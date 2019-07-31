using PoeHUD.Models;
using PoeHUD.Models.Enums;
using PoeHUD.Poe.RemoteMemoryObjects;
using System.Collections.Generic;
using System.Linq;

namespace PoeHUD.Poe.Components
{
    public class Mods : Component
    {

        public List<ItemMod> ItemMods
        {
            get
            {
                var implicitMods = GetMods(0x90, 0x98);
                var explicitMods = GetMods(0xA8, 0xB0);
                return implicitMods.Concat(explicitMods).ToList();
            }
        }

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
