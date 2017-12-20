namespace PoeHUD.Poe.Components
{
    public class Stats : Component
    {
        private int statOffset => (Game.IngameState.Data.CurrentArea.IsTown ||
            Game.IngameState.Data.CurrentArea.Name.Contains("Hideout")) ? 0x00 : 0x08;
        public int coldResistance => M.ReadInt(Address + 0x50, 0x154 + statOffset);
        public int fireResistance => M.ReadInt(Address + 0x50, 0x15C + statOffset);
        public int lightningResistance => M.ReadInt(Address + 0x50, 0x164 + statOffset);
        public int chaosResistance => M.ReadInt(Address + 0x50, 0x16C + statOffset);
    }
}
