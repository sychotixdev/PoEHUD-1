using System;
using PoeHUD.Models.Enums;
using System.Collections.Generic;
using PoeHUD.Hud;

namespace PoeHUD.Poe.Components
{
    public class ObjectMagicProperties : Component
    {
        public ObjectMagicPropertiesRMO ObjectMagicPropertiesStructure => GetObject<ObjectMagicPropertiesRMO>(Address);

        public MonsterRarity Rarity
        {
            get
            {
                if (Address != 0)
                {
                    return (MonsterRarity)ObjectMagicPropertiesStructure.MonsterRarity;
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
                long begin = ObjectMagicPropertiesStructure.ModsStart;
                long end = ObjectMagicPropertiesStructure.ModsEnd;
                var list = new List<string>();
                if (begin == 0 || end == 0)
                {
                    return list;
                }
                for (long i = begin; i < end; i += 0x28)
                {
                    string mod = M.ReadStringU(M.ReadLong(i + 0x20, 0));
                    list.Add(mod);
                }
                return list;
            }
        }
    }

    public class ObjectMagicPropertiesRMO : StructuredRemoteMemoryObject<EnumOffsets.ObjectMagicProperties>
    {
        public int MonsterRarity => Structure.monsterRarity;
        public long ModsStart => (long)Structure.modsStart;
        public long ModsEnd => (long)Structure.modsEnd;
    }
}