using System.Runtime.InteropServices;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct ArmourStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
        [FieldOffset(0x10)]
        public long DefensePtr;
    }

    public class Armour : StructuredRemoteMemoryObject<ArmourStruct>, Component
    {
        public Entity Owner => GetObject<Entity>(Structure.OwnerPtr);
        public ArmourDefense Defense => GetObject<ArmourDefense>(Structure.DefensePtr);

        [StructLayout(LayoutKind.Explicit)]
        public struct ArmourDefenseStruct
        {
            [FieldOffset(0x10)]
            public int EvasionScore;
            [FieldOffset(0x14)]
            public int ArmourScore;
            [FieldOffset(0x18)]
            public int EnergyShieldScore;
        }

        public class ArmourDefense : StructuredRemoteMemoryObject<ArmourDefenseStruct>
        {

        }
        

        public int EvasionScore
        {
            get
            {
                return this.Address != 0 ? Defense.Structure.EvasionScore : 0;
            }
        }
        public int ArmourScore
        {
            get
            {
                return this.Address != 0 ? Defense.Structure.ArmourScore : 0;
            }
        }
        public int EnergyShieldScore
        {
            get
            {
                return this.Address != 0 ? Defense.Structure.EnergyShieldScore : 0;
            }
        }
    }
}