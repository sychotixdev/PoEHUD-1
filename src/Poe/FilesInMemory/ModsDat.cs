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

        public ModsDat(Memory m, int address, StatsDat sDat, TagsDat tagsDat) : base(m, address)
        {
            loadItems(sDat, tagsDat);
        }

        private void loadItems(StatsDat sDat, TagsDat tagsDat)
        {
            foreach (int addr in RecordAddresses())
            {
                var r = new ModRecord(M, sDat, tagsDat, addr);
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
            public int Unknown4;
            public string UserFriendlyName;
            // more fields can be added (see in visualGGPK)

            public ModRecord(Memory m, StatsDat sDat, TagsDat tagsDat, int addr)
            {
                Key = m.ReadStringU(m.ReadInt(addr + 0));
                Unknown4 = m.ReadInt(addr + 4);
                MinLevel = m.ReadInt(addr + 0x10);

                StatNames = new[]
                {
                    m.ReadInt(addr + 0x18) == 0
                        ? null
                        : sDat.records[m.ReadStringU(m.ReadInt(m.ReadInt(addr + 0x18)))],
                    m.ReadInt(addr + 0x20) == 0
                        ? null
                        : sDat.records[m.ReadStringU(m.ReadInt(m.ReadInt(addr + 0x20)))],
                    m.ReadInt(addr + 0x28) == 0
                        ? null
                        : sDat.records[m.ReadStringU(m.ReadInt(m.ReadInt(addr + 0x28)))],
                    m.ReadInt(addr + 0x30) == 0
                        ? null
                        : sDat.records[m.ReadStringU(m.ReadInt(m.ReadInt(addr + 0x30)))]
                };

                Domain = m.ReadInt(addr + 0x34);
                UserFriendlyName = m.ReadStringU(m.ReadInt(addr + 0x38));
                AffixType = (ModType)m.ReadInt(addr + 0x3C);
                Group = m.ReadStringU(m.ReadInt(addr + 0x40));

                StatRange = new[]
                {
                    new IntRange(m.ReadInt(addr + 0x44), m.ReadInt(addr + 0x48)),
                    new IntRange(m.ReadInt(addr + 0x4C), m.ReadInt(addr + 0x50)),
                    new IntRange(m.ReadInt(addr + 0x54), m.ReadInt(addr + 0x58)),
                    new IntRange(m.ReadInt(addr + 0x5C), m.ReadInt(addr + 0x60))
                };

                Tags = new TagsDat.TagRecord[m.ReadInt(addr + 0x64)];
                int ta = m.ReadInt(addr + 0x68);
                for (int i = 0; i < Tags.Length; i++)
                {
                    int ii = ta + 4 + 8 * i;
                    Tags[i] = tagsDat.records[m.ReadStringU(m.ReadInt(ii, 0), 255)];
                }

                TagChances = new int[m.ReadInt(addr + 0x6C)];
                int tc = m.ReadInt(addr + 0x70);
                for (int i = 0; i < Tags.Length; i++)
                    TagChances[i] = m.ReadInt(tc + 4 * i);
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