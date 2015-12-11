using System;
using System.Collections.Generic;
using System.Linq;
using SharpDX;
using PoeHUD.Models.Enums;
using PoeHUD.Models.Interfaces;
using PoeHUD.Poe.Components;

namespace PoeHUD.Hud.Loot
{
    public class ItemUsefulProperties
    {
        private readonly string _name;
        private readonly IEntity _item;
        private readonly CraftingBase _craftingBase;
        private ItemRarity rarity;
        private int quality, borderWidth, alertIcon = -1;
        private string alertText;
        private Color color;

        public ItemUsefulProperties(string name, IEntity item, CraftingBase craftingBase)
        {
            _name = name;
            _item = item;
            _craftingBase = craftingBase;
        }

        public AlertDrawStyle GetDrawStyle()
        {
            return new AlertDrawStyle(new Color().Equals(color) ? (object)rarity : color, borderWidth, alertText, alertIcon);
        }

        public bool ShouldAlert(HashSet<string> currencyNames, ItemAlertSettings settings)
        {
            Mods mods = _item.GetComponent<Mods>();
            QualityItemsSettings qualitySettings = settings.QualityItems;

            rarity = mods.ItemRarity;

            if (_item.HasComponent<Quality>())
            {
                quality = _item.GetComponent<Quality>().ItemQuality;
            }

            alertText = string.Concat(quality > 0 ? "Superior " : String.Empty, _name);

            if (settings.Maps && (_item.HasComponent<Map>() || _item.Path.Contains("VaalFragment")))
            {
                borderWidth = 1;
                return true;
            }

            if (settings.Currency && _item.Path.Contains("Currency"))
            {
                color = HudSkin.CurrencyColor;
                return currencyNames?.Contains(_name) ?? !_name.Contains("Wisdom") && !_name.Contains("Portal");
            }

            if (settings.DivinationCards && _item.Path.Contains("DivinationCards"))
            {
                color = HudSkin.DivinationCardColor;
                return true;
            }

            if (settings.Talisman && _item.Path.Contains("Talisman"))
            {
                color = HudSkin.TalismanColor;
                return true;
            }

            Sockets sockets = _item.GetComponent<Sockets>();

            if (sockets.LargestLinkSize >= settings.MinLinks)
            {
                if (sockets.LargestLinkSize == 6)
                {
                    alertIcon = 3;
                }
                return true;
            }

            if (IsCraftingBase(mods.ItemLevel))
            {
                alertIcon = 2;
                return true;
            }

            if (sockets.NumberOfSockets >= settings.MinSockets)
            {
                alertIcon = 0;
                return true;
            }

            if (settings.Rgb && sockets.IsRGB)
            {
                alertIcon = 1;
                return true;
            }

            if (settings.Jewels && _item.Path.Contains("Jewels"))
            {
                return true;
            }

            switch (rarity)
            {
                case ItemRarity.Rare:
                    return settings.Rares;
                case ItemRarity.Unique:
                    return settings.Uniques;
            }

            if (qualitySettings.Enable)
            {
                if (qualitySettings.Flask.Enable && _item.HasComponent<Flask>())
                {
                    return quality >= qualitySettings.Flask.MinQuality;
                }
                if (qualitySettings.SkillGem.Enable && _item.HasComponent<SkillGem>())
                {
                    color = HudSkin.SkillGemColor;
                    return quality >= qualitySettings.SkillGem.MinQuality;
                }
                if (qualitySettings.Weapon.Enable && _item.HasComponent<Weapon>())
                {
                    return quality >= qualitySettings.Weapon.MinQuality;
                }
                if (qualitySettings.Armour.Enable && _item.HasComponent<Armour>())
                {
                    return quality >= qualitySettings.Armour.MinQuality;
                }
            }
            return false;
        }

        private bool IsCraftingBase(int itemLevel)
        {
            return !String.IsNullOrEmpty(_craftingBase.Name) && itemLevel >= _craftingBase.MinItemLevel && quality >= _craftingBase.MinQuality && (_craftingBase.Rarities == null || _craftingBase.Rarities.Contains(rarity));
        }
    }
}