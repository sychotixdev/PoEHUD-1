using PoeHUD.Poe.Elements;
using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameUIElements : RemoteMemoryObject
    {
        public Element QuestTracker => ReadObjectAt<Element>(0xA40);
        public Element OpenLeftPanel => ReadObjectAt<Element>(0xA68);
        public Element OpenRightPanel => ReadObjectAt<Element>(0xA6C);
        public Elements.Inventory InventoryPanel => ReadObjectAt<Elements.Inventory>(0xA84);
        public Element TreePanel => ReadObjectAt<Element>(0xA9C);
        public Element AtlasPanel => ReadObjectAt<Element>(0xAA0);
        public Map Map => ReadObjectAt<Map>(0xAC8);
        public IEnumerable<ItemsOnGroundLabelElement> ItemsOnGroundLabels
        {
            get
            {
                var itemsOnGroundLabelRoot = ReadObjectAt<ItemsOnGroundLabelElement>(0xACC);
                return itemsOnGroundLabelRoot.Children;
            }
        }
        public Element GemLvlUpPanel => ReadObjectAt<Element>(0xBD8);
        public ItemOnGroundTooltip ItemOnGroundTooltip => ReadObjectAt<ItemOnGroundTooltip>(0xC10);
    }
}
