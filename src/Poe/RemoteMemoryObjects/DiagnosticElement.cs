namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class DiagnosticElement : RemoteMemoryObject
    {
        public const int LAST_INDEX = 0x13C;
        public int X => M.ReadInt(Address + 0x4);
        public int Y => M.ReadInt(Address + 0x8);
        public int Width => M.ReadInt(Address + 0xC);
        public int Height => M.ReadInt(Address + 0x10);
        public float this[int index] => index >= 0 && index <= LAST_INDEX ? M.ReadFloat(M.ReadInt(Address)) : -1;
    }
}