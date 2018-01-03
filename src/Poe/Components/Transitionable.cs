namespace PoeHUD.Poe.Components
{
    public class Transitionable : Component
    {
        public byte switchState => M.ReadByte(Address + 0x120);
    }
}