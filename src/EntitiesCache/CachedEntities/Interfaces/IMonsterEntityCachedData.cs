using PoeHUD.Models.Enums;

namespace PoeHUD.EntitiesCache.CachedEntities.Interfaces
{
    /// <summary>
    /// Properties in this class are safe to call in case if entity is not visible
    /// </summary>
    public interface IMonsterEntityCachedData : IAliveEntityCachedData
    {
        string Name { get; }
        MonsterRarity Rarity { get; }
        bool IsLegion { get; }
    }
}
