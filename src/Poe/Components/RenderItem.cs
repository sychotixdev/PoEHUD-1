using System.Runtime.InteropServices;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct RenderItemStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
        [FieldOffset(0x20)]
        public long ResourcePathPtr;

    }

    public class RenderItem : StructuredRemoteMemoryObject<RenderItemStruct>, Component
    {
        public Entity Owner => ReadObject<Entity>(Structure.OwnerPtr);

        public string ResourcePath => M.ReadStringU(Structure.ResourcePathPtr);
    }
}