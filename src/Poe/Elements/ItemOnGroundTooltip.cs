namespace PoeHUD.Poe.Elements
{
    public class ItemOnGroundTooltip : Element
    {
        public Element Tooltip => GetChildAtIndex(0);
        public Element TooltipUI => GetChildAtIndex(0);
    }
}