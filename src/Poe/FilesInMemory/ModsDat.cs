using PoeHUD.Framework;
using System;
using System.Collections.Generic;

namespace PoeHUD.Poe.FilesInMemory
{
    public class ModsDat : FileInMemory
    {
        public enum ModType
        {
            // Details: http://pathofexile.gamepedia.com/Modifiers#Mod_Generation_Type
            Prefix = 1,
            Suffix = 2,
            Unique = 3,
            Nemesis = 4,
            Corrupted = 5,
            BloodLines = 6,
            Torment = 7,
            Tempest = 8,
            Talisman = 9,
            Enchantment = 10,
            EssenceMonster = 11
        }

        public enum ModDomain
        {
            // Details: http://pathofexile.gamepedia.com/Modifiers#Mod_Domain
            Item = 1,
            Flask = 2,
            Monster = 3,
            Chest = 4,
            Area = 5,
            unknown1 = 6,
            unknown2 = 7,
            unknown3 = 8,
            Stance = 9,
            Master = 10,
            Jewel = 11,
            Atlas = 12,
            LeagueStone = 13
        }

        public Dictionary<string, ModRecord> records =
            new Dictionary<string, ModRecord>(StringComparer.OrdinalIgnoreCase);

        public Dictionary<Tuple<string, ModType>, List<ModRecord>> recordsByTier =
            new Dictionary<Tuple<string, ModType>, List<ModRecord>>();

        public ModsDat(Memory m, long address, StatsDat sDat, TagsDat tagsDat) : base(m, address)
        {
            loadItems(sDat, tagsDat);
        }

        private void loadItems(StatsDat sDat, TagsDat tagsDat)
        {
            foreach (long addr in RecordAddresses())
            {
                var r = new ModRecord(M, sDat, tagsDat, addr);
                if (records.ContainsKey(r.Key))
                    continue;

                records.Add(r.Key, r);
                bool addToItemIiers = r.Domain != ModDomain.Monster;
                if (!addToItemIiers) continue;
                Tuple<string, ModType> byTierKey = Tuple.Create(r.Group, r.AffixType);
                List<ModRecord> groupMembers;
                if (!recordsByTier.TryGetValue(byTierKey, out groupMembers))
                {
                    groupMembers = new List<ModRecord>();
                    recordsByTier[byTierKey] = groupMembers;
                }
                groupMembers.Add(r);
            }
            foreach (var list in recordsByTier.Values)
            {
                list.Sort(ModRecord.ByLevelComparer);
            }
        }

        public class ModRecord
        {
            public long Address;
            public const int NumberOfStats = 4;
            public static IComparer<ModRecord> ByLevelComparer = new LevelComparer();
            public readonly string Key;
            public ModType AffixType;
            public ModDomain Domain;
            public string Group;
            public int MinLevel;
            public StatsDat.StatRecord[] StatNames; // Game refers to Stats.dat line
            public IntRange[] StatRange;
            public Dictionary<string, int> TagChances;
            public TagsDat.TagRecord[] Tags; // Game refers to Tags.dat line
            public long Unknown8;//Unknown pointer
            public string UserFriendlyName;
            public bool IsEssence;
            public string Tier;
            // more fields can be added (see in visualGGPK)

            public ModRecord(Memory m, StatsDat sDat, TagsDat tagsDat, long addr)
            {
                Address = addr;
                Key = m.ReadStringU(m.ReadLong(addr + 0));
                Unknown8 = m.ReadLong(addr + 0x8);
                MinLevel = m.ReadInt(addr + 0x1C);

                StatNames = new[]
                {
                    m.ReadLong(addr + 0x28) == 0
                        ? null
                        : sDat.records[m.ReadStringU(m.ReadLong(m.ReadLong(addr + 0x28)))],
                    m.ReadLong(addr + 0x38) == 0
                        ? null
                        : sDat.records[m.ReadStringU(m.ReadLong(m.ReadLong(addr + 0x38)))],
                    m.ReadLong(addr + 0x48) == 0
                        ? null
                        : sDat.records[m.ReadStringU(m.ReadLong(m.ReadLong(addr + 0x48)))],
                    m.ReadLong(addr + 0x58) == 0
                        ? null
                        : sDat.records[m.ReadStringU(m.ReadLong(m.ReadLong(addr + 0x58)))]
                };

                Domain = (ModDomain)m.ReadInt(addr + 0x60);

                UserFriendlyName = m.ReadStringU(m.ReadLong(addr + 0x64));

                AffixType = (ModType)m.ReadInt(addr + 0x6C);
                Group = m.ReadStringU(m.ReadLong(addr + 0x70));

                StatRange = new[]
                {
                    new IntRange(m.ReadInt(addr + 0x78), m.ReadInt(addr + 0x7C)),
                    new IntRange(m.ReadInt(addr + 0x80), m.ReadInt(addr + 0x84)),
                    new IntRange(m.ReadInt(addr + 0x88), m.ReadInt(addr + 0x8C)),
                    new IntRange(m.ReadInt(addr + 0x90), m.ReadInt(addr + 0x94))
                };

                Tags = new TagsDat.TagRecord[m.ReadLong(addr + 0x98)];
                long ta = m.ReadLong(addr + 0xA0);
                for (int i = 0; i < Tags.Length; i++)
                {
                    long ii = ta + 0x8 + 0x10 * i;
                    Tags[i] = tagsDat.records[m.ReadStringU(m.ReadLong(ii, 0), 255)];
                }

                TagChances = new Dictionary<string,int>(m.ReadInt(addr + 0xA8));
                long tc = m.ReadLong(addr + 0xB0);
                for (int i = 0; i < Tags.Length; i++)
                {
                    TagChances[Tags[i].Key] = m.ReadInt(tc + 4 * i);
                }
                IsEssence = m.ReadByte(addr + 0x1AC) == 0x01;
                Tier = m.ReadStringU(m.ReadLong(addr + 0x1C5));
            }

            private class LevelComparer : IComparer<ModRecord>
            {
                public int Compare(ModRecord x, ModRecord y)
                {
                    return -x.MinLevel + y.MinLevel;
                }
            }
        }
    }
}