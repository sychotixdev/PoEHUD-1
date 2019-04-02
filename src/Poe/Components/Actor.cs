using System.Collections.Generic;
using System;
using PoeHUD.Poe.RemoteMemoryObjects;
using PoeHUD.Controllers;
using PoeHUD.Models;
using SharpDX;
using System.Runtime.InteropServices;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct ActorStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
        [FieldOffset(0x60)]
        public long CurrentActionPtr;
        [FieldOffset(0xD8)]
        public int ActionId;
        [FieldOffset(0x110)]
        public float TimeSinceLastMove;
        [FieldOffset(0x114)]
        public float TimeSinceLastAction;
        [FieldOffset(0x2C0)]
        public long SkillsStartPointer;
        [FieldOffset(0x2C8)]
        public long SkillsEndPointer;
        [FieldOffset(0x2F0)]
        public long VaalSkillsStartPointer;
        [FieldOffset(0x2F8)]
        public long VaalSkillsEndPointer;
        [FieldOffset(0x328)]
        public long DeployedObjectStartPtr;
        [FieldOffset(0x330)]
        public long DeployedObjectEndPtr;
    }

    public class Actor : StructuredRemoteMemoryObject<ActorStruct>, Component
    {
        private const int ACTOR_VAAL_SKILLS_SIZE = 0x20;

        public Entity Owner => GetObject<Entity>(Structure.OwnerPtr);

        /// <summary>
        ///     Standing still = 2048 =bit 11 set
        ///     running = 2178 = bit 11 & 7
        ///     Maybe Bit-field : Bit 7 set = running
        /// </summary>
        public int ActionId => Address != 0 ? Structure.ActionId : 1;

        public ActionFlags Action => Address != 0 ? (ActionFlags)Structure.ActionId : ActionFlags.None;
        public bool isMoving => (Action & ActionFlags.Moving) > 0;
        public bool isAttacking => (Action & ActionFlags.UsingAbility) > 0;

        public bool HasMinion(Entity entity)
        {
            if (Address == 0)
            {
                return false;
            }
            long num = Structure.DeployedObjectStartPtr;
            long num2 = Structure.DeployedObjectEndPtr;
            for (long i = num; i < num2; i += 8)
            {
                int num3 = M.ReadInt(i);
                if (num3 == (int)(entity.Id >> 32))
                {
                    return true;
                }
            }
            return false;
        }


        public float TimeSinseLastMove => -Structure.TimeSinceLastMove;
        public float TimeSinseLastAction => -Structure.TimeSinceLastAction;

        public ActionWrapper CurrentAction => (Action & ActionFlags.UsingAbility) > 0 ? GetObject<ActionWrapper>(Structure.CurrentActionPtr) : null;

        // e.g minions, mines
        private long DeployedObjectStart => Structure.DeployedObjectStartPtr;
        private long DeployedObjectEnd => Structure.DeployedObjectEndPtr;
        public long DeployedObjectsCount => (DeployedObjectEnd - DeployedObjectStart) / 8;
        public List<DeployedObject> DeployedObjects
        {
            get
            {
                var result = new List<DeployedObject>();
                var LIMIT = 300;
                for (var addr = DeployedObjectStart; addr < DeployedObjectEnd; addr += 8)
                {
                    var objectId = M.ReadUInt(addr);
                    var objectKey = M.ReadUShort(addr + 4);//in list of entities
                    result.Add(new DeployedObject(objectId, objectKey));

                    if (--LIMIT < 0)
                    {
                        DebugPlug.DebugPlugin.LogMsg("Fixed stuck in Actor.DeployedObjects", 2);
                        break;
                    }
                }
                return result;
            }
        }

        public List<ActorSkill> ActorSkills
        {
            get
            {
                var skillsStartPointer = Structure.SkillsStartPointer;
                var skillsEndPointer = Structure.SkillsEndPointer;
                skillsStartPointer += 8;//Don't ask me why. Just skipping first one

                int stuckCounter = 0;
                var result = new List<ActorSkill>();
                for (var addr = skillsStartPointer; addr < skillsEndPointer; addr += 16)//16 because we are reading each second pointer (pointer vectors)
                {
                    result.Add(ReadObject<ActorSkill>(addr));
                    if (stuckCounter++ > 50)
                        return new List<ActorSkill>();
                }
                return result;
            }
        }

        public List<ActorVaalSkill> ActorVaalSkills => M.ReadStructsArray<ActorVaalSkill>(Structure.VaalSkillsStartPointer, Structure.VaalSkillsEndPointer, ACTOR_VAAL_SKILLS_SIZE, 100);
		//{
		//	get
		//	{
		//						var skillsStartPointer = Structure.VaalSkillsStartPointer;
		//		var skillsEndPointer = ;

		//		int stuckCounter = 0;
		//		var result = new List<ActorVaalSkill>();
		//		for (var addr = skillsStartPointer; addr < skillsEndPointer; addr += ACTOR_VAAL_SKILLS_SIZE)
		//		{
		//			result.Add(ReadObject<ActorVaalSkill>(addr));
		//			if (stuckCounter++ > 50)
		//				return new List<ActorVaalSkill>();
		//		}
		//		return result;
		//	}
		//}

        [StructLayout(LayoutKind.Explicit)]
        public struct ActionWrapperStruct
        {
            [FieldOffset(0x18)]
            public long SkillPtr;
            [FieldOffset(0x48)]
            public float DestinationX;
            [FieldOffset(0x4C)]
            public float DestinationY;

        }

        public class ActionWrapper : StructuredRemoteMemoryObject<ActionWrapperStruct>
        {
            public float DestinationX => Structure.DestinationX;
            public float DestinationY => Structure.DestinationY;

            public Vector2 CastDestination => new Vector2(DestinationX, DestinationY);

            public ActorSkill Skill => GetObject<ActorSkill>(Structure.SkillPtr);

        }


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
