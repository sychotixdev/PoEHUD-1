using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoeHUD.Poe.Components;

namespace PoeHUD.Hud.Flasker
{
    public enum PlayerFlaskInstantType
    {
        None,
        LowLife,
        Partial,
        Full
    }

    public class PlayerFlask
    {
        public int Index { get; set; } = 0;
        public string Name { get; set; } = "None";
        public int TotalUses { get; set; } = 0;
        public string BuffString1 { get; set; } = "";
        //For Hybrid Flask as Hybrid flask have two buffs.
        public string BuffString2 { get; set; } = "";

        public bool GivesHealth { get; set; } = false;
        public bool GivesMana { get; set; } = false;
        public bool IsOffensive { get; set; } = false;
        public bool IsDefensive { get; set; } = false;
        public PlayerFlaskInstantType InstantType { get; set; }
        public bool Instant => InstantType != PlayerFlaskInstantType.None;
        public Mods Mods { get; set; } = null;
    }
}
