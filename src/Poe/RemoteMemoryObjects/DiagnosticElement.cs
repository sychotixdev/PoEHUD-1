namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class DiagnosticElement : RemoteMemoryObject
    {
        public long DiagnosticArray => M.ReadInt(Address + 0x0);
        public float CurrValue => M.ReadFloat(DiagnosticArray + 0x13C);
        public int X => M.ReadInt(Address + 0x8);
        public int Y => M.ReadInt(Address + 0xC);
        public int Width => M.ReadInt(Address + 0x10);
        public int Height => M.ReadInt(Address + 0x14);
    }
}