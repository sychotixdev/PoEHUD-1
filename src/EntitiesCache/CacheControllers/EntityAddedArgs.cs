using PoeHUD.EntitiesCache.CachedEntities.Base;

namespace PoeHUD.EntitiesCache.CacheControllers
{
    public class EntityAddedArgs<T> where T : BaseEntity
    {
        public EntityAddedArgs(T entity, bool isNewEntity)
        {
            Entity = entity;
            IsNewEntity = isNewEntity;
        }

        public bool IsNewEntity { get; }
        public T Entity { get; }
    }
}