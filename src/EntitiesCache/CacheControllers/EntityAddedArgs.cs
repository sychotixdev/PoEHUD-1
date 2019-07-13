using PoeHUD.EntitiesCache.CachedEntities.Base;

namespace PoeHUD.EntitiesCache.CacheControllers
{
    public class EntityAddedArgs<T> where T : BaseEntity
    {
        public EntityAddedArgs(T entity, bool isNewEntity, bool revived)
        {
            Entity = entity;
            IsNewEntity = isNewEntity;
            Revived = revived;
        }

        public bool Revived { get; }
        public bool IsNewEntity { get; }
        public T Entity { get; }
    }
}