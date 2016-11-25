using PoeHUD.Controllers;
using PoeHUD.Poe;
using PoeHUD.Poe.Elements;
using System;
using System.Collections.Generic;

namespace PoeHUD.Models
{
    public sealed class EntityListWrapper
    {
        private readonly GameController gameController;
        private readonly HashSet<string> ignoredEntities;
        private Dictionary<long, EntityWrapper> entityCache;

        public EntityListWrapper(GameController gameController)
        {
            this.gameController = gameController;
            entityCache = new Dictionary<long, EntityWrapper>();
            ignoredEntities = new HashSet<string>();
            gameController.Area.OnAreaChange += OnAreaChanged;
        }

        public ICollection<EntityWrapper> Entities => entityCache.Values;

        private EntityWrapper player;

        public EntityWrapper Player
        {
            get
            {
                if (player == null)
                    UpdatePlayer();
                return player;
            }
        }

        public event Action<EntityWrapper> EntityAdded;

        public event Action<EntityWrapper> EntityRemoved;

        private void OnAreaChanged(AreaController area)
        {
            ignoredEntities.Clear();
            RemoveOldEntitiesFromCache();
        }

        private void RemoveOldEntitiesFromCache()
        {
            foreach (var current in Entities)
            {
                EntityRemoved?.Invoke(current);
                current.IsInList = false;
            }
            entityCache.Clear();
        }

        public void RefreshState()
        {
            UpdatePlayer();
            if (gameController.Area.CurrentArea == null)
                return;

            Dictionary<int, Entity> newEntities = gameController.Game.IngameState.Data.EntityList.EntitiesAsDictionary;
            var newCache = new Dictionary<long, EntityWrapper>();
            foreach (var keyEntity in newEntities)
            {
                if (!keyEntity.Value.IsValid)
                    continue;

                long entityID = keyEntity.Key;
                string uniqueEntityName = keyEntity.Value.Path + entityID;

                if (ignoredEntities.Contains(uniqueEntityName))
                    continue;

                if (entityCache.ContainsKey(entityID) && entityCache[entityID].IsValid)
                {
                    newCache.Add(entityID, entityCache[entityID]);
                    entityCache[entityID].IsInList = true;
                    entityCache.Remove(entityID);
                    continue;
                }

                var entity = new EntityWrapper(gameController, keyEntity.Value);
                if (entity.Path.StartsWith("Metadata/Effects") || ((entityID & 0x80000000L) != 0L) ||
                    entity.Path.StartsWith("Metadata/Monsters/Daemon"))
                {
                    ignoredEntities.Add(uniqueEntityName);
                    continue;
                }

                EntityAdded?.Invoke(entity);
                newCache.Add(entityID, entity);
            }
            RemoveOldEntitiesFromCache();
            entityCache = newCache;
        }

        private void UpdatePlayer()
        {
            long address = gameController.Game.IngameState.Data.LocalPlayer.Address;
            if ((player == null) || (player.Address != address))
            {
                player = new EntityWrapper(gameController, address);
            }
        }

        public EntityWrapper GetEntityById(int id)
        {
            EntityWrapper result;
            return entityCache.TryGetValue(id, out result) ? result : null;
        }

        public EntityLabel GetLabelForEntity(Entity entity)
        {
            var hashSet = new HashSet<int>();
            int entityLabelMap = gameController.Game.IngameState.EntityLabelMap;
            int num = entityLabelMap;
            while (true)
            {
                hashSet.Add(num);
                if (gameController.Memory.ReadInt(num + 0x10) == entity.Address)
                {
                    break;
                }
                num = gameController.Memory.ReadInt(num);
                if (hashSet.Contains(num) || num == 0 || num == -1)
                {
                    return null;
                }
            }
            return gameController.Game.ReadObject<EntityLabel>(num + 0x18);
        }
    }
}