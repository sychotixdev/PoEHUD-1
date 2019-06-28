using System;
using System.Collections.Generic;
using System.Linq;
using PoeHUD.EntitiesCache.CachedEntities;
using PoeHUD.Models;
using PoeHUD.Plugins;

namespace PoeHUD.Controllers
{
    public class AreaController
    {
        public static AreaController Instance { get; private set; }
        private const double DELETE_FROM_CACHE_OLD_AREA_MIN = 15; //TODO: To core config
        private readonly Dictionary<uint, AreaInstance> _areasCache = new Dictionary<uint, AreaInstance>();
        private readonly GameController _gController;

        public AreaController(GameController gameController)
        {
            Instance = this;
            _gController = gameController;
            CreateNewArea();
            PlayerInfo.UpdatePlayer();
            PlayerInfo.UpdateInfo();
        }

        public AreaInstance CurrentArea { get; private set; }
        [Obsolete("Use OnAreaChange event in plugin to avoid memory leek")]
        public event Action<AreaController> AreaChange;

        public void RefreshState()
        {
            if (!_gController.InGame)
                return;

            _gController.Cache.UpdateCache();

            var inGameData = _gController.Game.InGameState.Data;
            var areaHash = inGameData.CurrentAreaHash;

            if (CurrentArea?.Hash != areaHash)
            {
                if (_areasCache.TryGetValue(areaHash, out var currentAreaData))
                {
                    CurrentArea = currentAreaData;
                    currentAreaData.PickedFromCache();
                }
                else
                {
                    CreateNewArea();
                }

                PlayerInfo.UpdatePlayer();
                PlayerInfo.UpdateInfo();

                AreaChange?.Invoke(this);
            }
        }

        internal void TriggerAreaChange()
        {
            AreaChange?.Invoke(this);
        }

        private void CreateNewArea()
        {
            var inGameData = _gController.Game.InGameState.Data;
            var areaHash = inGameData.CurrentAreaHash;
            var areaTemplate = inGameData.CurrentArea;
            ClearOldAreasInCache();
            CurrentArea = new AreaInstance(areaTemplate, areaHash, inGameData.CurrentAreaLevel);

            if (CurrentArea.Name != "Azurite Mine") //ignore delve caching, we cannot re-enter same area
            {
                _areasCache.Add(areaHash, CurrentArea);
            }
        }

        private void ClearOldAreasInCache()
        {
            //TODO: Switch to amount of cached areas (5 max) instead of time
            foreach (var cachedAreaData in _areasCache.Values.ToList())
            {
                if (cachedAreaData.TimeExistInCache.TotalMinutes > DELETE_FROM_CACHE_OLD_AREA_MIN)
                {
                    BasePlugin.LogMessage($"Removing old map from cache: {cachedAreaData.Name}", 5);
                    _areasCache.Remove(cachedAreaData.Hash);
                }
            }
        }
    }
}
