using PoeHUD.Framework;
using System;
using System.Collections.Generic;

namespace PoeHUD.Poe.FilesInMemory
{
    public class TagsDat : FileInMemory
    {
        public Dictionary<string, TagRecord> records =
            new Dictionary<string, TagRecord>(StringComparer.OrdinalIgnoreCase);

        public TagsDat(Memory m, long address)
            : base(m, address)
        {
            loadItems();
        }

        private void loadItems()
        {
            foreach (long addr in RecordAddresses())
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

            public TagRecord(Memory m, long addr)
            {
                Key = m.ReadStringU(m.ReadLong(addr + 0), 255);
                Hash = m.ReadInt(addr + 0x8);
            }
        }
    }
}