using System;
using PoeHUD.Poe.Components;

namespace PoeHUD.Poe.Elements
{
    public class InventoryItemIcon : Element
    {
        private readonly Func<Element> inventoryItemTooltip;
        private readonly Func<Element> itemInChatTooltip;
        private readonly Func<ItemOnGroundTooltip> toolTipOnground;
        private ToolTipType? toolTip;

        public InventoryItemIcon()
        {
            toolTipOnground = () => Game.IngameState.IngameUi.ItemOnGroundTooltip;
            inventoryItemTooltip = () => ReadObject<Element>(Address + 0xA7C);
            itemInChatTooltip = () => ReadObject<Element>(Address + 0x808); //bug wrong
        }

        public ToolTipType ToolTipType => (ToolTipType)(toolTip ?? (toolTip = GetToolTipType()));

        public Element Tooltip
        {
            get
            {
                switch (ToolTipType)
                {
                    case ToolTipType.ItemOnGround:
                        return toolTipOnground().Tooltip;
                    case ToolTipType.InventoryItem:
                        return inventoryItemTooltip();
                    case ToolTipType.ItemInChat:
                        return itemInChatTooltip();
                }
                return null;
            }
        }

        public Entity Item
        {
            get
            {
                switch (ToolTipType)
                {
                    case ToolTipType.ItemOnGround:
                        return Game.IngameState.IngameUi.ReadObjectAt<ItemsOnGroundLabelElement>(0x138).ReadObjectAt<Entity>(0x95C).GetComponent<WorldItem>().ItemEntity;
                    case ToolTipType.InventoryItem:
                        return ReadObject<Entity>(Address + 0xAA0);
                }
                return null;
            }
        }

        private ToolTipType GetToolTipType()
        {
            if (inventoryItemTooltip() != null && inventoryItemTooltip().IsVisible)
            {
                return ToolTipType.InventoryItem;
            }
/*            if (toolTipOnground().Tooltip != null && toolTipOnground().TooltipUI != null && toolTipOnground().TooltipUI.IsVisible)
            {
                return ToolTipType.ItemOnGround;
            }
*/            return ToolTipType.None;
        }
    }

    public enum ToolTipType
    {
        None,
        InventoryItem,
        ItemOnGround,
        ItemInChat
    }
}