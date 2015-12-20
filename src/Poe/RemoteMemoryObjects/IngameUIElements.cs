using PoeHUD.Poe.Elements;
using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameUIElements : RemoteMemoryObject
    {
        public Element Uknown0 => ReadObjectAt<Element>(0x40);
        public Element HpGlobe => ReadObjectAt<Element>(0x44);
        public Element ManaGlobe => ReadObjectAt<Element>(0x48);
        public Element Flasks => ReadObjectAt<Element>(0x50);
        public Element XpBar => ReadObjectAt<Element>(0x54);
        public Element MenuButton => ReadObjectAt<Element>(0x58);
        public Element ShopButton => ReadObjectAt<Element>(0x84);
        public Element HideoutEditButton => ReadObjectAt<Element>(0x88);
        public Element HideoutStashButton => ReadObjectAt<Element>(0x8C);
        public Element Mouseposition => ReadObjectAt<Element>(0xA4);
        public Element ActionButtons => ReadObjectAt<Element>(0xA8);
        public Element Chat => ReadObjectAt<Element>(0xE8);
        public Element QuestTracker => ReadObjectAt<Element>(0xF0);
        public Element MtxInventory => ReadObjectAt<Element>(0xF4);
        public Element MtxShop => ReadObjectAt<Element>(0xF8);
        public Element InventoryPanel => ReadObjectAt<Element>(0x108);
        public Element StashPanel => ReadObjectAt<Element>(0x108);
        public Element SocialPanel => ReadObjectAt<Element>(0x114);
        public Element TreePanel => ReadObjectAt<Element>(0x11C);
        public Element CharacterPanel => ReadObjectAt<Element>(0x11C);
        public Element OptionsPanel => ReadObjectAt<Element>(0x120);
        public Element AchievementsPanel => ReadObjectAt<Element>(0x124);
        public Element WorldPanel => ReadObjectAt<Element>(0x12C);
        public Map Map => ReadObjectAt<Map>(0x134);
        public IEnumerable<ItemsOnGroundLabelElement> ItemsOnGroundLabels
        {
            get
            {
                var itemsOnGroundLabelRoot = ReadObjectAt<ItemsOnGroundLabelElement>(0x138);
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

        public Element Buffs => ReadObjectAt<Element>(0x138);
        public Element Buffs2 => ReadObjectAt<Element>(0x194);
        public Element OpenLeftPanel => ReadObjectAt<Element>(0x16C);
        public Element OpenRightPanel => ReadObjectAt<Element>(0x170);
        public Element OpenNpcDialogPanel => ReadObjectAt<Element>(0x168);
        public Element CreatureInfoPanel => ReadObjectAt<Element>(0x18C);
        public Element InstanceManagerPanel => ReadObjectAt<Element>(0x1A0);
        public Element InstanceManagerPanel2 => ReadObjectAt<Element>(0x1A4);
        public Element SwitchingZoneInfo => ReadObjectAt<Element>(0x1CC);
        public Element GemLvlUpPanel => ReadObjectAt<Element>(0x220);
        public ItemOnGroundTooltip ItemOnGroundTooltip => ReadObjectAt<ItemOnGroundTooltip>(0x230);
    }
}