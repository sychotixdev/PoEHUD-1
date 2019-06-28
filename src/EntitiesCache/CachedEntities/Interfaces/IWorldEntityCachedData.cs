namespace PoeHUD.EntitiesCache.CachedEntities.Interfaces
{
    public interface IWorldEntityCachedData : IEntityCachedData
    {
        uint Id { get; }
        bool IsVisible { get; }
    }
}
