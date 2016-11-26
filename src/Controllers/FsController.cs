using PoeHUD.Framework;
using PoeHUD.Poe.FilesInMemory;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PoeHUD.Controllers
{
    public class FsController
    {
        public readonly BaseItemTypes BaseItemTypes;
        public readonly ItemClassesDisplay ItemClassesDisplay;
        public readonly ModsDat Mods;
        public readonly StatsDat Stats;
        public readonly TagsDat Tags;
        private readonly Dictionary<string, long> files;
        private readonly Memory mem;
        private bool isLoaded;

        public FsController(Memory mem)
        {
            this.mem = mem;
            files = GetAllFiles();
            ItemClassesDisplay = new ItemClassesDisplay();

            BaseItemTypes = new BaseItemTypes(mem, FindFile("Data/BaseItemTypes.dat"), ItemClassesDisplay);
            Tags = new TagsDat(mem, FindFile("Data/Tags.dat"));
            Stats = new StatsDat(mem, FindFile("Data/Stats.dat"));
            Mods = new ModsDat(mem, FindFile("Data/Mods.dat"), Stats, Tags);
        }
            
        public Dictionary<string, long> GetAllFiles()
        {
            var fileList = new Dictionary<string, long>();
            long fileRoot = mem.AddressOfProcess + mem.offsets.FileRoot;
            long start = mem.ReadLong(fileRoot + 0x8);

            for (long CurrFile = mem.ReadLong(start); CurrFile != start && CurrFile != 0; CurrFile = mem.ReadLong(CurrFile))
            {
                 var str = mem.ReadStringU(mem.ReadLong(CurrFile + 0x10), 512);

                if (!fileList.ContainsKey(str))
                {
                    fileList.Add(str, mem.ReadLong(CurrFile + 0x18));
                }
            }
            return fileList;
        }

        public long FindFile(string name)
        {
            try
            {
                return files[name];
            }
            catch (KeyNotFoundException)
            {
                const string MESSAGE_FORMAT = "Couldn't find the file in memory: {0}\nTry to restart the game.";
                MessageBox.Show(string.Format(MESSAGE_FORMAT, name), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }

            return 0;
        }
    }
}