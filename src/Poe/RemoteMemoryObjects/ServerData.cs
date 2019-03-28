using System;
using System.Collections.Generic;
using System.Linq;
using PoeHUD.Poe.Elements;
using PoeHUD.Controllers;
using PoeHUD.Poe.Components;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
	public class ServerData : RemoteMemoryObject
	{
		public BetrayalData BetrayalData => GetObject<BetrayalData>(M.ReadLong(Address + 0x1FC8));

		[Obsolete("Obsolete. Use GameController.Game.IngameState.IngameUi.StashElement instead")]
	    public StashElement StashPanel => GameController.Instance.Game.IngameState.IngameUi.StashElement;// Address != 0 ? GetObject<StashElement>(M.ReadLong(Address + 0x4C8, 0xA0, 0x78)) : null; // needs fixed, but if it's obsolete, just remove it

		public PartyStatus PartyStatusType => (PartyStatus)M.ReadByte(Address + 0x6288);

		public CharacterClass PlayerClass => (CharacterClass)(M.ReadByte(Address + 0x6090) & 0xF);

		public List<ushort> PassiveSkillIds
		{
			get
			{
				var fisrPtr = M.ReadLong(Address + 0x6020);
				var endPtr = M.ReadLong(Address + 0x6028);

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
		public int CharacterLevel => M.ReadInt(Address + 0x6094);
		public int PassiveRefundPointsLeft => M.ReadInt(Address + 0x6098);
		public int QuestPassiveSkillPoints => M.ReadInt(Address + 0x609C);
		public int FreePassiveSkillPointsLeft => M.ReadInt(Address + 0x60A0);
		public int TotalAscendencyPoints => M.ReadInt(Address + 0x60A4);
		public int SpentAscendencyPoints => M.ReadInt(Address + 0x60A8);
		public int TimeInGame => M.ReadInt(Address + 0x6148);

		public NetworkStateE NetworkState => (NetworkStateE)M.ReadByte(Address + 0x60D0);
	    public bool IsInGame => GameStateController.IsInGameState;

		public string League => NativeStringReader.ReadString(Address + 0x60E8);
		public PartyAllocation PartyAllocationType => (PartyAllocation)M.ReadByte(Address + 0x6135);
		public int Latency => M.ReadInt(Address + 0x6150);
		#endregion
		#region Stash Tabs
		public List<ServerStashTab> PlayerStashTabs => GetStashTabs(0x6160, 0x6168);
		public List<ServerStashTab> GuildStashTabs => GetStashTabs(0x6178, 0x6180);
		private List<ServerStashTab> GetStashTabs(int offsetBegin, int offsetEnd)
		{
			var firstAddr = M.ReadLong(Address + offsetBegin);
			var lastAddr = M.ReadLong(Address + offsetEnd);

			var tabs = M.ReadStructsArray<ServerStashTab>(firstAddr, lastAddr, ServerStashTab.StructSize, 5000);//Some players have 300 stash tabs, lol

			//Skipping hidden tabs of premium maps tab (read notes in StashTabController.cs)
			tabs.RemoveAll(x => x.IsHidden);
			return tabs;
		}
		#endregion

		// New Guild is a structure pointed to at 0x6210
		// 0x10 - Length of Guild Name
		// 0x00 - Name (either a pointer if length > 8 else Ustring)
		// public string Guild => NativeStringReader.ReadString(M.ReadLong(Address + 0x5290));//TODO Fixme

		public List<ushort> SkillBarIds
		{
			get
			{
				var result = new List<ushort>();

				var readAddr = Address + 0x6318;
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
				var firstAddr = M.ReadLong(Address + 0x6448);
				var lastAddr = M.ReadLong(Address + 0x6450);
				return M.ReadStructsArray<InventoryHolder>(firstAddr, lastAddr, InventoryHolder.StructSize, 400);
			}
		}
		public List<InventoryHolder> NPCInventories
		{
			get
			{
				var firstAddr = M.ReadLong(Address + 0x6500);
				var lastAddr = M.ReadLong(Address + 0x6508);

				if (firstAddr == 0)
					return new List<InventoryHolder>();

				return M.ReadStructsArray<InventoryHolder>(firstAddr, lastAddr, InventoryHolder.StructSize, 100);
			}
		}

		public List<InventoryHolder> GuildInventories
		{
			get
			{
				var firstAddr = M.ReadLong(Address + 0x65B8); // double check these
				var lastAddr = M.ReadLong(Address + 0x65C0);
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

		public ushort TradeChatChannel => M.ReadUShort(Address + 0x66D0);
		public ushort GlobalChatChannel => M.ReadUShort(Address + 0x66D8);
		public ushort LastActionId => M.ReadUShort(Address + 0x6724);

        #region Completed Areas
        public List<WorldArea> UnknownAreas => GetAreas(0x6760);
        public List<WorldArea> CompletedAreas => GetAreas(0x67A0);
        public List<WorldArea> ShapedMaps => GetAreas(0x67E0);
        public List<WorldArea> BonusCompletedAreas => GetAreas(0x6820);
        public List<WorldArea> ElderGuardiansAreas => GetAreas(0x6860);
        public List<WorldArea> MasterAreas => GetAreas(0x68A0);
        public List<WorldArea> ShaperElderAreas => GetAreas(0x68E0);

        private List<WorldArea> GetAreas(int offset)
		{
			var result = new List<WorldArea>();
			var size = M.ReadInt(Address + offset - 0x8);
	
		    if (size == 0 || size > 300)
		        return result;
		    var listStart = M.ReadLong(Address + offset);

			for (var addr = M.ReadLong(listStart); addr != listStart; addr = M.ReadLong(addr))
			{
		
				var areaAddr = M.ReadLong(addr + 0x18);

			    if (areaAddr != 0)
			    {
			        var area = GameController.Instance.Files.WorldAreas.GetByAddress(areaAddr);
                    if(area != null)
			            result.Add(area);
			    }

			    if (--size < 0) break;
			}
			return result;
		}
		#endregion
		#region Monster Info
		public byte MonsterLevel => M.ReadByte(Address + 0x7284);
		public byte MonstersRemaining => M.ReadByte(Address + 0x7285); // 51 = 50+, 255 = N/A (Town, etc.)
		#endregion
		#region Delve Info
		public int CurrentSulphiteAmount => M.ReadUShort(Address + 0x731C);
		public int CurrentAzuriteAmount => M.ReadInt(Address + 0x7328);
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
