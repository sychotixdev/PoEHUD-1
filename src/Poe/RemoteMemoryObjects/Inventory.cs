using PoeHUD.Poe.Elements;
using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class Inventory : RemoteMemoryObject
    {
        public long ItemCount => M.ReadLong(Address + 0x410, 0x5F0, 0x50);

        // Only works if inventory is opened and currently being viewed.
        // Even if game have already fetched inventory data from server.
        public List<InventoryItemIcon> InventoryItems
        {
            get
            {
                var list = new List<InventoryItemIcon>();
                // Max size of Quad Stash.
                if (ItemCount > 576 || ItemCount <= 0)
                {
                    return list;
                }
                var hashSet = new HashSet<long>();
                long itmIndex = 0;
                long itmAddr = 0;

                long invIndex = 0;
                long invAddr = M.ReadLong(Address + 0x710);
                while (itmIndex < ItemCount)
                {
                    itmAddr = M.ReadLong(invAddr + (invIndex * 8));
                    if (itmAddr != 0)
                    {
                        list.Add(GetObject<InventoryItemIcon>(itmAddr));
                        hashSet.Add(itmAddr);
                        itmIndex++;
                    }
                    invIndex++;
                }
                return list;
            }
        }

        // Works even if inventory is currently not in view.
        // As long as game have fetched inventory data from Server.
        // Will return the item based on x,y format.
        // Give more controll to user what to do with
        // dublicate items (items taking more than 1 slot)
        // or slots where items doesn't exists (return null).
        public Entity this[int x, int y, int xLength]
        {
            get
            {
                long invAddr = M.ReadLong(Address + 0x410, 0x5F0, 0x30);
                y = y * xLength;
                long itmAddr = M.ReadLong(invAddr + ((x + y) * 8));
                return ReadObject<Entity>(itmAddr);
            }
        }
    }
}