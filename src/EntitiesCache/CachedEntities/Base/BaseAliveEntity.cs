using System.Linq;
using PoeHUD.EntitiesCache.CachedEntities.Interfaces;
using PoeHUD.Models.Enums;
using PoeHUD.Poe.Components;

namespace PoeHUD.EntitiesCache.CachedEntities.Base
{
    public class BaseAliveEntity : BaseMovableEntity, IAliveEntityCachedData
    {
        internal BaseAliveEntity(NewWorldEntityParams entityParams) : base(entityParams)
        {
            IsAlly = !PositionedComponent.IsHostile;
        }

        /// <summary>
        /// Entity was destroyed and no longer exist in poe memory and in hud entities cache.
        /// </summary>
        public bool IsDestroyed { get; internal set; }
        public bool IsAlly { get; internal set; }
        public bool IsHostile => !IsAlly;
        public bool IsAlive
        {
            get
            {
                if (IsDeathRegistered | IsDestroyed)
                    return false;

                if (!IsVisible)
                    return true;

                return true;// IsAliveReal;
            }
        }


        public bool HasStat(GameStat statType, out int value)
        {
            return GetComponent<Stats>().GameStatDictionary.TryGetValue(statType, out value);
        }

        public bool HasBuff(string buff) => GetComponent<Life>().Buffs.Any(x => x.Name == buff);

        public override string ToString()
        {
            return $"{base.ToString()}, IsAlive: {IsAlive}";
        }

        #region Internal stuff

        internal bool IsAliveReal => GetComponent<Life>().CurHP > 0;
        internal bool IsDeathRegistered { get; set; }

        #endregion
    }
}
