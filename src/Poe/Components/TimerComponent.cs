using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct TimerComponentStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
        [FieldOffset(0x18)]
        public float TimeLeft;

    }

    public class TimerComponent : StructuredRemoteMemoryObject<TimerComponentStruct>, Component
    {
        public Entity Owner => GetObject<Entity>(Structure.OwnerPtr);

        public float TimeLeft => Structure.TimeLeft;
    }
}
