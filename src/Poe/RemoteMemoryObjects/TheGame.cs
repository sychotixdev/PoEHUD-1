using PoeHUD.Controllers;
using PoeHUD.Framework;
namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class TheGame : RemoteMemoryObject
    {
        public TheGame(Memory m)
        {
            M = m;
            Address = m.ReadLong(Offsets.Base + m.AddressOfProcess, 0x8, 0xf8);//0xC40
            Game = this;
        }
        public IngameState IngameState => GameStateController.IngameState;
        public int AreaChangeCount => M.ReadInt(M.AddressOfProcess + Offsets.AreaChangeCount);
        public bool IsGameLoading => GameStateController.IsLoading;
        public void RefreshTheGameState()
        {
            Address = M.ReadLong(Offsets.Base + M.AddressOfProcess, 0x8, 0xF8);
        }
    }
}