using System;
using PoeHUD.EntitiesCache.CachedEntities;

namespace PoeHUD.Hud.Icons.MapIcons
{
    public class ChestMapIcon : MapIcon
    {
        public ChestMapIcon(ChestEntity cachedEntity, HudTexture hudTexture, Func<bool> show, float iconSize)
            : base(cachedEntity, hudTexture, show, iconSize)
        {
        }
    }
}