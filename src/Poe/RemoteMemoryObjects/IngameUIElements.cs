using PoeHUD.Poe.Elements;
using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameUIElements : RemoteMemoryObject
    {
        public Element QuestTracker => ReadObjectAt<Element>(0xA14);
        public Element OpenLeftPanel => ReadObjectAt<Element>(0xA3C);
        public Element OpenRightPanel => ReadObjectAt<Element>(0xA40);
        public Elements.Inventory InventoryPanel => ReadObjectAt<Elements.Inventory>(0xA58);
        public Element TreePanel => ReadObjectAt<Element>(0xA70);
        public Element AtlasPanel => ReadObjectAt<Element>(0xA74);
        public Map Map => ReadObjectAt<Map>(0xA9C);
        public IEnumerable<ItemsOnGroundLabelElement> ItemsOnGroundLabels
        {
            get
            {
                var itemsOnGroundLabelRoot = ReadObjectAt<ItemsOnGroundLabelElement>(0xAA0);
                return itemsOnGroundLabelRoot.Children;
            }
        }
        public Element GemLvlUpPanel => ReadObjectAt<Element>(0xBA0);
        public ItemOnGroundTooltip ItemOnGroundTooltip => ReadObjectAt<ItemOnGroundTooltip>(0xBD4);
    }
}
