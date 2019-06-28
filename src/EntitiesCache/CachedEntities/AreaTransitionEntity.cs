using PoeHUD.EntitiesCache.CachedEntities.Base;
using PoeHUD.Poe.Components;
using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.EntitiesCache.CachedEntities
{
    public sealed class AreaTransitionEntity : BaseStaticEntity
    {
        internal AreaTransitionEntity(NewWorldEntityParams entityParams, AreaTransition transitionComponent) : base(entityParams)
        {
            TransitionType = transitionComponent.TransitionType;
            Area = transitionComponent.WorldArea;
            Name = Area != null ? Area.Name : "NoName";
        }
        
        public AreaTransition.AreaTransitionType TransitionType { get; }
        public WorldArea Area { get; }
        public string Name { get; }

        public override string ToString()
        {
            return $"{base.ToString()}, " +
                   $"TransitionType: {TransitionType}, " +
                   $"Distance: {Distance}, " +
                   $"Ignored: {Ignored}";
        }
    }
}
