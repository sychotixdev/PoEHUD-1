namespace PoeHUD.Poe.Components
{
    public class RenderItem : Component
    {
        public string ResourcePath => M.ReadStringU(M.ReadLong(Address + 0x20));
    }
}