namespace PoeHUD.Poe.Components.AnimatedComponents
{
    public class ClientAnimationController : Component
    {
        public int AnimKey => M.ReadInt(Address + 0x9c);
    }
}
