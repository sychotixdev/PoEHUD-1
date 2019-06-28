using System.Collections.Generic;
using System;
using PoeHUD.Models.Enums;
using System.Globalization;
using PoeHUD.Controllers;
using PoeHUD.Poe.Components;
using System.Linq;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class ActorSkill : RemoteMemoryObject
    {
        public ushort Id => M.ReadUShort(Address + 0x10);
        public GrantedEffectsPerLevel EffectsPerLevel => ReadObject<GrantedEffectsPerLevel>(Address + 0x20);

        public bool CanBeUsedWithWeapon => M.ReadByte(Address + 0x46) > 0;
        public bool CanBeUsed => M.ReadByte(Address + 0x47) == 0;
        public int Cost => M.ReadByte(Address + 0x4C);
        //public int Unknown_Old_MaxUses => M.ReadInt(Address + 0x4c);
        public int TotalUses => M.ReadInt(Address + 0x50);
        public float Cooldown => M.ReadInt(Address + 0x58) / 100f; //Converted milliseconds to seconds

        public int SoulsPerUse => M.ReadInt(Address + 0x68);
        public int TotalVaalUses => M.ReadInt(Address + 0x6c);
        public bool IsOnSkillBar => SkillBarSlot != -1;
        public int SkillBarSlot => GameController.Instance.Game.InGameState.ServerData.SkillBarIds.IndexOf(Id);
 
        public byte SkillUseStage => M.ReadByte(Address + 0x8);//Default value is 2, but increasing while skill casting (for repeating skills)
        
        /// <summary>
        /// Use carefully. Returns true while skill is actually casting. Maybe you are looking for a IsUsingPressed
        /// </summary>
        public bool IsUsing => SkillUseStage > 2;
        public byte SkillStage => M.ReadByte(Address + 0xC);

        /// <summary>
        /// Returns true while user pressed down button for casting skill. Returns true even if no mana for casting skill
        /// </summary>
        public bool IsUsingPressed => (SkillStage & 8) > 0;

        private string _name;
        public string Name
        {
            get
            {
                if (!string.IsNullOrEmpty(_name))
                    return _name;

                var id = Id;
                var effects = EffectsPerLevel;
                if (effects != null)
                {
                    var skill = effects.SkillGemWrapper;
                    var name = skill.Name;

                    if (string.IsNullOrEmpty(name))
                    {
                        name = skill.ActiveSkill.InternalName;

                        if (string.IsNullOrEmpty(name))
                            name = Id.ToString(CultureInfo.InvariantCulture);
                    }
                    return _name = name;
                }
                else
                {
                    string name;
                    switch (id)
                    {
                        case 0x266:
                            name = "Interaction";
                            break;

                        case 0x2909:
                            name = "Move";
                            break;

                        default:
                            if (id != 0x37d9)
                                name = InternalName;
                            else
                                name = "WashedUp";
                            break;
                    }
                    return _name = name;
                }
            }
        }

        public int SkillSlotIndex
        {
            get
            {
                List<ushort> skillBarIds = Game.InGameState.ServerData.SkillBarIds;
                var id = Id;
                for (int i = 0; i < 8; i++)
                {
                    if (skillBarIds[i] == id)
                    {
                        return i;
                    }
                }
                return -1;
            }
        }

        internal int SlotIdentifier => ((Id >> 8) & 0xff);
        public int SocketIndex => ((SlotIdentifier >> 2) & 15);
        public bool IsUserSkill => (SlotIdentifier & 0x80) > 0;
        public bool AllowedToCast => CanBeUsedWithWeapon && CanBeUsed;

        public TimeSpan CastTime => TimeSpan.FromMilliseconds((double)((int)Math.Ceiling((double)(1000f / (((float)HundredTimesAttacksPerSecond) / 100f)))));
        public float Dps => GetStat((GameStat)GameController.Instance.Files.Stats.records["hundred_times_damage_per_second"].ID + (IsUsing ? 4 : 0)) / 100f;
        public int HundredTimesAttacksPerSecond => GetStat(IsUsing ? (GameStat)GameController.Instance.Files.Stats.records["hundred_times_casts_per_second"].ID : (GameStat)GameController.Instance.Files.Stats.records["hundred_times_attacks_per_second"].ID);
        public bool IsTotem => GetStat((GameStat)GameController.Instance.Files.Stats.records["is_totem"].ID) == 1 || GetStat((GameStat)GameController.Instance.Files.Stats.records["skill_is_totemified"].ID) == 1;
        public bool IsTrap => GetStat((GameStat)GameController.Instance.Files.Stats.records["is_trap"].ID) == 1 || GetStat((GameStat)GameController.Instance.Files.Stats.records["skill_is_trapped"].ID) == 1;
        public bool IsVaalSkill => (SoulsPerUse >= 1) && (TotalVaalUses >= 1);

        private bool IsMine => GetStat((GameStat)GameController.Instance.Files.Stats.records["is_remote_mine"].ID) == 1 || GetStat((GameStat)GameController.Instance.Files.Stats.records["skill_is_mined"].ID) == 1;
        //TODO
        /*
        public int UsesAvailable
        {
            get
            {

            if (MaxUses == 0)
            {
                if (IsTotem)
                {
                    return GetStat(PlayerStats.SkillDisplayNumberOfTotemsAllowed);
                }
                return 1;
            }
            return -1;

            if (IsMine)
            {
                return (GetStat(PlayerStats.SkillDisplayNumberOfRemoteMinesAllowed) - NumberDeployed);
            }
            return (MaxUses - NumberDeployed);                         
            }
        }
  

        public int NumberDeployed
        {
            get
            {
                return DeployedObjects.Count;
            }
        }
          */

        //Doesn't work after patch or what
        //public List<DeployedObject> DeployedObjects => GameController.Instance.Player.GetComponent<Actor>().DeployedObjects.Where(x => x.ObjectKey == Id).ToList();


        public string InternalName
        {
            get
            {
                var effects = EffectsPerLevel;
                if (effects != null)
                {
                    return effects.SkillGemWrapper.ActiveSkill.InternalName;
                }
                else
                {
                    string name;
                    switch (Id)
                    {
                        case 0x266:
                            return "Interaction";
                            break;

                        case 0x2909:
                            return "Move";
                            break;

                        default:
                            if (Id != 0x37d9)
                                return Id.ToString(CultureInfo.InvariantCulture);
                            else
                                return "WashedUp";
                            break;
                    }
                }
            }
        }

        public Dictionary<GameStat, int> Stats
        {
            get
            {
                var statsPtr = M.ReadLong(Address + 0x78);
                var result = new Dictionary<GameStat, int>();

                ReadStats(result, statsPtr);

                //var additionalStatsPtr = M.ReadLong(Address + 0x60);
                //ReadStats(result, additionalStatsPtr);
                //And one more additional pointer in 0x10 -> 0x78 that I don't want to read
                return result;
            }
        }

        internal void ReadStats(Dictionary<GameStat, int> stats, long address)
        {
            var statPtrStart = M.ReadLong(address + 0x68);
            var statPtrEnd = M.ReadLong(address + 0x70);

            int key = 0;
            int value = 0;
            int total_stats = (int)(statPtrEnd - statPtrStart);

            if (total_stats == 0)
                return;

            var bytes = M.ReadBytes(statPtrStart, total_stats);

            for (int i = 0; i < bytes.Length; i += 8)
            {
                key = BitConverter.ToInt32(bytes, i);
                value = BitConverter.ToInt32(bytes, i + 0x04);
                stats[(GameStat)key] = value;
            }
        }


        public int GetStat(GameStat stat)
        {
            int num;
            if (!Stats.TryGetValue(stat, out num))
            {
                return 0;
            }
            return num;
        }

        public override string ToString()
        {
            return $"IsUsing: {IsUsing}, {Name}, Id: {Id}, InternalName: {InternalName}, CanBeUsed: {CanBeUsed}";
        }
    }
}
