using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class NativeStringReader : RemoteMemoryObject
    {
        public uint Size => M.ReadUInt(Address + 0x8);
        //public uint Reserved => M.ReadUInt(Address + 0x14);
        public string Value
        {
            get
            {
                var size = Size;
                if (size == 0)
                    return string.Empty;
                else if (8 <= size)
                {
                    var readAddr = M.ReadLong(Address);
                    return M.ReadStringU(readAddr, (int)size * 2);
                }
                else
                    return M.ReadStringU(Address, (int)size * 2);
            }
        }
    }
}
