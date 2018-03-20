using PoeHUD.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;
using PoeHUD.Controllers;
using PoeHUD.Poe.FilesInMemory;
using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.Poe.Components
{
    public class Prophecy : Component
    {
        public ProphecyDat DatProphecy => GameController.Instance.Files.Prophecies.GetByAddress(M.ReadLong(Address + 0x20));
    }
}
