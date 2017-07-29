using PoeHUD.Poe.Elements;
using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameUIElements : RemoteMemoryObject
    {
        public Element QuestTracker => ReadObjectAt<Element>(0xBC8);
        public Element OpenLeftPanel => ReadObjectAt<Element>(0xC08);
        public Element OpenRightPanel => ReadObjectAt<Element>(0xC10);
        public InventoryElement InventoryPanel => ReadObjectAt<InventoryElement>(0xC40);
        public Element TreePanel => ReadObjectAt<Element>(0xC70);
        public Element AtlasPanel => ReadObjectAt<Element>(0xC78);
        public Map Map => ReadObjectAt<Map>(0xCC8);
        public IEnumerable<ItemsOnGroundLabelElement> ItemsOnGroundLabels
        {
            get
            {
                var itemsOnGroundLabelRoot = ReadObjectAt<ItemsOnGroundLabelElement>(0xCD0);
                return itemsOnGroundLabelRoot.Children;
            }
        }
        public Element GemLvlUpPanel => ReadObjectAt<Element>(0xED0);
        public ItemOnGroundTooltip ItemOnGroundTooltip => ReadObjectAt<ItemOnGroundTooltip>(0xF30);
    }
}

