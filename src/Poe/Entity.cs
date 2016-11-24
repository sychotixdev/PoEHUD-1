using PoeHUD.Models.Interfaces;
using System.Collections.Generic;

namespace PoeHUD.Poe
{
    public sealed class Entity : RemoteMemoryObject, IEntity
    {
        private long ComponentLookup => M.ReadInt(Address, 0x30, 0x18, 0);
        private int ComponentList => M.ReadInt(Address + 4);
        public string Path => M.ReadStringU(M.ReadLong(Address, 0x20));
        public bool IsValid => M.ReadInt(Address, 0x20, 0) == 0x65004D;

        public int Id => M.ReadInt(Address + 0x14);
        public int InventoryId => M.ReadInt(Address + 0x18);
        public long LongId => (long)Id << 32 ^ Path.GetHashCode();

        /// <summary>
        /// 0x65004D = "Me"(4 bytes) from word Metadata
        /// </summary>
       

        public bool IsHostile => (M.ReadByte(M.ReadInt(Address + 0x20) + 0xF8) & 1) == 0;

        public bool HasComponent<T>() where T : Component, new()
        {
            long addr;
            return HasComponent<T>(out addr);
        }

        private bool HasComponent<T>(out long addr) where T : Component, new()
        {
            string name = typeof(T).Name;
            long componentLookup = ComponentLookup;
            addr = componentLookup;
            int i = 0;
            while (!M.ReadString(M.ReadLong(addr + 8)).Equals(name))
            {
                addr = M.ReadLong(addr);
                ++i;
                if (addr == componentLookup || addr == 0 || addr == -1 || i >= 200)
                    return false;
            }
            return true;
        }

        public T GetComponent<T>() where T : Component, new()
        {
            long addr;
            return HasComponent<T>(out addr) ? ReadObject<T>(ComponentList + M.ReadLong(addr + 0xC) * 4) : GetObject<T>(0);
        }

        public Dictionary<string, long> GetComponents()
        {
            var dictionary = new Dictionary<string, long>();
            long componentLookup = ComponentLookup;
            long addr = componentLookup;
            do
            {
                string name = M.ReadString(M.ReadLong(addr + 8));
                long componentAddress = M.ReadLong(ComponentList + M.ReadLong(addr + 0xC) * 4);
                if (!dictionary.ContainsKey(name) && !string.IsNullOrWhiteSpace(name))
                    dictionary.Add(name, componentAddress);
                addr = M.ReadLong(addr);
            } while (addr != componentLookup && addr != 0 && addr != -1);
            return dictionary;
        }

        public override string ToString()
        {
            return Path;
        }
    }
}