using PoeHUD.Models.Enums;
using PoeHUD.Poe;
using PoeHUD.Poe.Components;
using PoeHUD.Poe.RemoteMemoryObjects;
using System;

namespace PoeHUD.Models
{
    public sealed class ItemStats
    {
        private static StatTranslator translate;
        private readonly Entity item;
        private readonly float[] stats;

        public ItemStats(Entity item)
        {
            this.item = item;
            if (translate == null)
            {
                translate = new StatTranslator();
            }
            stats = new float[Enum.GetValues(typeof(ItemStatEnum)).Length];
            ParseExplicitMods();
        }

        private void ParseExplicitMods()
        {
            foreach (ItemMod current in item.GetComponent<Mods>().ItemMods)
            {
                translate.Translate(this, current);
            }
            AddToMod(ItemStatEnum.ElementalResistance,
                GetStat(ItemStatEnum.LightningResistance) + GetStat(ItemStatEnum.FireResistance) +
                GetStat(ItemStatEnum.ColdResistance));
            AddToMod(ItemStatEnum.TotalResistance, GetStat(ItemStatEnum.ElementalResistance) + GetStat(ItemStatEnum.TotalResistance));
        }

        public void AddToMod(ItemStatEnum stat, float value)
        {
            stats[(int)stat] += value;
        }

        public float GetStat(ItemStatEnum stat)
        {
            return stats[(int)stat];
        }
    }
}