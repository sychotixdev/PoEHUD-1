using PoeHUD.Poe.RemoteMemoryObjects;
using PoeHUD.Controllers;

namespace PoeHUD.Poe.Components
{
    public class Map : Component
    {
        public WorldArea Area => GameController.Instance.Files.WorldAreas.GetAreaByAddress(M.ReadLong(Address + 0x10, 0x18));
        public int Tier => M.ReadInt(Address + 0x10, 0x90);
        public InventoryTabMapSeries MapSeries => (InventoryTabMapSeries)M.ReadByte(Address + 0x10, 0x9c);

    }

    public enum InventoryTabMapSeries : byte
    {
        Atlas_of_Worlds = 3,
        None = 0,
        Original = 1,
        The_Awakening = 2,
        War_for_the_Atlas = 4,
        Bestiary = 5,
    }
}