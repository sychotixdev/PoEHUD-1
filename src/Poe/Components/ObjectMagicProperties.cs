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
                int begin = M.ReadInt(Address + 0x70);
                int end = M.ReadInt(Address + 0x74);
                var list = new List<string>();
                if (begin == 0 || end == 0)
                {
                    return list;
                }
                for (int i = begin; i < end; i += 24)
                {
                    string mod = M.ReadStringU(M.ReadInt(i + 20, 0));
                    list.Add(mod);
                }
                return list;
            }
        }
    }
}