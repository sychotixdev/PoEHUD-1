using PoeHUD.Poe.RemoteMemoryObjects;
using PoeHUD.Controllers;

namespace PoeHUD.Poe.Components
{
    public class Portal : Component
    {
        public WorldArea Area => GameController.Instance.Files.WorldAreas.GetByAddress(M.ReadLong(Address + 0x28));
    }
}
