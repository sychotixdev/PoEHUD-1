using PoeHUD.EntitiesCache.CachedEntities.Base;
using PoeHUD.EntitiesCache.CachedEntities.Interfaces;
using PoeHUD.Poe.Components;

namespace PoeHUD.EntitiesCache.CachedEntities
{
    public sealed class PlayerEntity : BaseAliveEntity, IPlayerEntityCachedData
    {
        internal PlayerEntity(NewWorldEntityParams entityParams) : base(entityParams)
        {
            PlayerComponent = GetComponent<Player>();
            PlayerName = PlayerComponent.PlayerName;
        }

        internal PlayerEntity(NewWorldEntityParams entityParams, Player playerComponent) : base(entityParams)
        {
            PlayerComponent = playerComponent;
            PlayerName = PlayerComponent.PlayerName;
        }

        public string PlayerName { get; }
        public Player PlayerComponent { get; private set; }

        protected override void OnAppear()
        {
            base.OnAppear();
            PlayerComponent = GetComponent<Player>();
        }

        protected internal override void OnDisappear()
        {
            base.OnDisappear();
            PlayerComponent = null;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, PlayerName: {PlayerName}";
        }
    }
}
