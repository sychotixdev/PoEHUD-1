using System;
using System.Collections.Generic;
using PoeHUD.EntitiesCache.CacheControllers;
using PoeHUD.EntitiesCache.CachedEntities.Interfaces;
using PoeHUD.EntitiesCache.ComponentsCache;
using PoeHUD.Poe;
using SharpDX;

namespace PoeHUD.EntitiesCache.CachedEntities.Base
{
    /// <summary>
    /// Base class for all world entities that exist in entities cache
    /// </summary>
    /// <seealso cref="PoeHUD.EntitiesCache.CachedEntities.Base.BaseEntity" />
    public abstract class BaseWorldEntity : BaseEntity, IWorldEntityCachedData
    {
        /// <summary>
        /// Container for user data
        /// </summary>
        private DataContainer _dataContainer;

        /// <summary>
        /// Holds all cached components
        /// </summary>
        internal readonly EntityComponentsHolder ComponentsHolder;

        /// <summary>
        /// Used to define that entity exist in memory while entities scanning
        /// </summary>
        internal uint ScanNumber;

        internal BaseWorldEntity(NewWorldEntityParams entityParams) : base(entityParams)
        {
            Id = entityParams.Id;
            ScanNumber = entityParams.ScanNumber;
            IsVisible = true;
            ComponentsHolder = new EntityComponentsHolder(entity: this, isItemEntity: false);
        }

        /// <summary>
        /// Entity id.
        /// </summary>
        public uint Id { get; }

        public override int GetHashCode()
        {
            return (int) Id; //should works fine for caching system
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Id: {Id}{(Ignored ? $", Ignore reason: {FilterOutReason}" : string.Empty)}";
        }

        #region Appearence
        /// <summary>
        /// Is this entity is in player visible range
        /// </summary>
        public bool IsVisible { get; internal set; }
        /// <summary>
        /// Used for sending event to EntityCache<T> that entity appear. It will trigger event OnEntityAdded (IsNew = false)
        /// </summary>
        internal IEntitiesController OwnerEntityController { get; set; }
        /// <summary>
        /// Return true to remove this cached entity from cached collection (Monsters, chest (after opening), etc), but will be
        /// still present in main AllEntities cache.
        /// Warning: Make sure ur filter for removing entity was identical to EntitiesAreaCache filter, otherwise it will add
        /// it and remove on each frame, this is expensive!
        /// </summary>
        internal virtual bool RemoveFromSpecialCachedCollections()
        {
            return false;
        }

        /// <summary>
        /// if this value is false this class was removed from special collections (monsters, chests, etc)
        /// ...but this class will be in AllEntities collection
        /// </summary>
        internal bool IsRemovedFromSpecialCachedCollections { get; set; }

        /// <summary>
        /// Called once when entity go out of visible range.
        /// </summary>
        protected internal virtual void OnDisappear()
        {
        }
        /// <summary>
        /// Called once when entity back to visible range. EntityAddress is updated.
        /// </summary>
        protected virtual void OnAppear()
        {
        }

        /// <summary>
        /// Called once when player go out of visible range. Entity is null now. IsVisible is false
        /// </summary>
        internal void Appear(uint scanNumber, long address)
        {
            ScanNumber = scanNumber;
            Address = address;

            if (!IsVisible)
            {
                IsVisible = true;
                OnAppear();

                //EntityControllerFeedback can be null because it don't have any EntityCache (if entity is not passed to any collection).
                OwnerEntityController?.EntityAppear(this);
            }
        }

        #endregion

        #region Ignored

        /// <summary>
        /// Actually affect nothing. It indicates that fx CachedChest entity was not added to Chests cache (fx it was opened
        /// and no sense to add it).
        /// If it is true you can check InitialFilterOutReason and PriorityFilterOutReason
        /// </summary>
        public bool Ignored { get; internal set; }
        /// <summary>
        /// Reason why this entity is filtered out (Ignored is true) and not passed to special cached entities collection
        /// (CachedMonsters, CachedChests),
        /// but still present in main AllEntities collection.
        /// </summary>
        public string FilterOutReason { get; internal set; } //For debug

        #endregion

        #region Components

        public T GetComponent<T>() where T : Component, new()
        {
            if (!IsVisible)
                ThrowExceptionGetInformationOnOutRangeEntity();

            return ComponentsHolder.GetComponent<T>();
        }

        public bool HasComponent<T>() where T : Component
        {
            if (!IsVisible)
                ThrowExceptionGetInformationOnOutRangeEntity();

            return ComponentsHolder.HasComponent<T>();
        }

        public Dictionary<string, long> GetComponents()
        {
            if (!IsVisible)
                ThrowExceptionGetInformationOnOutRangeEntity();

            return ComponentsHolder.GetComponents();
        }

        protected void ThrowExceptionGetInformationOnOutRangeEntity()
        {
            throw new InvalidOperationException($"Check {nameof(IsVisible)} before getting not cached information from entity");
        }

        #endregion

        #region Data Container

        public T GetDataContainer<T>() where T : class
        {
            return _dataContainer?.GetDataContainer<T>();
        }

        public void AddDataContainer<T>(T container) where T : class
        {
            if (_dataContainer == null)
                _dataContainer = new DataContainer(); //not sure, maybe save some memory?

            _dataContainer.AddDataContainer(container);
        }

        #endregion

        #region Position

        protected internal Vector2 CachedGridPos;
        protected internal Vector3 CachedWorldPos;
        protected internal Vector3 CachedEntityCenterWorldPos;
        public virtual Vector2 GridPos => CachedGridPos;
        public virtual Vector3 WorldPos => CachedWorldPos;
        public virtual Vector3 EntityCenterWorldPos => CachedEntityCenterWorldPos;
        public float Distance => Vector2.Distance(GridPos, PlayerInfo.GridPos);

        #endregion
    }

    internal class NewWorldEntityParams : NewCachedEntityParams
    {
        internal NewWorldEntityParams(uint id, long address, string metadata, long metadataAddress, uint scanNumber) : base(address, metadata, metadataAddress)
        {
            Id = id;
            ScanNumber = scanNumber;
        }

        public uint Id { get; }
        public uint ScanNumber { get; }
    }
}
