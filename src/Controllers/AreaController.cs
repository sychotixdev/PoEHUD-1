using PoeHUD.Models;
using PoeHUD.Poe.RemoteMemoryObjects;
using System;

namespace PoeHUD.Controllers
{
    public class AreaController
    {
        private readonly GameController GController;

        public AreaController(GameController gameController)
        {
            GController = gameController;
        }

        [Obsolete("Use OnAreaChange event in plugin to avoid memory leek")]
        public event Action<AreaController> OnAreaChange;
        public event Action<AreaController> AreaChange;
   

        public AreaInstance CurrentArea { get; private set; }

        public void RefreshState()
        {
            if (!GController.InGame)
                return;

            GController.Cache.UpdateCache();
            var ingameData = GController.Game.IngameState.Data;
            AreaTemplate clientsArea = ingameData.CurrentArea;
            var curAreaHash = ingameData.CurrentAreaHash;

            if (CurrentArea != null && curAreaHash == CurrentArea.Hash)
                return;

            CurrentArea = new AreaInstance(clientsArea, curAreaHash, ingameData.CurrentAreaLevel);
            AreaChange?.Invoke(this);
            OnAreaChange?.Invoke(this);
        }
    }
}