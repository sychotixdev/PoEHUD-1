using PoeHUD.Models.Enums;
using PoeHUD.Poe.Elements;
using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class Inventory : Element
    {
        public long ItemCount => M.ReadLong(Address + 0x3B8);
        public long TotalBoxesInInventoryRow => M.ReadInt(Address + 0x4A0);

        public InventoryType InvType
        {
            get
            {
                // For Poe MemoryLeak bug where ChildCount of PlayerInventory keep
                // Increasing on Area/Map Change. Ref:
                // http://www.ownedcore.com/forums/mmo/path-of-exile/poe-bots-programs/511580-poehud-overlay-updated-362.html#post3718876
                // Orriginal Value of ChildCount should be 0x18
                for (int j = 1; j < InventoryList.InventoryCount; j++)
                    if (Game.IngameState.IngameUi.InventoryPanel[(InventoryIndex)j].Address == Address)
                        return InventoryType.PlayerInventory;

                switch (this.AsObject<Element>().Parent.ChildCount)
                {
                    case 0x6f:
                        return InventoryType.EssenceStash;
                    case 0x38:
                        return InventoryType.CurrencyStash;
                    case 0x40:
                        return InventoryType.FragmentStash;
                    case 0x05:
                        return InventoryType.DivinationStash;
                    case 0x06:
                        return InventoryType.MapStash;
                    case 0x01:
                        // Normal Stash and Quad Stash is same.
                        if (TotalBoxesInInventoryRow == 24)
                        {
                            return InventoryType.QuadStash;
                        }
                        return InventoryType.NormalStash;
                    default:
                        return InventoryType.InvalidInventory;
                }
            }
        }

        public Element InventoryUiElement
        {
            get
            {
                switch(InvType)
                {
                    case InventoryType.PlayerInventory:
                    case InventoryType.NormalStash:
                    case InventoryType.QuadStash:
                        return this.AsObject<Element>();
                    case InventoryType.CurrencyStash:
                    case InventoryType.EssenceStash:
                    case InventoryType.FragmentStash:
                        return this.AsObject<Element>().Parent;
                    case InventoryType.DivinationStash:
                        // There are many children  but we are only interested in one of them i.e. Owned Cards
                        return GetObject<Element>(M.ReadLong(Address + Element.OffsetBuffers + 0x24, 0x08));
                    case InventoryType.MapStash:
                        return this.AsObject<Element>().Parent;
                    default:
                        return null;
                }
            }
        }

        //I'm using this to debug all items (NormalInventoryItem.InventPosX), etc..
        //public List<NormalInventoryItem> _DebugVisibleInventoryItems => InventoryUiElement.Children.Select(x => InventoryUiElement.GetObject<NormalInventoryItem>(x.Address)).ToList();

        // Shows Item details of visible inventory/stashes
        public List<NormalInventoryItem> VisibleInventoryItems
        {
            get
            {
                var list = new List<NormalInventoryItem>();
                var InvRoot = InventoryUiElement;
                if (InvRoot == null || InvRoot.Address == 0x00)
                    //throw new InvalidOperationException("InventoryUiElement is incorrect (address is '0')");
                    return null;
                if (!InvRoot.IsVisible)
                    //throw new InvalidOperationException("InventoryUiElement is not visible");
                return null;
           

                switch (InvType)
                {
                    case InventoryType.PlayerInventory:
                        foreach (var item in InvRoot.Children)
                        {
                            if (item.ChildCount == 0) continue; //3.3 fix, Can cause problems but filter out first incorrect item
                            var normalItem = item.AsObject<NormalInventoryItem>();
                            if (normalItem.InventPosX > 11 || normalItem.InventPosY > 4) continue;//Sometimes it gives big wrong values. Fix from macaddict (#plugin-help)
                            list.Add(normalItem);
                        }
                        break;
                    case InventoryType.NormalStash:
                        foreach (var item in InvRoot.Children)
                        {
                            if (item.ChildCount == 0) continue; //3.3 fix, Can cause problems but filter out first incorrect item
                            var normalItem = item.AsObject<NormalInventoryItem>();
                            if (normalItem.InventPosX > 11 || normalItem.InventPosY > 11) continue;
                            list.Add(normalItem);
                        }
                        break;
                    case InventoryType.QuadStash:
                        foreach (var item in InvRoot.Children)
                        {
                            if (item.ChildCount == 0) continue; //3.3 fix, Can cause problems but filter out first incorrect item
                            var normalItem = item.AsObject<NormalInventoryItem>();
                            if (normalItem.InventPosX > 23 || normalItem.InventPosY > 23) continue;
                            list.Add(normalItem);
                        }
                        break;

                    //For 3.3 child count is 3, not 2 as earlier, so we using the second one
                    case InventoryType.CurrencyStash:
                        foreach (var item in InvRoot.Children)
                        {
                            if (item.ChildCount > 1)
                                list.Add(item.Children[1].AsObject<CurrencyInventoryItem>());
                        }
                        break;
                    case InventoryType.EssenceStash:
                        foreach (var item in InvRoot.Children)
                        {
                            if (item.ChildCount > 1)
                                list.Add(item.Children[1].AsObject<EssenceInventoryItem>());
                        }
                        break;
                    case InventoryType.FragmentStash:
                        foreach (var item in InvRoot.Children)
                        {
                            if (item.ChildCount > 1)
                                list.Add(item.Children[1].AsObject<FragmentInventoryItem>());
                        }
                        break;
                    case InventoryType.DivinationStash:
                        foreach (var item in InvRoot.Children)
                        {
                            // Divination Stash tab isn't loaded.
                            if (item.ChildCount < 2)
                                return null;

                            if (item.Children[1].ChildCount > 1)
                                list.Add(item.Children[1].Children[1].AsObject<DivinationInventoryItem>());
                        }
                        break;
                    case InventoryType.MapStash:
                        // Children[3] is where all the inventories are, rest of the childrens are just buttons.
                        foreach (var subInventories in InvRoot.Children[3].Children)
                        {
                            // VisibleInventoryItems would only be found in Visible Sub Inventory :p
                            if (!subInventories.IsVisible)
                                continue;

                            // All empty sub Inventories have full ChildCount (72) but all childcount have 0 items.
                            if (subInventories.ChildCount == 72 && subInventories.Children[0].AsObject<NormalInventoryItem>().Item.Address == 0x00)
                                continue;

                            foreach (var item in subInventories.Children)
                            {
                                if (item.ChildCount == 0) continue; //3.3 fix
                                list.Add(item.AsObject<NormalInventoryItem>());
                            }
                        }
                        break;
                }
                return list;
            }
        }
    }
}
