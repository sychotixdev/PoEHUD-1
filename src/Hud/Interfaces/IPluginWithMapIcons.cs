using System.Collections.Generic;

namespace PoeHUD.Hud.Interfaces
{
    public interface IPluginWithMapIcons
    {
        IEnumerable<MapIcon> GetIcons();
    }
}