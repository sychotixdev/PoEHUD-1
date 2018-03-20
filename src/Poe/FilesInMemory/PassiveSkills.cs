using PoeHUD.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;
using PoeHUD.Controllers;
using PoeHUD.Poe.RemoteMemoryObjects;
using StatRecord = PoeHUD.Poe.FilesInMemory.StatsDat.StatRecord;

namespace PoeHUD.Poe.FilesInMemory
{
    public class PassiveSkills : UniversalFileWrapper<PassiveSkill>
    {
        public Dictionary<int, PassiveSkill> PassiveSkillsDictionary = new Dictionary<int, PassiveSkill>();

        public PassiveSkills(Memory m, long address)
            : base(m, address)
        {
        }

        public PassiveSkill GetPassiveSkillByPassiveId(int index)
        {
            CheckCache();

            PassiveSkill result;
            PassiveSkillsDictionary.TryGetValue(index, out result);
            return result;
        }

        public PassiveSkill GetPassiveSkillById(string id)
        {
            return EntriesList.FirstOrDefault(x => x.Id == id);
        }

        protected override void EntryAdded(long addr, PassiveSkill entry)
        {
            PassiveSkillsDictionary.Add(entry.PassiveId, entry);
        }
    }

    public class PassiveSkill : RemoteMemoryObject
    {
        private int passiveId = -1;
        public int PassiveId => passiveId != -1 ? passiveId :
            passiveId = M.ReadInt(Address + 0x30);

        private string id;
        public string Id => id != null ? id :
            id = M.ReadStringU(M.ReadLong(Address), 255);

        private string name;
        public string Name => name != null ? name :
            name = M.ReadStringU(M.ReadLong(Address + 0x34), 255);

        public string Icon => M.ReadStringU(M.ReadLong(Address + 0x8), 255);//Read on request

        private List<Tuple<StatRecord, int>> stats;
        public List<Tuple<StatRecord, int>> Stats
        {
            get
            {
                if (stats == null)
                {
                    stats = new List<Tuple<StatRecord, int>>();

                    var statsCount = M.ReadInt(Address + 0x10);
                    var pointerToStats = M.ReadLong(Address + 0x18);
                    var statsPointers = M.ReadSecondPointerArray_Count(pointerToStats, statsCount);

                    stats = statsPointers.Select((x, i) =>
                    new Tuple<StatRecord, int>
                    (
                        GameController.Instance.Files.Stats.GetStatByAddress(x),
                        ReadStatValue(i)
                    )).ToList();
                }
                return stats;
            }
        }

        internal int ReadStatValue(int index)
        {
            return M.ReadInt(Address + 0x20 + index * 4);
        }

        public override string ToString()
        {
            return $"{Name}, Id: {Id}, PassiveId: {PassiveId}";
        }
    }
}