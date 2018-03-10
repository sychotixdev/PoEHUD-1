namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class ServerData : RemoteMemoryObject
    {
        public bool IsInGame => M.ReadInt(Address + /*Offsets.InGameOffset*/ 0x4734) == 3;
    }
}