using PoeHUD.EntitiesCache.CachedEntities.Base;

namespace PoeHUD.EntitiesCache.CachedEntities
{
    public class WorldItemEntity : BaseStaticEntity
    {
        internal WorldItemEntity(NewWorldEntityParams entityParams) : base(entityParams)
        {
        }
        
        public string IgnoreReason { get; internal set; }

        /// <summary>
        /// Mean IsPicked
        /// </summary>
        public bool Destroyed { get; internal set; }

        public override string ToString()
        {
            return $"{base.ToString()}, Ignored: {Ignored}, IgnoreReason: {IgnoreReason}]";
        }
    }
}
