using PoeHUD.EntitiesCache.CachedEntities.Interfaces;
using PoeHUD.Poe.Components;
using SharpDX;

namespace PoeHUD.EntitiesCache.CachedEntities.Base
{
    /// <summary>
    /// This class actually cache the position of cached entity
    /// </summary>
    /// <seealso cref="BaseEntity" />
    public abstract class BaseMovableEntity : BaseWorldEntity, IMovableEntityCachedData
    {
        internal BaseMovableEntity(NewWorldEntityParams entityParams) : base(entityParams)
        {
            PositionedComponent = GetComponent<Positioned>();
            RenderComponent = GetComponent<Render>();
        }

        public Positioned PositionedComponent { get; private set; }
        public Render RenderComponent { get; private set; }

        protected override void OnAppear()
        {
            base.OnAppear();
            PositionedComponent = GetComponent<Positioned>();
            RenderComponent = GetComponent<Render>();
        }

        protected internal override void OnDisappear()
        {
            base.OnDisappear();
            PositionedComponent = null;
            RenderComponent = null;
        }

        public override Vector2 GridPos
        {
            get
            {
                if (!IsVisible)
                    return CachedGridPos;

                return CachedGridPos = PositionedComponent.GridPos;
            }
        }

        public override Vector3 WorldPos
        {
            get
            {
                if (!IsVisible)
                    return CachedWorldPos;

                return CachedWorldPos = RenderComponent.Pos;
            }
        }

        public override Vector3 EntityCenterWorldPos
        {
            get
            {
                if (!IsVisible)
                    return CachedEntityCenterWorldPos;

                return CachedEntityCenterWorldPos = RenderComponent.EntityCenterPos;
            }
        }
    }
}
