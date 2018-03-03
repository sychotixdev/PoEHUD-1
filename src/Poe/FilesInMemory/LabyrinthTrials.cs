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
        //We mark this fields as private coz we don't allow to read them directly. Optimisation. Use methods instead
        private readonly Dictionary<int, LabyrinthTrial> LabyrinthTrialsDictionary = new Dictionary<int, LabyrinthTrial>();
        private readonly List<LabyrinthTrial> LabyrinthTrialsList = new List<LabyrinthTrial>();

        public LabyrinthTrials(Memory m, long address)
            : base(m, address)
        {
        }
        
        public LabyrinthTrial GetLabyrinthTrialByAreaId(string id)
        {
            return GetTrialAreas().First(x => x.Area.Id == id);
        }

        public LabyrinthTrial GetLabyrinthTrialById(int index)
        {
            return GetTrialAreas().First(x => x.Id == index);
        }

        public LabyrinthTrial GetLabyrinthTrialByArea(WorldArea area)
        {
            return GetTrialAreas().First(x => x.Area == area );
        }

        public List<LabyrinthTrial> GetTrialAreas()
        {
            if (LabyrinthTrialsDictionary.Count == 0)
                ReloadCache();

            return LabyrinthTrialsList;
        }

        private void ReloadCache()
        {
            LabyrinthTrialsDictionary.Clear();
            LabyrinthTrialsList.Clear();
            
            foreach (long addr in RecordAddresses())
            {
                var lw = new LabyrinthTrial(M, addr);
                LabyrinthTrialsDictionary.Add(lw.Id, lw);
                LabyrinthTrialsList.Add(lw);
            }
        }

        public static string[] LabyrinthTrialAreaIds = new string[18]
        {
            "1_1_7_1",
            "1_2_5_1",
            "1_2_6_2",
            "1_3_3_1",
            "1_3_6",
            "1_3_15",
            "2_6_7_1",
            "2_7_4",
            "2_7_5_2",
            "2_8_5",
            "2_9_7",
            "2_10_9",
            "EndGame_Labyrinth_trials_spikes",
            "EndGame_Labyrinth_trials_spinners",
            "EndGame_Labyrinth_trials_sawblades_#",
            "EndGame_Labyrinth_trials_lava_#",
            "EndGame_Labyrinth_trials_roombas",
            "EndGame_Labyrinth_trials_arrows"
        };
    }

    public class LabyrinthTrial
    {
        public readonly int Id;
        public long Address { get; private set; }

        public WorldArea area;
        public WorldArea Area
        {
            get
            {
                if (area == null)
                {
                    var areaPtr = GameController.Instance.Memory.ReadLong(Address + 0x8);
                    area = GameController.Instance.Files.WorldAreas.GetAreaByAddress(areaPtr);
                }
                return area;
            }
        }

        public LabyrinthTrial(Memory m, long addr)
        {
            Address = addr;
            Id = m.ReadInt(Address + 0x10);

            //Unknown shit
            //int1 = m.ReadInt(Address + 0x10);
            //int2 = m.ReadInt(Address + 0x14);
            //int3 = m.ReadInt(Address + 0x18);
        }
    }
}