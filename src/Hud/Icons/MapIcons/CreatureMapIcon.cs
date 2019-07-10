using System;
using PoeHUD.EntitiesCache.CachedEntities;
using PoeHUD.Models.Enums;
using PoeHUD.Plugins;
using PoeHUD.Poe.Components;

namespace PoeHUD.Hud.Icons.MapIcons
{
    public class CreatureMapIcon : MapIcon
    {
        private readonly MonsterEntity _cachedMonster;
        public bool CheckHiddenMonster { get; set; }

        public CreatureMapIcon(MonsterEntity cachedEntity, string hudTexture, Func<bool> show, float iconSize)
            : base(cachedEntity, new HudTexture(hudTexture), show, iconSize)
        {
            _cachedMonster = cachedEntity;
        }

        public override bool IsVisible()
        {
            if (!base.IsVisible()) //all non alive entities is already removed by PoiTracker plugin
                return false;

            if (_cachedMonster.IsVisible)
            {
                //if (_cachedMonster.IsLegion)
                //{
                //    var rarity = CachedEntity.GetComponent<ObjectMagicProperties>().Rarity;

                //    if (rarity < MonsterRarity.Rare && (_cachedMonster.IsFrozenInTime || !_cachedMonster.IsActive))
                //        return false;

                //    if (rarity == MonsterRarity.Rare && !_cachedMonster.IsFrozenInTime && !_cachedMonster.IsActive)
                //        return false;

                //    if (Math.Abs(Math.Round(CachedEntity.GetComponent<Life>().HPPercentage, 2) - 0.01) < float.Epsilon)
                //        return false;
                //}

                if (CheckHiddenMonster)
                {
                    if (!_cachedMonster.HasBuff("hidden_monster") && _cachedMonster.IsVisible)
                    {
                        CheckHiddenMonster = false;
                        TextureIcon = new HudTexture(TextureIcon.FileName.Replace("-gray", string.Empty));
                        BasePlugin.LogWarning("Entity appear!", 4);
                    }
                }
            }

            return true;
        }
    }
}
