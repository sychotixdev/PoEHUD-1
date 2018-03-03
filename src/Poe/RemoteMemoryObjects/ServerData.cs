using System;
using System.Collections.Generic;
using PoeHUD.Poe.Elements;
using PoeHUD.Poe.RemoteMemoryObjects;
using PoeHUD.Controllers;
using PoeHUD.Poe.FilesInMemory;
using PoeHUD.Models;
using PoeHUD.Poe.Components;
using PoeHUD.Models.Attributes;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class ServerData : RemoteMemoryObject
    {
        [HideInReflection]
        [Obsolete("Obsolete. Use StashTabs instead")]
        public StashElement StashPanel => Address != 0 ? GetObject<StashElement>(M.ReadLong(Address + 0x3C0, 0xA0, 0x78)) : null;

        public ushort GlobalChatChannel => M.ReadUShort(Address + 0x4d48);
        //public byte MonsterLevel => M.ReadByte(Address + 0x5A2C);

        //if 51 - more than 50 monsters remaining (no exact number)
        //if 255 - not supported for current map (town or scenary map)
        public CharacterClass PlayerClass => (CharacterClass)(M.ReadByte(Address + 0x4788) & 0xF);
        //public byte MonstersRemaining => M.ReadByte(Address + 0x5A2D);

        #region PlayerData
        //public ushort LastActionId => M.ReadUShort(Address + 0x49ac);
        public int CharacterLevel => M.ReadInt(Address + 0x478c);
        public int PassiveRefundPointsLeft => M.ReadInt(Address + 0x4790);
        public int FreePassiveSkillPointsLeft => M.ReadInt(Address + 0x4798);
        public int QuestPassiveSkillPoints => M.ReadInt(Address + 0x4794);
        public int TotalAscendencyPoints => M.ReadInt(Address + 0x479c);
        public int SpentAscendencyPoints => M.ReadInt(Address + 0x47a0);
        public string League => GetObject<NativeStringReader>(Address + 0x47e0).Value;
        public PartyAllocation PartyAllocationType => (PartyAllocation)M.ReadByte(Address + 0x49a0);
        public bool IsInGame => NetworkState == NetworkStateE.Connected;
        public NetworkStateE NetworkState => (NetworkStateE)M.ReadByte(Address + 0x47c8);
        public int Latency => M.ReadInt(Address + 0x4848);
        public List<ushort> SkillBarIds
        {
            get
            {
                var result = new List<ushort>();

                var readAddr = Address + 0x4a10;
                for (int i = 0; i < 8; i++)
                {
                    result.Add(M.ReadUShort(readAddr));
                    readAddr += 2;
                }
                return result;
            }
        }
        public List<ushort> PassiveSkillIds
        {
            get
            {
                var fisrPtr = M.ReadLong(Address + 0x4718);
                var endPtr = M.ReadLong(Address + 0x4720);
                //var lastPtr = M.ReadLong(Address + 0x4728);

                int total_stats = (int)(endPtr - fisrPtr);
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
        #endregion
        public List<Player> NearestPlayers
        {
            get
            {
                var startPtr = M.ReadLong(Address + 0x4a50);
                var endPtr = M.ReadLong(Address + 0x4a58);
                startPtr += 16;//Don't ask me why. Just skipping first 2

                var result = new List<Player>();
                for (var addr = startPtr; addr < endPtr; addr += 16)//16 because we are reading each second pointer (pointer vectors)
                {
                    result.Add(ReadObject<Player>(addr));
                }
                return result;
            }
        }

        #region Stash Tabs
        public List<ServerStashTab> PlayerStashTabs => GetStashTabs(0x4858, 0x4860);
      public List<ServerStashTab> GuildStashTabs => GetStashTabs(0x4870, 0x4878);
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
                var firstAddr = M.ReadLong(Address + 0x4b20);
                var lastAddr = M.ReadLong(Address + 0x4b28);
                return M.ReadStructsArray<InventoryHolder>(firstAddr, lastAddr, InventoryHolder.StructSize);
            }
        }
        public List<InventoryHolder> NPCInventories
        {
            get
            {
                var firstAddr = M.ReadLong(Address + 0x4bc8);
                var lastAddr = M.ReadLong(Address + 0x4bd0);

                if (firstAddr == 0)
                    return new List<InventoryHolder>();

                return M.ReadStructsArray<InventoryHolder>(firstAddr, lastAddr, InventoryHolder.StructSize);
            }
        }

        public List<InventoryHolder> GuildInventories
        {
            get
            {
                var firstAddr = M.ReadLong(Address + 0x4c70);
                var lastAddr = M.ReadLong(Address + 0x4c78);
                return M.ReadStructsArray<InventoryHolder>(firstAddr, lastAddr, InventoryHolder.StructSize);
            }
        }

        #region Utils functions
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

        #endregion
        #endregion
        #region Completed Areas
        public List<WorldArea> CompletedAreas => GetAreas(0x4e08);
        public List<WorldArea> ShapedAreas => GetAreas(0x4e48);
        public List<WorldArea> BonusCompletedAreas => GetAreas(0x4e88);
        public List<WorldArea> Unknown_Areas => GetAreas(0x4ec8);
        public List<WorldArea> ElderAreas => GetAreas(0x4f08);

        private List<WorldArea> GetAreas(int offset)
        {
            var result = new List<WorldArea>();
            var size = M.ReadInt(Address + offset - 0x8);
            var listStart = M.ReadLong(Address + offset);
          
            for (var addr = M.ReadLong(listStart); addr != listStart; addr = M.ReadLong(addr))
            {
                result.Add(GameController.Instance.Files.WorldAreas.GetAreaByAddress(M.ReadLong(addr + 0x18)));
                if (--size < 0) break;
            }
            return result;
        }
        #endregion

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
            None,
            NotInParty = 160
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