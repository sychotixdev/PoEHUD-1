using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryPreview
{
    public struct CellData
    {
        public bool IsDrawn_Flag;
        public bool IsUsed { get; set; }
        public bool IsStackable;
        public int CurrentStackSize;
        public int MaxStackSize;
        public string ItemName;
        public int ItemSizeX;
        public int ItemSizeY;
        public string IconMetadata;

        public void SetItem(string itemName, bool stackable, int currentStackSize, int maxStackSize, int itemSizeX, int itemSizeY, string iconMetadata)
        {
            IsUsed = true;
            ItemName = itemName;
            IsStackable = stackable;
            CurrentStackSize = currentStackSize;
            MaxStackSize = maxStackSize;
            ItemSizeX = itemSizeX;
            ItemSizeY = itemSizeY;
            IconMetadata = iconMetadata;
        }
    }

}
