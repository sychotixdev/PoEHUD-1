using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct ShrineStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
        [FieldOffset(0x1c)]
        public byte IsAvailable;

    }

    public class Shrine : StructuredRemoteMemoryObject<ShrineStruct>, Component
    {
        public Entity Owner => GetObject<Entity>(Structure.OwnerPtr);

        public bool IsAvailable => Address != 0 && Structure.IsAvailable == 0;
    }
}
