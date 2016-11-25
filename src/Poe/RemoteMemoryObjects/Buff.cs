namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class Buff : RemoteMemoryObject
    {
        public string Name => M.ReadStringU(M.ReadInt(Address + 8, 0));
        public int Charges => M.ReadInt(Address + 0x28);
        public int SkillId => M.ReadInt(Address + 0x34);
        public float Timer => M.ReadFloat(Address + 0x14);
    }
}