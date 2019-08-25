using PoeHUD.Hud.Settings;

namespace PoeHUD.Hud.Health
{
    public sealed class FlaskerSettings : SettingsBase
    {
        public FlaskerSettings()
        {
            Enable = false;
            
        }

        [PoeHUD.Plugins.Menu("Auto Flask", 0)]
        public ToggleNode AutoFlask { get; set; } = false;

        [PoeHUD.Plugins.Menu("HP Potion", 1, 0)]
        public RangeNode<int> HPPotion { get; set; } = new RangeNode<int>(65, 0, 100);
        [PoeHUD.Plugins.Menu("Instant HP Potion", 2, 0)]
        public RangeNode<int> InstantHPPotion { get; set; } = new RangeNode<int>(35, 0, 100);

        [PoeHUD.Plugins.Menu("Mana Potion", 3, 0)]
        public RangeNode<int> ManaPotion { get; set; } = new RangeNode<int>(65, 0, 100);

        [PoeHUD.Plugins.Menu("Instant Mana Potion", 3, 0)]
        public RangeNode<int> InstantManaPotion { get; set; } = new RangeNode<int>(35, 0, 100);

        [PoeHUD.Plugins.Menu("Defensive Flask", 10)]
        public ToggleNode DefensiveFlaskEnable { get; set; } = false;
        [PoeHUD.Plugins.Menu("Defensive Flask HP", 11, 10)]
        public RangeNode<int> HPPercentDefensive { get; set; } = new RangeNode<int>(50, 0, 100);
        [PoeHUD.Plugins.Menu("Offensive Flask", 20)]
        public ToggleNode OffensiveFlaskEnable { get; set; } = false;
        [PoeHUD.Plugins.Menu("Offensive Flask HP", 21, 20)]
        public RangeNode<int> HPPercentOffensive { get; set; } = new RangeNode<int>(50, 0, 100);
        [PoeHUD.Plugins.Menu("Offensive Flask", 30)]
        public ToggleNode SpeedFlaskEnable { get; set; } = false;

        [PoeHUD.Plugins.Menu("Remove Ailments", 40)]
        public ToggleNode RemAilment { get; set; } = false;
        [PoeHUD.Plugins.Menu("Frozen", 41, 40)]
        public ToggleNode RemFrozen { get; set; } = false;
        [PoeHUD.Plugins.Menu("Burning", 42, 40)]
        public ToggleNode RemBurning { get; set; } = false;
        [PoeHUD.Plugins.Menu("Shocked", 43, 40)]
        public ToggleNode RemShocked { get; set; } = false;
        [PoeHUD.Plugins.Menu("Curse", 44, 40)]
        public ToggleNode RemCurse { get; set; } = false;
        [PoeHUD.Plugins.Menu("Poison", 45, 40)]
        public ToggleNode RemPoison { get; set; } = false;
        [PoeHUD.Plugins.Menu("Bleed", 46, 40)]
        public ToggleNode RemBleed { get; set; } = false;
        [PoeHUD.Plugins.Menu("Corrupted Blood Count", 47, 40)]
        public RangeNode<int> CorruptCount { get; set; } = new RangeNode<int>(10, 0, 20);
    }
}