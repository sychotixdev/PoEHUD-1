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
    public class LabyrinthTrials : FileInMemory
    {
        public Dictionary<int, LabyrinthTrialWrapper> LabyrinthTrialsDictionary = new Dictionary<int, LabyrinthTrialWrapper>();

        public LabyrinthTrials(Memory m, long address)
            : base(m, address)
        {
        }
        
        public void ReloadCache()
        {
            LabyrinthTrialsDictionary.Clear();

            var idCounter = 0;
            foreach (long addr in RecordAddresses())
            {
                var r = new LabyrinthTrialWrapper(M, addr, idCounter);
                LabyrinthTrialsDictionary.Add(r.Index, r);
                idCounter++;
            }
        }

        public List<LabyrinthTrialWrapper> GetTrialAreas()
        {
            if (LabyrinthTrialsDictionary.Count == 0)
                ReloadCache();

            return LabyrinthTrialsDictionary.Values.ToList();
        }

        public class LabyrinthTrialWrapper
        {
            public readonly int Index;
            public long Address { get; private set; }

            public WorldArea area;
            public WorldArea Area
            {
                get
                {
                    if(area == null)
                    {
                        var areaPtr = GameController.Instance.Memory.ReadLong(Address + 0x8);
                        area = GameController.Instance.Files.WorldAreas.GetAreaByAddress(areaPtr);
                        area.ReadData();
                    }
                    return area;
                }
            }

            public LabyrinthTrialWrapper(Memory m, long addr, int id)
            {
                Address = addr;
                Index = id;

                //Unknown shit
                //int1 = m.ReadInt(Address + 0x10);
                //int2 = m.ReadInt(Address + 0x14);
                //int3 = m.ReadInt(Address + 0x18);
            }
        }
    }
}