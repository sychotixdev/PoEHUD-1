using System;
using PoeHUD.Hud;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class ItemMod : StructuredRemoteMemoryObject<EnumOffsets.ItemMods>
    {
        private ItemModInternalRMO ItemModInternalRmo => GetObject<ItemModInternalRMO>((long)Structure.modsInternal);

        private int level;
        private string name;
        private string rawName;
        private string displayName;

        public int Value1 => ItemModInternalRmo.Value1;
        public int Value2 => ItemModInternalRmo.Value2;
        public int Value3 => ItemModInternalRmo.Value3;
        public int Value4 => ItemModInternalRmo.Value4;

        public string RawName
        {
            get
            {
                if (rawName == null)
                    ParseName();
                return rawName;
            }
        }

        public string Name
        {
            get
            {
                if (rawName == null)
                    ParseName();
                return name;
            }
        }

        public string DisplayName
        {
            get
            {
                if (rawName == null)
                    ParseName();
                return displayName;
            }
        }

        public int Level
        {
            get
            {
                if (rawName == null)
                    ParseName();
                return level;
            }
        }

        private void ParseName()
        {
            long addr = M.ReadLong((long)Structure.pathPart1);
            rawName = M.ReadStringU(addr);
            displayName = M.ReadStringU(addr + ((rawName.Length + 2)*2));
            name = rawName.Replace("_", ""); // Master Crafted mod can have underscore on the end, need to ignore
            int ixDigits = name.IndexOfAny("0123456789".ToCharArray());
            if (ixDigits < 0 || !int.TryParse(name.Substring(ixDigits), out level))
            {
                level = 1;
            }
            else
            {
                name = name.Substring(0, ixDigits);
            }
        }

        public override string ToString()
        {
            return $"{Name} ({Value1}, {Value2}, {Value3}, {Value4}";
        }
    }

    public class ItemModInternalRMO : StructuredRemoteMemoryObject<EnumOffsets.ItemModsInternal>
    {
        public int Value1 => Structure.value1;
        public int Value2 => Structure.value2;
        public int Value3 => Structure.value3;
        public int Value4 => Structure.value4;
    }
}