using System;
using System.Collections.Generic;
using System.Linq;
using PoeHUD.EntitiesCache.CachedEntities;
using PoeHUD.Plugins;

namespace PoeHUD.EntitiesCache.CacheControllers
{
    public class MonstersController : EntityCache<MonsterEntity>
    {
        const float ENTITY_DESTROY_CHECK_DISTANCE = 100; //optimal distance is debatable, but its not recommended to be higher than 100
        /// <summary>
        /// All cached monsters in current area
        /// </summary>
        public static MonstersController Current { get; internal set; }
        /// <summary>
        /// Visible dead and alive, ally and enemy monsters
        /// </summary>
        public IEnumerable<MonsterEntity> VisibleMonsters { get; }
        /// <summary>
        /// Visible alive ally and enemy monsters
        /// </summary>
        public IEnumerable<MonsterEntity> VisibleAliveMonsters { get; }
        /// <summary>
        /// Visible dead and alive enemy monsters
        /// </summary>
        public IEnumerable<MonsterEntity> VisibleEnemyMonsters { get; }
        /// <summary>
        /// Visible dead and alive enemy monsters
        /// </summary>
        public IEnumerable<MonsterEntity> VisibleAllyMonsters { get; }
        /// <summary>
        /// Visible alive enemy monsters
        /// </summary>
        public IEnumerable<MonsterEntity> VisibleAliveEnemyMonsters { get; }
        /// <summary>
        /// NOT visible (out of range) alive, ally and enemy monsters.
        /// Be careful, use only Position and other cached properties, don't try to get components, otherwise InvalidOperationException
        /// </summary>
        public IEnumerable<MonsterEntity> OutOfRangeAliveMonsters { get; }

        internal MonstersController(EntitiesAreaCache entitiesCache) : base(entitiesCache)
        {
            VisibleMonsters = new EntityCollectionFilter<MonsterEntity>(_allEntities, x => x.IsVisible);
            VisibleAliveMonsters = new EntityCollectionFilter<MonsterEntity>(_allEntities, x => x.IsVisible && x.IsAlive);
            OutOfRangeAliveMonsters = new EntityCollectionFilter<MonsterEntity>(_allEntities, x => !x.IsVisible && x.IsAlive);
            VisibleEnemyMonsters = new EntityCollectionFilter<MonsterEntity>(_allEntities, x => x.IsVisible && !x.IsAlly);
            VisibleAllyMonsters = new EntityCollectionFilter<MonsterEntity>(_allEntities, x => x.IsVisible && x.IsAlly);
            VisibleAliveEnemyMonsters = new EntityCollectionFilter<MonsterEntity>(_allEntities, x => x.IsVisible && x.IsAlive && !x.IsAlly);
        }

        public static event Action<MonsterDeathArgs> OnMonsterDeath = delegate { };

        internal override void AddNewEntity(MonsterEntity cachedEntity)
        {
            base.AddNewEntity(cachedEntity);

            //New entity and already killed? Probably this is not our kill
            if (!cachedEntity.IsAlive)
            {
                OnMonsterDeath(new MonsterDeathArgs(cachedEntity, killedByOtherPlayer: true));
            }
        }

        internal void UpdateMonsters()
        {
            //we are not going to use VisibleMonsters for case it could be fucked
            //We do .ToList() coz sometimes "CollectionWasChanged" exception appears,
            //I think in case when monster corpse is destroyed on kill and we call EntityDestroyed in this func to remove it from _allEntities
            foreach (var cachedMonsterEntity in _allEntities.ToList()) 
            {
                if (cachedMonsterEntity.IsVisible)
                {
                    if (!cachedMonsterEntity.IsAliveReal)
                    {
                        if (!cachedMonsterEntity.IsDeathRegistered)
                        {
                            cachedMonsterEntity.IsDeathRegistered = true;
                            //this is more likely we killed the enemy
                            SafeEventCall(OnMonsterDeath, new MonsterDeathArgs(cachedMonsterEntity, killedByOtherPlayer: false), nameof(OnMonsterDeath));
                        }
                    }

                    //We killed a monster that destroy it's corpse after death
                    //actually we can not do this, because the next IF with distance check will do the stuff
                    if (!cachedMonsterEntity.IsValid)
                    {
                        MonsterEntityDestroyed(cachedMonsterEntity);
                    }

                    continue; //normal visible monster
                }

                //Here we will try to handle non standard situations
                //mean cached entity in range but it doesn't exist in poe memory, only in our cache, so it was destroyed
                if (cachedMonsterEntity.Distance <= ENTITY_DESTROY_CHECK_DISTANCE)
                {
                    //Case when monster destroy it's corpse after death
                    //monster exist only in cache (not in game) but close than 100. Seems we were seen this monster (was cached) once and then it was killed by someone while out of range
                    //So, remove monsters that were close to us, but now are null (corpse exploded, shattered etc)
                  
                    //Probably this is not our kill, but I'm not 100% sure
                    MonsterEntityDestroyed(cachedMonsterEntity);
                }
            }
        }

        private void MonsterEntityDestroyed(MonsterEntity entity)
        {
            entity.IsDestroyed = true;
            entity.IsDeathRegistered = true;
            entity.IsVisible = false;
            EntitiesAreaCache.Current.AllEntities.Remove(entity.Id);
            EntityDestroyed(entity);
            SafeEventCall(OnMonsterDeath, new MonsterDeathArgs(entity, killedByOtherPlayer: true), nameof(OnMonsterDeath));
        }
    }

    public class MonsterDeathArgs
    {
        public MonsterDeathArgs(MonsterEntity entity, bool killedByOtherPlayer)
        {
            Entity = entity;
            KilledByOtherPlayer = killedByOtherPlayer;
        }

        public MonsterEntity Entity { get; }
        /// <summary>
        /// Probably killed by some other player or was out of checking range
        /// </summary>
        public bool KilledByOtherPlayer { get; }

        public override string ToString()
        {
            return $"MonsterDeathParams. Entity: {Entity}, KilledByOtherPlayer: {KilledByOtherPlayer}";
        }
    }
}
