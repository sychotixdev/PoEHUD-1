using PoeHUD.EntitiesCache.CachedEntities.Base;

namespace PoeHUD.EntitiesCache.CacheControllers
{
    /// <summary>
    /// Used for sending event from CachedEntity to EntityCache<T> that entity appear. It will trigger event OnEntityAdded (IsNew = false)
    /// </summary>
    public interface IEntitiesController
    {
        void EntityAppear(BaseWorldEntity cachedEntity);
        void EntityDestroyed(BaseWorldEntity cachedEntity);
    }
}