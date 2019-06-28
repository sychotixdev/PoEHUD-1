using PoeHUD.EntitiesCache.CachedEntities.Base;
using PoeHUD.Poe.Components;

namespace PoeHUD.EntitiesCache.CachedEntities
{
    public sealed class NpcEntity : BaseMovableEntity
    {
        internal NpcEntity(NewWorldEntityParams entityParams) : base(entityParams)
        {
            Name = GetComponent<Render>().Name;
        }

        public string Name { get; }
    }
}
