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
        public readonly ItemClasses itemClasses;
        public readonly ModsDat Mods;
        public readonly StatsDat Stats;
        public readonly TagsDat Tags;
        public readonly WorldAreas WorldAreas;
        public readonly PassiveSkills PassiveSkills;
        public readonly LabyrinthTrials LabyrinthTrials;
        private readonly Dictionary<string, long> files;
        private readonly Memory mem;
        //private bool isLoaded;

        public FsController(Memory mem)
        {
            this.mem = mem;
            files = GetAllFiles();
            itemClasses = new ItemClasses();
            BaseItemTypes = new BaseItemTypes(mem, FindFile("Data/BaseItemTypes.dat"));
            Tags = new TagsDat(mem, FindFile("Data/Tags.dat"));
            Stats = new StatsDat(mem, FindFile("Data/Stats.dat"));
            Mods = new ModsDat(mem, FindFile("Data/Mods.dat"), Stats, Tags);
            WorldAreas = new WorldAreas(mem, FindFile("Data/WorldAreas.dat"));
            PassiveSkills = new PassiveSkills(mem, FindFile("Data/PassiveSkills.dat"));
            LabyrinthTrials = new LabyrinthTrials(mem, FindFile("Data/LabyrinthTrials.dat"));
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