using PoeHUD.Models.Interfaces;
using System.Collections.Generic;

namespace PoeHUD.Poe
{
    public sealed class Entity : RemoteMemoryObject, IEntity
    {
        private int ComponentLookup => M.ReadInt(Address, 0x48, 0);
        private int ComponentList => M.ReadInt(Address + 4);
        public string Path => M.ReadStringU(M.ReadInt(Address, 0xC));
        public int Id => M.ReadInt(Address + 0x14);
        public long LongId => (long)Id << 32 ^ Path.GetHashCode();

        /// <summary>
        /// 0x65004D = "Me"(4 bytes) from word Metadata
        /// </summary>
        public bool IsValid => M.ReadInt(Address, 0xC, 0) == 0x65004D;

        public bool IsHostile => (M.ReadByte(Address + 0x19) & 1) == 0;

        public bool HasComponent<T>() where T : Component, new()
        {
            int addr;
            return HasComponent<T>(out addr);
        }

        private bool HasComponent<T>(out int addr) where T : Component, new()
        {
            string name = typeof(T).Name;
            int componentLookup = ComponentLookup;
            addr = componentLookup;
            int i = 0;
            while (!M.ReadString(M.ReadInt(addr + 8)).Equals(name))
            {
                addr = M.ReadInt(addr);
                ++i;
                if (addr == componentLookup || addr == 0 || addr == -1 || i >= 200)
                    return false;
            }
            return true;
        }

        public T GetComponent<T>() where T : Component, new()
        {
            int addr;
            return HasComponent<T>(out addr) ? ReadObject<T>(ComponentList + M.ReadInt(addr + 0xC) * 4) : GetObject<T>(0);
        }

        public Dictionary<string, int> GetComponents()
        {
            var dictionary = new Dictionary<string, int>();
            int componentLookup = ComponentLookup;
            int addr = componentLookup;
            do
            {
                string name = M.ReadString(M.ReadInt(addr + 8));
                int componentAddress = M.ReadInt(ComponentList + M.ReadInt(addr + 0xC) * 4);
                if (!dictionary.ContainsKey(name) && !string.IsNullOrWhiteSpace(name))
                    dictionary.Add(name, componentAddress);
                addr = M.ReadInt(addr);
            } while (addr != componentLookup && addr != 0 && addr != -1);
            return dictionary;
        }

        public override string ToString()
        {
            return Path;
        }
    }
}