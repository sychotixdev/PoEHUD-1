using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using PoeHUD.Controllers;
using PoeHUD.EntitiesCache.CacheControllers;
using PoeHUD.EntitiesCache.CachedEntities;
using PoeHUD.EntitiesCache.CachedEntities.Base;
using PoeHUD.Framework.Helpers;
using PoeHUD.Hud.Icons.MapIcons;
using PoeHUD.Hud.Interfaces;
using PoeHUD.Hud.Preload;
using PoeHUD.Hud.UI;
using PoeHUD.Models;
using PoeHUD.Models.Enums;
using PoeHUD.Plugins;
using PoeHUD.Poe.Components;
using SharpDX;
using SharpDX.Direct3D9;

namespace PoeHUD.Hud.Trackers
{
    public class MonsterTracker : Plugin<MonsterTrackerSettings>, IPluginWithMapIcons
    {
        private const string MOD_ALERTS = "config/monster_mod_alerts.txt";
        private const string MOD_ALERTS_PERSONAL = "config/monster_mod_alerts_personal.txt";
        private const string TYPE_ALERTS = "config/monster_name_alerts.txt";
        private const string TYPE_ALERTS_PERSONAL = "config/monster_name_alerts_personal.txt";

        private static readonly List<string> IgnoreEntitiesList = new List<string>
        {
            "GoddessOfJustice",
            "MonsterFireTrap2",
            "MonsterBlastRainTrap",
            "Metadata/Monsters/Frog/FrogGod/SilverOrb",
            "Metadata/Monsters/Frog/FrogGod/SilverPool"
        };

        private readonly Dictionary<MonsterEntity, MonsterConfigLine> alertTexts;
        private readonly HashSet<long> alreadyAlertedOf;
        private readonly Dictionary<MonsterRarity, Func<MonsterEntity, Func<string, string>, CreatureMapIcon>> iconCreators;
        private readonly Dictionary<string, MonsterConfigLine> modAlerts, typeAlerts;
        private MonsterIconsAreaCache _iconsCache;

        private readonly string[] HiddenIcons =
        {
            "ms-red-gray.png", //White     
            "ms-blue-gray.png", //Magic
            "ms-yellow-gray.png", //Rare
            "ms-purple-gray.png" //Uniq
        };

        public MonsterTracker(GameController gameController, Graphics graphics, MonsterTrackerSettings settings)
            : base(gameController, graphics, settings)
        {
            alreadyAlertedOf = new HashSet<long>();
            alertTexts = new Dictionary<MonsterEntity, MonsterConfigLine>();
            modAlerts = LoadConfig(MOD_ALERTS);
            typeAlerts = LoadConfig(TYPE_ALERTS);

            if (File.Exists(MOD_ALERTS_PERSONAL))
                modAlerts = modAlerts.MergeLeft(LoadConfig(MOD_ALERTS_PERSONAL));
            else
                File.WriteAllText(MOD_ALERTS_PERSONAL, string.Empty);

            if (File.Exists(TYPE_ALERTS_PERSONAL))
                typeAlerts = typeAlerts.MergeLeft(LoadConfig(TYPE_ALERTS_PERSONAL));
            else
                File.WriteAllText(TYPE_ALERTS_PERSONAL, string.Empty);

            iconCreators = new Dictionary<MonsterRarity, Func<MonsterEntity, Func<string, string>, CreatureMapIcon>>
            {
                {MonsterRarity.White, (e, f) => new CreatureMapIcon(e, f("ms-red.png"), () => Settings.Monsters, settings.WhiteMobIcon)},
                {MonsterRarity.Magic, (e, f) => new CreatureMapIcon(e, f("ms-blue.png"), () => Settings.Monsters, settings.MagicMobIcon)},
                {MonsterRarity.Rare, (e, f) => new CreatureMapIcon(e, f("ms-yellow.png"), () => Settings.Monsters, settings.RareMobIcon)},
                {MonsterRarity.Unique, (e, f) => new CreatureMapIcon(e, f("ms-purple.png"), () => Settings.Monsters, settings.UniqueMobIcon)}
            };

            GameController.Area.AreaChange += area =>
            {
                alreadyAlertedOf.Clear();
                alertTexts.Clear();
            };

            MonstersController.OnEntityAdded += OnOnEntityAdded;
            MonstersController.OnEntityRemoved += OnOnEntityRemoved;
            MonstersController.OnMonsterDeath += OnOnMonsterDeath;
            GameController.Area.AreaChange += delegate { _iconsCache = GameController.Area.CurrentArea.GetOrCreateDataContainer<MonsterIconsAreaCache>(); };
        }

        public Dictionary<string, MonsterConfigLine> LoadConfig(string path)
        {
            return LoadConfigBase(path, 5).ToDictionary(line => line[0], line =>
            {
                var monsterConfigLine = new MonsterConfigLine
                {
                    Text = line[1],
                    SoundFile = line.ConfigValueExtractor(2),
                    Color = line.ConfigColorValueExtractor(3),
                    MinimapIcon = line.ConfigValueExtractor(4)
                };

                if (monsterConfigLine.SoundFile != null)
                    Sounds.AddSound(monsterConfigLine.SoundFile);

                return monsterConfigLine;
            });
        }

        public override void Render()
        {
            try
            {
                if (!Settings.Enable || !Settings.ShowText)
                    return;

                var rect = GameController.Window.GetWindowRectangle();
                var xPos = rect.Width * Settings.TextPositionX * 0.01f + rect.X;
                var yPos = rect.Height * Settings.TextPositionY * 0.01f + rect.Y;

                var playerPos = PlayerInfo.GridPos;
                var first = true;
                var rectBackground = new RectangleF();

                var groupedAlerts = alertTexts.Where(y => y.Key.IsAlive && y.Key.IsHostile).Select(y =>
                    {
                        var delta = y.Key.GridPos - playerPos;
                        double phi;
                        var distance = delta.GetPolarCoordinates(out phi);
                        return new {Dic = y, Phi = phi, Distance = distance};
                    })
                    .OrderBy(y => y.Distance)
                    .GroupBy(y => y.Dic.Value)
                    .Select(y => new {y.Key.Text, y.Key.Color, Monster = y.First(), Count = y.Count()}).ToList();

                foreach (var group in groupedAlerts)
                {
                    var uv = GetDirectionsUV(group.Monster.Phi, group.Monster.Distance);
                    var text = $"{group.Text} {(group.Count > 1 ? "(" + group.Count + ")" : string.Empty)}";
                    var color = group.Color ?? Settings.DefaultTextColor;
                    var textSize = Graphics.DrawText(text, Settings.TextSize, new Vector2(xPos, yPos), color, FontDrawFlags.Center);

                    rectBackground = new RectangleF(xPos - 30 - textSize.Width / 2f - 6, yPos, 80 + textSize.Width, textSize.Height);
                    rectBackground.X -= textSize.Height + 3;
                    rectBackground.Width += textSize.Height;

                    var rectDirection = new RectangleF(rectBackground.X + 3, rectBackground.Y, rectBackground.Height, rectBackground.Height);

                    if (first) // vertical padding above
                    {
                        rectBackground.Y -= 2;
                        rectBackground.Height += 5;
                        first = false;
                    }

                    Graphics.DrawImage("preload-start.png", rectBackground, Settings.BackgroundColor);
                    Graphics.DrawImage("directions.png", rectDirection, uv, color);
                    yPos += textSize.Height;
                }

                if (!first) // vertical padding below
                {
                    rectBackground.Y = rectBackground.Y + rectBackground.Height;
                    rectBackground.Height = 5;
                    Graphics.DrawImage("preload-start.png", rectBackground, Settings.BackgroundColor);
                }
            }
            catch
            {
                // do nothing
            }
        }

        private void OnOnEntityAdded(EntityAddedArgs<MonsterEntity> entityAddedArgs)
        {
            if (!Settings.Enable)
                return;

            if (!entityAddedArgs.IsNewEntity)
                return;

            var entity = entityAddedArgs.Entity;

            if (!entity.IsAlive)
                return;

            if (alertTexts.ContainsKey(entity))
                return;
            
            var entityMetadata = entity.Metadata;

            MonsterConfigLine monsterConfigLine = null;

            if (typeAlerts.ContainsKey(entityMetadata))
            {
                monsterConfigLine = typeAlerts[entityMetadata];
                AlertHandler(monsterConfigLine, entity);
            }
            else
            {
                var modAlert = entity.GetComponent<ObjectMagicProperties>().Mods.FirstOrDefault(x => modAlerts.ContainsKey(x));

                if (modAlert != null)
                {
                    monsterConfigLine = modAlerts[modAlert];
                    AlertHandler(monsterConfigLine, entity);
                }
            }

            var mapIcon = GetMapIconForMonster(entity, monsterConfigLine);

            if (mapIcon != null)
            {
                //BasePlugin.LogMessage($"Added icon: {mapIcon.TextureIcon.FileName}", 4);  //I'll leave it for debug
                _iconsCache.CurrentIcons[entity] = mapIcon;
            }
        }

        private void OnOnMonsterDeath(MonsterDeathArgs monsterDeathArgs)
        {
            alertTexts.Remove(monsterDeathArgs.Entity);
            if (_iconsCache.CurrentIcons.Remove(monsterDeathArgs.Entity))
            {
                //BasePlugin.LogMessage($"removed icon: {monsterDeathArgs.Entity.Name}", 4);  //I'll leave it for debug
            }
        }

        private void OnOnEntityRemoved(EntityRemovedArgs<MonsterEntity> entityRemovedArgs)
        {
            if (entityRemovedArgs.Destroyed)
            {
                alertTexts.Remove(entityRemovedArgs.Entity);
                _iconsCache.CurrentIcons.Remove(entityRemovedArgs.Entity);
            }
        }

        private void AlertHandler(MonsterConfigLine monsterConfigLine, MonsterEntity entity)
        {
            alertTexts.Add(entity, monsterConfigLine);
            PlaySound(entity, monsterConfigLine.SoundFile);
        }

        private CreatureMapIcon GetMapIconForMonster(MonsterEntity entity, MonsterConfigLine monsterConfigLine)
        {
            // If ignored entity found, skip
            foreach (var _entity in IgnoreEntitiesList)
            {
                if (entity.Metadata.Contains(_entity))
                    return null;
            }

            if (!entity.IsHostile)
                return new CreatureMapIcon(entity, "ms-cyan.png", () => Settings.Minions, Settings.MinionsIcon);

            var monsterRarity = entity.GetComponent<ObjectMagicProperties>().Rarity;

            var isHiddenMonster = entity.HasBuff("hidden_monster");
            string overrideIcon = null;
            if (isHiddenMonster)
            {
                overrideIcon = HiddenIcons[(int) monsterRarity];
            }

            var icon = iconCreators.TryGetValue(monsterRarity, out var iconCreator)
                ? iconCreator(entity, text => monsterConfigLine?.MinimapIcon ?? overrideIcon ?? text)
                : null;

            if (isHiddenMonster && icon != null)
                icon.CheckHiddenMonster = true;
            return icon;
        }

        private void PlaySound(MonsterEntity entity, string soundFile)
        {
            if (Settings.PlaySound && !alreadyAlertedOf.Contains(entity.Id))
            {
                if (!string.IsNullOrEmpty(soundFile))
                    Sounds.GetSound(soundFile).Play(Settings.SoundVolume);

                alreadyAlertedOf.Add(entity.Id);
            }
        }
        
        public IEnumerable<MapIcon> GetIcons()
        {
            return _iconsCache.CurrentIcons.Values;
        }
    }

    //this class have identical content with all classes related to icons caching..
    //buw we cannot use it for all of them due to better performance (each plugin should have own class to not put all entities to the same collection)
    public class MonsterIconsAreaCache
    {
        public Dictionary<BaseWorldEntity, MapIcon> CurrentIcons = new Dictionary<BaseWorldEntity, MapIcon>();
    }
}
