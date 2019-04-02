using System.Runtime.InteropServices;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct StackStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
        [FieldOffset(0x10)]
        public long CurrencyInfoPtr;
        [FieldOffset(0x18)]
        public int Size;

    }

    public class Stack : StructuredRemoteMemoryObject<StackStruct>, Component
    {
        public Entity Owner => GetObject<Entity>(Structure.OwnerPtr);

        public int Size => Address == 0 ? 0 : Structure.Size;//0xC ?
        public CurrencyInfo Info => Address != 0 ? GetObject<CurrencyInfo>(Structure.CurrencyInfoPtr) : null;
    }
}