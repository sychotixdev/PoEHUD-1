using System;
using PoeHUD.Models;
using PoeHUD.Models.Enums;
using PoeHUD.Poe.RemoteMemoryObjects;
using System.Collections.Generic;
using System.Linq;
using PoeHUD.Hud;

namespace PoeHUD.Poe.Components
{
    public class Mods : Component
    {

        private ModsRMO ModsStructure => GetObject<ModsRMO>(Address);

        public ItemRarity ItemRarity => ModsStructure.ItemRarity;

        public List<ItemMod> ItemMods
        {
            get
            {
                var implicitMods = GetMods(ModsStructure.ImplicitModsStart, ModsStructure.ImplicitModsEnd);
                var explicitMods = GetMods(ModsStructure.ExplicitModsStart, ModsStructure.ExplicitModsEnd);
                return implicitMods.Concat(explicitMods).ToList();
            }
        }

        private List<ItemMod> GetMods(long begin, long end)
        {
            var list = new List<ItemMod>();

            if (Address == 0)
                return list;

            long count = (end - begin) / 0x28;

            if (count > 12)
                return list;

            //System.Windows.Forms.MessageBox.Show(begin.ToString("x"));

            for (long i = begin; i < end; i += 0x28)
                list.Add(GetObject<ItemMod>(i));

            return list;
        }
    }

    public class ModsRMO : StructuredRemoteMemoryObject<EnumOffsets.Mods>
    {
        public ItemRarity ItemRarity => (ItemRarity) Structure.itemRarity;
        public long ImplicitModsStart => (long)Structure.implicitModsStart;
        public long ImplicitModsEnd => (long)Structure.implicitModsEnd;
        public long ExplicitModsStart => (long)Structure.explicitModsStart;
        public long ExplicitModsEnd => (long)Structure.explicitModsEnd;
    }
}
