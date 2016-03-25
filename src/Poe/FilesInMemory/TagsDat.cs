using PoeHUD.Framework;
using System;
using System.Collections.Generic;

namespace PoeHUD.Poe.FilesInMemory
{
    public class TagsDat : FileInMemory
    {
        public Dictionary<string, TagRecord> records =
            new Dictionary<string, TagRecord>(StringComparer.OrdinalIgnoreCase);

        public TagsDat(Memory m, int address)
            : base(m, address)
        {
            loadItems();
        }

        private void loadItems()
        {
            foreach (int addr in RecordAddresses())
            {
                var r = new TagRecord(M, addr);
                if (!records.ContainsKey(r.Key))
                    records.Add(r.Key, r);
            }
        }

        public class TagRecord
        {
            public readonly string Key;
            public int Hash;
            // more fields can be added (see in visualGGPK)

            public TagRecord(Memory m, int addr)
            {
                Key = m.ReadStringU(m.ReadInt(addr + 0), 255);
                Hash = m.ReadInt(addr + 4);
            }
        }
    }
}