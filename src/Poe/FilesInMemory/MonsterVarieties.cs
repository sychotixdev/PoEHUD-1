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
    public class MonsterVarieties : UniversalFileWrapper<MonsterVariety>
    {
        private readonly Dictionary<string, MonsterVariety> MonsterVarietyMetadataDictionary = new Dictionary<string, MonsterVariety>();

        public MonsterVarieties(Memory m, long address)
            : base(m, address)
        {
        }

        public MonsterVariety TranslateFromMetadata(string path)
        {
            CheckCache();
            MonsterVariety result;
            MonsterVarietyMetadataDictionary.TryGetValue(path, out result);
            return result;
        }

        protected override void EntryAdded(long addr, MonsterVariety entry)
        {
            MonsterVarietyMetadataDictionary.Add(entry.VarietyId, entry);
        }
    }
}