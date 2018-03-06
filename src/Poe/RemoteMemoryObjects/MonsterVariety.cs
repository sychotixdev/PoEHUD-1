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

        public string VarietyId { get; internal set; }//=> M.ReadStringU(M.ReadLong(Address));

        //public long MonsterTypePtr => M.ReadLong(Address + 0x10);//TODO

        public int ObjectSize => M.ReadInt(Address + 0x1c);
        public int MinimumAttackDistance => M.ReadInt(Address + 0x20);
        public int MaximumAttackDistance => M.ReadInt(Address + 0x24);

        public string ACTFile => M.ReadStringU(M.ReadLong(Address + 0x28));
        public string AOFile => M.ReadStringU(M.ReadLong(Address + 0x30));
        public string BaseMonsterTypeIndex => M.ReadStringU(M.ReadLong(Address + 0x38));

        public List<ModsDat.ModRecord> Mods
        {
            get
            {
                var count = M.ReadInt(Address + 0x40);
                var pointers = M.ReadSecondPointerArray_Count(M.ReadLong(Address + 0x48), count);

                return pointers.Select(x => GameController.Instance.Files.Mods.GetModByAddress(x)).ToList();
            }
        }
        public int ModelSizeMultiplier => M.ReadInt(Address + 0x64);
        public int ExperienceMultiplier => M.ReadInt(Address + 0x8c);
        public int CriticalStrikeChance => M.ReadInt(Address + 0xac);

        //public int GrantedEffectsCount => M.ReadInt(Address + 0xb4);
        //public long GrantedEffectsPtr => M.ReadLong(Address + 0xbc);

        public string AISFile => M.ReadStringU(M.ReadLong(Address + 0xc4));

        //public int ModKeysCount => M.ReadInt(Address + 0xcc);
        //public long ModKeysPtr => M.ReadLong(Address + 0xd4);
        public string MonsterName => M.ReadStringU(M.ReadLong(Address + 0xf4));

        public int DamageMultiplier => M.ReadInt(Address + 0xfc);
        public int LifeMultiplier => M.ReadInt(Address + 0x100);
        public int AttackSpeed => M.ReadInt(Address + 0x104);

        public override string ToString()
        {
            return $"Name: {MonsterName}, VarietyId: {VarietyId}, BaseMonsterTypeIndex: {BaseMonsterTypeIndex}";
        }
    }
}
