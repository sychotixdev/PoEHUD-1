namespace PoeHUD.Poe.Components
{
    public class Targetable : Component
    {
        public bool isTargeted => Address != 0 && M.ReadByte(Address + 0x2A) == 1;
    }
}