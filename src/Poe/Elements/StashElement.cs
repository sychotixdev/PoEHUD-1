using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.Poe.Elements
{
    public class StashElement : Element
    {
        private Element StashTitlePanel => Address != 0 ? GetObject<Element>(M.ReadLong(Address + 0xA48, 0x10, 0xb28)) : null;
        private Element StashInventoryPanel => Address != 0 ? GetObject<Element>(M.ReadLong(Address + 0xA48, 0x10, 0xb38)) : null;
        private Element StashListPanel => Address != 0 ? GetObject<Element>(M.ReadLong(Address + 0xA48, 0x10, 0xb48)) : null;

        public long TotalStashes => StashInventoryPanel.ChildCount;

        public Inventory getStashInventory(int number)
        {
            if (number >= TotalStashes)
                return null;
            if (StashInventoryPanel.Children[number].ChildCount == 0)
                return null;
            return StashInventoryPanel.Children[number].Children[0].Children[0].AsObject<Inventory>();
        }
        public string getStashName(int number)
        {
            if (number >= TotalStashes)
                return string.Empty;
            long add = StashListPanel.Children[2].Children[number].Address;
            string ret = M.ReadStringU(M.ReadLong(add + 0x690, 0x5D0) + 0x00);
            if ( ret.Length == 0)
                return M.ReadStringU(M.ReadLong(add + 0x690) + 0x5D0);
            return ret;
        }
        public Element getStashTitleElement(string stashName)
        {
            long addr = 0;
            for (int i = 0; i < StashTitlePanel.ChildCount; i++)
            {
                if (StashTitlePanel.Children[i].ChildCount == 0)
                    continue;

                addr = StashTitlePanel.Children[i].Children[0].Address;
                if (addr == 0)
                    continue;

                string text = M.ReadStringU(M.ReadLong(addr + 0x390, 0x820));
                if (text == string.Empty)
                    text = M.ReadStringU(M.ReadLong(addr + 0x390) + 0x820);
                if (text == stashName)
                    return StashTitlePanel.Children[i];
            }
            return null;
        }
    }
}
