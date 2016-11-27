using PoeHUD.Framework;
using System;
using System.Collections.Generic;

namespace PoeHUD.Poe.FilesInMemory
{
    public class ModsDat : FileInMemory
    {
        public enum ModType
        {
            Prefix = 1,
            Suffix = 2,
            Hidden = 3,
            NemesisMod = 4,
            Other = 5
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
                bool addToItemIiers = r.Domain != 3;
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
            public const int NumberOfStats = 4;
            public static IComparer<ModRecord> ByLevelComparer = new LevelComparer();
            public readonly string Key;
            public ModType AffixType;
            public int Domain;
            public string Group;
            public int MinLevel;
            public StatsDat.StatRecord[] StatNames; // Game refers to Stats.dat line
            public IntRange[] StatRange;
            public int[] TagChances;
            public TagsDat.TagRecord[] Tags; // Game refers to Tags.dat line
            public long Unknown8;//Unknown pointer
            public string UserFriendlyName;
            // more fields can be added (see in visualGGPK)

            public ModRecord(Memory m, StatsDat sDat, TagsDat tagsDat, long addr)
            {
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

                Domain = m.ReadInt(addr + 0x60);

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

                TagChances = new int[m.ReadInt(addr + 0xA8)];
                long tc = m.ReadLong(addr + 0xB0);
                for (int i = 0; i < Tags.Length; i++)
                    TagChances[i] = m.ReadInt(tc + 4 + 4 * i);
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