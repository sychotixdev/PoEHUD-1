using System.Runtime.InteropServices;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct MonsterStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
    }

    public class Monster : StructuredRemoteMemoryObject<MonsterStruct>, Component
    {
        public Entity Owner => GetObject<Entity>(Structure.OwnerPtr);

    }
}