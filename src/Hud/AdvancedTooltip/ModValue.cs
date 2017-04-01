using PoeHUD.Controllers;
using PoeHUD.Framework;
using PoeHUD.Poe.FilesInMemory;
using PoeHUD.Poe.RemoteMemoryObjects;
using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PoeHUD.Hud.AdvancedTooltip
{
    public class ModValue
    {
        private readonly int totalTiers = 1;

        public ModValue(ItemMod mod, FsController fs, int iLvl, Models.BaseItemType baseItem)
        {
            string baseClassName = baseItem.ClassName.ToLower().Replace(' ', '_');
            Record = fs.Mods.records[mod.RawName];
            AffixType = Record.AffixType;
            AffixText = String.IsNullOrEmpty(Record.UserFriendlyName) ? Record.Key : Record.UserFriendlyName;
            IsCrafted = Record.Domain == ModsDat.ModDomain.Master;
            StatValue = new[] { mod.Value1, mod.Value2, mod.Value3, mod.Value4 };
            Tier = -1;

            int subOptimalTierDistance = 0;

            List<ModsDat.ModRecord> allTiers;
            if (fs.Mods.recordsByTier.TryGetValue(Tuple.Create(Record.Group, Record.AffixType), out allTiers))
            {
                bool tierFound = false;
                totalTiers = 0;
                var keyRcd = Record.Key.Where(c => char.IsLetter(c)).ToArray<char>();
                foreach (var tmp in allTiers)
                {
                    var keyrcd = tmp.Key.Where(k => char.IsLetter(k)).ToArray<char>();
                    if (!keyrcd.SequenceEqual(keyRcd))
                        continue;

                    int baseChance;
                    if (!tmp.TagChances.TryGetValue(baseClassName, out baseChance))
                        baseChance = -1;

                    int defaultChance;
                    if (!tmp.TagChances.TryGetValue("default", out defaultChance))
                        defaultChance = 0;

                    int tagChance = -1;
                    foreach (var tg in baseItem.Tags)
                    {
                        if (tmp.TagChances.ContainsKey(tg))
                            tagChance = tmp.TagChances[tg];
                    }

                    int moreTagChance = -1;
                    foreach ( var tg in baseItem.MoreTagsFromPath)
                    {
                        if (tmp.TagChances.ContainsKey(tg))
                            moreTagChance = tmp.TagChances[tg];
                    }

                    #region GetOnlyValidMods
                        switch (baseChance)
                        {
                            case 0:
                                break;
                            case -1: //baseClass name not found in mod tags.
                                switch (tagChance)
                                {
                                    case 0:
                                        break;
                                    case -1: //item tags not found in mod tags.
                                        switch (moreTagChance)
                                        {
                                            case 0:
                                                break;
                                            case -1://more item tags not found in mod tags.
                                                if (defaultChance > 0)
                                                {
                                                    totalTiers++;
                                                    if (tmp.Equals(Record))
                                                    {
                                                        Tier = totalTiers;
                                                        tierFound = true;
                                                    }
                                                    if (!tierFound && tmp.MinLevel <= iLvl)
                                                    {
                                                        subOptimalTierDistance++;
                                                    }
                                                }
                                                break;
                                            default:
                                                totalTiers++;
                                                if (tmp.Equals(Record))
                                                {
                                                    Tier = totalTiers;
                                                    tierFound = true;
                                                }
                                                if (!tierFound && tmp.MinLevel <= iLvl)
                                                {
                                                    subOptimalTierDistance++;
                                                }
                                                break;
                                        }
                                        break;
                                    default:
                                        totalTiers++;
                                        if (tmp.Equals(Record))
                                        {
                                            Tier = totalTiers;
                                            tierFound = true;
                                        }
                                        if (!tierFound && tmp.MinLevel <= iLvl)
                                        {
                                            subOptimalTierDistance++;
                                        }
                                        break;
                                }
                                break;
                            default:
                                totalTiers++;
                                if(tmp.Equals(Record))
                                {
                                    Tier = totalTiers;
                                    tierFound = true;
                                }
                                if (!tierFound && tmp.MinLevel <= iLvl)
                                {
                                    subOptimalTierDistance++;
                                }
                                break;
                        }
                    #endregion
                }
            }
            double hue = totalTiers == 1 ? 180 : 120 - Math.Min(subOptimalTierDistance, 3) * 40;
            Color = ColorUtils.ColorFromHsv(hue, totalTiers == 1 ? 0 : 1, 1);
        }

        public ModsDat.ModType AffixType { get; private set; }
        public bool IsCrafted { get; private set; }
        public String AffixText { get; private set; }
        public Color Color { get; private set; }
        public ModsDat.ModRecord Record { get; }
        public int[] StatValue { get; private set; }
        public int Tier { get; private set; }

        public bool CouldHaveTiers()
        {
            return totalTiers > 1;
        }
    }
}