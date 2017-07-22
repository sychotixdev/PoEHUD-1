using PoeHUD.Poe.Elements;
using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameUIElements : RemoteMemoryObject
    {
        public Element QuestTracker => ReadObjectAt<Element>(0xB78);
        public Element OpenLeftPanel => ReadObjectAt<Element>(0xBB8);
        public Element OpenRightPanel => ReadObjectAt<Element>(0xBC0);
        public InventoryElement InventoryPanel => ReadObjectAt<InventoryElement>(0xBF0);
        public Element TreePanel => ReadObjectAt<Element>(0xC20);
        public Element AtlasPanel => ReadObjectAt<Element>(0xC28);
        public Map Map => ReadObjectAt<Map>(0xC68);
        public IEnumerable<ItemsOnGroundLabelElement> ItemsOnGroundLabels
        {
            get
            {
                var itemsOnGroundLabelRoot = ReadObjectAt<ItemsOnGroundLabelElement>(0xC70);
                return itemsOnGroundLabelRoot.Children;
            }
        }
        public Element GemLvlUpPanel => ReadObjectAt<Element>(0xE68);
        public ItemOnGroundTooltip ItemOnGroundTooltip => ReadObjectAt<ItemOnGroundTooltip>(0xE88);
    }
}

