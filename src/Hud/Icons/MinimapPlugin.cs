using System;
using System.Collections.Generic;
using System.Linq;
using PoeHUD.Controllers;
using PoeHUD.EntitiesCache.CachedEntities;
using PoeHUD.Framework.Helpers;
using PoeHUD.Hud.Icons.MapIcons;
using PoeHUD.Hud.UI;
using PoeHUD.Plugins;
using PoeHUD.Poe.Components;
using SharpDX;

namespace PoeHUD.Hud.Icons
{
    public class MinimapPlugin : Plugin<MapIconsSettings>
    {
        private readonly Func<IEnumerable<MapIcon>> getIcons;

        public MinimapPlugin(GameController gameController, Graphics graphics, Func<IEnumerable<MapIcon>> gatherMapIcons,
            MapIconsSettings settings)
            : base(gameController, graphics, settings)
        {
            getIcons = gatherMapIcons;
        }

        public override void Render()
        {
            try
            {
                if (!Settings.Enable || !GameController.InGame || !Settings.IconsOnMinimap)
                    return;

                var smallMinimap = GameController.Game.InGameState.InGameUi.Map.SmallMinimap;

                if (!smallMinimap.IsVisible)
                    return;

                if (GameController.Game.InGameState.InGameUi.AtlasPanel.IsVisible)
                    return;

                if (GameController.Game.InGameState.InGameUi.TreePanel.IsVisible)
                    return;

                var playerPos = PlayerInfo.GridPos;
                var posZ = PlayerInfo.RenderComponent.Z;

                const float SCALE = 240f;
                var mapRect = smallMinimap.GetClientRect();
                var mapCenter = new Vector2(mapRect.X + mapRect.Width / 2, mapRect.Y + mapRect.Height / 2).Translate(0, 0);
                var diag = Math.Sqrt(mapRect.Width * mapRect.Width + mapRect.Height * mapRect.Height) / 2.0;

                foreach (var icon in getIcons().Where(x => x.IsVisible()))
                {
                    var iconZ = icon.CachedEntity.GetComponent<Render>().Z;
                    var point = mapCenter + MapIcon.DeltaInWorldToMinimapDelta(icon.WorldPosition - playerPos, diag, SCALE, (iconZ - posZ) / 20);
                    var texture = icon.TextureIcon;
                    var size = icon.Size;
                    var rect = new RectangleF(point.X - size / 2f, point.Y - size / 2f, size, size);
                    mapRect.Contains(ref rect, out var isContain);

                    if (isContain)
                        texture.Draw(Graphics, rect);
                }
            }
            catch
            {
                // do nothing
            }
        }
    }
}
