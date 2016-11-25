using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class EntityList : RemoteMemoryObject
    {
        public IEnumerable<Entity> Entities => EntitiesAsDictionary.Values;

        public Dictionary<int, Entity> EntitiesAsDictionary
        {
            get
            {
                var dictionary = new Dictionary<int, Entity>();
                CollectEntities(M.ReadLong(Address), dictionary);
                return dictionary;
            }
        }

        private void CollectEntities(long addr, Dictionary<int, Entity> list)
        {
            long num = addr;
            addr = M.ReadLong(addr + 0x8);
            var hashSet = new HashSet<long>();
            var queue = new Queue<long>();
            queue.Enqueue(addr);
            int loopcount = 0;
            while (queue.Count > 0 && loopcount < 10000)
            {
                loopcount++;
                long nextAddr = queue.Dequeue();
                if (hashSet.Contains(nextAddr))
                    continue;

                hashSet.Add(nextAddr);
                if (nextAddr != num && nextAddr != 0)
                {
                    int EntityID = M.ReadInt(nextAddr + 0x28, 0x28);
                    if (!list.ContainsKey(EntityID))
                    {
                        long address = M.ReadLong(nextAddr + 0x28);
                        var entity = GetObject<Entity>(address);
                        list.Add(EntityID, entity);
                    }
                    queue.Enqueue(M.ReadLong(nextAddr));
                    queue.Enqueue(M.ReadLong(nextAddr + 0x10));
                }
            }
        }
    }
}