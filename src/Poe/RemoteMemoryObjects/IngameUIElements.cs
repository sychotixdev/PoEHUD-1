using PoeHUD.Poe.Elements;
using System.Collections.Generic;
using System.IO;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameUIElements : RemoteMemoryObject
    {
        public Element QuestTracker => ReadObjectAt<Element>(0xB58 + Offsets.GarenaTWDelta);
        public Element OpenLeftPanel => ReadObjectAt<Element>(0xB98 + Offsets.GarenaTWDelta);
        public Element OpenRightPanel => ReadObjectAt<Element>(0xBA0 + Offsets.GarenaTWDelta);
        public Element InventoryPanel => ReadObjectAt<Element>(0xBD0 + Offsets.GarenaTWDelta);
        public Element TreePanel => ReadObjectAt<Element>(0xC00 + Offsets.GarenaTWDelta);
        public Element AtlasPanel => ReadObjectAt<Element>(0xC08 + Offsets.GarenaTWDelta);
        public Map Map => ReadObjectAt<Map>(0xC38 + Offsets.GarenaTWDelta);
        public IEnumerable<ItemsOnGroundLabelElement> ItemsOnGroundLabels
        {
            get
            {
                var itemsOnGroundLabelRoot = ReadObjectAt<ItemsOnGroundLabelElement>(0xC40 + Offsets.GarenaTWDelta);

                DebugPlug.DebugPlugin.LogMsg("ItemsOnGroundLabelElementAddr: " + Address.ToString("x"), -2);

                return itemsOnGroundLabelRoot.Children;
            }
        }
        public Element GemLvlUpPanel => ReadObjectAt<Element>(0xDE8 + Offsets.GarenaTWDelta);
        public ItemOnGroundTooltip ItemOnGroundTooltip => ReadObjectAt<ItemOnGroundTooltip>(0xE08 + Offsets.GarenaTWDelta);
    }
}

