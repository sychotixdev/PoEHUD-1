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
        public uint Reserved => M.ReadUInt(Address + 0x10);

        public string Value
        {
            get
            {
                //var size = Size;
                //if (size == 0)
                //    return string.Empty;
                if (/*8 <= size ||*/ 8 <= Reserved)//Have no idea how to deal with this
                {
                    var readAddr = M.ReadLong(Address);
                    return M.ReadStringU(readAddr);
                }
                else
                {
                    return M.ReadStringU(Address);
                }
            }
        }
    }
}
