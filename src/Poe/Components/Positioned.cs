using SharpDX;

namespace PoeHUD.Poe.Components
{
	using Models.Attributes;

	public class Positioned : Component
	{
		public int GridX => Address != 0 ? M.ReadInt(Address + 0xE8) : 0;
		public int GridY => Address != 0 ? M.ReadInt(Address + 0xEC) : 0;
		public Vector2 GridPos => new Vector2(GridX, GridY);

        public byte Reaction => M.ReadByte(Address + 0x58);
	}
}