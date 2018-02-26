using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class NativeStringReader : RemoteMemoryObject
    {
        public uint Size => M.ReadUInt(Address + 0x10);
        public uint Reserved => M.ReadUInt(Address + 0x14);
        public string Value
        {
            get
            {
                if (Size == 0)
                    return string.Empty;
                else if(8 <= Size)
                    return M.ReadStringU(M.ReadLong(Address), (int)Size * 2);
                else
                    return M.ReadStringU(Address, (int)Size * 2);
            }
        }
    }
}
