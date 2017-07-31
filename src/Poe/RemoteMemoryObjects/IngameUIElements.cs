using PoeHUD.Poe.Elements;
using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameUIElements : RemoteMemoryObject
    {
        public Element QuestTracker => ReadObjectAt<Element>(0x9CC);
        public Element OpenLeftPanel => ReadObjectAt<Element>(0x9F4);
        public Element OpenRightPanel => ReadObjectAt<Element>(0x9F8);
        public Elements.Inventory InventoryPanel => ReadObjectAt<Elements.Inventory>(0xA10);
        public Element TreePanel => ReadObjectAt<Element>(0xA28);
        public Element AtlasPanel => ReadObjectAt<Element>(0xA2C);
        public Map Map => ReadObjectAt<Map>(0xA4C);
        public IEnumerable<ItemsOnGroundLabelElement> ItemsOnGroundLabels
        {
            get
            {
                var itemsOnGroundLabelRoot = ReadObjectAt<ItemsOnGroundLabelElement>(0xA50);
                return itemsOnGroundLabelRoot.Children;
            }
        }
        public Element GemLvlUpPanel => ReadObjectAt<Element>(0xB4C);
        public ItemOnGroundTooltip ItemOnGroundTooltip => ReadObjectAt<ItemOnGroundTooltip>(0xB5C);
    }
}
