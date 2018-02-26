using PoeHUD.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;
using PoeHUD.Controllers;
using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.Poe.FilesInMemory
{
    public partial class WorldAreas : FileInMemory
    {
        public Dictionary<string, WorldArea> WorldAreaDictionary = new Dictionary<string, WorldArea>(StringComparer.OrdinalIgnoreCase);

        public WorldAreas(Memory m, long address)
            : base(m, address)
        {
        }

        public WorldArea GetAreaById(string areaId)
        {
            CheckCache();

            WorldArea result;
            if (WorldAreaDictionary.TryGetValue(areaId, out result))
                result.ReadData();

            return result;
        }
        public WorldArea GetAreaByIndex(int index)
        {
            CheckCache();

            var result = WorldAreaDictionary.Values.ToList().Find(x => x.Index == index);
            result?.ReadData();
            return result;
        }

        public WorldArea GetAreaByAddress(long address)
        {
            CheckCache();

            var result = WorldAreaDictionary.Values.ToList().Find(x => x.Address == address);
            result?.ReadData();
            return result;
        }
        
        public void CheckCache()
        {
            if (WorldAreaDictionary.Count != 0)
                return;

            var indexCounter = 0;
            foreach (long addr in RecordAddresses())
            {
                var r = new WorldArea(M, addr, indexCounter++);
                if (!WorldAreaDictionary.ContainsKey(r.Id))
                    WorldAreaDictionary.Add(r.Id, r);
            }
        }
    }
}