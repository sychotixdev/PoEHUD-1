using PoeHUD.Poe.Components;

namespace PoeHUD.EntitiesCache.CachedEntities.Base
{
    /// <summary>
    /// Entity that cannot move and have cached position.
    /// </summary>
    /// <seealso cref="PoeHUD.EntitiesCache.CachedEntities.Base.BaseEntity" />
    public abstract class BaseStaticEntity : BaseWorldEntity
    {
        internal BaseStaticEntity(NewWorldEntityParams entityParams) : base(entityParams)
        {
            var render = GetComponent<Render>();
            CachedGridPos = GetComponent<Positioned>().GridPos;
            CachedWorldPos = render.Pos;
            CachedEntityCenterWorldPos = render.EntityCenterPos;
        }
    }
}