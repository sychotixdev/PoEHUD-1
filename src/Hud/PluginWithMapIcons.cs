using PoeHUD.Controllers;
using PoeHUD.Hud.Interfaces;
using PoeHUD.Hud.Settings;
using PoeHUD.Hud.UI;
using System.Collections.Generic;
using PoeHUD.EntitiesCache.CachedEntities.Base;
using PoeHUD.Hud.Icons.MapIcons;

namespace PoeHUD.Hud
{
    public abstract class PluginWithMapIcons<TSettings> : Plugin<TSettings>, IPluginWithMapIcons where TSettings : SettingsBase
    {
        internal readonly Dictionary<BaseWorldEntity, MapIcon> CurrentIcons;

        protected PluginWithMapIcons(GameController gameController, Graphics graphics, TSettings settings) : base(gameController, graphics, settings)
        {
            CurrentIcons = new Dictionary<BaseWorldEntity, MapIcon>();
            GameController.Area.AreaChange += delegate
            {
                CurrentIcons.Clear();
            };
        }

        public IEnumerable<MapIcon> GetIcons()
        {
            return CurrentIcons.Values;
        }
    }
}