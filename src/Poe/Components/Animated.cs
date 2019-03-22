using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct AnimatedStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
        [FieldOffset(0x88)]
        public long BaseAnimatedObjectEntityPtr;
    }

    public class Animated : StructuredRemoteMemoryObject<AnimatedStruct>, Component
    {
        public Entity Owner => GetObject<Entity>(Structure.OwnerPtr);

        public Entity BaseAnimatedObjectEntity => GetObject<Entity>(Structure.BaseAnimatedObjectEntityPtr);
    }
}
