using System.Runtime.InteropServices;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct CurrencyInfoStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
        [FieldOffset(0x28)]
        public int MaxStackSize;

    }

    public class CurrencyInfo : StructuredRemoteMemoryObject<CurrencyInfoStruct>, Component
    {
        public Entity Owner => GetObject<Entity>(Address + 8);

        public int MaxStackSize => Address != 0 ? Structure.MaxStackSize : 0;
    }
}