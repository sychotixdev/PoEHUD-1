using PoeHUD.EntitiesCache.CachedEntities.Base;

namespace PoeHUD.EntitiesCache.CachedEntities
{
    public sealed class DangerEntity : BaseMovableEntity
    {
        /// <summary>
        /// This is something like explosion radius (of volatile, etc)
        /// </summary>
        public float Radius { get; }

        /// <summary>
        /// The is monster or a mine
        /// </summary>
        private readonly bool _isMonster;

        internal DangerEntity(bool isMonster, float radius, NewWorldEntityParams entityParams) : base(entityParams)
        {
            Radius = radius;
            _isMonster = isMonster;
        }
    }
}
