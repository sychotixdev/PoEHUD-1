using PoeHUD.Models.Enums;
using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class InventoryList : RemoteMemoryObject
    {
        public int InventoryCount => 15;

        public Inventory this[InventoryIndex inv]
        {
            get
            {
                var num = (int)inv;
                if (num < 0 || num >= InventoryCount)
                    return null;
                return ReadObjectAt<Inventory>(num * 8);
            }
        }
    }
}