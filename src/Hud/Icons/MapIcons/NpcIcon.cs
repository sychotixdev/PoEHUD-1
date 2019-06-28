using System;
using PoeHUD.EntitiesCache.CachedEntities;

namespace PoeHUD.Hud.Icons.MapIcons
{
    public class NpcIcon : MapIcon
    {
        public NpcIcon(NpcEntity cachedEntity, string hudTexture, Func<bool> show, float iconSize = 10) : 
            base(cachedEntity, new HudTexture(hudTexture), show, iconSize)
        {
        }
    }
}
