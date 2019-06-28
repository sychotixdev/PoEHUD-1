using System;
using PoeHUD.EntitiesCache;
using PoeHUD.EntitiesCache.CacheControllers;
using PoeHUD.EntitiesCache.ComponentsCache;
using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.Models
{
    public sealed class AreaInstance
    {
        internal readonly EntitiesAreaCache EntitiesCache;

        /// <summary>
        /// Holds all world entities component cache
        /// </summary>
        internal readonly AreaEntityComponentsCache WorldEntitiesComponentsCache;

        /// <summary>
        /// Holds all item entities component cache
        /// </summary>
        internal readonly AreaEntityComponentsCache ItemEntitiesComponentsCache;
        private DateTime _creationTime;
        private DataContainer _dataContainer;
        public DateTime TimeEntered = DateTime.Now;

        public AreaInstance(AreaTemplate area, uint hash, int realLevel)
        {
            Area = area;
            Hash = hash;
            RealLevel = realLevel;
            Name = area.Name;
            Act = area.Act;
            IsTown = area.IsTown;
            HasWaypoint = area.HasWaypoint;
            IsMap = area.IsMap;
            IsHideout = area.RawName.ToLower().Contains("hideout");
            _creationTime = DateTime.Now;
            Current = this;
            EntitiesCache = new EntitiesAreaCache();
            WorldEntitiesComponentsCache = new AreaEntityComponentsCache();
            ItemEntitiesComponentsCache = new AreaEntityComponentsCache();
            UpdateCachesSingleton();
        }

        public int RealLevel { get; }
        public string Name { get; }
        public int Act { get; }
        public bool IsTown { get; }
        public bool IsHideout { get; }
        public bool HasWaypoint { get; }
        public bool IsMap { get; }
        public uint Hash { get; }
        public bool IsCombatArea => !IsTown && !IsHideout;
        public AreaTemplate Area { get; }
        public static AreaInstance Current { get; private set; }
        public string DisplayName => string.Concat(Name, " (", RealLevel, ")");
        /// <summary>
        ///     For deleting old maps data from cache.
        /// </summary>
        internal TimeSpan TimeExistInCache => DateTime.Now - _creationTime;

        public override string ToString()
        {
            return $"{Name} ({RealLevel}) #{Hash}";
        }

        public static string GetTimeString(TimeSpan timeSpent)
        {
            var allsec = (int) timeSpent.TotalSeconds;
            var secs = allsec % 60;
            var mins = allsec / 60;
            var hours = mins / 60;
            mins = mins % 60;
            return string.Format(hours > 0 ? "{0}:{1:00}:{2:00}" : "{1}:{2:00}", hours, mins, secs);
        }

        internal void PickedFromCache()
        {
            Current = this;
            _creationTime = DateTime.Now;//Update the time if player re-entered area
            UpdateCachesSingleton();
        }

        private void UpdateCachesSingleton()
        {
            EntitiesAreaCache.Current = Current.EntitiesCache;
            MonstersController.Current = EntitiesAreaCache.Current.Monsters;
            AreaEntityComponentsCache.WorldEntitiesComponentsCache = Current.WorldEntitiesComponentsCache;
            AreaEntityComponentsCache.ItemEntitiesComponentsCache = Current.ItemEntitiesComponentsCache;
        }

        #region Data Container

        /// <summary>
        /// Used for holding per-area custom data
        /// </summary>
        public T GetDataContainer<T>() where T : class
        {
            return _dataContainer?.GetDataContainer<T>();
        }

        /// <summary>
        /// Used for holding per-area custom data
        /// </summary>
        public T GetOrCreateDataContainer<T>() where T : class, new()
        {
            if (_dataContainer == null)
                _dataContainer = new DataContainer(); //not sure, maybe save some memory?

            return _dataContainer.GetOrCreateDataContainer<T>();
        }

        /// <summary>
        /// Used for holding per-area custom data
        /// </summary>
        public void AddDataContainer<T>(T container) where T : class
        {
            if (_dataContainer == null)
                _dataContainer = new DataContainer(); //not sure, maybe save some memory?

            _dataContainer.AddDataContainer(container);
        }

        #endregion
    }
}
