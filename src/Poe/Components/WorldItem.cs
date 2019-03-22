using System.Runtime.InteropServices;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct WorldItemStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
        [FieldOffset(0x28)]
        public byte ItemEntity;

    }

    public class WorldItem : StructuredRemoteMemoryObject<WorldItemStruct>, Component
    {
        public Entity Owner => GetObject<Entity>(Structure.OwnerPtr);

        public Entity ItemEntity => Address != 0 ? GetObject<Entity>(Structure.ItemEntity) : GetObject<Entity>(0);
    }
}