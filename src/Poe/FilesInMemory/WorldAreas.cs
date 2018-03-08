using PoeHUD.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;
using PoeHUD.Controllers;
using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.Poe.FilesInMemory
{
    public partial class WorldAreas : UniversalFileWrapper<WorldArea>
    {
        public WorldAreas(Memory m, long address)
            : base(m, address)
        {
        }

        public WorldArea GetAreaByAreaId(int index)
        {
            return EntriesList.Find(x => x.Index == index);
        }
    }
}