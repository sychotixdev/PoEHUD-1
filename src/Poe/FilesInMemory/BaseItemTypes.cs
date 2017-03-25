using PoeHUD.Framework;
using PoeHUD.Models;
using System;
using System.Collections.Generic;

namespace PoeHUD.Poe.FilesInMemory
{
    public class BaseItemTypes : FileInMemory
    {
        private readonly Dictionary<string, BaseItemType> contents = new Dictionary<string, BaseItemType>();

        public BaseItemTypes(Memory m, long address) : base(m, address)
        {
            LoadItemTypes();
        }

        public BaseItemType Translate(string metadata)
        {
            if (!contents.ContainsKey(metadata))
            {
                LoadItemTypes();
            }
            if (!contents.ContainsKey(metadata))
            {
                Console.WriteLine("Key not found in BaseItemTypes: " + metadata);
                return null;
            }
            return contents[metadata];
        }

        private void LoadItemTypes()
        {
            foreach (long i in RecordAddresses())
            {
                string key = M.ReadStringU(M.ReadLong(i));
                var baseItemType = new BaseItemType
                {
                    ClassName = M.ReadStringU(M.ReadLong(i + 0x10, 0)),

                    Width = M.ReadInt(i + 0x18),
                    Height = M.ReadInt(i + 0x1C),
                    BaseName = M.ReadStringU(M.ReadLong(i + 0x20)),
                    DropLevel = M.ReadInt(i + 0x30),
                    Tags = new string[M.ReadLong(i + 0xA8)]
                };
                long ta = M.ReadLong(i + 0xB0);
                for (int k = 0; k < baseItemType.Tags.Length; k++)
                {
                    long ii = ta + 0x8 + 0x10 * k;
                    baseItemType.Tags[k] = M.ReadStringU(M.ReadLong(ii, 0), 255);
                }

                if (!contents.ContainsKey(key))
                {
                    contents.Add(key, baseItemType);
                }
            }
        }
    }
}