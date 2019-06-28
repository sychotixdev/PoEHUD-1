using System;
using System.Linq;
using PoeHUD.EntitiesCache.CachedEntities;

namespace PoeHUD.EntitiesCache.CacheControllers
{
    public class WorldItemsController : EntityCache<WorldItemEntity>
    {
        const float ENTITY_DESTROY_CHECK_DISTANCE = 100; //optimal distance is debatable, but its not recommended to be higher than 100
        internal WorldItemsController(EntitiesAreaCache entitiesCache) : base(entitiesCache)
        {
        }

        /// <summary>
        /// Called when entity is picked
        /// </summary>
        public static event Action<WorldItemEntity> OnItemPicked = delegate { };

        internal void UpdateItems()
        {
            foreach (var cachedWorldItemEntity in _allEntities.ToList())
            {
                if (!cachedWorldItemEntity.IsVisible && cachedWorldItemEntity.Distance < ENTITY_DESTROY_CHECK_DISTANCE)
                {//mean cached entity in range but it doesn't exist in poe memory, only in our cache, so it was destroyed
                    ItemPicked(cachedWorldItemEntity);
                }
            }
        }

        private void ItemPicked(WorldItemEntity entity)
        {
            entity.Destroyed = true;
            EntityDestroyed(entity);
            EntitiesAreaCache.Current.AllEntities.Remove(entity.Id);
            SafeEventCall(OnItemPicked, entity, nameof(OnItemPicked));
        }
    }
}
