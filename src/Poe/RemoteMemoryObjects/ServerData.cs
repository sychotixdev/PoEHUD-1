using System;
using System.Collections.Generic;
using System.Linq;
using PoeHUD.Poe.Elements;
using PoeHUD.Controllers;
using PoeHUD.Hud;
using PoeHUD.Poe.Components;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class ServerData : StructuredRemoteMemoryObject<EnumOffsets.ServerData>
    {
        #region PlayerData
        
        public bool IsInGame => GameStateController.IsInGameState;

        #endregion


        #region Inventories
        public List<InventoryHolder> PlayerInventories
        {
            get
            {
                var firstAddr = (long)Structure.playerInventoriesFirstAddress;
                var lastAddr = (long)Structure.playerInventoriesLastAddress;
                return M.ReadStructsArray<InventoryHolder>(firstAddr, lastAddr, InventoryHolder.StructSize, 400);
            }
        }

        #region Utils functions
        public ServerInventory GetPlayerInventoryBySlot(InventorySlotE slot)
        {
            foreach (var inventory in PlayerInventories)
            {
                if (inventory.Inventory.InventSlot == slot)
                {
                    return inventory.Inventory;
                }
            }
            return null;
        }
        public ServerInventory GetPlayerInventoryByType(InventoryTypeE type)
        {
            foreach (var inventory in PlayerInventories)
            {
                if (inventory.Inventory.InventType == type)
                {
                    return inventory.Inventory;
                }
            }
            return null;
        }

        public ServerInventory GetPlayerInventoryBySlotAndType(InventoryTypeE type, InventorySlotE slot)
        {
            foreach (var inventory in PlayerInventories)
            {
                if (inventory.Inventory.InventType == type && inventory.Inventory.InventSlot == slot)
                {
                    return inventory.Inventory;
                }
            }
            return null;
        }

        #endregion
        #endregion
    }
}
