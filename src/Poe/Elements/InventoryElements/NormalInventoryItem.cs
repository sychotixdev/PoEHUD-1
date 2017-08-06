namespace PoeHUD.Poe.Elements
{
    public class NormalInventoryItem : Element
    {
        public virtual int InventPosX => M.ReadInt(Address + 0xb60);
        public virtual int InventPosY => M.ReadInt(Address + 0xb64);

        public Entity Item
        {
            get
            {
                return ReadObject<Entity>(Address + 0xB58);
            }
        }

        public ToolTipType toolTipType => ToolTipType.InventoryItem;
        public Element ToolTip => ReadObject<Element>(Address + 0xB10);

    }
}
