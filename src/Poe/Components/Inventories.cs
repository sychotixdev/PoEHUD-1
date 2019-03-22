using System.Runtime.InteropServices;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct InventoriesStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
        [FieldOffset(0x40)]
        public long LeftHandPtr;
        [FieldOffset(0x80)]
        public long RightHandPtr;
        [FieldOffset(0xC0)]
        public long ChestPtr;
        [FieldOffset(0x100)]
        public long HelmPtr;
        [FieldOffset(0x140)]
        public long GlovesPtr;
        [FieldOffset(0x180)]
        public long BootsPtr;
        [FieldOffset(0x1C0)]
        public long UnknownPtr;
        [FieldOffset(0x200)]
        public long LeftRingPtr;
        [FieldOffset(0x240)]
        public long RightRingPtr;
        [FieldOffset(0x280)]
        public long BeltPtr;
    }

    public class Inventories : StructuredRemoteMemoryObject<InventoriesStruct>, Component
    {
        public Entity Owner => ReadObject<Entity>(Address + 8);

        public InventoryVisual LeftHand => GetObject<InventoryVisual>(Structure.LeftHandPtr);
        public InventoryVisual RightHand => GetObject<InventoryVisual>(Structure.RightHandPtr);
        public InventoryVisual Chest => GetObject<InventoryVisual>(Structure.ChestPtr);
        public InventoryVisual Helm => GetObject<InventoryVisual>(Structure.HelmPtr);
        public InventoryVisual Gloves => GetObject<InventoryVisual>(Structure.GlovesPtr);
        public InventoryVisual Boots => GetObject<InventoryVisual>(Structure.BootsPtr);
        public InventoryVisual Unknown => GetObject<InventoryVisual>(Structure.UnknownPtr);
        public InventoryVisual LeftRing => GetObject<InventoryVisual>(Structure.LeftRingPtr);
        public InventoryVisual RightRing => GetObject<InventoryVisual>(Structure.RightRingPtr);
        public InventoryVisual Belt => GetObject<InventoryVisual>(Structure.BeltPtr);
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InventoryVisualStruct
    {
        [FieldOffset(0x0)]
        public long NamePtr;
        [FieldOffset(0x8)]
        public long TexturePtr;
        [FieldOffset(0x10)]
        public long ModelPtr;
    }

    public class InventoryVisual : StructuredRemoteMemoryObject<InventoryVisualStruct>
    {
        public string Name => M.ReadStringU(Structure.NamePtr);
        public string Texture => M.ReadStringU(Structure.TexturePtr);
        public string Model => M.ReadStringU(Structure.ModelPtr);
    }
}