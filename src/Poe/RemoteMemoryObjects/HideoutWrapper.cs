using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoeHUD.Controllers;
using PoeHUD.Poe.FilesInMemory;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class HideoutWrapper : RemoteMemoryObject
    {
        public string Name => M.ReadStringU(M.ReadLong(Address));
        public WorldArea WorldArea1 => GameController.Instance.Files.WorldAreas.GetByAddress(M.ReadLong(Address + 0x10));
        public WorldArea WorldArea2 => GameController.Instance.Files.WorldAreas.GetByAddress(M.ReadLong(Address + 0x30));
        public WorldArea WorldArea3 => GameController.Instance.Files.WorldAreas.GetByAddress(M.ReadLong(Address + 0x40));
    }
}
