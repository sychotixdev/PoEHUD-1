using System.Collections.Generic;
using System;
using PoeHUD.Poe.RemoteMemoryObjects;
using PoeHUD.Controllers;
using PoeHUD.Models;
using SharpDX;

namespace PoeHUD.Poe.Components
{
    public partial class Actor : Component
    {
        public ActionFlags Action => Address != 0 ? (ActionFlags)M.ReadInt(Address + 0xF8) : ActionFlags.None;
        public bool isMoving => (Action & ActionFlags.Moving) > 0;
        public bool isAttacking => (Action & ActionFlags.UsingAbility) > 0;

        [Flags]
        public enum ActionFlags
        {
            None = 0,
            UsingAbility = 2,

            //Actor is currently playing the "attack" animation, and therefor locked in a cooldown before any other action.
            AbilityCooldownActive = 16,
            Dead = 64,
            Moving = 128,

            /// actor is in the washed up state and false otherwise.
            WashedUpState = 256,
            HasMines = 2048
        }
    }
}
