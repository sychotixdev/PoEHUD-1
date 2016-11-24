using PoeHUD.Models.Enums;
using System.Collections.Generic;

namespace PoeHUD.Poe.Components
{
    public class ObjectMagicProperties : Component
    {
        public MonsterRarity Rarity
        {
            get
            {
                if (Address != 0)
                {
                    return (MonsterRarity)M.ReadInt(Address + 0x50);
                }
                return MonsterRarity.White;
            }
        }

        public List<string> Mods
        {
            get
            {
                if (Address == 0)
                {
                    return new List<string>();
                }
                long begin = M.ReadLong(Address + 0x60);
                long end = M.ReadLong(Address + 0x64);
                var list = new List<string>();
                if (begin == 0 || end == 0)
                {
                    return list;
                }
                for (long i = begin; i < end; i += 0x14)
                {
                    string mod = M.ReadStringU(M.ReadInt(i + 0x10, 0));
                    list.Add(mod);
                }
                return list;
            }
        }
    }
}