using PoeHUD.Models;
using PoeHUD.Models.Enums;
using PoeHUD.Poe.RemoteMemoryObjects;
using System.Collections.Generic;
using System.Linq;

namespace PoeHUD.Poe.Components
{
    public class Mods : Component
    {
        public string UniqueName => Address != 0 ? M.ReadStringU(M.ReadLong(Address + 0x30, 0x8, 0x4)) + M.ReadStringU(M.ReadLong(Address + 0x30, 0x18, 4)) : string.Empty;
        public bool Identified => Address != 0 && M.ReadByte(Address + 0x88) == 1;
        public ItemRarity ItemRarity => Address != 0 ? (ItemRarity)M.ReadInt(Address + 0x8C) : ItemRarity.Normal;
        public List<ItemMod> ItemMods
        {
            get
            {
                var implicitMods = GetMods(0x90, 0x98);
                var explicitMods = GetMods(0xA8, 0xB0);
                return implicitMods.Concat(explicitMods).ToList();
            }
        }
        public int ItemLevel => Address != 0 ? M.ReadInt(Address + 0x374) : 1;
        public int RequiredLevel => Address != 0 ? M.ReadInt(Address + 0x378) : 1;
        public ItemStats ItemStats => new ItemStats(Owner);

        private List<ItemMod> GetMods(int startOffset, int endOffset)
        {
            var list = new List<ItemMod>();
            if (Address == 0)
                return list;

            long begin = M.ReadLong(Address + startOffset);
            long end = M.ReadLong(Address + endOffset);
            long count = (end - begin) / 0x28;
            
            if (count > 12)
                return list;

            //System.Windows.Forms.MessageBox.Show(begin.ToString("x"));

            for (long i = begin; i < end; i += 0x28)
                list.Add(GetObject<ItemMod>(i));

            return list;
        }
    }
}