// (c) by c.huede
// if used in any program the sourcecode for thios has to be provided !
namespace PoeHUD.Poe.EntityComponents
{
    public class LocalStats : Component
    {
        public LocalStats()
        {
        }

        public int Type
        {
            get
            {
                return this.Address != 0 ? this.M.ReadInt(this.Address) : 0;
            }
        }

        public int Value
        {
            get
            {
                return this.Address != 0 ? this.M.ReadInt(this.Address + 4) : 0;
            }
        }
        // To be implemented
    }
}
