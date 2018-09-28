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
		//[Obsolete("Obsolete. Use StashTabs instead")]
		public StashElement StashPanel => Address != 0 ? GetObject<StashElement>(M.ReadLong(Address + 0x4C8, 0xA0, 0x78)) : null;

		public PartyStatus PartyStatusType => (PartyStatus)M.ReadByte(Address + 0x4F08);

		public CharacterClass PlayerClass => (CharacterClass)(M.ReadByte(Address + 0x5010) & 0xF);

		public List<ushort> PassiveSkillIds
		{
			get
			{
				var fisrPtr = M.ReadLong(Address + 0x4FA0);
				var endPtr = M.ReadLong(Address + 0x4FA8);
				//var lastPtr = M.ReadLong(Address + 0x4FB0);

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
		#region PlayerData
		public int CharacterLevel => M.ReadInt(Address + 0x5014);
		public int PassiveRefundPointsLeft => M.ReadInt(Address + 0x5018);
		public int QuestPassiveSkillPoints => M.ReadInt(Address + 0x501C);
		public int FreePassiveSkillPointsLeft => M.ReadInt(Address + 0x5020);
		public int TotalAscendencyPoints => M.ReadInt(Address + 0x5024);
		public int SpentAscendencyPoints => M.ReadInt(Address + 0x5028);

		public NetworkStateE NetworkState => (NetworkStateE)M.ReadByte(Address + 0x5050);
		public bool IsInGame => GameController.UseGameStateController ? GameStateController.IsInGameState : NetworkState == NetworkStateE.Connected;

		public string League => NativeStringReader.ReadString(Address + 0x5078);
		public PartyAllocation PartyAllocationType => (PartyAllocation)M.ReadByte(Address + 0x50B5);
		public int Latency => M.ReadInt(Address + 0x50D0);
		#endregion
		#region Stash Tabs
		public List<ServerStashTab> PlayerStashTabs => GetStashTabs(0x50E0, 0x50E8);
		public List<ServerStashTab> GuildStashTabs => GetStashTabs(0x50F8, 0x5100);
		private List<ServerStashTab> GetStashTabs(int offsetBegin, int offsetEnd)
		{
			var firstAddr = M.ReadLong(Address + offsetBegin);
			var lastAddr = M.ReadLong(Address + offsetEnd);

			var tabs = M.ReadStructsArray<ServerStashTab>(firstAddr, lastAddr, ServerStashTab.StructSize, 500);

			//Skipping hidden tabs of premium maps tab (read notes in StashTabController.cs)
			tabs.RemoveAll(x => x.IsHidden);
			return tabs;
		}
		#endregion

		public string Guild => NativeStringReader.ReadString(M.ReadLong(Address + 0x5290));

		public List<ushort> SkillBarIds
		{
			get
			{
				var result = new List<ushort>();

				var readAddr = Address + 0x5298;
				for (int i = 0; i < 8; i++)
				{
					result.Add(M.ReadUShort(readAddr));
					readAddr += 2;
				}
				return result;
			}
		}
		public List<Player> NearestPlayers
		{
			get
			{
				var startPtr = M.ReadLong(Address + 0x52D8);
				var endPtr = M.ReadLong(Address + 0x52E0);
				startPtr += 16;//Don't ask me why. Just skipping first 2

				var result = new List<Player>();
				for (var addr = startPtr; addr < endPtr; addr += 16)//16 because we are reading each second pointer (pointer vectors)
				{
					result.Add(ReadObject<Player>(addr));
				}
				return result;
			}
		}

		#region Inventories
		public List<InventoryHolder> PlayerInventories
		{
			get
			{
				var firstAddr = M.ReadLong(Address + 0x53B8);
				var lastAddr = M.ReadLong(Address + 0x53C0);
				return M.ReadStructsArray<InventoryHolder>(firstAddr, lastAddr, InventoryHolder.StructSize, 400);
			}
		}
		public List<InventoryHolder> NPCInventories
		{
			get
			{
				var firstAddr = M.ReadLong(Address + 0x5468);
				var lastAddr = M.ReadLong(Address + 0x5470);

				if (firstAddr == 0)
					return new List<InventoryHolder>();

				return M.ReadStructsArray<InventoryHolder>(firstAddr, lastAddr, InventoryHolder.StructSize, 100);
			}
		}

		public List<InventoryHolder> GuildInventories
		{
			get
			{
				var firstAddr = M.ReadLong(Address + 0x5518);
				var lastAddr = M.ReadLong(Address + 0x5520);
				return M.ReadStructsArray<InventoryHolder>(firstAddr, lastAddr, InventoryHolder.StructSize, 100);
			}
		}

		#region Utils functions
		public ServerInventory GetPlayerInventoryBySlot(InventorySlotE slot)
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
		public ServerInventory GetPlayerInventoryByType(InventoryTypeE type)
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

		public ServerInventory GetPlayerInventoryBySlotAndType(InventoryTypeE type, InventorySlotE slot)
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

		public ushort TradeChatChannel => M.ReadUShort(Address + 0x5610);
		public ushort GlobalChatChannel => M.ReadUShort(Address + 0x5618);
		public ushort LastActionId => M.ReadUShort(Address + 0x5668);

		#region Completed Areas
		public List<WorldArea> CompletedAreas => GetAreas(0x56E0);
		public List<WorldArea> ShapedMaps => GetAreas(0x5720);
		public List<WorldArea> BonusCompletedAreas => GetAreas(0x5760);
		public List<WorldArea> ElderGuardiansAreas => GetAreas(0x57A0);
		public List<WorldArea> ShaperElderAreas => GetAreas(0x57E0);

		private List<WorldArea> GetAreas(int offset)
		{
			var result = new List<WorldArea>();
			var size = M.ReadInt(Address + offset - 0x8);
			var listStart = M.ReadLong(Address + offset);

			for (var addr = M.ReadLong(listStart); addr != listStart; addr = M.ReadLong(addr))
			{
				result.Add(GameController.Instance.Files.WorldAreas.GetByAddress(M.ReadLong(addr + 0x18)));
				if (--size < 0) break;
			}
			return result;
		}
		#endregion
		#region Monster Info
		public byte MonsterLevel => M.ReadByte(Address + 0x6188);
		public byte MonstersRemaining => M.ReadByte(Address + 0x6189); // 51 = 50+, 255 = N/A (Town, etc.)
		#endregion
		#region Delve Info
		public int CurrentAzuriteAmount => M.ReadInt(Address + 0x61E0);
		public int CurrentSulphiteAmount => M.ReadInt(Address + 0x61F0);
		#endregion
		public enum NetworkStateE : byte
		{
			None,
			Disconnected,
			Connecting,
			Connected
		}

		public enum PartyStatus
		{
			PartyLeader,
			Invited,
			PartyMember,
			None,
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