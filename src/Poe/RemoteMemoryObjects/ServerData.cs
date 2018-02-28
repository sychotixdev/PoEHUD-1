using System;
using System.Collections.Generic;
using PoeHUD.Poe.Elements;
using PoeHUD.Poe.RemoteMemoryObjects;
using PoeHUD.Controllers;
using PoeHUD.Poe.FilesInMemory;
using PoeHUD.Models;
using PoeHUD.Poe.Components;

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
            return M.ReadStructsArray<ServerStashTab>(firstAddr, lastAddr, ServerStashTab.StructSize);
        }
        #endregion

        #region Inventories
        public List<InventoryHolder> PlayerInventories
        {
            get
            {
                var firstAddr = M.ReadLong(Address + 0x4728);
                var lastAddr = M.ReadLong(Address + 0x4730);
                return M.ReadStructsArray<InventoryHolder>(firstAddr, lastAddr, InventoryHolder.StructSize);
            }
        }

        public Inventory2 GetPlayerInventoryBySlot(InventorySlotE slot)
        {
            foreach (var inventory in PlayerInventories)
            {
                if (inventory.Inventory.InventSlot == slot)
                {
                    return inventory.Inventory;
                }
            }
            return null;
        }
        public Inventory2 GetPlayerInventoryByType(InventoryTypeE type)
        {
            foreach (var inventory in PlayerInventories)
            {
                if (inventory.Inventory.InventType == type)
                {
                    return inventory.Inventory;
                }
            }
            return null;
        }

        public Inventory2 GetPlayerInventoryBySlotAndType(InventoryTypeE type, InventorySlotE slot)
        {
            foreach (var inventory in PlayerInventories)
            {
                if (inventory.Inventory.InventType == type && inventory.Inventory.InventSlot == slot)
                {
                    return inventory.Inventory;
                }
            }
            return null;
        }

        public List<InventoryHolder> NPCInventories
        {
            get
            {
                var firstAddr = M.ReadLong(Address + 0x47d0);
                var lastAddr = M.ReadLong(Address + 0x47d8);
                return M.ReadStructsArray<InventoryHolder>(firstAddr, lastAddr, InventoryHolder.StructSize);
            }
        }

        public List<InventoryHolder> GuildInventories
        {
            get
            {
                var firstAddr = M.ReadLong(Address + 0x4878);
                var lastAddr = M.ReadLong(Address + 0x4880);
                return M.ReadStructsArray<InventoryHolder>(firstAddr, lastAddr, InventoryHolder.StructSize);
            }
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


        public List<Player> NearestPlayers
        {
            get
            {
                var startPtr = M.ReadLong(Address + 0x4658);
                var endPtr = M.ReadLong(Address + 0x4660);
                return M.ReadClassesArray<Player>(startPtr, endPtr, 0x68);
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