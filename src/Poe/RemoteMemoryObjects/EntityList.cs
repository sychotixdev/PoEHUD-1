using System;
using System.Collections.Generic;
using PoeHUD.Framework;
using PoeHUD.Hud;
using SharpDX;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class EntityList : RemoteMemoryObject
    {
        protected EnumOffsets.EntityList Structure { get; set; }

        public EntityList(TheGame game, Memory m, EnumOffsets.EntityList structure)
        {
            this.Structure = structure;
            this.M = m;
            this.Game = game;
        }

        public IEnumerable<Entity> Entities => EntitiesAsDictionary.Values;

        public Dictionary<uint, Entity> EntitiesAsDictionary
        {
            get
            {
                var dictionary = new Dictionary<uint, Entity>();
                CollectEntities((long)Structure.entities, dictionary);
                return dictionary;
            }
        }

        private void CollectEntities(long addr, Dictionary<uint, Entity> list)
        {
            long num = addr;
            addr = M.ReadLong(addr + 0x8);
            var hashSet = new HashSet<long>();
            var queue = new Queue<long>();
            queue.Enqueue(addr);
            int loopcount = 0;
            while (queue.Count > 0)
            {
                long nextAddr = queue.Dequeue();
                if (hashSet.Contains(nextAddr))
                    continue;

                hashSet.Add(nextAddr);
                if (nextAddr != num && nextAddr != 0)
                {
                    EntityListEntry entry = GetObject<EntityListEntry>(nextAddr);
                    var entity = GetObject<Entity>((long)entry.Entity);
                    var EntityID = entity.Id;
                    if (!list.ContainsKey(EntityID))
                    {
                        list.Add(EntityID, entity);
                    }
                    queue.Enqueue((long)entry.Previous);
                    queue.Enqueue((long)entry.Next);
                }

                if (loopcount++ > 10000)
                {
                    DebugPlug.DebugPlugin.LogMsg("Entities processing limit reached (10k)", 10, Color.Yellow);
					break;
                }
            }
        }
    }

    public class EntityListEntry : StructuredRemoteMemoryObject<EnumOffsets.EntityListEntry>
    {
        public IntPtr Previous => Structure.previous;
        public IntPtr Next => Structure.next;
        public IntPtr Entity => Structure.entity;
    }
}