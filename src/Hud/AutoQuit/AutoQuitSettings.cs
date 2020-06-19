using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoeHUD.Hud.Settings;

namespace PoeHUD.Hud.AutoQuit
{
    public class AutoQuitSettings : SettingsBase
        {
            public AutoQuitSettings()
            {
                Enable = new ToggleNode(false);
                percentHPQuit = new RangeNode<float>(35f, 0f, 100f);
                percentESQuit = new RangeNode<float>(35f, 0f, 100f);
                forcedAutoQuit = Keys.F4;
                suspend = new ToggleNode(true);
            }

            #region Auto Quit Menu
            [PoeHUD.Plugins.Menu("Forced Quit Hotkey:", 10)]
            public HotkeyNode forcedAutoQuit { get; set; }

            [PoeHUD.Plugins.Menu("Min % Life to Auto Quit", 30)]
            public RangeNode<float> percentHPQuit { get; set; }
            [PoeHUD.Plugins.Menu("Min % ES Auto Quit", 40)]
            public RangeNode<float> percentESQuit { get; set; }
            [PoeHUD.Plugins.Menu("Suspend in Hideout", "Suspended in Town by default.\nForce quit with the hotkey works anyway.", 50)]
            public ToggleNode suspend { get; set; }
            #endregion
        }
}
