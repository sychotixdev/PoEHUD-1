using PoeHUD.Poe.Elements;
using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameUIElements : RemoteMemoryObject
    {
        public SkillBarElement SkillBar => ReadObjectAt<SkillBarElement>(0xBA0);
        public SkillBarElement HiddenSkillBar => ReadObjectAt<SkillBarElement>(0xB58);
        public PoeChatElement ChatBox => GetObject<PoeChatElement>(M.ReadLong(Address + 0xBD8, 0xAB8, 0xC30));
        public Element QuestTracker => ReadObjectAt<Element>(0xC50);
        public Element OpenLeftPanel => ReadObjectAt<Element>(0xC90);
        public Element OpenRightPanel => ReadObjectAt<Element>(0xC98);
        public InventoryElement InventoryPanel => ReadObjectAt<InventoryElement>(0xCC8);
        public Element TreePanel => ReadObjectAt<Element>(0xCF8);
        public Element AtlasPanel => ReadObjectAt<Element>(0xD00);
        public Map Map => ReadObjectAt<Map>(0xD50);
        public IEnumerable<ItemsOnGroundLabelElement> ItemsOnGroundLabels
        {
            get
            {
                var itemsOnGroundLabelRoot = ReadObjectAt<ItemsOnGroundLabelElement>(0xD58);
                return itemsOnGroundLabelRoot.Children;
            }
        }
        public Element GemLvlUpPanel => ReadObjectAt<Element>(0xF70);
        public ItemOnGroundTooltip ItemOnGroundTooltip => ReadObjectAt<ItemOnGroundTooltip>(0xFD8);
    }
}

