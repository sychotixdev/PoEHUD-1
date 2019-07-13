using System;
using System.Collections.Generic;
using PoeHUD.Controllers;
using PoeHUD.EntitiesCache.CacheControllers;
using PoeHUD.EntitiesCache.CachedEntities;
using PoeHUD.EntitiesCache.CachedEntities.Base;
using PoeHUD.EntitiesCache.ComponentsCache;
using PoeHUD.Framework;
using PoeHUD.Hud.DebugPlugin;
using PoeHUD.Poe;
using PoeHUD.Poe.Components;
using SharpDX;

namespace PoeHUD.EntitiesCache
{
    public class EntitiesAreaCache
    {
        public static EntitiesAreaCache Current { get; internal set; }
        internal event Action OnEntitiesClear = delegate { };
        private uint _scanNumber;
        public readonly Dictionary<uint, BaseWorldEntity> AllEntities;
        public readonly EntityCache<AreaTransitionEntity> AreaTransitions;
        public readonly EntityCache<DangerEntity> DangerEntities;
        public readonly EntityCache<ChestEntity> Chests;
        public readonly EntityCache<DelveVeinEntity> DelveVeins;
        public readonly EntityCache<DoorEntity> Doors;
        public readonly EntityCache<NpcEntity> Npc;
        public readonly EntityCache<PortalEntity> Portals;
        public readonly EntityCache<ShrineEntity> Shrines;
        public readonly EntityCache<StrongboxEntity> Strongboxes;
        public readonly EntityCache<PlayerEntity> Players;
        public readonly WorldItemsController WorldItems;
        public readonly MonstersController Monsters;

        internal EntitiesAreaCache()
        {
            AllEntities = new Dictionary<uint, BaseWorldEntity>();
            AreaTransitions = new EntityCache<AreaTransitionEntity>(this);
            DangerEntities = new EntityCache<DangerEntity>(this);
            Chests = new EntityCache<ChestEntity>(this);
            DelveVeins = new EntityCache<DelveVeinEntity>(this);
            Doors = new EntityCache<DoorEntity>(this);
            Monsters = new MonstersController(this);
            Npc = new EntityCache<NpcEntity>(this);
            Portals = new EntityCache<PortalEntity>(this);
            Shrines = new EntityCache<ShrineEntity>(this);
            Strongboxes = new EntityCache<StrongboxEntity>(this);
            Players = new EntityCache<PlayerEntity>(this);
            WorldItems = new WorldItemsController(this);
        }

        /// <summary>
        /// Clears the entities cache. I do not recommend to use this function, I'm just adding a possibility to clear cache in correct way 
        /// </summary>
        /// <param name="callDestroyedEvent">If true will call OnEntityRemoved events in all plugins (recommended).</param>
        internal void ClearEntitiesCache(bool callDestroyedEvent = true)
        {
            if (callDestroyedEvent)
            {
                foreach (var baseWorldEntity in AllEntities)
                {
                    baseWorldEntity.Value.IsRemovedFromSpecialCachedCollections = true;
                    baseWorldEntity.Value.OwnerEntityController.EntityDestroyed(baseWorldEntity.Value);
                }
            }

            AllEntities.Clear();
            OnEntitiesClear();
        }

        internal void UpdateCache()
        {
            _scanNumber++;

            if (_scanNumber == uint.MaxValue)
                _scanNumber = 0;

            PlayerInfo.UpdateInfo();

            var game = GameController.Instance.Game;

            foreach (var keyValuePair in game.InGameState.Data.EntityList.EntitiesDictionary)
            {
                var entityAddress = keyValuePair.Value;
                var entityId = Memory.Instance.ReadUInt(entityAddress + 0x40);
                var metadataAddress = Memory.Instance.ReadLong(entityAddress, 0x18);
                var entityMetadataPath = Memory.Instance.ReadStringU(metadataAddress);

                if (string.IsNullOrEmpty(entityMetadataPath))
                    continue;

                //"Metadata/Effects/Spells/monsters_effects/elemental_beacon_v2/fire/OTs/beacon"
                //"Metadata/Effects/Spells/monsters_effects/elemental_beacon_v2/fire/OTs/beacon_aoe"
                //if (entityMetadataPath.StartsWith("Metadata/Effects/Spells/monsters_effects/elemental_beacon_v2/"))
                //{
                //    if (entityMetadataPath.Contains("/OTs/beacon_aoe"))
                //    {
                //        if (!DangerEntities.TryGetValue(id, out var mine))
                //        {
                //            mine = new CachedDangerEntity(entity, _scanNumber, false, false, 70);

                //            //LogWarning($"Found aoe mine: {mine.Metadata}");
                //            DangerEntities.TryAdd(id, mine);
                //        }
                //    }
                //}

                if ((entityId & 0x80000000L) != 0L || entityMetadataPath.StartsWith("Metadata/Monsters/Daemon"))
                    continue;

                if (AllEntities.TryGetValue(keyValuePair.Key, out var cachedEntity))
                {
                    if (!cachedEntity.IsRemovedFromSpecialCachedCollections && cachedEntity.RemoveFromSpecialCachedCollections())
                    {
                        cachedEntity.IsRemovedFromSpecialCachedCollections = true;

                        cachedEntity.OwnerEntityController
                            ?.EntityDestroyed(cachedEntity); //OwnerEntityController can be null for filtered out entities
                    }
                    else
                    {
                        cachedEntity.Appear(_scanNumber, entityAddress);
                    }

                    continue;
                }

                var newWorldEntityParams = new NewWorldEntityParams(entityId, entityAddress, entityMetadataPath, metadataAddress, _scanNumber);

                //Metadata/Terrain/Leagues/Delve/Objects/DelveMineralVein
                //Metadata/Terrain/Leagues/Delve/Objects/DelveMineralChest
                if (entityMetadataPath.StartsWith("Metadata/Terrain/Leagues/Delve/Objects/DelveMineral"))
                {
                    var newCachedEntity = new DelveVeinEntity(newWorldEntityParams);
                    AllEntities.Add(newCachedEntity.Id, newCachedEntity);
                    DelveVeins.AddNewEntity(newCachedEntity);
                    continue;
                }

                var found = false;

                var offsets = AreaEntityComponentsCache.ReadEntityComponentsOffsets(entityAddress);
                var componentListAddress = Memory.Instance.ReadLong(entityAddress + EntityComponentsHolder.COMPONENT_LIST_OFFSET);
                var components = EntityComponentsHolder.GetComponents(offsets, componentListAddress);

                foreach (var componentsKey in components)
                {
                    try
                    {
                        if (componentsKey.Key == nameof(NPC))
                        {
                            var newCachedEntity = new NpcEntity(newWorldEntityParams);
                            AllEntities.Add(newCachedEntity.Id, newCachedEntity);
                            Npc.AddNewEntity(newCachedEntity);

                            //LogMessage($"Found Npc: {entity.Metadata}");
                            found = true;
                            break;
                        }

                        if (componentsKey.Key == nameof(Chest))
                        {
                            found = true;

                            if (entityMetadataPath == "Metadata/Chests/ArmourRack1") //todo: make some config for this
                            {
                                break;
                            }

                            if (entityMetadataPath == "Metadata/Chests/WeaponRack1") //todo: make some config for this
                            {
                                break;
                            }

                            var chestComponent = game.GetObject<Chest>(componentsKey.Value);

                            if (chestComponent.IsOpened)
                            {
                                break;
                            }

                            //entityMetadataPath.StartsWith("Metadata/Chests/AbyssChest") //Abyss Hoard
                            //entityMetadataPath.StartsWith("Metadata/Chests/VaultTreasurePile")
                            var processAsStrongbox = chestComponent.IsStrongbox ||
                                                     entityMetadataPath.StartsWith("Metadata/Chests/Abyss/AbyssFinalChest");

                            if (processAsStrongbox)
                            {
                                var newCachedEntity = new StrongboxEntity(newWorldEntityParams);

                                if (IsSpecialChest(entityMetadataPath))
                                {
                                    newCachedEntity.IsSpecialChest = true;
                                }

                                Strongboxes.AddNewEntity(newCachedEntity);
                                AllEntities.Add(newCachedEntity.Id, newCachedEntity);
                            }
                            else
                            {
                                var newCachedEntity = new ChestEntity(newWorldEntityParams);

                                if (chestComponent.IsLocked || chestComponent.OpenOnDamage)
                                    break;

                                Chests.AddNewEntity(newCachedEntity);
                                AllEntities.Add(newCachedEntity.Id, newCachedEntity);
                            }

                            found = true;
                            break;
                        }

                        if (componentsKey.Key == nameof(Monster))
                        {
                            //Metadata/Monsters/Anomaly/AnomalyFromDaemon@73 add? This is 
                            if (entityMetadataPath == "Metadata/Monsters/VolatileCore/VolatileCore" ||
                                entityMetadataPath == "Metadata/Monsters/Clone/WitchLightningClone" ||
                                entityMetadataPath == "Metadata/Monsters/Clone/RangerLightningClone")
                            {
                                var volatileMonster = new DangerEntity(true, 50, newWorldEntityParams); //entity, _scanNumber, true, true, 50

                                //LogWarning($"Found VOLATILE!!!: {volatileMonster.Metadata}");
                                DangerEntities.AddNewEntity(volatileMonster);
                                AllEntities[volatileMonster.Id] = volatileMonster;
                            }
                            else
                            {
                                var newCachedEntity = new MonsterEntity(newWorldEntityParams);
                                AllEntities.Add(newCachedEntity.Id, newCachedEntity);

                                if (FilterMonster(newCachedEntity))
                                {
                                    //LogWarning($"+++Found monster: {newCachedEntity.Name}, ent null: {newCachedEntity.Entity == null}, Id: {newCachedEntity.Id}");
                                    Monsters.AddNewEntity(newCachedEntity);
                                }
                            }

                            found = true;
                            break;
                        }

                        if (componentsKey.Key == nameof(Player))
                        {
                            var player = game.GetObject<Player>(componentsKey.Value);
                            var newCachedEntity = new PlayerEntity(newWorldEntityParams, player);
                            AllEntities.Add(newCachedEntity.Id, newCachedEntity);
                            Players.AddNewEntity(newCachedEntity);
                            found = true;
                            break;
                        }

                        if (componentsKey.Key == nameof(Shrine))
                        {
                            var newCachedEntity = new ShrineEntity(newWorldEntityParams);
                            AllEntities.Add(newCachedEntity.Id, newCachedEntity);
                            Shrines.AddNewEntity(newCachedEntity);
                            found = true;
                            break;
                        }

                        if (componentsKey.Key == nameof(Portal))
                        {
                            var portal = game.GetObject<Portal>(componentsKey.Value);
                            var newCachedEntity = new PortalEntity(newWorldEntityParams, portal);
                            AllEntities.Add(newCachedEntity.Id, newCachedEntity);
                            Portals.AddNewEntity(newCachedEntity);
                            found = true;
                            break;
                        }

                        if (componentsKey.Key == nameof(AreaTransition))
                        {
                            var areaTransition = game.GetObject<AreaTransition>(componentsKey.Value);
                            var newCachedEntity = new AreaTransitionEntity(newWorldEntityParams, areaTransition);
                            AllEntities.Add(newCachedEntity.Id, newCachedEntity);
                            AreaTransitions.AddNewEntity(newCachedEntity);
                            found = true;
                            break;
                        }

                        if (componentsKey.Key == nameof(TriggerableBlockage))
                        {
                            var newCachedEntity = new DoorEntity(newWorldEntityParams);
                            AllEntities.Add(newCachedEntity.Id, newCachedEntity);

                            if (!newCachedEntity.RemoveFromSpecialCachedCollections())
                            {
                                Doors.AddNewEntity(newCachedEntity);
                            }

                            found = true;
                            break;
                        }

                        if (componentsKey.Key == nameof(WorldItem))
                        {
                            var newCachedEntity = new WorldItemEntity(newWorldEntityParams);
                            AllEntities.Add(newCachedEntity.Id, newCachedEntity);

                            if (FilterWorldItem(newCachedEntity))
                                WorldItems.AddNewEntity(newCachedEntity);

                            //LogMessage($"Found TriggerableBlockage: {entity.Metadata}");
                            found = true;
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        DebugPlugin.LogMsg($"Entities controller: Error while processing entity: {entityMetadataPath}: {e}", 10,
                            Color.Magenta);
                    }
                }

                //if (entity.Path == "Metadata/Terrain/EndGame/MapShipGraveyardCagan/Objects/Teleport") //Whakawairua Tuahu map
                //{
                //    var newCachedEntity = new CachedAreaTransition(entity, _scanNumber, AreaTransition.AreaTransitionType.Local);
                //    CachedEntities.Add(newCachedEntity.Id, newCachedEntity);
                //    AreaTransitions.Add(newCachedEntity);
                //}
                //else 
                if (!found)
                {
                    //LogMessage($"Added OTHER entity: {entity.Metadata}");
                    var otherCachedEntity = new UnknownCachedEntity(newWorldEntityParams);

                    //if (!AllEntities.ContainsKey(otherCachedEntity.Id)) //Sometimes shit happen...
                    //    AllEntities.Add(otherCachedEntity.Id, otherCachedEntity);
                    AllEntities[otherCachedEntity.Id] = otherCachedEntity;
                }
            }

            AreaTransitions.CheckVisibility(_scanNumber);
            Monsters.CheckVisibility(_scanNumber);
            DangerEntities.CheckVisibility(_scanNumber);
            Chests.CheckVisibility(_scanNumber);
            DelveVeins.CheckVisibility(_scanNumber);
            Doors.CheckVisibility(_scanNumber);
            Monsters.CheckVisibility(_scanNumber);
            Npc.CheckVisibility(_scanNumber);
            Portals.CheckVisibility(_scanNumber);
            Shrines.CheckVisibility(_scanNumber);
            Strongboxes.CheckVisibility(_scanNumber);
            Players.CheckVisibility(_scanNumber);
            WorldItems.CheckVisibility(_scanNumber);

            Monsters.UpdateMonsters();
            WorldItems.UpdateItems();
        }

        #region WorldItems

        private static bool FilterWorldItem(WorldItemEntity cachedWorldItem)
        {
            //var worldItem = cachedWorldItem.GetComponent<WorldItem>();
            //var entity = worldItem.ItemEntity;
            //var baseComp = entity.GetComponent<Base>();
            //var itemName = baseComp.Name;
            //cachedWorldItem.Name = itemName;

            //TODO
            //if (FilterItemUtils.FilterPickItem(entity, itemName))
            //    return true;
            return true;

            cachedWorldItem.IgnoreReason = "Passed through all filters (filtered out)";
            return false;
        }

        #endregion

        #region Chests

        private static readonly HashSet<string> _specialChestMetadada = new HashSet<string>
        {
            "Metadata/Chests/BootyChest",
            "Metadata/Chests/NotSoBootyChest",
            "Metadata/Chests/VaultTreasurePile",
            "Metadata/Chests/GhostPirateBootyChest",
            "Metadata/Chests/StatueMakersTools",
            "Metadata/Chests/StrongBoxes/VaultsOfAtziriUniqueChest",
            "Metadata/Chests/CopperChestEpic3",
            "Metadata/Chests/TutorialSupportGemChest"
        };

        private static bool IsSpecialChest(string metadata)
        {
            if (_specialChestMetadada.Contains(metadata))
                return true;

            if (metadata.Contains("/Breach/"))
                return true;

            if (metadata.Contains("/PerandusChests/"))
                return true;

            if (metadata.Contains("IncursionChest"))
                return true;

            return false;
        }

        #endregion

        #region Monsters

        private static bool FilterMonster(MonsterEntity cachedMonster)
        {
            if (!cachedMonster.IsAlive)
            {
                cachedMonster.FilterOutReason = "!IsAlive";
                return false;
            }

            if (cachedMonster.Metadata == "Metadata/Monsters/LegionLeague/LegionSandTornadoDaemon")
                return false;
            //
            //if (entity.CannotDieAura)
            //{
            //    if (!cachedMonster.FilterOutCannotDie)
            //    {
            //        cachedMonster.InitialFilterOutReason = "Killing the source of CannotDie!";
            //        return true;
            //    }

            //    cachedMonster.InitialFilterOutReason = "CannotDie";
            //    return false;
            //}

            //if (!entity.IsHostile)
            //{
            //    cachedMonster.InitialFilterOutReason = "!IsHostile";
            //    return false;
            //}

            //if (!entity.HasComponent<Monster>()) //Sometimes item Id is equal to monster.
            //{
            //    cachedMonster.InitialFilterOutReason = "!entity.HasComponent<Monster>()";
            //    return false;
            //}

            //Note: CannotBeDamaged causing emerging enemies to be ignored and they are not pass to Monsters list. 
            //TODO: DO NOT use IsTargetable as filter here too (but I'm not sure. Test this)
            //if (entity.CannotBeDamaged)
            //{
            //    cachedMonster.FilterOutReason = "CannotBeDamaged";
            //    return false;
            //}

            //if ((
            //        !entity.IsTargetable || 
            //        entity.CannotBeDamaged) && !entity.IsEmerging)
            //    return false;

            //TODO: Fixme
            //if (!IsInIncursion && entity.ExplicitAffixes.Any(a => a.InternalName.StartsWith("MonsterIncursion")))
            //    return;

            //if (HasImmunityAura(entity))
            //{
            //    cachedMonster.InitialFilterOutReason = "HasImmunityAura";
            //    return false;
            //}

            if (SkipThisMob(cachedMonster))
            {
                cachedMonster.FilterOutReason = "SkipThisMob(list)";
                return false;
            }

            return true;
        }

        private static bool HasImmunityAura(Entity entity)
        {
            foreach (var aura in entity.GetComponent<Life>().Buffs)
            {
                var name = aura.Name;

                if (name == "cannot_be_damaged" ||
                    name == "bloodlines_necrovigil" ||
                    name == "god_mode" ||
                    name == "shrine_godmode")
                    return true;
            }

            return false;
        }

        private static bool SkipThisMob(MonsterEntity entity)
        {
            var m = entity.Metadata;

            //TODO: Add from config
            return m == "Metadata/Monsters/LeagueIncursion/VaalSaucerBoss" ||
                   m.Contains("DoedreStonePillar");
        }

        #endregion
    }
}
