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
        //We mark this fields as private coz we don't allow to read them directly. Optimisation. Use methods instead
        private Dictionary<string, WorldArea> WorldAreaDictionary = new Dictionary<string, WorldArea>(StringComparer.OrdinalIgnoreCase);
        private List<WorldArea> WorldAreaList = new List<WorldArea>();

        public WorldAreas(Memory m, long address)
            : base(m, address)
        {
        }

        public WorldArea GetAreaById(string areaId)
        {
            CheckCache();

            WorldArea result;
            WorldAreaDictionary.TryGetValue(areaId, out result);
            return result;
        }
        public WorldArea GetAreaByAreaId(int index)
        {
            CheckCache();
            return WorldAreaList.Find(x => x.Index == index);
        }
        public WorldArea GetAreaByAddress(long address)
        {
            CheckCache();
            return WorldAreaList.Find(x => x.Address == address);
        }

        private void CheckCache()
        {
            if (WorldAreaDictionary.Count != 0)
                return;

            var indexCounter = 0;
            foreach (long addr in RecordAddresses())
            {
                var r = GameController.Instance.Game.IngameState.GetObject<WorldArea>(addr);
                r.Index = indexCounter++;
                r.Id = M.ReadStringU(M.ReadLong(addr), 255);

                if (!WorldAreaDictionary.ContainsKey(r.Id))
                {
                    WorldAreaDictionary.Add(r.Id, r);
                    WorldAreaList.Add(r);
                }
            }
        }
    }
}