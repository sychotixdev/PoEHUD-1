using System.Collections.Generic;

namespace PoeHUD.Poe.FilesInMemory
{
	public class ItemClasses
	{

		public Dictionary<string, Models.ItemClass> contents;
		public ItemClasses()
		{
			contents = new Dictionary<string, Models.ItemClass>()
			{
				{"LifeFlask", new Models.ItemClass("Life Flasks","Flasks")},
				{"ManaFlask", new Models.ItemClass("Mana Flasks","Flasks")},
				{"HybridFlask", new Models.ItemClass("Hybrid Flasks","Flasks")},
				{"Currency", new Models.ItemClass("Currency","Other")},
				{"Amulet", new Models.ItemClass("Amulets","Jewellery")},
				{"Ring", new Models.ItemClass("Rings","Jewellery")},
				{"Claw", new Models.ItemClass("Claws","One Handed Weapon")},
				{"Dagger", new Models.ItemClass("Daggers","One Handed Weapon")},
				{"Wand", new Models.ItemClass("Wands","One Handed Weapon")},
				{"One Hand Sword", new Models.ItemClass("One Hand Swords","One Handed Weapon")},
				{"Thrusting One Hand Sword", new Models.ItemClass("Thrusting One Hand Swords","One Handed Weapon")},
				{"One Hand Axe", new Models.ItemClass("One Hand Axes","One Handed Weapon")},
				{"One Hand Mace", new Models.ItemClass("One Hand Maces","One Handed Weapon")},
				{"Bow", new Models.ItemClass("Bows","Two Handed Weapon")},
				{"Staff", new Models.ItemClass("Staves","Two Handed Weapon")},
				{"Two Hand Sword", new Models.ItemClass("Two Hand Swords","Two Handed Weapon")},
				{"Two Hand Axe", new Models.ItemClass("Two Hand Axes","Two Handed Weapon")},
				{"Two Hand Mace", new Models.ItemClass("Two Hand Maces","Two Handed Weapon")},
				{"Active Skill Gem", new Models.ItemClass("Active Skill Gems","Gems")},
				{"Support Skill Gem", new Models.ItemClass("Support Skill Gems","Gems")},
				{"Quiver", new Models.ItemClass("Quivers","Off-hand")},
				{"Belt", new Models.ItemClass("Belts","Jewellery")},
				{"Gloves", new Models.ItemClass("Gloves","Armor")},
				{"Boots", new Models.ItemClass("Boots","Armor")},
				{"Body Armour", new Models.ItemClass("Body Armours","Armor")},
				{"Helmet", new Models.ItemClass("Helmets","Armor")},
				{"Shield", new Models.ItemClass("Shields","Off-hand")},
				{"SmallRelic", new Models.ItemClass("Small Relics","")},
				{"MediumRelic", new Models.ItemClass("Medium Relics","")},
				{"LargeRelic", new Models.ItemClass("Large Relics","")},
				{"StackableCurrency", new Models.ItemClass("Stackable Currency","")},
				{"QuestItem", new Models.ItemClass("Quest Items","")},
				{"Sceptre", new Models.ItemClass("Sceptres","One Handed Weapon")},
				{"UtilityFlask", new Models.ItemClass("Utility Flasks","Flasks")},
				{"UtilityFlaskCritical", new Models.ItemClass("Critical Utility Flasks","")},
				{"Map", new Models.ItemClass("Maps","Other")},
				{"Unarmed", new Models.ItemClass("","")},
				{"FishingRod", new Models.ItemClass("Fishing Rods","")},
				{"MapFragment", new Models.ItemClass("Map Fragments","Other")},
				{"HideoutDoodad", new Models.ItemClass("Hideout Doodads","")},
				{"Microtransaction", new Models.ItemClass("Microtransactions","")},
				{"Jewel", new Models.ItemClass("Jewel","Other")},
				{"DivinationCard", new Models.ItemClass("Divination Card","Other")},
				{"LabyrinthItem", new Models.ItemClass("Labyrinth Item","")},
				{"LabyrinthTrinket", new Models.ItemClass("Labyrinth Trinket","")},
				{"LabyrinthMapItem", new Models.ItemClass("Labyrinth Map Item","Other")},
				{"MiscMapItem", new Models.ItemClass("Misc Map Items","")},
				{"Leaguestone", new Models.ItemClass("Leaguestones","Other")}
			};
		}
	}
}