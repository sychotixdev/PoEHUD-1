using PoeHUD.Poe.RemoteMemoryObjects;
using System.Collections.Generic;

namespace PoeHUD.Poe.Components
{
    public class Life : Component
    {
        public int MaxHP => Address != 0 ? M.ReadInt(Address + 0x34) : 1;
        public int CurHP => Address != 0 ? M.ReadInt(Address + 0x38) : 1;
        public int ReservedHP => Address != 0 ? M.ReadInt(Address + 0x40) : 0;
        public int MaxMana => Address != 0 ? M.ReadInt(Address + 0x64) : 1;
        public int CurMana => Address != 0 ? M.ReadInt(Address + 0x68) : 1;
        public int ReservedMana => Address != 0 ? M.ReadInt(Address + 0x70) : 0;
        public int MaxES => Address != 0 ? M.ReadInt(Address + 0x90) : 0;
        public int CurES => Address != 0 ? M.ReadInt(Address + 0x94 ) : 0;
        public float HPPercentage => CurHP / (float)(MaxHP - ReservedHP);
        public float MPPercentage => CurMana / (float)(MaxMana - ReservedMana);

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

        public List<Buff> Buffs
        {
            get
            {
                var list = new List<Buff>();
                int start = M.ReadInt(Address + 0xB0);
                int end = M.ReadInt(Address + 0xB4);
                int count = (end - start) / 4;
                if (count <= 0 || count > 32)
                {
                    return list;
                }
                for (int i = 0; i < count; i++)
                {
                    list.Add(ReadObject<Buff>(M.ReadInt(start + i * 4) + 4));
                }
                return list;
            }
        }

        public bool HasBuff(string buff)
        {
            return Buffs.Exists(x => x.Name == buff);
        }

		//public bool CorpseUsable => M.ReadBytes(Address + 0xF8, 1)[0] == 1; // not sure this is right, didn't bother to check
	}
}