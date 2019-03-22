using System.Runtime.InteropServices;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct QualityStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
        [FieldOffset(0x18)]
        public int ItemQuality;
    }

    public class Quality : StructuredRemoteMemoryObject<QualityStruct>, Component
    {
        public Entity Owner => GetObject<Entity>(Structure.OwnerPtr);

        public int ItemQuality => Address != 0 ? Structure.ItemQuality : 0;
    }
}