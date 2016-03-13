using PoeHUD.Framework;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class TheGame : RemoteMemoryObject
    {
        public TheGame(Memory m)
        {
            M = m;
            Address = m.ReadInt(m.AddressOfProcess + Offsets.Base, 4, 0x7C);
            Game = this;
        }
        public IngameState IngameState => ReadObject<IngameState>(Address + 0x11C);
        public int AreaChangeCount => M.ReadInt(M.AddressOfProcess + Offsets.AreaChangeCount);
    }
}