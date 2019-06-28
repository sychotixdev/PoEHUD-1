using SharpDX;

namespace PoeHUD.EntitiesCache.CachedEntities.Interfaces
{
    public interface IMovableEntityCachedData : IWorldEntityCachedData
    {
        Vector2 GridPos { get; }
        Vector3 WorldPos { get; }
        Vector3 EntityCenterWorldPos { get; }
    }
}
