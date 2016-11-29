using PoeHUD.Poe.Elements;
using System.Collections.Generic;
using System.IO;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameUIElements : RemoteMemoryObject
    {
        public Element QuestTracker => ReadObjectAt<Element>(0x9BC);
        public Element OpenLeftPanel => ReadObjectAt<Element>(0x9EC);
        public Element OpenRightPanel => ReadObjectAt<Element>(0x9F0);
        public Element InventoryPanel => ReadObjectAt<Element>(0xA00);
        public Element TreePanel => ReadObjectAt<Element>(0xA18);
        public Element AtlasPanel => ReadObjectAt<Element>(0xA1C);
        public Map Map => ReadObjectAt<Map>(0xA34);
        public IEnumerable<ItemsOnGroundLabelElement> ItemsOnGroundLabels
        {
            get
            {
                var itemsOnGroundLabelRoot = ReadObjectAt<ItemsOnGroundLabelElement>(0xA38);
                return itemsOnGroundLabelRoot.Children;
            }
        }
        public Element GemLvlUpPanel => ReadObjectAt<Element>(0xB0C);
        public ItemOnGroundTooltip ItemOnGroundTooltip => ReadObjectAt<ItemOnGroundTooltip>(0xB1C);
    }
}