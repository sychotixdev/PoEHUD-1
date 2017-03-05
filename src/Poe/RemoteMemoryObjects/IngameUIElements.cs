using PoeHUD.Poe.Elements;
using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameUIElements : RemoteMemoryObject
    {
        public Element QuestTracker => ReadObjectAt<Element>(0xB58);
        public Element OpenLeftPanel => ReadObjectAt<Element>(0xBA0);
        public Element OpenRightPanel => ReadObjectAt<Element>(0xBA8);
        public Elements.Inventory InventoryPanel => ReadObjectAt<Elements.Inventory>(0xBD8);
        public Element TreePanel => ReadObjectAt<Element>(0xC08);
        public Element AtlasPanel => ReadObjectAt<Element>(0xC10);
        public Map Map => ReadObjectAt<Map>(0xC40);
        public IEnumerable<ItemsOnGroundLabelElement> ItemsOnGroundLabels
        {
            get
            {
                var itemsOnGroundLabelRoot = ReadObjectAt<ItemsOnGroundLabelElement>(0xC48);
                return itemsOnGroundLabelRoot.Children;
            }
        }
        public Element GemLvlUpPanel => ReadObjectAt<Element>(0xDF0);
        public ItemOnGroundTooltip ItemOnGroundTooltip => ReadObjectAt<ItemOnGroundTooltip>(0xE10);
    }
}

