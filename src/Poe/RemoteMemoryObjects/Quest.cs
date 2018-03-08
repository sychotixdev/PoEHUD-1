using PoeHUD.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;
using PoeHUD.Controllers;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class Quest : RemoteMemoryObject
    {
        private string id;
        public string Id => id != null ? id :
            id = M.ReadStringU(M.ReadLong(Address), 255);

        public int Act => M.ReadInt(Address + 0x8);

        private string name;
        public string Name => name != null ? name :
            name = M.ReadStringU(M.ReadLong(Address + 0xc));

        public string Icon => M.ReadStringU(M.ReadLong(Address + 0x18));

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}
