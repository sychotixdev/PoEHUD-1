using PoeHUD.Framework;
using PoeHUD.Models;
using System;
using System.Collections.Generic;

namespace PoeHUD.Poe.FilesInMemory
{
    public class BaseItemTypes : FileInMemory
    {
        private readonly Dictionary<string, BaseItemType> contents = new Dictionary<string, BaseItemType>();
        private readonly ItemClassesDisplay itemClassesDisplay;

        public BaseItemTypes(Memory m, long address, ItemClassesDisplay itemClassesDisplay) : base(m, address)
        {
            this.itemClassesDisplay = itemClassesDisplay;
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
                    DropLevel = M.ReadInt(i + 0x30)
                };

                if (!contents.ContainsKey(key))
                {
                    contents.Add(key, baseItemType);
                }
            }
        }
    }
}