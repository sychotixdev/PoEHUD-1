using PoeHUD.Poe.RemoteMemoryObjects;
using System;
using System.Collections.Generic;

namespace PoeHUD.Poe.Components
{
	public class Life : Component
	{
		public int MaxHP => Address != 0 ? M.ReadInt(Address + 0x98) : 1;
		public int CurHP => Address != 0 ? M.ReadInt(Address + 0x9C) : 1;
		public int ReservedFlatHP => Address != 0 ? M.ReadInt(Address + 0xA4) : 0;
		public int ReservedPercentHP => Address != 0 ? M.ReadInt(Address + 0xA8) : 0;
		public int MaxMana => Address != 0 ? M.ReadInt(Address + 0xE8) : 1;
		public int CurMana => Address != 0 ? M.ReadInt(Address + 0xEC) : 1;
		public int ReservedFlatMana => Address != 0 ? M.ReadInt(Address + 0xF4): 0;
		public int ReservedPercentMana => Address != 0 ? M.ReadInt(Address + 0xF8) : 0;
		public int MaxES => Address != 0 ? M.ReadInt(Address + 0x120) : 0;
		public int CurES => Address != 0 ? M.ReadInt(Address + 0x124) : 0;
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

		//public bool CorpseUsable => M.ReadBytes(Address + 0x238, 1)[0] == 1; // Total guess, didn't verify
		private long BuffStart => M.ReadLong(Address + 0x150);
		private long BuffEnd => M.ReadLong(Address + 0x158);
		private long MaxBuffCount => 512; // Randomly bumping to 512 from 32 buffs... no idea what real value is.
		public List<Buff> Buffs
		{
			get
			{
				var list = new List<Buff>();
				long start = BuffStart;
				long length = BuffEnd - BuffStart;
				if (length <= 0 || length >= MaxBuffCount * 8) // * 8 as we buff pointer takes 8 bytes.
					return list;
				byte[] buffPointers = M.ReadBytes(start, (int)length);
				Buff tmp = null;
				for (int i = 0; i < length; i += 8)
				{
					tmp = ReadObject<Buff>(BitConverter.ToInt64(buffPointers, i) + 0x08);
					list.Add(tmp);
				}
				return list;
			}
		}

        public bool HasBuff(string buffName)
        {
            return GetBuff(buffName) != null;
        }

		public Buff GetBuff(string buffName)
		{
            var start = BuffStart;
            var end = BuffEnd;
            var length = BuffEnd - BuffStart;

            if (length <= 0 || length >= MaxBuffCount * 8)
                return null;

            var buffPointers = M.ReadBytes(start, (int) length);

            for (var i = 0; i < length; i += 8)
            {
                var buff = ReadObject<Buff>(BitConverter.ToInt64(buffPointers, i) + 0x08);

                if (buff.Name == buffName)
                    return buff;
            }

            return null;
		}
	}
}
