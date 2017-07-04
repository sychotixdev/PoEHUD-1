using PoeHUD.Poe.Elements;
using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameUIElements : RemoteMemoryObject
    {
        public Element QuestTracker => ReadObjectAt<Element>(0xBB8);
        public Element OpenLeftPanel => ReadObjectAt<Element>(0xBF8);
        public Element OpenRightPanel => ReadObjectAt<Element>(0xC00);
        public InventoryElement InventoryPanel => ReadObjectAt<InventoryElement>(0xC30);
        public Element TreePanel => ReadObjectAt<Element>(0xC60);
        public Element AtlasPanel => ReadObjectAt<Element>(0xC68);
        public Map Map => ReadObjectAt<Map>(0xCB8);
        public IEnumerable<ItemsOnGroundLabelElement> ItemsOnGroundLabels
        {
            get
            {
                var itemsOnGroundLabelRoot = ReadObjectAt<ItemsOnGroundLabelElement>(0xCC0);
                return itemsOnGroundLabelRoot.Children;
            }
        }
        public Element GemLvlUpPanel => ReadObjectAt<Element>(0xEC0);
        public ItemOnGroundTooltip ItemOnGroundTooltip => ReadObjectAt<ItemOnGroundTooltip>(0xEF8);
    }
}

