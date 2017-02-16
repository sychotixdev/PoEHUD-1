using PoeHUD.Models.Enums;
using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class InventoryList : RemoteMemoryObject
    {
        public int InventoryCount => 15;

        public List<Inventory> Inventories
        {
            get
            {
                var list = new List<Inventory>();
                for (int i = 0; i < InventoryCount; i++)
                {
                    list.Add(ReadObjectAt<Inventory>(i * 8));
                }
                return list;
            }
        }

        public Inventory this[InventoryIndex inv]
        {
            get
            {
                var num = (int)inv;
                return ReadObjectAt<Inventory>(num * 8);
            }
        }
    }
}