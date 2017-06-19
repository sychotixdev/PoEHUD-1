using PoeHUD.Poe.RemoteMemoryObjects;
using System.Collections.Generic;

namespace PoeHUD.Poe.Elements
{
    public class StashElement : Element
    {
        public long TotalStashes => StashInventoryPanel.ChildCount;

        private Element StashTitlePanel => Address != 0 ? GetObject<Element>(M.ReadLong(Address + 0xA48, 0x10, 0xb28)) : null;
        private Element StashInventoryPanel => Address != 0 ? GetObject<Element>(M.ReadLong(Address + 0xA48, 0x10, 0xb38)) : null;
        private Element StashListPanel => Address != 0 ? GetObject<Element>(M.ReadLong(Address + 0xA48, 0x10, 0xb48)) : null;

        public Element ExitButton => Address != 0 ? GetObject<Element>(M.ReadLong(Address + 0xA28)) : null;
        // TODO: Gonna convert this to Address + offset mode later on.
        public Element ViewAllStashPanel => Address != 0 ? StashListPanel.Children[2] : null;
        public Element SearchBar => Address != 0 ? this.Children[3].Children[3].Children[0] : null;
        public Element ViewAllStashButton => Address != 0 ? this.Children[2].Children[0].Children[1].Children[2] : null;
        public Element NextStashButton => Address != 0 ? this.Children[2].Children[0].Children[1].Children[5] : null;
        public Element PreviousStashButton => Address != 0 ? this.Children[2].Children[0].Children[1].Children[4] : null;
        public Element ClearSearchButton => Address != 0 ? this.Children[3].Children[3].Children[1] : null;

        public Inventory VisibleStash => GetVisibleStash();
        private Inventory GetVisibleStash()
        {
            Inventory ret = null;
            for (int i = 0; i < TotalStashes; i++)
            {
                if (StashInventoryPanel.Children[i].ChildCount == 0)
                    continue;
                ret = StashInventoryPanel.Children[i].Children[0].Children[0].AsObject<Inventory>();
                if (ret.InventoryRootElement.IsVisible)
                {
                    return ret;
                }
            }
            return null;
        }

        public List<string> AllStashNames => GetAllStashNames();
        private List<string> GetAllStashNames()
        {
            List<string> ret = new List<string>();
            for (int i = 0; i < TotalStashes; i++)
            {
                ret.Add(GetStashName(i));
            }
            return ret;
        }

        public Inventory GetStashInventoryByIndex(int index)
        {
            if (index >= TotalStashes)
                return null;
            if (StashInventoryPanel.Children[index].ChildCount == 0)
                return null;
            return StashInventoryPanel.Children[index].Children[0].Children[0].AsObject<Inventory>();
        }
        public string GetStashName(int index)
        {
            if (index >= TotalStashes || index < 0)
                return string.Empty;
            long add = StashListPanel.Children[2].Children[index].Address;
            int NameLength = M.ReadInt(add + 0x690, 0x5E0);
            return NameLength < 8 ? M.ReadStringU(M.ReadLong(add + 0x690) + 0x5D0, NameLength * 2) : M.ReadStringU(M.ReadLong(add + 0x690, 0x5D0), NameLength * 2);
        }
        // Making it private because currently no plugin use it.
        private Element GetStashTitleElement(string stashName)
        {
            long addr = 0;
            int NameLength = 0;

            if (stashName == "")
                return null;

            for (int i = 0; i < StashTitlePanel.ChildCount; i++)
            {
                if (StashTitlePanel.Children[i].ChildCount == 0)
                    continue;

                addr = StashTitlePanel.Children[i].Children[0].Address;
                if (addr == 0)
                    continue;

                NameLength = M.ReadInt(addr + 0x390, 0x830);
                string text = (NameLength < 8) ? M.ReadStringU(M.ReadLong(addr + 0x390) + 0x820, NameLength * 2) : M.ReadStringU(M.ReadLong(addr + 0x390, 0x820), NameLength * 2);
                if (text == stashName)
                    return StashTitlePanel.Children[i];
            }
            return null;
        }
    }
}
