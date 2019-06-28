using System;
using System.Collections.Generic;
using PoeHUD.EntitiesCache.CachedEntities.Base;
using PoeHUD.Framework;

namespace PoeHUD.EntitiesCache.ComponentsCache
{
    /// <summary>
    /// Holds components offsets per entity type (by entity path)
    /// </summary>
    internal class AreaEntityComponentsCache
    {
        /// <summary>
        /// Holds all world entities component cache
        /// </summary>
        public static AreaEntityComponentsCache WorldEntitiesComponentsCache { get; internal set; }
        /// <summary>
        /// Holds all item entities component cache
        /// </summary>
        public static AreaEntityComponentsCache ItemEntitiesComponentsCache { get; internal set; }

        private readonly Dictionary<long, EntityComponentOffsetsHolder> _cachedComponentOffsetsHolders =
            new Dictionary<long, EntityComponentOffsetsHolder>();

        public EntityComponentOffsetsHolder GetComponentHolder(BaseEntity entity)
        {
            if (!_cachedComponentOffsetsHolders.TryGetValue(entity.MetadataAddress, out var componentHolder))
            {
                componentHolder = ReadEntityComponentsOffsets(entity.Address);
                _cachedComponentOffsetsHolders.Add(entity.MetadataAddress, componentHolder);
            }

            return componentHolder;
        }

        internal static EntityComponentOffsetsHolder ReadEntityComponentsOffsets(long entityAddress)
        {
            var dictionary = new Dictionary<string, int>();
            var componentLookup = Memory.Instance.ReadLong(entityAddress, 0x40, 0x30);

            // the first address is a base object that doesn't contain a component, so read the first component
            var linkedListIterator = Memory.Instance.ReadLong(componentLookup);
            var stuckCounter = 0;

            while (linkedListIterator != componentLookup && linkedListIterator != 0 && linkedListIterator != -1)
            {
                var name = Memory.Instance.ReadString(Memory.Instance.ReadLong(linkedListIterator + 0x10));
                var nameStart = name;

                if (!string.IsNullOrWhiteSpace(name))
                {
                    var arr = name.ToCharArray();
                    arr = Array.FindAll(arr, c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c) || c == '-');
                    name = new string(arr);
                }

                if (string.IsNullOrWhiteSpace(name) || name != nameStart)
                    break;

                var componentIndex = Memory.Instance.ReadInt(linkedListIterator + 0x18);

                if (!dictionary.ContainsKey(name) && !string.IsNullOrWhiteSpace(name))
                    dictionary.Add(name, componentIndex);

                linkedListIterator = Memory.Instance.ReadLong(linkedListIterator);

                if (stuckCounter++ > 20)
                    break;
            }

            return new EntityComponentOffsetsHolder(dictionary, entityAddress);
        }
    }
}
