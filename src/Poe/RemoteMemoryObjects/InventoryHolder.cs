namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class InventoryHolder : RemoteMemoryObject
    {
        internal const int StructSize = 0x20;
        public int Id => M.ReadInt(Address);
        public ServerInventory Inventory => ReadObject<ServerInventory>(Address + 0x8);

        public override string ToString()
        {
            return $"InventoryType: {Inventory.InventType}, InventorySlot: {Inventory.InventSlot}, Columns: {Inventory.Columns}, Rows: {Inventory.Rows}," +
                $"ItemsCount: {Inventory.TotalItemsCounts}, ServerRequestsCounter: {Inventory.ServerRequestCounter}";
        }
    }
}
