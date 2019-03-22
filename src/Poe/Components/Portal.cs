using PoeHUD.Poe.RemoteMemoryObjects;
using PoeHUD.Controllers;
using System.Runtime.InteropServices;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct PortalStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
        [FieldOffset(0x28)]
        public byte AreaPtr;
    }

    public class Portal : StructuredRemoteMemoryObject<PortalStruct>, Component
    {
        public Entity Owner => GetObject<Entity>(Structure.OwnerPtr);

        public WorldArea Area => GameController.Instance.Files.WorldAreas.GetByAddress(Structure.AreaPtr);
    }
}
