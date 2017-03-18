using PoeHUD.Poe.Elements;
using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameUIElements : RemoteMemoryObject
    {
        public Element QuestTracker => ReadObjectAt<Element>(0x9C0);
        public Element OpenLeftPanel => ReadObjectAt<Element>(0x9F0);
        public Element OpenRightPanel => ReadObjectAt<Element>(0x9F4);
        public Elements.Inventory InventoryPanel => ReadObjectAt<Elements.Inventory>(0xA04);
        public Element TreePanel => ReadObjectAt<Element>(0xA1C);
        public Element AtlasPanel => ReadObjectAt<Element>(0xA20);
        public Map Map => ReadObjectAt<Map>(0xA38);
        public IEnumerable<ItemsOnGroundLabelElement> ItemsOnGroundLabels
        {
            get
            {
                var itemsOnGroundLabelRoot = ReadObjectAt<ItemsOnGroundLabelElement>(0xA3C);
                return itemsOnGroundLabelRoot.Children;
            }
        }
        public Element GemLvlUpPanel => ReadObjectAt<Element>(0xB10);
        public ItemOnGroundTooltip ItemOnGroundTooltip => ReadObjectAt<ItemOnGroundTooltip>(0xB20);
    }
}
