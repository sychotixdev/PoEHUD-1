using System.Runtime.InteropServices;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct DiesAfterTimeStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
    }

    public class DiesAfterTime : StructuredRemoteMemoryObject<CurrencyInfoStruct>, Component
    {
        public Entity Owner => GetObject<Entity>(Structure.OwnerPtr);
    }
}
