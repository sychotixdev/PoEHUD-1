namespace PoeHUD.Poe.EntityComponents
{
	public class Base : Component
	{

        public string Name
        {
            get
            {
                return this.M.ReadStringU(this.M.ReadInt(this.Address +0x8, 0x10), 256);
            }
        }


		// 0x8 - link to base item
		 // +0x10 - Name
		 // +0x30 - Use hint
		 // +0x50 - Link to Data/BaseItemTypes.dat

		// 0xC (+4) fileref to visual identity
	}
}
