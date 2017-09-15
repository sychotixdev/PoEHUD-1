namespace PoeHUD.Poe.Components
{
    public class Map : Component
    {
        public int Tier => Address != 0 ? M.ReadInt(Address + 0x10, 0x90) : 0;
    }
}