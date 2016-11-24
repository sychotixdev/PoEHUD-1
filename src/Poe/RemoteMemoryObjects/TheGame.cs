using PoeHUD.Framework;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class TheGame : RemoteMemoryObject
    {
        public TheGame(Memory m)
        {
            M = m;
            Address = m.ReadLong(Offsets.Base + m.AddressOfProcess);//0xC40
            Game = this;
        }
        public IngameState IngameState => ReadObject<IngameState>(Address + 0xB88);
        public int AreaChangeCount => M.ReadInt(M.AddressOfProcess + Offsets.AreaChangeCount);
    }
}