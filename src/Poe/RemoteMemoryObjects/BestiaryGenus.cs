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
    public class BestiaryGenus : RemoteMemoryObject
    {
        public int Id { get; internal set; }

        private string genusId;
        public string GenusId => genusId != null ? genusId :
            genusId = M.ReadStringU(M.ReadLong(Address));

        private string name;
        public string Name => name != null ? name :
            name = M.ReadStringU(M.ReadLong(Address + 0x8));

        private BestiaryGroup bestiaryGroup;
        public BestiaryGroup BestiaryGroup => bestiaryGroup != null ? bestiaryGroup :
            bestiaryGroup = GameController.Instance.Files.BestiaryGroups.GetByAddress(M.ReadLong(Address + 0x18));

        private string name2;
        public string Name2 => name2 != null ? name2 :
            name2 = M.ReadStringU(M.ReadLong(Address + 0x20));

        private string icon;
        public string Icon => icon != null ? icon :
            icon = M.ReadStringU(M.ReadLong(Address + 0x28));

        public int Unknown6 => M.ReadInt(Address + 0x30);

        public override string ToString()
        {
            return Name;
        }
    }
}