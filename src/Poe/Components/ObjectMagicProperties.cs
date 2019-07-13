using System.Collections.Generic;
using PoeHUD.Models.Enums;

namespace PoeHUD.Poe.Components
{
    public class ObjectMagicProperties : Component
    {
        public MonsterRarity Rarity
        {
            get
            {
                if (Address != 0)
                    return (MonsterRarity) M.ReadInt(Address + 0x7C);

                return MonsterRarity.White;
            }
        }

        public List<string> Mods
        {
            get
            {
                if (Address == 0)
                    return new List<string>();

                var begin = M.ReadLong(Address + 0x98);
                var end = M.ReadLong(Address + 0xA0);
                var list = new List<string>();

                if (begin == 0 || end == 0)
                    return list;

                var stuckCounter = 0;
                for (var i = begin; i < end; i += 0x28)
                {
                    var mod = M.ReadStringU(M.ReadLong(i + 0x20, 0));
                    list.Add(mod);

                    if (stuckCounter++ > 100)
                        break;
                }

                return list;
            }
        }
    }
}
