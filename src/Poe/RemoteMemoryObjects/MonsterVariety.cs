using PoeHUD.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;
using PoeHUD.Controllers;
using PoeHUD.Poe.FilesInMemory;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class MonsterVariety : RemoteMemoryObject
    {
        public int Id { get; internal set; }

        private string varietyId;
        public string VarietyId => varietyId != null ? varietyId : varietyId = M.ReadStringU(M.ReadLong(Address));

        //public long MonsterTypePtr => M.ReadLong(Address + 0x10);//TODO

        public List<ModsDat.ModRecord> Mods
        {
            get
            {
                var count = M.ReadInt(Address + 0x40);
                var pointers = M.ReadSecondPointerArray_Count(M.ReadLong(Address + 0x48), count);

                return pointers.Select(x => GameController.Instance.Files.Mods.GetModByAddress(x)).ToList();
            }
        }

        //public int GrantedEffectsCount => M.ReadInt(Address + 0xb4);
        //public long GrantedEffectsPtr => M.ReadLong(Address + 0xbc);


        //public int ModKeysCount => M.ReadInt(Address + 0xcc);
        //public long ModKeysPtr => M.ReadLong(Address + 0xd4);
        public string MonsterName => M.ReadStringU(M.ReadLong(Address + 0xf4));

        public override string ToString()
        {
            return $"Name: {MonsterName}, VarietyId: {VarietyId}";
        }
    }
}
