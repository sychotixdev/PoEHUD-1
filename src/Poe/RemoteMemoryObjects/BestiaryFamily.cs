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
    public class BestiaryFamily : RemoteMemoryObject
    {
        public int Id { get; internal set; }

        private string familyId;
        public string FamilyId => familyId != null ? familyId :
            familyId = M.ReadStringU(M.ReadLong(Address));

        private string name;
        public string Name => name != null ? name :
            name = M.ReadStringU(M.ReadLong(Address + 0x8));

        public string Icon => M.ReadStringU(M.ReadLong(Address + 0x10));
        public string SmallIcon => M.ReadStringU(M.ReadLong(Address + 0x18));
        public string Illustration => M.ReadStringU(M.ReadLong(Address + 0x20));
        public string PageArt => M.ReadStringU(M.ReadLong(Address + 0x28));
        public string Description => M.ReadStringU(M.ReadLong(Address + 0x30));

        public override string ToString()
        {
            return Name;
        }
    }
}
