namespace PoeHUD.EntitiesCache.CachedEntities.Interfaces
{
    public interface IAliveEntityCachedData : IMovableEntityCachedData
    {
        bool IsDestroyed { get; }
        bool IsAlly { get; }
        bool IsHostile { get; }
        bool IsAlive { get; }
    }
}
