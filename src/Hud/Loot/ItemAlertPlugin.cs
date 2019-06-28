using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Antlr4.Runtime;
using PoeFilterParser;
using PoeFilterParser.Model;
using PoeHUD.Controllers;
using PoeHUD.EntitiesCache.CacheControllers;
using PoeHUD.EntitiesCache.CachedEntities;
using PoeHUD.EntitiesCache.CachedEntities.Base;
using PoeHUD.Framework;
using PoeHUD.Framework.Helpers;
using PoeHUD.Hud.Icons.MapIcons;
using PoeHUD.Hud.Interfaces;
using PoeHUD.Hud.Settings;
using PoeHUD.Hud.UI;
using PoeHUD.Models.Enums;
using PoeHUD.Plugins;
using PoeHUD.Poe.Components;
using PoeHUD.Poe.RemoteMemoryObjects;
using SharpDX;
using SharpDX.Direct3D9;

namespace PoeHUD.Hud.Loot
{
    public class ItemAlertPlugin : SizedPluginWithMapIcons<ItemAlertSettings>, IPluginWithMapIcons
    {
        public static PoeFilterVisitor visitor;
        public static bool holdKey;
        private readonly HashSet<CraftingBase> craftingBases;
        private readonly HashSet<string> currencyNames;
        private readonly HashSet<long> playedSoundsCache;
        private readonly SettingsHub settingsHub;
        private Dictionary<long, LabelOnGround> currentLabels;
        private readonly Dictionary<WorldItemEntity, AlertDrawStyle> _currentAlerts;
        private ItemsIconsAreaCache _iconsCache;

        public ItemAlertPlugin(GameController gameController, Graphics graphics, ItemAlertSettings settings, SettingsHub settingsHub)
            : base(gameController, graphics, settings)
        {
            this.settingsHub = settingsHub;
            playedSoundsCache = new HashSet<long>();
            currentLabels = new Dictionary<long, LabelOnGround>();
            _currentAlerts = new Dictionary<WorldItemEntity, AlertDrawStyle>();
            currencyNames = LoadCurrency();
            craftingBases = LoadCraftingBases();
            GameController.Area.AreaChange += OnAreaChange;
            PoeFilterInit(settings.FilePath);
            settings.FilePath.OnFileChanged += () => PoeFilterInit(settings.FilePath);
            EntityCache<WorldItemEntity>.OnEntityAdded += OnEntityAdded;
            EntityCache<WorldItemEntity>.OnEntityRemoved += OnEntityRemoved;

            GameController.Area.AreaChange += delegate { _iconsCache = GameController.Area.CurrentArea.GetOrCreateDataContainer<ItemsIconsAreaCache>(); };
        }

        private void PoeFilterInit(string path)
        {
            try
            {
                if (!string.IsNullOrEmpty(path))
                {
                    DebugPlugin.DebugPlugin.LogMsg("Loading the Filter File", 4);

                    using (var fileStream = new StreamReader(path))
                    {
                        var input = new AntlrInputStream(fileStream.ReadToEnd());
                        var lexer = new PoeFilterLexer(input);
                        var tokens = new CommonTokenStream(lexer);
                        var parser = new PoeFilterParser.Model.PoeFilterParser(tokens);
                        parser.RemoveErrorListeners();
                        parser.AddErrorListener(new ErrorListener());
                        var tree = parser.main();
                        visitor = new PoeFilterVisitor(tree, GameController, Settings);
                    }
                }
                else
                    Settings.ShouldUseFilterFile.Value = false;
            }
            catch (SyntaxErrorException ex)
            {
                Settings.FilePath.Value = string.Empty;
                Settings.ShouldUseFilterFile.Value = false;

                MessageBox.Show($"Line: {ex.Line}:{ex.CharPositionInLine}, " +
                                $"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                visitor = null;
            }
            catch (Exception ex)
            {
                Settings.FilePath.Value = string.Empty;
                Settings.ShouldUseFilterFile.Value = false;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void Dispose()
        {
            GameController.Area.AreaChange -= OnAreaChange;
        }

        public override void Render()
        {
            if (!holdKey && WinApi.IsKeyDown(Keys.F10))
            {
                holdKey = true;
                Settings.Enable.Value = !Settings.Enable.Value;
                SettingsHub.Save(settingsHub);
            }
            else if (holdKey && !WinApi.IsKeyDown(Keys.F10))
                holdKey = false;

            if (!Settings.Enable)
                return;

            if (Settings.Enable)
            {
                var playerPos = PlayerInfo.GridPos;
                var position = StartDrawPointFunc();
                const int BOTTOM_MARGIN = 2;
                var shouldUpdate = false;

                foreach (var kv in _currentAlerts)
                {
                    if (string.IsNullOrEmpty(kv.Value.Text))
                        continue;

                    if (!currentLabels.TryGetValue(kv.Key.Address, out var entityLabel))
                        shouldUpdate = true;
                    else
                    {
                        if (Settings.BorderSettings.Enable)
                            DrawBorder(entityLabel);
                       
                        if (Settings.ShowText)
                        {
                            if (entityLabel.CanPickUp || entityLabel.MaxTimeForPickUp.TotalSeconds == 0)
                                position = DrawText(playerPos, position, BOTTOM_MARGIN, kv, kv.Value.Text);
                            else if (!Settings.HideOthers)
                            {
                                // get current values
                                var textColor = kv.Value.TextColor;
                                var borderColor = kv.Value.BorderColor;
                                var backgroundColor = kv.Value.BackgroundColor;

                                if (Settings.DimOtherByPercentToggle)
                                {
                                    // edit values to new ones
                                    var reduceByPercent = (double) Settings.DimOtherByPercent / 100;

                                    textColor = ReduceNumbers(textColor, reduceByPercent);
                                    borderColor = ReduceNumbers(borderColor, reduceByPercent);
                                    backgroundColor = ReduceNumbers(backgroundColor, reduceByPercent);

                                    // backgrounds with low alpha start to look a little strange when dark so im adding an alpha threshold
                                    if (backgroundColor.A < 210)
                                        backgroundColor.A = 210;
                                }

                                // Complete new KeyValuePair with new stuff
                                var modifiedDrawStyle = new AlertDrawStyle(kv.Value.Text, textColor, kv.Value.BorderWidth, borderColor,
                                    backgroundColor, kv.Value.IconIndex);

                                var newKv = new KeyValuePair<WorldItemEntity, AlertDrawStyle>(kv.Key, modifiedDrawStyle);

                                position = DrawText(playerPos, position, BOTTOM_MARGIN, newKv, kv.Value.Text);
                            }
                        }
                    }
                }

                Size = new Size2F(0, position.Y); //bug absent width

                if (shouldUpdate)
                {
                    currentLabels.Clear();
                    var labels = GameController.Game.InGameState.InGameUi.ItemsOnGroundLabels?.ToList();

                    if (labels != null && labels.Count > 0)//fixed exception on Exit to character selection
                    {
                        currentLabels = labels.GroupBy(y => y.ItemOnGround.Address).ToDictionary(y => y.Key, y => y.First());
                    }
                }
            }
        }

        private Color ReduceNumbers(Color oldColor, double percent)
        {
            var newColor = oldColor;

            newColor.R = (byte) (oldColor.R - oldColor.R * percent);
            newColor.G = (byte) (oldColor.G - oldColor.G * percent);
            newColor.B = (byte) (oldColor.B - oldColor.B * percent);
            newColor.A = (byte) (oldColor.A - (double) oldColor.A / 10 * percent);

            return newColor;
        }

        private Vector2 DrawText(Vector2 playerPos, Vector2 position, int BOTTOM_MARGIN,
            KeyValuePair<WorldItemEntity, AlertDrawStyle> kv, string text)
        {
            var padding = new Vector2(5, 2);
            var delta = kv.Key.GridPos - playerPos;
            var itemSize = DrawItem(kv.Value, delta, position, padding, text);

            if (itemSize != new Vector2())
                position.Y += itemSize.Y + BOTTOM_MARGIN;

            return position;
        }

        private void OnEntityRemoved(EntityRemovedArgs<WorldItemEntity> removedArgs)
        {
            currentLabels.Remove(removedArgs.Entity.Address);

            if (removedArgs.Destroyed)
            {
                _iconsCache.CurrentIcons.Remove(removedArgs.Entity);
            }
        }

        private void OnEntityAdded(EntityAddedArgs<WorldItemEntity> entityAddedArgs)
        {
            if (!entityAddedArgs.IsNewEntity)
            {
                return;
            }

            var entity = entityAddedArgs.Entity;

            var item = entity.GetComponent<WorldItem>().ItemEntity;

            if (Settings.ShouldUseFilterFile && !string.IsNullOrEmpty(Settings.FilePath))
            {
                var drawStyle = visitor.Visit(item);

                if (drawStyle != null)
                {
                    PrepareForDrawingAndPlaySound(entity, drawStyle);
                }
            }
            else
            {
                var props = GetUsefulProperties(item);

                if (props != null)
                {
                    if (props.ShouldAlert(currencyNames, Settings))
                    {
                        var drawStyle = props.GetDrawStyle();
                        PrepareForDrawingAndPlaySound(entity, drawStyle);
                    }

                    Settings.ShouldUseFilterFile.Value = false;
                }
            }
        }

        private void PrepareForDrawingAndPlaySound(WorldItemEntity entity, AlertDrawStyle drawStyle)
        {
            _currentAlerts.Add(entity, drawStyle);
            var mapIcon = new MapIcon(entity,
                new HudTexture("currency.png", Settings.LootIconBorderColor ? drawStyle.BorderColor : drawStyle.TextColor),
                () => Settings.ShowItemOnMap, Settings.LootIcon);

            _iconsCache.CurrentIcons[entity] = mapIcon;

            if (Settings.PlaySound && !playedSoundsCache.Contains(entity.Id))
            {
                playedSoundsCache.Add(entity.Id);
                Sounds.AlertSound.Play(Settings.SoundVolume);
            }
        }

        private ItemUsefulProperties GetUsefulProperties(ItemEntity item)
        {
            var bit = GameController.Files.BaseItemTypes.Translate(item.Metadata);

            if (bit == null)
                return null;

            var name = bit.BaseName;
            var craftingBase = new CraftingBase();

            if (Settings.Crafting)
            {
                foreach (var cb in craftingBases
                    .Where(cb => cb.Name
                                     .Equals(name, StringComparison.InvariantCultureIgnoreCase) || new Regex(cb.Name)
                                     .Match(name).Success))
                {
                    craftingBase = cb;
                    break;
                }
            }

            return new ItemUsefulProperties(name, item, craftingBase);
        }

        private static HashSet<CraftingBase> LoadCraftingBases()
        {
            if (!File.Exists("config/crafting_bases.txt"))
                return new HashSet<CraftingBase>();

            var hashSet = new HashSet<CraftingBase>();
            var parseErrors = new List<string>();
            var array = File.ReadAllLines("config/crafting_bases.txt");

            foreach (var text in array.Select(x => x.Trim()).Where(x => !string.IsNullOrWhiteSpace(x) && !x.StartsWith("#")))
            {
                var parts = text.Split(',');
                var itemName = parts[0].Trim();

                var item = new CraftingBase {Name = itemName};

                int tmpVal;

                if (parts.Length > 1 && int.TryParse(parts[1], out tmpVal))
                    item.MinItemLevel = tmpVal;

                if (parts.Length > 2 && int.TryParse(parts[2], out tmpVal))
                    item.MinQuality = tmpVal;

                const int RARITY_POSITION = 3;

                if (parts.Length > RARITY_POSITION)
                {
                    item.Rarities = new ItemRarity[parts.Length - 3];

                    for (var i = RARITY_POSITION; i < parts.Length; i++)
                    {
                        if (item.Rarities != null && !Enum.TryParse(parts[i], true, out item.Rarities[i - RARITY_POSITION]))
                        {
                            parseErrors.Add("Incorrect rarity definition at line: " + text);
                            item.Rarities = null;
                        }
                    }
                }

                if (!hashSet.Add(item))
                    parseErrors.Add("Duplicate definition for item was ignored: " + text);
            }

            if (parseErrors.Any())
                throw new Exception("Error parsing config/crafting_bases.txt\r\n" + string.Join(Environment.NewLine, parseErrors));

            return hashSet;
        }

        private static HashSet<string> LoadCurrency()
        {
            if (!File.Exists("config/currency.txt"))
                return null;

            var hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var lines = File.ReadAllLines("config/currency.txt");
            lines.Where(x => !string.IsNullOrWhiteSpace(x) && !x.StartsWith("#")).ForEach(x => hashSet.Add(x.Trim().ToLowerInvariant()));
            return hashSet;
        }

        private void DrawBorder(LabelOnGround entityLabel)
        {
            if (entityLabel == null)
            {
                return;//sometimes this happen while picking item
            }

            var ui = GameController.Game.InGameState.InGameUi;

            if (entityLabel.IsVisible)
            {
                var rect = entityLabel.Label.GetClientRect();

                if (ui.OpenLeftPanel.IsVisible && ui.OpenLeftPanel.GetClientRect().Intersects(rect) ||
                    ui.OpenRightPanel.IsVisible && ui.OpenRightPanel.GetClientRect().Intersects(rect))
                    return;

                var borderColor = Settings.BorderSettings.BorderColor;

                if (!entityLabel.CanPickUp)
                {
                    borderColor = Settings.BorderSettings.NotMyItemBorderColor;
                    var timeLeft = entityLabel.TimeLeft;

                    if (Settings.BorderSettings.ShowTimer && timeLeft.TotalMilliseconds > 0)
                    {
                        borderColor = Settings.BorderSettings.CantPickUpBorderColor;
                        Graphics.DrawText(timeLeft.ToString(@"mm\:ss"), Settings.BorderSettings.TimerTextSize, rect.TopRight.Translate(4, 0));
                    }
                }

                Graphics.DrawFrame(rect, Settings.BorderSettings.BorderWidth, borderColor);
            }
        }

        private Vector2 DrawItem(AlertDrawStyle drawStyle, Vector2 delta, Vector2 position, Vector2 padding, string text)
        {
            padding.X -= drawStyle.BorderWidth;
            padding.Y -= drawStyle.BorderWidth;
            double phi;
            var distance = delta.GetPolarCoordinates(out phi);
            float compassOffset = Settings.TextSize + 8;
            var textPos = position.Translate(-padding.X - compassOffset, padding.Y);
            var textSize = Graphics.DrawText(text, Settings.TextSize, textPos, drawStyle.TextColor, FontDrawFlags.Right);

            if (textSize == new Size2())
                return new Vector2();

            var iconSize = drawStyle.IconIndex >= 0 ? textSize.Height : 0;
            var fullHeight = textSize.Height + 2 * padding.Y + 2 * drawStyle.BorderWidth;
            var fullWidth = textSize.Width + 2 * padding.X + iconSize + 2 * drawStyle.BorderWidth + compassOffset;
            var boxRect = new RectangleF(position.X - fullWidth, position.Y, fullWidth - compassOffset, fullHeight);
            Graphics.DrawBox(boxRect, drawStyle.BackgroundColor);

            var rectUV = GetDirectionsUV(phi, distance);

            var rectangleF = new RectangleF(position.X - padding.X - compassOffset + 6, position.Y + padding.Y,
                textSize.Height, textSize.Height);

            Graphics.DrawImage("directions.png", rectangleF, rectUV);

            if (iconSize > 0)
            {
                const float ICONS_IN_SPRITE = 4;
                var iconPos = new RectangleF(textPos.X - iconSize - textSize.Width, textPos.Y, iconSize, iconSize);
                var iconX = drawStyle.IconIndex / ICONS_IN_SPRITE;
                var uv = new RectangleF(iconX, 0, (drawStyle.IconIndex + 1) / ICONS_IN_SPRITE - iconX, 1);
                Graphics.DrawImage("item_icons.png", iconPos, uv);
            }

            if (drawStyle.BorderWidth > 0)
                Graphics.DrawFrame(boxRect, drawStyle.BorderWidth, drawStyle.BorderColor);

            return new Vector2(fullWidth, fullHeight);
        }

        private void OnAreaChange(AreaController area)
        {
            playedSoundsCache.Clear();
            currentLabels.Clear();
            _currentAlerts.Clear();
        }

        public IEnumerable<MapIcon> GetIcons()
        {
            return _iconsCache.CurrentIcons.Values;
        }
    }

    //this class have identical content with all classes related to icons caching..
    //buw we cannot use it for all of them due to better performance (each plugin should have own class to not put all entities to the same collection)
    public class ItemsIconsAreaCache
    {
        public Dictionary<BaseWorldEntity, MapIcon> CurrentIcons = new Dictionary<BaseWorldEntity, MapIcon>();
    }
}
