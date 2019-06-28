namespace PoeHUD.EntitiesCache.CachedEntities.Interfaces
{
    public interface IEntityCachedData
    {
        string Path { get; }
        string Metadata { get; }
        long Address { get; }
    }
}
