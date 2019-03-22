using PoeHUD.Poe.RemoteMemoryObjects;
using System.Runtime.InteropServices;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct BaseStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
        [FieldOffset(0x10)]
        public long InternalPtr;
        [FieldOffset(0xD8)]
        public byte IsCorrupted;
        [FieldOffset(0xD9)]
        public byte IsShaper;
        [FieldOffset(0xDA)]
        public byte IsElder;
    }

    public class Base : StructuredRemoteMemoryObject<BaseStruct>, Component
    {
        public Entity Owner => GetObject<Entity>(Structure.OwnerPtr);
        public BaseInternal Internal => GetObject<BaseInternal>(Structure.InternalPtr);

        [StructLayout(LayoutKind.Explicit)]
        public struct BaseInternalStruct
        {
            [FieldOffset(0x10)]
            public int ItemCellsSizeX;
            [FieldOffset(0x14)]
            public int ItemCellsSizeY;
            [FieldOffset(0x18)]
            public long NamePtr;
        }

        public class BaseInternal : StructuredRemoteMemoryObject<BaseInternalStruct>
        {

        }


        public string Name => NativeStringReader.ReadString(Internal.Structure.NamePtr);
        public int ItemCellsSizeX => Internal.Structure.ItemCellsSizeX;
        public int ItemCellsSizeY => Internal.Structure.ItemCellsSizeY;
        public bool isCorrupted => Structure.IsCorrupted == 1;
        public bool isShaper => Structure.IsShaper == 1;
        public bool isElder => Structure.IsElder == 1;

        // 0x8 - link to base item
        // +0x10 - Name
        // +0x30 - Use hint
        // +0x50 - Link to Data/BaseItemTypes.dat

        // 0xC (+4) fileref to visual identity
    }
}
