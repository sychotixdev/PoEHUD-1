using PoeHUD.Hud;

namespace PoeHUD.Poe.Components
{
    public class Charges : Component
    {
        private ChargesRMO ChargesStructure => GetObject<ChargesRMO>(Address);
        public int NumCharges => Address != 0 ? ChargesStructure.NumCharges : 0;

        public int ChargesPerUse => Address != 0 ? ChargesStructure.ChargesInternal.ChargesPerUse : 0;

        public int ChargesMax => Address != 0 ? ChargesStructure.ChargesInternal.ChargesMax : 0;
    }

    public class ChargesRMO : StructuredRemoteMemoryObject<EnumOffsets.Charges>
    {
        public int NumCharges => Structure.numCharges;
        public ChargesInternalRMO ChargesInternal => GetObject<ChargesInternalRMO>((long)Structure.chargesInternal);

    }

    public class ChargesInternalRMO : StructuredRemoteMemoryObject<EnumOffsets.ChargesInternal>
    {
        public int ChargesMax => Structure.chargesMax;
        public int ChargesPerUse => Structure.chargesPerUse;
    }
}
