namespace PoeHUD.Poe.Elements
{
    public class NormalInventoryItem : Element
    {
        public virtual int InventPosX => M.ReadInt(Address + 0xb20);
        public virtual int InventPosY => M.ReadInt(Address + 0xb24);

        public Entity Item
        {
            get
            {
                return ReadObject<Entity>(Address + 0xB18);
            }
        }

        public ToolTipType toolTipType => ToolTipType.InventoryItem;
        public Element ToolTip => ReadObject<Element>(Address + 0xAD0);

    }
}
