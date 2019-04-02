using System.Runtime.InteropServices;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct SkillGemStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
        [FieldOffset(0x34)]
        public byte GemLevel;

    }

    public class SkillGem : StructuredRemoteMemoryObject<SkillGemStruct>, Component
    {
        public Entity Owner => GetObject<Entity>(Structure.OwnerPtr);

        public int GemLevel => Structure.GemLevel;
    }
}