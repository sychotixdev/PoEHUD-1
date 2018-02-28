using System;
using System.Collections.Generic;
using PoeHUD.Poe.Elements;
using PoeHUD.Poe.RemoteMemoryObjects;
using PoeHUD.Controllers;
using PoeHUD.Poe.FilesInMemory;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class ServerData : RemoteMemoryObject
    {
        [Obsolete("Obsolete. Use StashTabs instead")]
        public StashElement StashPanel => Address != 0 ? GetObject<StashElement>(M.ReadLong(Address + 0x3C0, 0xA0, 0x78)) : null;

        public ushort GlobalChatChannel => M.ReadUShort(Address + 0x4950);
        public byte MonsterLevel => M.ReadByte(Address + 0x4c2c);

        //if 51 - more than 50 monsters remaining (no exact number)
        //if 255 - not supported for current map (town or scenary map)
        public CharacterClass PlayerClass => (CharacterClass)(M.ReadByte(Address + 0x4388) & 0xF);
        public byte MonstersRemaining => M.ReadByte(Address + 0x4c2d);

        #region PlayerData
        public ushort LastActionId => M.ReadUShort(Address + 0x49ac);
        public int CharacterLevel => M.ReadInt(Address + 0x438c);
        public int PassiveRefundPointsLeft => M.ReadInt(Address + 0x4390);
        public int FreePassiveSkillPointsLeft => M.ReadInt(Address + 0x4398);
        public int QuestPassiveSkillPoints => M.ReadInt(Address + 0x4394);
        public int TotalAscendencyPoints => M.ReadInt(Address + 0x439c);
        public int SpentAscendencyPoints => M.ReadInt(Address + 0x43a0);
        public string League => GetObject<NativeStringReader>(Address + 0x43e0).Value;
        public PartyAllocation PartyAllocationType => (PartyAllocation)M.ReadByte(Address + 0x45a0);

        public List<ushort> SkillBarIds
        {
            get
            {
                var result = new List<ushort>();

                var readAddr = Address + 0x4610;
                for (int i = 0; i < 8; i++)
                {
                    result.Add(M.ReadUShort(readAddr));
                    readAddr += 2;
                }
                return result;
            }
        }
        #endregion

        public bool IsInGame => NetworkState == NetworkStateE.Connected;
        public NetworkStateE NetworkState => (NetworkStateE)M.ReadByte(Address + 0x43c8);
        public int Latency => M.ReadInt(Address + 0x4448);

        #region Stash Tabs
        public List<ServerStashTab> StashTabs => GetStashTabs(0x4458, 0x4460);
        public List<ServerStashTab> GuildStashTabs => GetStashTabs(0x4470, 0x4478);
        private List<ServerStashTab> GetStashTabs(int offsetBegin, int offsetEnd)
        {
            var firstAddr = M.ReadLong(Address + offsetBegin);
            var lastAddr = M.ReadLong(Address + offsetEnd);
            var pointersRange = firstAddr - lastAddr;
            var pointersToRead = pointersRange / ServerStashTab.StructSize;

            if (pointersToRead > 500)
                throw new System.InvalidOperationException($"Can't read server stash tabs: amount is bigger than 500 ({pointersToRead})");

            var result = new List<ServerStashTab>();

            for (var address = firstAddr; address < lastAddr; address += ServerStashTab.StructSize)
            {
                result.Add(GetObject<ServerStashTab>(address));
            }
            return result;
        }
        #endregion

        public List<WorldArea> GetCompletedAreas() => GetAreas(0x4a10);
        public List<WorldArea> GetShapedAreas() => GetAreas(0x4a50);
        public List<WorldArea> GetBonusCompletedAreas() => GetAreas(0x4a90);
        //public List<WorldArea> Unknown() => GetAreas(0x4ad0);
        public List<WorldArea> GetElderAreas() => GetAreas(0x4b10);
        private List<WorldArea> GetAreas(int offset)
        {
            var result = new List<WorldArea>();
            var listStart = M.ReadLong(Address + offset);
            //var size = M.ReadInt(Address + 0x8);

            for (var addr = M.ReadLong(listStart); addr != listStart; addr = M.ReadLong(addr))
            {
                result.Add(GameController.Instance.Files.WorldAreas.GetAreaByAddress(M.ReadLong(addr + 0x18)));
            }
            return result;
        }



        public List<ushort> PassiveSkillIds
        {
            get
            {
                var fisrPtr = M.ReadLong(Address + 0x4318);
                var endPtr = M.ReadLong(Address + 0x4320);
                var lastPtr = M.ReadLong(Address + 0x4320);

                int total_stats = (int)(lastPtr - fisrPtr);
                var bytes = M.ReadBytes(fisrPtr, total_stats);
                var result = new List<ushort>();

                for (int i = 0; i < bytes.Length; i += 2)
                {
                    var id = BitConverter.ToUInt16(bytes, i);
                    result.Add(id);
                }
                return result;
            }
        }

        public enum NetworkStateE : byte
        {
            None,
            Disconnected,
            Connecting,
            Connected
        }

        public enum PartyAllocation : byte
        {
            FreeForAll,
            ShortAllocation,
            PermanentAllocation,
            None
        }

        public enum CharacterClass
        {
            Scion,
            Marauder,
            Ranger,
            Witch,
            Duelist,
            Templar,
            Shadow,
            None
        }
    }
}