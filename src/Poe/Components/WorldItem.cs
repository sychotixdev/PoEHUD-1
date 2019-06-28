using PoeHUD.EntitiesCache.CachedEntities;
using PoeHUD.EntitiesCache.CachedEntities.Base;

namespace PoeHUD.Poe.Components
{
    public class WorldItem : Component
    {
        public ItemEntity ItemEntity => new ItemEntity(M.ReadLong(Address + 0x28));
    }
}