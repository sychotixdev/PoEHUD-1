using PoeHUD.Poe.RemoteMemoryObjects;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct LifeStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
        [FieldOffset(0x88)]
        public int MaxHP;
        [FieldOffset(0x8C)]
        public int CurHP;
        [FieldOffset(0x94)]
        public int ReservedFlatHP;
        [FieldOffset(0x98)]
        public int ReservedPercentHP;
        [FieldOffset(0xC8)]
        public int MaxMana;
        [FieldOffset(0xCC)]
        public int CurMana;
        [FieldOffset(0xD4)]
        public int ReservedFlatMana;
        [FieldOffset(0xD8)]
        public int ReservedPercentMana;
        [FieldOffset(0x100)]
        public int MaxES;
        [FieldOffset(0x104)]
        public int CurES;
        [FieldOffset(0x128)]
        public int BuffStartPtr;
        [FieldOffset(0x130)]
        public int BuffEndPtr;
    }

    public class Life : StructuredRemoteMemoryObject<LifeStruct>, Component
	{
        public Entity Owner => GetObject<Entity>(Structure.OwnerPtr);

        public int MaxHP => Address != 0 ? Structure.MaxHP : 1;
		public int CurHP => Address != 0 ? Structure.CurHP : 1;
		public int ReservedFlatHP => Address != 0 ? Structure.ReservedFlatHP : 0;
		public int ReservedPercentHP => Address != 0 ? Structure.ReservedPercentHP : 0;
		public int MaxMana => Address != 0 ? Structure.MaxMana : 1;
		public int CurMana => Address != 0 ? Structure.CurMana : 1;
		public int ReservedFlatMana => Address != 0 ? Structure.ReservedFlatMana : 0;
		public int ReservedPercentMana => Address != 0 ? Structure.ReservedPercentMana : 0;
		public int MaxES => Address != 0 ? Structure.MaxES : 0;
		public int CurES => Address != 0 ? Structure.CurES : 0;
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
		private long BuffStart => Structure.BuffStartPtr;
		private long BuffEnd => Structure.BuffEndPtr;
		private long MaxBuffCount => 512; // Randomly bumping to 512 from 32 buffs... no idea what real value is.
		public List<Buff> Buffs
		{
			get
			{
				var list = new List<Buff>();
				long start = BuffStart;
				long end = BuffEnd;
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

		public bool HasBuff(string buff)
		{
			long start = BuffStart;
			long end = BuffEnd;
			long length = BuffEnd - BuffStart;
			if (length <= 0 || length >= MaxBuffCount * 8)
				return false;
			byte[] buffPointers = M.ReadBytes(start, (int)length);
			Buff tmp = null;
			for (int i = 0; i < length; i += 8)
			{
				tmp = ReadObject<Buff>(BitConverter.ToInt64(buffPointers, i) + 0x08);
				if (tmp.Name == buff)
					return true;
			}
			return false;
		}
	}
}
