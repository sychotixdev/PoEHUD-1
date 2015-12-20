namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class Buff : RemoteMemoryObject
    {
        public string Name => M.ReadStringU(M.ReadInt(Address + 4, 0));
        public int Charges => M.ReadInt(Address + 0x18);
        public int SkillId => M.ReadInt(Address + 0x24);
        public float Timer => M.ReadFloat(Address + 0xC);
    }
}