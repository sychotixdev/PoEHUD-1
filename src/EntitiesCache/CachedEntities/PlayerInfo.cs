using System.Windows.Forms.VisualStyles;
using PoeHUD.Controllers;
using PoeHUD.EntitiesCache.CachedEntities.Base;
using PoeHUD.Poe;
using PoeHUD.Poe.Components;
using SharpDX;

namespace PoeHUD.EntitiesCache.CachedEntities
{
    /// <summary>
    /// Holds all cached information about player
    /// </summary>
    public static class PlayerInfo
    {
        /// <summary>
        /// Gets the per frame cached grid position. Use PositionedComponent.GridPos for updated data
        /// </summary>
        public static Vector2 GridPos { get; private set; }
        /// <summary>
        /// Gets the per frame cached world position. Use PositionedComponent.WorldPos for updated data
        /// </summary>
        public static Vector3 WorldPos { get; private set; }
        /// <summary>
        /// Game window rectangle.
        /// </summary>
        public static RectangleF GameWindowRectangle { get; private set; }
        public static PlayerEntity PlayerEntity { get; private set; }
        public static Life LifeComponent { get; private set; }
        public static Positioned PositionedComponent { get; private set; }
        public static Actor ActorComponent { get; private set; }
        public static Stats StatsComponent { get; private set; }
        public static Pathfinding PathfindingComponent { get; private set; }
        public static Inventories InventoriesComponent { get; private set; }
        public static Player PlayerComponent { get; private set; }
        public static Render RenderComponent { get; private set; }
        public static Targetable TargetableComponent { get; private set; }
        public static bool IsAlive { get; private set; }
        public static long Address { get; private set; }

        internal static void UpdateInfo()
        {
            GameWindowRectangle = GameController.Instance.Window.GetWindowRectangle();
            GridPos = PlayerEntity.GridPos;
            WorldPos = PlayerEntity.WorldPos;
            IsAlive = PlayerEntity.IsAlive;
        }

        internal static void UpdatePlayer()
        {
            Address = GameController.Instance.Game.InGameState.Data.LocalPlayerAddress;
            PlayerEntity = new PlayerEntity(new NewWorldEntityParams(0, Address, null, 0, 0));

            LifeComponent = PlayerEntity.GetComponent<Life>();
            PositionedComponent = PlayerEntity.GetComponent<Positioned>();
            ActorComponent = PlayerEntity.GetComponent<Actor>();
            StatsComponent = PlayerEntity.GetComponent<Stats>();
            PathfindingComponent = PlayerEntity.GetComponent<Pathfinding>();
            InventoriesComponent = PlayerEntity.GetComponent<Inventories>();
            PlayerComponent = PlayerEntity.GetComponent<Player>();
            RenderComponent = PlayerEntity.GetComponent<Render>();
            TargetableComponent = PlayerEntity.GetComponent<Targetable>();
        }
    }
}
