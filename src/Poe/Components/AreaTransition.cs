using PoeHUD.Controllers;
using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.Poe.Components
{
    public class AreaTransition : Component
    {
        public int WorldAreaId => M.ReadInt(Address + 0x22);
        public WorldArea WorldArea => GameController.Instance.Files.WorldAreas.GetAreaByAreaId(WorldAreaId);
        public AreaTransitionType TransitionType => (AreaTransitionType)M.ReadByte(Address + 0x28);

        public enum AreaTransitionType
        {
            Normal = 0,
            Local = 1,
            NormalToCorrupted = 2,
            CorruptedToNormal = 3,
            Labyrinth = 5
        }
    }
}