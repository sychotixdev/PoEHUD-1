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
    public class PassiveSkills : FileInMemory
    {
        public Dictionary<int, PassiveSkill> PassiveSkillsDictionary = new Dictionary<int, PassiveSkill>();

        public PassiveSkills(Memory m, long address)
            : base(m, address)
        {
            CheckCache(); //temporary
        }

        public PassiveSkill GetPassiveSkillByPassiveId(int index)
        {
            CheckCache();

            PassiveSkill result;
            if (PassiveSkillsDictionary.TryGetValue(index, out result))
                result.ReadData();

            return result;
        }
        public PassiveSkill GetPassiveSkillById(string id)
        {
            CheckCache();

            var result = PassiveSkillsDictionary.Values.ToList().Find(x => x.Id == id);
            result?.ReadData();
            return result;
        }

        public PassiveSkill GetAreaByAddress(long address)
        {
            CheckCache();

            var result = PassiveSkillsDictionary.Values.ToList().Find(x => x.Address == address);
            result?.ReadData();
            return result;
        }

        public void CheckCache()
        {
            if (PassiveSkillsDictionary.Count != 0)
                return;
            
            foreach (long addr in RecordAddresses())
            {
                var r = new PassiveSkill(M, addr);
                if (!PassiveSkillsDictionary.ContainsKey(r.PassiveId))
                    PassiveSkillsDictionary.Add(r.PassiveId, r);
            }
        }
    }

    public class PassiveSkill
    {
        public readonly long Address;
        public readonly int PassiveId;
        public string Id { get; internal set; }
        public string Name { get; internal set; }
        public string Icon => M.ReadStringU(M.ReadLong(Address + 0x8), 255);//Read on request
        private Memory M;

        public PassiveSkill(Memory m, long address)
        {
            M = m;
            Address = address;
            PassiveId = m.ReadInt(Address + 0x30);
        }

        internal void ReadData()
        {
            Id = M.ReadStringU(M.ReadLong(Address), 255);
            Name = M.ReadStringU(M.ReadLong(Address + 0x34), 255);
        }

        public List<Tuple<StatRecord, int>> Stats
        {
            get
            {
                var result = new List<Tuple<StatRecord, int>>();

                var statsCount = M.ReadInt(Address + 0x10);
                var pointerToStats = M.ReadLong(Address + 0x18);
                pointerToStats += 8;//Skip first

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
            return M.ReadInt(Address + 0x20 + index * 4);
        }

        public override string ToString()
        {
            return $"{Name}, Id: {Id}, PassiveId: {PassiveId}";
        }
    }
}