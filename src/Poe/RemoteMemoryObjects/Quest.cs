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
        public int QuestId { get; internal set; }
        public string Id { get; internal set; }
        public int Act => M.ReadInt(Address + 0x8);
        public string Name => M.ReadStringU(M.ReadLong(Address + 0xc));
        public string Icon => M.ReadStringU(M.ReadLong(Address + 0x18));

        public override string ToString()
        {
            return $"QuestId: {QuestId}, Id: {Id}, Name: {Name}";
        }
    }
}
