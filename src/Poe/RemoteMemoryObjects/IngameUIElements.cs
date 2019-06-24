using PoeHUD.Poe.Elements;
using System.Collections.Generic;
using PoeHUD.Controllers;
using System;
using System.Linq;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
	public class IngameUIElements : RemoteMemoryObject
	{
        public Element FlaskBar => GetObject<Element>(M.ReadLong(Address + 0x278, 0x1B0));
		public SkillBarElement SkillBar => ReadObjectAt<SkillBarElement>(0x388);
		public SkillBarElement HiddenSkillBar => ReadObjectAt<SkillBarElement>(0x390);
		public PoeChatElement ChatBox => GetObject<PoeChatElement>(M.ReadLong(Address + 0x410, 0x2D0, 0xF80));
		public Element QuestTracker => ReadObjectAt<Element>(0x490);
		public Element OpenLeftPanel => ReadObjectAt<Element>(0x4F8/*508*/);
		public Element OpenRightPanel => ReadObjectAt<Element>(0x500/*510 */);
		public InventoryElement InventoryPanel => ReadObjectAt<InventoryElement>(0x530);
		public StashElement StashElement => ReadObjectAt<StashElement>(0x538); //This element was in serverdata
		public Element TreePanel => ReadObjectAt<Element>(0x560);
		public Element AtlasPanel => ReadObjectAt<Element>(0x568);
		public Map Map => ReadObjectAt<Map>(0x5B8);
        public SyndicatePanel SyndicatePanel => GameController.Instance.Game.IngameState.UIRoot.GetChildFromIndices(1, 64).AsObject<SyndicatePanel>();
        public SubterraneanChart MineMap => ReadObjectAt<SubterraneanChart>(0x710/*0xED8*/);
		public WorldMapElement WorldMap => ReadObjectAt<WorldMapElement>(0xCD8);
		public WorldMapElement AreaInstanceUi => ReadObjectAt<WorldMapElement>(0x7C0);
	    public IncursionWindow IncursionWindow => GameController.Instance.Game.IngameState.UIRoot.GetChildFromIndices(1, 58).AsObject<IncursionWindow>();

		public IEnumerable<LabelOnGround> ItemsOnGroundLabels
		{
			get
			{
                // when updating this Offset, copy paste it in file: Poe->Elements->HoverItemIcon.cs
                //            line 63 ( Game.IngameState.IngameUi.ReadObjectAt<ItemsOnGroundLabelElement>(0x5C0); )
                var itemsOnGroundLabelRoot = GetObject<ItemsOnGroundLabelElement>(M.ReadLong(Address + 0x5C0));
				return itemsOnGroundLabelRoot.LabelsOnGround;
			}
		}
		public Element GemLvlUpPanel => ReadObjectAt<Element>(0x8D8);
		public ItemOnGroundTooltip ItemOnGroundTooltip => ReadObjectAt<ItemOnGroundTooltip>(0x958);//or 0x250

		//public bool IsDndEnabled => M.ReadByte(Address + 0xf92) == 1;
		//public string DndMessage => M.ReadStringU(M.ReadLong(Address + 0xf98));



        private const int QUESTS_OFFSET = 0x218;
		public List<Tuple<Quest, int>> GetUncompletedQuests
		{
			get
			{
				var stateListPres = M.ReadDoublePointerIntList(M.ReadLong(Address + QUESTS_OFFSET));
				return stateListPres.Where(x => x.Item2 > 0).Select(x => new Tuple<Quest, int>(GameController.Instance.Files.Quests.GetByAddress(x.Item1), x.Item2)).ToList();
			}
		}

		public List<Tuple<Quest, int>> GetCompletedQuests
		{
			get
			{
				var stateListPres = M.ReadDoublePointerIntList(M.ReadLong(Address + QUESTS_OFFSET));
				return stateListPres.Where(x => x.Item2 == 0).Select(x => new Tuple<Quest, int>(GameController.Instance.Files.Quests.GetByAddress(x.Item1), x.Item2)).ToList();
			}
		}

		public Dictionary<string, KeyValuePair<Quest, QuestState>> GetQuestStates
		{
			get
			{
				Dictionary<string, KeyValuePair<Quest, QuestState>> dictionary = new Dictionary<string, KeyValuePair<Quest, QuestState>>();
				foreach (var quest in GetQuests)
				{
					if (quest == null) continue;
					if (quest.Item1 == null) continue;

					QuestState value = GameController.Instance.Files.QuestStates.GetQuestState(quest.Item1.Id, quest.Item2);

					if (value == null) continue;

					if (!dictionary.ContainsKey(quest.Item1.Id))
						dictionary.Add(quest.Item1.Id, new KeyValuePair<Quest, QuestState>(quest.Item1, value));
				}
				return dictionary.OrderBy(x => x.Key).ToDictionary(Key => Key.Key, Value => Value.Value);
			}
		}


		private List<Tuple<Quest, int>> GetQuests
		{
			get
			{
				var stateListPres = M.ReadDoublePointerIntList(M.ReadLong(Address + QUESTS_OFFSET));
				return stateListPres.Select(x => new Tuple<Quest, int>(GameController.Instance.Files.Quests.GetByAddress(x.Item1), x.Item2)).ToList();
			}
		}
	}
}

