using PoeHUD.EntitiesCache.CachedEntities.Base;
using PoeHUD.Poe.Components;

namespace PoeHUD.EntitiesCache.CachedEntities
{
    public class ChestEntity : BaseStaticEntity
    {
        internal ChestEntity(NewWorldEntityParams entityParams) : base(entityParams)
        {
        }

        public bool IsSpecialChest { get; internal set; }
        public bool IsOpened
        {
            get
            {
                if (!IsVisible)
                    ThrowExceptionGetInformationOnOutRangeEntity();

                return GetComponent<Chest>().IsOpened;
            }
        }

        internal override bool RemoveFromSpecialCachedCollections()
        {
            return IsVisible && IsOpened;
        }
    }
}
