using System.Runtime.InteropServices;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct ChestStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
        [FieldOffset(0x20)]
        public long StrongboxDataPtr;
        [FieldOffset(0x58)]
        public byte IsOpened;
        [FieldOffset(0x59)]
        public byte IsLocked;
        [FieldOffset(0x5C)]
        public byte Quality;
        [FieldOffset(0x98)]
        public long IsStrongbox;

    }

    public class Chest : StructuredRemoteMemoryObject<ChestStruct>, Component
    {
        public Entity Owner => GetObject<Entity>(Structure.OwnerPtr);

        public bool IsOpened => Address != 0 && Structure.IsOpened == 1;
        public bool IsLocked => Address != 0 && Structure.IsLocked > 1;
        public bool IsStrongbox => Address != 0 && Structure.IsStrongbox > 0;
        public byte Quality => Structure.Quality;

        [StructLayout(LayoutKind.Explicit)]
        public struct ChestStrongboxStruct
        {
            [FieldOffset(0x20)]
            public byte DestroyingAfterOpen;
            [FieldOffset(0x21)]
            public byte IsLarge;
            [FieldOffset(0x22)]
            public byte Stompable;
            [FieldOffset(0x25)]
            public byte OpenOnDamage;
            [FieldOffset(0x28)]
            public byte OpenWhenDeamonsDie;
        }

        public class ChestStrongbox : StructuredRemoteMemoryObject<ChestStrongboxStruct>
        {

        }

        public ChestStrongbox StrongboxData => GetObject<ChestStrongbox>(Structure.StrongboxDataPtr);
        public bool DestroyingAfterOpen => Address != 0 && StrongboxData.Structure.DestroyingAfterOpen == 1;
        public bool IsLarge => Address != 0 && StrongboxData.Structure.IsLarge == 1;
        public bool Stompable => Address != 0 && StrongboxData.Structure.Stompable == 1;
        public bool OpenOnDamage => Address != 0 && StrongboxData.Structure.OpenOnDamage == 1;
        public bool OpenWhenDeamonsDie => Address != 0 && StrongboxData.Structure.OpenWhenDeamonsDie == 1;
    }
}