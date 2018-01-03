using PoeHUD.Poe.Elements;
using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameUIElements : RemoteMemoryObject
    {
        public Element QuestTracker => ReadObjectAt<Element>(0xA18);
        public Element OpenLeftPanel => ReadObjectAt<Element>(0xA40);
        public Element OpenRightPanel => ReadObjectAt<Element>(0xA44);
        public Elements.Inventory InventoryPanel => ReadObjectAt<Elements.Inventory>(0xA5C);
        public Element TreePanel => ReadObjectAt<Element>(0xA74);
        public Element AtlasPanel => ReadObjectAt<Element>(0xA78);
        public Map Map => ReadObjectAt<Map>(0xAA0);
        public IEnumerable<ItemsOnGroundLabelElement> ItemsOnGroundLabels
        {
            get
            {
                var itemsOnGroundLabelRoot = ReadObjectAt<ItemsOnGroundLabelElement>(0xAA4);
                return itemsOnGroundLabelRoot.Children;
            }
        }
        public Element GemLvlUpPanel => ReadObjectAt<Element>(0xBAC);
        public ItemOnGroundTooltip ItemOnGroundTooltip => ReadObjectAt<ItemOnGroundTooltip>(0xBE0);
    }
}
