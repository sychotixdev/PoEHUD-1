namespace PoeHUD.Poe.Elements
{
    public class Inventory : Element
    {
        public RemoteMemoryObjects.InventoryList AllInventories => GetObjectAt<RemoteMemoryObjects.InventoryList>(0xAB0);
    }
}