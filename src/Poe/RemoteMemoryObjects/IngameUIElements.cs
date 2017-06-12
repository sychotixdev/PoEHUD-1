using PoeHUD.Poe.Elements;
using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameUIElements : RemoteMemoryObject
    {
        public Element QuestTracker => ReadObjectAt<Element>(0xBB0);
        public Element OpenLeftPanel => ReadObjectAt<Element>(0xBF0);
        public Element OpenRightPanel => ReadObjectAt<Element>(0xBF8);
        public InventoryElement InventoryPanel => ReadObjectAt<InventoryElement>(0xC28);
        public Element TreePanel => ReadObjectAt<Element>(0xC58);
        public Element AtlasPanel => ReadObjectAt<Element>(0xC60);
        public Map Map => ReadObjectAt<Map>(0xCB0);
        public IEnumerable<ItemsOnGroundLabelElement> ItemsOnGroundLabels
        {
            get
            {
                var itemsOnGroundLabelRoot = ReadObjectAt<ItemsOnGroundLabelElement>(0xCB8);
                return itemsOnGroundLabelRoot.Children;
            }
        }
        public Element GemLvlUpPanel => ReadObjectAt<Element>(0xEB8);
        public ItemOnGroundTooltip ItemOnGroundTooltip => ReadObjectAt<ItemOnGroundTooltip>(0xEF0);
    }
}

