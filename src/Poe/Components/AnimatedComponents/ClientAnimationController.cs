using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct ClientAnimationMemoryStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
        [FieldOffset(0x9c)]
        public Int32 AnimKey;
    }

    public class ClientAnimationController : StructuredRemoteMemoryObject<ClientAnimationMemoryStruct>, Component
    {
        public Entity Owner => GetObject<Entity>(Structure.OwnerPtr);
        public int AnimKey => Structure.AnimKey;
    }
}
