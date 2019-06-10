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
    public class BestiaryGroup : RemoteMemoryObject
    {
        public int Id { get; internal set; }

        private string groupId;
        public string GroupId => groupId != null ? groupId :
            groupId = M.ReadStringU(M.ReadLong(Address));

        public string Description => M.ReadStringU(M.ReadLong(Address + 0x8));
        public string Illustration => M.ReadStringU(M.ReadLong(Address + 0x10));

        private string name;
        public string Name => name != null ? name :
            name = M.ReadStringU(M.ReadLong(Address + 0x18));

        public string SmallIcon => M.ReadStringU(M.ReadLong(Address + 0x20));
        public string ItemIcon => M.ReadStringU(M.ReadLong(Address + 0x28));

        private BestiaryFamily family;
        public BestiaryFamily Family => family != null ? family :
            family = GameController.Instance.Files.BestiaryFamilies.GetByAddress(M.ReadLong(Address + 0x38));

        public override string ToString()
        {
            return Name;
        }
    }
}
