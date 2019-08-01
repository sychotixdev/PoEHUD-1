using System.Collections.Generic;
using System;
using PoeHUD.Poe.RemoteMemoryObjects;
using PoeHUD.Controllers;
using PoeHUD.Hud;
using PoeHUD.Models;
using SharpDX;

namespace PoeHUD.Poe.Components
{
    public partial class Actor : Component
    {
        public ActorRMO ActorStructure => GetObject<ActorRMO>(Address);

        public ActionFlags Action => Address != 0 ? (ActionFlags)ActorStructure.Action : ActionFlags.None;
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

    public class ActorRMO : StructuredRemoteMemoryObject<EnumOffsets.Actor>
    {
        public int Action => Structure.action;
    }
}
