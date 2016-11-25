using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class EntityList : RemoteMemoryObject
    {
        public IEnumerable<Entity> Entities => EntitiesAsDictionary.Values;

        public Dictionary<long, Entity> EntitiesAsDictionary
        {
            get
            {
                var dictionary = new Dictionary<long, Entity>();
                CollectEntities(M.ReadInt(Address), dictionary);
                return dictionary;
            }
        }

        private void CollectEntities(long addr, Dictionary<long, Entity> list)
        {
            long num = addr;
            addr = M.ReadLong(addr + 4);
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
                    long key = M.ReadLong(nextAddr + 0x14, 0x14);
                    if (!list.ContainsKey(key))
                    {
                        long address = M.ReadLong(nextAddr + 0x14);
                        var entity = GetObject<Entity>(address);
                        list.Add(key, entity);
                    }
                    queue.Enqueue(M.ReadLong(nextAddr));
                    queue.Enqueue(M.ReadLong(nextAddr + 8));
                }
            }
        }
    }
}