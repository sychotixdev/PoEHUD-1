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
    public class MonsterVarieties : FileInMemory
    {
        //We mark this fields as private coz we don't allow to read them directly. Optimisation. Use methods instead
        private readonly Dictionary<long, MonsterVariety> MonsterVarietyAddressDictionary = new Dictionary<long, MonsterVariety>();
        private readonly Dictionary<string, MonsterVariety> MonsterVarietyMetadataDictionary = new Dictionary<string, MonsterVariety>();
        private readonly List<MonsterVariety> MonsterVarietyList = new List<MonsterVariety>();

        public List<MonsterVariety> DebugList
        {
            get
            {
                CheckCache();
                return MonsterVarietyList;
            }
        }

        public MonsterVarieties(Memory m, long address)
            : base(m, address)
        {
        }

        public MonsterVariety Translate(string metadata)
        {
            CheckCache();
            MonsterVariety result;
            MonsterVarietyMetadataDictionary.TryGetValue(metadata, out result);
            return result;
        }

        public MonsterVariety GetMonsterVarietyByAddress(long address)
        {
            CheckCache();
            MonsterVariety result;
            MonsterVarietyAddressDictionary.TryGetValue(address, out result);
            return result;
        }

        public void CheckCache()
        {
            if (MonsterVarietyAddressDictionary.Count != 0)
                return;

            var idCounter = 0;
            foreach (long addr in RecordAddresses())
            {
                var r = GameController.Instance.Game.IngameState.GetObject<MonsterVariety>(addr);
                r.Id = idCounter++;

                r.VarietyId = M.ReadStringU(M.ReadLong(addr));
                MonsterVarietyMetadataDictionary.Add(r.VarietyId, r);
                MonsterVarietyAddressDictionary.Add(addr, r);
                MonsterVarietyList.Add(r);
            }
        }
    }
}