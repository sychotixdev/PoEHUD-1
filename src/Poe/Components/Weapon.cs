using System.Runtime.InteropServices;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct WeaponStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
        [FieldOffset(0x28)]
        public byte InternalPtr;

    }

    public class Weapon : StructuredRemoteMemoryObject<WeaponStruct>, Component
    {
        public Entity Owner => GetObject<Entity>(Structure.OwnerPtr);
        public WeaponInternal Internal => GetObject<WeaponInternal>(Structure.InternalPtr);

        [StructLayout(LayoutKind.Explicit)]
        public struct WeaponInternalStruct
        {
            [FieldOffset(0x14)]
            public int DamageMin;
            [FieldOffset(0x18)]
            public int DamageMax;
            [FieldOffset(0x1c)]
            public int AttackTime;
            [FieldOffset(0x20)]
            public int CritChance;
        }

        public class WeaponInternal : StructuredRemoteMemoryObject<WeaponInternalStruct>
        {

        }

        public int DamageMin => Address != 0 ? Internal.Structure.DamageMin : 0;
        public int DamageMax => Address != 0 ? Internal.Structure.DamageMax : 0;
        public int AttackTime => Address != 0 ? Internal.Structure.AttackTime : 1;
        public int CritChance => Address != 0 ? Internal.Structure.CritChance : 0;
    }
}