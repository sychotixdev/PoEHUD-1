using PoeHUD.EntitiesCache.CachedEntities.Base;

namespace PoeHUD.EntitiesCache.CacheControllers
{
    public class EntityRemovedArgs<T> where T : BaseEntity
    {
        internal EntityRemovedArgs(T entity, bool destroyed, bool killed)
        {
            Entity = entity;
            Destroyed = destroyed;
            Killed = killed;
        }

        public bool Killed { get; }
        public bool Destroyed { get; }
        public T Entity { get; }
    }
}