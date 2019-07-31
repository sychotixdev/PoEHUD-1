using PoeHUD.Hud;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class InventoryHolder : StructuredRemoteMemoryObject<EnumOffsets.InventoryHolder>
    {
        internal const int StructSize = 0x20;
        public int Id => Structure.id;
        public ServerInventory Inventory => GetObject<ServerInventory>((long)Structure.inventory);

        public override string ToString()
        {
            return $"InventoryType: {Inventory.InventType}, InventorySlot: {Inventory.InventSlot}, Columns: {Inventory.Columns}, Rows: {Inventory.Rows}," +
                   $"ItemsCount: {Inventory.TotalItemsCounts}";
        }
    }
}