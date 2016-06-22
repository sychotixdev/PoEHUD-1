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

        public BaseItemTypes(Memory m, int address, ItemClassesDisplay itemClassesDisplay) : base(m, address)
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
            foreach (int i in RecordAddresses())
            {
                string key = M.ReadStringU(M.ReadInt(i));
                var baseItemType = new BaseItemType
                {
                    BaseName = M.ReadStringU(M.ReadInt(i + 0x14)),
                    ClassName = M.ReadStringU(M.ReadInt(i + 0x8, 0)),
                    Width = M.ReadInt(i + 0xC),
                    Height = M.ReadInt(i + 0x10),
                    DropLevel = M.ReadInt(i + 0x1C)
                };
                if (!contents.ContainsKey(key))
                {
                    contents.Add(key, baseItemType);
                }
            }
        }
    }
}