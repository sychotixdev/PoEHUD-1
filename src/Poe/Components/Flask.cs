using System.Runtime.InteropServices;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct FlaskStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
    }

    public class Flask : StructuredRemoteMemoryObject<FlaskStruct>, Component {
        public Entity Owner => ReadObject<Entity>(Structure.OwnerPtr);
    }
}