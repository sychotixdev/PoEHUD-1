namespace PoeHUD.Poe.Elements
{
    public class EntityLabel : Element
    {
        public string Text
        {
            get
            {
                int LabelLen = M.ReadInt(Address + 0xB5C);
                if (LabelLen <= 0 || LabelLen > 256)
                {
                    return "";
                }
                return LabelLen >= 8 ? M.ReadStringU(M.ReadInt(Address + 0xB4C), LabelLen * 2) : M.ReadStringU(Address + 0xB4C, LabelLen * 2);
            }
        }
    }
}