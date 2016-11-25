namespace PoeHUD.Poe.Components
{
    public class Stack : Component
    {
        public int Size
        {
            get
            {
                if (Address == 0)
                {
                    return 0;
                }
                int res = M.ReadInt(Address + 0x18);
                return res;
            }
        }
    }
}