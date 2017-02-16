using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class Inventory : RemoteMemoryObject
    {
        public long ItemCount => M.ReadLong(Address + 0x410, 0x5F0, 0x50);
        public int Width => 0;
        public int Height => 0;

        public List<Entity> Items
        {
            get
            {
                var list = new List<Entity>();
                // Max size of Player Inventory excluding stashes.
                if (ItemCount > 60 || ItemCount <= 0)
                {
                    return list;
                }
                var hashSet = new HashSet<long>();
                long itmIndex = 0;
                long itmAddr = 0;

                long invIndex = 0;
                long invAddr = M.ReadLong(Address + 0x410, 0x5F0, 0x30);
                while ( itmIndex < ItemCount)
                {
                    itmAddr = M.ReadLong(invAddr + (invIndex * 8));
                    if ( itmAddr != 0 && !hashSet.Contains(itmAddr) )
                    {
                        list.Add(ReadObject<Entity>(itmAddr));
                        hashSet.Add(itmAddr);
                        itmIndex++;
                    }
                    invIndex++;
                }
                return list;
            }
        }
    }
}