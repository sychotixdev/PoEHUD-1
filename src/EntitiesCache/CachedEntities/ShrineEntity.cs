using PoeHUD.EntitiesCache.CachedEntities.Base;

namespace PoeHUD.EntitiesCache.CachedEntities
{
    public class ShrineEntity : BaseStaticEntity
    {
        internal ShrineEntity(NewWorldEntityParams entityParams) : base(entityParams)
        {
            Name = "%NoName%"; //TODO
        }

        public string Name { get; }

        public override string ToString()
        {
            return $"{base.ToString()}, ShrineName: {Name}";
        }
    }
}
