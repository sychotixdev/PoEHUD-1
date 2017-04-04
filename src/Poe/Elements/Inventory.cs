namespace PoeHUD.Poe.Elements
{
    public class Inventory : Element
    {
        public RemoteMemoryObjects.InventoryList AllInventories => GetObjectAt<RemoteMemoryObjects.InventoryList>(OffsetBuffers + 0x3C4);
    }
}