using PoeHUD.EntitiesCache.CachedEntities.Base;

namespace PoeHUD.EntitiesCache.CacheControllers
{
    public class EntityRemovedArgs<T> where T : BaseEntity
    {
        public EntityRemovedArgs(T entity, bool destroyed)
        {
            Entity = entity;
            Destroyed = destroyed;
        }

        public bool Destroyed { get; }
        public T Entity { get; }
    }
}