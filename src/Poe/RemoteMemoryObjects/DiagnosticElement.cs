namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class DiagnosticElement : RemoteMemoryObject
    {
        public const int LAST_INDEX = 0x13C;
        public int DiagnosticArray => M.ReadInt(Address);
        public float CurrValue => M.ReadFloat(DiagnosticArray + LAST_INDEX);
        public int X => M.ReadInt(Address + 0x4);
        public int Y => M.ReadInt(Address + 0x8);
        public int Width => M.ReadInt(Address + 0xC);
        public int Height => M.ReadInt(Address + 0x10);
    }
}