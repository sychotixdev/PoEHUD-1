using System.Linq;
using PoeHUD.Controllers;
using PoeHUD.EntitiesCache.CachedEntities.Base;
using PoeHUD.EntitiesCache.CachedEntities.Interfaces;
using PoeHUD.Models.Attributes;
using PoeHUD.Models.Enums;
using PoeHUD.Poe.Components;

namespace PoeHUD.EntitiesCache.CachedEntities
{
    public sealed class MonsterEntity : BaseAliveEntity, IMonsterEntityCachedData
    {
        private string _name;

        internal MonsterEntity(NewWorldEntityParams entityParams) : base(entityParams)
        {
            Rarity = IsAlly ? MonsterRarity.Ally : GetComponent<ObjectMagicProperties>().Rarity;
            IsLegion = Metadata.Contains("LegionLeague");
        }

        public MonsterRarity Rarity { get; }
        //internal bool IsValid => true;// Address != 0 && Memory.Instance.ReadInt(Address, 0x18, 0) == 0x65004D;//sometimes it gives a false when entity appear or.. randomly
        [LegionLeague]
        public bool IsLegion { get; }
        public string Name => _name ?? (_name = GetMonsterName());
        public bool CannotDieAura => HasBuff("monster_aura_cannot_die");
        public bool BestiaryMonsterCaptured => HasBuff("capture_monster_trapped");
        public bool IsHidden => HasStat((GameStat) GameController.Instance.Files.Stats.records["is_hidden_monster"].ID, out var stat) && stat == 1;
        public bool CannotBeDamagedStat =>
            HasStat((GameStat) GameController.Instance.Files.Stats.records["cannot_be_damaged"].ID, out var stat) && stat == 1;
        public bool Invincible => CannotDieAura || CannotBeDamagedStat;
        public bool IsMapBoss => GetComponent<ObjectMagicProperties>().Mods.Any(a => a == "MonsterMapBoss");
        public bool IsFrozenInTime => HasBuff("frozen_in_time");
        public bool IsStrongboxMinion => HasBuff("summoned_monster_epk_buff");
        public bool IsHarbingerMinion => HasBuff("harbinger_minion_new");
        public bool IsTargetable => GetComponent<Targetable>().isTargetable;
        public bool IsActive => IsHostile && IsAlive && IsTargetable && !IsHidden;
        public bool IsEmerging => IsHidden && (Metadata.Contains("/RootSpiders/") ||
                                               Metadata.Contains("ZombieMiredGraspEmerge") ||
                                               Metadata.Contains("ReliquaryMonsterEmerge"));

        public override string ToString()
        {
            return $"{base.ToString()}, Name: {Name}";
        }

        private string GetMonsterName()
        {
            var monsterCfg = GameController.Instance.Files.MonsterVarieties.TranslateFromMetadata(Metadata);
            return monsterCfg == null ? string.Empty : monsterCfg.MonsterName;
        }
    }
}
