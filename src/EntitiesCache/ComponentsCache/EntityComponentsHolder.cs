using System.Collections.Generic;
using PoeHUD.EntitiesCache.CachedEntities.Base;
using PoeHUD.Framework;
using PoeHUD.Poe;

namespace PoeHUD.EntitiesCache.ComponentsCache
{
    /// <summary>
    /// This class will hold all component objects of entity
    /// </summary>
    internal class EntityComponentsHolder
    {
        internal const int COMPONENT_LIST_OFFSET = 0x8;
        private readonly BaseEntity _entity;
        private EntityComponentOffsetsHolder _componentOffsetsHolder;
        private readonly Dictionary<string, Component> _cachedComponentObjects = new Dictionary<string, Component>();
        private long? _componentListAddress;

        /// <summary>
        /// For items we are using another cache
        /// </summary>
        private readonly bool _isItemEntity;

        internal EntityComponentsHolder(BaseEntity entity, bool isItemEntity)
        {
            _entity = entity;
            _isItemEntity = isItemEntity;
        }

        public long ComponentListAddress
        {
            get
            {
                if (!_componentListAddress.HasValue)
                {
                    _componentListAddress = Memory.Instance.ReadLong(_entity.Address + COMPONENT_LIST_OFFSET);
                }

                return _componentListAddress.Value;
            }
        }

        public void ClearCache()
        {
            _componentListAddress = null;
            _cachedComponentObjects.Clear();
        }

        public EntityComponentOffsetsHolder ComponentOffsetsHolder
        {
            get
            {
                if (_componentOffsetsHolder == null)
                {
                    if (_isItemEntity)//For items we are using another cache
                    {
                        _componentOffsetsHolder = AreaEntityComponentsCache.ItemEntitiesComponentsCache.GetComponentHolder(_entity);
                    }
                    else
                    {
                        _componentOffsetsHolder = AreaEntityComponentsCache.WorldEntitiesComponentsCache.GetComponentHolder(_entity);
                    }
                }

                return _componentOffsetsHolder;
            }
        }

        public T GetComponent<T>() where T : Component, new()
        {
            if (!_cachedComponentObjects.TryGetValue(typeof(T).Name, out var component))
            {
                var componentName = typeof(T).Name;

                if (!ComponentOffsetsHolder.EntityComponentOffsets.TryGetValue(componentName, out var offset))
                {
                    //BasePlugin.LogError($"No component: {componentName} at: {_entity.Metadata}. " +
                    //                    $"AllComponents: {string.Join(", ", ComponentOffsetsHolder.EntityComponentOffsets.Select(x => x.Key))}", 3);

                    _cachedComponentObjects.Add(typeof(T).Name, null);
                    return null;
                }

                component = RemoteMemoryObject.CreateObject<T>(Memory.Instance.ReadLong(ComponentListAddress + offset * sizeof(long)));
                _cachedComponentObjects.Add(typeof(T).Name, component);
            }

            return (T) component;
        }

        public bool HasComponent<T>() where T : Component
        {
            return ComponentOffsetsHolder.EntityComponentOffsets.ContainsKey(typeof(T).Name);
        }

        public Dictionary<string, long> GetComponents()
        {
            return GetComponents(ComponentOffsetsHolder, ComponentListAddress);
        }

        internal static Dictionary<string, long> GetComponents(EntityComponentOffsetsHolder offsetsHolder, long componentListAddress)
        {
            var result = new Dictionary<string, long>();

            foreach (var componentOffset in offsetsHolder.EntityComponentOffsets)
            {
                var componentAddress = Memory.Instance.ReadLong(componentListAddress + componentOffset.Value * sizeof(long));
                result.Add(componentOffset.Key, componentAddress);
            }

            return result;
        }
    }
}
