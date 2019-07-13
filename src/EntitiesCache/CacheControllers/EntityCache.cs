using System;
using System.Collections.Generic;
using PoeHUD.EntitiesCache.CachedEntities.Base;
using PoeHUD.Plugins;

namespace PoeHUD.EntitiesCache.CacheControllers
{
    public class EntityCache<T> : IEntitiesController where T : BaseWorldEntity
    {
        // ReSharper disable once InconsistentNaming
        protected readonly List<T> _allEntities = new List<T>();

        internal EntityCache(EntitiesAreaCache entitiesCache)
        {
            VisibleEntities = new EntityCollectionFilter<T>(_allEntities, x => x.IsVisible);
            OutOfRangeEntities = new EntityCollectionFilter<T>(_allEntities, x => !x.IsVisible);
            AllEntities = _allEntities.AsReadOnly();
            entitiesCache.OnEntitiesClear += _allEntities.Clear;
        }

        /// <summary>
        /// All entities in visible range
        /// </summary>
        public IEnumerable<T> VisibleEntities { get; }
        /// <summary>
        /// NOT visible (out of range) entities
        /// Be careful, use only Position and other cached properties, don't try to get components, otherwise InvalidOperationException
        /// </summary>
        public IEnumerable<T> OutOfRangeEntities { get; }
        /// <summary>
        /// All visible and not visible (out of range) entities
        /// Be careful, check IsVisible and use only Position and other cached properties if it is not visible,
        /// don't try to get components, otherwise InvalidOperationException
        /// </summary>
        public IReadOnlyCollection<T> AllEntities { get; }

        //TODO: Remove memory leak. Perfectly we shoudn't trigger the subscriber in outdated plugins (dev plugins, after they reloaded in memory after compiling in VS)
        //So, after reloading plugin in memory the old plugin object is still subscribed to this event, and we should unsubscribe it automatically after hot reload.
        //Do it in ExternalPluginHolder.ReloadPlugin function
        public static event Action<EntityAddedArgs<T>> OnEntityAdded = delegate { };
        public static event Action<EntityRemovedArgs<T>> OnEntityRemoved = delegate { };

        #region Entity appearence

        /// <summary>
        /// Here we will find entities that go out of range
        /// </summary>
        /// <param name="scanNumber">The scan number.</param>
        internal virtual void CheckVisibility(uint scanNumber)
        {
            foreach (var cachedEntity in _allEntities)
            {
                //if scan number is not equal this mean that this entity was not found while scanning, so it is out of range
                if (cachedEntity.ScanNumber != scanNumber)
                {
                    //cachedEntity.ScanNumber = scanNumber;//seems no sense in this

                    if (cachedEntity.IsVisible)
                    {
                        cachedEntity.IsVisible = false;
                        cachedEntity.ComponentsHolder.ClearCache();
                        cachedEntity.OnDisappear();
                        SafeInvokeEntityRemoved(new EntityRemovedArgs<T>(cachedEntity, destroyed: false, killed: false));
                        cachedEntity.Address = -1; //I think it should be here in case s1 using address for caching
                    }
                }
            }
        }

        void IEntitiesController.EntityAppear(BaseWorldEntity cachedEntity)
        {
            SafeInvokeEntityAdded(new EntityAddedArgs<T>((T) cachedEntity, false, revived: false));
        }

        void IEntitiesController.EntityDestroyed(BaseWorldEntity cachedEntity)
        {
            EntityDestroyed((T) cachedEntity);
        }

        /// <summary>
        /// Actually this is when we found a new not cached entity in hud memory
        /// </summary>
        internal virtual void AddNewEntity(T cachedEntity)
        {
            cachedEntity.OwnerEntityController = this;
            _allEntities.Add(cachedEntity);
            SafeInvokeEntityAdded(new EntityAddedArgs<T>(cachedEntity, isNewEntity: true, revived: false));
        }

        protected internal void EntityDestroyed(T cachedEntity)
        {
            SafeInvokeEntityRemoved(new EntityRemovedArgs<T>(cachedEntity, destroyed: true, killed: true));
            _allEntities.Remove(cachedEntity);
        }

        protected internal void SafeInvokeEntityRemoved(EntityRemovedArgs<T> args)
        {
            SafeEventCall(OnEntityRemoved, args, nameof(OnEntityRemoved));
        }

        protected internal void SafeInvokeEntityAdded(EntityAddedArgs<T> args)
        {
            SafeEventCall(OnEntityAdded, args, nameof(OnEntityAdded));
        }

        internal void SafeEventCall(MulticastDelegate func, object arg, string eventName)
        {
            foreach (var subscriber in func.GetInvocationList())
            {
                try
                {
                    subscriber.DynamicInvoke(arg);
                }
                catch (Exception e)
                {
                    BasePlugin.LogError($"Error while calling function subscribed to event {eventName}" +
                                        $" in object {subscriber.Target}, " +
                                        $"method: {subscriber.Method.Name}: {e}", 7);
                }
            }
        }

        #endregion
    }
}
