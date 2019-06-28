using System;
using System.Collections.Generic;
using PoeHUD.Plugins;

namespace PoeHUD.EntitiesCache.CacheControllers
{
    public class DataContainer
    {
        private readonly Dictionary<int, object> _dataContainerDictionary = new Dictionary<int, object>();

        public T GetDataContainer<T>() where T : class
        {
            //BasePlugin.LogError($"Get container: {typeof(T).FullName}, Hash: {typeof(T).GUID.GetHashCode()}", 5);
            //perfectly instead of GetHashCode from typeof(T), which takes unknown amount of time
            //I probably tried to use the address of typeof(T) using unsafe..
            //It will be fast, but Im not 100% sure that address will be stable (fx in case loading and unloading assemblies)

            //UPD. I'll use typeof(T).Guid.GetHashCode() which seems is the fastest way (no InternalHelpers for calculating hashcode of Type, just fast bit operations)
            //and seems this is the same as Dictionary<GUID,xxx)... I'll go this way
            if (_dataContainerDictionary.TryGetValue(typeof(T).GUID.GetHashCode(), out var container))
            {
                //if (container is T typedContainer) //to avoid exceptions while direct cast
                    return (T)container;
                //else
                //{
                //    
                //}
            }

            return null;
        }

        public T GetOrCreateDataContainer<T>() where T : class, new()
        {
            var container = GetDataContainer<T>();

            if (container == null)
            {
                container = new T();
                //BasePlugin.LogError($"Add container: {typeof(T).Name}, Hash: {typeof(T).GUID.GetHashCode()}", 5);
                AddDataContainer(container);
            }

            return container;
        }

        public void AddDataContainer<T>(T container) where T : class
        {
            _dataContainerDictionary.Add(typeof(T).GUID.GetHashCode(), container);
        }
    }
}
