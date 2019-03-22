using System.Runtime.InteropServices;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct TargetableStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
        [FieldOffset(0x30)]
        public byte IsTargetable;
        [FieldOffset(0x32)]
        public byte IsTargeted;

    }

    public class Targetable : StructuredRemoteMemoryObject<TargetableStruct>, Component
    {
        public Entity Owner => GetObject<Entity>(Structure.OwnerPtr);

        public bool isTargetable => Address != 0 && Structure.IsTargetable == 1;
        public bool isTargeted => Address != 0 && Structure.IsTargeted == 1;
    }
}
