using System.Collections.Generic;
using System.Linq;
using PoeHUD.EntitiesCache.CachedEntities;
using PoeHUD.Models.Enums;
using PoeHUD.Poe.Components;
using SharpDX;

namespace PoeHUD.Hud.Loot
{
    public class ItemUsefulProperties
    {
        private readonly CraftingBase _craftingBase;
        private readonly ItemEntity _item;
        private readonly string _name;
        private string alertText;
        private Color color;
        private int quality, borderWidth, alertIcon = -1;
        private ItemRarity rarity;

        public ItemUsefulProperties(string name, ItemEntity item, CraftingBase craftingBase)
        {
            _name = name;
            _item = item;
            _craftingBase = craftingBase;
        }

        public AlertDrawStyle GetDrawStyle()
        {
            return new AlertDrawStyle(new Color().Equals(color) ? (object) rarity : color, borderWidth, alertText, alertIcon);
        }

        public bool ShouldAlert(HashSet<string> currencyNames, ItemAlertSettings settings)
        {
            var mods = _item.GetComponent<Mods>();
            var qualitySettings = settings.QualityItems;

            rarity = mods?.ItemRarity ?? ItemRarity.Normal;
            quality = _item.GetComponent<Quality>()?.ItemQuality ?? 0; 

            alertText = string.Concat(quality > 0 ? "Superior " : string.Empty, _name);

            if (settings.Maps && (_item.HasComponent<Map>() || _item.Metadata.Contains("VaalFragment")))
            {
                borderWidth = 1;
                return true;
            }

            if (settings.Currency && _item.Metadata.Contains("Currency"))
            {
                color = HudSkin.CurrencyColor;
                return currencyNames?.Contains(_name) ?? !_name.Contains("Wisdom") && !_name.Contains("Portal");
            }

            if (settings.DivinationCards && _item.Metadata.Contains("DivinationCards"))
            {
                color = HudSkin.DivinationCardColor;
                return true;
            }

            if (settings.Talisman && _item.Metadata.Contains("Talisman"))
            {
                color = HudSkin.TalismanColor;
                return true;
            }

            var sockets = _item.GetComponent<Sockets>();

            if (sockets != null && sockets.LargestLinkSize >= settings.MinLinks)
            {
                if (sockets.LargestLinkSize == 6)
                    alertIcon = 3;

                return true;
            }

            if (IsCraftingBase(mods?.ItemLevel ?? 0))
            {
                alertIcon = 2;
                return true;
            }

            if (sockets != null && sockets.NumberOfSockets >= settings.MinSockets)
            {
                alertIcon = 0;
                return true;
            }

            if (settings.Rgb && sockets != null && sockets.IsRGB)
            {
                alertIcon = 1;
                return true;
            }

            if (settings.Jewels && _item.Metadata.Contains("Jewels"))
                return true;

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
                    return quality >= qualitySettings.Flask.MinQuality;

                if (qualitySettings.SkillGem.Enable && _item.HasComponent<SkillGem>())
                {
                    color = HudSkin.SkillGemColor;
                    return quality >= qualitySettings.SkillGem.MinQuality;
                }

                if (qualitySettings.Weapon.Enable && _item.HasComponent<Weapon>())
                    return quality >= qualitySettings.Weapon.MinQuality;

                if (qualitySettings.Armour.Enable && _item.HasComponent<Armour>())
                    return quality >= qualitySettings.Armour.MinQuality;
            }

            return false;
        }

        private bool IsCraftingBase(int itemLevel)
        {
            return !string.IsNullOrEmpty(_craftingBase.Name) && itemLevel >= _craftingBase.MinItemLevel && quality >= _craftingBase.MinQuality &&
                   (_craftingBase.Rarities == null || _craftingBase.Rarities.Contains(rarity));
        }
    }
}
