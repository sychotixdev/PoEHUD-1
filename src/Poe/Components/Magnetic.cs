namespace PoeHUD.Poe.Components
{
    //Azurite shard component
    public class Magnetic : Component
    {
        public int Force => M.ReadInt(Address + 0x30);
    }
}
