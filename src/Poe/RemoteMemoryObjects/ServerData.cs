using System;
using System.Collections.Generic;
using PoeHUD.Poe.Elements;
using PoeHUD.Controllers;
using PoeHUD.Poe.Components;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
	public class ServerData : RemoteMemoryObject
	{
		//[Obsolete("Obsolete. Use StashTabs instead")]
		public StashElement StashPanel => Address != 0 ? GetObject<StashElement>(M.ReadLong(Address + 0x4C8, 0xA0, 0x78)) : null; //TODO: fix offset

		public PartyStatus PartyStatusType => (PartyStatus)M.ReadByte(Address + 0x6188);

		public CharacterClass PlayerClass => (CharacterClass)(M.ReadByte(Address + 0x5F90) & 0xF);

		public List<ushort> PassiveSkillIds
		{
			get
			{
				var fisrPtr = M.ReadLong(Address + 0x5F20);
				var endPtr = M.ReadLong(Address + 0x5F28);

				int skillIds = (int)(endPtr - fisrPtr);

			    if (Math.Abs(skillIds) > 500)
			        return null;
				var bytes = M.ReadBytes(fisrPtr, skillIds);
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
		public int CharacterLevel => M.ReadInt(Address + 0x5F94);
		public int PassiveRefundPointsLeft => M.ReadInt(Address + 0x5F98);//TODO Fixme
		public int QuestPassiveSkillPoints => M.ReadInt(Address + 0x5F9C);//TODO Fixme
		public int FreePassiveSkillPointsLeft => M.ReadInt(Address + 0x5FA0);//TODO Fixme
		public int TotalAscendencyPoints => M.ReadInt(Address + 0x5FA4);//TODO Fixme
		public int SpentAscendencyPoints => M.ReadInt(Address + 0x5FA8);//TODO Fixme
		public float TimeInGame => M.ReadFloat(Address + 0x6048);

		public NetworkStateE NetworkState => (NetworkStateE)M.ReadByte(Address + 0x5FD0);
		public bool IsInGame => true ? GameStateController.IsInGameState : NetworkState == NetworkStateE.Connected;

		public string League => NativeStringReader.ReadString(Address + 0x5FE8);
		public PartyAllocation PartyAllocationType => (PartyAllocation)M.ReadByte(Address + 0x6035);
		public int Latency => M.ReadInt(Address + 0x6050);
		#endregion
		#region Stash Tabs
		public List<ServerStashTab> PlayerStashTabs => GetStashTabs(0x6060, 0x6068);
		public List<ServerStashTab> GuildStashTabs => GetStashTabs(0x6078, 0x6080);
		private List<ServerStashTab> GetStashTabs(int offsetBegin, int offsetEnd)
		{
			var firstAddr = M.ReadLong(Address + offsetBegin);
			var lastAddr = M.ReadLong(Address + offsetEnd);

			var tabs = M.ReadStructsArray<ServerStashTab>(firstAddr, lastAddr, ServerStashTab.StructSize, 200);

			//Skipping hidden tabs of premium maps tab (read notes in StashTabController.cs)
			tabs.RemoveAll(x => x.IsHidden);
			return tabs;
		}
		#endregion

		public string Guild => NativeStringReader.ReadString(M.ReadLong(Address + 0x5290));//TODO Fixme

		public List<ushort> SkillBarIds
		{
			get
			{
				var result = new List<ushort>();

				var readAddr = Address + 0x5E18;
				for (var i = 0; i < 8; i++)
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
				var startPtr = M.ReadLong(Address + 0x6258);
				var endPtr = M.ReadLong(Address + 0x6260);

			    if (Math.Abs(endPtr - startPtr) / 8 > 50)
			        return null;

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
				var firstAddr = M.ReadLong(Address + 0x6338);
				var lastAddr = M.ReadLong(Address + 0x6340);
				return M.ReadStructsArray<InventoryHolder>(firstAddr, lastAddr, InventoryHolder.StructSize, 400);
			}
		}
		public List<InventoryHolder> NPCInventories
		{
			get
			{
				var firstAddr = M.ReadLong(Address + 0x63E8);
				var lastAddr = M.ReadLong(Address + 0x63F0);

				if (firstAddr == 0)
					return new List<InventoryHolder>();

				return M.ReadStructsArray<InventoryHolder>(firstAddr, lastAddr, InventoryHolder.StructSize, 100);
			}
		}

		public List<InventoryHolder> GuildInventories
		{
			get
			{
				var firstAddr = M.ReadLong(Address + 0x6498);
				var lastAddr = M.ReadLong(Address + 0x64A0);
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

		public ushort TradeChatChannel => M.ReadUShort(Address + 0x6590);
		public ushort GlobalChatChannel => M.ReadUShort(Address + 0x6598);
		public ushort LastActionId => M.ReadUShort(Address + 0x65E4);

		#region Completed Areas
		public List<WorldArea> ElderGuardiansAreas=> GetAreas(0x6630);//TODO Fixme
		public List<WorldArea> CompletedAreas => GetAreas(0x6660);
		public List<WorldArea> ShapedMaps => GetAreas(0x66A0);
		public List<WorldArea> BonusCompletedAreas => GetAreas(0x66E0);
		public List<WorldArea> UnknownAreas => GetAreas(0x6720);//TODO Fixme
		public List<WorldArea> MasterAreas => GetAreas(0x6760);
		public List<WorldArea> ShaperElderAreas => GetAreas(0x67A0);

		private List<WorldArea> GetAreas(int offset)
		{
			var result = new List<WorldArea>();
			var size = M.ReadInt(Address + offset - 0x8);
			var listStart = M.ReadLong(Address + offset);

		    if (size == 0 || size > 300)
		        return result;
		    listStart = M.ReadLong(listStart);
			for (var addr = M.ReadLong(listStart); addr != listStart; addr = M.ReadLong(addr))
			{
				result.Add(GameController.Instance.Files.WorldAreas.GetByAddress(M.ReadLong(addr + 0x18)));
				if (--size < 0) break;
			}
			return result;
		}
		#endregion
		#region Monster Info
		public byte MonsterLevel => M.ReadByte(Address + 0x7144);
		public byte MonstersRemaining => M.ReadByte(Address + 0x7145); // 51 = 50+, 255 = N/A (Town, etc.)
		#endregion
		#region Delve Info
		public int CurrentSulphiteAmount => M.ReadUShort(Address + 0x727C);
		public int CurrentAzuriteAmount => M.ReadInt(Address + 0x7288);
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