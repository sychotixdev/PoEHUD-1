using System.Runtime.InteropServices;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct NPCStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
        [FieldOffset(0x20)]
        public byte IsIgnoreHiddenPtr;
        [FieldOffset(0x21)]
        public byte IsMinimapLabelVisible;
        [FieldOffset(0x48)]
        public long OverheadIconPtr;
    }

    public class NPC : StructuredRemoteMemoryObject<NPCStruct>, Component
    {
        public Entity Owner => GetObject<Entity>(Structure.OwnerPtr);

        public bool HasIconOverhead => Structure.OverheadIconPtr != 0;
        public bool IsIgnoreHidden => Structure.IsIgnoreHiddenPtr == 1;
        public bool IsMinimapLabelVisible => Structure.IsMinimapLabelVisible == 1;
    }
}