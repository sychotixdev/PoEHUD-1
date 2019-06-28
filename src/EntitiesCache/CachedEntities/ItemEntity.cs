using System.Collections.Generic;
using PoeHUD.EntitiesCache.CachedEntities.Base;
using PoeHUD.EntitiesCache.ComponentsCache;
using PoeHUD.Framework;
using PoeHUD.Poe;

namespace PoeHUD.EntitiesCache.CachedEntities
{
    /// <summary>
    /// Like inventory item
    /// </summary>
    /// <seealso cref="PoeHUD.EntitiesCache.CachedEntities.Base.BaseEntity" />
    public class ItemEntity : BaseEntity
    {
        /// <summary>
        /// Holds all cached components
        /// </summary>
        private readonly EntityComponentsHolder _componentsHolder;

        public ItemEntity(long address) : base(address)
        {
            InventoryId = Memory.Instance.ReadInt(address + 0x58);
            _componentsHolder = new EntityComponentsHolder(entity: this, isItemEntity: true);
        }

        public int InventoryId { get; }
        public T GetComponent<T>() where T : Component, new() => _componentsHolder.GetComponent<T>();
        public bool HasComponent<T>() where T : Component, new() => _componentsHolder.HasComponent<T>();
        public Dictionary<string, long> GetComponents() => _componentsHolder.GetComponents();
    }
}
