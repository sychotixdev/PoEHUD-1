using PoeHUD.Hud.Settings;

namespace PoeHUD.Hud.Loot
{
    public class QualityItemsSettings : SettingsBase
    {
        public QualityItemsSettings()
        {
            Enable = true;
            Weapon = new QualityItemSettings(false, 12);
            Armour = new QualityItemSettings(false, 12);
            Flask = new QualityItemSettings(false, 10);
            SkillGem = new QualityItemSettings(true, 0);
        }

        public QualityItemSettings Weapon { get; set; }
        public QualityItemSettings Armour { get; set; }
        public QualityItemSettings Flask { get; set; }
        public QualityItemSettings SkillGem { get; set; }
    }
}