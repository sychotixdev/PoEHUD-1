using PoeHUD.Poe.RemoteMemoryObjects;
using System;
using System.Collections.Generic;
using PoeHUD.Hud;

namespace PoeHUD.Poe.Components
{
	public class Life : Component
    {
        private LifeRMO LifeStructure => GetObject<LifeRMO>(Address);

		public int MaxHP => Address != 0 ? LifeStructure.MaxHP : 1;
		public int ReservedFlatHP => Address != 0 ? LifeStructure.ReservedFlatHp : 0;
		public int CurHP => Address != 0 ? LifeStructure.CurHp : 1;
		public int ReservedPercentHP => Address != 0 ? LifeStructure.ReservedPercentHP : 0;
		public int MaxMana => Address != 0 ? LifeStructure.MaxMana : 1;
		public int ReservedFlatMana => Address != 0 ? LifeStructure.ReservedFlatMana : 0;
		public int CurMana => Address != 0 ? LifeStructure.CurMana : 1;
		public int ReservedPercentMana => Address != 0 ? LifeStructure.ReservedPercentMana : 0;
		public int MaxES => Address != 0 ? LifeStructure.MaxES : 0;
		public int CurES => Address != 0 ? LifeStructure.CurES : 0;
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

		//public bool CorpseUsable => M.ReadBytes(Address + 0x90, 1)[0] == 1; // Total guess, didn't verify
		private long BuffStart => (long)LifeStructure.BuffsStart;
		private long BuffEnd => (long)LifeStructure.BuffsEnd;
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

			var buffPointers = M.ReadBytes(start, (int)length);

			for (var i = 0; i < length; i += 8)
			{
				var buff = ReadObject<Buff>(BitConverter.ToInt64(buffPointers, i) + 0x08);

				if (buff.Name == buffName)
					return buff;
			}

			return null;
		}
	}

    public class LifeRMO : StructuredRemoteMemoryObject<EnumOffsets.Life>
    {
        public IntPtr BuffsStart => Structure.buffsStart;
        public IntPtr BuffsEnd => Structure.buffsEnd;
        public int MaxMana => Structure.maxMana;
        public int ReservedFlatMana => Structure.reservedFlatMana;
        public int CurMana => Structure.curMana;
        public int ReservedPercentMana => Structure.reservedPercentMana;
        public int MaxES => Structure.maxES;
        public int CurES => Structure.curES;
        public int MaxHP => Structure.maxHP;
        public int ReservedFlatHp => Structure.reservedFlatHp;
        public int CurHp => Structure.curHp;
        public int ReservedPercentHP => Structure.reservedPercentHP;
    }
}
