using PoeHUD.Controllers;
using PoeHUD.Hud.UI;
using PoeHUD.Poe.Components;
using System.Collections.Generic;
using PoeHUD.EntitiesCache.CacheControllers;
using PoeHUD.EntitiesCache.CachedEntities;
using PoeHUD.EntitiesCache.CachedEntities.Base;
using PoeHUD.Hud.Icons.MapIcons;
using PoeHUD.Hud.Interfaces;
using PoeHUD.Models.Attributes;

namespace PoeHUD.Hud.Trackers
{
    public class PoiTracker : Plugin<PoiTrackerSettings>, IPluginWithMapIcons
    {
        private PoiIconsAreaCache _iconsCache;
        private static readonly List<string> masters = new List<string>
        {
            "Metadata/NPC/Missions/Wild/Dex",
            "Metadata/NPC/Missions/Wild/DexInt",
            "Metadata/NPC/Missions/Wild/Int",
            "Metadata/NPC/Missions/Wild/Str",
            "Metadata/NPC/Missions/Wild/StrDex",
            "Metadata/NPC/Missions/Wild/StrDexInt",
            "Metadata/NPC/Missions/Wild/StrInt"
        };

        private static readonly List<string> cadiro = new List<string>
        {
            "Metadata/NPC/League/Cadiro"
        };

        private static readonly List<string> perandus = new List<string>
        {
            "Metadata/Chests/PerandusChests/PerandusChestStandard",
            "Metadata/Chests/PerandusChests/PerandusChestRarity",
            "Metadata/Chests/PerandusChests/PerandusChestQuantity",
            "Metadata/Chests/PerandusChests/PerandusChestCoins",
            "Metadata/Chests/PerandusChests/PerandusChestJewellery",
            "Metadata/Chests/PerandusChests/PerandusChestGems",
            "Metadata/Chests/PerandusChests/PerandusChestCurrency",
            "Metadata/Chests/PerandusChests/PerandusChestInventory",
            "Metadata/Chests/PerandusChests/PerandusChestDivinationCards",
            "Metadata/Chests/PerandusChests/PerandusChestKeepersOfTheTrove",
            "Metadata/Chests/PerandusChests/PerandusChestUniqueItem",
            "Metadata/Chests/PerandusChests/PerandusChestMaps",
            "Metadata/Chests/PerandusChests/PerandusChestFishing",
            "Metadata/Chests/PerandusChests/PerandusManorUniqueChest",
            "Metadata/Chests/PerandusChests/PerandusManorCurrencyChest",
            "Metadata/Chests/PerandusChests/PerandusManorMapsChest",
            "Metadata/Chests/PerandusChests/PerandusManorJewelryChest",
            "Metadata/Chests/PerandusChests/PerandusManorDivinationCardsChest",
            "Metadata/Chests/PerandusChests/PerandusManorLostTreasureChest"
        };

        public PoiTracker(GameController gameController, Graphics graphics, PoiTrackerSettings settings)
            : base(gameController, graphics, settings)
        {
            EntityCache<ChestEntity>.OnEntityAdded += OnChestAdded;
            EntityCache<StrongboxEntity>.OnEntityAdded += OnStrongboxAdded;
            EntityCache<NpcEntity>.OnEntityAdded += OnNPCAdded;

            EntityCache<ChestEntity>.OnEntityRemoved += EntityRemoved;
            EntityCache<StrongboxEntity>.OnEntityRemoved += EntityRemoved;
            EntityCache<NpcEntity>.OnEntityRemoved += EntityRemoved;

            GameController.Area.AreaChange += delegate { _iconsCache = GameController.Area.CurrentArea.GetOrCreateDataContainer<PoiIconsAreaCache>(); };
        }

        private void EntityRemoved<T>(EntityRemovedArgs<T> entityRemovedArgs) where T : BaseWorldEntity
        {
            if (entityRemovedArgs.Destroyed)
            {
                _iconsCache.CurrentIcons.Remove(entityRemovedArgs.Entity);
            }
        }

        private void OnStrongboxAdded(EntityAddedArgs<StrongboxEntity> entityAddedArgs)
        {
            if (!Settings.Enable.Value)
            {
                return;
            }

            if (!Settings.Strongboxes.Value)
            {
                return;
            }

            if (!entityAddedArgs.IsNewEntity) //we gonna show it through all map
                return;

            var entity = entityAddedArgs.Entity;
            var icon = GetChestIcon(entity);

            if (null != icon)
            {
                _iconsCache.CurrentIcons[entity] = icon;
            }
        }

        private void OnNPCAdded(EntityAddedArgs<NpcEntity> npcAddedArgs)
        {
            if (!Settings.Masters.Value)
            {
                return;
            }

            if (!Settings.Enable.Value)
            {
                return;
            }

            if (!npcAddedArgs.IsNewEntity) //we gonna show it through all map
                return;

            var entity = npcAddedArgs.Entity;
            var icon = GetNpcIcon(entity);

            if (null != icon)
            {
                _iconsCache.CurrentIcons[entity] = icon;
            }
        }

        private MapIcon GetNpcIcon(NpcEntity entity)
        {
            if (masters.Contains(entity.Metadata))
            {
                return new NpcIcon(entity, "ms-cyan.png", () => Settings.Masters, Settings.MastersIcon);
            }

            if (cadiro.Contains(entity.Metadata))
            {
                return new NpcIcon(entity, "ms-green.png", () => Settings.Cadiro, Settings.CadiroIcon);
            }

            return null;
        }

        private void OnChestAdded(EntityAddedArgs<ChestEntity> chestAddedArgs)
        {
            if (!Settings.Enable.Value)
            {
                return;
            }

            if (!Settings.Chests.Value)
            {
                return;
            }

            if (!chestAddedArgs.IsNewEntity) //we gonna show it through all map
                return;

            var entity = chestAddedArgs.Entity;
            var icon = GetChestIcon(entity);

            if (null != icon)
            {
                _iconsCache.CurrentIcons[entity] = icon;
            }
        }

        [LegionLeagueAttribute] //LegionChests
        private ChestMapIcon GetChestIcon(ChestEntity entity)
        {
            Chest chest = entity.GetComponent<Chest>();
            var metadata = entity.Metadata;

            if (perandus.Contains(metadata))
            {
                return new ChestMapIcon(entity, new HudTexture("strongbox.png", Settings.PerandusChestColor), () => Settings.PerandusChest,
                    Settings.PerandusChestIconSize);
            }

            if (!chest.IsOpened)
            {
                if (metadata.Contains("BreachChest"))
                {
                    return new ChestMapIcon(entity, new HudTexture("strongbox.png", Settings.BreachChestColor), () => Settings.BreachChest,
                        Settings.BreachChestIcon);
                }

                if (metadata.StartsWith("Metadata/Chests/LegionChests"))
                {
                    // Parse Legion Chests
                    if (metadata.Contains("EpicNoCrystal"))
                    {
                        // epic Legion chests with no crystal
                        return new ChestMapIcon(entity, new HudTexture("strongbox.png", Settings.LegionEpicNoCrystalChestColor),
                            () => Settings.LegionChest, Settings.LegionEpicNoCrystalChestIcon);
                    }

                    if (metadata.Contains("Epic"))
                    {
                        // Epic Legion chests (with a crystal?)
                        return new ChestMapIcon(entity, new HudTexture("strongbox.png", Settings.LegionEpicChestColor), () => Settings.LegionChest,
                            Settings.LegionEpicChestIcon);
                    }

                    if (metadata.Contains("NoCrystal"))
                    {
                        // Legion chests with no crystal
                        return new ChestMapIcon(entity, new HudTexture("strongbox.png", Settings.LegionNoCrystalChestColor),
                            () => Settings.LegionChest,
                            Settings.LegionNoCrystalChestIcon);
                    }

                    // Legion chests (with a crystal?)
                    return new ChestMapIcon(entity, new HudTexture("strongbox.png", Settings.LegionChestColor), () => Settings.LegionChest,
                        Settings.LegionChestIcon);
                }

                if (metadata == "Metadata/Chests/Prophecy/Divination") //From prophecy The Fortune Teller's Collection
                {
                    return new ChestMapIcon(entity, new HudTexture("strongboxes/chest_divination.png",
                        entity.GetComponent<ObjectMagicProperties>().Rarity), () => Settings.Strongboxes, Settings.StrongboxesIconSize);
                }

                if (chest.IsStrongbox)
                {
                    var chestIcon = "chest.png";

                    switch (metadata)
                    {
                        case "Metadata/Chests/StrongBoxes/StrongboxDivination":
                            chestIcon = "chest_divination.png";
                            break;
                        case "Metadata/Chests/StrongBoxes/Ornate":
                            chestIcon = "chest_ornate.png";
                            break;
                        case "Metadata/Chests/StrongBoxes/Large":
                            chestIcon = "chest_large.png";
                            break;
                        case "Metadata/Chests/StrongBoxes/Jeweller":
                            chestIcon = "chest_jewelers.png";
                            break;
                        case "Metadata/Chests/StrongBoxes/Gemcutter":
                            chestIcon = "chest_gemscutter.png";
                            break;
                        case "Metadata/Chests/StrongBoxes/Artisan":
                            chestIcon = "chest_quality.png";
                            break;
                        case "Metadata/Chests/StrongBoxes/Armory":
                            chestIcon = "chest_weapon.png";
                            break;
                        default:

                            if (metadata.StartsWith("Metadata/Chests/StrongBoxes/Cartographer"))
                                chestIcon = "chest_map.png";
                            else if (metadata.StartsWith("Metadata/Chests/StrongBoxes/Arcanist"))
                                chestIcon = "chest_no_quality.png";

                            break;
                    }

                    return new ChestMapIcon(entity, new HudTexture("strongboxes/" + chestIcon,
                        entity.GetComponent<ObjectMagicProperties>().Rarity), () => Settings.Strongboxes, Settings.StrongboxesIconSize);
                }

                return new ChestMapIcon(entity, new HudTexture("chest.png"), () => Settings.Chests, Settings.ChestsIcon);
            }

            return null;
        }

        public override void Render()
        {
            
        }

        public IEnumerable<MapIcon> GetIcons()
        {
            return _iconsCache.CurrentIcons.Values;
        }
    }

    //this class have identical content with all classes related to icons caching..
    //buw we cannot use it for all of them due to better performance (each plugin should have own class to not put all entities to the same collection)
    public class PoiIconsAreaCache
    {
        public Dictionary<BaseWorldEntity, MapIcon> CurrentIcons = new Dictionary<BaseWorldEntity, MapIcon>();
    }
}
