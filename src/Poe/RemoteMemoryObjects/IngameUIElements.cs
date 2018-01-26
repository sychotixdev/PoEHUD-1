using PoeHUD.Poe.Elements;
using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameUIElements : RemoteMemoryObject
    {

        public SkillBarElement SkillBar => ReadObjectAt<SkillBarElement>(0xB58);
        public SkillBarElement HiddenSkillBar => ReadObjectAt<SkillBarElement>(0xB60);
        public PoeChatElement ChatBox => GetObject<PoeChatElement>(M.ReadLong(Address + 0xBD8, 0xAB8, 0xC30));
        public Element QuestTracker => ReadObjectAt<Element>(0xC08);
        public Element OpenLeftPanel => ReadObjectAt<Element>(0xC48);
        public Element OpenRightPanel => ReadObjectAt<Element>(0xC50);
        public InventoryElement InventoryPanel => ReadObjectAt<InventoryElement>(0xC80);
        public Element TreePanel => ReadObjectAt<Element>(0xCB0);
        public Element AtlasPanel => ReadObjectAt<Element>(0xCB8);
        public Map Map => ReadObjectAt<Map>(0xD08);
        public IEnumerable<ItemsOnGroundLabelElement> ItemsOnGroundLabels
        {
            get
            {
                var itemsOnGroundLabelRoot = ReadObjectAt<ItemsOnGroundLabelElement>(0xD10);
                return itemsOnGroundLabelRoot.Children;
            }
        }
        public Element GemLvlUpPanel => ReadObjectAt<Element>(0xF20);
        public ItemOnGroundTooltip ItemOnGroundTooltip => ReadObjectAt<ItemOnGroundTooltip>(0xF88);
    }
}

