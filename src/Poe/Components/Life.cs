using PoeHUD.Poe.RemoteMemoryObjects;
using System.Collections.Generic;
using System;

namespace PoeHUD.Poe.Components
{
    public class Life : Component
    {
        public int MaxHP => Address != 0 ? M.ReadInt(Address + 0x50) : 1;
        public int CurHP => Address != 0 ? M.ReadInt(Address + 0x54) : 1;
        public int ReservedFlatHP => Address != 0 ? M.ReadInt(Address + 0x5C) : 0;
        public int ReservedPercentHP => Address != 0 ? M.ReadInt(Address + 0x60) : 0;
        public int MaxMana => Address != 0 ? M.ReadInt(Address + 0x80) : 1;
        public int CurMana => Address != 0 ? M.ReadInt(Address + 0x84) : 1;
        public int ReservedFlatMana => Address != 0 ? M.ReadInt(Address + 0x8C) : 0;
        public int ReservedPercentMana => Address != 0 ? M.ReadInt(Address + 0x90) : 0;
        public int MaxES => Address != 0 ? M.ReadInt(Address + 0xB0) : 0;
        public int CurES => Address != 0 ? M.ReadInt(Address + 0xB4) : 0;
        public float HPPercentage => CurHP / (float)(MaxHP - ReservedFlatHP - Math.Round(ReservedPercentHP * 0.01 * MaxHP));
        public float MPPercentage => CurMana / (float)(MaxMana - ReservedFlatMana - Math.Round(ReservedPercentMana * 0.01 * MaxMana));

        public float ESPercentage
        {
            get
            {
                if (MaxES != 0)
                {
                    return CurES / (float)MaxES;
                }
                return 0f;
            }
        }

        public bool CorpseUsable => M.ReadBytes(Address + 0x11C, 1)[0] == 1; // 0x11c or 0x13c, probably

        public List<Buff> Buffs
        {
            get
            {
                var list = new List<Buff>();
                int start = M.ReadInt(Address + 0xD8);
                int end = M.ReadInt(Address + 0xE0);
                int count = (end - start) / 8;
                if (count <= 0 || count > 32)
                {
                    return list;
                }
                for (int i = 0; i < count; i++)
                {
                    list.Add(ReadObject<Buff>(M.ReadInt(start + i * 8) + 8));
                }
                return list;
            }
        }

        public bool HasBuff(string buff)
        {
            return Buffs.Exists(x => x.Name == buff);
        }
    }
}