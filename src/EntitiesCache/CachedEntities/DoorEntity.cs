using PoeHUD.EntitiesCache.CachedEntities.Base;
using PoeHUD.EntitiesCache.Extensions;
using PoeHUD.Poe.Components;

namespace PoeHUD.EntitiesCache.CachedEntities
{
    public sealed class DoorEntity : BaseStaticEntity
    {
        internal DoorEntity(NewWorldEntityParams entityParams) : base(entityParams)
        {
            IsLockedDoor = GetComponent<Render>().Name == LocalizationConstants.LOCKED_DOOR;
        }

        public bool IsOpened => IsVisible && !GetComponent<TriggerableBlockage>().IsClosed;

        internal override bool RemoveFromSpecialCachedCollections()
        {
            return IsOpened;
        }
        
        public bool IsLockedDoor { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}, IsOpened: {IsOpened}, IsLockingDoor: {IsLockedDoor}";
        }
    }
}
