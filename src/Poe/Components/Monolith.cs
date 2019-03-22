using System.Runtime.InteropServices;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct MonolithStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
        [FieldOffset(0x70)]
        public byte OpenStage;
    }

    public class Monolith : StructuredRemoteMemoryObject<MonolithStruct>, Component
    {
        public Entity Owner => GetObject<Entity>(Structure.OwnerPtr);

        //EssenceTypes: 0x28-0x20 is a range, then read double pointer struct (each second pointer)
        public int OpenStage => Structure.OpenStage;
        public bool IsOpened => OpenStage == 4;//After killing monsters (or on time) this objects disappear
    }
}
