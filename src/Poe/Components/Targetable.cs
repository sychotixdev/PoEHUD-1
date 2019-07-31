namespace PoeHUD.Poe.Components
{
    public class Targetable : Component
    {
        public bool isTargetable => Address != 0 && M.ReadByte(Address + 0x30) == 1;
    }
}
