using PoeHUD.EntitiesCache.CachedEntities.Base;
using PoeHUD.Poe.Components;
using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.EntitiesCache.CachedEntities
{
    public sealed class PortalEntity : BaseMovableEntity
    {
        internal PortalEntity(NewWorldEntityParams entityParams, Portal portalComponent) : base(entityParams)
        {
            IsPlayerPortal = /*Entity.IsTargetable &&*/
                             (
                                 Metadata == "Metadata/MiscellaneousObjects/PlayerPortal" ||
                                 Metadata == "Metadata/MiscellaneousObjects/MapReturnPortal"
                             );

            Area = portalComponent.Area;
        }

        public bool IsPlayerPortal { get; }
        public WorldArea Area { get; }

        public override string ToString()
        {
            return $"{base.ToString()}, IsPlayerPortal: {IsPlayerPortal}";
        }
    }
}
