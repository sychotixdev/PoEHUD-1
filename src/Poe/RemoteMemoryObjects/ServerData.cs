namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class ServerData : RemoteMemoryObject
    {
        public bool IsInGame => M.ReadInt(Address + /*Offsets.InGameOffset*/ 0x39c8) == 3;
        public InventoryList PlayerInventories => GetObject<InventoryList>(Address + 0x2900);
    }
}