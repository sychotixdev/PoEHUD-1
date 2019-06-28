using System.Collections.Generic;

namespace PoeHUD.EntitiesCache.ComponentsCache
{
    /// <summary>
    /// Actually we can use just Dictionary<string, int>, but let's see how the things are going
    /// </summary>
    internal class EntityComponentOffsetsHolder
    {
        public long EntityAddress { get; } //for debug purposes, remove it

        public EntityComponentOffsetsHolder(Dictionary<string, int> entityComponentOffsets, long entityAddress)
        {
            EntityComponentOffsets = entityComponentOffsets;
            EntityAddress = entityAddress;
        }

        public Dictionary<string, int> EntityComponentOffsets { get; }
    }
}