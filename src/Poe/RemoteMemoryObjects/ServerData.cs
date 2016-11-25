namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class ServerData : RemoteMemoryObject
    {
        public bool IsInGame => InGameType == 3;
        public int InGameType => M.ReadInt(Address + /*Offsets.InGameOffset*/ 0x39C8);//0 - not in game (login screen), 1 - loading location, 3 - on location
        public InventoryList PlayerInventories => GetObject<InventoryList>(Address + 0x2900);
    }
}