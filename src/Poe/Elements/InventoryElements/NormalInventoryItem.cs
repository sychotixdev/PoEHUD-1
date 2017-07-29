namespace PoeHUD.Poe.Elements
{
    public class NormalInventoryItem : Element
    {
        public virtual int InventPosX => M.ReadInt(Address + 0xB38);
        public virtual int InventPosY => M.ReadInt(Address + 0xB3C);

        public Entity Item
        {
            get
            {
                return ReadObject<Entity>(Address + 0xB30);
            }
        }

        public ToolTipType toolTipType => ToolTipType.InventoryItem;
        public Element ToolTip => ReadObject<Element>(Address + 0xAE0);

    }
}
