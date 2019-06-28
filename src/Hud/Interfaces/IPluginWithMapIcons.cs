using System.Collections.Generic;
using PoeHUD.Hud.Icons.MapIcons;

namespace PoeHUD.Hud.Interfaces
{
    public interface IPluginWithMapIcons
    {
        IEnumerable<MapIcon> GetIcons();
    }
}