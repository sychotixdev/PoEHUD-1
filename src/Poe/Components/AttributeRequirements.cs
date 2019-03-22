using System.Runtime.InteropServices;

namespace PoeHUD.Poe.EntityComponents
{
    [StructLayout(LayoutKind.Explicit)]
    public struct AttributesRequirementsStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
        [FieldOffset(0x10)]
        public long AttributesPtr;
    }

    public class AttributeRequirements : StructuredRemoteMemoryObject<AttributesRequirementsStruct>, Component
    {
        public Entity Owner => GetObject<Entity>(Structure.OwnerPtr);
        public AttributeRequirementsAttributes Attributes => GetObject<AttributeRequirementsAttributes>(Structure.AttributesPtr);

        [StructLayout(LayoutKind.Explicit)]
        public struct AttributeRequirementsAttributesStruct
        {
            [FieldOffset(0x10)]
            public int Strength;
            [FieldOffset(0x14)]
            public int Dexterity;
            [FieldOffset(0x18)]
            public int Intelligence;
        }

        public class AttributeRequirementsAttributes : StructuredRemoteMemoryObject<AttributeRequirementsAttributesStruct>
        {

        }

        public int strength => (Address != 0) ? Attributes.Structure.Strength : 0;
        public int dexterity => (Address != 0) ? Attributes.Structure.Dexterity : 0;
        public int intelligence => (Address != 0) ? Attributes.Structure.Intelligence : 0;
    }
}