using System.Collections.Generic;
using PoeHUD.Poe.FilesInMemory;
using PoeHUD.Poe.RemoteMemoryObjects;
using PoeHUD.Controllers;

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
