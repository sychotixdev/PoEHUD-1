using PoeHUD.Hud;
using SharpDX;

namespace PoeHUD.Poe.Components
{
	using Models.Attributes;

	public class Positioned : Component
    {
        public PositionedRMO PositionedStructure => GetObject<PositionedRMO>(Address);
		public int GridX => Address != 0 ? PositionedStructure.GridX : 0;
		public int GridY => Address != 0 ? PositionedStructure.GridY : 0;
		public Vector2 GridPos => new Vector2(GridX, GridY);

        public byte Reaction => PositionedStructure.Reach;

    }

    public class PositionedRMO : StructuredRemoteMemoryObject<EnumOffsets.Positioned>
    {
        public byte Reach => Structure.reach;
        public int GridX => Structure.gridX;
        public int GridY => Structure.gridY;
    }
}