using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoeHUD.Controllers;
using PoeHUD.Poe.FilesInMemory;
using StatRecord = PoeHUD.Poe.FilesInMemory.StatsDat.StatRecord;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class GrantedEffectsPerLevel : RemoteMemoryObject
    {
        public SkillGemWrapper SkillGemWrapper => ReadObject<SkillGemWrapper>(Address + 0x8);
  
        public int Level => M.ReadInt(Address + 0x10);
        public int RequiredLevel => M.ReadInt(Address + 0x74);
        public int ManaMultiplier => M.ReadInt(Address + 0x78);
        //public int RequirementsComparer => M.ReadInt(Address + 0x80);
        public int ManaCost => M.ReadInt(Address + 0xa8);
        public int EffectivenessOfAddedDamage => M.ReadInt(Address + 0xac);
        public int Cooldown => M.ReadInt(Address + 0xb4);


        public List<Tuple<StatRecord, int>> Stats
        {
            get
            {
                var result = new List<Tuple<StatRecord, int>>();

                var statsCount = M.ReadInt(Address + 0x14);
                var pointerToStats = M.ReadLong(Address + 0x1c);
                pointerToStats += 8;

                for (int i = 0; i < statsCount; i++)
                {
                    var datPtr = M.ReadLong(pointerToStats);
                    var stat = GameController.Instance.Files.Stats.GetStatByAddress(datPtr);
                    result.Add(new Tuple<StatRecord, int>(stat, ReadStatValue(i)));
                    pointerToStats += 16;//16 because we are reading each second pointer
                }
                return result;
            }
        }

        internal int ReadStatValue(int index)
        {
            return M.ReadInt(Address + 0x54 + index * 4);
        }


        public List<Tuple<StatRecord, int>> QualityStats
        {
            get
            {
                var result = new List<Tuple<StatRecord, int>>();

                var statsCount = M.ReadInt(Address + 0x84);
                var pointerToStats = M.ReadLong(Address + 0x8c);
                pointerToStats += 8;//Skip first

                for (int i = 0; i < statsCount; i++)
                {
                    var datPtr = M.ReadLong(pointerToStats);
                    var stat = GameController.Instance.Files.Stats.GetStatByAddress(datPtr);
                    result.Add(new Tuple<StatRecord, int>(stat, ReadQualityStatValue(i)));
                    pointerToStats += 16;//16 because we are reading each second pointer
                }
                return result;
            }
        }
        internal int ReadQualityStatValue(int index)
        {
            return M.ReadInt(Address + 0x9c + index * 4);
        }


        public List<StatRecord> TypeStats
        {
            get
            {
                var result = new List<StatRecord>();

                var statsCount = M.ReadInt(Address + 0xbc);
                var pointerToStats = M.ReadLong(Address + 0xc4);
                pointerToStats += 8;//Skip first

                for (int i = 0; i < statsCount; i++)
                {
                    var datPtr = M.ReadLong(pointerToStats);
                    var stat = GameController.Instance.Files.Stats.GetStatByAddress(datPtr);
                    result.Add(stat);
                    pointerToStats += 16;//16 because we are reading each second pointer
                }
                return result;
            }
        }
    }
}
