using PoeHUD.Models.Enums;
using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class InventoryList : RemoteMemoryObject
    {
        private int ListStart => M.ReadInt(Address + 0x70);
        private int ListEnd => M.ReadInt(Address + 0x74);
        public int InventoryCount => (ListEnd - ListStart) / 16;

        public List<Inventory> Inventories
        {
            get
            {
                var list = new List<Inventory>();
                int inventoryCount = InventoryCount;
                if (inventoryCount > 50 || inventoryCount <= 0)
                {
                    return list;
                }
                for (int i = 0; i < inventoryCount; i++)
                {
                    list.Add(ReadObject<Inventory>(ListStart + 8 + i * 16));
                }
                return list;
            }
        }

        public Inventory this[InventoryIndex inv]
        {
            get
            {
                var num = (int)inv;
                return ReadObject<Inventory>(ListStart + 8 + num * 0x10);
            }
        }
    }
}