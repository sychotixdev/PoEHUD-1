using System;
using PoeHUD.EntitiesCache.CachedEntities.Base;
using SharpDX;

namespace PoeHUD.Hud.Icons.MapIcons
{
    public class MapIcon
    {
        private readonly Func<bool> _show;

        public MapIcon(BaseWorldEntity cachedEntity, HudTexture hudTexture, Func<bool> show, float iconSize = 10f)
        {
            CachedEntity = cachedEntity;
            TextureIcon = hudTexture;
            _show = show;
            Size = iconSize;
        }
        
        public BaseWorldEntity CachedEntity { get; }
        public HudTexture TextureIcon { get; protected set; }
        public float Size { get; }
        public Vector2 WorldPosition => CachedEntity.GridPos;

        public static Vector2 DeltaInWorldToMinimapDelta(Vector2 delta, double diag, float scale, float deltaZ = 0)
        {
            const float CAMERA_ANGLE = 38 * MathUtil.Pi / 180;
            // Values according to 40 degree rotation of cartesian coordiantes, still doesn't seem right but closer
            var cos = (float)(diag * Math.Cos(CAMERA_ANGLE) / scale);
            var sin = (float)(diag * Math.Sin(CAMERA_ANGLE) / scale); // possible to use cos so angle = nearly 45 degrees
            // 2D rotation formulas not correct, but it's what appears to work?
            return new Vector2((delta.X - delta.Y) * cos, deltaZ - (delta.X + delta.Y) * sin);
        }

        public virtual bool IsVisible()
        {
            return _show();
        }
    }
}