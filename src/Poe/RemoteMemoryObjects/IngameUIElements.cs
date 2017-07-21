using PoeHUD.Poe.Elements;
using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameUIElements : RemoteMemoryObject
    {
        public Element QuestTracker => ReadObjectAt<Element>(0xB58);
        public Element OpenLeftPanel => ReadObjectAt<Element>(0xB98);
        public Element OpenRightPanel => ReadObjectAt<Element>(0xBA0);
        public InventoryElement InventoryPanel => ReadObjectAt<InventoryElement>(0xBD0);
        public Element TreePanel => ReadObjectAt<Element>(0xC00);
        public Element AtlasPanel => ReadObjectAt<Element>(0xC08);
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

