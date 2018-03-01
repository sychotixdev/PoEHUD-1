using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using PoeHUD.Poe.FilesInMemory;
using PoeHUD.Poe.RemoteMemoryObjects;
using PoeHUD.Controllers;
using PoeHUD.Poe.FilesInMemory;

namespace PoeHUD.Poe.Components
{
    public class Player : Component
    {
        public string PlayerName
        {
            get
            {
                if (Address == 0)
                {
                    return "";
                }
                int NameLength = M.ReadInt(Address + 0x30);
                if (NameLength > 512)
                {
                    return "";
                }
                return NameLength < 8 ? M.ReadStringU(Address + 0x20, NameLength * 2) : M.ReadStringU(M.ReadLong(Address + 0x20), NameLength * 2);
            }
        }

        public uint XP => Address != 0 ? M.ReadUInt(Address + 0x48) : 0;
		public int Strength => Address != 0 ? M.ReadInt(Address + 0x4c) : 0;
		public int Dexterity => Address != 0 ? M.ReadInt(Address + 0x50) : 0;
		public int Intelligence => Address != 0 ? M.ReadInt(Address + 0x54) : 0;
        public int Level => Address != 0 ? M.ReadByte(Address + 0x58) : 1;
        public int AllocatedLootId => Address != 0 ? M.ReadByte(Address + 0x44) : 1;


        public int HideoutLevel => M.ReadByte(Address + 0x246);
        public byte PropheciesCount => M.ReadByte(Address + 0x247);

        public HideoutWrapper Hidout => ReadObject<HideoutWrapper>(Address + 0x220);


        public PantheonGod PantheonMinor => (PantheonGod)M.ReadByte(Address + 0x5b);
        public PantheonGod PantheonMajor => (PantheonGod)M.ReadByte(Address + 0x5c);


        public List<PassiveSkill> AllocatedPassives
        {
            get
            {
                var result = new List<PassiveSkill>();
                var passiveIds = GameController.Instance.Game.IngameState.ServerData.PassiveSkillIds;

                foreach(var id in passiveIds)
                {
                    var passive = GameController.Instance.Files.PassiveSkills.GetPassiveSkillByPassiveId(id);
                    if(passive == null)
                    {
                        DebugPlug.DebugPlugin.LogMsg($"Can't find passive with id: {id}", 10, SharpDX.Color.Red);
                        continue;
                    }
                    result.Add(passive);
                }
                return result;
            }
        }


        public bool IsTrialCompleted(string trialId)
        {
            var trialWrapper = GameController.Instance.Files.LabyrinthTrials.GetLabyrinthTrialByAreaId(trialId);
            if(trialWrapper == null)
                throw new ArgumentException($"Trial with id '{trialId}' is not found. Use WorldArea.Id or LabyrinthTrials.LabyrinthTrialAreaIds[]");

            return TrialPassStates.Get(trialWrapper.Id);
        }

        public bool IsTrialCompleted(LabyrinthTrial trialWrapper)
        {
            if (trialWrapper == null)
                throw new ArgumentException($"Argument {nameof(trialWrapper)} should not be null");

            return TrialPassStates.Get(trialWrapper.Id);
        }


        public bool IsTrialCompleted(WorldArea area)
        {
            if (area == null)
                throw new ArgumentException($"Argument {nameof(area)} should not be null");

            var trialWrapper = GameController.Instance.Files.LabyrinthTrials.LabyrinthTrialsList.Find(x => x.Area == area);

            if (trialWrapper == null)
                throw new ArgumentException($"Can't find trial wrapper for area '{area.Name}' (seems not a trial area).");

            return TrialPassStates.Get(trialWrapper.Id);
        }


        private BitArray TrialPassStates
        {
            get
            {
                byte[] buffer = new byte[0x30];
                var stateBuff = M.ReadBytes(Address + 0x154, 0x34);
                for (int i = 0; i < buffer.Length; i++)
                {
                    buffer[i] = stateBuff[i];
                }
                return new BitArray(buffer);
            }
        }

        public List<TrialState> TrialStates
        {
            get
            {
                var result = new List<TrialState>();
                var passStates = TrialPassStates;
                foreach (var trialAreaId in LabyrinthTrials.LabyrinthTrialAreaIds)
                {
                    var wrapper = GameController.Instance.Files.LabyrinthTrials.GetLabyrinthTrialByAreaId(trialAreaId);
                    result.Add(new TrialState() { TrialAreaId = trialAreaId, TrialArea = wrapper, IsCompleted = passStates.Get(wrapper.Id - 1) });
                }
                return result;
            }
        }


        public class TrialState
        {
            public LabyrinthTrial TrialArea { get; internal set; }
            public string TrialAreaId { get; internal set; }
            public bool IsCompleted { get; internal set; }
            public string AreaAddr => TrialArea.Address.ToString("x");

            public override string ToString()
            {
                return $"Completed: {IsCompleted}, Trial {TrialArea.Area.Name}, AreaId: {TrialArea.Id}";//, TrialAreaId: {TrialAreaId}
            }
        }


        public enum PantheonGod
        {
            None,
            TheBrineKing,
            Arakaali,
            Solaris,
            Lunaris,
            MinorGod1,
            MinorGod2,
            Abberath,
            MinorGod4,
            Gruthkul,
            Yugul,
            Shakari,
            Tukohama,
            MinorGod9,
            Ralakesh,
            Garukhan,
            Ryslatha
        }
    }
}
