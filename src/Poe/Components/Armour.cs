namespace PoeHUD.Poe.Components
{
    public class Armour : Component
    {
        public int EvasionScore
        {
            get
            {
                return this.Address != 0 ? this.M.ReadInt(this.Address + 0x10, 0x10) : 0;
            }
        }
        public int ArmourScore
        {
            get
            {
                return this.Address != 0 ? this.M.ReadInt(this.Address + 0x10, 0x14) : 0;
            }
        }
        public int EnergyShieldScore
        {
            get
            {
                return this.Address != 0 ? this.M.ReadInt(this.Address + 0x10, 0x18) : 0;
            }
        }
    }
}