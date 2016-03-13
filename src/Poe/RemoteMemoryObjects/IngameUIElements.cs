using PoeHUD.Poe.Elements;
using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameUIElements : RemoteMemoryObject
    {
        public Element Uknown0 => ReadObjectAt<Element>(0x38);
        public Element HpGlobe => ReadObjectAt<Element>(0x3C);
        public Element ManaGlobe => ReadObjectAt<Element>(0x40);
        public Element Flasks => ReadObjectAt<Element>(0x48);
        public Element XpBar => ReadObjectAt<Element>(0x4C);
        public Element MenuButton => ReadObjectAt<Element>(0x50);
        public Element ShopButton => ReadObjectAt<Element>(0x7C);
        public Element HideoutEditButton => ReadObjectAt<Element>(0x80);
        public Element HideoutStashButton => ReadObjectAt<Element>(0x84);
        public Element Mouseposition => ReadObjectAt<Element>(0xA0);
        public Element ActionButtons => ReadObjectAt<Element>(0xA4);
        public Element Chat => ReadObjectAt<Element>(0xE4);
        public Element QuestTracker => ReadObjectAt<Element>(0xF4);
        public Element MtxInventory => ReadObjectAt<Element>(0xF8);
        public Element MtxShop => ReadObjectAt<Element>(0xFC);
        public Element InventoryPanel => ReadObjectAt<Element>(0x100);
        public Element StashPanel => ReadObjectAt<Element>(0x104);
        public Element SocialPanel => ReadObjectAt<Element>(0x110);
        public Element TreePanel => ReadObjectAt<Element>(0x114);
        public Element CharacterPanel => ReadObjectAt<Element>(0x118);
        public Element OptionsPanel => ReadObjectAt<Element>(0x11C);
        public Element AchievementsPanel => ReadObjectAt<Element>(0x120);
        public Element EventsAndPvP => ReadObjectAt<Element>(0x124);
        public Element WorldPanel => ReadObjectAt<Element>(0x128);
        public Map Map => ReadObjectAt<Map>(0x12C);

        public IEnumerable<ItemsOnGroundLabelElement> ItemsOnGroundLabels
        {
            get
            {
                var itemsOnGroundLabelRoot = ReadObjectAt<ItemsOnGroundLabelElement>(0x130);
                return itemsOnGroundLabelRoot.Children;
            }
        }

        public List<HPbarElement> MonsterHpLabels
        {
            get
            {
                var monsterHpLabelsRoot = ReadObjectAt<HPbarElement>(0x12C);
                return monsterHpLabelsRoot.Children;
            }
        }

        public Element Buffs => ReadObjectAt<Element>(0x130);
        public Element Buffs2 => ReadObjectAt<Element>(0x18C);
        public Element OpenLeftPanel => ReadObjectAt<Element>(0x160);
        public Element OpenRightPanel => ReadObjectAt<Element>(0x164);
        public Element OpenNpcDialogPanel => ReadObjectAt<Element>(0x15C);
        public Element CreatureInfoPanel => ReadObjectAt<Element>(0x180);
        public Element InstanceManagerPanel => ReadObjectAt<Element>(0x1D0);
        public Element InstanceManagerPanel2 => ReadObjectAt<Element>(0x1D4);
        public Element SwitchingZoneInfo => ReadObjectAt<Element>(0x1D8);
        public Element GemLvlUpPanel => ReadObjectAt<Element>(0x224);
        public ItemOnGroundTooltip ItemOnGroundTooltip => ReadObjectAt<ItemOnGroundTooltip>(0x234);
    }
}