using System.Runtime.InteropServices;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct ChargesStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
        [FieldOffset(0x10)]
        public long InternalPtr;
        [FieldOffset(0x18)]
        public int NumCharges;
    }

    public class Charges : StructuredRemoteMemoryObject<ChargesStruct>, Component
    {
        public Entity Owner => GetObject<Entity>(Structure.OwnerPtr);
        public ChargesInternal Internal => GetObject<ChargesInternal>(Structure.InternalPtr);

        [StructLayout(LayoutKind.Explicit)]
        public struct ChargesInternalStruct
        {
            [FieldOffset(0x10)]
            public int ChargesMax;
            [FieldOffset(0x14)]
            public int ChargesPerUse;
        }

        public class ChargesInternal : StructuredRemoteMemoryObject<ChargesInternalStruct>
        {

        }

        public int NumCharges => Address != 0 ? Structure.NumCharges : 0;

        public int ChargesPerUse => Address != 0 ? Internal.Structure.ChargesPerUse : 0;

        public int ChargesMax => Address != 0 ? Internal.Structure.ChargesMax : 0;
    }
}
