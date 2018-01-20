using System.ComponentModel;

namespace PoeHUD.Models.Enums
{
    public enum PlayerStats
    {
        [Description("Level")]
        Level = 1,
        [Description("Item Drop Slots")]
        ItemDropSlots = 2,
        [Description("Main Hand Weapon Type")]
        MainHandWeaponType = 3,
        [Description("Off Hand Weapon Type")]
        OffHandWeaponType = 4,
        [Description("Current Endurance Charges")]
        CurrentEnduranceCharges = 5,
        [Description("Current Frenzy Charges")]
        CurrentFrenzyCharges = 6,
        [Description("Current Power Charges")]
        CurrentPowerCharges = 7,
        [Description("Cannot Have Life Leeched From")]
        CannotHaveLifeLeechedFrom = 8,
        [Description("Cannot Have Mana Leeched From")]
        CannotHaveManaLeechedFrom = 9,
        [Description("Monster Slain Experience +%")]
        MonsterSlainExperiencePosPct = 10,
        [Description("Monster Dropped Item Rarity +%")]
        MonsterDroppedItemRarityPosPct = 11,
        [Description("Monster Dropped Item Quantity +%")]
        MonsterDroppedItemQuantityPosPct = 12,
        [Description("Local Flask Life To Recover")]
        LocalFlaskLifeToRecover = 13,
        [Description("Local Flask Life To Recover +%")]
        LocalFlaskLifeToRecoverPosPct = 14,
        [Description("Local Flask Mana To Recover")]
        LocalFlaskManaToRecover = 15,
        [Description("Local Flask Mana To Recover +%")]
        LocalFlaskManaToRecoverPosPct = 16,
        [Description("Local Flask Recovery Speed +%")]
        LocalFlaskRecoverySpeedPosPct = 17,
        [Description("Local Flask Deciseconds To Recover")]
        LocalFlaskDecisecondsToRecover = 18,
        [Description("Local Extra Max Charges")]
        LocalExtraMaxCharges = 19,
        [Description("Shield Block %")]
        ShieldBlockPct = 20,
        [Description("Blocking Blocks Spells %")]
        BlockingBlocksSpellsPct = 21,
        [Description("Block While Dual Wielding %")]
        BlockWhileDualWieldingPct = 22,
        [Description("Block Recovery +%")]
        BlockRecoveryPosPct = 23,
        [Description("Shield Armour +%")]
        ShieldArmourPosPct = 24,
        [Description("Damage +%")]
        DamagePosPct = 25,
        [Description("Spell Damage +%")]
        SpellDamagePosPct = 26,
        [Description("Physical Damage +%")]
        PhysicalDamagePosPct = 27,
        [Description("Local Physical Damage +%")]
        LocalPhysicalDamagePosPct = 28,
        [Description("Global Minimum Added Physical Damage")]
        GlobalMinimumAddedPhysicalDamage = 29,
        [Description("Global Maximum Added Physical Damage")]
        GlobalMaximumAddedPhysicalDamage = 30,
        [Description("Attack Minimum Added Physical Damage")]
        AttackMinimumAddedPhysicalDamage = 31,
        [Description("Attack Maximum Added Physical Damage")]
        AttackMaximumAddedPhysicalDamage = 32,
        [Description("Local Minimum Added Physical Damage")]
        LocalMinimumAddedPhysicalDamage = 33,
        [Description("Local Maximum Added Physical Damage")]
        LocalMaximumAddedPhysicalDamage = 34,
        [Description("Physical Axe Damage +%")]
        PhysicalAxeDamagePosPct = 35,
        [Description("Physical Staff Damage +%")]
        PhysicalStaffDamagePosPct = 36,
        [Description("Physical Claw Damage +%")]
        PhysicalClawDamagePosPct = 37,
        [Description("Physical Dagger Damage +%")]
        PhysicalDaggerDamagePosPct = 38,
        [Description("Physical Mace Damage +%")]
        PhysicalMaceDamagePosPct = 39,
        [Description("Physical Bow Damage +%")]
        PhysicalBowDamagePosPct = 40,
        [Description("Physical Sword Damage +%")]
        PhysicalSwordDamagePosPct = 41,
        [Description("Physical Wand Damage +%")]
        PhysicalWandDamagePosPct = 42,
        [Description("Fire Damage +%")]
        FireDamagePosPct = 43,
        [Description("Global Minimum Added Fire Damage")]
        GlobalMinimumAddedFireDamage = 44,
        [Description("Global Maximum Added Fire Damage")]
        GlobalMaximumAddedFireDamage = 45,
        [Description("Attack Minimum Added Fire Damage")]
        AttackMinimumAddedFireDamage = 46,
        [Description("Attack Maximum Added Fire Damage")]
        AttackMaximumAddedFireDamage = 47,
        [Description("Local Minimum Added Fire Damage")]
        LocalMinimumAddedFireDamage = 48,
        [Description("Local Maximum Added Fire Damage")]
        LocalMaximumAddedFireDamage = 49,
        [Description("Cold Damage +%")]
        ColdDamagePosPct = 50,
        [Description("Global Minimum Added Cold Damage")]
        GlobalMinimumAddedColdDamage = 51,
        [Description("Global Maximum Added Cold Damage")]
        GlobalMaximumAddedColdDamage = 52,
        [Description("Attack Minimum Added Cold Damage")]
        AttackMinimumAddedColdDamage = 53,
        [Description("Attack Maximum Added Cold Damage")]
        AttackMaximumAddedColdDamage = 54,
        [Description("Local Minimum Added Cold Damage")]
        LocalMinimumAddedColdDamage = 55,
        [Description("Local Maximum Added Cold Damage")]
        LocalMaximumAddedColdDamage = 56,
        [Description("Lightning Damage +%")]
        LightningDamagePosPct = 57,
        [Description("Global Minimum Added Lightning Damage")]
        GlobalMinimumAddedLightningDamage = 58,
        [Description("Global Maximum Added Lightning Damage")]
        GlobalMaximumAddedLightningDamage = 59,
        [Description("Attack Minimum Added Lightning Damage")]
        AttackMinimumAddedLightningDamage = 60,
        [Description("Attack Maximum Added Lightning Damage")]
        AttackMaximumAddedLightningDamage = 61,
        [Description("Local Minimum Added Lightning Damage")]
        LocalMinimumAddedLightningDamage = 62,
        [Description("Local Maximum Added Lightning Damage")]
        LocalMaximumAddedLightningDamage = 63,
        [Description("Chaos Damage +%")]
        ChaosDamagePosPct = 64,
        [Description("Global Minimum Added Chaos Damage")]
        GlobalMinimumAddedChaosDamage = 65,
        [Description("Global Maximum Added Chaos Damage")]
        GlobalMaximumAddedChaosDamage = 66,
        [Description("Attack Minimum Added Chaos Damage")]
        AttackMinimumAddedChaosDamage = 67,
        [Description("Attack Maximum Added Chaos Damage")]
        AttackMaximumAddedChaosDamage = 68,
        [Description("Local Minimum Added Chaos Damage")]
        LocalMinimumAddedChaosDamage = 69,
        [Description("Local Maximum Added Chaos Damage")]
        LocalMaximumAddedChaosDamage = 70,
        [Description("Attack Speed +%")]
        AttackSpeedPosPct = 71,
        [Description("Local Attack Speed +%")]
        LocalAttackSpeedPosPct = 72,
        [Description("Melee Attack Speed +%")]
        MeleeAttackSpeedPosPct = 73,
        [Description("Attack Speed While Dual Wielding +%")]
        AttackSpeedWhileDualWieldingPosPct = 74,
        [Description("Axe Attack Speed +%")]
        AxeAttackSpeedPosPct = 75,
        [Description("Staff Attack Speed +%")]
        StaffAttackSpeedPosPct = 76,
        [Description("Claw Attack Speed +%")]
        ClawAttackSpeedPosPct = 77,
        [Description("Dagger Attack Speed +%")]
        DaggerAttackSpeedPosPct = 78,
        [Description("Mace Attack Speed +%")]
        MaceAttackSpeedPosPct = 79,
        [Description("Bow Attack Speed +%")]
        BowAttackSpeedPosPct = 80,
        [Description("Sword Attack Speed +%")]
        SwordAttackSpeedPosPct = 81,
        [Description("Wand Attack Speed +%")]
        WandAttackSpeedPosPct = 82,
        [Description("Shield Attack Speed +%")]
        ShieldAttackSpeedPosPct = 83,
        [Description("Accuracy Rating")]
        AccuracyRating = 84,
        [Description("Accuracy Rating +%")]
        AccuracyRatingPosPct = 85,
        [Description("Accuracy Rating While Dual Wielding +%")]
        AccuracyRatingWhileDualWieldingPosPct = 86,
        [Description("Axe Accuracy Rating +%")]
        AxeAccuracyRatingPosPct = 87,
        [Description("Staff Accuracy Rating +%")]
        StaffAccuracyRatingPosPct = 88,
        [Description("Claw Accuracy Rating +%")]
        ClawAccuracyRatingPosPct = 89,
        [Description("Dagger Accuracy Rating +%")]
        DaggerAccuracyRatingPosPct = 90,
        [Description("Mace Accuracy Rating +%")]
        MaceAccuracyRatingPosPct = 91,
        [Description("Bow Accuracy Rating +%")]
        BowAccuracyRatingPosPct = 92,
        [Description("Sword Accuracy Rating +%")]
        SwordAccuracyRatingPosPct = 93,
        [Description("Wand Accuracy Rating +%")]
        WandAccuracyRatingPosPct = 94,
        [Description("Poison On Critical Strike With Dagger")]
        PoisonOnCriticalStrikeWithDagger = 95,
        [Description("Base Critical Strike Multiplier +")]
        BaseCriticalStrikeMultiplierPos = 96,
        [Description("Critical Strike Multiplier With Dagger +")]
        CriticalStrikeMultiplierWithDaggerPos = 97,
        [Description("Base Self Critical Strike Multiplier -%")]
        BaseSelfCriticalStrikeMultiplierNegPct = 98,
        [Description("Self Critical Strike Multiplier -% Per Endurance Charge")]
        SelfCriticalStrikeMultiplierNegPctPerEnduranceCharge = 99,
        [Description("Old Do Not Use Local Life Leech From Physical Damage %")]
        OldDoNotUseLocalLifeLeechFromPhysicalDamagePct = 100,
        [Description("Old Do Not Use Local Mana Leech From Physical Damage %")]
        OldDoNotUseLocalManaLeechFromPhysicalDamagePct = 101,
        [Description("Old Do Not Use Life Leech From Physical Damage %")]
        OldDoNotUseLifeLeechFromPhysicalDamagePct = 102,
        [Description("Old Do Not Use Mana Leech From Physical Damage %")]
        OldDoNotUseManaLeechFromPhysicalDamagePct = 103,
        [Description("Old Do Not Use Life Leech From Physical Damage With Claw %")]
        OldDoNotUseLifeLeechFromPhysicalDamageWithClawPct = 104,
        [Description("Base Life Gained On Enemy Death")]
        BaseLifeGainedOnEnemyDeath = 105,
        [Description("Life Leech From Any Damage Permyriad")]
        LifeLeechFromAnyDamagePermyriad = 106,
        [Description("Mana Leech From Any Damage Permyriad")]
        ManaLeechFromAnyDamagePermyriad = 107,
        [Description("Base Mana Gained On Enemy Death")]
        BaseManaGainedOnEnemyDeath = 108,
        [Description("Base Stun Threshold Reduction +%")]
        BaseStunThresholdReductionPosPct = 109,
        [Description("While Using Mace Stun Threshold Reduction +%")]
        WhileUsingMaceStunThresholdReductionPosPct = 110,
        [Description("Global Knockback")]
        GlobalKnockback = 111,
        [Description("Knockback With Bow")]
        KnockbackWithBow = 112,
        [Description("Knockback With Staff")]
        KnockbackWithStaff = 113,
        [Description("Knockback With Wand")]
        KnockbackWithWand = 114,
        [Description("Local Knockback")]
        LocalKnockback = 115,
        [Description("Maximum Physical Damage Reduction %")]
        MaximumPhysicalDamageReductionPct = 116,
        [Description("Base Physical Damage Reduction Rating")]
        BasePhysicalDamageReductionRating = 117,
        [Description("Physical Damage Reduction Rating +%")]
        PhysicalDamageReductionRatingPosPct = 118,
        [Description("Local Physical Damage Reduction Rating +%")]
        LocalPhysicalDamageReductionRatingPosPct = 119,
        [Description("Base Evasion Rating")]
        BaseEvasionRating = 120,
        [Description("Evasion Rating +%")]
        EvasionRatingPosPct = 121,
        [Description("Local Evasion Rating +%")]
        LocalEvasionRatingPosPct = 122,
        [Description("Evasion Rating +% Per Frenzy Charge")]
        EvasionRatingPosPctPerFrenzyCharge = 123,
        [Description("Base Maximum Life")]
        BaseMaximumLife = 124,
        [Description("Maximum Life +%")]
        MaximumLifePosPct = 125,
        [Description("Base Life Regeneration Rate Per Minute")]
        BaseLifeRegenerationRatePerMinute = 126,
        [Description("Life Regeneration Rate Per Minute % Per Endurance Charge")]
        LifeRegenerationRatePerMinutePctPerEnduranceCharge = 127,
        [Description("Base Maximum Mana")]
        BaseMaximumMana = 128,
        [Description("Maximum Mana +%")]
        MaximumManaPosPct = 129,
        [Description("Mana Regeneration Rate Per Minute %")]
        ManaRegenerationRatePerMinutePct = 130,
        [Description("Mana Regeneration Rate +%")]
        ManaRegenerationRatePosPct = 131,
        [Description("Base Mana Regeneration Rate Per Minute")]
        BaseManaRegenerationRatePerMinute = 132,
        [Description("Mana Regeneration Rate Per Minute % Per Power Charge")]
        ManaRegenerationRatePerMinutePctPerPowerCharge = 133,
        [Description("Base Maximum Energy Shield")]
        BaseMaximumEnergyShield = 134,
        [Description("Maximum Energy Shield +%")]
        MaximumEnergyShieldPosPct = 135,
        [Description("Local Energy Shield")]
        LocalEnergyShield = 136,
        [Description("Local Energy Shield +%")]
        LocalEnergyShieldPosPct = 137,
        [Description("Energy Shield Recharge Rate Per Minute %")]
        EnergyShieldRechargeRatePerMinutePct = 138,
        [Description("Energy Shield Recharge Rate +%")]
        EnergyShieldRechargeRatePosPct = 139,
        [Description("Energy Shield Delay -%")]
        EnergyShieldDelayNegPct = 140,
        [Description("Cannot Be Damaged")]
        CannotBeDamaged = 141,
        [Description("Base Resist All Elements %")]
        BaseResistAllElementsPct = 142,
        [Description("Resist All Elements % Per Endurance Charge")]
        ResistAllElementsPctPerEnduranceCharge = 143,
        [Description("Maximum Fire Damage Resistance %")]
        MaximumFireDamageResistancePct = 144,
        [Description("Base Fire Damage Resistance %")]
        BaseFireDamageResistancePct = 145,
        [Description("Maximum Cold Damage Resistance %")]
        MaximumColdDamageResistancePct = 146,
        [Description("Base Cold Damage Resistance %")]
        BaseColdDamageResistancePct = 147,
        [Description("Maximum Lightning Damage Resistance %")]
        MaximumLightningDamageResistancePct = 148,
        [Description("Base Lightning Damage Resistance %")]
        BaseLightningDamageResistancePct = 149,
        [Description("Maximum Chaos Damage Resistance %")]
        MaximumChaosDamageResistancePct = 150,
        [Description("Base Chaos Damage Resistance %")]
        BaseChaosDamageResistancePct = 151,
        [Description("Base Item Found Quantity +%")]
        BaseItemFoundQuantityPosPct = 152,
        [Description("Chest Item Quantity +%")]
        ChestItemQuantityPosPct = 153,
        [Description("Base Item Found Rarity +%")]
        BaseItemFoundRarityPosPct = 154,
        [Description("Chest Item Rarity +%")]
        ChestItemRarityPosPct = 155,
        [Description("Item Found Quality +%")]
        ItemFoundQualityPosPct = 156,
        [Description("Item Found Relevancy +%")]
        ItemFoundRelevancyPosPct = 157,
        [Description("Experience Gain +%")]
        ExperienceGainPosPct = 158,
        [Description("Experience Loss On Death -%")]
        ExperienceLossOnDeathNegPct = 159,
        [Description("Minion Maximum Life +%")]
        MinionMaximumLifePosPct = 160,
        [Description("Base Spectre Maximum Life +%")]
        BaseSpectreMaximumLifePosPct = 161,
        [Description("Base Zombie Maximum Life +%")]
        BaseZombieMaximumLifePosPct = 162,
        [Description("Base Fire Elemental Maximum Life +%")]
        BaseFireElementalMaximumLifePosPct = 163,
        [Description("Base Raven Maximum Life +%")]
        BaseRavenMaximumLifePosPct = 164,
        [Description("Base Number Of Spectres Allowed")]
        BaseNumberOfSpectresAllowed = 165,
        [Description("Base Number Of Zombies Allowed")]
        BaseNumberOfZombiesAllowed = 166,
        [Description("Totem Life +%")]
        TotemLifePosPct = 167,
        [Description("Totem Range +%")]
        TotemRangePosPct = 168,
        [Description("Buff Duration +%")]
        BuffDurationPosPct = 169,
        [Description("Buff Affects Party")]
        BuffAffectsParty = 170,
        [Description("Buff Party Effect Radius +%")]
        BuffPartyEffectRadiusPosPct = 171,
        [Description("Do Not Chain")]
        DoNotChain = 172,
        [Description("Number Of Additional Projectiles In Chain")]
        NumberOfAdditionalProjectilesInChain = 173,
        [Description("Number Of Additional Projectiles")]
        NumberOfAdditionalProjectiles = 174,
        [Description("Base Number Of Additional Arrows")]
        BaseNumberOfAdditionalArrows = 175,
        [Description("Base Projectile Speed +%")]
        BaseProjectileSpeedPosPct = 176,
        [Description("Base Arrow Speed +%")]
        BaseArrowSpeedPosPct = 177,
        [Description("Projectile Homing Magnitude")]
        ProjectileHomingMagnitude = 178,
        [Description("Base Movement Velocity +%")]
        BaseMovementVelocityPosPct = 179,
        [Description("Movement Velocity +% Per Frenzy Charge")]
        MovementVelocityPosPctPerFrenzyCharge = 180,
        [Description("Max Endurance Charges")]
        MaxEnduranceCharges = 181,
        [Description("Max Frenzy Charges")]
        MaxFrenzyCharges = 182,
        [Description("Max Power Charges")]
        MaxPowerCharges = 183,
        [Description("Add Endurance Charge On Critical Strike")]
        AddEnduranceChargeOnCriticalStrike = 184,
        [Description("Add Frenzy Charge On Critical Strike")]
        AddFrenzyChargeOnCriticalStrike = 185,
        [Description("Add Power Charge On Critical Strike")]
        AddPowerChargeOnCriticalStrike = 186,
        [Description("Add Endurance Charge On Skill Hit %")]
        AddEnduranceChargeOnSkillHitPct = 187,
        [Description("Add Frenzy Charge On Skill Hit %")]
        AddFrenzyChargeOnSkillHitPct = 188,
        [Description("Add Power Charge On Skill Hit %")]
        AddPowerChargeOnSkillHitPct = 189,
        [Description("Add Endurance Charge On Enemy Critical Strike")]
        AddEnduranceChargeOnEnemyCriticalStrike = 190,
        [Description("Add Endurance Charge On Status Ailment")]
        AddEnduranceChargeOnStatusAilment = 191,
        [Description("Base Avoid Chill %")]
        BaseAvoidChillPct = 192,
        [Description("Base Avoid Freeze %")]
        BaseAvoidFreezePct = 193,
        [Description("Base Avoid Ignite %")]
        BaseAvoidIgnitePct = 194,
        [Description("Base Avoid Shock %")]
        BaseAvoidShockPct = 195,
        [Description("Avoid Stun %")]
        AvoidStunPct = 196,
        [Description("Always Ignite")]
        AlwaysIgnite = 197,
        [Description("Always Shock")]
        AlwaysShock = 198,
        [Description("Always Stun")]
        AlwaysStun = 199,
        [Description("Always Freeze")]
        AlwaysFreeze = 200,
        [Description("Chill Duration +%")]
        ChillDurationPosPct = 201,
        [Description("Shock Duration +%")]
        ShockDurationPosPct = 202,
        [Description("Freeze Duration +%")]
        FreezeDurationPosPct = 203,
        [Description("Ignite Duration +%")]
        IgniteDurationPosPct = 204,
        [Description("Stun Duration +%")]
        StunDurationPosPct = 205,
        [Description("Base Self Chill Duration -%")]
        BaseSelfChillDurationNegPct = 206,
        [Description("Base Self Shock Duration -%")]
        BaseSelfShockDurationNegPct = 207,
        [Description("Base Self Freeze Duration -%")]
        BaseSelfFreezeDurationNegPct = 208,
        [Description("Base Self Ignite Duration -%")]
        BaseSelfIgniteDurationNegPct = 209,
        [Description("Chance Per Second Of Fire Spreading Between Enemies %")]
        ChancePerSecondOfFireSpreadingBetweenEnemiesPct = 210,
        [Description("Burn Damage +%")]
        BurnDamagePosPct = 211,
        [Description("Active Skill Level +")]
        ActiveSkillLevelPos = 212,
        [Description("Gem Experience Gain +%")]
        GemExperienceGainPosPct = 213,
        [Description("Skill Area Of Effect +%")]
        SkillAreaOfEffectPosPct = 214,
        [Description("Base Mana Cost -%")]
        BaseManaCostNegPct = 215,
        [Description("Skill Repeat Count")]
        SkillRepeatCount = 216,
        [Description("Skill Effect Duration +%")]
        SkillEffectDurationPosPct = 217,
        [Description("Base Cast Speed +%")]
        BaseCastSpeedPosPct = 218,
        [Description("Cast Speed +% Per Power Charge")]
        CastSpeedPosPctPerPowerCharge = 219,
        [Description("Skill Cooldown -%")]
        SkillCooldownNegPct = 220,
        [Description("Avoid Interruption While Casting %")]
        AvoidInterruptionWhileCastingPct = 221,
        [Description("Base Attack Repeat Count")]
        BaseAttackRepeatCount = 222,
        [Description("Base Stun Recovery +%")]
        BaseStunRecoveryPosPct = 223,
        [Description("Stun Recovery +% Per Frenzy Charge")]
        StunRecoveryPosPctPerFrenzyCharge = 224,
        [Description("While Using Sword Reduce Enemy Block %")]
        WhileUsingSwordReduceEnemyBlockPct = 225,
        [Description("Prevent Monster Heal")]
        PreventMonsterHeal = 226,
        [Description("Prevent Monster Heal Duration +%")]
        PreventMonsterHealDurationPosPct = 227,
        [Description("Chest Trap Defuse %")]
        ChestTrapDefusePct = 228,
        [Description("Enemies Chill As Unfrozen")]
        EnemiesChillAsUnfrozen = 229,
        [Description("Shocks Enemies That Hit Actor While Actor Is Casting")]
        ShocksEnemiesThatHitActorWhileActorIsCasting = 230,
        [Description("Local Is Max Quality")]
        LocalIsMaxQuality = 231,
        [Description("Local Disable Gem Experience Gain")]
        LocalDisableGemExperienceGain = 232,
        [Description("Local Gem Experience Gain +%")]
        LocalGemExperienceGainPosPct = 233,
        [Description("Local Extra Socket")]
        LocalExtraSocket = 234,
        [Description("Local Level Requirement -")]
        LocalLevelRequirementNeg = 235,
        [Description("Local Attribute Requirements +%")]
        LocalAttributeRequirementsPosPct = 236,
        [Description("Local All Sockets Are White")]
        LocalAllSocketsAreWhite = 237,
        [Description("Local Quantity Of Sockets +%")]
        LocalQuantityOfSocketsPosPct = 238,
        [Description("Local Connectivity Of Sockets +%")]
        LocalConnectivityOfSocketsPosPct = 239,
        [Description("Local Gem Level +")]
        LocalGemLevelPos = 240,
        [Description("Block %")]
        BlockPct = 241,
        [Description("Physical Damage Reduction Rating")]
        PhysicalDamageReductionRating = 242,
        [Description("Spell Block %")]
        SpellBlockPct = 243,
        [Description("Movement Velocity +%")]
        MovementVelocityPosPct = 244,
        [Description("Is Dual Wielding")]
        IsDualWielding = 245,
        [Description("Maximum Life")]
        MaximumLife = 246,
        [Description("Maximum Mana")]
        MaximumMana = 247,
        [Description("Maximum Energy Shield")]
        MaximumEnergyShield = 248,
        [Description("Life Regeneration Rate Per Minute")]
        LifeRegenerationRatePerMinute = 249,
        [Description("Mana Regeneration Rate Per Minute")]
        ManaRegenerationRatePerMinute = 250,
        [Description("Energy Shield Recharge Rate Per Minute")]
        EnergyShieldRechargeRatePerMinute = 251,
        [Description("Spell Minimum Cold Damage")]
        SpellMinimumColdDamage = 252,
        [Description("Spell Maximum Cold Damage")]
        SpellMaximumColdDamage = 253,
        [Description("Spell Minimum Fire Damage")]
        SpellMinimumFireDamage = 254,
        [Description("Spell Maximum Fire Damage")]
        SpellMaximumFireDamage = 255,
        [Description("Spell Minimum Lightning Damage")]
        SpellMinimumLightningDamage = 256,
        [Description("Spell Minimum Chaos Damage")]
        SpellMinimumChaosDamage = 257,
        [Description("Spell Maximum Lightning Damage")]
        SpellMaximumLightningDamage = 258,
        [Description("Spell Maximum Chaos Damage")]
        SpellMaximumChaosDamage = 259,
        [Description("Spell Minimum Physical Damage")]
        SpellMinimumPhysicalDamage = 260,
        [Description("Spell Maximum Physical Damage")]
        SpellMaximumPhysicalDamage = 261,
        [Description("Main Hand Minimum Cold Damage")]
        MainHandMinimumColdDamage = 262,
        [Description("Main Hand Maximum Cold Damage")]
        MainHandMaximumColdDamage = 263,
        [Description("Off Hand Minimum Cold Damage")]
        OffHandMinimumColdDamage = 264,
        [Description("Off Hand Maximum Cold Damage")]
        OffHandMaximumColdDamage = 265,
        [Description("Main Hand Minimum Fire Damage")]
        MainHandMinimumFireDamage = 266,
        [Description("Main Hand Maximum Fire Damage")]
        MainHandMaximumFireDamage = 267,
        [Description("Off Hand Minimum Fire Damage")]
        OffHandMinimumFireDamage = 268,
        [Description("Off Hand Maximum Fire Damage")]
        OffHandMaximumFireDamage = 269,
        [Description("Main Hand Minimum Lightning Damage")]
        MainHandMinimumLightningDamage = 270,
        [Description("Main Hand Maximum Lightning Damage")]
        MainHandMaximumLightningDamage = 271,
        [Description("Off Hand Minimum Lightning Damage")]
        OffHandMinimumLightningDamage = 272,
        [Description("Off Hand Maximum Lightning Damage")]
        OffHandMaximumLightningDamage = 273,
        [Description("Main Hand Minimum Chaos Damage")]
        MainHandMinimumChaosDamage = 274,
        [Description("Main Hand Maximum Chaos Damage")]
        MainHandMaximumChaosDamage = 275,
        [Description("Off Hand Minimum Chaos Damage")]
        OffHandMinimumChaosDamage = 276,
        [Description("Off Hand Maximum Chaos Damage")]
        OffHandMaximumChaosDamage = 277,
        [Description("Main Hand Minimum Physical Damage")]
        MainHandMinimumPhysicalDamage = 278,
        [Description("Main Hand Maximum Physical Damage")]
        MainHandMaximumPhysicalDamage = 279,
        [Description("Off Hand Minimum Physical Damage")]
        OffHandMinimumPhysicalDamage = 280,
        [Description("Off Hand Maximum Physical Damage")]
        OffHandMaximumPhysicalDamage = 281,
        [Description("Stun Recovery +%")]
        StunRecoveryPosPct = 282,
        [Description("Evasion Rating")]
        EvasionRating = 283,
        [Description("Main Hand Reduce Enemy Block %")]
        MainHandReduceEnemyBlockPct = 284,
        [Description("Off Hand Reduce Enemy Block %")]
        OffHandReduceEnemyBlockPct = 285,
        [Description("Main Hand Critical Strike Multiplier +")]
        MainHandCriticalStrikeMultiplierPos = 286,
        [Description("Off Hand Critical Strike Multiplier +")]
        OffHandCriticalStrikeMultiplierPos = 287,
        [Description("Self Critical Strike Multiplier +%")]
        SelfCriticalStrikeMultiplierPosPct = 288,
        [Description("Main Hand Knockback")]
        MainHandKnockback = 289,
        [Description("Off Hand Knockback")]
        OffHandKnockback = 290,
        [Description("Main Hand Accuracy Rating")]
        MainHandAccuracyRating = 291,
        [Description("Off Hand Accuracy Rating")]
        OffHandAccuracyRating = 292,
        [Description("Main Hand Attack Speed +%")]
        MainHandAttackSpeedPosPct = 293,
        [Description("Off Hand Attack Speed +%")]
        OffHandAttackSpeedPosPct = 294,
        [Description("Cast Speed +%")]
        CastSpeedPosPct = 295,
        [Description("Spectre Maximum Life +%")]
        SpectreMaximumLifePosPct = 296,
        [Description("Zombie Maximum Life +%")]
        ZombieMaximumLifePosPct = 297,
        [Description("Fire Elemental Maximum Life +%")]
        FireElementalMaximumLifePosPct = 298,
        [Description("Raven Maximum Life +%")]
        RavenMaximumLifePosPct = 299,
        [Description("Number Of Additional Arrows")]
        NumberOfAdditionalArrows = 300,
        [Description("Arrow Speed +%")]
        ArrowSpeedPosPct = 301,
        [Description("Main Hand Stun Threshold Reduction +%")]
        MainHandStunThresholdReductionPosPct = 302,
        [Description("Off Hand Stun Threshold Reduction +%")]
        OffHandStunThresholdReductionPosPct = 303,
        [Description("Main Hand Life Leech From Physical Attack Damage Permyriad")]
        MainHandLifeLeechFromPhysicalAttackDamagePermyriad = 304,
        [Description("Off Hand Life Leech From Physical Attack Damage Permyriad")]
        OffHandLifeLeechFromPhysicalAttackDamagePermyriad = 305,
        [Description("Main Hand Mana Leech From Physical Attack Damage Permyriad")]
        MainHandManaLeechFromPhysicalAttackDamagePermyriad = 306,
        [Description("Off Hand Mana Leech From Physical Attack Damage Permyriad")]
        OffHandManaLeechFromPhysicalAttackDamagePermyriad = 307,
        [Description("Cold Damage Resistance %")]
        ColdDamageResistancePct = 308,
        [Description("Fire Damage Resistance %")]
        FireDamageResistancePct = 309,
        [Description("Lightning Damage Resistance %")]
        LightningDamageResistancePct = 310,
        [Description("Chaos Damage Resistance %")]
        ChaosDamageResistancePct = 311,
        [Description("Resist All Elements %")]
        ResistAllElementsPct = 312,
        [Description("Trap Duration +%")]
        TrapDurationPosPct = 313,
        [Description("Trap Trigger Radius +%")]
        TrapTriggerRadiusPosPct = 314,
        [Description("Trap Throwing Speed +%")]
        TrapThrowingSpeedPosPct = 315,
        [Description("Monster Response Time Ms")]
        MonsterResponseTimeMs = 316,
        [Description("Skill Internal Monster Responsiveness +%")]
        SkillInternalMonsterResponsivenessPosPct = 317,
        [Description("Endurance Charges Granted Per One Hundred Nearby Enemies During Endurance Warcry")]
        EnduranceChargesGrantedPerOneHundredNearbyEnemiesDuringEnduranceWarcry = 318,
        [Description("Skill Range +%")]
        SkillRangePosPct = 319,
        [Description("Gem Level +")]
        GemLevelPos = 320,
        [Description("Skill Visual Scale +%")]
        SkillVisualScalePosPct = 321,
        [Description("Imp Variation")]
        ImpVariation = 322,
        [Description("Main Hand Base Weapon Attack Duration Ms")]
        MainHandBaseWeaponAttackDurationMs = 323,
        [Description("Off Hand Base Weapon Attack Duration Ms")]
        OffHandBaseWeaponAttackDurationMs = 324,
        [Description("Main Hand Minimum Attack Distance")]
        MainHandMinimumAttackDistance = 325,
        [Description("Off Hand Minimum Attack Distance")]
        OffHandMinimumAttackDistance = 326,
        [Description("Main Hand Base Maximum Attack Distance")]
        MainHandBaseMaximumAttackDistance = 327,
        [Description("Off Hand Base Maximum Attack Distance")]
        OffHandBaseMaximumAttackDistance = 328,
        [Description("Main Hand Quality")]
        MainHandQuality = 329,
        [Description("Off Hand Quality")]
        OffHandQuality = 330,
        [Description("Base Spell Critical Strike Multiplier +")]
        BaseSpellCriticalStrikeMultiplierPos = 331,
        [Description("Spell Critical Strike Multiplier +")]
        SpellCriticalStrikeMultiplierPos = 332,
        [Description("Is Trap")]
        IsTrap = 333,
        [Description("Weapon Elemental Damage +%")]
        WeaponElementalDamagePosPct = 334,
        [Description("Staff Stun Duration +%")]
        StaffStunDurationPosPct = 335,
        [Description("Two Handed Melee Physical Damage +%")]
        TwoHandedMeleePhysicalDamagePosPct = 336,
        [Description("Two Handed Melee Stun Duration +%")]
        TwoHandedMeleeStunDurationPosPct = 337,
        [Description("Two Handed Melee Attack Speed +%")]
        TwoHandedMeleeAttackSpeedPosPct = 338,
        [Description("Two Handed Melee Accuracy Rating +%")]
        TwoHandedMeleeAccuracyRatingPosPct = 339,
        [Description("Physical Damage While Dual Wielding +%")]
        PhysicalDamageWhileDualWieldingPosPct = 340,
        [Description("One Handed Melee Physical Damage +%")]
        OneHandedMeleePhysicalDamagePosPct = 341,
        [Description("One Handed Melee Attack Speed +%")]
        OneHandedMeleeAttackSpeedPosPct = 342,
        [Description("One Handed Melee Accuracy Rating +%")]
        OneHandedMeleeAccuracyRatingPosPct = 343,
        [Description("Base Stun Duration +%")]
        BaseStunDurationPosPct = 344,
        [Description("Bow Stun Duration +%")]
        BowStunDurationPosPct = 345,
        [Description("Base Life Gain Per Target")]
        BaseLifeGainPerTarget = 346,
        [Description("Corpse Explosion Monster Life %")]
        CorpseExplosionMonsterLifePct = 347,
        [Description("Skill Level")]
        SkillLevel = 348,
        [Description("Action Speed -%")]
        ActionSpeedNegPct = 349,
        [Description("Skill Art Variation")]
        SkillArtVariation = 350,
        [Description("Always Crit")]
        AlwaysCrit = 351,
        [Description("Damage Infusion %")]
        DamageInfusionPct = 352,
        [Description("Chaos Damage Taken Per Minute")]
        ChaosDamageTakenPerMinute = 353,
        [Description("Base Fire Damage To Deal Per Minute")]
        BaseFireDamageToDealPerMinute = 354,
        [Description("Add Frenzy Charge On Kill")]
        AddFrenzyChargeOnKill = 355,
        [Description("Base Fire Damage To Deal To Nearby Per Minute")]
        BaseFireDamageToDealToNearbyPerMinute = 356,
        [Description("Base Physical Damage Taken Per Minute")]
        BasePhysicalDamageTakenPerMinute = 357,
        [Description("Spell Minimum Base Lightning Damage Per Power Charge")]
        SpellMinimumBaseLightningDamagePerPowerCharge = 358,
        [Description("Spell Maximum Base Lightning Damage Per Power Charge")]
        SpellMaximumBaseLightningDamagePerPowerCharge = 359,
        [Description("Base Skill Effect Duration")]
        BaseSkillEffectDuration = 360,
        [Description("Skill Effect Duration")]
        SkillEffectDuration = 361,
        [Description("Buff Effect Duration")]
        BuffEffectDuration = 362,
        [Description("Buff Effect Duration +% Per Endurance Charge")]
        BuffEffectDurationPosPctPerEnduranceCharge = 363,
        [Description("Local Base Evasion Rating")]
        LocalBaseEvasionRating = 364,
        [Description("Local Base Physical Damage Reduction Rating")]
        LocalBasePhysicalDamageReductionRating = 365,
        [Description("Base Attack Speed +% Per Frenzy Charge")]
        BaseAttackSpeedPosPctPerFrenzyCharge = 366,
        [Description("Physical Damage +% Per Frenzy Charge")]
        PhysicalDamagePosPctPerFrenzyCharge = 367,
        [Description("Is Player")]
        IsPlayer = 368,
        [Description("Life Per Level")]
        LifePerLevel = 369,
        [Description("Mana Per Level")]
        ManaPerLevel = 370,
        [Description("Backstab Damage +%")]
        BackstabDamagePosPct = 371,
        [Description("Additional Player Bonus Maximum Life +% Final")]
        AdditionalPlayerBonusMaximumLifePosPctFinal = 372,
        [Description("Intermediary Maximum Life")]
        IntermediaryMaximumLife = 373,
        [Description("Local Flask Armour +% While Healing")]
        LocalFlaskArmourPosPctWhileHealing = 374,
        [Description("Local Flask Evasion +% While Healing")]
        LocalFlaskEvasionPosPctWhileHealing = 375,
        [Description("Local Flask Energy Shield +% While Healing")]
        LocalFlaskEnergyShieldPosPctWhileHealing = 376,
        [Description("Local Flask Movement Speed +% While Healing")]
        LocalFlaskMovementSpeedPosPctWhileHealing = 377,
        [Description("Local Flask Stun Recovery +% While Healing")]
        LocalFlaskStunRecoveryPosPctWhileHealing = 378,
        [Description("Local Flask Resistances +% While Healing")]
        LocalFlaskResistancesPosPctWhileHealing = 379,
        [Description("Old Do Not Use Local Flask Life Leech % While Healing")]
        OldDoNotUseLocalFlaskLifeLeechPctWhileHealing = 380,
        [Description("Old Do Not Use Local Flask Mana Leech % While Healing")]
        OldDoNotUseLocalFlaskManaLeechPctWhileHealing = 381,
        [Description("Local Flask Adds Knockback While Healing")]
        LocalFlaskAddsKnockbackWhileHealing = 382,
        [Description("Local Flask Removes % Of Mana Recovery From Life On Use")]
        LocalFlaskRemovesPctOfManaRecoveryFromLifeOnUse = 383,
        [Description("Local Flask Removes % Of Life Recovery From Mana On Use")]
        LocalFlaskRemovesPctOfLifeRecoveryFromManaOnUse = 384,
        [Description("Local Flask Removes % Of Life Recovery From Life On Use")]
        LocalFlaskRemovesPctOfLifeRecoveryFromLifeOnUse = 385,
        [Description("Local Flask Amount To Recover +% When On Low Life")]
        LocalFlaskAmountToRecoverPosPctWhenOnLowLife = 386,
        [Description("Local Flask Recover Instantly When On Low Life")]
        LocalFlaskRecoverInstantlyWhenOnLowLife = 387,
        [Description("Local Flask Recovery Amount % To Recover Instantly")]
        LocalFlaskRecoveryAmountPctToRecoverInstantly = 388,
        [Description("Local Flask Dispels Burning")]
        LocalFlaskDispelsBurning = 389,
        [Description("Local Flask Dispels Freeze And Chill")]
        LocalFlaskDispelsFreezeAndChill = 390,
        [Description("Local Max Charges +%")]
        LocalMaxChargesPosPct = 391,
        [Description("Local Charges Added +%")]
        LocalChargesAddedPosPct = 392,
        [Description("Local Flask Amount To Recover +%")]
        LocalFlaskAmountToRecoverPosPct = 393,
        [Description("Local Flask Recovers Instantly")]
        LocalFlaskRecoversInstantly = 394,
        [Description("Local Flask Minion Heal %")]
        LocalFlaskMinionHealPct = 395,
        [Description("Local Recharge On Crit")]
        LocalRechargeOnCrit = 396,
        [Description("Local Recharge On Take Crit")]
        LocalRechargeOnTakeCrit = 397,
        [Description("Local Critical Strike Multiplier +")]
        LocalCriticalStrikeMultiplierPos = 398,
        [Description("Local Flask Prevents Death While Healing")]
        LocalFlaskPreventsDeathWhileHealing = 399,
        [Description("Cannot Die")]
        CannotDie = 400,
        [Description("Flask Life To Recover +%")]
        FlaskLifeToRecoverPosPct = 401,
        [Description("Flask Mana To Recover +%")]
        FlaskManaToRecoverPosPct = 402,
        [Description("Flask Recovery Speed +%")]
        FlaskRecoverySpeedPosPct = 403,
        [Description("Knockback Distance +%")]
        KnockbackDistancePosPct = 404,
        [Description("Weapon Fire Damage +%")]
        WeaponFireDamagePosPct = 405,
        [Description("Weapon Cold Damage +%")]
        WeaponColdDamagePosPct = 406,
        [Description("Weapon Lightning Damage +%")]
        WeaponLightningDamagePosPct = 407,
        [Description("Weapon Chaos Damage +%")]
        WeaponChaosDamagePosPct = 408,
        [Description("Spell Elemental Damage +%")]
        SpellElementalDamagePosPct = 409,
        [Description("Resist All Elements +% While Holding Shield")]
        ResistAllElementsPosPctWhileHoldingShield = 410,
        [Description("Staff Block %")]
        StaffBlockPct = 411,
        [Description("Attack Minimum Added Lightning Damage With Wand")]
        AttackMinimumAddedLightningDamageWithWand = 412,
        [Description("Attack Maximum Added Lightning Damage With Wand")]
        AttackMaximumAddedLightningDamageWithWand = 413,
        [Description("Attack Minimum Added Fire Damage With Wand")]
        AttackMinimumAddedFireDamageWithWand = 414,
        [Description("Attack Maximum Added Fire Damage With Wand")]
        AttackMaximumAddedFireDamageWithWand = 415,
        [Description("Attack Minimum Added Cold Damage With Wand")]
        AttackMinimumAddedColdDamageWithWand = 416,
        [Description("Attack Maximum Added Cold Damage With Wand")]
        AttackMaximumAddedColdDamageWithWand = 417,
        [Description("Wand Elemental Damage +%")]
        WandElementalDamagePosPct = 418,
        [Description("Chance To Gain Endurance Charge On Block %")]
        ChanceToGainEnduranceChargeOnBlockPct = 419,
        [Description("Endurance Charge Duration +%")]
        EnduranceChargeDurationPosPct = 420,
        [Description("Share Endurance Charges With Party Within Distance")]
        ShareEnduranceChargesWithPartyWithinDistance = 421,
        [Description("Add Frenzy Charge On Enemy Block")]
        AddFrenzyChargeOnEnemyBlock = 422,
        [Description("Base Frenzy Charge Duration +%")]
        BaseFrenzyChargeDurationPosPct = 423,
        [Description("Share Frenzy Charges With Party Within Distance")]
        ShareFrenzyChargesWithPartyWithinDistance = 424,
        [Description("Add Power Charge On Minion Death")]
        AddPowerChargeOnMinionDeath = 425,
        [Description("Skill Area Of Effect +% Per Power Charge")]
        SkillAreaOfEffectPosPctPerPowerCharge = 426,
        [Description("Spell Damage +% Per Power Charge")]
        SpellDamagePosPctPerPowerCharge = 427,
        [Description("Wand Damage +% Per Power Charge")]
        WandDamagePosPctPerPowerCharge = 428,
        [Description("Power Charge Duration +%")]
        PowerChargeDurationPosPct = 429,
        [Description("Share Power Charges With Party Within Distance")]
        SharePowerChargesWithPartyWithinDistance = 430,
        [Description("Minions Explode On Low Life Maximum Life % To Deal")]
        MinionsExplodeOnLowLifeMaximumLifePctToDeal = 431,
        [Description("Totem Duration +%")]
        TotemDurationPosPct = 432,
        [Description("Buff Effect On Self +%")]
        BuffEffectOnSelfPosPct = 433,
        [Description("Add Power Charge When Interrupted While Casting")]
        AddPowerChargeWhenInterruptedWhileCasting = 434,
        [Description("Add Power Charge When Kill Shocked Enemy")]
        AddPowerChargeWhenKillShockedEnemy = 435,
        [Description("Base Skill Area Of Effect +%")]
        BaseSkillAreaOfEffectPosPct = 436,
        [Description("Casting Spell")]
        CastingSpell = 437,
        [Description("Avoid Interruption %")]
        AvoidInterruptionPct = 438,
        [Description("Shocks Enemies That Hit Actor")]
        ShocksEnemiesThatHitActor = 439,
        [Description("Add Power Charge When Interrupted")]
        AddPowerChargeWhenInterrupted = 440,
        [Description("Attack Minimum Base Fire Damage For Elemental Hit")]
        AttackMinimumBaseFireDamageForElementalHit = 441,
        [Description("Attack Maximum Base Fire Damage For Elemental Hit")]
        AttackMaximumBaseFireDamageForElementalHit = 442,
        [Description("Attack Minimum Base Cold Damage For Elemental Hit")]
        AttackMinimumBaseColdDamageForElementalHit = 443,
        [Description("Attack Maximum Base Cold Damage For Elemental Hit")]
        AttackMaximumBaseColdDamageForElementalHit = 444,
        [Description("Attack Minimum Base Lightning Damage For Elemental Hit")]
        AttackMinimumBaseLightningDamageForElementalHit = 445,
        [Description("Attack Maximum Base Lightning Damage For Elemental Hit")]
        AttackMaximumBaseLightningDamageForElementalHit = 446,
        [Description("Additional Physical Damage Reduction %")]
        AdditionalPhysicalDamageReductionPct = 447,
        [Description("Physical Damage Reduction % Per Endurance Charge")]
        PhysicalDamageReductionPctPerEnduranceCharge = 448,
        [Description("Physical Damage % To Add As Fire")]
        PhysicalDamagePctToAddAsFire = 449,
        [Description("Physical Damage % To Add As Cold")]
        PhysicalDamagePctToAddAsCold = 450,
        [Description("Physical Damage % To Add As Lightning")]
        PhysicalDamagePctToAddAsLightning = 451,
        [Description("Physical Damage % To Add As Chaos")]
        PhysicalDamagePctToAddAsChaos = 452,
        [Description("Life Regeneration Rate Per Minute %")]
        LifeRegenerationRatePerMinutePct = 453,
        [Description("Base Chaos Damage % Of Maximum Life Taken Per Minute")]
        BaseChaosDamagePctOfMaximumLifeTakenPerMinute = 454,
        [Description("Base Chaos Damage Taken Per Minute")]
        BaseChaosDamageTakenPerMinute = 455,
        [Description("Add Level X Blood Rage On Kill")]
        AddLevelXBloodRageOnKill = 456,
        [Description("Base Chance To Freeze %")]
        BaseChanceToFreezePct = 457,
        [Description("Display Mana Cost Reduction %")]
        DisplayManaCostReductionPct = 458,
        [Description("Display Minion Monster Level")]
        DisplayMinionMonsterLevel = 459,
        [Description("Display Minion Monster Type")]
        DisplayMinionMonsterType = 460,
        [Description("Monster Slain Flask Charges Granted +%")]
        MonsterSlainFlaskChargesGrantedPosPct = 461,
        [Description("Charges Gained +%")]
        ChargesGainedPosPct = 462,
        [Description("Global Knockback On Crit")]
        GlobalKnockbackOnCrit = 463,
        [Description("Dummy Stat Display Nothing")]
        DummyStatDisplayNothing = 464,
        [Description("Shield Charge Extra Distance")]
        ShieldChargeExtraDistance = 465,
        [Description("Shield Charge End Slide Distance")]
        ShieldChargeEndSlideDistance = 466,
        [Description("Main Hand Knockback On Crit")]
        MainHandKnockbackOnCrit = 467,
        [Description("Off Hand Knockback On Crit")]
        OffHandKnockbackOnCrit = 468,
        [Description("Knockback On Crit With Staff")]
        KnockbackOnCritWithStaff = 469,
        [Description("Knockback On Crit With Bow")]
        KnockbackOnCritWithBow = 470,
        [Description("Knockback On Crit With Wand")]
        KnockbackOnCritWithWand = 471,
        [Description("Shield Charge Stun Duration +% Maximum")]
        ShieldChargeStunDurationPosPctMaximum = 472,
        [Description("Shield Charge Knockback Distance +% Maximum")]
        ShieldChargeKnockbackDistancePosPctMaximum = 473,
        [Description("Shield Charge Damage +% Maximum")]
        ShieldChargeDamagePosPctMaximum = 474,
        [Description("Spell Minimum Base Fire Damage Per Endurance Charge")]
        SpellMinimumBaseFireDamagePerEnduranceCharge = 475,
        [Description("Spell Maximum Base Fire Damage Per Endurance Charge")]
        SpellMaximumBaseFireDamagePerEnduranceCharge = 476,
        [Description("Spell Minimum Base Cold Damage Per Frenzy Charge")]
        SpellMinimumBaseColdDamagePerFrenzyCharge = 477,
        [Description("Spell Maximum Base Cold Damage Per Frenzy Charge")]
        SpellMaximumBaseColdDamagePerFrenzyCharge = 478,
        [Description("Base Damage Taken +%")]
        BaseDamageTakenPosPct = 479,
        [Description("Is Shocked")]
        IsShocked = 480,
        [Description("Base Global Chance To Knockback %")]
        BaseGlobalChanceToKnockbackPct = 481,
        [Description("Main Hand Chance To Knockback %")]
        MainHandChanceToKnockbackPct = 482,
        [Description("Off Hand Chance To Knockback %")]
        OffHandChanceToKnockbackPct = 483,
        [Description("Base Physical Damage % To Convert To Fire")]
        BasePhysicalDamagePctToConvertToFire = 484,
        [Description("Base Physical Damage % To Convert To Cold")]
        BasePhysicalDamagePctToConvertToCold = 485,
        [Description("Base Physical Damage % To Convert To Lightning")]
        BasePhysicalDamagePctToConvertToLightning = 486,
        [Description("Base Physical Damage % To Convert To Chaos")]
        BasePhysicalDamagePctToConvertToChaos = 487,
        [Description("Elemental Damage +%")]
        ElementalDamagePosPct = 488,
        [Description("Mana Regeneration Rate +% Per Power Charge")]
        ManaRegenerationRatePosPctPerPowerCharge = 489,
        [Description("Minion Damage +%")]
        MinionDamagePosPct = 490,
        [Description("Shield Maximum Energy Shield +%")]
        ShieldMaximumEnergyShieldPosPct = 491,
        [Description("Melee Physical Damage +%")]
        MeleePhysicalDamagePosPct = 492,
        [Description("Maximum Block %")]
        MaximumBlockPct = 493,
        [Description("Shield Physical Damage Reduction Rating +%")]
        ShieldPhysicalDamageReductionRatingPosPct = 494,
        [Description("Shield Evasion Rating +%")]
        ShieldEvasionRatingPosPct = 495,
        [Description("Base Shield Evasion Rating")]
        BaseShieldEvasionRating = 496,
        [Description("Base Shield Physical Damage Reduction Rating")]
        BaseShieldPhysicalDamageReductionRating = 497,
        [Description("Base Shield Maximum Energy Shield")]
        BaseShieldMaximumEnergyShield = 498,
        [Description("Ranged Weapon Physical Damage +%")]
        RangedWeaponPhysicalDamagePosPct = 499,
        [Description("Projectile Damage +%")]
        ProjectileDamagePosPct = 500,
        [Description("Base Is Projectile")]
        BaseIsProjectile = 501,
        [Description("Base Cast Speed +% Per Frenzy Charge")]
        BaseCastSpeedPosPctPerFrenzyCharge = 502,
        [Description("Sword Accuracy Rating")]
        SwordAccuracyRating = 503,
        [Description("Bow Accuracy Rating")]
        BowAccuracyRating = 504,
        [Description("Dagger Accuracy Rating")]
        DaggerAccuracyRating = 505,
        [Description("Axe Accuracy Rating")]
        AxeAccuracyRating = 506,
        [Description("Claw Accuracy Rating")]
        ClawAccuracyRating = 507,
        [Description("Staff Accuracy Rating")]
        StaffAccuracyRating = 508,
        [Description("Mace Accuracy Rating")]
        MaceAccuracyRating = 509,
        [Description("Wand Accuracy Rating")]
        WandAccuracyRating = 510,
        [Description("Wall Expand Delay Ms")]
        WallExpandDelayMs = 511,
        [Description("Wall Maximum Length")]
        WallMaximumLength = 512,
        [Description("Main Hand Poison On Critical Strike")]
        MainHandPoisonOnCriticalStrike = 513,
        [Description("Off Hand Poison On Critical Strike")]
        OffHandPoisonOnCriticalStrike = 514,
        [Description("Current Viper Strike Orbs")]
        CurrentViperStrikeOrbs = 515,
        [Description("Max Viper Strike Orbs")]
        MaxViperStrikeOrbs = 516,
        [Description("Monster Chance To Not Flee %")]
        MonsterChanceToNotFleePct = 517,
        [Description("Local Socketed Fire Gem Level +")]
        LocalSocketedFireGemLevelPos = 518,
        [Description("Local Socketed Cold Gem Level +")]
        LocalSocketedColdGemLevelPos = 519,
        [Description("Local Socketed Lightning Gem Level +")]
        LocalSocketedLightningGemLevelPos = 520,
        [Description("Local Socketed Chaos Gem Level +")]
        LocalSocketedChaosGemLevelPos = 521,
        [Description("Local Socketed Projectile Gem Level +")]
        LocalSocketedProjectileGemLevelPos = 522,
        [Description("Local Socketed Spell Gem Level +")]
        LocalSocketedSpellGemLevelPos = 523,
        [Description("Local Socketed Melee Gem Level +")]
        LocalSocketedMeleeGemLevelPos = 524,
        [Description("Local Socketed Bow Gem Level +")]
        LocalSocketedBowGemLevelPos = 525,
        [Description("Local Socketed Minion Gem Level +")]
        LocalSocketedMinionGemLevelPos = 526,
        [Description("Local Socketed Gem Level +")]
        LocalSocketedGemLevelPos = 527,
        [Description("Base Killed Monster Dropped Item Rarity +%")]
        BaseKilledMonsterDroppedItemRarityPosPct = 528,
        [Description("Base Killed Monster Dropped Item Quantity +%")]
        BaseKilledMonsterDroppedItemQuantityPosPct = 529,
        [Description("Current Fuse Arrow Orbs")]
        CurrentFuseArrowOrbs = 530,
        [Description("Max Fuse Arrow Orbs")]
        MaxFuseArrowOrbs = 531,
        [Description("Minimum Fire Damage Per Fuse Arrow Orb")]
        MinimumFireDamagePerFuseArrowOrb = 532,
        [Description("Maximum Fire Damage Per Fuse Arrow Orb")]
        MaximumFireDamagePerFuseArrowOrb = 533,
        [Description("Buff Time Passed -%")]
        BuffTimePassedNegPct = 534,
        [Description("Chance To Be Shocked %")]
        ChanceToBeShockedPct = 535,
        [Description("Chance To Be Chilled %")]
        ChanceToBeChilledPct = 536,
        [Description("Chance To Be Frozen %")]
        ChanceToBeFrozenPct = 537,
        [Description("Chance To Be Ignited %")]
        ChanceToBeIgnitedPct = 538,
        [Description("Life Leech On Any Damage When Hit Permyriad")]
        LifeLeechOnAnyDamageWhenHitPermyriad = 539,
        [Description("Mana Leech On Any Damage When Hit Permyriad")]
        ManaLeechOnAnyDamageWhenHitPermyriad = 540,
        [Description("Chance To Grant Power Charge On Death %")]
        ChanceToGrantPowerChargeOnDeathPct = 541,
        [Description("Physical Damage Dealt Applied To Self %")]
        PhysicalDamageDealtAppliedToSelfPct = 542,
        [Description("Additional Chance To Take Critical Strike %")]
        AdditionalChanceToTakeCriticalStrikePct = 543,
        [Description("Chance To Be Knocked Back %")]
        ChanceToBeKnockedBackPct = 544,
        [Description("Degen Effect +%")]
        DegenEffectPosPct = 545,
        [Description("Chance To Be Stunned %")]
        ChanceToBeStunnedPct = 546,
        [Description("Chance To Grant Endurance Charge On Death %")]
        ChanceToGrantEnduranceChargeOnDeathPct = 547,
        [Description("Physical Damage Taken +%")]
        PhysicalDamageTakenPosPct = 548,
        [Description("Fuse Arrow Explosion Radius + Per Fuse Arrow Orb")]
        FuseArrowExplosionRadiusPosPerFuseArrowOrb = 549,
        [Description("Base Number Of Skeletons Allowed")]
        BaseNumberOfSkeletonsAllowed = 550,
        [Description("Number Of Melee Skeletons To Summon")]
        NumberOfMeleeSkeletonsToSummon = 551,
        [Description("Main Hand Critical Strike Chance")]
        MainHandCriticalStrikeChance = 552,
        [Description("Off Hand Critical Strike Chance")]
        OffHandCriticalStrikeChance = 553,
        [Description("Spell Critical Strike Chance")]
        SpellCriticalStrikeChance = 554,
        [Description("Local Critical Strike Chance")]
        LocalCriticalStrikeChance = 555,
        [Description("Base Spell Critical Strike Chance")]
        BaseSpellCriticalStrikeChance = 556,
        [Description("Critical Strike Chance +%")]
        CriticalStrikeChancePosPct = 557,
        [Description("Critical Strike Chance +% Per Power Charge")]
        CriticalStrikeChancePosPctPerPowerCharge = 558,
        [Description("Spell Critical Strike Chance +%")]
        SpellCriticalStrikeChancePosPct = 559,
        [Description("Local Critical Strike Chance +%")]
        LocalCriticalStrikeChancePosPct = 560,
        [Description("Dagger Critical Strike Chance +%")]
        DaggerCriticalStrikeChancePosPct = 561,
        [Description("Bow Critical Strike Chance +%")]
        BowCriticalStrikeChancePosPct = 562,
        [Description("Claw Critical Strike Chance +%")]
        ClawCriticalStrikeChancePosPct = 563,
        [Description("Base Life Recovery Per Minute")]
        BaseLifeRecoveryPerMinute = 564,
        [Description("Base Mana Recovery Per Minute")]
        BaseManaRecoveryPerMinute = 565,
        [Description("Maximum Life % To Add To Maximum Energy Shield")]
        MaximumLifePctToAddToMaximumEnergyShield = 566,
        [Description("Physical Damage Taken % To Deal To Attacker")]
        PhysicalDamageTakenPctToDealToAttacker = 567,
        [Description("Elemental Damage Taken % To Deal To Attacker")]
        ElementalDamageTakenPctToDealToAttacker = 568,
        [Description("Base Skeleton Maximum Life +%")]
        BaseSkeletonMaximumLifePosPct = 569,
        [Description("Skeleton Maximum Life +%")]
        SkeletonMaximumLifePosPct = 570,
        [Description("Additional Base Critical Strike Chance")]
        AdditionalBaseCriticalStrikeChance = 571,
        [Description("Accuracy Rating Per Level")]
        AccuracyRatingPerLevel = 572,
        [Description("Evasion Rating Per Level")]
        EvasionRatingPerLevel = 573,
        [Description("Local Accuracy Rating")]
        LocalAccuracyRating = 574,
        [Description("Strength")]
        Strength = 575,
        [Description("Base Strength")]
        BaseStrength = 576,
        [Description("Additional Strength")]
        AdditionalStrength = 577,
        [Description("Intelligence")]
        Intelligence = 578,
        [Description("Base Intelligence")]
        BaseIntelligence = 579,
        [Description("Additional Intelligence")]
        AdditionalIntelligence = 580,
        [Description("Dexterity")]
        Dexterity = 581,
        [Description("Base Dexterity")]
        BaseDexterity = 582,
        [Description("Additional Dexterity")]
        AdditionalDexterity = 583,
        [Description("On Low Life")]
        OnLowLife = 584,
        [Description("On Full Life")]
        OnFullLife = 585,
        [Description("Damage +% When On Low Life")]
        DamagePosPctWhenOnLowLife = 586,
        [Description("Damage +% When On Full Life")]
        DamagePosPctWhenOnFullLife = 587,
        [Description("Cast Speed +% When On Low Life")]
        CastSpeedPosPctWhenOnLowLife = 588,
        [Description("Cast Speed +% When On Full Life")]
        CastSpeedPosPctWhenOnFullLife = 589,
        [Description("Attack Speed +% When On Low Life")]
        AttackSpeedPosPctWhenOnLowLife = 590,
        [Description("Attack Speed +% When On Full Life")]
        AttackSpeedPosPctWhenOnFullLife = 591,
        [Description("Kill Enemy On Hit If Under 10% Life")]
        KillEnemyOnHitIfUnder10PctLife = 592,
        [Description("Reduce Enemy Cold Resistance %")]
        ReduceEnemyColdResistancePct = 593,
        [Description("Reduce Enemy Fire Resistance %")]
        ReduceEnemyFireResistancePct = 594,
        [Description("Reduce Enemy Lightning Resistance %")]
        ReduceEnemyLightningResistancePct = 595,
        [Description("Base Reduce Enemy Fire Resistance %")]
        BaseReduceEnemyFireResistancePct = 596,
        [Description("Base Reduce Enemy Cold Resistance %")]
        BaseReduceEnemyColdResistancePct = 597,
        [Description("Base Reduce Enemy Lightning Resistance %")]
        BaseReduceEnemyLightningResistancePct = 598,
        [Description("Reduce Enemy Elemental Resistance %")]
        ReduceEnemyElementalResistancePct = 599,
        [Description("Reduce Enemy Chaos Resistance %")]
        ReduceEnemyChaosResistancePct = 600,
        [Description("Life Leech On Physical Damage When Hit By Attack %")]
        LifeLeechOnPhysicalDamageWhenHitByAttackPct = 601,
        [Description("Mana Leech On Physical Damage When Hit By Attack %")]
        ManaLeechOnPhysicalDamageWhenHitByAttackPct = 602,
        [Description("Add Endurance Charge On Melee Critical Strike")]
        AddEnduranceChargeOnMeleeCriticalStrike = 603,
        [Description("Add Frenzy Charge On Melee Critical Strike")]
        AddFrenzyChargeOnMeleeCriticalStrike = 604,
        [Description("Add Power Charge On Melee Critical Strike")]
        AddPowerChargeOnMeleeCriticalStrike = 605,
        [Description("Life Leech Speed +%")]
        LifeLeechSpeedPosPct = 606,
        [Description("Mana Leech Speed +%")]
        ManaLeechSpeedPosPct = 607,
        [Description("Base Number Of Converted Allowed")]
        BaseNumberOfConvertedAllowed = 608,
        [Description("Additional All Attributes")]
        AdditionalAllAttributes = 609,
        [Description("Base Critical Strike Multiplier")]
        BaseCriticalStrikeMultiplier = 610,
        [Description("Main Hand Critical Strike Multiplier")]
        MainHandCriticalStrikeMultiplier = 611,
        [Description("Off Hand Critical Strike Multiplier")]
        OffHandCriticalStrikeMultiplier = 612,
        [Description("Spell Critical Strike Multiplier")]
        SpellCriticalStrikeMultiplier = 613,
        [Description("Base Cold Damage % To Convert To Fire")]
        BaseColdDamagePctToConvertToFire = 614,
        [Description("Base Chance To Ignite %")]
        BaseChanceToIgnitePct = 615,
        [Description("Fire Storm Fireball Delay Ms")]
        FireStormFireballDelayMs = 616,
        [Description("One Handed Melee Critical Strike Chance +%")]
        OneHandedMeleeCriticalStrikeChancePosPct = 617,
        [Description("Axe Critical Strike Multiplier +")]
        AxeCriticalStrikeMultiplierPos = 618,
        [Description("Sword Critical Strike Multiplier +")]
        SwordCriticalStrikeMultiplierPos = 619,
        [Description("Bow Critical Strike Multiplier +")]
        BowCriticalStrikeMultiplierPos = 620,
        [Description("Minion Movement Speed +%")]
        MinionMovementSpeedPosPct = 621,
        [Description("Is Area Damage")]
        IsAreaDamage = 622,
        [Description("Area Damage +%")]
        AreaDamagePosPct = 623,
        [Description("Avoid All Elemental Status %")]
        AvoidAllElementalStatusPct = 624,
        [Description("Self Elemental Status Duration -%")]
        SelfElementalStatusDurationNegPct = 625,
        [Description("One Handed Melee Critical Strike Multiplier +")]
        OneHandedMeleeCriticalStrikeMultiplierPos = 626,
        [Description("Two Handed Melee Critical Strike Chance +%")]
        TwoHandedMeleeCriticalStrikeChancePosPct = 627,
        [Description("Two Handed Melee Critical Strike Multiplier +")]
        TwoHandedMeleeCriticalStrikeMultiplierPos = 628,
        [Description("Shield Charge Continue Past Target")]
        ShieldChargeContinuePastTarget = 629,
        [Description("Avoid Chill %")]
        AvoidChillPct = 630,
        [Description("Avoid Freeze %")]
        AvoidFreezePct = 631,
        [Description("Avoid Ignite %")]
        AvoidIgnitePct = 632,
        [Description("Avoid Shock %")]
        AvoidShockPct = 633,
        [Description("Self Chill Duration -%")]
        SelfChillDurationNegPct = 634,
        [Description("Self Shock Duration -%")]
        SelfShockDurationNegPct = 635,
        [Description("Self Freeze Duration -%")]
        SelfFreezeDurationNegPct = 636,
        [Description("Self Ignite Duration -%")]
        SelfIgniteDurationNegPct = 637,
        [Description("Active Skill Damage +% Final")]
        ActiveSkillDamagePosPctFinal = 638,
        [Description("Phase Run Melee Physical Damage +% Final")]
        PhaseRunMeleePhysicalDamagePosPctFinal = 639,
        [Description("Active Skill Physical Damage +% Final")]
        ActiveSkillPhysicalDamagePosPctFinal = 640,
        [Description("Active Skill Elemental Damage +% Final")]
        ActiveSkillElementalDamagePosPctFinal = 641,
        [Description("Active Skill Fire Damage +% Final")]
        ActiveSkillFireDamagePosPctFinal = 642,
        [Description("Active Skill Cold Damage +% Final")]
        ActiveSkillColdDamagePosPctFinal = 643,
        [Description("Active Skill Lightning Damage +% Final")]
        ActiveSkillLightningDamagePosPctFinal = 644,
        [Description("Active Skill Chaos Damage +% Final")]
        ActiveSkillChaosDamagePosPctFinal = 645,
        [Description("Support Melee Physical Damage +% Final")]
        SupportMeleePhysicalDamagePosPctFinal = 646,
        [Description("Support Weapon Elemental Damage +% Final")]
        SupportWeaponElementalDamagePosPctFinal = 647,
        [Description("Support Area Concentrate Area Damage +% Final")]
        SupportAreaConcentrateAreaDamagePosPctFinal = 648,
        [Description("Active Skill Attack Damage +% Final")]
        ActiveSkillAttackDamagePosPctFinal = 649,
        [Description("Active Skill Spell Damage +% Final")]
        ActiveSkillSpellDamagePosPctFinal = 650,
        [Description("Support Multiple Projectile Damage +% Final")]
        SupportMultipleProjectileDamagePosPctFinal = 651,
        [Description("Enfeeble Damage +% Final")]
        EnfeebleDamagePosPctFinal = 652,
        [Description("Main Hand Weapon Minimum Physical Damage")]
        MainHandWeaponMinimumPhysicalDamage = 653,
        [Description("Main Hand Weapon Maximum Physical Damage")]
        MainHandWeaponMaximumPhysicalDamage = 654,
        [Description("Off Hand Weapon Minimum Physical Damage")]
        OffHandWeaponMinimumPhysicalDamage = 655,
        [Description("Off Hand Weapon Maximum Physical Damage")]
        OffHandWeaponMaximumPhysicalDamage = 656,
        [Description("Active Skill Minion Life +% Final")]
        ActiveSkillMinionLifePosPctFinal = 657,
        [Description("Active Skill Minion Damage +% Final")]
        ActiveSkillMinionDamagePosPctFinal = 658,
        [Description("Max Life +% Final For Minion")]
        MaxLifePosPctFinalForMinion = 659,
        [Description("Damage +% Final For Minion")]
        DamagePosPctFinalForMinion = 660,
        [Description("Strength Per Level")]
        StrengthPerLevel = 661,
        [Description("Dexterity Per Level")]
        DexterityPerLevel = 662,
        [Description("Intelligence Per Level")]
        IntelligencePerLevel = 663,
        [Description("Critical Strike Chance While Dual Wielding +%")]
        CriticalStrikeChanceWhileDualWieldingPosPct = 664,
        [Description("Critical Strike Multiplier While Dual Wielding +")]
        CriticalStrikeMultiplierWhileDualWieldingPos = 665,
        [Description("Mace Critical Strike Multiplier +")]
        MaceCriticalStrikeMultiplierPos = 666,
        [Description("Base Chance To Shock %")]
        BaseChanceToShockPct = 667,
        [Description("Spell Maximum Action Distance +%")]
        SpellMaximumActionDistancePosPct = 668,
        [Description("Local Accuracy Rating +%")]
        LocalAccuracyRatingPosPct = 669,
        [Description("Display Skill Increased Item Quantity +%")]
        DisplaySkillIncreasedItemQuantityPosPct = 670,
        [Description("Display Skill Increased Item Rarity +%")]
        DisplaySkillIncreasedItemRarityPosPct = 671,
        [Description("Wand Physical Damage % To Add As Fire")]
        WandPhysicalDamagePctToAddAsFire = 672,
        [Description("Wand Physical Damage % To Add As Cold")]
        WandPhysicalDamagePctToAddAsCold = 673,
        [Description("Wand Physical Damage % To Add As Lightning")]
        WandPhysicalDamagePctToAddAsLightning = 674,
        [Description("Main Hand Minimum Total Damage")]
        MainHandMinimumTotalDamage = 675,
        [Description("Main Hand Maximum Total Damage")]
        MainHandMaximumTotalDamage = 676,
        [Description("Off Hand Minimum Total Damage")]
        OffHandMinimumTotalDamage = 677,
        [Description("Off Hand Maximum Total Damage")]
        OffHandMaximumTotalDamage = 678,
        [Description("Spell Minimum Total Damage")]
        SpellMinimumTotalDamage = 679,
        [Description("Spell Maximum Total Damage")]
        SpellMaximumTotalDamage = 680,
        [Description("Chance To Hit %")]
        ChanceToHitPct = 681,
        [Description("Hundred Times Attacks Per Second")]
        HundredTimesAttacksPerSecond = 682,
        [Description("Hundred Times Damage Per Second")]
        HundredTimesDamagePerSecond = 683,
        [Description("Chance To Evade %")]
        ChanceToEvadePct = 684,
        [Description("Base Spell Cast Time Ms")]
        BaseSpellCastTimeMs = 685,
        [Description("Hundred Times Casts Per Second")]
        HundredTimesCastsPerSecond = 686,
        [Description("Global Hit Causes Monster Flee %")]
        GlobalHitCausesMonsterFleePct = 687,
        [Description("Local Hit Causes Monster Flee %")]
        LocalHitCausesMonsterFleePct = 688,
        [Description("Main Hand Hit Causes Monster Flee %")]
        MainHandHitCausesMonsterFleePct = 689,
        [Description("Off Hand Hit Causes Monster Flee %")]
        OffHandHitCausesMonsterFleePct = 690,
        [Description("Global Always Hit")]
        GlobalAlwaysHit = 691,
        [Description("Main Hand Always Hit")]
        MainHandAlwaysHit = 692,
        [Description("Off Hand Always Hit")]
        OffHandAlwaysHit = 693,
        [Description("Local Always Hit")]
        LocalAlwaysHit = 694,
        [Description("Explode On Low Life % Maximum Life To Deal")]
        ExplodeOnLowLifePctMaximumLifeToDeal = 695,
        [Description("Curses Never Expire")]
        CursesNeverExpire = 696,
        [Description("Chance To Dodge %")]
        ChanceToDodgePct = 697,
        [Description("No Physical Damage Reduction Rating")]
        NoPhysicalDamageReductionRating = 698,
        [Description("No Energy Shield")]
        NoEnergyShield = 699,
        [Description("Keystone Iron Reflexes")]
        KeystoneIronReflexes = 700,
        [Description("Global Cannot Crit")]
        GlobalCannotCrit = 701,
        [Description("Convert All Physical Damage To Fire")]
        ConvertAllPhysicalDamageToFire = 702,
        [Description("Base Cannot Evade")]
        BaseCannotEvade = 703,
        [Description("Chaos Immunity")]
        ChaosImmunity = 704,
        [Description("Keystone Chaos Inoculation")]
        KeystoneChaosInoculation = 705,
        [Description("Mana % To Add As Energy Shield")]
        ManaPctToAddAsEnergyShield = 706,
        [Description("No Mana")]
        NoMana = 707,
        [Description("Base Use Life In Place Of Mana")]
        BaseUseLifeInPlaceOfMana = 708,
        [Description("Base Cannot Be Stunned")]
        BaseCannotBeStunned = 709,
        [Description("Ignore Armour Movement Penalties")]
        IgnoreArmourMovementPenalties = 710,
        [Description("Base Buff Duration Ms + Per Endurance Charge")]
        BaseBuffDurationMsPosPerEnduranceCharge = 711,
        [Description("Secondary Minimum Physical Damage")]
        SecondaryMinimumPhysicalDamage = 712,
        [Description("Secondary Maximum Physical Damage")]
        SecondaryMaximumPhysicalDamage = 713,
        [Description("Secondary Minimum Cold Damage")]
        SecondaryMinimumColdDamage = 714,
        [Description("Secondary Maximum Cold Damage")]
        SecondaryMaximumColdDamage = 715,
        [Description("Secondary Minimum Fire Damage")]
        SecondaryMinimumFireDamage = 716,
        [Description("Secondary Maximum Fire Damage")]
        SecondaryMaximumFireDamage = 717,
        [Description("Secondary Minimum Lightning Damage")]
        SecondaryMinimumLightningDamage = 718,
        [Description("Secondary Maximum Lightning Damage")]
        SecondaryMaximumLightningDamage = 719,
        [Description("Secondary Minimum Chaos Damage")]
        SecondaryMinimumChaosDamage = 720,
        [Description("Secondary Maximum Chaos Damage")]
        SecondaryMaximumChaosDamage = 721,
        [Description("Secondary Critical Strike Multiplier")]
        SecondaryCriticalStrikeMultiplier = 722,
        [Description("Secondary Critical Strike Chance")]
        SecondaryCriticalStrikeChance = 723,
        [Description("Physical Immunity")]
        PhysicalImmunity = 724,
        [Description("Base Actor Scale +%")]
        BaseActorScalePosPct = 725,
        [Description("Display Estimated Physical Damage Reduciton %")]
        DisplayEstimatedPhysicalDamageReducitonPct = 726,
        [Description("Curse Count")]
        CurseCount = 727,
        [Description("Number Of Additional Curses Allowed")]
        NumberOfAdditionalCursesAllowed = 728,
        [Description("Melee Knockback")]
        MeleeKnockback = 729,
        [Description("Total Number Of Projectiles To Fire")]
        TotalNumberOfProjectilesToFire = 730,
        [Description("Total Number Of Arrows To Fire")]
        TotalNumberOfArrowsToFire = 731,
        [Description("Number Of Zombies Allowed")]
        NumberOfZombiesAllowed = 732,
        [Description("Number Of Spectres Allowed")]
        NumberOfSpectresAllowed = 733,
        [Description("Number Of Converted Allowed")]
        NumberOfConvertedAllowed = 734,
        [Description("Number Of Skeletons Allowed")]
        NumberOfSkeletonsAllowed = 735,
        [Description("From Armour Movement Speed +%")]
        FromArmourMovementSpeedPosPct = 736,
        [Description("Active Skill Minion Energy Shield +% Final")]
        ActiveSkillMinionEnergyShieldPosPctFinal = 737,
        [Description("Energy Shield +% Final For Minion")]
        EnergyShieldPosPctFinalForMinion = 738,
        [Description("Projectile Damage Taken +%")]
        ProjectileDamageTakenPosPct = 739,
        [Description("Fire Shield Damage Threshold")]
        FireShieldDamageThreshold = 740,
        [Description("Support Multiple Projectiles Critical Strike Chance +% Final")]
        SupportMultipleProjectilesCriticalStrikeChancePosPctFinal = 741,
        [Description("Display Monster Wealth Mod")]
        DisplayMonsterWealthMod = 742,
        [Description("Local Armour And Energy Shield +%")]
        LocalArmourAndEnergyShieldPosPct = 743,
        [Description("Local Armour And Evasion +%")]
        LocalArmourAndEvasionPosPct = 744,
        [Description("Local Evasion And Energy Shield +%")]
        LocalEvasionAndEnergyShieldPosPct = 745,
        [Description("Local Armour And Evasion And Energy Shield +%")]
        LocalArmourAndEvasionAndEnergyShieldPosPct = 746,
        [Description("Flask Charges Used +%")]
        FlaskChargesUsedPosPct = 747,
        [Description("Flask Duration +%")]
        FlaskDurationPosPct = 748,
        [Description("Flask Life Recovery Rate +%")]
        FlaskLifeRecoveryRatePosPct = 749,
        [Description("Flask Mana Recovery Rate +%")]
        FlaskManaRecoveryRatePosPct = 750,
        [Description("Minions Get Shield Stats Instead Of You")]
        MinionsGetShieldStatsInsteadOfYou = 751,
        [Description("Cannot Resist Cold Damage")]
        CannotResistColdDamage = 752,
        [Description("Add Power Charge On Kill")]
        AddPowerChargeOnKill = 753,
        [Description("Immune To Curses")]
        ImmuneToCurses = 754,
        [Description("Monster Grants Frenzy Charges To Allies Within Distance On Death")]
        MonsterGrantsFrenzyChargesToAlliesWithinDistanceOnDeath = 755,
        [Description("Dual Wield Or Shield Block %")]
        DualWieldOrShieldBlockPct = 756,
        [Description("Gain Frenzy Charge For Each Quarter Life Removed")]
        GainFrenzyChargeForEachQuarterLifeRemoved = 757,
        [Description("Monster Life Thresholds Passed")]
        MonsterLifeThresholdsPassed = 758,
        [Description("Chaos Inoculation Keystone Energy Shield +% Final")]
        ChaosInoculationKeystoneEnergyShieldPosPctFinal = 759,
        [Description("Pain Attunement Keystone Spell Damage +% Final")]
        PainAttunementKeystoneSpellDamagePosPctFinal = 760,
        [Description("Keystone Elemental Equilibrium")]
        KeystoneElementalEquilibrium = 761,
        [Description("Evasion Rating + When On Low Life")]
        EvasionRatingPosWhenOnLowLife = 762,
        [Description("Life Regeneration Rate Per Minute % When On Low Life")]
        LifeRegenerationRatePerMinutePctWhenOnLowLife = 763,
        [Description("Local Socketed Strength Gem Level +")]
        LocalSocketedStrengthGemLevelPos = 764,
        [Description("Local Socketed Dexterity Gem Level +")]
        LocalSocketedDexterityGemLevelPos = 765,
        [Description("Local Socketed Intelligence Gem Level +")]
        LocalSocketedIntelligenceGemLevelPos = 766,
        [Description("Maximum Physical Damage To Return To Melee Attacker")]
        MaximumPhysicalDamageToReturnToMeleeAttacker = 767,
        [Description("Maximum Fire Damage To Return To Melee Attacker")]
        MaximumFireDamageToReturnToMeleeAttacker = 768,
        [Description("Maximum Cold Damage To Return To Melee Attacker")]
        MaximumColdDamageToReturnToMeleeAttacker = 769,
        [Description("Maximum Lightning Damage To Return To Melee Attacker")]
        MaximumLightningDamageToReturnToMeleeAttacker = 770,
        [Description("Maximum Chaos Damage To Return To Melee Attacker")]
        MaximumChaosDamageToReturnToMeleeAttacker = 771,
        [Description("Minimum Physical Damage To Return To Melee Attacker")]
        MinimumPhysicalDamageToReturnToMeleeAttacker = 772,
        [Description("Minimum Fire Damage To Return To Melee Attacker")]
        MinimumFireDamageToReturnToMeleeAttacker = 773,
        [Description("Minimum Cold Damage To Return To Melee Attacker")]
        MinimumColdDamageToReturnToMeleeAttacker = 774,
        [Description("Minimum Lightning Damage To Return To Melee Attacker")]
        MinimumLightningDamageToReturnToMeleeAttacker = 775,
        [Description("Minimum Chaos Damage To Return To Melee Attacker")]
        MinimumChaosDamageToReturnToMeleeAttacker = 776,
        [Description("Physical Damage Taken When Hit By Attack")]
        PhysicalDamageTakenWhenHitByAttack = 777,
        [Description("Fire Damage Taken When Hit By Attack")]
        FireDamageTakenWhenHitByAttack = 778,
        [Description("Cold Damage Taken When Hit By Attack")]
        ColdDamageTakenWhenHitByAttack = 779,
        [Description("Lightning Damage Taken When Hit By Attack")]
        LightningDamageTakenWhenHitByAttack = 780,
        [Description("Chaos Damage Taken When Hit By Attack")]
        ChaosDamageTakenWhenHitByAttack = 781,
        [Description("Mana Cost +% When On Low Life")]
        ManaCostPosPctWhenOnLowLife = 782,
        [Description("Elemental Resistance % When On Low Life")]
        ElementalResistancePctWhenOnLowLife = 783,
        [Description("Local Has No Sockets")]
        LocalHasNoSockets = 784,
        [Description("Local All Sockets Linked")]
        LocalAllSocketsLinked = 785,
        [Description("Movement Velocity +% When On Low Life")]
        MovementVelocityPosPctWhenOnLowLife = 786,
        [Description("Mana Cost +%")]
        ManaCostPosPct = 787,
        [Description("Keystone Acrobatics")]
        KeystoneAcrobatics = 788,
        [Description("Keystone Pain Attunement")]
        KeystonePainAttunement = 789,
        [Description("Item Found Quantity +% When On Low Life")]
        ItemFoundQuantityPosPctWhenOnLowLife = 790,
        [Description("Item Found Rarity +% When On Low Life")]
        ItemFoundRarityPosPctWhenOnLowLife = 791,
        [Description("Item Found Quantity +%")]
        ItemFoundQuantityPosPct = 792,
        [Description("Item Found Rarity +%")]
        ItemFoundRarityPosPct = 793,
        [Description("Active Skill Projectile Damage +% Final")]
        ActiveSkillProjectileDamagePosPctFinal = 794,
        [Description("Bonus Damage +% From Strength")]
        BonusDamagePosPctFromStrength = 795,
        [Description("Keystone Strong Bowman")]
        KeystoneStrongBowman = 796,
        [Description("Monster Projectile Variation")]
        MonsterProjectileVariation = 797,
        [Description("Keystone Point Blank")]
        KeystonePointBlank = 798,
        [Description("Damage +% Final From Distance")]
        DamagePosPctFinalFromDistance = 799,
        [Description("Keystone Conduit")]
        KeystoneConduit = 800,
        [Description("Movement Velocity +% When On Full Life")]
        MovementVelocityPosPctWhenOnFullLife = 801,
        [Description("Show Number Of Projectiles")]
        ShowNumberOfProjectiles = 802,
        [Description("Lightning Arrow Maximum Number Of Extra Targets")]
        LightningArrowMaximumNumberOfExtraTargets = 803,
        [Description("Main Hand Local Physical Damage +%")]
        MainHandLocalPhysicalDamagePosPct = 804,
        [Description("Main Hand Local Minimum Added Physical Damage")]
        MainHandLocalMinimumAddedPhysicalDamage = 805,
        [Description("Main Hand Local Maximum Added Physical Damage")]
        MainHandLocalMaximumAddedPhysicalDamage = 806,
        [Description("Main Hand Local Minimum Added Fire Damage")]
        MainHandLocalMinimumAddedFireDamage = 807,
        [Description("Main Hand Local Maximum Added Fire Damage")]
        MainHandLocalMaximumAddedFireDamage = 808,
        [Description("Main Hand Local Minimum Added Cold Damage")]
        MainHandLocalMinimumAddedColdDamage = 809,
        [Description("Main Hand Local Maximum Added Cold Damage")]
        MainHandLocalMaximumAddedColdDamage = 810,
        [Description("Main Hand Local Minimum Added Lightning Damage")]
        MainHandLocalMinimumAddedLightningDamage = 811,
        [Description("Main Hand Local Maximum Added Lightning Damage")]
        MainHandLocalMaximumAddedLightningDamage = 812,
        [Description("Main Hand Local Minimum Added Chaos Damage")]
        MainHandLocalMinimumAddedChaosDamage = 813,
        [Description("Main Hand Local Maximum Added Chaos Damage")]
        MainHandLocalMaximumAddedChaosDamage = 814,
        [Description("Main Hand Local Attack Speed +%")]
        MainHandLocalAttackSpeedPosPct = 815,
        [Description("Old Do Not Use Main Hand Local Life Leech From Physical Damage %")]
        OldDoNotUseMainHandLocalLifeLeechFromPhysicalDamagePct = 816,
        [Description("Old Do Not Use Main Hand Local Mana Leech From Physical Damage %")]
        OldDoNotUseMainHandLocalManaLeechFromPhysicalDamagePct = 817,
        [Description("Main Hand Local Knockback")]
        MainHandLocalKnockback = 818,
        [Description("Main Hand Local Critical Strike Multiplier +")]
        MainHandLocalCriticalStrikeMultiplierPos = 819,
        [Description("Main Hand Local Critical Strike Chance")]
        MainHandLocalCriticalStrikeChance = 820,
        [Description("Main Hand Local Critical Strike Chance +%")]
        MainHandLocalCriticalStrikeChancePosPct = 821,
        [Description("Main Hand Local Accuracy Rating")]
        MainHandLocalAccuracyRating = 822,
        [Description("Main Hand Local Accuracy Rating +%")]
        MainHandLocalAccuracyRatingPosPct = 823,
        [Description("Main Hand Local Hit Causes Monster Flee %")]
        MainHandLocalHitCausesMonsterFleePct = 824,
        [Description("Main Hand Local Always Hit")]
        MainHandLocalAlwaysHit = 825,
        [Description("Off Hand Local Physical Damage +%")]
        OffHandLocalPhysicalDamagePosPct = 826,
        [Description("Off Hand Local Minimum Added Physical Damage")]
        OffHandLocalMinimumAddedPhysicalDamage = 827,
        [Description("Off Hand Local Maximum Added Physical Damage")]
        OffHandLocalMaximumAddedPhysicalDamage = 828,
        [Description("Off Hand Local Minimum Added Fire Damage")]
        OffHandLocalMinimumAddedFireDamage = 829,
        [Description("Off Hand Local Maximum Added Fire Damage")]
        OffHandLocalMaximumAddedFireDamage = 830,
        [Description("Off Hand Local Minimum Added Cold Damage")]
        OffHandLocalMinimumAddedColdDamage = 831,
        [Description("Off Hand Local Maximum Added Cold Damage")]
        OffHandLocalMaximumAddedColdDamage = 832,
        [Description("Off Hand Local Minimum Added Lightning Damage")]
        OffHandLocalMinimumAddedLightningDamage = 833,
        [Description("Off Hand Local Maximum Added Lightning Damage")]
        OffHandLocalMaximumAddedLightningDamage = 834,
        [Description("Off Hand Local Minimum Added Chaos Damage")]
        OffHandLocalMinimumAddedChaosDamage = 835,
        [Description("Off Hand Local Maximum Added Chaos Damage")]
        OffHandLocalMaximumAddedChaosDamage = 836,
        [Description("Off Hand Local Attack Speed +%")]
        OffHandLocalAttackSpeedPosPct = 837,
        [Description("Old Do Not Use Off Hand Local Life Leech From Physical Damage %")]
        OldDoNotUseOffHandLocalLifeLeechFromPhysicalDamagePct = 838,
        [Description("Old Do Not Use Off Hand Local Mana Leech From Physical Damage %")]
        OldDoNotUseOffHandLocalManaLeechFromPhysicalDamagePct = 839,
        [Description("Off Hand Local Knockback")]
        OffHandLocalKnockback = 840,
        [Description("Off Hand Local Critical Strike Multiplier +")]
        OffHandLocalCriticalStrikeMultiplierPos = 841,
        [Description("Off Hand Local Critical Strike Chance")]
        OffHandLocalCriticalStrikeChance = 842,
        [Description("Off Hand Local Critical Strike Chance +%")]
        OffHandLocalCriticalStrikeChancePosPct = 843,
        [Description("Off Hand Local Accuracy Rating")]
        OffHandLocalAccuracyRating = 844,
        [Description("Off Hand Local Accuracy Rating +%")]
        OffHandLocalAccuracyRatingPosPct = 845,
        [Description("Off Hand Local Hit Causes Monster Flee %")]
        OffHandLocalHitCausesMonsterFleePct = 846,
        [Description("Off Hand Local Always Hit")]
        OffHandLocalAlwaysHit = 847,
        [Description("Acrobatics Additional Chance To Dodge %")]
        AcrobaticsAdditionalChanceToDodgePct = 848,
        [Description("Keystone Phase Acrobatics")]
        KeystonePhaseAcrobatics = 849,
        [Description("Chance To Dodge Spells %")]
        ChanceToDodgeSpellsPct = 850,
        [Description("Phase Acrobatics Additional Chance To Dodge Spells %")]
        PhaseAcrobaticsAdditionalChanceToDodgeSpellsPct = 851,
        [Description("Number Of Inca Minions Allowed")]
        NumberOfIncaMinionsAllowed = 852,
        [Description("Curse Cast Speed +%")]
        CurseCastSpeedPosPct = 853,
        [Description("Chance To Evade Projectile Attacks +%")]
        ChanceToEvadeProjectileAttacksPosPct = 854,
        [Description("Keystone Projectile Evasion")]
        KeystoneProjectileEvasion = 855,
        [Description("Elemental Status Effect Aura Radius")]
        ElementalStatusEffectAuraRadius = 856,
        [Description("Support Lesser Multiple Projectile Damage +% Final")]
        SupportLesserMultipleProjectileDamagePosPctFinal = 857,
        [Description("Use Life In Place Of Mana")]
        UseLifeInPlaceOfMana = 858,
        [Description("Keystone Blood Magic")]
        KeystoneBloodMagic = 859,
        [Description("Base Mana Reservation +%")]
        BaseManaReservationPosPct = 860,
        [Description("Base Aura Area Of Effect +%")]
        BaseAuraAreaOfEffectPosPct = 861,
        [Description("Physical Attack Damage Taken +")]
        PhysicalAttackDamageTakenPos = 862,
        [Description("Physical Ranged Attack Damage Taken +")]
        PhysicalRangedAttackDamageTakenPos = 863,
        [Description("Block % To Apply To Spells While On Low Life")]
        BlockPctToApplyToSpellsWhileOnLowLife = 864,
        [Description("Display What Elemental Proliferation Does")]
        DisplayWhatElementalProliferationDoes = 865,
        [Description("Skill Can Fire Arrows")]
        SkillCanFireArrows = 866,
        [Description("Skill Can Fire Wand Projectiles")]
        SkillCanFireWandProjectiles = 867,
        [Description("Local Additional Block Chance %")]
        LocalAdditionalBlockChancePct = 868,
        [Description("Keystone Minion Instability")]
        KeystoneMinionInstability = 869,
        [Description("Strong Casting")]
        StrongCasting = 870,
        [Description("Support Damage While On Full Life +% Final")]
        SupportDamageWhileOnFullLifePosPctFinal = 871,
        [Description("Is Totem")]
        IsTotem = 872,
        [Description("Monster Base Type Attack Cast Speed +% And Damage -% Final")]
        MonsterBaseTypeAttackCastSpeedPosPctAndDamageNegPctFinal = 873,
        [Description("Monster Rarity Attack Cast Speed +% And Damage -% Final")]
        MonsterRarityAttackCastSpeedPosPctAndDamageNegPctFinal = 874,
        [Description("Monster Attack Cast Speed +% And Damage -% Final")]
        MonsterAttackCastSpeedPosPctAndDamageNegPctFinal = 875,
        [Description("Cast Speed +% From Haste Aura")]
        CastSpeedPosPctFromHasteAura = 876,
        [Description("Is Hidden Monster")]
        IsHiddenMonster = 877,
        [Description("Base Totem Duration")]
        BaseTotemDuration = 878,
        [Description("Totem Duration")]
        TotemDuration = 879,
        [Description("Base Totem Range")]
        BaseTotemRange = 880,
        [Description("Totem Range")]
        TotemRange = 881,
        [Description("Immune To Auras From Other Entities")]
        ImmuneToAurasFromOtherEntities = 882,
        [Description("Totem Support Gem Level")]
        TotemSupportGemLevel = 883,
        [Description("Base Number Of Totems Allowed")]
        BaseNumberOfTotemsAllowed = 884,
        [Description("Base Trap Duration")]
        BaseTrapDuration = 885,
        [Description("Trap Duration")]
        TrapDuration = 886,
        [Description("Base Number Of Traps Allowed")]
        BaseNumberOfTrapsAllowed = 887,
        [Description("Monster Flurry")]
        MonsterFlurry = 888,
        [Description("Number Of Insects Allowed")]
        NumberOfInsectsAllowed = 889,
        [Description("Is Remote Mine")]
        IsRemoteMine = 890,
        [Description("Base Number Of Remote Mines Allowed")]
        BaseNumberOfRemoteMinesAllowed = 891,
        [Description("Base Mine Duration")]
        BaseMineDuration = 892,
        [Description("Mine Duration")]
        MineDuration = 893,
        [Description("Nonlethal Fire Damage Taken Per Minute")]
        NonlethalFireDamageTakenPerMinute = 894,
        [Description("Base Nonlethal Fire Damage % Of Maximum Life Taken Per Minute")]
        BaseNonlethalFireDamagePctOfMaximumLifeTakenPerMinute = 895,
        [Description("Righteous Fire Spell Damage +% Final")]
        RighteousFireSpellDamagePosPctFinal = 896,
        [Description("Base Righteous Fire % Of Max Life To Deal To Nearby Per Minute")]
        BaseRighteousFirePctOfMaxLifeToDealToNearbyPerMinute = 897,
        [Description("Totem Level")]
        TotemLevel = 898,
        [Description("Base Active Skill Totem Level")]
        BaseActiveSkillTotemLevel = 899,
        [Description("Alternate Minion")]
        AlternateMinion = 900,
        [Description("Corpse Consumption Life To Gain")]
        CorpseConsumptionLifeToGain = 901,
        [Description("Support Totem Damage +% Final")]
        SupportTotemDamagePosPctFinal = 902,
        [Description("Freeze Mine Damage To Freeze As Though Dealing")]
        FreezeMineDamageToFreezeAsThoughDealing = 903,
        [Description("Monster No Drops Or Experience")]
        MonsterNoDropsOrExperience = 904,
        [Description("Active Skill Gem Added Damage Effectiveness +% Final")]
        ActiveSkillGemAddedDamageEffectivenessPosPctFinal = 905,
        [Description("Monster Gain Frenzy Charge On Kin Death")]
        MonsterGainFrenzyChargeOnKinDeath = 906,
        [Description("Monster Ground Fire On Death % Max Damage To Deal Per Minute")]
        MonsterGroundFireOnDeathPctMaxDamageToDealPerMinute = 907,
        [Description("Monster Ground Fire On Death Base Area Of Effect Radius")]
        MonsterGroundFireOnDeathBaseAreaOfEffectRadius = 908,
        [Description("Monster Ground Effect On Death Base Duration Ms")]
        MonsterGroundEffectOnDeathBaseDurationMs = 909,
        [Description("Monster Ground Fire On Death Duration Ms")]
        MonsterGroundFireOnDeathDurationMs = 910,
        [Description("Curse On Hit % Vulnerability")]
        CurseOnHitPctVulnerability = 911,
        [Description("Curse On Hit % Temporal Chains")]
        CurseOnHitPctTemporalChains = 912,
        [Description("Support Gem Mine Damage +% Final")]
        SupportGemMineDamagePosPctFinal = 913,
        [Description("Undead Description")]
        UndeadDescription = 914,
        [Description("Monster Casts Firestorm Text")]
        MonsterCastsFirestormText = 915,
        [Description("Monster Casts Puncture Text")]
        MonsterCastsPunctureText = 916,
        [Description("Monster Casts Coldsnap Text")]
        MonsterCastsColdsnapText = 917,
        [Description("Monster Casts Assassins Mark Curse Text")]
        MonsterCastsAssassinsMarkCurseText = 918,
        [Description("Monster Casts Elementral Weakness Curse Text")]
        MonsterCastsElementralWeaknessCurseText = 919,
        [Description("Monster Casts Enfeeble Curse Text")]
        MonsterCastsEnfeebleCurseText = 920,
        [Description("Monster Casts Fireball Text")]
        MonsterCastsFireballText = 921,
        [Description("Monster Casts Ice Nova Text")]
        MonsterCastsIceNovaText = 922,
        [Description("Monster Casts Ice Spear Text")]
        MonsterCastsIceSpearText = 923,
        [Description("Monster Casts Molten Shell Text")]
        MonsterCastsMoltenShellText = 924,
        [Description("Monster Casts Projectile Vulnerability Curse Text")]
        MonsterCastsProjectileVulnerabilityCurseText = 925,
        [Description("Monster Casts Shock Nova Text")]
        MonsterCastsShockNovaText = 926,
        [Description("Monster Casts Spark Text")]
        MonsterCastsSparkText = 927,
        [Description("Monster Casts Vulnerability Curse Text")]
        MonsterCastsVulnerabilityCurseText = 928,
        [Description("Monster Casts Warlords Mark Curse Text")]
        MonsterCastsWarlordsMarkCurseText = 929,
        [Description("Monster Detonates Corpses Text")]
        MonsterDetonatesCorpsesText = 930,
        [Description("Monster Explodes On Its Target Text")]
        MonsterExplodesOnItsTargetText = 931,
        [Description("Monster Fires A Rain Of Arrows Text")]
        MonsterFiresARainOfArrowsText = 932,
        [Description("Monster Fires Burning Arrows Text")]
        MonsterFiresBurningArrowsText = 933,
        [Description("Monster Fires Explosive Arrows Text")]
        MonsterFiresExplosiveArrowsText = 934,
        [Description("Monster Fires Lightning Arrows Text")]
        MonsterFiresLightningArrowsText = 935,
        [Description("Monster Fires Caustic Arrows Text")]
        MonsterFiresCausticArrowsText = 936,
        [Description("Monster Fires Split Arrows Text")]
        MonsterFiresSplitArrowsText = 937,
        [Description("Monster Leaps Onto Enemies Text")]
        MonsterLeapsOntoEnemiesText = 938,
        [Description("Monster Raises Undead Text")]
        MonsterRaisesUndeadText = 939,
        [Description("Monster Summons Exploding Spawn Text")]
        MonsterSummonsExplodingSpawnText = 940,
        [Description("Monster Summons Monkeys From Nearby Trees Text")]
        MonsterSummonsMonkeysFromNearbyTreesText = 941,
        [Description("Monster Summons Skeletons Text")]
        MonsterSummonsSkeletonsText = 942,
        [Description("Monster Summons Spawn Text")]
        MonsterSummonsSpawnText = 943,
        [Description("Monster Uses Enduring Cry Text")]
        MonsterUsesEnduringCryText = 944,
        [Description("Monster Uses Flicker Strike Text")]
        MonsterUsesFlickerStrikeText = 945,
        [Description("Monster Uses Glacial Hammer Text")]
        MonsterUsesGlacialHammerText = 946,
        [Description("Monster Uses Ground Slam Text")]
        MonsterUsesGroundSlamText = 947,
        [Description("Monster Uses Lightning Strike Text")]
        MonsterUsesLightningStrikeText = 948,
        [Description("Monster Uses Phase Run Text")]
        MonsterUsesPhaseRunText = 949,
        [Description("Monster Casts Shield Charge Text")]
        MonsterCastsShieldChargeText = 950,
        [Description("Monster Casts Mass Frenzy Text")]
        MonsterCastsMassFrenzyText = 951,
        [Description("Monster Casts Temporal Chains Text")]
        MonsterCastsTemporalChainsText = 952,
        [Description("Monster Casts Frenzy Text")]
        MonsterCastsFrenzyText = 953,
        [Description("Monster Casts Viper Strike Text")]
        MonsterCastsViperStrikeText = 954,
        [Description("Monster Casts Elemental Hit Text")]
        MonsterCastsElementalHitText = 955,
        [Description("Cannot Block Attacks")]
        CannotBlockAttacks = 956,
        [Description("Attack Block %")]
        AttackBlockPct = 957,
        [Description("Local Weapon Uses Both Hands")]
        LocalWeaponUsesBothHands = 958,
        [Description("Base Maximum Fire Damage Resistance %")]
        BaseMaximumFireDamageResistancePct = 959,
        [Description("Base Maximum Cold Damage Resistance %")]
        BaseMaximumColdDamageResistancePct = 960,
        [Description("Base Maximum Lightning Damage Resistance %")]
        BaseMaximumLightningDamageResistancePct = 961,
        [Description("Base Maximum Chaos Damage Resistance %")]
        BaseMaximumChaosDamageResistancePct = 962,
        [Description("Additional Maximum All Resistances %")]
        AdditionalMaximumAllResistancesPct = 963,
        [Description("Additional Maximum All Elemental Resistances %")]
        AdditionalMaximumAllElementalResistancesPct = 964,
        [Description("Local Display Socketed Gems Get Concentrated Area Level")]
        LocalDisplaySocketedGemsGetConcentratedAreaLevel = 965,
        [Description("Number Of Additional Traps Allowed")]
        NumberOfAdditionalTrapsAllowed = 966,
        [Description("Number Of Additional Remote Mines Allowed")]
        NumberOfAdditionalRemoteMinesAllowed = 967,
        [Description("Number Of Traps Allowed")]
        NumberOfTrapsAllowed = 968,
        [Description("Number Of Remote Mines Allowed")]
        NumberOfRemoteMinesAllowed = 969,
        [Description("Number Of Additional Totems Allowed")]
        NumberOfAdditionalTotemsAllowed = 970,
        [Description("Number Of Totems Allowed")]
        NumberOfTotemsAllowed = 971,
        [Description("Additional Physical Damage Reduction % When On Low Life")]
        AdditionalPhysicalDamageReductionPctWhenOnLowLife = 972,
        [Description("Endurance Only Conduit")]
        EnduranceOnlyConduit = 973,
        [Description("Frenzy Only Conduit")]
        FrenzyOnlyConduit = 974,
        [Description("Power Only Conduit")]
        PowerOnlyConduit = 975,
        [Description("Ice Spear Second Form Critical Strike Chance +%")]
        IceSpearSecondFormCriticalStrikeChancePosPct = 976,
        [Description("Monster Dropped Item Rarity +% From Player Support")]
        MonsterDroppedItemRarityPosPctFromPlayerSupport = 977,
        [Description("Monster Dropped Item Quantity +% From Player Support")]
        MonsterDroppedItemQuantityPosPctFromPlayerSupport = 978,
        [Description("Monster Ground Ice On Death Base Area Of Effect Radius")]
        MonsterGroundIceOnDeathBaseAreaOfEffectRadius = 979,
        [Description("Monster Ground Ice On Death Duration Ms")]
        MonsterGroundIceOnDeathDurationMs = 980,
        [Description("Monster Ground Tar On Death Base Area Of Effect Radius")]
        MonsterGroundTarOnDeathBaseAreaOfEffectRadius = 981,
        [Description("Monster Ground Tar On Death Duration Ms")]
        MonsterGroundTarOnDeathDurationMs = 982,
        [Description("Monster Ground Tar On Death Monvement Speed Pluspercent")]
        MonsterGroundTarOnDeathMonvementSpeedPluspercent = 983,
        [Description("Blinded")]
        Blinded = 984,
        [Description("Local Chance To Blind On Hit %")]
        LocalChanceToBlindOnHitPct = 985,
        [Description("Main Hand Local Chance To Blind On Hit %")]
        MainHandLocalChanceToBlindOnHitPct = 986,
        [Description("Off Hand Local Chance To Blind On Hit %")]
        OffHandLocalChanceToBlindOnHitPct = 987,
        [Description("Global Chance To Blind On Hit %")]
        GlobalChanceToBlindOnHitPct = 988,
        [Description("Main Hand Chance To Blind On Hit %")]
        MainHandChanceToBlindOnHitPct = 989,
        [Description("Off Hand Chance To Blind On Hit %")]
        OffHandChanceToBlindOnHitPct = 990,
        [Description("Local Display Socketed Gems Get Blind Level")]
        LocalDisplaySocketedGemsGetBlindLevel = 991,
        [Description("Blind Duration +%")]
        BlindDurationPosPct = 992,
        [Description("Cannot Be Knocked Back")]
        CannotBeKnockedBack = 993,
        [Description("Dual Wield Inherent Attack Speed +% Final")]
        DualWieldInherentAttackSpeedPosPctFinal = 994,
        [Description("Map Spawn Two Bosses")]
        MapSpawnTwoBosses = 995,
        [Description("Map Boss Damage +%")]
        MapBossDamagePosPct = 996,
        [Description("Map Boss Attack And Cast Speed +%")]
        MapBossAttackAndCastSpeedPosPct = 997,
        [Description("Map Monsters Additional Fire Resistance")]
        MapMonstersAdditionalFireResistance = 998,
        [Description("Map Monsters Additional Cold Resistance")]
        MapMonstersAdditionalColdResistance = 999,
        [Description("Map Monsters Additional Lightning Resistance")]
        MapMonstersAdditionalLightningResistance = 1000,
        [Description("Map Monsters Additional Physical Damage Reduction")]
        MapMonstersAdditionalPhysicalDamageReduction = 1001,
        [Description("Map Monsters Cannot Be Stunned")]
        MapMonstersCannotBeStunned = 1002,
        [Description("Map Monsters Life +%")]
        MapMonstersLifePosPct = 1003,
        [Description("Map Monsters Damage +%")]
        MapMonstersDamagePosPct = 1004,
        [Description("Map Monsters Movement Speed +%")]
        MapMonstersMovementSpeedPosPct = 1005,
        [Description("Map Monsters Attack Speed +%")]
        MapMonstersAttackSpeedPosPct = 1006,
        [Description("Map Monsters Cast Speed +%")]
        MapMonstersCastSpeedPosPct = 1007,
        [Description("Map Monsters Reflect % Physical Damage")]
        MapMonstersReflectPctPhysicalDamage = 1008,
        [Description("Map Monsters Reflect % Elemental Damage")]
        MapMonstersReflectPctElementalDamage = 1009,
        [Description("Map Monsters Additional Number Of Projecitles")]
        MapMonstersAdditionalNumberOfProjecitles = 1010,
        [Description("Map Player Has Level X Vulnerability")]
        MapPlayerHasLevelXVulnerability = 1011,
        [Description("Map Player Has Level X Warlords Mark")]
        MapPlayerHasLevelXWarlordsMark = 1012,
        [Description("Map Player Has Level X Enfeeble")]
        MapPlayerHasLevelXEnfeeble = 1013,
        [Description("Map Player Has Level X Elemental Weakness")]
        MapPlayerHasLevelXElementalWeakness = 1014,
        [Description("Map Player Has Level X Temporal Chains")]
        MapPlayerHasLevelXTemporalChains = 1015,
        [Description("Map Player No Regeneration")]
        MapPlayerNoRegeneration = 1016,
        [Description("No Life Regeneration")]
        NoLifeRegeneration = 1017,
        [Description("No Mana Regeneration")]
        NoManaRegeneration = 1018,
        [Description("Map Player Base Chaos Damage Taken Per Minute")]
        MapPlayerBaseChaosDamageTakenPerMinute = 1019,
        [Description("Map Player Has Blood Magic Keystone")]
        MapPlayerHasBloodMagicKeystone = 1020,
        [Description("Map Player Has Elemental Equilibrium Keystone")]
        MapPlayerHasElementalEquilibriumKeystone = 1021,
        [Description("Map Player Has Chaos Inoculation Keystone")]
        MapPlayerHasChaosInoculationKeystone = 1022,
        [Description("Map Additional Player Maximum Resistances %")]
        MapAdditionalPlayerMaximumResistancesPct = 1023,
        [Description("Map Player Status Recovery Speed +%")]
        MapPlayerStatusRecoverySpeedPosPct = 1024,
        [Description("Life Recovery Speed +% Final From Map")]
        LifeRecoverySpeedPosPctFinalFromMap = 1025,
        [Description("Mana Recovery Speed +% Final From Map")]
        ManaRecoverySpeedPosPctFinalFromMap = 1026,
        [Description("Energy Shield Recovery Speed +% Final From Map")]
        EnergyShieldRecoverySpeedPosPctFinalFromMap = 1027,
        [Description("Map Size +%")]
        MapSizePosPct = 1028,
        [Description("Map Is Branchy")]
        MapIsBranchy = 1029,
        [Description("Map Packs Are Totems")]
        MapPacksAreTotems = 1030,
        [Description("Map Packs Are Skeletons")]
        MapPacksAreSkeletons = 1031,
        [Description("Map Packs Are Bandits")]
        MapPacksAreBandits = 1032,
        [Description("Map Packs Are Goatmen")]
        MapPacksAreGoatmen = 1033,
        [Description("Map Packs Are Sea Witches And Spawn")]
        MapPacksAreSeaWitchesAndSpawn = 1034,
        [Description("Map Packs Are Undead And Necromancers")]
        MapPacksAreUndeadAndNecromancers = 1035,
        [Description("Map Packs Fire Projectiles")]
        MapPacksFireProjectiles = 1036,
        [Description("Map Pack Size +%")]
        MapPackSizePosPct = 1037,
        [Description("Map Number Of Magic Packs +%")]
        MapNumberOfMagicPacksPosPct = 1038,
        [Description("Map Number Of Rare Packs +%")]
        MapNumberOfRarePacksPosPct = 1039,
        [Description("Map Base Ground Fire Damage To Deal Per Minute")]
        MapBaseGroundFireDamageToDealPerMinute = 1040,
        [Description("Map Monsters % Physical Damage To Convert To Fire")]
        MapMonstersPctPhysicalDamageToConvertToFire = 1041,
        [Description("Map Monsters % Physical Damage To Convert To Cold")]
        MapMonstersPctPhysicalDamageToConvertToCold = 1042,
        [Description("Map Monsters % Physical Damage To Convert To Lightning")]
        MapMonstersPctPhysicalDamageToConvertToLightning = 1043,
        [Description("Map Monsters % Physical Damage To Convert To Chaos")]
        MapMonstersPctPhysicalDamageToConvertToChaos = 1044,
        [Description("Map Monsters % Physical Damage To Add As Fire")]
        MapMonstersPctPhysicalDamageToAddAsFire = 1045,
        [Description("Map Monsters % Physical Damage To Add As Cold")]
        MapMonstersPctPhysicalDamageToAddAsCold = 1046,
        [Description("Map Monsters % Physical Damage To Add As Lightning")]
        MapMonstersPctPhysicalDamageToAddAsLightning = 1047,
        [Description("Map Monsters % Physical Damage To Add As Chaos")]
        MapMonstersPctPhysicalDamageToAddAsChaos = 1048,
        [Description("Base Additional Physical Damage Reduction %")]
        BaseAdditionalPhysicalDamageReductionPct = 1049,
        [Description("Map Monsters Gain X Frenzy Charges Every 20 Seconds")]
        MapMonstersGainXFrenzyChargesEvery20Seconds = 1050,
        [Description("Map Additional Number Of Packs To Choose")]
        MapAdditionalNumberOfPacksToChoose = 1051,
        [Description("Map Item Drop Quantity +%")]
        MapItemDropQuantityPosPct = 1052,
        [Description("Map Ground Effect Patches Per 100 Tiles")]
        MapGroundEffectPatchesPer100Tiles = 1053,
        [Description("Map Ground Tar Movement Speed +%")]
        MapGroundTarMovementSpeedPosPct = 1054,
        [Description("Map Ground Effect Radius")]
        MapGroundEffectRadius = 1055,
        [Description("Map Ground Ice")]
        MapGroundIce = 1056,
        [Description("Map Chest Item Quantity +%")]
        MapChestItemQuantityPosPct = 1057,
        [Description("Map Chest Item Rarity +%")]
        MapChestItemRarityPosPct = 1058,
        [Description("Display Map No Monsters")]
        DisplayMapNoMonsters = 1059,
        [Description("Necromancer Additional Rarity Levels Can Be Raised")]
        NecromancerAdditionalRarityLevelsCanBeRaised = 1060,
        [Description("Monster Dropped Item Quantity From Numplayers +%")]
        MonsterDroppedItemQuantityFromNumplayersPosPct = 1061,
        [Description("Map Disable Chest Drop Scaling")]
        MapDisableChestDropScaling = 1062,
        [Description("Physical Damage Taken % As Fire")]
        PhysicalDamageTakenPctAsFire = 1063,
        [Description("Physical Damage Taken % As Cold")]
        PhysicalDamageTakenPctAsCold = 1064,
        [Description("Physical Damage Taken % As Lightning")]
        PhysicalDamageTakenPctAsLightning = 1065,
        [Description("Physical Damage Taken % As Chaos")]
        PhysicalDamageTakenPctAsChaos = 1066,
        [Description("Base Energy Shield Regeneration Rate Per Minute")]
        BaseEnergyShieldRegenerationRatePerMinute = 1067,
        [Description("Leech Energy Shield Instead Of Life")]
        LeechEnergyShieldInsteadOfLife = 1068,
        [Description("Energy Shield Regeneration Rate Per Minute")]
        EnergyShieldRegenerationRatePerMinute = 1069,
        [Description("Monster Uses Mass Power Text")]
        MonsterUsesMassPowerText = 1070,
        [Description("Monster Uses Mass Endurance Text")]
        MonsterUsesMassEnduranceText = 1071,
        [Description("Monster Uses Shockwave Text")]
        MonsterUsesShockwaveText = 1072,
        [Description("Unique Facebreaker Unarmed Physical Damage +% Final")]
        UniqueFacebreakerUnarmedPhysicalDamagePosPctFinal = 1073,
        [Description("Local Display Socketed Gems Get Increased Area Level")]
        LocalDisplaySocketedGemsGetIncreasedAreaLevel = 1074,
        [Description("Local Socketed Aura Gem Level +")]
        LocalSocketedAuraGemLevelPos = 1075,
        [Description("Extra Gore")]
        ExtraGore = 1076,
        [Description("Local One Socket Each Colour Only")]
        LocalOneSocketEachColourOnly = 1077,
        [Description("Life Reserved By Stat %")]
        LifeReservedByStatPct = 1078,
        [Description("Block While Dual Wielding Claws %")]
        BlockWhileDualWieldingClawsPct = 1079,
        [Description("Unique Chin Sol Close Range Bow Damage +% Final")]
        UniqueChinSolCloseRangeBowDamagePosPctFinal = 1080,
        [Description("Unique Chin Sol Close Range Knockback")]
        UniqueChinSolCloseRangeKnockback = 1081,
        [Description("Physical Damage Reduction Rating Against Projectiles")]
        PhysicalDamageReductionRatingAgainstProjectiles = 1082,
        [Description("Projectile Block %")]
        ProjectileBlockPct = 1083,
        [Description("Additional Block Chance Against Projectiles %")]
        AdditionalBlockChanceAgainstProjectilesPct = 1084,
        [Description("Physical Damage Reduction Rating +% Against Projectiles")]
        PhysicalDamageReductionRatingPosPctAgainstProjectiles = 1085,
        [Description("Spell Projectile Block %")]
        SpellProjectileBlockPct = 1086,
        [Description("Projectile Attack Block %")]
        ProjectileAttackBlockPct = 1087,
        [Description("Display Estimated Physical Damage Reduciton Against Projectiles %")]
        DisplayEstimatedPhysicalDamageReducitonAgainstProjectilesPct = 1088,
        [Description("Damage Taken Goes To Mana %")]
        DamageTakenGoesToManaPct = 1089,
        [Description("Evasion And Physical Damage Reduction Rating +%")]
        EvasionAndPhysicalDamageReductionRatingPosPct = 1090,
        [Description("Additional Item Drop Slots When Deleted On Death")]
        AdditionalItemDropSlotsWhenDeletedOnDeath = 1091,
        [Description("Mana Degeneration Per Minute")]
        ManaDegenerationPerMinute = 1092,
        [Description("Life Degeneration Per Minute")]
        LifeDegenerationPerMinute = 1093,
        [Description("Ice Shield Moving Mana Degeneration Per Minute")]
        IceShieldMovingManaDegenerationPerMinute = 1094,
        [Description("Unique Quill Rain Weapon Damage +% Final")]
        UniqueQuillRainWeaponDamagePosPctFinal = 1095,
        [Description("Melee Physical Damage Taken % To Deal To Attacker")]
        MeleePhysicalDamageTakenPctToDealToAttacker = 1096,
        [Description("Additional Block %")]
        AdditionalBlockPct = 1097,
        [Description("Frozen Monsters Take Increased Damage")]
        FrozenMonstersTakeIncreasedDamage = 1098,
        [Description("Local Display Socketed Gems Get Blood Magic Level")]
        LocalDisplaySocketedGemsGetBloodMagicLevel = 1099,
        [Description("Local Display Socketed Gems Have Blood Magic")]
        LocalDisplaySocketedGemsHaveBloodMagic = 1100,
        [Description("Monster Base Block %")]
        MonsterBaseBlockPct = 1101,
        [Description("Base Cannot Leech")]
        BaseCannotLeech = 1102,
        [Description("Keystone Vampirism")]
        KeystoneVampirism = 1103,
        [Description("Unique Dewaths Hide Physical Attack Damage Dealt -")]
        UniqueDewathsHidePhysicalAttackDamageDealtNeg = 1104,
        [Description("Local Strength Requirement +%")]
        LocalStrengthRequirementPosPct = 1105,
        [Description("Local Dexterity Requirement +%")]
        LocalDexterityRequirementPosPct = 1106,
        [Description("Local Intelligence Requirement +%")]
        LocalIntelligenceRequirementPosPct = 1107,
        [Description("Local Cannot Be Used With Chaos Innoculation")]
        LocalCannotBeUsedWithChaosInnoculation = 1108,
        [Description("Local Display Socketed Gems Have Mana Reservation +%")]
        LocalDisplaySocketedGemsHaveManaReservationPosPct = 1109,
        [Description("Mace Elemental Damage +%")]
        MaceElementalDamagePosPct = 1110,
        [Description("Active Skill Minion Movement Velocity +% Final")]
        ActiveSkillMinionMovementVelocityPosPctFinal = 1111,
        [Description("Movement Velocity +% Final For Minion")]
        MovementVelocityPosPctFinalForMinion = 1112,
        [Description("Movement Velocity Cap")]
        MovementVelocityCap = 1113,
        [Description("Display Minion Base Maximum Life")]
        DisplayMinionBaseMaximumLife = 1114,
        [Description("Display Minion Maximum Life")]
        DisplayMinionMaximumLife = 1115,
        [Description("Skill Physical Damage % To Convert To Fire")]
        SkillPhysicalDamagePctToConvertToFire = 1116,
        [Description("Skill Physical Damage % To Convert To Cold")]
        SkillPhysicalDamagePctToConvertToCold = 1117,
        [Description("Skill Physical Damage % To Convert To Lightning")]
        SkillPhysicalDamagePctToConvertToLightning = 1118,
        [Description("Skill Physical Damage % To Convert To Chaos")]
        SkillPhysicalDamagePctToConvertToChaos = 1119,
        [Description("Skill Cold Damage % To Convert To Fire")]
        SkillColdDamagePctToConvertToFire = 1120,
        [Description("Physical Damage % To Convert To Fire")]
        PhysicalDamagePctToConvertToFire = 1121,
        [Description("Physical Damage % To Convert To Cold")]
        PhysicalDamagePctToConvertToCold = 1122,
        [Description("Physical Damage % To Convert To Lightning")]
        PhysicalDamagePctToConvertToLightning = 1123,
        [Description("Physical Damage % To Convert To Chaos")]
        PhysicalDamagePctToConvertToChaos = 1124,
        [Description("Cold Damage % To Convert To Fire")]
        ColdDamagePctToConvertToFire = 1125,
        [Description("Main Hand Attack Duration Ms")]
        MainHandAttackDurationMs = 1126,
        [Description("Off Hand Attack Duration Ms")]
        OffHandAttackDurationMs = 1127,
        [Description("Spell Cast Time Ms")]
        SpellCastTimeMs = 1128,
        [Description("Cast Time Overrides Attack Duration")]
        CastTimeOverridesAttackDuration = 1129,
        [Description("Projectiles Fork")]
        ProjectilesFork = 1130,
        [Description("Base Skill Number Of Additional Hits")]
        BaseSkillNumberOfAdditionalHits = 1131,
        [Description("Skill Override Pvp Scaling Time Ms")]
        SkillOverridePvpScalingTimeMs = 1132,
        [Description("Skill Double Hits When Dual Wielding")]
        SkillDoubleHitsWhenDualWielding = 1133,
        [Description("Skill Number Of Additional Hits")]
        SkillNumberOfAdditionalHits = 1134,
        [Description("Trap Override Pvp Scaling Time Ms")]
        TrapOverridePvpScalingTimeMs = 1135,
        [Description("Mine Override Pvp Scaling Time Ms")]
        MineOverridePvpScalingTimeMs = 1136,
        [Description("Override Pvp Scaling Time Ms")]
        OverridePvpScalingTimeMs = 1137,
        [Description("Skill Display Number Of Totems Allowed")]
        SkillDisplayNumberOfTotemsAllowed = 1138,
        [Description("Skill Display Number Of Traps Allowed")]
        SkillDisplayNumberOfTrapsAllowed = 1139,
        [Description("Skill Display Number Of Remote Mines Allowed")]
        SkillDisplayNumberOfRemoteMinesAllowed = 1140,
        [Description("Energy Shield % Gained On Block")]
        EnergyShieldPctGainedOnBlock = 1141,
        [Description("Local Display Socketed Gems Get Added Chaos Damage Level")]
        LocalDisplaySocketedGemsGetAddedChaosDamageLevel = 1142,
        [Description("Projectiles Return")]
        ProjectilesReturn = 1143,
        [Description("Projectile Number To Split")]
        ProjectileNumberToSplit = 1144,
        [Description("Determination Aura Armour +% Final")]
        DeterminationAuraArmourPosPctFinal = 1145,
        [Description("Support Chain Hit Damage +% Final")]
        SupportChainHitDamagePosPctFinal = 1146,
        [Description("Support Split Projectile Damage +% Final")]
        SupportSplitProjectileDamagePosPctFinal = 1147,
        [Description("Support Return Projectile Damage +% Final")]
        SupportReturnProjectileDamagePosPctFinal = 1148,
        [Description("Support Fork Projectile Damage +% Final")]
        SupportForkProjectileDamagePosPctFinal = 1149,
        [Description("Energy Shield % Of Armour Rating Gained On Block")]
        EnergyShieldPctOfArmourRatingGainedOnBlock = 1150,
        [Description("Skeleton Duration +%")]
        SkeletonDurationPosPct = 1151,
        [Description("Local Poison On Hit")]
        LocalPoisonOnHit = 1152,
        [Description("Main Hand Local Poison On Hit")]
        MainHandLocalPoisonOnHit = 1153,
        [Description("Off Hand Local Poison On Hit")]
        OffHandLocalPoisonOnHit = 1154,
        [Description("On Low Mana")]
        OnLowMana = 1155,
        [Description("Spell Damage Taken +% When On Low Mana")]
        SpellDamageTakenPosPctWhenOnLowMana = 1156,
        [Description("Spell Damage Taken +%")]
        SpellDamageTakenPosPct = 1157,
        [Description("Evasion Rating + When On Full Life")]
        EvasionRatingPosWhenOnFullLife = 1158,
        [Description("Aura Effect On Self +%")]
        AuraEffectOnSelfPosPct = 1159,
        [Description("Minions Have Aura Effect +%")]
        MinionsHaveAuraEffectPosPct = 1160,
        [Description("Reflect Curses")]
        ReflectCurses = 1161,
        [Description("Global Critical Strike Chance +% While Holding Staff")]
        GlobalCriticalStrikeChancePosPctWhileHoldingStaff = 1162,
        [Description("Global Critical Strike Multiplier + While Holding Staff")]
        GlobalCriticalStrikeMultiplierPosWhileHoldingStaff = 1163,
        [Description("Secondary Damage Critical Strike Multiplier +")]
        SecondaryDamageCriticalStrikeMultiplierPos = 1164,
        [Description("Old Do Not Use Life Leech From Spell Damage %")]
        OldDoNotUseLifeLeechFromSpellDamagePct = 1165,
        [Description("Old Do Not Use Mana Leech From Spell Damage %")]
        OldDoNotUseManaLeechFromSpellDamagePct = 1166,
        [Description("Punishment Physical Damage % Reflected For Normal Monsters")]
        PunishmentPhysicalDamagePctReflectedForNormalMonsters = 1167,
        [Description("Punishment Physical Damage % Reflected For Magic Monsters")]
        PunishmentPhysicalDamagePctReflectedForMagicMonsters = 1168,
        [Description("Punishment Physical Damage % Reflected For Rare Monsters")]
        PunishmentPhysicalDamagePctReflectedForRareMonsters = 1169,
        [Description("Punishment Physical Damage % Reflected For Unique Monsters")]
        PunishmentPhysicalDamagePctReflectedForUniqueMonsters = 1170,
        [Description("Is Player Minion")]
        IsPlayerMinion = 1171,
        [Description("Local Flask Curse Immunity While Healing")]
        LocalFlaskCurseImmunityWhileHealing = 1172,
        [Description("Attacks Deal No Physical Damage")]
        AttacksDealNoPhysicalDamage = 1173,
        [Description("Whirling Blades Base Ground Fire Damage To Deal Per Minute")]
        WhirlingBladesBaseGroundFireDamageToDealPerMinute = 1174,
        [Description("Monster Casts Ethereal Knives Text")]
        MonsterCastsEtherealKnivesText = 1175,
        [Description("Monster Throws Beartraps Text")]
        MonsterThrowsBeartrapsText = 1176,
        [Description("Monster Casts Lightning Thorns Text")]
        MonsterCastsLightningThornsText = 1177,
        [Description("Monster Throws Fire Bombs Text")]
        MonsterThrowsFireBombsText = 1178,
        [Description("Monster Throws Caustic Bombs Text")]
        MonsterThrowsCausticBombsText = 1179,
        [Description("Monster Casts Freezing Pulse Text")]
        MonsterCastsFreezingPulseText = 1180,
        [Description("Monster Cleaves Text")]
        MonsterCleavesText = 1181,
        [Description("Monster Fires Ice Shot Arrows Text")]
        MonsterFiresIceShotArrowsText = 1182,
        [Description("Monster Casts Conductivity Text")]
        MonsterCastsConductivityText = 1183,
        [Description("Monster Casts Flammability Text")]
        MonsterCastsFlammabilityText = 1184,
        [Description("Monster Casts Augmented Fireballs Text")]
        MonsterCastsAugmentedFireballsText = 1185,
        [Description("Monster Channels Lightning Text")]
        MonsterChannelsLightningText = 1186,
        [Description("Monster Casts Arc Text")]
        MonsterCastsArcText = 1187,
        [Description("Monster Raises Zombies Text")]
        MonsterRaisesZombiesText = 1188,
        [Description("Monster Casts Ice Shield Text")]
        MonsterCastsIceShieldText = 1189,
        [Description("Monster Casts Unholy Fire Text")]
        MonsterCastsUnholyFireText = 1190,
        [Description("Physical Damage Taken +")]
        PhysicalDamageTakenPos = 1191,
        [Description("Fire Damage Taken +")]
        FireDamageTakenPos = 1192,
        [Description("Monster Gain Power Charge On Kin Death")]
        MonsterGainPowerChargeOnKinDeath = 1193,
        [Description("Monster Casts Discharge Text")]
        MonsterCastsDischargeText = 1194,
        [Description("Trap Variation")]
        TrapVariation = 1195,
        [Description("Number Of Water Elementals To Summon")]
        NumberOfWaterElementalsToSummon = 1196,
        [Description("Number Of Water Elementals Allowed")]
        NumberOfWaterElementalsAllowed = 1197,
        [Description("Display Summons Water Elementals Text")]
        DisplaySummonsWaterElementalsText = 1198,
        [Description("Shield Charge Remove Stun And Knockback")]
        ShieldChargeRemoveStunAndKnockback = 1199,
        [Description("Display Monster Uses Double Strike Text")]
        DisplayMonsterUsesDoubleStrikeText = 1200,
        [Description("Bleed On Hit Base Duration")]
        BleedOnHitBaseDuration = 1201,
        [Description("Display Monster Uses Whirling Blades Text")]
        DisplayMonsterUsesWhirlingBladesText = 1202,
        [Description("Cannot Be Stunned")]
        CannotBeStunned = 1203,
        [Description("Cannot Be Stunned When On Low Life")]
        CannotBeStunnedWhenOnLowLife = 1204,
        [Description("Display Monster Casts Lightning Warp Text")]
        DisplayMonsterCastsLightningWarpText = 1205,
        [Description("Display Golden Radiance")]
        DisplayGoldenRadiance = 1206,
        [Description("Display Monster Casts Frostbite Text")]
        DisplayMonsterCastsFrostbiteText = 1207,
        [Description("Cannot Be Converted Or Dominated")]
        CannotBeConvertedOrDominated = 1208,
        [Description("Map Hidden Monster Life +% Times 6 Final")]
        MapHiddenMonsterLifePosPctTimes6Final = 1209,
        [Description("Map Hidden Monster Damage +% Squared Final")]
        MapHiddenMonsterDamagePosPctSquaredFinal = 1210,
        [Description("Regenerate Energy Shield Instead Of Life")]
        RegenerateEnergyShieldInsteadOfLife = 1211,
        [Description("Damage Not From Skill User")]
        DamageNotFromSkillUser = 1212,
        [Description("Deal No Damage Yourself")]
        DealNoDamageYourself = 1213,
        [Description("Deal No Damage")]
        DealNoDamage = 1214,
        [Description("Disable Skill If Melee Attack")]
        DisableSkillIfMeleeAttack = 1215,
        [Description("Display Disable Melee Weapons")]
        DisplayDisableMeleeWeapons = 1216,
        [Description("Chaos Damage Does Not Bypass Energy Shield")]
        ChaosDamageDoesNotBypassEnergyShield = 1217,
        [Description("Cannot Cast Spells")]
        CannotCastSpells = 1218,
        [Description("Piety Transform Debuff Time Ms")]
        PietyTransformDebuffTimeMs = 1219,
        [Description("Cheat Override Blood Effect Level")]
        CheatOverrideBloodEffectLevel = 1220,
        [Description("Map Undead Monsters Get Up After X Seconds")]
        MapUndeadMonstersGetUpAfterXSeconds = 1221,
        [Description("Local Stun Threshold Reduction +%")]
        LocalStunThresholdReductionPosPct = 1222,
        [Description("Main Hand Local Stun Threshold Reduction +%")]
        MainHandLocalStunThresholdReductionPosPct = 1223,
        [Description("Off Hand Local Stun Threshold Reduction +%")]
        OffHandLocalStunThresholdReductionPosPct = 1224,
        [Description("Intermediary Maximum Life Including Chaos Innoculation")]
        IntermediaryMaximumLifeIncludingChaosInnoculation = 1225,
        [Description("Light Radius +%")]
        LightRadiusPosPct = 1226,
        [Description("Active Skill Cast Speed +% Final")]
        ActiveSkillCastSpeedPosPctFinal = 1227,
        [Description("Map Has X Waves Of Monsters")]
        MapHasXWavesOfMonsters = 1228,
        [Description("Map Has X Seconds Between Waves")]
        MapHasXSecondsBetweenWaves = 1229,
        [Description("Map Num Initial Wave Monsters")]
        MapNumInitialWaveMonsters = 1230,
        [Description("Map Wave Monster Increment")]
        MapWaveMonsterIncrement = 1231,
        [Description("Flamethrower Damage +% Per Stage Final")]
        FlamethrowerDamagePosPctPerStageFinal = 1232,
        [Description("Ground Tar On Take Crit Base Area Of Effect Radius")]
        GroundTarOnTakeCritBaseAreaOfEffectRadius = 1233,
        [Description("Ground Tar On Take Crit Duration Ms")]
        GroundTarOnTakeCritDurationMs = 1234,
        [Description("Ground Tar On Take Crit Monvement Speed Pluspercent")]
        GroundTarOnTakeCritMonvementSpeedPluspercent = 1235,
        [Description("Curse On Hit % Enfeeble")]
        CurseOnHitPctEnfeeble = 1236,
        [Description("Totem Art Variation")]
        TotemArtVariation = 1237,
        [Description("Spells Have Culling Strike")]
        SpellsHaveCullingStrike = 1238,
        [Description("Map Monsters Immune To A Random Status Ailment Or Stun")]
        MapMonstersImmuneToARandomStatusAilmentOrStun = 1239,
        [Description("Map Monster Melee Attacks Apply Random Curses")]
        MapMonsterMeleeAttacksApplyRandomCurses = 1240,
        [Description("Map Monsters Reflect Curses")]
        MapMonstersReflectCurses = 1241,
        [Description("Curse On Melee Hit % Random Curse")]
        CurseOnMeleeHitPctRandomCurse = 1242,
        [Description("Main Hand Maximum Attack Distance")]
        MainHandMaximumAttackDistance = 1243,
        [Description("Off Hand Maximum Attack Distance")]
        OffHandMaximumAttackDistance = 1244,
        [Description("Melee Range +")]
        MeleeRangePos = 1245,
        [Description("Cyclone Movement Speed +% Final")]
        CycloneMovementSpeedPosPctFinal = 1246,
        [Description("Local Display Socketed Gems Get Added Fire Damage Level")]
        LocalDisplaySocketedGemsGetAddedFireDamageLevel = 1247,
        [Description("Local Display Socketed Gems Get Cold To Fire Level")]
        LocalDisplaySocketedGemsGetColdToFireLevel = 1248,
        [Description("Local Display Socketed Gems Get Fire Penetration Level")]
        LocalDisplaySocketedGemsGetFirePenetrationLevel = 1249,
        [Description("Evasion Rating +% When On Low Life")]
        EvasionRatingPosPctWhenOnLowLife = 1250,
        [Description("Life Leech Is Instant")]
        LifeLeechIsInstant = 1251,
        [Description("Base Life Leech Is Instant")]
        BaseLifeLeechIsInstant = 1252,
        [Description("Support Multiple Attacks Melee Attack Speed +% Final")]
        SupportMultipleAttacksMeleeAttackSpeedPosPctFinal = 1253,
        [Description("Map Item Drop Rarity +%")]
        MapItemDropRarityPosPct = 1254,
        [Description("Life Gain Per Target")]
        LifeGainPerTarget = 1255,
        [Description("Local Life Leech Is Instant")]
        LocalLifeLeechIsInstant = 1256,
        [Description("Main Hand Local Life Leech Is Instant")]
        MainHandLocalLifeLeechIsInstant = 1257,
        [Description("Off Hand Local Life Leech Is Instant")]
        OffHandLocalLifeLeechIsInstant = 1258,
        [Description("Avoid Ignite % When On Low Life")]
        AvoidIgnitePctWhenOnLowLife = 1259,
        [Description("Fire Damage Resistance % When On Low Life")]
        FireDamageResistancePctWhenOnLowLife = 1260,
        [Description("Local Display Socketed Gems Get Elemental Proliferation Level")]
        LocalDisplaySocketedGemsGetElementalProliferationLevel = 1261,
        [Description("Melee Splash")]
        MeleeSplash = 1262,
        [Description("Support Melee Splash Damage +% Final")]
        SupportMeleeSplashDamagePosPctFinal = 1263,
        [Description("Support Melee Splash Damage +% Final For Splash")]
        SupportMeleeSplashDamagePosPctFinalForSplash = 1264,
        [Description("Add Power Charge On Critical Strike %")]
        AddPowerChargeOnCriticalStrikePct = 1265,
        [Description("Base Melee Attack Repeat Count")]
        BaseMeleeAttackRepeatCount = 1266,
        [Description("Attack Repeat Count")]
        AttackRepeatCount = 1267,
        [Description("Display Map Larger Maze")]
        DisplayMapLargerMaze = 1268,
        [Description("Display Map Restless Dead")]
        DisplayMapRestlessDead = 1269,
        [Description("Display Map Two Bosses")]
        DisplayMapTwoBosses = 1270,
        [Description("Display Map Large Chest")]
        DisplayMapLargeChest = 1271,
        [Description("Local Socketed Movement Gem Level +")]
        LocalSocketedMovementGemLevelPos = 1272,
        [Description("Map Projectile Speed +%")]
        MapProjectileSpeedPosPct = 1273,
        [Description("Map Player Projectile Damage +% Final")]
        MapPlayerProjectileDamagePosPctFinal = 1274,
        [Description("Projectile Damage +% Final From Map")]
        ProjectileDamagePosPctFinalFromMap = 1275,
        [Description("Support Multiple Attack Damage +% Final")]
        SupportMultipleAttackDamagePosPctFinal = 1276,
        [Description("Necromancer Revivable Even If Corpse Unusable")]
        NecromancerRevivableEvenIfCorpseUnusable = 1277,
        [Description("Local Six Linked White Sockets")]
        LocalSixLinkedWhiteSockets = 1278,
        [Description("Area Of Effect +% Per 20 Int")]
        AreaOfEffectPosPctPer20Int = 1279,
        [Description("Attack Speed +% Per 10 Dex")]
        AttackSpeedPosPctPer10Dex = 1280,
        [Description("Physical Weapon Damage +% Per 10 Str")]
        PhysicalWeaponDamagePosPctPer10Str = 1281,
        [Description("Chance To Dodge % Per Frenzy Charge")]
        ChanceToDodgePctPerFrenzyCharge = 1282,
        [Description("Gain Power Charge Per Enemy You Crit")]
        GainPowerChargePerEnemyYouCrit = 1283,
        [Description("Local Unique Tabula Rasa No Requirement Or Energy Shield")]
        LocalUniqueTabulaRasaNoRequirementOrEnergyShield = 1284,
        [Description("Map Wave Magic Increase")]
        MapWaveMagicIncrease = 1285,
        [Description("Local Display Socketed Gems Get Spell Totem Level")]
        LocalDisplaySocketedGemsGetSpellTotemLevel = 1286,
        [Description("Cannot Increase Quantity Of Dropped Items")]
        CannotIncreaseQuantityOfDroppedItems = 1287,
        [Description("Cannot Increase Rarity Of Dropped Items")]
        CannotIncreaseRarityOfDroppedItems = 1288,
        [Description("Killed Monster Dropped Item Rarity +%")]
        KilledMonsterDroppedItemRarityPosPct = 1289,
        [Description("Killed Monster Dropped Item Quantity +%")]
        KilledMonsterDroppedItemQuantityPosPct = 1290,
        [Description("Burning Damage Taken +%")]
        BurningDamageTakenPosPct = 1291,
        [Description("Curse Effect On Self +%")]
        CurseEffectOnSelfPosPct = 1292,
        [Description("Randomly Cursed When Totems Die Curse Level")]
        RandomlyCursedWhenTotemsDieCurseLevel = 1293,
        [Description("Maximum Physical Damage To Return When Hit")]
        MaximumPhysicalDamageToReturnWhenHit = 1294,
        [Description("Maximum Fire Damage To Return When Hit")]
        MaximumFireDamageToReturnWhenHit = 1295,
        [Description("Maximum Cold Damage To Return When Hit")]
        MaximumColdDamageToReturnWhenHit = 1296,
        [Description("Maximum Lightning Damage To Return When Hit")]
        MaximumLightningDamageToReturnWhenHit = 1297,
        [Description("Maximum Chaos Damage To Return When Hit")]
        MaximumChaosDamageToReturnWhenHit = 1298,
        [Description("Minimum Physical Damage To Return When Hit")]
        MinimumPhysicalDamageToReturnWhenHit = 1299,
        [Description("Minimum Fire Damage To Return When Hit")]
        MinimumFireDamageToReturnWhenHit = 1300,
        [Description("Minimum Cold Damage To Return When Hit")]
        MinimumColdDamageToReturnWhenHit = 1301,
        [Description("Minimum Lightning Damage To Return When Hit")]
        MinimumLightningDamageToReturnWhenHit = 1302,
        [Description("Minimum Chaos Damage To Return When Hit")]
        MinimumChaosDamageToReturnWhenHit = 1303,
        [Description("Local Display Socketed Gems Get Increased Duration Level")]
        LocalDisplaySocketedGemsGetIncreasedDurationLevel = 1304,
        [Description("Summon Fire Resistance +")]
        SummonFireResistancePos = 1305,
        [Description("Summon Cold Resistance +")]
        SummonColdResistancePos = 1306,
        [Description("Summon Lightning Resistance +")]
        SummonLightningResistancePos = 1307,
        [Description("Melee Weapon Critical Strike Multiplier +")]
        MeleeWeaponCriticalStrikeMultiplierPos = 1308,
        [Description("Map Monster Skills Chain X Additional Times")]
        MapMonsterSkillsChainXAdditionalTimes = 1309,
        [Description("Local Ring Disable Other Ring")]
        LocalRingDisableOtherRing = 1310,
        [Description("Disable Ring Slot 1")]
        DisableRingSlot1 = 1311,
        [Description("Disable Ring Slot 2")]
        DisableRingSlot2 = 1312,
        [Description("Global Item Attribute Requirements +%")]
        GlobalItemAttributeRequirementsPosPct = 1313,
        [Description("Grant Kill To Target When Exploding Self")]
        GrantKillToTargetWhenExplodingSelf = 1314,
        [Description("Mana Gain Per Target")]
        ManaGainPerTarget = 1315,
        [Description("Animation Effect Variation")]
        AnimationEffectVariation = 1316,
        [Description("Enemy Hits Roll Low Damage")]
        EnemyHitsRollLowDamage = 1317,
        [Description("Minions Take No Actions")]
        MinionsTakeNoActions = 1318,
        [Description("Unique Loris Lantern Golden Light")]
        UniqueLorisLanternGoldenLight = 1319,
        [Description("Chaos Damage Resistance % When On Low Life")]
        ChaosDamageResistancePctWhenOnLowLife = 1320,
        [Description("Gain Power Charge For Each Quarter Life Removed")]
        GainPowerChargeForEachQuarterLifeRemoved = 1321,
        [Description("Enemy Extra Damage Rolls")]
        EnemyExtraDamageRolls = 1322,
        [Description("Enemy Extra Damage Rolls When On Low Life")]
        EnemyExtraDamageRollsWhenOnLowLife = 1323,
        [Description("Map Fixed Seed")]
        MapFixedSeed = 1324,
        [Description("Map Monsters Drop Ground Fire On Death Base Radius")]
        MapMonstersDropGroundFireOnDeathBaseRadius = 1325,
        [Description("Map Monsters Drop Ground Fire On Death Duration Ms")]
        MapMonstersDropGroundFireOnDeathDurationMs = 1326,
        [Description("Map Monsters Drop Ground Fire On Death % Max Damage To Deal Per Minute")]
        MapMonstersDropGroundFireOnDeathPctMaxDamageToDealPerMinute = 1327,
        [Description("Map Monsters Convert All Physical Damage To Fire")]
        MapMonstersConvertAllPhysicalDamageToFire = 1328,
        [Description("Map Players Convert All Physical Damage To Fire")]
        MapPlayersConvertAllPhysicalDamageToFire = 1329,
        [Description("Local Display Socketed Gems Have Chance To Flee %")]
        LocalDisplaySocketedGemsHaveChanceToFleePct = 1330,
        [Description("Map No Refills In Town")]
        MapNoRefillsInTown = 1331,
        [Description("Base Minimum Lightning Damage On Charge Expiry")]
        BaseMinimumLightningDamageOnChargeExpiry = 1332,
        [Description("Base Maximum Lightning Damage On Charge Expiry")]
        BaseMaximumLightningDamageOnChargeExpiry = 1333,
        [Description("Item Drops On Death")]
        ItemDropsOnDeath = 1334,
        [Description("Map Minimap Revealed")]
        MapMinimapRevealed = 1335,
        [Description("Explode On Death % Main Hand Damage To Deal As Fire")]
        ExplodeOnDeathPctMainHandDamageToDealAsFire = 1336,
        [Description("Explode On Death % Main Hand Damage To Deal As Lightning")]
        ExplodeOnDeathPctMainHandDamageToDealAsLightning = 1337,
        [Description("Explode On Death % Main Hand Damage To Deal As Cold")]
        ExplodeOnDeathPctMainHandDamageToDealAsCold = 1338,
        [Description("Explode On Death % Main Hand Damage To Deal As Chaos")]
        ExplodeOnDeathPctMainHandDamageToDealAsChaos = 1339,
        [Description("Never Shock")]
        NeverShock = 1340,
        [Description("Never Freeze")]
        NeverFreeze = 1341,
        [Description("Faster Burn %")]
        FasterBurnPct = 1342,
        [Description("Disable Chest Slot")]
        DisableChestSlot = 1343,
        [Description("Local Display Socketed Gems Get Faster Attacks Level")]
        LocalDisplaySocketedGemsGetFasterAttacksLevel = 1344,
        [Description("Local Display Socketed Gems Get Melee Physical Damage Level")]
        LocalDisplaySocketedGemsGetMeleePhysicalDamageLevel = 1345,
        [Description("Flasks Dispel Burning")]
        FlasksDispelBurning = 1346,
        [Description("Physical Claw Damage +% When On Low Life")]
        PhysicalClawDamagePosPctWhenOnLowLife = 1347,
        [Description("Accuracy Rating +% When On Low Life")]
        AccuracyRatingPosPctWhenOnLowLife = 1348,
        [Description("Cannot Leech")]
        CannotLeech = 1349,
        [Description("Cannot Leech When On Low Life")]
        CannotLeechWhenOnLowLife = 1350,
        [Description("Base Cannot Leech Life")]
        BaseCannotLeechLife = 1351,
        [Description("Base Cannot Leech Mana")]
        BaseCannotLeechMana = 1352,
        [Description("Cannot Leech Life")]
        CannotLeechLife = 1353,
        [Description("Cannot Leech Mana")]
        CannotLeechMana = 1354,
        [Description("Base Energy Shield Gained On Enemy Death")]
        BaseEnergyShieldGainedOnEnemyDeath = 1355,
        [Description("Summon Totem Cast Speed +%")]
        SummonTotemCastSpeedPosPct = 1356,
        [Description("Consecrate On Block % Chance To Create")]
        ConsecrateOnBlockPctChanceToCreate = 1357,
        [Description("Consecrate On Block % Life Regen Per Minute")]
        ConsecrateOnBlockPctLifeRegenPerMinute = 1358,
        [Description("Consecrate On Block Base Radius")]
        ConsecrateOnBlockBaseRadius = 1359,
        [Description("Consecrate On Block Duration Ms")]
        ConsecrateOnBlockDurationMs = 1360,
        [Description("Desecrate On Block % Chance To Create")]
        DesecrateOnBlockPctChanceToCreate = 1361,
        [Description("Desecrate On Block Base Chaos Damage To Deal Per Minute")]
        DesecrateOnBlockBaseChaosDamageToDealPerMinute = 1362,
        [Description("Desecrate On Block Base Radius")]
        DesecrateOnBlockBaseRadius = 1363,
        [Description("Desecrate On Block Duration Ms")]
        DesecrateOnBlockDurationMs = 1364,
        [Description("Base Chaos Damage % Of Maximum Life Taken Per Minute Per Frenzy Charge")]
        BaseChaosDamagePctOfMaximumLifeTakenPerMinutePerFrenzyCharge = 1365,
        [Description("Add Frenzy Charge On Kill % Chance")]
        AddFrenzyChargeOnKillPctChance = 1366,
        [Description("Local Socketed Elemental Gem Level +")]
        LocalSocketedElementalGemLevelPos = 1367,
        [Description("Melee Critical Strike Chance +%")]
        MeleeCriticalStrikeChancePosPct = 1368,
        [Description("Melee Critical Strike Chance +% When On Full Life")]
        MeleeCriticalStrikeChancePosPctWhenOnFullLife = 1369,
        [Description("Cannot Be Killed By Elemental Reflect")]
        CannotBeKilledByElementalReflect = 1370,
        [Description("Local Display Socketed Gems Get Added Lightning Damage Level")]
        LocalDisplaySocketedGemsGetAddedLightningDamageLevel = 1371,
        [Description("Map Is Unidentified")]
        MapIsUnidentified = 1372,
        [Description("Melee Attacks Usable Without Mana Cost")]
        MeleeAttacksUsableWithoutManaCost = 1373,
        [Description("Melee Attack Mana Cost +")]
        MeleeAttackManaCostPos = 1374,
        [Description("Melee Damage +%")]
        MeleeDamagePosPct = 1375,
        [Description("Melee Damage Taken +%")]
        MeleeDamageTakenPosPct = 1376,
        [Description("Map Experience Gain +%")]
        MapExperienceGainPosPct = 1377,
        [Description("Life Gained On Block")]
        LifeGainedOnBlock = 1378,
        [Description("Mana Gained On Block")]
        ManaGainedOnBlock = 1379,
        [Description("Minimum Physical Damage To Return On Block")]
        MinimumPhysicalDamageToReturnOnBlock = 1380,
        [Description("Maximum Physical Damage To Return On Block")]
        MaximumPhysicalDamageToReturnOnBlock = 1381,
        [Description("Footstep Effect Variation")]
        FootstepEffectVariation = 1382,
        [Description("Zombie Maximum Life +")]
        ZombieMaximumLifePos = 1383,
        [Description("Number Of Zombies Allowed +%")]
        NumberOfZombiesAllowedPosPct = 1384,
        [Description("Zombie Chaos Elemental Damage Resistance %")]
        ZombieChaosElementalDamageResistancePct = 1385,
        [Description("Chill And Freeze Duration Based On % Energy Shield")]
        ChillAndFreezeDurationBasedOnPctEnergyShield = 1386,
        [Description("Number Of Equipped Uniques")]
        NumberOfEquippedUniques = 1387,
        [Description("Intelligence +% Per Equipped Unique")]
        IntelligencePosPctPerEquippedUnique = 1388,
        [Description("Ignited Enemies Explode On Kill")]
        IgnitedEnemiesExplodeOnKill = 1389,
        [Description("Additional Scroll Of Wisdom Drop Chance %")]
        AdditionalScrollOfWisdomDropChancePct = 1390,
        [Description("Explode On Kill % Fire Damage To Deal")]
        ExplodeOnKillPctFireDamageToDeal = 1391,
        [Description("Zombie Explode On Kill % Fire Damage To Deal")]
        ZombieExplodeOnKillPctFireDamageToDeal = 1392,
        [Description("Local Unique Flask Item Rarity +% While Healing")]
        LocalUniqueFlaskItemRarityPosPctWhileHealing = 1393,
        [Description("Local Unique Flask Item Quantity +% While Healing")]
        LocalUniqueFlaskItemQuantityPosPctWhileHealing = 1394,
        [Description("Local Unique Flask Light Radius +% While Healing")]
        LocalUniqueFlaskLightRadiusPosPctWhileHealing = 1395,
        [Description("Local Unique Flask Additional Maximum All Elemental Resistances % While Healing")]
        LocalUniqueFlaskAdditionalMaximumAllElementalResistancesPctWhileHealing = 1396,
        [Description("Additional Strength And Intelligence")]
        AdditionalStrengthAndIntelligence = 1397,
        [Description("Additional Strength And Dexterity")]
        AdditionalStrengthAndDexterity = 1398,
        [Description("Additional Dexterity And Intelligence")]
        AdditionalDexterityAndIntelligence = 1399,
        [Description("Curse Effect +%")]
        CurseEffectPosPct = 1400,
        [Description("Nonfunctional Old Stat Map Monster Movement Velocity Cap")]
        NonfunctionalOldStatMapMonsterMovementVelocityCap = 1401,
        [Description("Movement Velocity +% While Cursed")]
        MovementVelocityPosPctWhileCursed = 1402,
        [Description("Map Spawn Exile Per Area %")]
        MapSpawnExilePerAreaPct = 1403,
        [Description("Cyclone Extra Distance")]
        CycloneExtraDistance = 1404,
        [Description("Zombie Boss Extract Life % To Gain")]
        ZombieBossExtractLifePctToGain = 1405,
        [Description("Life Regeneration Rate Per Minute % Per Frenzy Charge")]
        LifeRegenerationRatePerMinutePctPerFrenzyCharge = 1406,
        [Description("Enemy On Low Life Damage Taken +% Per Frenzy Charge")]
        EnemyOnLowLifeDamageTakenPosPctPerFrenzyCharge = 1407,
        [Description("Movement Velocity +% Per Ten Levels")]
        MovementVelocityPosPctPerTenLevels = 1408,
        [Description("Enemy On Low Life Damage Taken +%")]
        EnemyOnLowLifeDamageTakenPosPct = 1409,
        [Description("Add Power Charge On Kill % Chance")]
        AddPowerChargeOnKillPctChance = 1410,
        [Description("Gain Endurance Charge On Power Charge Expiry")]
        GainEnduranceChargeOnPowerChargeExpiry = 1411,
        [Description("Melee Damage +% When On Full Life")]
        MeleeDamagePosPctWhenOnFullLife = 1412,
        [Description("Consecrate On Crit % Chance To Create")]
        ConsecrateOnCritPctChanceToCreate = 1413,
        [Description("Projectile Speed +%")]
        ProjectileSpeedPosPct = 1414,
        [Description("Projectile Speed +% Per Frenzy Charge")]
        ProjectileSpeedPosPctPerFrenzyCharge = 1415,
        [Description("Projectile Damage +% Per Power Charge")]
        ProjectileDamagePosPctPerPowerCharge = 1416,
        [Description("Killed Monster Dropped Item Rarity +% On Crit")]
        KilledMonsterDroppedItemRarityPosPctOnCrit = 1417,
        [Description("Onslaught Buff Duration On Kill Ms")]
        OnslaughtBuffDurationOnKillMs = 1418,
        [Description("Local Right Ring Slot No Mana Regeneration")]
        LocalRightRingSlotNoManaRegeneration = 1419,
        [Description("Local Right Ring Slot Base Energy Shield Regeneration Rate Per Minute %")]
        LocalRightRingSlotBaseEnergyShieldRegenerationRatePerMinutePct = 1420,
        [Description("Local Left Ring Slot Mana Regeneration Rate +%")]
        LocalLeftRingSlotManaRegenerationRatePosPct = 1421,
        [Description("Local Left Ring Slot No Energy Shield Recharge Or Regeneration")]
        LocalLeftRingSlotNoEnergyShieldRechargeOrRegeneration = 1422,
        [Description("No Energy Shield Recharge Or Regeneration")]
        NoEnergyShieldRechargeOrRegeneration = 1423,
        [Description("Base Energy Shield Regeneration Rate Per Minute %")]
        BaseEnergyShieldRegenerationRatePerMinutePct = 1424,
        [Description("Character Sheet Monster Level")]
        CharacterSheetMonsterLevel = 1425,
        [Description("Keystone Acrobatics Energy Shield +% Final")]
        KeystoneAcrobaticsEnergyShieldPosPctFinal = 1426,
        [Description("Keystone Acrobatics Physical Damage Reduction Rating +% Final")]
        KeystoneAcrobaticsPhysicalDamageReductionRatingPosPctFinal = 1427,
        [Description("Life Recovery Per Minute From Leech")]
        LifeRecoveryPerMinuteFromLeech = 1428,
        [Description("Mana Recovery Per Minute From Leech")]
        ManaRecoveryPerMinuteFromLeech = 1429,
        [Description("Energy Shield Recovery Per Minute From Leech")]
        EnergyShieldRecoveryPerMinuteFromLeech = 1430,
        [Description("Life Recovery Per Minute")]
        LifeRecoveryPerMinute = 1431,
        [Description("Mana Recovery Per Minute")]
        ManaRecoveryPerMinute = 1432,
        [Description("Energy Shield Recovery Per Minute")]
        EnergyShieldRecoveryPerMinute = 1433,
        [Description("Extra Critical Rolls")]
        ExtraCriticalRolls = 1434,
        [Description("Combined All Damage +%")]
        CombinedAllDamagePosPct = 1435,
        [Description("Combined All Damage +% Final")]
        CombinedAllDamagePosPctFinal = 1436,
        [Description("Combined Spell All Damage +%")]
        CombinedSpellAllDamagePosPct = 1437,
        [Description("Combined Spell All Damage +% Final")]
        CombinedSpellAllDamagePosPctFinal = 1438,
        [Description("Combined Attack All Damage +%")]
        CombinedAttackAllDamagePosPct = 1439,
        [Description("Combined Attack All Damage +% Final")]
        CombinedAttackAllDamagePosPctFinal = 1440,
        [Description("Combined Main Hand Attack All Damage +%")]
        CombinedMainHandAttackAllDamagePosPct = 1441,
        [Description("Combined Off Hand Attack All Damage +%")]
        CombinedOffHandAttackAllDamagePosPct = 1442,
        [Description("Combined Physical Damage +%")]
        CombinedPhysicalDamagePosPct = 1443,
        [Description("Combined Physical Damage +% Final")]
        CombinedPhysicalDamagePosPctFinal = 1444,
        [Description("Combined Attack Physical Damage +%")]
        CombinedAttackPhysicalDamagePosPct = 1445,
        [Description("Combined Attack Physical Damage +% Final")]
        CombinedAttackPhysicalDamagePosPctFinal = 1446,
        [Description("Combined Main Hand Attack Physical Damage +%")]
        CombinedMainHandAttackPhysicalDamagePosPct = 1447,
        [Description("Combined Off Hand Attack Physical Damage +%")]
        CombinedOffHandAttackPhysicalDamagePosPct = 1448,
        [Description("Combined Main Hand Attack Physical Damage +% Final")]
        CombinedMainHandAttackPhysicalDamagePosPctFinal = 1449,
        [Description("Combined Off Hand Attack Physical Damage +% Final")]
        CombinedOffHandAttackPhysicalDamagePosPctFinal = 1450,
        [Description("Combined Fire Damage +%")]
        CombinedFireDamagePosPct = 1451,
        [Description("Combined Fire Damage +% Final")]
        CombinedFireDamagePosPctFinal = 1452,
        [Description("Combined Cold Damage +%")]
        CombinedColdDamagePosPct = 1453,
        [Description("Combined Cold Damage +% Final")]
        CombinedColdDamagePosPctFinal = 1454,
        [Description("Combined Lightning Damage +%")]
        CombinedLightningDamagePosPct = 1455,
        [Description("Combined Lightning Damage +% Final")]
        CombinedLightningDamagePosPctFinal = 1456,
        [Description("Combined Chaos Damage +%")]
        CombinedChaosDamagePosPct = 1457,
        [Description("Combined Chaos Damage +% Final")]
        CombinedChaosDamagePosPctFinal = 1458,
        [Description("Combined Elemental Damage +%")]
        CombinedElementalDamagePosPct = 1459,
        [Description("Combined Elemental Damage +% Final")]
        CombinedElementalDamagePosPctFinal = 1460,
        [Description("Combined Attack Fire Damage +%")]
        CombinedAttackFireDamagePosPct = 1461,
        [Description("Combined Attack Cold Damage +%")]
        CombinedAttackColdDamagePosPct = 1462,
        [Description("Combined Attack Cold Damage +% Final")]
        CombinedAttackColdDamagePosPctFinal = 1463,
        [Description("Combined Spell Fire Damage +%")]
        CombinedSpellFireDamagePosPct = 1464,
        [Description("Combined Spell Cold Damage +%")]
        CombinedSpellColdDamagePosPct = 1465,
        [Description("Combined Spell Lightning Damage +%")]
        CombinedSpellLightningDamagePosPct = 1466,
        [Description("Combined Spell Lightning Damage +% Final")]
        CombinedSpellLightningDamagePosPctFinal = 1467,
        [Description("Combined Spell Elemental Damage +%")]
        CombinedSpellElementalDamagePosPct = 1468,
        [Description("Combined Spell Elemental Damage +% Final")]
        CombinedSpellElementalDamagePosPctFinal = 1469,
        [Description("Combined Main Hand Attack Elemental Damage +%")]
        CombinedMainHandAttackElementalDamagePosPct = 1470,
        [Description("Combined Off Hand Attack Elemental Damage +%")]
        CombinedOffHandAttackElementalDamagePosPct = 1471,
        [Description("Combined Main Hand Attack Elemental Damage +% Final")]
        CombinedMainHandAttackElementalDamagePosPctFinal = 1472,
        [Description("Combined Off Hand Attack Elemental Damage +% Final")]
        CombinedOffHandAttackElementalDamagePosPctFinal = 1473,
        [Description("Combined Main Hand Attack Fire Damage +%")]
        CombinedMainHandAttackFireDamagePosPct = 1474,
        [Description("Combined Off Hand Attack Fire Damage +%")]
        CombinedOffHandAttackFireDamagePosPct = 1475,
        [Description("Combined Main Hand Attack Cold Damage +%")]
        CombinedMainHandAttackColdDamagePosPct = 1476,
        [Description("Combined Off Hand Attack Cold Damage +%")]
        CombinedOffHandAttackColdDamagePosPct = 1477,
        [Description("Combined Main Hand Attack Lightning Damage +%")]
        CombinedMainHandAttackLightningDamagePosPct = 1478,
        [Description("Combined Off Hand Attack Lightning Damage +%")]
        CombinedOffHandAttackLightningDamagePosPct = 1479,
        [Description("Combined Main Hand Attack Chaos Damage +%")]
        CombinedMainHandAttackChaosDamagePosPct = 1480,
        [Description("Combined Off Hand Attack Chaos Damage +%")]
        CombinedOffHandAttackChaosDamagePosPct = 1481,
        [Description("Spell Minimum Base Physical Damage")]
        SpellMinimumBasePhysicalDamage = 1482,
        [Description("Spell Maximum Base Physical Damage")]
        SpellMaximumBasePhysicalDamage = 1483,
        [Description("Spell Minimum Base Fire Damage")]
        SpellMinimumBaseFireDamage = 1484,
        [Description("Spell Maximum Base Fire Damage")]
        SpellMaximumBaseFireDamage = 1485,
        [Description("Spell Minimum Base Cold Damage")]
        SpellMinimumBaseColdDamage = 1486,
        [Description("Spell Maximum Base Cold Damage")]
        SpellMaximumBaseColdDamage = 1487,
        [Description("Spell Minimum Base Lightning Damage")]
        SpellMinimumBaseLightningDamage = 1488,
        [Description("Spell Maximum Base Lightning Damage")]
        SpellMaximumBaseLightningDamage = 1489,
        [Description("Spell Minimum Base Chaos Damage")]
        SpellMinimumBaseChaosDamage = 1490,
        [Description("Spell Maximum Base Chaos Damage")]
        SpellMaximumBaseChaosDamage = 1491,
        [Description("Is Projectile")]
        IsProjectile = 1492,
        [Description("Attack Is Melee")]
        AttackIsMelee = 1493,
        [Description("Base Lightning Damage % To Convert To Fire")]
        BaseLightningDamagePctToConvertToFire = 1494,
        [Description("Base Lightning Damage % To Convert To Cold")]
        BaseLightningDamagePctToConvertToCold = 1495,
        [Description("Base Fire Damage % To Convert To Chaos")]
        BaseFireDamagePctToConvertToChaos = 1496,
        [Description("Base Cold Damage % To Convert To Chaos")]
        BaseColdDamagePctToConvertToChaos = 1497,
        [Description("Base Lightning Damage % To Convert To Chaos")]
        BaseLightningDamagePctToConvertToChaos = 1498,
        [Description("Skill Lightning Damage % To Convert To Fire")]
        SkillLightningDamagePctToConvertToFire = 1499,
        [Description("Skill Lightning Damage % To Convert To Cold")]
        SkillLightningDamagePctToConvertToCold = 1500,
        [Description("Skill Fire Damage % To Convert To Chaos")]
        SkillFireDamagePctToConvertToChaos = 1501,
        [Description("Skill Cold Damage % To Convert To Chaos")]
        SkillColdDamagePctToConvertToChaos = 1502,
        [Description("Skill Lightning Damage % To Convert To Chaos")]
        SkillLightningDamagePctToConvertToChaos = 1503,
        [Description("Lightning Damage % To Convert To Fire")]
        LightningDamagePctToConvertToFire = 1504,
        [Description("Lightning Damage % To Convert To Cold")]
        LightningDamagePctToConvertToCold = 1505,
        [Description("Fire Damage % To Convert To Chaos")]
        FireDamagePctToConvertToChaos = 1506,
        [Description("Cold Damage % To Convert To Chaos")]
        ColdDamagePctToConvertToChaos = 1507,
        [Description("Lightning Damage % To Convert To Chaos")]
        LightningDamagePctToConvertToChaos = 1508,
        [Description("Physical Damage % Lost To Conversion")]
        PhysicalDamagePctLostToConversion = 1509,
        [Description("Fire Damage % Lost To Conversion")]
        FireDamagePctLostToConversion = 1510,
        [Description("Cold Damage % Lost To Conversion")]
        ColdDamagePctLostToConversion = 1511,
        [Description("Lightning Damage % Lost To Conversion")]
        LightningDamagePctLostToConversion = 1512,
        [Description("Chaos Damage % Lost To Conversion")]
        ChaosDamagePctLostToConversion = 1513,
        [Description("Fire Damage % To Add As Chaos")]
        FireDamagePctToAddAsChaos = 1514,
        [Description("Cold Damage % To Add As Fire")]
        ColdDamagePctToAddAsFire = 1515,
        [Description("Cold Damage % To Add As Chaos")]
        ColdDamagePctToAddAsChaos = 1516,
        [Description("Lightning Damage % To Add As Fire")]
        LightningDamagePctToAddAsFire = 1517,
        [Description("Lightning Damage % To Add As Cold")]
        LightningDamagePctToAddAsCold = 1518,
        [Description("Lightning Damage % To Add As Chaos")]
        LightningDamagePctToAddAsChaos = 1519,
        [Description("Total Physical Damage % As Fire")]
        TotalPhysicalDamagePctAsFire = 1520,
        [Description("Total Physical Damage % As Cold")]
        TotalPhysicalDamagePctAsCold = 1521,
        [Description("Total Physical Damage % As Lightning")]
        TotalPhysicalDamagePctAsLightning = 1522,
        [Description("Total Physical Damage % As Chaos")]
        TotalPhysicalDamagePctAsChaos = 1523,
        [Description("Total Lightning Damage % As Fire")]
        TotalLightningDamagePctAsFire = 1524,
        [Description("Total Lightning Damage % As Cold")]
        TotalLightningDamagePctAsCold = 1525,
        [Description("Total Lightning Damage % As Chaos")]
        TotalLightningDamagePctAsChaos = 1526,
        [Description("Total Cold Damage % As Fire")]
        TotalColdDamagePctAsFire = 1527,
        [Description("Total Cold Damage % As Chaos")]
        TotalColdDamagePctAsChaos = 1528,
        [Description("Total Fire Damage % As Chaos")]
        TotalFireDamagePctAsChaos = 1529,
        [Description("Secondary Minimum Base Physical Damage")]
        SecondaryMinimumBasePhysicalDamage = 1530,
        [Description("Secondary Maximum Base Physical Damage")]
        SecondaryMaximumBasePhysicalDamage = 1531,
        [Description("Secondary Minimum Base Fire Damage")]
        SecondaryMinimumBaseFireDamage = 1532,
        [Description("Secondary Maximum Base Fire Damage")]
        SecondaryMaximumBaseFireDamage = 1533,
        [Description("Secondary Minimum Base Cold Damage")]
        SecondaryMinimumBaseColdDamage = 1534,
        [Description("Secondary Maximum Base Cold Damage")]
        SecondaryMaximumBaseColdDamage = 1535,
        [Description("Secondary Minimum Base Lightning Damage")]
        SecondaryMinimumBaseLightningDamage = 1536,
        [Description("Secondary Maximum Base Lightning Damage")]
        SecondaryMaximumBaseLightningDamage = 1537,
        [Description("Secondary Minimum Base Chaos Damage")]
        SecondaryMinimumBaseChaosDamage = 1538,
        [Description("Secondary Maximum Base Chaos Damage")]
        SecondaryMaximumBaseChaosDamage = 1539,
        [Description("Spell Total Minimum Base Physical Damage")]
        SpellTotalMinimumBasePhysicalDamage = 1540,
        [Description("Spell Total Maximum Base Physical Damage")]
        SpellTotalMaximumBasePhysicalDamage = 1541,
        [Description("Spell Total Minimum Base Fire Damage")]
        SpellTotalMinimumBaseFireDamage = 1542,
        [Description("Spell Total Maximum Base Fire Damage")]
        SpellTotalMaximumBaseFireDamage = 1543,
        [Description("Spell Total Minimum Base Cold Damage")]
        SpellTotalMinimumBaseColdDamage = 1544,
        [Description("Spell Total Maximum Base Cold Damage")]
        SpellTotalMaximumBaseColdDamage = 1545,
        [Description("Spell Total Minimum Base Lightning Damage")]
        SpellTotalMinimumBaseLightningDamage = 1546,
        [Description("Spell Total Maximum Base Lightning Damage")]
        SpellTotalMaximumBaseLightningDamage = 1547,
        [Description("Spell Total Minimum Base Chaos Damage")]
        SpellTotalMinimumBaseChaosDamage = 1548,
        [Description("Spell Total Maximum Base Chaos Damage")]
        SpellTotalMaximumBaseChaosDamage = 1549,
        [Description("Spell Total Minimum Added Physical Damage")]
        SpellTotalMinimumAddedPhysicalDamage = 1550,
        [Description("Spell Total Maximum Added Physical Damage")]
        SpellTotalMaximumAddedPhysicalDamage = 1551,
        [Description("Spell Total Minimum Added Fire Damage")]
        SpellTotalMinimumAddedFireDamage = 1552,
        [Description("Spell Total Maximum Added Fire Damage")]
        SpellTotalMaximumAddedFireDamage = 1553,
        [Description("Spell Total Minimum Added Cold Damage")]
        SpellTotalMinimumAddedColdDamage = 1554,
        [Description("Spell Total Maximum Added Cold Damage")]
        SpellTotalMaximumAddedColdDamage = 1555,
        [Description("Spell Total Minimum Added Lightning Damage")]
        SpellTotalMinimumAddedLightningDamage = 1556,
        [Description("Spell Total Maximum Added Lightning Damage")]
        SpellTotalMaximumAddedLightningDamage = 1557,
        [Description("Spell Total Minimum Added Chaos Damage")]
        SpellTotalMinimumAddedChaosDamage = 1558,
        [Description("Spell Total Maximum Added Chaos Damage")]
        SpellTotalMaximumAddedChaosDamage = 1559,
        [Description("Main Hand Total Minimum Base Physical Damage")]
        MainHandTotalMinimumBasePhysicalDamage = 1560,
        [Description("Main Hand Total Maximum Base Physical Damage")]
        MainHandTotalMaximumBasePhysicalDamage = 1561,
        [Description("Main Hand Total Minimum Base Fire Damage")]
        MainHandTotalMinimumBaseFireDamage = 1562,
        [Description("Main Hand Total Maximum Base Fire Damage")]
        MainHandTotalMaximumBaseFireDamage = 1563,
        [Description("Main Hand Total Minimum Base Cold Damage")]
        MainHandTotalMinimumBaseColdDamage = 1564,
        [Description("Main Hand Total Maximum Base Cold Damage")]
        MainHandTotalMaximumBaseColdDamage = 1565,
        [Description("Main Hand Total Minimum Base Lightning Damage")]
        MainHandTotalMinimumBaseLightningDamage = 1566,
        [Description("Main Hand Total Maximum Base Lightning Damage")]
        MainHandTotalMaximumBaseLightningDamage = 1567,
        [Description("Main Hand Total Minimum Base Chaos Damage")]
        MainHandTotalMinimumBaseChaosDamage = 1568,
        [Description("Main Hand Total Maximum Base Chaos Damage")]
        MainHandTotalMaximumBaseChaosDamage = 1569,
        [Description("Main Hand Total Minimum Added Physical Damage")]
        MainHandTotalMinimumAddedPhysicalDamage = 1570,
        [Description("Main Hand Total Maximum Added Physical Damage")]
        MainHandTotalMaximumAddedPhysicalDamage = 1571,
        [Description("Main Hand Total Minimum Added Fire Damage")]
        MainHandTotalMinimumAddedFireDamage = 1572,
        [Description("Main Hand Total Maximum Added Fire Damage")]
        MainHandTotalMaximumAddedFireDamage = 1573,
        [Description("Main Hand Total Minimum Added Cold Damage")]
        MainHandTotalMinimumAddedColdDamage = 1574,
        [Description("Main Hand Total Maximum Added Cold Damage")]
        MainHandTotalMaximumAddedColdDamage = 1575,
        [Description("Main Hand Total Minimum Added Lightning Damage")]
        MainHandTotalMinimumAddedLightningDamage = 1576,
        [Description("Main Hand Total Maximum Added Lightning Damage")]
        MainHandTotalMaximumAddedLightningDamage = 1577,
        [Description("Main Hand Total Minimum Added Chaos Damage")]
        MainHandTotalMinimumAddedChaosDamage = 1578,
        [Description("Main Hand Total Maximum Added Chaos Damage")]
        MainHandTotalMaximumAddedChaosDamage = 1579,
        [Description("Off Hand Total Minimum Base Physical Damage")]
        OffHandTotalMinimumBasePhysicalDamage = 1580,
        [Description("Off Hand Total Maximum Base Physical Damage")]
        OffHandTotalMaximumBasePhysicalDamage = 1581,
        [Description("Off Hand Total Minimum Base Fire Damage")]
        OffHandTotalMinimumBaseFireDamage = 1582,
        [Description("Off Hand Total Maximum Base Fire Damage")]
        OffHandTotalMaximumBaseFireDamage = 1583,
        [Description("Off Hand Total Minimum Base Cold Damage")]
        OffHandTotalMinimumBaseColdDamage = 1584,
        [Description("Off Hand Total Maximum Base Cold Damage")]
        OffHandTotalMaximumBaseColdDamage = 1585,
        [Description("Off Hand Total Minimum Base Lightning Damage")]
        OffHandTotalMinimumBaseLightningDamage = 1586,
        [Description("Off Hand Total Maximum Base Lightning Damage")]
        OffHandTotalMaximumBaseLightningDamage = 1587,
        [Description("Off Hand Total Minimum Base Chaos Damage")]
        OffHandTotalMinimumBaseChaosDamage = 1588,
        [Description("Off Hand Total Maximum Base Chaos Damage")]
        OffHandTotalMaximumBaseChaosDamage = 1589,
        [Description("Off Hand Total Minimum Added Physical Damage")]
        OffHandTotalMinimumAddedPhysicalDamage = 1590,
        [Description("Off Hand Total Maximum Added Physical Damage")]
        OffHandTotalMaximumAddedPhysicalDamage = 1591,
        [Description("Off Hand Total Minimum Added Fire Damage")]
        OffHandTotalMinimumAddedFireDamage = 1592,
        [Description("Off Hand Total Maximum Added Fire Damage")]
        OffHandTotalMaximumAddedFireDamage = 1593,
        [Description("Off Hand Total Minimum Added Cold Damage")]
        OffHandTotalMinimumAddedColdDamage = 1594,
        [Description("Off Hand Total Maximum Added Cold Damage")]
        OffHandTotalMaximumAddedColdDamage = 1595,
        [Description("Off Hand Total Minimum Added Lightning Damage")]
        OffHandTotalMinimumAddedLightningDamage = 1596,
        [Description("Off Hand Total Maximum Added Lightning Damage")]
        OffHandTotalMaximumAddedLightningDamage = 1597,
        [Description("Off Hand Total Minimum Added Chaos Damage")]
        OffHandTotalMinimumAddedChaosDamage = 1598,
        [Description("Off Hand Total Maximum Added Chaos Damage")]
        OffHandTotalMaximumAddedChaosDamage = 1599,
        [Description("Spell Minimum Added Physical Damage")]
        SpellMinimumAddedPhysicalDamage = 1600,
        [Description("Spell Maximum Added Physical Damage")]
        SpellMaximumAddedPhysicalDamage = 1601,
        [Description("Spell Minimum Added Fire Damage")]
        SpellMinimumAddedFireDamage = 1602,
        [Description("Spell Maximum Added Fire Damage")]
        SpellMaximumAddedFireDamage = 1603,
        [Description("Spell Minimum Added Cold Damage")]
        SpellMinimumAddedColdDamage = 1604,
        [Description("Spell Maximum Added Cold Damage")]
        SpellMaximumAddedColdDamage = 1605,
        [Description("Spell Minimum Added Lightning Damage")]
        SpellMinimumAddedLightningDamage = 1606,
        [Description("Spell Maximum Added Lightning Damage")]
        SpellMaximumAddedLightningDamage = 1607,
        [Description("Spell Minimum Added Chaos Damage")]
        SpellMinimumAddedChaosDamage = 1608,
        [Description("Spell Maximum Added Chaos Damage")]
        SpellMaximumAddedChaosDamage = 1609,
        [Description("Total Base Life Regeneration Rate Per Minute %")]
        TotalBaseLifeRegenerationRatePerMinutePct = 1610,
        [Description("Total Base Life Regeneration Rate Per Minute")]
        TotalBaseLifeRegenerationRatePerMinute = 1611,
        [Description("Total Base Maximum Energy Shield")]
        TotalBaseMaximumEnergyShield = 1612,
        [Description("Combined Energy Shield +%")]
        CombinedEnergyShieldPosPct = 1613,
        [Description("Combined Energy Shield From Shield +%")]
        CombinedEnergyShieldFromShieldPosPct = 1614,
        [Description("Combined Energy Shield +% Final")]
        CombinedEnergyShieldPosPctFinal = 1615,
        [Description("Total Base Evasion Rating")]
        TotalBaseEvasionRating = 1616,
        [Description("Combined Evasion Rating +%")]
        CombinedEvasionRatingPosPct = 1617,
        [Description("Combined Evasion Rating From Shield +%")]
        CombinedEvasionRatingFromShieldPosPct = 1618,
        [Description("Movement Velocity +1% Per X Evasion Rating")]
        MovementVelocityPos1PctPerXEvasionRating = 1619,
        [Description("Local Display Socketed Gems Have % Chance To Ignite With Fire Damage")]
        LocalDisplaySocketedGemsHavePctChanceToIgniteWithFireDamage = 1620,
        [Description("Cannot Freeze Shock Ignite On Critical")]
        CannotFreezeShockIgniteOnCritical = 1621,
        [Description("No Critical Strike Multiplier")]
        NoCriticalStrikeMultiplier = 1622,
        [Description("Onslaught On Crit Duration Ms")]
        OnslaughtOnCritDurationMs = 1623,
        [Description("Zombie Scale +%")]
        ZombieScalePosPct = 1624,
        [Description("Zombie Physical Damage +%")]
        ZombiePhysicalDamagePosPct = 1625,
        [Description("Faster Burn From Attacks %")]
        FasterBurnFromAttacksPct = 1626,
        [Description("Weapon Elemental Damage +% Per Power Charge")]
        WeaponElementalDamagePosPctPerPowerCharge = 1627,
        [Description("Apply Linked Curses On Hit %")]
        ApplyLinkedCursesOnHitPct = 1628,
        [Description("Cannot Cast Curses")]
        CannotCastCurses = 1629,
        [Description("Spell Damage Modifiers Apply To Attack Damage")]
        SpellDamageModifiersApplyToAttackDamage = 1630,
        [Description("Spell Damage +% From Dexterity")]
        SpellDamagePosPctFromDexterity = 1631,
        [Description("Agile Will")]
        AgileWill = 1632,
        [Description("Old Do Not Use Mana Leech From Physical Damage % Per Power Charge")]
        OldDoNotUseManaLeechFromPhysicalDamagePctPerPowerCharge = 1633,
        [Description("Chaos Damage Can Shock")]
        ChaosDamageCanShock = 1634,
        [Description("Physical Damage Can Chill")]
        PhysicalDamageCanChill = 1635,
        [Description("Killed Monster Dropped Item Quantity +% When Frozen")]
        KilledMonsterDroppedItemQuantityPosPctWhenFrozen = 1636,
        [Description("Killed Monster Dropped Item Rarity +% When Shocked")]
        KilledMonsterDroppedItemRarityPosPctWhenShocked = 1637,
        [Description("Local Flask Removes % Maximum Energy Shield On Use")]
        LocalFlaskRemovesPctMaximumEnergyShieldOnUse = 1638,
        [Description("Local Flask Deals % Maximum Life As Chaos Damage On Use")]
        LocalFlaskDealsPctMaximumLifeAsChaosDamageOnUse = 1639,
        [Description("Local Flask Gain Power Charges On Use")]
        LocalFlaskGainPowerChargesOnUse = 1640,
        [Description("Local Flask Gain Frenzy Charges On Use")]
        LocalFlaskGainFrenzyChargesOnUse = 1641,
        [Description("Local Flask Gain Endurance Charges On Use")]
        LocalFlaskGainEnduranceChargesOnUse = 1642,
        [Description("Deaths Oath Debuff On Kill Duration Ms")]
        DeathsOathDebuffOnKillDurationMs = 1643,
        [Description("Deaths Oath Debuff On Kill Base Chaos Damage To Deal Per Minute")]
        DeathsOathDebuffOnKillBaseChaosDamageToDealPerMinute = 1644,
        [Description("Local Display Aura Base Chaos Damage To Deal Per Minute")]
        LocalDisplayAuraBaseChaosDamageToDealPerMinute = 1645,
        [Description("Blood Footprints From Item")]
        BloodFootprintsFromItem = 1646,
        [Description("Demigod Footprints From Item")]
        DemigodFootprintsFromItem = 1647,
        [Description("Silver Footprints From Item")]
        SilverFootprintsFromItem = 1648,
        [Description("Projectile Homing Type")]
        ProjectileHomingType = 1649,
        [Description("Projectile Homing Range")]
        ProjectileHomingRange = 1650,
        [Description("Map Obas Trial")]
        MapObasTrial = 1651,
        [Description("Display Skill Deals Secondary Damage")]
        DisplaySkillDealsSecondaryDamage = 1652,
        [Description("Secondary Minimum Total Damage")]
        SecondaryMinimumTotalDamage = 1653,
        [Description("Secondary Maximum Total Damage")]
        SecondaryMaximumTotalDamage = 1654,
        [Description("Local Unique Counts As Dual Wielding")]
        LocalUniqueCountsAsDualWielding = 1655,
        [Description("Unique Local Minimum Added Fire Damage When In Main Hand")]
        UniqueLocalMinimumAddedFireDamageWhenInMainHand = 1656,
        [Description("Unique Local Maximum Added Fire Damage When In Main Hand")]
        UniqueLocalMaximumAddedFireDamageWhenInMainHand = 1657,
        [Description("Unique Local Minimum Added Chaos Damage When In Off Hand")]
        UniqueLocalMinimumAddedChaosDamageWhenInOffHand = 1658,
        [Description("Unique Local Maximum Added Chaos Damage When In Off Hand")]
        UniqueLocalMaximumAddedChaosDamageWhenInOffHand = 1659,
        [Description("Unique Local Minimum Added Cold Damage When In Off Hand")]
        UniqueLocalMinimumAddedColdDamageWhenInOffHand = 1660,
        [Description("Unique Local Maximum Added Cold Damage When In Off Hand")]
        UniqueLocalMaximumAddedColdDamageWhenInOffHand = 1661,
        [Description("Map Floor Unlock Time Seconds Unused")]
        MapFloorUnlockTimeSecondsUNUSED = 1662,
        [Description("Map Ignore Rogue Exile Rarity Bias")]
        MapIgnoreRogueExileRarityBias = 1663,
        [Description("Map Override Rogue Exile Min Level")]
        MapOverrideRogueExileMinLevel = 1664,
        [Description("Attack Speed +% Per Frenzy Charge")]
        AttackSpeedPosPctPerFrenzyCharge = 1665,
        [Description("Cast Speed +% Per Frenzy Charge")]
        CastSpeedPosPctPerFrenzyCharge = 1666,
        [Description("Attack And Cast Speed +% Per Frenzy Charge")]
        AttackAndCastSpeedPosPctPerFrenzyCharge = 1667,
        [Description("Converted Original Team")]
        ConvertedOriginalTeam = 1668,
        [Description("Damage +% Vs Enemies On Low Life Per Frenzy Charge")]
        DamagePosPctVsEnemiesOnLowLifePerFrenzyCharge = 1669,
        [Description("Damage +% Per Frenzy Charge")]
        DamagePosPctPerFrenzyCharge = 1670,
        [Description("Damage Removed From Mana Before Life %")]
        DamageRemovedFromManaBeforeLifePct = 1671,
        [Description("Local Display Aura Damage +%")]
        LocalDisplayAuraDamagePosPct = 1672,
        [Description("Attack Ignite Chance %")]
        AttackIgniteChancePct = 1673,
        [Description("Melee Damage +% Vs Frozen Enemies")]
        MeleeDamagePosPctVsFrozenEnemies = 1674,
        [Description("Melee Damage +% Vs Shocked Enemies")]
        MeleeDamagePosPctVsShockedEnemies = 1675,
        [Description("Melee Damage +% Vs Burning Enemies")]
        MeleeDamagePosPctVsBurningEnemies = 1676,
        [Description("Melee Damage Taken % To Deal To Attacker")]
        MeleeDamageTakenPctToDealToAttacker = 1677,
        [Description("Mana Gained When Hit")]
        ManaGainedWhenHit = 1678,
        [Description("Local Display Socketed Gems Get Reduced Mana Cost Level")]
        LocalDisplaySocketedGemsGetReducedManaCostLevel = 1679,
        [Description("Local Display Socketed Gems Get Faster Cast Level")]
        LocalDisplaySocketedGemsGetFasterCastLevel = 1680,
        [Description("Projectile Ignite Chance %")]
        ProjectileIgniteChancePct = 1681,
        [Description("Projectile Freeze Chance %")]
        ProjectileFreezeChancePct = 1682,
        [Description("Projectile Shock Chance %")]
        ProjectileShockChancePct = 1683,
        [Description("Local Off Hand Visual Identity Override Hash")]
        LocalOffHandVisualIdentityOverrideHash = 1684,
        [Description("Elemental Reflect Damage Taken +%")]
        ElementalReflectDamageTakenPosPct = 1685,
        [Description("Physical Reflect Damage Taken +%")]
        PhysicalReflectDamageTakenPosPct = 1686,
        [Description("Local Left Ring Slot Elemental Reflect Damage Taken +%")]
        LocalLeftRingSlotElementalReflectDamageTakenPosPct = 1687,
        [Description("Local Right Ring Slot Physical Reflect Damage Taken +%")]
        LocalRightRingSlotPhysicalReflectDamageTakenPosPct = 1688,
        [Description("Grace Aura Evasion Rating +% Final")]
        GraceAuraEvasionRatingPosPctFinal = 1689,
        [Description("Deal No Attack Damage")]
        DealNoAttackDamage = 1690,
        [Description("Deal No Main Hand Damage")]
        DealNoMainHandDamage = 1691,
        [Description("Deal No Off Hand Damage")]
        DealNoOffHandDamage = 1692,
        [Description("Deal No Spell Damage")]
        DealNoSpellDamage = 1693,
        [Description("Deal No Secondary Damage")]
        DealNoSecondaryDamage = 1694,
        [Description("Deal No Physical Damage")]
        DealNoPhysicalDamage = 1695,
        [Description("Deal No Fire Damage")]
        DealNoFireDamage = 1696,
        [Description("Deal No Cold Damage")]
        DealNoColdDamage = 1697,
        [Description("Deal No Lightning Damage")]
        DealNoLightningDamage = 1698,
        [Description("Deal No Chaos Damage")]
        DealNoChaosDamage = 1699,
        [Description("Deal No Spell Physical Damage")]
        DealNoSpellPhysicalDamage = 1700,
        [Description("Deal No Spell Fire Damage")]
        DealNoSpellFireDamage = 1701,
        [Description("Deal No Spell Cold Damage")]
        DealNoSpellColdDamage = 1702,
        [Description("Deal No Spell Lightning Damage")]
        DealNoSpellLightningDamage = 1703,
        [Description("Deal No Spell Chaos Damage")]
        DealNoSpellChaosDamage = 1704,
        [Description("Deal No Secondary Physical Damage")]
        DealNoSecondaryPhysicalDamage = 1705,
        [Description("Deal No Secondary Fire Damage")]
        DealNoSecondaryFireDamage = 1706,
        [Description("Deal No Secondary Cold Damage")]
        DealNoSecondaryColdDamage = 1707,
        [Description("Deal No Secondary Lightning Damage")]
        DealNoSecondaryLightningDamage = 1708,
        [Description("Deal No Secondary Chaos Damage")]
        DealNoSecondaryChaosDamage = 1709,
        [Description("Deal No Main Hand Physical Damage")]
        DealNoMainHandPhysicalDamage = 1710,
        [Description("Deal No Main Hand Fire Damage")]
        DealNoMainHandFireDamage = 1711,
        [Description("Deal No Main Hand Cold Damage")]
        DealNoMainHandColdDamage = 1712,
        [Description("Deal No Main Hand Lightning Damage")]
        DealNoMainHandLightningDamage = 1713,
        [Description("Deal No Main Hand Chaos Damage")]
        DealNoMainHandChaosDamage = 1714,
        [Description("Deal No Off Hand Physical Damage")]
        DealNoOffHandPhysicalDamage = 1715,
        [Description("Deal No Off Hand Fire Damage")]
        DealNoOffHandFireDamage = 1716,
        [Description("Deal No Off Hand Cold Damage")]
        DealNoOffHandColdDamage = 1717,
        [Description("Deal No Off Hand Lightning Damage")]
        DealNoOffHandLightningDamage = 1718,
        [Description("Deal No Off Hand Chaos Damage")]
        DealNoOffHandChaosDamage = 1719,
        [Description("Base Deal No Main Hand Damage")]
        BaseDealNoMainHandDamage = 1720,
        [Description("Base Deal No Off Hand Damage")]
        BaseDealNoOffHandDamage = 1721,
        [Description("Base Deal No Spell Damage")]
        BaseDealNoSpellDamage = 1722,
        [Description("Base Deal No Secondary Damage")]
        BaseDealNoSecondaryDamage = 1723,
        [Description("Base Deal No Attack Damage")]
        BaseDealNoAttackDamage = 1724,
        [Description("Base Deal No Physical Damage")]
        BaseDealNoPhysicalDamage = 1725,
        [Description("Base Deal No Fire Damage")]
        BaseDealNoFireDamage = 1726,
        [Description("Base Deal No Cold Damage")]
        BaseDealNoColdDamage = 1727,
        [Description("Base Deal No Lightning Damage")]
        BaseDealNoLightningDamage = 1728,
        [Description("Base Deal No Chaos Damage")]
        BaseDealNoChaosDamage = 1729,
        [Description("Local Can Only Deal Damage With This Weapon")]
        LocalCanOnlyDealDamageWithThisWeapon = 1730,
        [Description("Reave Area Of Effect +% Final Per Stage")]
        ReaveAreaOfEffectPosPctFinalPerStage = 1731,
        [Description("Skill Can Add Multiple Charges Per Action")]
        SkillCanAddMultipleChargesPerAction = 1732,
        [Description("Local Charges Used +%")]
        LocalChargesUsedPosPct = 1733,
        [Description("Non Critical Damage Multiplier +%")]
        NonCriticalDamageMultiplierPosPct = 1734,
        [Description("Skill Sound Variation")]
        SkillSoundVariation = 1735,
        [Description("Unique Map Boss Number Of Rare Items To Drop")]
        UniqueMapBossNumberOfRareItemsToDrop = 1736,
        [Description("Unique Map Boss Class Of Rare Items To Drop")]
        UniqueMapBossClassOfRareItemsToDrop = 1737,
        [Description("Base Cold Damage To Deal Per Minute")]
        BaseColdDamageToDealPerMinute = 1738,
        [Description("Number Of Totems Summoned In Formation")]
        NumberOfTotemsSummonedInFormation = 1739,
        [Description("Supported Active Skill Gem Level +")]
        SupportedActiveSkillGemLevelPos = 1740,
        [Description("Shock Art Variation")]
        ShockArtVariation = 1741,
        [Description("Support Multicast Cast Speed +% Final")]
        SupportMulticastCastSpeedPosPctFinal = 1742,
        [Description("Global Attack Speed +% Per Green Socket On Item")]
        GlobalAttackSpeedPosPctPerGreenSocketOnItem = 1743,
        [Description("Global Weapon Physical Damage +% Per Red Socket On Item")]
        GlobalWeaponPhysicalDamagePosPctPerRedSocketOnItem = 1744,
        [Description("Old Do Not Use Global Mana Leech From Physical Attack Damage % Per Blue Socket On Item")]
        OldDoNotUseGlobalManaLeechFromPhysicalAttackDamagePctPerBlueSocketOnItem = 1745,
        [Description("Global Melee Range + Per White Socket On Item")]
        GlobalMeleeRangePosPerWhiteSocketOnItem = 1746,
        [Description("Spell Damage +% Per 5% Block Chance")]
        SpellDamagePosPctPer5PctBlockChance = 1747,
        [Description("Base Life Gained On Spell Hit")]
        BaseLifeGainedOnSpellHit = 1748,
        [Description("Armour % To Leech As Life On Block")]
        ArmourPctToLeechAsLifeOnBlock = 1749,
        [Description("Energy Shield % To Lose On Block")]
        EnergyShieldPctToLoseOnBlock = 1750,
        [Description("Light Radius Scales With Energy Shield")]
        LightRadiusScalesWithEnergyShield = 1751,
        [Description("Fishing Range +%")]
        FishingRangePosPct = 1752,
        [Description("Fishing Line Strength +%")]
        FishingLineStrengthPosPct = 1753,
        [Description("Fish Quantity +%")]
        FishQuantityPosPct = 1754,
        [Description("Fish Rarity +%")]
        FishRarityPosPct = 1755,
        [Description("Fishing Pool Consumption +%")]
        FishingPoolConsumptionPosPct = 1756,
        [Description("Fishing Lure Type")]
        FishingLureType = 1757,
        [Description("Fishing Hook Type")]
        FishingHookType = 1758,
        [Description("Cannot Be Damaged By Things Outside Radius")]
        CannotBeDamagedByThingsOutsideRadius = 1759,
        [Description("Inside Shield")]
        InsideShield = 1760,
        [Description("Flask Effect +%")]
        FlaskEffectPosPct = 1761,
        [Description("Chance To Gain Endurance Charge When Hit %")]
        ChanceToGainEnduranceChargeWhenHitPct = 1762,
        [Description("Lose All Endurance Charges When Reaching Maximum")]
        LoseAllEnduranceChargesWhenReachingMaximum = 1763,
        [Description("Gain Onslaught Ms When Reaching Maximum Endurance Charges")]
        GainOnslaughtMsWhenReachingMaximumEnduranceCharges = 1764,
        [Description("Cannot Gain Endurance Charges While Have Onslaught")]
        CannotGainEnduranceChargesWhileHaveOnslaught = 1765,
        [Description("Has Onslaught")]
        HasOnslaught = 1766,
        [Description("Cannot Gain Endurance Charges")]
        CannotGainEnduranceCharges = 1767,
        [Description("Local Weapon Range +")]
        LocalWeaponRangePos = 1768,
        [Description("Off Hand Weapon Range +")]
        OffHandWeaponRangePos = 1769,
        [Description("Main Hand Weapon Range +")]
        MainHandWeaponRangePos = 1770,
        [Description("Local Has X Sockets")]
        LocalHasXSockets = 1771,
        [Description("Weapon Physical Damage +%")]
        WeaponPhysicalDamagePosPct = 1772,
        [Description("Maximum Critical Strike Chance")]
        MaximumCriticalStrikeChance = 1773,
        [Description("Chilled Monsters Take +% Burning Damage")]
        ChilledMonstersTakePosPctBurningDamage = 1774,
        [Description("Unique Ignite Chance % When In Main Hand")]
        UniqueIgniteChancePctWhenInMainHand = 1775,
        [Description("Unique Chill Duration +% When In Off Hand")]
        UniqueChillDurationPosPctWhenInOffHand = 1776,
        [Description("Curse On Melee Block Level X Punishment")]
        CurseOnMeleeBlockLevelXPunishment = 1777,
        [Description("Curse On Projectile Block Level X Temporal Chains")]
        CurseOnProjectileBlockLevelXTemporalChains = 1778,
        [Description("Curse On Spell Block Level X Elemental Weakness")]
        CurseOnSpellBlockLevelXElementalWeakness = 1779,
        [Description("Local Display Socketed Gems Get Item Quantity +%")]
        LocalDisplaySocketedGemsGetItemQuantityPosPct = 1780,
        [Description("Local Display Socketed Gems Get Iron Will Level")]
        LocalDisplaySocketedGemsGetIronWillLevel = 1781,
        [Description("Gain Onslaught On Stun Duration Ms")]
        GainOnslaughtOnStunDurationMs = 1782,
        [Description("Cast Linked Spells On Attack Hit %")]
        CastLinkedSpellsOnAttackHitPct = 1783,
        [Description("Spectres Have Aura Cast Attack Move Speed +%")]
        SpectresHaveAuraCastAttackMoveSpeedPosPct = 1784,
        [Description("Physical Damage Reduction Rating Per Level")]
        PhysicalDamageReductionRatingPerLevel = 1785,
        [Description("Maximum Life Per 10 Levels")]
        MaximumLifePer10Levels = 1786,
        [Description("Resist All Elements % Per 10 Levels")]
        ResistAllElementsPctPer10Levels = 1787,
        [Description("Chance To Gain Random Curse When Hit % Per 10 Levels")]
        ChanceToGainRandomCurseWhenHitPctPer10Levels = 1788,
        [Description("Chance To Gain Random Curse When Hit %")]
        ChanceToGainRandomCurseWhenHitPct = 1789,
        [Description("Curse On Hit % Flammability")]
        CurseOnHitPctFlammability = 1790,
        [Description("Support Trap Damage +% Final")]
        SupportTrapDamagePosPctFinal = 1791,
        [Description("Number Of Additional Traps To Throw")]
        NumberOfAdditionalTrapsToThrow = 1792,
        [Description("Number Of Traps To Throw")]
        NumberOfTrapsToThrow = 1793,
        [Description("Projectiles Nova")]
        ProjectilesNova = 1794,
        [Description("Support Multithrow Damage +% Final")]
        SupportMultithrowDamagePosPctFinal = 1795,
        [Description("Suppressing Fire Debuff Cast Speed +% Final")]
        SuppressingFireDebuffCastSpeedPosPctFinal = 1796,
        [Description("Suppressing Fire Debuff Non Melee Attack Speed +% Final")]
        SuppressingFireDebuffNonMeleeAttackSpeedPosPctFinal = 1797,
        [Description("Cast On Death %")]
        CastOnDeathPct = 1798,
        [Description("Accuracy Rating +% Per Frenzy Charge")]
        AccuracyRatingPosPctPerFrenzyCharge = 1799,
        [Description("Base Skill Is Trapped")]
        BaseSkillIsTrapped = 1800,
        [Description("Base Skill Is Mined")]
        BaseSkillIsMined = 1801,
        [Description("Base Skill Is Totemified")]
        BaseSkillIsTotemified = 1802,
        [Description("Trap Damage +%")]
        TrapDamagePosPct = 1803,
        [Description("Totem Damage +%")]
        TotemDamagePosPct = 1804,
        [Description("Mine Damage +%")]
        MineDamagePosPct = 1805,
        [Description("Monster Reverse Point Blank Damage -% At Minimum Range")]
        MonsterReversePointBlankDamageNegPctAtMinimumRange = 1806,
        [Description("Frenzy Charge Duration +% Per Frenzy Charge")]
        FrenzyChargeDurationPosPctPerFrenzyCharge = 1807,
        [Description("Virtual Frenzy Charge Duration +%")]
        VirtualFrenzyChargeDurationPosPct = 1808,
        [Description("Attacks Poison While At Max Frenzy Charges")]
        AttacksPoisonWhileAtMaxFrenzyCharges = 1809,
        [Description("Attacks Poison")]
        AttacksPoison = 1810,
        [Description("Gain Endurance Charge On Melee Stun")]
        GainEnduranceChargeOnMeleeStun = 1811,
        [Description("Damage Taken +% Vs Demons")]
        DamageTakenPosPctVsDemons = 1812,
        [Description("Damage +% Vs Demons")]
        DamagePosPctVsDemons = 1813,
        [Description("Local Recharge On Demon Killed")]
        LocalRechargeOnDemonKilled = 1814,
        [Description("Local Unique Flask Damage Taken +% Vs Demons While Healing")]
        LocalUniqueFlaskDamageTakenPosPctVsDemonsWhileHealing = 1815,
        [Description("Local Unique Flask Damage +% Vs Demons While Healing")]
        LocalUniqueFlaskDamagePosPctVsDemonsWhileHealing = 1816,
        [Description("Chance To Apply Suppression On Hit %")]
        ChanceToApplySuppressionOnHitPct = 1817,
        [Description("Is Frozen")]
        IsFrozen = 1818,
        [Description("Is Chilled")]
        IsChilled = 1819,
        [Description("Is Ignited")]
        IsIgnited = 1820,
        [Description("Curses Reflected To Self")]
        CursesReflectedToSelf = 1821,
        [Description("Movement Speed Bonus When Throwing Trap Ms")]
        MovementSpeedBonusWhenThrowingTrapMs = 1822,
        [Description("Local Display Socketed Gems Get Trap Level")]
        LocalDisplaySocketedGemsGetTrapLevel = 1823,
        [Description("Poison On Melee Critical Strike %")]
        PoisonOnMeleeCriticalStrikePct = 1824,
        [Description("Shocks Reflected To Self")]
        ShocksReflectedToSelf = 1825,
        [Description("Damage +% Per Shock")]
        DamagePosPctPerShock = 1826,
        [Description("Movement Velocity +% Per Shock")]
        MovementVelocityPosPctPerShock = 1827,
        [Description("Damage +1% Per X Strength")]
        DamagePos1PctPerXStrength = 1828,
        [Description("Physical Damage Reduction Rating +1% Per X Strength")]
        PhysicalDamageReductionRatingPos1PctPerXStrength = 1829,
        [Description("Damage +1% Per X Strength When In Main Hand")]
        DamagePos1PctPerXStrengthWhenInMainHand = 1830,
        [Description("Physical Damage Reduction Rating +1% Per X Strength When In Off Hand")]
        PhysicalDamageReductionRatingPos1PctPerXStrengthWhenInOffHand = 1831,
        [Description("Local Display Socketed Gems Get Curse Reflection")]
        LocalDisplaySocketedGemsGetCurseReflection = 1832,
        [Description("Freeze Mine Cold Resistance + While Frozen")]
        FreezeMineColdResistancePosWhileFrozen = 1833,
        [Description("Max Corrupted Blood Stacks")]
        MaxCorruptedBloodStacks = 1834,
        [Description("Current Corrupted Blood Stacks")]
        CurrentCorruptedBloodStacks = 1835,
        [Description("Physical Damage Taken Per Minute")]
        PhysicalDamageTakenPerMinute = 1836,
        [Description("Base Physical Damage Taken Per Minute Per Corrupted Blood Stack")]
        BasePhysicalDamageTakenPerMinutePerCorruptedBloodStack = 1837,
        [Description("Firestorm Drop Burning Ground Duration Ms")]
        FirestormDropBurningGroundDurationMs = 1838,
        [Description("Firestorm Base Area Of Effect +%")]
        FirestormBaseAreaOfEffectPosPct = 1839,
        [Description("Mine Duration +%")]
        MineDurationPosPct = 1840,
        [Description("Display Monster Spike Nova On Death Text")]
        DisplayMonsterSpikeNovaOnDeathText = 1841,
        [Description("Display Monster Ice Spear Nova On Death Text")]
        DisplayMonsterIceSpearNovaOnDeathText = 1842,
        [Description("Skill Unusable")]
        SkillUnusable = 1843,
        [Description("Cast Linked Spells On Attack Crit %")]
        CastLinkedSpellsOnAttackCritPct = 1844,
        [Description("Cast Linked Spells On Melee Kill %")]
        CastLinkedSpellsOnMeleeKillPct = 1845,
        [Description("Spell Uncastable If Triggerable")]
        SpellUncastableIfTriggerable = 1846,
        [Description("Mine Detonation Is Instant")]
        MineDetonationIsInstant = 1847,
        [Description("Trap Damage Penetrates % Elemental Resistance")]
        TrapDamagePenetratesPctElementalResistance = 1848,
        [Description("Mine Damage Penetrates % Elemental Resistance")]
        MineDamagePenetratesPctElementalResistance = 1849,
        [Description("Traps Invulnerable For Duration Ms")]
        TrapsInvulnerableForDurationMs = 1850,
        [Description("Mines Invulnerable For Duration Ms")]
        MinesInvulnerableForDurationMs = 1851,
        [Description("Totem Elemental Resistance %")]
        TotemElementalResistancePct = 1852,
        [Description("Totem Additional Physical Damage Reduction %")]
        TotemAdditionalPhysicalDamageReductionPct = 1853,
        [Description("Mine Detonation Radius +%")]
        MineDetonationRadiusPosPct = 1854,
        [Description("Totem Skill Cast Speed +%")]
        TotemSkillCastSpeedPosPct = 1855,
        [Description("Totem Skill Attack Speed +%")]
        TotemSkillAttackSpeedPosPct = 1856,
        [Description("Mine Laying Speed +%")]
        MineLayingSpeedPosPct = 1857,
        [Description("Cyclone Places Ground Ice")]
        CyclonePlacesGroundIce = 1858,
        [Description("Leap Slam Base Ground Fire Damage To Deal Per Minute")]
        LeapSlamBaseGroundFireDamageToDealPerMinute = 1859,
        [Description("Projectiles Return If No Hit Object")]
        ProjectilesReturnIfNoHitObject = 1860,
        [Description("Cast On Stunned %")]
        CastOnStunnedPct = 1861,
        [Description("Cast On Damage Taken %")]
        CastOnDamageTakenPct = 1862,
        [Description("Cast On Damage Taken Threshold")]
        CastOnDamageTakenThreshold = 1863,
        [Description("Deal No Non Fire Damage")]
        DealNoNonFireDamage = 1864,
        [Description("Ice Nova Places Ground Ice")]
        IceNovaPlacesGroundIce = 1865,
        [Description("Shock Nova Places X Ground Lightning Patches")]
        ShockNovaPlacesXGroundLightningPatches = 1866,
        [Description("Ignores Proximity Shield")]
        IgnoresProximityShield = 1867,
        [Description("Emerge Speed +%")]
        EmergeSpeedPosPct = 1868,
        [Description("Animated Armour Replace Off Hand Weapon")]
        AnimatedArmourReplaceOffHandWeapon = 1869,
        [Description("Map No Exiles")]
        MapNoExiles = 1870,
        [Description("Animate Item Maximum Level Requirement")]
        AnimateItemMaximumLevelRequirement = 1871,
        [Description("Phase Through Objects")]
        PhaseThroughObjects = 1872,
        [Description("Delete On Death")]
        DeleteOnDeath = 1873,
        [Description("Corpse Consumption Mana To Gain")]
        CorpseConsumptionManaToGain = 1874,
        [Description("Fixed Projectile Spread")]
        FixedProjectileSpread = 1875,
        [Description("Fire And Cold Damage Resistance %")]
        FireAndColdDamageResistancePct = 1876,
        [Description("Fire And Lightning Damage Resistance %")]
        FireAndLightningDamageResistancePct = 1877,
        [Description("Cold And Lightning Damage Resistance %")]
        ColdAndLightningDamageResistancePct = 1878,
        [Description("Display Monster Mod Nemesis Test")]
        DisplayMonsterModNemesisTest = 1879,
        [Description("Base Damage Not From Skill User")]
        BaseDamageNotFromSkillUser = 1880,
        [Description("Map Rare Monsters Have Nemesis Mod")]
        MapRareMonstersHaveNemesisMod = 1881,
        [Description("Display Monster Has Firestorm Daemon")]
        DisplayMonsterHasFirestormDaemon = 1882,
        [Description("Monster Raises After Death")]
        MonsterRaisesAfterDeath = 1883,
        [Description("Display Monster Is Apparition")]
        DisplayMonsterIsApparition = 1884,
        [Description("Monster Spawns X Monsters On Death")]
        MonsterSpawnsXMonstersOnDeath = 1885,
        [Description("Damage +% While Ignited")]
        DamagePosPctWhileIgnited = 1886,
        [Description("Physical Damage Reduction Rating While Frozen")]
        PhysicalDamageReductionRatingWhileFrozen = 1887,
        [Description("Old Do Not Use Mana Leech % Vs Shocked Enemies")]
        OldDoNotUseManaLeechPctVsShockedEnemies = 1888,
        [Description("Old Do Not Use Life Leech % Vs Frozen Enemies")]
        OldDoNotUseLifeLeechPctVsFrozenEnemies = 1889,
        [Description("Damage +% Vs Rare Monsters")]
        DamagePosPctVsRareMonsters = 1890,
        [Description("Damage +% Vs Enemies Per Freeze Shock Ignite")]
        DamagePosPctVsEnemiesPerFreezeShockIgnite = 1891,
        [Description("Chance To Freeze Shock Ignite %")]
        ChanceToFreezeShockIgnitePct = 1892,
        [Description("Shrine Buff Effect On Self +%")]
        ShrineBuffEffectOnSelfPosPct = 1893,
        [Description("Shrine Effect Duration +%")]
        ShrineEffectDurationPosPct = 1894,
        [Description("Local Unique Flask Cannot Recover Life While Healing")]
        LocalUniqueFlaskCannotRecoverLifeWhileHealing = 1895,
        [Description("Local Unique Flask Recover % Maximum Life When Effect Reaches Duration")]
        LocalUniqueFlaskRecoverPctMaximumLifeWhenEffectReachesDuration = 1896,
        [Description("Local Unique Flask No Mana Cost While Healing")]
        LocalUniqueFlaskNoManaCostWhileHealing = 1897,
        [Description("Shock X Nearby Enemies For 2 S On Killing Shocked Enemy")]
        ShockXNearbyEnemiesFor2SOnKillingShockedEnemy = 1898,
        [Description("Ignite X Nearby Enemies For 4 S On Killing Ignited Enemy")]
        IgniteXNearbyEnemiesFor4SOnKillingIgnitedEnemy = 1899,
        [Description("Chance To Ignite %")]
        ChanceToIgnitePct = 1900,
        [Description("Chance To Shock %")]
        ChanceToShockPct = 1901,
        [Description("Chance To Freeze %")]
        ChanceToFreezePct = 1902,
        [Description("Echoing Shrine Cast Speed +% Final")]
        EchoingShrineCastSpeedPosPctFinal = 1903,
        [Description("Echoing Shrine Attack Speed +% Final")]
        EchoingShrineAttackSpeedPosPctFinal = 1904,
        [Description("Display Monster Has Proximity Shield Daemon")]
        DisplayMonsterHasProximityShieldDaemon = 1905,
        [Description("Display Monster Has Summon Skeletons Daemon")]
        DisplayMonsterHasSummonSkeletonsDaemon = 1906,
        [Description("Display Monster Has Smoke Mine Daemon")]
        DisplayMonsterHasSmokeMineDaemon = 1907,
        [Description("Monster Drop Additional Unique Items")]
        MonsterDropAdditionalUniqueItems = 1908,
        [Description("Base Corrupt Blood When Hit % Average Damage To Deal Per Minute Per Stack")]
        BaseCorruptBloodWhenHitPctAverageDamageToDealPerMinutePerStack = 1909,
        [Description("Cannot Recover Life")]
        CannotRecoverLife = 1910,
        [Description("Recover % Maximum Life When Buff Reaches Duration")]
        RecoverPctMaximumLifeWhenBuffReachesDuration = 1911,
        [Description("No Mana Cost")]
        NoManaCost = 1912,
        [Description("Gain Rare Monster Mods On Kill Ms")]
        GainRareMonsterModsOnKillMs = 1913,
        [Description("Corpse Cannot Be Destroyed")]
        CorpseCannotBeDestroyed = 1914,
        [Description("Cannot Be Dominated")]
        CannotBeDominated = 1915,
        [Description("Lightning Warp Shocked Ground Duration Ms")]
        LightningWarpShockedGroundDurationMs = 1916,
        [Description("Physical Damage % To Add As Random Element")]
        PhysicalDamagePctToAddAsRandomElement = 1917,
        [Description("Always Cause Elemental Status Ailment")]
        AlwaysCauseElementalStatusAilment = 1918,
        [Description("Reflect Projectiles At Owner")]
        ReflectProjectilesAtOwner = 1919,
        [Description("Base Righteous Fire % Of Max Energy Shield To Deal To Nearby Per Minute")]
        BaseRighteousFirePctOfMaxEnergyShieldToDealToNearbyPerMinute = 1920,
        [Description("Base Nonlethal Fire Damage % Of Maximum Energy Shield Taken Per Minute")]
        BaseNonlethalFireDamagePctOfMaximumEnergyShieldTakenPerMinute = 1921,
        [Description("Nemesis Transform On Low Life")]
        NemesisTransformOnLowLife = 1922,
        [Description("Attack And Cast Speed +%")]
        AttackAndCastSpeedPosPct = 1923,
        [Description("Cleave Damage +% Final While Dual Wielding")]
        CleaveDamagePosPctFinalWhileDualWielding = 1924,
        [Description("Monster Level Scale Maximum Mana And Mana Cost +% Final")]
        MonsterLevelScaleMaximumManaAndManaCostPosPctFinal = 1925,
        [Description("Grant Actor Scale +% To Aura Owner On Death")]
        GrantActorScalePosPctToAuraOwnerOnDeath = 1926,
        [Description("Grant Attack Speed +% To Aura Owner On Death")]
        GrantAttackSpeedPosPctToAuraOwnerOnDeath = 1927,
        [Description("Grant Cast Speed +% To Aura Owner On Death")]
        GrantCastSpeedPosPctToAuraOwnerOnDeath = 1928,
        [Description("Grant Damage Reduction % To Aura Owner On Death")]
        GrantDamageReductionPctToAuraOwnerOnDeath = 1929,
        [Description("Random Curse On Hit %")]
        RandomCurseOnHitPct = 1930,
        [Description("Random Curses Include Silence")]
        RandomCursesIncludeSilence = 1931,
        [Description("Is Twinned Unique Boss")]
        IsTwinnedUniqueBoss = 1932,
        [Description("Remove Flask Effects On Hit %")]
        RemoveFlaskEffectsOnHitPct = 1933,
        [Description("Remove Charges On Hit %")]
        RemoveChargesOnHitPct = 1934,
        [Description("Monster Casts Arctic Breath Text")]
        MonsterCastsArcticBreathText = 1935,
        [Description("Cast On Death Damage +% Final While Dead")]
        CastOnDeathDamagePosPctFinalWhileDead = 1936,
        [Description("Cast On Damage Taken Damage +% Final")]
        CastOnDamageTakenDamagePosPctFinal = 1937,
        [Description("Life Gained On Spell Hit")]
        LifeGainedOnSpellHit = 1938,
        [Description("Base Attacks Poison")]
        BaseAttacksPoison = 1939,
        [Description("Active Skill Attack Speed +% Final")]
        ActiveSkillAttackSpeedPosPctFinal = 1940,
        [Description("Infinite Skill Effect Duration")]
        InfiniteSkillEffectDuration = 1941,
        [Description("Physical Damage Reduction Rating +% While Not Ignited Frozen Shocked")]
        PhysicalDamageReductionRatingPosPctWhileNotIgnitedFrozenShocked = 1942,
        [Description("Max Corrupted Blood Rain Stacks")]
        MaxCorruptedBloodRainStacks = 1943,
        [Description("Current Corrupted Blood Rain Stacks")]
        CurrentCorruptedBloodRainStacks = 1944,
        [Description("Base Physical Damage Taken Per Minute Per Corrupted Blood Rain Stack")]
        BasePhysicalDamageTakenPerMinutePerCorruptedBloodRainStack = 1945,
        [Description("Base Damage Removed From Mana Before Life %")]
        BaseDamageRemovedFromManaBeforeLifePct = 1946,
        [Description("Keystone Mana Shield")]
        KeystoneManaShield = 1947,
        [Description("Actor Scale +%")]
        ActorScalePosPct = 1948,
        [Description("Capped Actor Scale +%")]
        CappedActorScalePosPct = 1949,
        [Description("Cannot Stun")]
        CannotStun = 1950,
        [Description("Is Daemon")]
        IsDaemon = 1951,
        [Description("Disable Light")]
        DisableLight = 1952,
        [Description("Base Chance To Dodge %")]
        BaseChanceToDodgePct = 1953,
        [Description("Base Chance To Dodge Spells %")]
        BaseChanceToDodgeSpellsPct = 1954,
        [Description("Map Allow Shrines")]
        MapAllowShrines = 1955,
        [Description("Aura Effect +%")]
        AuraEffectPosPct = 1956,
        [Description("Display Monster Uses Far Shot Text")]
        DisplayMonsterUsesFarShotText = 1957,
        [Description("Monster Additional Rarity Of Dropped Items In Merciless +%")]
        MonsterAdditionalRarityOfDroppedItemsInMercilessPosPct = 1958,
        [Description("Monster Additional Quantity Of Dropped Items In Merciless +%")]
        MonsterAdditionalQuantityOfDroppedItemsInMercilessPosPct = 1959,
        [Description("Mortal Conviction Mana Reservation +% Final")]
        MortalConvictionManaReservationPosPctFinal = 1960,
        [Description("Mana Reservation +%")]
        ManaReservationPosPct = 1961,
        [Description("Additional Player Bonus Maximum Energy Shield +% Final")]
        AdditionalPlayerBonusMaximumEnergyShieldPosPctFinal = 1962,
        [Description("Additional Player Bonus Monster Slain Flask Charges Granted +% Final")]
        AdditionalPlayerBonusMonsterSlainFlaskChargesGrantedPosPctFinal = 1963,
        [Description("Display Monster Uses Suppressing Fire Text")]
        DisplayMonsterUsesSuppressingFireText = 1964,
        [Description("Display Monster Casts Devouring Totem Skill Text")]
        DisplayMonsterCastsDevouringTotemSkillText = 1965,
        [Description("Monster Additional Quantity Of Dropped Items In Cruel +%")]
        MonsterAdditionalQuantityOfDroppedItemsInCruelPosPct = 1966,
        [Description("Monster Additional Rarity Of Dropped Items In Cruel +%")]
        MonsterAdditionalRarityOfDroppedItemsInCruelPosPct = 1967,
        [Description("Supported Active Skill Gem Quality %")]
        SupportedActiveSkillGemQualityPct = 1968,
        [Description("Map Rarity")]
        MapRarity = 1969,
        [Description("Animate Guardian Last Known Life")]
        AnimateGuardianLastKnownLife = 1970,
        [Description("Spell Only Castable On Death")]
        SpellOnlyCastableOnDeath = 1971,
        [Description("Local Support Gem Max Skill Level Requirement To Support")]
        LocalSupportGemMaxSkillLevelRequirementToSupport = 1972,
        [Description("Display Monster Casts Lightning Nova Text")]
        DisplayMonsterCastsLightningNovaText = 1973,
        [Description("Physical Damage To Deal Per Minute")]
        PhysicalDamageToDealPerMinute = 1974,
        [Description("Base Physical Damage To Deal Per Minute")]
        BasePhysicalDamageToDealPerMinute = 1975,
        [Description("Fire Damage To Deal Per Minute")]
        FireDamageToDealPerMinute = 1976,
        [Description("Cold Damage To Deal Per Minute")]
        ColdDamageToDealPerMinute = 1977,
        [Description("Lightning Damage To Deal Per Minute")]
        LightningDamageToDealPerMinute = 1978,
        [Description("Base Lightning Damage To Deal Per Minute")]
        BaseLightningDamageToDealPerMinute = 1979,
        [Description("Chaos Damage To Deal Per Minute")]
        ChaosDamageToDealPerMinute = 1980,
        [Description("Base Chaos Damage To Deal Per Minute")]
        BaseChaosDamageToDealPerMinute = 1981,
        [Description("Base Chaos Damage % Of Maximum Life To Deal Per Minute")]
        BaseChaosDamagePctOfMaximumLifeToDealPerMinute = 1982,
        [Description("Base Chaos Damage Taken Per Minute Per Viper Strike Orb")]
        BaseChaosDamageTakenPerMinutePerViperStrikeOrb = 1983,
        [Description("Combined All Damage Over Time +%")]
        CombinedAllDamageOverTimePosPct = 1984,
        [Description("Combined All Damage Over Time +% Final")]
        CombinedAllDamageOverTimePosPctFinal = 1985,
        [Description("Combined Physical Damage Over Time +%")]
        CombinedPhysicalDamageOverTimePosPct = 1986,
        [Description("Combined Physical Damage Over Time +% Final")]
        CombinedPhysicalDamageOverTimePosPctFinal = 1987,
        [Description("Combined Elemental Damage Over Time +%")]
        CombinedElementalDamageOverTimePosPct = 1988,
        [Description("Combined Elemental Damage Over Time +% Final")]
        CombinedElementalDamageOverTimePosPctFinal = 1989,
        [Description("Combined Fire Damage Over Time +%")]
        CombinedFireDamageOverTimePosPct = 1990,
        [Description("Combined Fire Damage Over Time +% Final")]
        CombinedFireDamageOverTimePosPctFinal = 1991,
        [Description("Combined Cold Damage Over Time +%")]
        CombinedColdDamageOverTimePosPct = 1992,
        [Description("Combined Cold Damage Over Time +% Final")]
        CombinedColdDamageOverTimePosPctFinal = 1993,
        [Description("Combined Lightning Damage Over Time +%")]
        CombinedLightningDamageOverTimePosPct = 1994,
        [Description("Combined Lightning Damage Over Time +% Final")]
        CombinedLightningDamageOverTimePosPctFinal = 1995,
        [Description("Combined Chaos Damage Over Time +%")]
        CombinedChaosDamageOverTimePosPct = 1996,
        [Description("Combined Chaos Damage Over Time +% Final")]
        CombinedChaosDamageOverTimePosPctFinal = 1997,
        [Description("Damage Over Time +%")]
        DamageOverTimePosPct = 1998,
        [Description("Fire Damage Taken Per Minute")]
        FireDamageTakenPerMinute = 1999,
        [Description("Base Fire Damage Taken Per Minute")]
        BaseFireDamageTakenPerMinute = 2000,
        [Description("Cold Damage Taken Per Minute")]
        ColdDamageTakenPerMinute = 2001,
        [Description("Base Cold Damage Taken Per Minute")]
        BaseColdDamageTakenPerMinute = 2002,
        [Description("Lightning Damage Taken Per Minute")]
        LightningDamageTakenPerMinute = 2003,
        [Description("Base Lightning Damage Taken Per Minute")]
        BaseLightningDamageTakenPerMinute = 2004,
        [Description("Deal No Damage Over Time")]
        DealNoDamageOverTime = 2005,
        [Description("Base Deal No Damage Over Time")]
        BaseDealNoDamageOverTime = 2006,
        [Description("Deal No Physical Damage Over Time")]
        DealNoPhysicalDamageOverTime = 2007,
        [Description("Deal No Fire Damage Over Time")]
        DealNoFireDamageOverTime = 2008,
        [Description("Deal No Cold Damage Over Time")]
        DealNoColdDamageOverTime = 2009,
        [Description("Deal No Lightning Damage Over Time")]
        DealNoLightningDamageOverTime = 2010,
        [Description("Deal No Chaos Damage Over Time")]
        DealNoChaosDamageOverTime = 2011,
        [Description("Unique Critical Strike Chance +% Final")]
        UniqueCriticalStrikeChancePosPctFinal = 2012,
        [Description("Map Ground Lightning")]
        MapGroundLightning = 2013,
        [Description("Add Endurance Charge On Kill")]
        AddEnduranceChargeOnKill = 2014,
        [Description("Unique Lose All Endurance Charges When Hit")]
        UniqueLoseAllEnduranceChargesWhenHit = 2015,
        [Description("Unique Gain Onslaught When Hit Duration Ms")]
        UniqueGainOnslaughtWhenHitDurationMs = 2016,
        [Description("Chance To Counter Strike When Hit %")]
        ChanceToCounterStrikeWhenHitPct = 2017,
        [Description("Hundred Times Average Damage Per Hit")]
        HundredTimesAverageDamagePerHit = 2018,
        [Description("Hundred Times Average Damage Per Skill Use")]
        HundredTimesAverageDamagePerSkillUse = 2019,
        [Description("Base Skill Show Average Damage Instead Of Dps")]
        BaseSkillShowAverageDamageInsteadOfDps = 2020,
        [Description("Display Hundred Times Damage Per Skill Use")]
        DisplayHundredTimesDamagePerSkillUse = 2021,
        [Description("Base Monster Will Be Deleted On Death")]
        BaseMonsterWillBeDeletedOnDeath = 2022,
        [Description("Monster Will Be Deleted On Death")]
        MonsterWillBeDeletedOnDeath = 2023,
        [Description("Charged Blast Spell Damage +% Final Per Stack")]
        ChargedBlastSpellDamagePosPctFinalPerStack = 2024,
        [Description("From Code Active Skill Spell Damage +% Final")]
        FromCodeActiveSkillSpellDamagePosPctFinal = 2025,
        [Description("Leech X Life Per Spell Cast")]
        LeechXLifePerSpellCast = 2026,
        [Description("Zero Elemental Resistance")]
        ZeroElementalResistance = 2027,
        [Description("Global Defences +%")]
        GlobalDefencesPosPct = 2028,
        [Description("Minimum Lightning Damage To Return On Block")]
        MinimumLightningDamageToReturnOnBlock = 2029,
        [Description("Maximum Lightning Damage To Return On Block")]
        MaximumLightningDamageToReturnOnBlock = 2030,
        [Description("Leap Slam Spawn X Zombies On Impact")]
        LeapSlamSpawnXZombiesOnImpact = 2031,
        [Description("Culling Strike On Burning Enemies")]
        CullingStrikeOnBurningEnemies = 2032,
        [Description("Gain Frenzy Charge If Attack Ignites")]
        GainFrenzyChargeIfAttackIgnites = 2033,
        [Description("Map Monsters Are Immune To Curses")]
        MapMonstersAreImmuneToCurses = 2034,
        [Description("Map Packs Are Animals")]
        MapPacksAreAnimals = 2035,
        [Description("Map Packs Are Demons")]
        MapPacksAreDemons = 2036,
        [Description("Map Packs Are Humanoids")]
        MapPacksAreHumanoids = 2037,
        [Description("Monster Drop Higher Level Gear")]
        MonsterDropHigherLevelGear = 2038,
        [Description("Regenerate X Life Over 1 Second On Cast")]
        RegenerateXLifeOver1SecondOnCast = 2039,
        [Description("Map Monsters Gain X Power Charges Every 20 Seconds")]
        MapMonstersGainXPowerChargesEvery20Seconds = 2040,
        [Description("Map Monsters Gain X Endurance Charges Every 20 Seconds")]
        MapMonstersGainXEnduranceChargesEvery20Seconds = 2041,
        [Description("Damage +% Per 10 Levels")]
        DamagePosPctPer10Levels = 2042,
        [Description("Monster Caustic Cloud On Death % Max Damage To Deal Per Minute")]
        MonsterCausticCloudOnDeathPctMaxDamageToDealPerMinute = 2043,
        [Description("Monster Caustic Cloud On Death Base Area Of Effect Radius")]
        MonsterCausticCloudOnDeathBaseAreaOfEffectRadius = 2044,
        [Description("Monster Caustic Cloud On Death Duration Ms")]
        MonsterCausticCloudOnDeathDurationMs = 2045,
        [Description("Chaos Damage Taken +")]
        ChaosDamageTakenPos = 2046,
        [Description("Local Socketed Curse Gem Level +")]
        LocalSocketedCurseGemLevelPos = 2047,
        [Description("Base Curse Duration +%")]
        BaseCurseDurationPosPct = 2048,
        [Description("Curse Duration +%")]
        CurseDurationPosPct = 2049,
        [Description("Curse Effect Duration")]
        CurseEffectDuration = 2050,
        [Description("Self Curse Duration +%")]
        SelfCurseDurationPosPct = 2051,
        [Description("Local Display Socketed Gems Get Flee Level")]
        LocalDisplaySocketedGemsGetFleeLevel = 2052,
        [Description("Dexterity +%")]
        DexterityPosPct = 2053,
        [Description("Strength +%")]
        StrengthPosPct = 2054,
        [Description("Intelligence +%")]
        IntelligencePosPct = 2055,
        [Description("Display Map Final Boss Drops Higher Level Gear")]
        DisplayMapFinalBossDropsHigherLevelGear = 2056,
        [Description("Chaos Resistance + While Using Flask")]
        ChaosResistancePosWhileUsingFlask = 2057,
        [Description("Minimum Physical Damage To Reflect To Self On Attack")]
        MinimumPhysicalDamageToReflectToSelfOnAttack = 2058,
        [Description("Maximum Physical Damage To Reflect To Self On Attack")]
        MaximumPhysicalDamageToReflectToSelfOnAttack = 2059,
        [Description("Is Bleeding")]
        IsBleeding = 2060,
        [Description("Damage +% Vs Bleeding Enemies")]
        DamagePosPctVsBleedingEnemies = 2061,
        [Description("Unique Gain Onslaught When Hit Duration Ms Per Endurance Charge")]
        UniqueGainOnslaughtWhenHitDurationMsPerEnduranceCharge = 2062,
        [Description("Unique Gain Endurance Charges Instead Of Frenzy Charges")]
        UniqueGainEnduranceChargesInsteadOfFrenzyCharges = 2063,
        [Description("Unique Gain Endurance Charges Instead Of Power Charges")]
        UniqueGainEnduranceChargesInsteadOfPowerCharges = 2064,
        [Description("Fire Damage Taken +%")]
        FireDamageTakenPosPct = 2065,
        [Description("Crits Have Culling Strike")]
        CritsHaveCullingStrike = 2066,
        [Description("Support Projectile Attack Physical Damage +% Final")]
        SupportProjectileAttackPhysicalDamagePosPctFinal = 2067,
        [Description("Support Projectile Attack Speed +% Final")]
        SupportProjectileAttackSpeedPosPctFinal = 2068,
        [Description("Supported Active Skill Gem Expereince Gained +%")]
        SupportedActiveSkillGemExpereinceGainedPosPct = 2069,
        [Description("Flame Whip Damage +% Final Vs Burning Enemies")]
        FlameWhipDamagePosPctFinalVsBurningEnemies = 2070,
        [Description("Unique Spread Poison To Nearby Enemies On Kill")]
        UniqueSpreadPoisonToNearbyEnemiesOnKill = 2071,
        [Description("Unique Spread Poison To Nearby Allies As Regeneration On Kill")]
        UniqueSpreadPoisonToNearbyAlliesAsRegenerationOnKill = 2072,
        [Description("Uncapped Fire Damage Resistance %")]
        UncappedFireDamageResistancePct = 2073,
        [Description("Uncapped Cold Damage Resistance %")]
        UncappedColdDamageResistancePct = 2074,
        [Description("Uncapped Lightning Damage Resistance %")]
        UncappedLightningDamageResistancePct = 2075,
        [Description("Uncapped Chaos Damage Resistance %")]
        UncappedChaosDamageResistancePct = 2076,
        [Description("Local Ring Duplicate Other Ring")]
        LocalRingDuplicateOtherRing = 2077,
        [Description("Duplicate Ring Slot 1")]
        DuplicateRingSlot1 = 2078,
        [Description("Duplicate Ring Slot 2")]
        DuplicateRingSlot2 = 2079,
        [Description("Unique Fire Damage Shocks")]
        UniqueFireDamageShocks = 2080,
        [Description("Unique Cold Damage Ignites")]
        UniqueColdDamageIgnites = 2081,
        [Description("Unique Lightning Damage Freezes")]
        UniqueLightningDamageFreezes = 2082,
        [Description("Fire Damage Can Shock")]
        FireDamageCanShock = 2083,
        [Description("Cold Damage Can Ignite")]
        ColdDamageCanIgnite = 2084,
        [Description("Lightning Damage Can Freeze")]
        LightningDamageCanFreeze = 2085,
        [Description("Fire Damage Cannot Ignite")]
        FireDamageCannotIgnite = 2086,
        [Description("Cold Damage Cannot Freeze")]
        ColdDamageCannotFreeze = 2087,
        [Description("Lightning Damage Cannot Shock")]
        LightningDamageCannotShock = 2088,
        [Description("Can Catch Exotic Fish")]
        CanCatchExoticFish = 2089,
        [Description("Transfer Curses To X Nearby Enemies On Kill")]
        TransferCursesToXNearbyEnemiesOnKill = 2090,
        [Description("Freeze As Though Dealt Damage +%")]
        FreezeAsThoughDealtDamagePosPct = 2091,
        [Description("Chill Prevention Ms When Chilled")]
        ChillPreventionMsWhenChilled = 2092,
        [Description("Freeze Prevention Ms When Frozen")]
        FreezePreventionMsWhenFrozen = 2093,
        [Description("Ignite Prevention Ms When Ignited")]
        IgnitePreventionMsWhenIgnited = 2094,
        [Description("Shock Prevention Ms When Shocked")]
        ShockPreventionMsWhenShocked = 2095,
        [Description("Grant X Frenzy Charges To Nearby Allies On Death")]
        GrantXFrenzyChargesToNearbyAlliesOnDeath = 2096,
        [Description("Unique Gain Power Charge On Non Crit")]
        UniqueGainPowerChargeOnNonCrit = 2097,
        [Description("Unique Lose All Power Charges On Crit")]
        UniqueLoseAllPowerChargesOnCrit = 2098,
        [Description("Curse Area Of Effect +%")]
        CurseAreaOfEffectPosPct = 2099,
        [Description("Support Spell Totem Cast Speed +% Final")]
        SupportSpellTotemCastSpeedPosPctFinal = 2100,
        [Description("Support Attack Totem Attack Speed +% Final")]
        SupportAttackTotemAttackSpeedPosPctFinal = 2101,
        [Description("Map Non Unique Monsters Spawn X Monsters On Death")]
        MapNonUniqueMonstersSpawnXMonstersOnDeath = 2102,
        [Description("Local Unique Attacks Cast Socketed Lightning Spells %")]
        LocalUniqueAttacksCastSocketedLightningSpellsPct = 2103,
        [Description("Main Hand Local Unique Attacks Cast Socketed Lightning Spells %")]
        MainHandLocalUniqueAttacksCastSocketedLightningSpellsPct = 2104,
        [Description("Off Hand Local Unique Attacks Cast Socketed Lightning Spells %")]
        OffHandLocalUniqueAttacksCastSocketedLightningSpellsPct = 2105,
        [Description("Local Display Aura Curse Effect On Self +%")]
        LocalDisplayAuraCurseEffectOnSelfPosPct = 2106,
        [Description("Flask Minion Heal %")]
        FlaskMinionHealPct = 2107,
        [Description("Minion Block %")]
        MinionBlockPct = 2108,
        [Description("Minion Physical Damage Reduction Rating")]
        MinionPhysicalDamageReductionRating = 2109,
        [Description("Untargetable By Monster Ai")]
        UntargetableByMonsterAi = 2110,
        [Description("Desecrate Number Of Corpses To Create")]
        DesecrateNumberOfCorpsesToCreate = 2111,
        [Description("Local Display Aura Damage +% Allies Only")]
        LocalDisplayAuraDamagePosPctAlliesOnly = 2112,
        [Description("Map Invasion Monster Packs")]
        MapInvasionMonsterPacks = 2113,
        [Description("Base Spell Block %")]
        BaseSpellBlockPct = 2114,
        [Description("Minion Attack Speed +%")]
        MinionAttackSpeedPosPct = 2115,
        [Description("Minion Cast Speed +%")]
        MinionCastSpeedPosPct = 2116,
        [Description("Old Do Not Use Minion Life Leech From Any Damage Permyriad")]
        OldDoNotUseMinionLifeLeechFromAnyDamagePermyriad = 2117,
        [Description("Minion Life Regeneration Rate Per Minute %")]
        MinionLifeRegenerationRatePerMinutePct = 2118,
        [Description("Minion Elemental Resistance %")]
        MinionElementalResistancePct = 2119,
        [Description("Minion Chaos Resistance %")]
        MinionChaosResistancePct = 2120,
        [Description("Skill Show Average Damage Instead Of Dps")]
        SkillShowAverageDamageInsteadOfDps = 2121,
        [Description("Offering Skill Effect Duration Per Corpse")]
        OfferingSkillEffectDurationPerCorpse = 2122,
        [Description("Unholy Might On Kill Duration Ms")]
        UnholyMightOnKillDurationMs = 2123,
        [Description("Minion Unholy Might On Kill Duration Ms")]
        MinionUnholyMightOnKillDurationMs = 2124,
        [Description("Chest Delay Drops Until Daemons Finish")]
        ChestDelayDropsUntilDaemonsFinish = 2125,
        [Description("Base Number Of Raging Spirits Allowed")]
        BaseNumberOfRagingSpiritsAllowed = 2126,
        [Description("Number Of Raging Spirits Allowed")]
        NumberOfRagingSpiritsAllowed = 2127,
        [Description("Chest Play Warning Sound")]
        ChestPlayWarningSound = 2128,
        [Description("Chest Drop Additional Unqiue Items")]
        ChestDropAdditionalUnqiueItems = 2129,
        [Description("Upheaval Number Of Spikes")]
        UpheavalNumberOfSpikes = 2130,
        [Description("Chest Display Summons Skeletons")]
        ChestDisplaySummonsSkeletons = 2131,
        [Description("Chest Display Ice Nova")]
        ChestDisplayIceNova = 2132,
        [Description("Chest Display Freeze")]
        ChestDisplayFreeze = 2133,
        [Description("Cyclone Places Ground Desecration Chaos Damage Per Minute")]
        CyclonePlacesGroundDesecrationChaosDamagePerMinute = 2134,
        [Description("Firestorm Drop Ground Ice Duration Ms")]
        FirestormDropGroundIceDurationMs = 2135,
        [Description("Vaal Burning Arrow Explode On Hit")]
        VaalBurningArrowExplodeOnHit = 2136,
        [Description("Molten Shell Explode Each Hit")]
        MoltenShellExplodeEachHit = 2137,
        [Description("Desecrate Corpse Level")]
        DesecrateCorpseLevel = 2138,
        [Description("Lightning Warp Remove Delay")]
        LightningWarpRemoveDelay = 2139,
        [Description("Immortal Call Prevent All Damage")]
        ImmortalCallPreventAllDamage = 2140,
        [Description("Power Siphon Fire At All Targets")]
        PowerSiphonFireAtAllTargets = 2141,
        [Description("Rain Of Arrows Place Shocking Ground Duration Ms")]
        RainOfArrowsPlaceShockingGroundDurationMs = 2142,
        [Description("Leap Slam Base Caustic Cloud Damage To Deal Per Minute")]
        LeapSlamBaseCausticCloudDamageToDealPerMinute = 2143,
        [Description("Base Number Of Projectiles In Spiral Nova")]
        BaseNumberOfProjectilesInSpiralNova = 2144,
        [Description("Projectile Spiral Nova Time Ms")]
        ProjectileSpiralNovaTimeMs = 2145,
        [Description("Projectile Spiral Nova Angle")]
        ProjectileSpiralNovaAngle = 2146,
        [Description("Kiweth Consume Leech % Max Life")]
        KiwethConsumeLeechPctMaxLife = 2147,
        [Description("Ice Nova Number Of Repeats")]
        IceNovaNumberOfRepeats = 2148,
        [Description("Ice Nova Radius +% Per Repeat")]
        IceNovaRadiusPosPctPerRepeat = 2149,
        [Description("Local Display Socketed Gems Have Iron Will")]
        LocalDisplaySocketedGemsHaveIronWill = 2150,
        [Description("Local Display Socketed Gems Chain X Additional Times")]
        LocalDisplaySocketedGemsChainXAdditionalTimes = 2151,
        [Description("Old Do Not Use Base Life Leech From Physical Damage Permyriad")]
        OldDoNotUseBaseLifeLeechFromPhysicalDamagePermyriad = 2152,
        [Description("Old Do Not Use Base Life Leech From Fire Damage Permyriad")]
        OldDoNotUseBaseLifeLeechFromFireDamagePermyriad = 2153,
        [Description("Old Do Not Use Base Life Leech From Cold Damage Permyriad")]
        OldDoNotUseBaseLifeLeechFromColdDamagePermyriad = 2154,
        [Description("Old Do Not Use Base Life Leech From Lightning Damage Permyriad")]
        OldDoNotUseBaseLifeLeechFromLightningDamagePermyriad = 2155,
        [Description("Base Life Leech From Chaos Damage Permyriad")]
        BaseLifeLeechFromChaosDamagePermyriad = 2156,
        [Description("Base Mana Leech From Physical Damage Permyriad")]
        BaseManaLeechFromPhysicalDamagePermyriad = 2157,
        [Description("Base Mana Leech From Fire Damage Permyriad")]
        BaseManaLeechFromFireDamagePermyriad = 2158,
        [Description("Base Mana Leech From Cold Damage Permyriad")]
        BaseManaLeechFromColdDamagePermyriad = 2159,
        [Description("Old Do Not Use Base Mana Leech From Lightning Damage Permyriad")]
        OldDoNotUseBaseManaLeechFromLightningDamagePermyriad = 2160,
        [Description("Base Mana Leech From Chaos Damage Permyriad")]
        BaseManaLeechFromChaosDamagePermyriad = 2161,
        [Description("Base Leech Is Instant On Critical")]
        BaseLeechIsInstantOnCritical = 2162,
        [Description("Local Socketed Vaal Gem Level +")]
        LocalSocketedVaalGemLevelPos = 2163,
        [Description("Elemental Damage % To Add As Chaos")]
        ElementalDamagePctToAddAsChaos = 2164,
        [Description("Chance To Ignite % While Using Flask")]
        ChanceToIgnitePctWhileUsingFlask = 2165,
        [Description("Chance To Freeze % While Using Flask")]
        ChanceToFreezePctWhileUsingFlask = 2166,
        [Description("Chance To Shock % While Using Flask")]
        ChanceToShockPctWhileUsingFlask = 2167,
        [Description("Stun Threshold Reduction +% While Using Flask")]
        StunThresholdReductionPosPctWhileUsingFlask = 2168,
        [Description("Local Unique Flask Physical Damage % To Add As Chaos While Healing")]
        LocalUniqueFlaskPhysicalDamagePctToAddAsChaosWhileHealing = 2169,
        [Description("Local Unique Flask Elemental Damage % To Add As Chaos While Healing")]
        LocalUniqueFlaskElementalDamagePctToAddAsChaosWhileHealing = 2170,
        [Description("Old Do Not Use Local Unique Flask Life Leech From Chaos Damage Permyriad While Healing")]
        OldDoNotUseLocalUniqueFlaskLifeLeechFromChaosDamagePermyriadWhileHealing = 2171,
        [Description("Local Display Socketed Spells Repeat Count")]
        LocalDisplaySocketedSpellsRepeatCount = 2172,
        [Description("Map Ambush Chests")]
        MapAmbushChests = 2173,
        [Description("Atziri Do Not Gain Skill Charges")]
        AtziriDoNotGainSkillCharges = 2174,
        [Description("Chest Hidden Item Quantity +%")]
        ChestHiddenItemQuantityPosPct = 2175,
        [Description("Chest Hidden Item Rarity +%")]
        ChestHiddenItemRarityPosPct = 2176,
        [Description("Monster Drop Vaal Fragment Chance")]
        MonsterDropVaalFragmentChance = 2177,
        [Description("Summoned Monster Rarity")]
        SummonedMonsterRarity = 2178,
        [Description("Number Of Monsters To Summon")]
        NumberOfMonstersToSummon = 2179,
        [Description("Chest Gems Drop With Experience")]
        ChestGemsDropWithExperience = 2180,
        [Description("Chest Drops Additional Utility Flasks")]
        ChestDropsAdditionalUtilityFlasks = 2181,
        [Description("Chest Items Drop Identified")]
        ChestItemsDropIdentified = 2182,
        [Description("Chest Drop Additional Normal Items Up To")]
        ChestDropAdditionalNormalItemsUpTo = 2183,
        [Description("Chest Drop Additional Magic Items Up To")]
        ChestDropAdditionalMagicItemsUpTo = 2184,
        [Description("Chest Drop Additional Rare Items Up To")]
        ChestDropAdditionalRareItemsUpTo = 2185,
        [Description("Chest Dropped Items Have Quality %")]
        ChestDroppedItemsHaveQualityPct = 2186,
        [Description("Dropped Items Have Additional Sockets")]
        DroppedItemsHaveAdditionalSockets = 2187,
        [Description("Dropped Items Are Fully Linked")]
        DroppedItemsAreFullyLinked = 2188,
        [Description("Chest Dropped Item Level +")]
        ChestDroppedItemLevelPos = 2189,
        [Description("Dropped Items Are Duplicated")]
        DroppedItemsAreDuplicated = 2190,
        [Description("Monster Unlock Chests On Death")]
        MonsterUnlockChestsOnDeath = 2191,
        [Description("Local Display Socketed Gems Mana Cost -%")]
        LocalDisplaySocketedGemsManaCostNegPct = 2192,
        [Description("Chest Spawn Rogue Exiles")]
        ChestSpawnRogueExiles = 2193,
        [Description("Chest Display Revive Nearby Monsters")]
        ChestDisplayReviveNearbyMonsters = 2194,
        [Description("Chest Display Spawns Monsters Continuously")]
        ChestDisplaySpawnsMonstersContinuously = 2195,
        [Description("Chest Display Explodes Corpses")]
        ChestDisplayExplodesCorpses = 2196,
        [Description("Chest Camoflaged")]
        ChestCamoflaged = 2197,
        [Description("Chest Display Cast Random Curse")]
        ChestDisplayCastRandomCurse = 2198,
        [Description("Chest Display Ignite")]
        ChestDisplayIgnite = 2199,
        [Description("Chest Display Fire Storm")]
        ChestDisplayFireStorm = 2200,
        [Description("Chest Display Caustic Clouds")]
        ChestDisplayCausticClouds = 2201,
        [Description("Chest Display Explosion")]
        ChestDisplayExplosion = 2202,
        [Description("Chest Drops Only Hybrid Flasks")]
        ChestDropsOnlyHybridFlasks = 2203,
        [Description("Chest Drops Only Support Gems")]
        ChestDropsOnlySupportGems = 2204,
        [Description("Chest Drops Extra Vaal Gems")]
        ChestDropsExtraVaalGems = 2205,
        [Description("Firestorm Drop Ground Shock Duration Ms")]
        FirestormDropGroundShockDurationMs = 2206,
        [Description("Detonate Dead Chain Explode")]
        DetonateDeadChainExplode = 2207,
        [Description("Corrupted Blood Cleave Stacks To Add")]
        CorruptedBloodCleaveStacksToAdd = 2208,
        [Description("Desecrated Ground Art Variation")]
        DesecratedGroundArtVariation = 2209,
        [Description("Kiweth Projectile Spawn Kiweth")]
        KiwethProjectileSpawnKiweth = 2210,
        [Description("Rain Of Arrows Pin")]
        RainOfArrowsPin = 2211,
        [Description("Onslaught On Vaal Skill Use Duration Ms")]
        OnslaughtOnVaalSkillUseDurationMs = 2212,
        [Description("Cold Snap Ground Ice")]
        ColdSnapGroundIce = 2213,
        [Description("Num Ghost Monkeys To Summon")]
        NumGhostMonkeysToSummon = 2214,
        [Description("Smoke Mine Spawn X Snakes On Teleport")]
        SmokeMineSpawnXSnakesOnTeleport = 2215,
        [Description("Num Sandspitters To Summon")]
        NumSandspittersToSummon = 2216,
        [Description("Vaal Lightning Strike Beam Damage +% Final")]
        VaalLightningStrikeBeamDamagePosPctFinal = 2217,
        [Description("Atziri Lightning Charge Requirement -")]
        AtziriLightningChargeRequirementNeg = 2218,
        [Description("Atziri Fire Charge Requirement -")]
        AtziriFireChargeRequirementNeg = 2219,
        [Description("Atziri Physical Charge Requirement -")]
        AtziriPhysicalChargeRequirementNeg = 2220,
        [Description("Life Leech From Physical Damage Permyriad")]
        LifeLeechFromPhysicalDamagePermyriad = 2221,
        [Description("Life Leech From Fire Damage Permyriad")]
        LifeLeechFromFireDamagePermyriad = 2222,
        [Description("Life Leech From Cold Damage Permyriad")]
        LifeLeechFromColdDamagePermyriad = 2223,
        [Description("Life Leech From Lightning Damage Permyriad")]
        LifeLeechFromLightningDamagePermyriad = 2224,
        [Description("Life Leech From Chaos Damage Permyriad")]
        LifeLeechFromChaosDamagePermyriad = 2225,
        [Description("Mana Leech From Physical Damage Permyriad")]
        ManaLeechFromPhysicalDamagePermyriad = 2226,
        [Description("Mana Leech From Fire Damage Permyriad")]
        ManaLeechFromFireDamagePermyriad = 2227,
        [Description("Mana Leech From Cold Damage Permyriad")]
        ManaLeechFromColdDamagePermyriad = 2228,
        [Description("Mana Leech From Lightning Damage Permyriad")]
        ManaLeechFromLightningDamagePermyriad = 2229,
        [Description("Mana Leech From Chaos Damage Permyriad")]
        ManaLeechFromChaosDamagePermyriad = 2230,
        [Description("Old Do Not Use Base Life Leech From Elemental Damage Permyriad")]
        OldDoNotUseBaseLifeLeechFromElementalDamagePermyriad = 2231,
        [Description("Base Mana Leech From Elemental Damage Permyriad")]
        BaseManaLeechFromElementalDamagePermyriad = 2232,
        [Description("Keystone Vampirism Life Leech Amount +% Final")]
        KeystoneVampirismLifeLeechAmountPosPctFinal = 2233,
        [Description("Attack Minimum Added Physical Damage With Bow")]
        AttackMinimumAddedPhysicalDamageWithBow = 2234,
        [Description("Attack Maximum Added Physical Damage With Bow")]
        AttackMaximumAddedPhysicalDamageWithBow = 2235,
        [Description("Attack Minimum Added Fire Damage With Bow")]
        AttackMinimumAddedFireDamageWithBow = 2236,
        [Description("Attack Maximum Added Fire Damage With Bow")]
        AttackMaximumAddedFireDamageWithBow = 2237,
        [Description("Number Of Packs To Summon")]
        NumberOfPacksToSummon = 2238,
        [Description("Summon Monster Radius")]
        SummonMonsterRadius = 2239,
        [Description("Resist Life Leech %")]
        ResistLifeLeechPct = 2240,
        [Description("Resist Mana Leech %")]
        ResistManaLeechPct = 2241,
        [Description("Life Leech Amount +%")]
        LifeLeechAmountPosPct = 2242,
        [Description("Level 11 Or Lower Life +% Final")]
        Level11OrLowerLifePosPctFinal = 2243,
        [Description("Local Socketed Support Gem Level +")]
        LocalSocketedSupportGemLevelPos = 2244,
        [Description("Level 33 Or Lower Life +% Final")]
        Level33OrLowerLifePosPctFinal = 2245,
        [Description("Level 33 Or Lower Damage +% Final")]
        Level33OrLowerDamagePosPctFinal = 2246,
        [Description("Display Monster Casts Vaal Detonate Dead Text")]
        DisplayMonsterCastsVaalDetonateDeadText = 2247,
        [Description("Minions Have Chest Summon Indicator")]
        MinionsHaveChestSummonIndicator = 2248,
        [Description("Curse On Hit Level Temporal Chains")]
        CurseOnHitLevelTemporalChains = 2249,
        [Description("Curse On Hit Level Vulnerability")]
        CurseOnHitLevelVulnerability = 2250,
        [Description("Curse On Hit Level Elemental Weakness")]
        CurseOnHitLevelElementalWeakness = 2251,
        [Description("Local Display Socketed Gems Get Melee Splash Level")]
        LocalDisplaySocketedGemsGetMeleeSplashLevel = 2252,
        [Description("Local Display Socketed Gems Get Cast On Crit Level")]
        LocalDisplaySocketedGemsGetCastOnCritLevel = 2253,
        [Description("Local Display Socketed Gems Get Cast When Stunned Level")]
        LocalDisplaySocketedGemsGetCastWhenStunnedLevel = 2254,
        [Description("Is Double")]
        IsDouble = 2255,
        [Description("Can Catch Corrupted Fish")]
        CanCatchCorruptedFish = 2256,
        [Description("Disable Animated Armour")]
        DisableAnimatedArmour = 2257,
        [Description("Number Of Archer Skeletons To Summon")]
        NumberOfArcherSkeletonsToSummon = 2258,
        [Description("Number Of Mage Skeletons To Summon")]
        NumberOfMageSkeletonsToSummon = 2259,
        [Description("Number Of Leader Skeletons To Summon")]
        NumberOfLeaderSkeletonsToSummon = 2260,
        [Description("Map Spawn Extra Exiles")]
        MapSpawnExtraExiles = 2261,
        [Description("Map Disable New Instance Management")]
        MapDisableNewInstanceManagement = 2262,
        [Description("Local Display Socketed Gems Get Mana Multplier %")]
        LocalDisplaySocketedGemsGetManaMultplierPct = 2263,
        [Description("Local Display Socketed Gems Get Stun Level")]
        LocalDisplaySocketedGemsGetStunLevel = 2264,
        [Description("Local Display Socketed Gems Get Additional Accuracy Level")]
        LocalDisplaySocketedGemsGetAdditionalAccuracyLevel = 2265,
        [Description("Local Display Socketed Gems Get Multistrike Level")]
        LocalDisplaySocketedGemsGetMultistrikeLevel = 2266,
        [Description("Local Display Socketed Gems Get Faster Projectiles Level")]
        LocalDisplaySocketedGemsGetFasterProjectilesLevel = 2267,
        [Description("Local Display Socketed Gems Get Life Leech Level")]
        LocalDisplaySocketedGemsGetLifeLeechLevel = 2268,
        [Description("Local Display Socketed Gems Get Increased Critical Damage Level")]
        LocalDisplaySocketedGemsGetIncreasedCriticalDamageLevel = 2269,
        [Description("Local Display Socketed Gems Get Fork Level")]
        LocalDisplaySocketedGemsGetForkLevel = 2270,
        [Description("Local Display Socketed Gems Get Weapon Elemental Damage Level")]
        LocalDisplaySocketedGemsGetWeaponElementalDamageLevel = 2271,
        [Description("Local Display Grants Skill Purity Of Fire Level")]
        LocalDisplayGrantsSkillPurityOfFireLevel = 2272,
        [Description("Local Display Grants Skill Purity Of Cold Level")]
        LocalDisplayGrantsSkillPurityOfColdLevel = 2273,
        [Description("Local Display Grants Skill Purity Of Lightning Level")]
        LocalDisplayGrantsSkillPurityOfLightningLevel = 2274,
        [Description("Local Display Grants Skill Flammability Level")]
        LocalDisplayGrantsSkillFlammabilityLevel = 2275,
        [Description("Local Display Grants Skill Conductivity Level")]
        LocalDisplayGrantsSkillConductivityLevel = 2276,
        [Description("Local Display Grants Skill Frostbite Level")]
        LocalDisplayGrantsSkillFrostbiteLevel = 2277,
        [Description("Local Display Grants Skill Temporal Chains Level")]
        LocalDisplayGrantsSkillTemporalChainsLevel = 2278,
        [Description("Local Display Grants Skill Haste Level")]
        LocalDisplayGrantsSkillHasteLevel = 2279,
        [Description("Local Display Grants Skill Clarity Level")]
        LocalDisplayGrantsSkillClarityLevel = 2280,
        [Description("Local Display Grants Skill Vitality Level")]
        LocalDisplayGrantsSkillVitalityLevel = 2281,
        [Description("Local Display Grants Skill Purity Level")]
        LocalDisplayGrantsSkillPurityLevel = 2282,
        [Description("Local Display Grants Skill Critical Weakness Level")]
        LocalDisplayGrantsSkillCriticalWeaknessLevel = 2283,
        [Description("Local Display Grants Skill Wrath Level")]
        LocalDisplayGrantsSkillWrathLevel = 2284,
        [Description("Local Display Grants Skill Hatred Level")]
        LocalDisplayGrantsSkillHatredLevel = 2285,
        [Description("Local Display Grants Skill Anger Level")]
        LocalDisplayGrantsSkillAngerLevel = 2286,
        [Description("Local Display Grants Skill Determination Level")]
        LocalDisplayGrantsSkillDeterminationLevel = 2287,
        [Description("Local Display Grants Skill Grace Level")]
        LocalDisplayGrantsSkillGraceLevel = 2288,
        [Description("Local Display Grants Skill Discipline Level")]
        LocalDisplayGrantsSkillDisciplineLevel = 2289,
        [Description("Local Display Grants Skill Projectile Weakness Level")]
        LocalDisplayGrantsSkillProjectileWeaknessLevel = 2290,
        [Description("Local Display Grants Skill Elemental Weakness Level")]
        LocalDisplayGrantsSkillElementalWeaknessLevel = 2291,
        [Description("Local Display Grants Skill Vulnerability Level")]
        LocalDisplayGrantsSkillVulnerabilityLevel = 2292,
        [Description("Cold Damage Cannot Chill")]
        ColdDamageCannotChill = 2293,
        [Description("Elemental Damage Taken % As Chaos")]
        ElementalDamageTakenPctAsChaos = 2294,
        [Description("Fire Damage Taken % As Chaos")]
        FireDamageTakenPctAsChaos = 2295,
        [Description("Cold Damage Taken % As Chaos")]
        ColdDamageTakenPctAsChaos = 2296,
        [Description("Lightning Damage Taken % As Chaos")]
        LightningDamageTakenPctAsChaos = 2297,
        [Description("Global Reduce Enemy Block %")]
        GlobalReduceEnemyBlockPct = 2298,
        [Description("Base Spell Repeat Count")]
        BaseSpellRepeatCount = 2299,
        [Description("Spell Repeat Count")]
        SpellRepeatCount = 2300,
        [Description("Pvp Damage +% Final Scale")]
        PvpDamagePosPctFinalScale = 2301,
        [Description("Physical Damage Taken + Vs Beasts")]
        PhysicalDamageTakenPosVsBeasts = 2302,
        [Description("Local Strength Requirement +")]
        LocalStrengthRequirementPos = 2303,
        [Description("Local Dexterity Requirement +")]
        LocalDexterityRequirementPos = 2304,
        [Description("Local Intelligence Requirement +")]
        LocalIntelligenceRequirementPos = 2305,
        [Description("Display Monster Vaal Storm Call")]
        DisplayMonsterVaalStormCall = 2306,
        [Description("Reave Rotation On Repeat")]
        ReaveRotationOnRepeat = 2307,
        [Description("Reave Additional Max Stacks")]
        ReaveAdditionalMaxStacks = 2308,
        [Description("Reave Additional Starting Stacks")]
        ReaveAdditionalStartingStacks = 2309,
        [Description("Bleed On Melee Crit Chance %")]
        BleedOnMeleeCritChancePct = 2310,
        [Description("Bleed On Melee Crit Chance Duration Ms")]
        BleedOnMeleeCritChanceDurationMs = 2311,
        [Description("Energy Shield Recharge Not Delayed By Damage")]
        EnergyShieldRechargeNotDelayedByDamage = 2312,
        [Description("Maximum Dodge Chance %")]
        MaximumDodgeChancePct = 2313,
        [Description("Maximum Spell Dodge Chance %")]
        MaximumSpellDodgeChancePct = 2314,
        [Description("Weapon Physical Damage % To Add As Random Element")]
        WeaponPhysicalDamagePctToAddAsRandomElement = 2315,
        [Description("Throw Traps In Circle Radius")]
        ThrowTrapsInCircleRadius = 2316,
        [Description("Damage Taken +%")]
        DamageTakenPosPct = 2317,
        [Description("Damage Taken +% Per Frenzy Charge")]
        DamageTakenPosPctPerFrenzyCharge = 2318,
        [Description("Lightning Damage +% Per Frenzy Charge")]
        LightningDamagePosPctPerFrenzyCharge = 2319,
        [Description("Life Gained On Enemy Death")]
        LifeGainedOnEnemyDeath = 2320,
        [Description("Life Gained On Enemy Death Per Frenzy Charge")]
        LifeGainedOnEnemyDeathPerFrenzyCharge = 2321,
        [Description("Vaal Sweep Additional Base Radius For Push")]
        VaalSweepAdditionalBaseRadiusForPush = 2322,
        [Description("Main Hand Weapon Elemental Damage +%")]
        MainHandWeaponElementalDamagePosPct = 2323,
        [Description("Off Hand Weapon Elemental Damage +%")]
        OffHandWeaponElementalDamagePosPct = 2324,
        [Description("Local Attacks With This Weapon Elemental Damage +%")]
        LocalAttacksWithThisWeaponElementalDamagePosPct = 2325,
        [Description("Monster Casts Glacial Cascade Text")]
        MonsterCastsGlacialCascadeText = 2326,
        [Description("Dual Wield Inherent Physical Attack Damage +% Final")]
        DualWieldInherentPhysicalAttackDamagePosPctFinal = 2327,
        [Description("Damage Cannot Be Reflected")]
        DamageCannotBeReflected = 2328,
        [Description("Map Base Ground Desecration Damage To Deal Per Minute")]
        MapBaseGroundDesecrationDamageToDealPerMinute = 2329,
        [Description("Global Poison On Hit")]
        GlobalPoisonOnHit = 2330,
        [Description("Map Monsters Poison On Hit")]
        MapMonstersPoisonOnHit = 2331,
        [Description("Play Jack The Axe Sounds")]
        PlayJackTheAxeSounds = 2332,
        [Description("Sound On Kill Wolf Call")]
        SoundOnKillWolfCall = 2333,
        [Description("Oba Decapitated")]
        ObaDecapitated = 2334,
        [Description("Chest Number Of Additional Kaom Uniques To Drop")]
        ChestNumberOfAdditionalKaomUniquesToDrop = 2335,
        [Description("Chest Drop Additional Number Of Uniques Of Drop Pool Types")]
        ChestDropAdditionalNumberOfUniquesOfDropPoolTypes = 2336,
        [Description("Chest Display Kaom Totems")]
        ChestDisplayKaomTotems = 2337,
        [Description("Map Mission Id")]
        MapMissionId = 2338,
        [Description("Chest No Regular Drops")]
        ChestNoRegularDrops = 2339,
        [Description("Map Side Area Chance +%")]
        MapSideAreaChancePosPct = 2340,
        [Description("Chest Drop Additional Unique Maps")]
        ChestDropAdditionalUniqueMaps = 2341,
        [Description("Map Display Garena Drop Buff")]
        MapDisplayGarenaDropBuff = 2342,
        [Description("Keystone Unwavering Stance")]
        KeystoneUnwaveringStance = 2343,
        [Description("Cannot Evade")]
        CannotEvade = 2344,
        [Description("Never Ignite")]
        NeverIgnite = 2345,
        [Description("Global Chance To Knockback %")]
        GlobalChanceToKnockbackPct = 2346,
        [Description("Local Unique Flask Instantly Recovers % Maximum Life")]
        LocalUniqueFlaskInstantlyRecoversPctMaximumLife = 2347,
        [Description("Local Unique Flask Chaos Damage % Of Maximum Life To Deal Per Minute While Healing")]
        LocalUniqueFlaskChaosDamagePctOfMaximumLifeToDealPerMinuteWhileHealing = 2348,
        [Description("Unique Add Power Charge On Melee Knockback %")]
        UniqueAddPowerChargeOnMeleeKnockbackPct = 2349,
        [Description("Display Map Boss Gives Experience +%")]
        DisplayMapBossGivesExperiencePosPct = 2350,
        [Description("Gain Power Charge When Throwing Trap %")]
        GainPowerChargeWhenThrowingTrapPct = 2351,
        [Description("Local Display Grants Skill Bear Trap Level")]
        LocalDisplayGrantsSkillBearTrapLevel = 2352,
        [Description("Critical Strike Chance +% Per 8 Strength")]
        CriticalStrikeChancePosPctPer8Strength = 2353,
        [Description("Skill Is Trapped")]
        SkillIsTrapped = 2354,
        [Description("Skill Is Mined")]
        SkillIsMined = 2355,
        [Description("Skill Is Totemified")]
        SkillIsTotemified = 2356,
        [Description("Current Rampage Stacks")]
        CurrentRampageStacks = 2357,
        [Description("Max Rampage Stacks")]
        MaxRampageStacks = 2358,
        [Description("Damage +% Per 10 Rampage Stacks")]
        DamagePosPctPer10RampageStacks = 2359,
        [Description("Movement Velocity +% Per 10 Rampage Stacks")]
        MovementVelocityPosPctPer10RampageStacks = 2360,
        [Description("Map Players Gain Rampage Stacks")]
        MapPlayersGainRampageStacks = 2361,
        [Description("Map Disable Missions")]
        MapDisableMissions = 2362,
        [Description("Map Spawn Map Portal")]
        MapSpawnMapPortal = 2363,
        [Description("Local Unique Flask Block % While Healing")]
        LocalUniqueFlaskBlockPctWhileHealing = 2364,
        [Description("Local Unique Flask Spell Block % While Healing")]
        LocalUniqueFlaskSpellBlockPctWhileHealing = 2365,
        [Description("Map Beyond Rules")]
        MapBeyondRules = 2366,
        [Description("Map Extra Ruleset")]
        MapExtraRuleset = 2367,
        [Description("Map Mission Variation")]
        MapMissionVariation = 2368,
        [Description("Ground Spikes Physical Damage To Deal Per Minute")]
        GroundSpikesPhysicalDamageToDealPerMinute = 2369,
        [Description("Ground Spikes Moving Physical Damage To Deal Per Minute")]
        GroundSpikesMovingPhysicalDamageToDealPerMinute = 2370,
        [Description("Attack Speed +% While Ignited")]
        AttackSpeedPosPctWhileIgnited = 2371,
        [Description("Cast Speed +% While Ignited")]
        CastSpeedPosPctWhileIgnited = 2372,
        [Description("Chance To Ignite % While Ignited")]
        ChanceToIgnitePctWhileIgnited = 2373,
        [Description("Fire Nova Damage +% Per Repeat Final")]
        FireNovaDamagePosPctPerRepeatFinal = 2374,
        [Description("Lightning Trap Projectiles Leave Shocking Ground")]
        LightningTrapProjectilesLeaveShockingGround = 2375,
        [Description("Main Hand Weapon Physical Damage +% Per 250 Evasion")]
        MainHandWeaponPhysicalDamagePosPctPer250Evasion = 2376,
        [Description("Off Hand Weapon Physical Damage +% Per 250 Evasion")]
        OffHandWeaponPhysicalDamagePosPctPer250Evasion = 2377,
        [Description("Local Attacks With This Weapon Physical Damage +% Per 250 Evasion")]
        LocalAttacksWithThisWeaponPhysicalDamagePosPctPer250Evasion = 2378,
        [Description("Map Cagan Has Hidden Mods")]
        MapCaganHasHiddenMods = 2379,
        [Description("Cyclone Places Ground Tar Movement Speed +%")]
        CyclonePlacesGroundTarMovementSpeedPosPct = 2380,
        [Description("Wand Damage +%")]
        WandDamagePosPct = 2381,
        [Description("Cast Speed While Dual Wielding +%")]
        CastSpeedWhileDualWieldingPosPct = 2382,
        [Description("Shield Spell Block %")]
        ShieldSpellBlockPct = 2383,
        [Description("Local Display Socketed Gems Get Echo Level")]
        LocalDisplaySocketedGemsGetEchoLevel = 2384,
        [Description("Support Echo Damage +% Final")]
        SupportEchoDamagePosPctFinal = 2385,
        [Description("Global Bleed On Hit")]
        GlobalBleedOnHit = 2386,
        [Description("Local Bleed On Hit")]
        LocalBleedOnHit = 2387,
        [Description("Main Hand Bleed On Hit")]
        MainHandBleedOnHit = 2388,
        [Description("Off Hand Bleed On Hit")]
        OffHandBleedOnHit = 2389,
        [Description("Damage +% Vs Ignited Enemies")]
        DamagePosPctVsIgnitedEnemies = 2390,
        [Description("Recover % Maximum Life On Rampage Threshold")]
        RecoverPctMaximumLifeOnRampageThreshold = 2391,
        [Description("Dispel Status Ailments On Rampage Threshold")]
        DispelStatusAilmentsOnRampageThreshold = 2392,
        [Description("Gain Physical Damage Immunity On Rampage Threshold Ms")]
        GainPhysicalDamageImmunityOnRampageThresholdMs = 2393,
        [Description("Gain X Vaal Souls On Rampage Threshold")]
        GainXVaalSoulsOnRampageThreshold = 2394,
        [Description("Physical Damage +% Vs Poisoned Enemies")]
        PhysicalDamagePosPctVsPoisonedEnemies = 2395,
        [Description("Block Causes Monster Flee %")]
        BlockCausesMonsterFleePct = 2396,
        [Description("Life Regeneration Rate Per Minute Per Level")]
        LifeRegenerationRatePerMinutePerLevel = 2397,
        [Description("Critical Strike Chance +% Per Level")]
        CriticalStrikeChancePosPctPerLevel = 2398,
        [Description("Attack Damage +% Per Level")]
        AttackDamagePosPctPerLevel = 2399,
        [Description("Spell Damage +% Per Level")]
        SpellDamagePosPctPerLevel = 2400,
        [Description("Recharge Flasks On Crit")]
        RechargeFlasksOnCrit = 2401,
        [Description("Bleeding Monsters Movement Velocity +%")]
        BleedingMonstersMovementVelocityPosPct = 2402,
        [Description("Old Do Not Use Life Leech Permyriad On Crit")]
        OldDoNotUseLifeLeechPermyriadOnCrit = 2403,
        [Description("Ground Smoke On Rampage Threshold Ms")]
        GroundSmokeOnRampageThresholdMs = 2404,
        [Description("Phasing On Rampage Threshold Ms")]
        PhasingOnRampageThresholdMs = 2405,
        [Description("On Full Energy Shield")]
        OnFullEnergyShield = 2406,
        [Description("Movement Velocity +% On Full Energy Shield")]
        MovementVelocityPosPctOnFullEnergyShield = 2407,
        [Description("Sword Critical Strike Chance +%")]
        SwordCriticalStrikeChancePosPct = 2408,
        [Description("Attack Damage +% Per 450 Evasion")]
        AttackDamagePosPctPer450Evasion = 2409,
        [Description("Old Do Not Use Mana Leech From Physical Damage With Claw %")]
        OldDoNotUseManaLeechFromPhysicalDamageWithClawPct = 2410,
        [Description("Main Hand Steal Power Frenzy Endurance Charges On Hit %")]
        MainHandStealPowerFrenzyEnduranceChargesOnHitPct = 2411,
        [Description("Off Hand Steal Power Frenzy Endurance Charges On Hit %")]
        OffHandStealPowerFrenzyEnduranceChargesOnHitPct = 2412,
        [Description("Claw Steal Power Frenzy Endurance Charges On Hit %")]
        ClawStealPowerFrenzyEnduranceChargesOnHitPct = 2413,
        [Description("Player Gain Rampage Stacks")]
        PlayerGainRampageStacks = 2414,
        [Description("Regenerate % Armour As Life Over 1 Second On Block")]
        RegeneratePctArmourAsLifeOver1SecondOnBlock = 2415,
        [Description("Monster Cast Spell % On Attack Hit")]
        MonsterCastSpellPctOnAttackHit = 2416,
        [Description("Unique Chaos Damage To Reflect To Self On Attack % Chance")]
        UniqueChaosDamageToReflectToSelfOnAttackPctChance = 2417,
        [Description("Unique Minimum Chaos Damage To Reflect To Self On Attack")]
        UniqueMinimumChaosDamageToReflectToSelfOnAttack = 2418,
        [Description("Unique Maximum Chaos Damage To Reflect To Self On Attack")]
        UniqueMaximumChaosDamageToReflectToSelfOnAttack = 2419,
        [Description("Map Monsters Curse Effect +%")]
        MapMonstersCurseEffectPosPct = 2420,
        [Description("Map Mission Variation2")]
        MapMissionVariation2 = 2421,
        [Description("Map Player Has Random Level X Curse Every 10 Seconds")]
        MapPlayerHasRandomLevelXCurseEvery10Seconds = 2422,
        [Description("Display Map Inhabited By Wild Beasts")]
        DisplayMapInhabitedByWildBeasts = 2423,
        [Description("Monster No Drops")]
        MonsterNoDrops = 2424,
        [Description("Map Monster No Drops")]
        MapMonsterNoDrops = 2425,
        [Description("Life Regeneration Rate +%")]
        LifeRegenerationRatePosPct = 2426,
        [Description("Cannot Be Blinded")]
        CannotBeBlinded = 2427,
        [Description("Local Socketed Skill Gem Level +")]
        LocalSocketedSkillGemLevelPos = 2428,
        [Description("Gain Unholy Might On Rampage Threshold Ms")]
        GainUnholyMightOnRampageThresholdMs = 2429,
        [Description("Elemental Damage +% Per Level")]
        ElementalDamagePosPctPerLevel = 2430,
        [Description("Chaos Damage +% Per Level")]
        ChaosDamagePosPctPerLevel = 2431,
        [Description("Life Gained On Enemy Death Per Level")]
        LifeGainedOnEnemyDeathPerLevel = 2432,
        [Description("Mana Gained On Enemy Death")]
        ManaGainedOnEnemyDeath = 2433,
        [Description("Energy Shield Gained On Enemy Death")]
        EnergyShieldGainedOnEnemyDeath = 2434,
        [Description("Mana Gained On Enemy Death Per Level")]
        ManaGainedOnEnemyDeathPerLevel = 2435,
        [Description("Energy Shield Gained On Enemy Death Per Level")]
        EnergyShieldGainedOnEnemyDeathPerLevel = 2436,
        [Description("Aura Cannot Affect Self")]
        AuraCannotAffectSelf = 2437,
        [Description("Map Scion Mission Monster Pack")]
        MapScionMissionMonsterPack = 2438,
        [Description("Mace Critical Strike Chance +%")]
        MaceCriticalStrikeChancePosPct = 2439,
        [Description("Staff Critical Strike Chance +%")]
        StaffCriticalStrikeChancePosPct = 2440,
        [Description("Wand Critical Strike Chance +%")]
        WandCriticalStrikeChancePosPct = 2441,
        [Description("Wand Critical Strike Multiplier +")]
        WandCriticalStrikeMultiplierPos = 2442,
        [Description("Bow Stun Threshold Reduction +%")]
        BowStunThresholdReductionPosPct = 2443,
        [Description("Number Of Animated Bows To Summon")]
        NumberOfAnimatedBowsToSummon = 2444,
        [Description("Number Of Animated Daggers To Summon")]
        NumberOfAnimatedDaggersToSummon = 2445,
        [Description("Number Of Animated Two Handed Swords To Summon")]
        NumberOfAnimatedTwoHandedSwordsToSummon = 2446,
        [Description("Firestorm Avoid Unwalkable Terrain")]
        FirestormAvoidUnwalkableTerrain = 2447,
        [Description("Ground Effect Ring Type")]
        GroundEffectRingType = 2448,
        [Description("Local Display Socketed Gems Have Elemental Equilibrium")]
        LocalDisplaySocketedGemsHaveElementalEquilibrium = 2449,
        [Description("Unique Fire Damage Resistance % When Red Gem Socketed")]
        UniqueFireDamageResistancePctWhenRedGemSocketed = 2450,
        [Description("Unique Cold Damage Resistance % When Green Gem Socketed")]
        UniqueColdDamageResistancePctWhenGreenGemSocketed = 2451,
        [Description("Unique Lightning Damage Resistance % When Blue Gem Socketed")]
        UniqueLightningDamageResistancePctWhenBlueGemSocketed = 2452,
        [Description("Skill Mana Cost +")]
        SkillManaCostPos = 2453,
        [Description("Map Aoe Daemons Per 100 Tiles")]
        MapAoeDaemonsPer100Tiles = 2454,
        [Description("Map Aoe Daemons Variation")]
        MapAoeDaemonsVariation = 2455,
        [Description("Monster No Beyond Portal")]
        MonsterNoBeyondPortal = 2456,
        [Description("Local Socketed Support Gem Quality +")]
        LocalSocketedSupportGemQualityPos = 2457,
        [Description("Map Packs Are Str Mission Totems")]
        MapPacksAreStrMissionTotems = 2458,
        [Description("Chance To Grant Frenzy Charge On Death %")]
        ChanceToGrantFrenzyChargeOnDeathPct = 2459,
        [Description("Life Granted When Hit By Attacks")]
        LifeGrantedWhenHitByAttacks = 2460,
        [Description("Mana Granted When Hit By Attacks")]
        ManaGrantedWhenHitByAttacks = 2461,
        [Description("Life Granted When Killed")]
        LifeGrantedWhenKilled = 2462,
        [Description("Mana Granted When Killed")]
        ManaGrantedWhenKilled = 2463,
        [Description("Evasion Rating +% Final From Poachers Mark")]
        EvasionRatingPosPctFinalFromPoachersMark = 2464,
        [Description("Monster Interactible Corpse")]
        MonsterInteractibleCorpse = 2465,
        [Description("Revive All With Onslaught Make Minions")]
        ReviveAllWithOnslaughtMakeMinions = 2466,
        [Description("Revive All With Onslaught Make Unusable")]
        ReviveAllWithOnslaughtMakeUnusable = 2467,
        [Description("Additive Spell Damage Modifiers Apply To Attack Damage")]
        AdditiveSpellDamageModifiersApplyToAttackDamage = 2468,
        [Description("Monster Show Mission Minimap Icon")]
        MonsterShowMissionMinimapIcon = 2469,
        [Description("Monster Potential Mission Target")]
        MonsterPotentialMissionTarget = 2470,
        [Description("Is Trap Object")]
        IsTrapObject = 2471,
        [Description("Attack Projectiles Return")]
        AttackProjectilesReturn = 2472,
        [Description("Attack Projectiles Return If No Hit Object")]
        AttackProjectilesReturnIfNoHitObject = 2473,
        [Description("Minion Damage +% Per 10 Rampage Stacks")]
        MinionDamagePosPctPer10RampageStacks = 2474,
        [Description("Minion Movement Velocity +% Per 10 Rampage Stacks")]
        MinionMovementVelocityPosPctPer10RampageStacks = 2475,
        [Description("Virtual Minion Damage +%")]
        VirtualMinionDamagePosPct = 2476,
        [Description("Player Dex Mission Enable Pointer")]
        PlayerDexMissionEnablePointer = 2477,
        [Description("Map Hidden Monster Life +% Final")]
        MapHiddenMonsterLifePosPctFinal = 2478,
        [Description("Map Hidden Monster Damage +% Final")]
        MapHiddenMonsterDamagePosPctFinal = 2479,
        [Description("Projectiles Not Offset")]
        ProjectilesNotOffset = 2480,
        [Description("Herald Of Ash Fire Damage +%")]
        HeraldOfAshFireDamagePosPct = 2481,
        [Description("Map Num Extra Invasion Bosses")]
        MapNumExtraInvasionBosses = 2482,
        [Description("Map Num Extra Strongboxes")]
        MapNumExtraStrongboxes = 2483,
        [Description("Map Num Extra Shrines")]
        MapNumExtraShrines = 2484,
        [Description("Map All Monster Packs Rare And Allow Magic")]
        MapAllMonsterPacksRareAndAllowMagic = 2485,
        [Description("Duelist Master Is Dummy Variation")]
        DuelistMasterIsDummyVariation = 2486,
        [Description("Soul Eater Ignore Non Experience Monsters")]
        SoulEaterIgnoreNonExperienceMonsters = 2487,
        [Description("Summoned Monsters Are Minions")]
        SummonedMonstersAreMinions = 2488,
        [Description("Summoned Monsters No Drops Or Experience")]
        SummonedMonstersNoDropsOrExperience = 2489,
        [Description("Monster Do Not Fracture")]
        MonsterDoNotFracture = 2490,
        [Description("Item Generation Cannot Change Prefixes")]
        ItemGenerationCannotChangePrefixes = 2491,
        [Description("Item Generation Cannot Change Suffixes")]
        ItemGenerationCannotChangeSuffixes = 2492,
        [Description("Item Generation Cannot Roll Caster Affixes")]
        ItemGenerationCannotRollCasterAffixes = 2493,
        [Description("Item Generation Cannot Roll Attack Affixes")]
        ItemGenerationCannotRollAttackAffixes = 2494,
        [Description("Item Generation Can Have Multiple Crafted Mods")]
        ItemGenerationCanHaveMultipleCraftedMods = 2495,
        [Description("Map Set League Category")]
        MapSetLeagueCategory = 2496,
        [Description("Local Level Requirement +")]
        LocalLevelRequirementPos = 2497,
        [Description("Projectile Spiral Nova Starting Angle Offset")]
        ProjectileSpiralNovaStartingAngleOffset = 2498,
        [Description("Projectile Spiral Nova Both Directions")]
        ProjectileSpiralNovaBothDirections = 2499,
        [Description("Triggered Spell Spell Damage +%")]
        TriggeredSpellSpellDamagePosPct = 2500,
        [Description("Damage +% Vs Blinded Enemies")]
        DamagePosPctVsBlindedEnemies = 2501,
        [Description("Ground Smoke When Hit %")]
        GroundSmokeWhenHitPct = 2502,
        [Description("Number Of Beacons")]
        NumberOfBeacons = 2503,
        [Description("Is Dead")]
        IsDead = 2504,
        [Description("Area Of Effect +% While Dead")]
        AreaOfEffectPosPctWhileDead = 2505,
        [Description("Beacon Placement Radius")]
        BeaconPlacementRadius = 2506,
        [Description("Map Area Portal Variation")]
        MapAreaPortalVariation = 2507,
        [Description("Skill Is Triggered")]
        SkillIsTriggered = 2508,
        [Description("Skill Is Curse")]
        SkillIsCurse = 2509,
        [Description("Skill Triggerable Spell")]
        SkillTriggerableSpell = 2510,
        [Description("Unique Mjolner Lightning Spells Triggered")]
        UniqueMjolnerLightningSpellsTriggered = 2511,
        [Description("Skill Number Of Triggers")]
        SkillNumberOfTriggers = 2512,
        [Description("Curse On Block Level X Vulnerability")]
        CurseOnBlockLevelXVulnerability = 2513,
        [Description("Monster Enrages On Low Life Text")]
        MonsterEnragesOnLowLifeText = 2514,
        [Description("Drop Bear Fall On Target")]
        DropBearFallOnTarget = 2515,
        [Description("Map Magic Pack Mod Rules")]
        MapMagicPackModRules = 2516,
        [Description("Display Map Has Oxygen")]
        DisplayMapHasOxygen = 2517,
        [Description("Bloodlines Beacon On Death Variation")]
        BloodlinesBeaconOnDeathVariation = 2518,
        [Description("Actor Scale +% Granted To Pack Members On Death")]
        ActorScalePosPctGrantedToPackMembersOnDeath = 2519,
        [Description("Maximum Life +% Granted To Pack Members On Death")]
        MaximumLifePosPctGrantedToPackMembersOnDeath = 2520,
        [Description("Monster Dodge Direction")]
        MonsterDodgeDirection = 2521,
        [Description("Herald Of Ice Cold Damage +%")]
        HeraldOfIceColdDamagePosPct = 2522,
        [Description("Herald Of Thunder Lightning Damage +%")]
        HeraldOfThunderLightningDamagePosPct = 2523,
        [Description("Number Of Taniwha Tails Allowed")]
        NumberOfTaniwhaTailsAllowed = 2524,
        [Description("Minion Dies When Parent Dies")]
        MinionDiesWhenParentDies = 2525,
        [Description("Unique Nearby Allies Recover Permyriad Max Life On Death")]
        UniqueNearbyAlliesRecoverPermyriadMaxLifeOnDeath = 2526,
        [Description("Suppress Mod Stat Display")]
        SuppressModStatDisplay = 2527,
        [Description("Base Steal Power Frenzy Endurance Charges On Hit %")]
        BaseStealPowerFrenzyEnduranceChargesOnHitPct = 2528,
        [Description("Cannot Die And Damage +% Near Pack Corpse")]
        CannotDieAndDamagePosPctNearPackCorpse = 2529,
        [Description("Projectile Spread Radius")]
        ProjectileSpreadRadius = 2530,
        [Description("Local Item Drops On Death If Equipped By Animate Armour")]
        LocalItemDropsOnDeathIfEquippedByAnimateArmour = 2531,
        [Description("Physical Attack Damage +%")]
        PhysicalAttackDamagePosPct = 2532,
        [Description("Melee Physical Damage +% While Holding Shield")]
        MeleePhysicalDamagePosPctWhileHoldingShield = 2533,
        [Description("Local Display Socketed Gems Get Cast On Death Level")]
        LocalDisplaySocketedGemsGetCastOnDeathLevel = 2534,
        [Description("Cluster Burst Spawn Amount")]
        ClusterBurstSpawnAmount = 2535,
        [Description("Bloodline Daemon Update Count On Death")]
        BloodlineDaemonUpdateCountOnDeath = 2536,
        [Description("Bloodline Daemon Pack Death Count")]
        BloodlineDaemonPackDeathCount = 2537,
        [Description("Bloodline Summon Blood Monster On Pack Death")]
        BloodlineSummonBloodMonsterOnPackDeath = 2538,
        [Description("Damage Taken +% Per Bloodline Damage Charge")]
        DamageTakenPosPctPerBloodlineDamageCharge = 2539,
        [Description("Attack Speed +% Per Bloodline Speed Charge")]
        AttackSpeedPosPctPerBloodlineSpeedCharge = 2540,
        [Description("Cast Speed +% Per Bloodline Speed Charge")]
        CastSpeedPosPctPerBloodlineSpeedCharge = 2541,
        [Description("Current Bloodline Damage Charges")]
        CurrentBloodlineDamageCharges = 2542,
        [Description("Current Bloodline Speed Charges")]
        CurrentBloodlineSpeedCharges = 2543,
        [Description("Maximum Bloodline Damage Charges")]
        MaximumBloodlineDamageCharges = 2544,
        [Description("Maximum Bloodline Speed Charges")]
        MaximumBloodlineSpeedCharges = 2545,
        [Description("Apply X Random Curses On Hit")]
        ApplyXRandomCursesOnHit = 2546,
        [Description("Total Projectile Spread Angle Override")]
        TotalProjectileSpreadAngleOverride = 2547,
        [Description("Map Beyond Chance %")]
        MapBeyondChancePct = 2548,
        [Description("Map Boss Vaal Item Drop %")]
        MapBossVaalItemDropPct = 2549,
        [Description("Map Is Corrupted")]
        MapIsCorrupted = 2550,
        [Description("Map No Strongboxes")]
        MapNoStrongboxes = 2551,
        [Description("Keystone Acrobatics Block Chance +% Final")]
        KeystoneAcrobaticsBlockChancePosPctFinal = 2552,
        [Description("Corpse Consumption Affects Pack")]
        CorpseConsumptionAffectsPack = 2553,
        [Description("Damage +% Per Bloodline Damage Charge")]
        DamagePosPctPerBloodlineDamageCharge = 2554,
        [Description("Movement Speed +% Per Bloodline Speed Charge")]
        MovementSpeedPosPctPerBloodlineSpeedCharge = 2555,
        [Description("Active Skill Area Damage +% Final")]
        ActiveSkillAreaDamagePosPctFinal = 2556,
        [Description("Monster Share Charges With Pack")]
        MonsterShareChargesWithPack = 2557,
        [Description("Melee Counterattack Trigger On Block %")]
        MeleeCounterattackTriggerOnBlockPct = 2558,
        [Description("Bloodline Firestorm Scales With Pack Death")]
        BloodlineFirestormScalesWithPackDeath = 2559,
        [Description("Base Fire Damage % Of Maximum Life Plus Maximum Es Taken Per Minute")]
        BaseFireDamagePctOfMaximumLifePlusMaximumESTakenPerMinute = 2560,
        [Description("Is Totem Object")]
        IsTotemObject = 2561,
        [Description("Uses No Mana")]
        UsesNoMana = 2562,
        [Description("Monster Spawn Bloodlines Ghost Totem On Death")]
        MonsterSpawnBloodlinesGhostTotemOnDeath = 2563,
        [Description("Skill Triggerable Attack")]
        SkillTriggerableAttack = 2564,
        [Description("Attack Unusable If Triggerable")]
        AttackUnusableIfTriggerable = 2565,
        [Description("Clone Hidden Duration")]
        CloneHiddenDuration = 2566,
        [Description("Never Take Critical Strike")]
        NeverTakeCriticalStrike = 2567,
        [Description("Tormented Necromancer Spawn Monster On Death Variation")]
        TormentedNecromancerSpawnMonsterOnDeathVariation = 2568,
        [Description("Tormented Mutilator Spawn Monster On Death Variation")]
        TormentedMutilatorSpawnMonsterOnDeathVariation = 2569,
        [Description("Spawn Monster On Death Variation")]
        SpawnMonsterOnDeathVariation = 2570,
        [Description("Map Spawn Tormented Spirits")]
        MapSpawnTormentedSpirits = 2571,
        [Description("Damage +% Vs Frozen Shocked Ignited Enemies")]
        DamagePosPctVsFrozenShockedIgnitedEnemies = 2572,
        [Description("Bloodlines Animate Guardian On Death")]
        BloodlinesAnimateGuardianOnDeath = 2573,
        [Description("Melee Counterattack Trigger On Hit %")]
        MeleeCounterattackTriggerOnHitPct = 2574,
        [Description("Reduce Enemy Dodge %")]
        ReduceEnemyDodgePct = 2575,
        [Description("Shield Counterattack Aoe Range")]
        ShieldCounterattackAoeRange = 2576,
        [Description("Bloodlines Monster Unholy Might Duration Ms")]
        BloodlinesMonsterUnholyMightDurationMs = 2577,
        [Description("Bloodlines Monster Unholy Might Damage Taken +%")]
        BloodlinesMonsterUnholyMightDamageTakenPosPct = 2578,
        [Description("Bloodlines Phylacteral Link Is Vulnerable")]
        BloodlinesPhylacteralLinkIsVulnerable = 2579,
        [Description("Bloodlines Full Guardian Size +% On Death")]
        BloodlinesFullGuardianSizePosPctOnDeath = 2580,
        [Description("Bloodlines Guardian Damage +% On Death")]
        BloodlinesGuardianDamagePosPctOnDeath = 2581,
        [Description("Bloodlines Guardian Attack Speed +% On Death")]
        BloodlinesGuardianAttackSpeedPosPctOnDeath = 2582,
        [Description("Bloodlines Guardian Movement Speed +% On Death")]
        BloodlinesGuardianMovementSpeedPosPctOnDeath = 2583,
        [Description("Bloodlines Force Drop Of Pack Item Type Rarity")]
        BloodlinesForceDropOfPackItemTypeRarity = 2584,
        [Description("Merveil Number Of Geysers")]
        MerveilNumberOfGeysers = 2585,
        [Description("Weapon Elemental Damage +% While Using Flask")]
        WeaponElementalDamagePosPctWhileUsingFlask = 2586,
        [Description("Attack Speed +% While Holding Shield")]
        AttackSpeedPosPctWhileHoldingShield = 2587,
        [Description("Create Trap At Target Location")]
        CreateTrapAtTargetLocation = 2588,
        [Description("Avoid Knockback %")]
        AvoidKnockbackPct = 2589,
        [Description("Bloodlines Corrupted Blood % Average Damage To Deal Per Minute Per Stack For 20 Pack Members")]
        BloodlinesCorruptedBloodPctAverageDamageToDealPerMinutePerStackFor20PackMembers = 2590,
        [Description("Cant Touch This")]
        CantTouchThis = 2591,
        [Description("Cant Possess This")]
        CantPossessThis = 2592,
        [Description("Base Physical Damage % Of Maximum Life Taken Per Minute")]
        BasePhysicalDamagePctOfMaximumLifeTakenPerMinute = 2593,
        [Description("Static Strike Explosion Damage +% Final")]
        StaticStrikeExplosionDamagePosPctFinal = 2594,
        [Description("Disable Highlight")]
        DisableHighlight = 2595,
        [Description("Removes % Mana On Hit")]
        RemovesPctManaOnHit = 2596,
        [Description("Curse When Hit % Silence")]
        CurseWhenHitPctSilence = 2597,
        [Description("Life Gain On Ignited Enemy Hit")]
        LifeGainOnIgnitedEnemyHit = 2598,
        [Description("Minimum Added Physical Damage Vs Frozen Enemies")]
        MinimumAddedPhysicalDamageVsFrozenEnemies = 2599,
        [Description("Maximum Added Physical Damage Vs Frozen Enemies")]
        MaximumAddedPhysicalDamageVsFrozenEnemies = 2600,
        [Description("Damage Vs Shocked Enemies +%")]
        DamageVsShockedEnemiesPosPct = 2601,
        [Description("Old Do Not Use Life Leech Permyriad Vs Shocked Enemies")]
        OldDoNotUseLifeLeechPermyriadVsShockedEnemies = 2602,
        [Description("Physical Damage As Fire Damage Vs Ignited Enemies %")]
        PhysicalDamageAsFireDamageVsIgnitedEnemiesPct = 2603,
        [Description("Local Display Socketed Melee Gems Have Area Radius +%")]
        LocalDisplaySocketedMeleeGemsHaveAreaRadiusPosPct = 2604,
        [Description("Local Display Socketed Red Gems Have % Of Physical Damage To Add As Fire")]
        LocalDisplaySocketedRedGemsHavePctOfPhysicalDamageToAddAsFire = 2605,
        [Description("Curse Effect +% Vs Players")]
        CurseEffectPosPctVsPlayers = 2606,
        [Description("Monster Drop Additional Currency Items")]
        MonsterDropAdditionalCurrencyItems = 2607,
        [Description("Monster Drop Additional Wisdom Scrolls")]
        MonsterDropAdditionalWisdomScrolls = 2608,
        [Description("Monster Drop Additional Portal Scrolls")]
        MonsterDropAdditionalPortalScrolls = 2609,
        [Description("Monster Drop Additional Rings Amulets")]
        MonsterDropAdditionalRingsAmulets = 2610,
        [Description("Item Generation Local Maximum Mod Required Level Override")]
        ItemGenerationLocalMaximumModRequiredLevelOverride = 2611,
        [Description("Block Chance +%")]
        BlockChancePosPct = 2612,
        [Description("Local Unique Flask Physical Damage Taken % As Cold While Healing")]
        LocalUniqueFlaskPhysicalDamageTakenPctAsColdWhileHealing = 2613,
        [Description("Local Unique Flask Physical Damage % To Add As Cold While Healing")]
        LocalUniqueFlaskPhysicalDamagePctToAddAsColdWhileHealing = 2614,
        [Description("Local Unique Flask Avoid Chill % While Healing")]
        LocalUniqueFlaskAvoidChillPctWhileHealing = 2615,
        [Description("Local Unique Flask Avoid Freeze % While Healing")]
        LocalUniqueFlaskAvoidFreezePctWhileHealing = 2616,
        [Description("Monster Drop Additional Map Items")]
        MonsterDropAdditionalMapItems = 2617,
        [Description("Lightning Warp Move Speed Override")]
        LightningWarpMoveSpeedOverride = 2618,
        [Description("Fire Damage Taken % Causes Additional Physical Damage")]
        FireDamageTakenPctCausesAdditionalPhysicalDamage = 2619,
        [Description("Chill Effectiveness On Self +%")]
        ChillEffectivenessOnSelfPosPct = 2620,
        [Description("Temporal Chains Effeciveness +%")]
        TemporalChainsEffecivenessPosPct = 2621,
        [Description("Gain Flask Charge When Crit %")]
        GainFlaskChargeWhenCritPct = 2622,
        [Description("Gain Flask Charge When Crit Amount")]
        GainFlaskChargeWhenCritAmount = 2623,
        [Description("Self Physical Damage On Skill Use % Mana Cost")]
        SelfPhysicalDamageOnSkillUsePctManaCost = 2624,
        [Description("Torment Embezzler Debuff On Hit Recovery Speed +%")]
        TormentEmbezzlerDebuffOnHitRecoverySpeedPosPct = 2625,
        [Description("Monster No Drops When Not Deleted On Death")]
        MonsterNoDropsWhenNotDeletedOnDeath = 2626,
        [Description("Leech Amount +% Final On Crit")]
        LeechAmountPosPctFinalOnCrit = 2627,
        [Description("Unqiue Atzitis Acuity Instant Leech 60% Effectiveness On Crit")]
        UnqiueAtzitisAcuityInstantLeech60PctEffectivenessOnCrit = 2628,
        [Description("Leech Is Instant On Critical")]
        LeechIsInstantOnCritical = 2629,
        [Description("Bleed On Melee Attack Chance %")]
        BleedOnMeleeAttackChancePct = 2630,
        [Description("Physical Damage Over Time +%")]
        PhysicalDamageOverTimePosPct = 2631,
        [Description("Elemental Equilibrium Effect +%")]
        ElementalEquilibriumEffectPosPct = 2632,
        [Description("Local Display Socketed Gems Have Elemental Equilibrium Effect Pluspercent")]
        LocalDisplaySocketedGemsHaveElementalEquilibriumEffectPluspercent = 2633,
        [Description("Attack Damage +%")]
        AttackDamagePosPct = 2634,
        [Description("Attack Damage Vs Bleeding Enemies +%")]
        AttackDamageVsBleedingEnemiesPosPct = 2635,
        [Description("Chance To Gain Endurance Charge On Crit %")]
        ChanceToGainEnduranceChargeOnCritPct = 2636,
        [Description("Chance To Gain Power Charge When Block %")]
        ChanceToGainPowerChargeWhenBlockPct = 2637,
        [Description("Stuns Have Culling Strike")]
        StunsHaveCullingStrike = 2638,
        [Description("Chance To Gain Onslaught On Kill %")]
        ChanceToGainOnslaughtOnKillPct = 2639,
        [Description("Onslaught Time Granted On Kill Ms")]
        OnslaughtTimeGrantedOnKillMs = 2640,
        [Description("Base Main Hand Damage +%")]
        BaseMainHandDamagePosPct = 2641,
        [Description("Base Off Hand Attack Speed +%")]
        BaseOffHandAttackSpeedPosPct = 2642,
        [Description("Damage Vs Enemies On Low Life +%")]
        DamageVsEnemiesOnLowLifePosPct = 2643,
        [Description("Drop Additional Rare Items")]
        DropAdditionalRareItems = 2644,
        [Description("Monster Drop Additional Vaal Items")]
        MonsterDropAdditionalVaalItems = 2645,
        [Description("Bloodlines Shrouded")]
        BloodlinesShrouded = 2646,
        [Description("Monster Pretend To Be Player Level")]
        MonsterPretendToBePlayerLevel = 2647,
        [Description("Monster Display Es When Life Full")]
        MonsterDisplayESWhenLifeFull = 2648,
        [Description("Minimum Added Fire Damage Vs Ignited Enemies")]
        MinimumAddedFireDamageVsIgnitedEnemies = 2649,
        [Description("Maximum Added Fire Damage Vs Ignited Enemies")]
        MaximumAddedFireDamageVsIgnitedEnemies = 2650,
        [Description("Monster Is Possessed")]
        MonsterIsPossessed = 2651,
        [Description("Monster Has Second Form")]
        MonsterHasSecondForm = 2652,
        [Description("Map Crash Instance Debug")]
        MapCrashInstanceDebug = 2653,
        [Description("Map Pause Instance Debug")]
        MapPauseInstanceDebug = 2654,
        [Description("Chance To Gain Endurance Charge On Melee Crit %")]
        ChanceToGainEnduranceChargeOnMeleeCritPct = 2655,
        [Description("Physical Damage Per Endurance Charge +%")]
        PhysicalDamagePerEnduranceChargePosPct = 2656,
        [Description("Penetrate Elemental Resistance Per Frenzy Charge %")]
        PenetrateElementalResistancePerFrenzyChargePct = 2657,
        [Description("Damage Vs Enemies On Full Life Per Power Charge +%")]
        DamageVsEnemiesOnFullLifePerPowerChargePosPct = 2658,
        [Description("Damage Vs Enemies On Low Life Per Power Charge +%")]
        DamageVsEnemiesOnLowLifePerPowerChargePosPct = 2659,
        [Description("Monster Dodge Distance")]
        MonsterDodgeDistance = 2660,
        [Description("Cast Socketed Minion Skills On Bow Kill %")]
        CastSocketedMinionSkillsOnBowKillPct = 2661,
        [Description("Minion Damage +% Per 10 Dex")]
        MinionDamagePosPctPer10Dex = 2662,
        [Description("Unique Bow Minion Spells Triggered")]
        UniqueBowMinionSpellsTriggered = 2663,
        [Description("Local Flask Ignite Immunity While Healing")]
        LocalFlaskIgniteImmunityWhileHealing = 2664,
        [Description("Local Flask Chill And Freeze Immunity While Healing")]
        LocalFlaskChillAndFreezeImmunityWhileHealing = 2665,
        [Description("Local Flask Shock Immunity While Healing")]
        LocalFlaskShockImmunityWhileHealing = 2666,
        [Description("Local Flask Bleeding Immunity While Healing")]
        LocalFlaskBleedingImmunityWhileHealing = 2667,
        [Description("Immune To Bleeding")]
        ImmuneToBleeding = 2668,
        [Description("Local Display Socketed Gems Have Number Of Additional Projectiles")]
        LocalDisplaySocketedGemsHaveNumberOfAdditionalProjectiles = 2669,
        [Description("Local Display Socketed Gems Projectiles Nova")]
        LocalDisplaySocketedGemsProjectilesNova = 2670,
        [Description("Local Display Socketed Gems Skill Effect Duration +%")]
        LocalDisplaySocketedGemsSkillEffectDurationPosPct = 2671,
        [Description("Life Regen Per Minute Per Endurance Charge")]
        LifeRegenPerMinutePerEnduranceCharge = 2672,
        [Description("Vaal Souls Gained Per Minute")]
        VaalSoulsGainedPerMinute = 2673,
        [Description("Attack Damage That Stuns Also Chills")]
        AttackDamageThatStunsAlsoChills = 2674,
        [Description("Cannot Knockback")]
        CannotKnockback = 2675,
        [Description("Cleave Disable Predictive Damage")]
        CleaveDisablePredictiveDamage = 2676,
        [Description("Display Map Contains Grandmasters")]
        DisplayMapContainsGrandmasters = 2677,
        [Description("Gain X Life When Endurance Charge Expires Or Consumed")]
        GainXLifeWhenEnduranceChargeExpiresOrConsumed = 2678,
        [Description("Virtual Maximum Endurance Charges")]
        VirtualMaximumEnduranceCharges = 2679,
        [Description("Virtual Maximum Frenzy Charges")]
        VirtualMaximumFrenzyCharges = 2680,
        [Description("Virtual Maximum Power Charges")]
        VirtualMaximumPowerCharges = 2681,
        [Description("No Maximum Power Charges")]
        NoMaximumPowerCharges = 2682,
        [Description("Damage Vs Cursed Enemies Per Enemy Curse +%")]
        DamageVsCursedEnemiesPerEnemyCursePosPct = 2683,
        [Description("Virtual Ignite Duration +%")]
        VirtualIgniteDurationPosPct = 2684,
        [Description("Virtual Shock Duration +%")]
        VirtualShockDurationPosPct = 2685,
        [Description("Virtual Freeze Duration +%")]
        VirtualFreezeDurationPosPct = 2686,
        [Description("Virtual Chill Duration +%")]
        VirtualChillDurationPosPct = 2687,
        [Description("Base Elemental Status Ailment Duration +%")]
        BaseElementalStatusAilmentDurationPosPct = 2688,
        [Description("Local Display Socketed Gems Supported By X Knockback Level")]
        LocalDisplaySocketedGemsSupportedByXKnockbackLevel = 2689,
        [Description("Enemy Knockback Direction Is Reversed")]
        EnemyKnockbackDirectionIsReversed = 2690,
        [Description("Map Zana Subarea Mission")]
        MapZanaSubareaMission = 2691,
        [Description("Map Zana Subarea Extra Req")]
        MapZanaSubareaExtraReq = 2692,
        [Description("Immune To Ally Buff Auras")]
        ImmuneToAllyBuffAuras = 2693,
        [Description("Buff Auras Dont Affect Allies")]
        BuffAurasDontAffectAllies = 2694,
        [Description("Hits Can Only Kill Frozen Enemies")]
        HitsCanOnlyKillFrozenEnemies = 2695,
        [Description("Spectral Throw Deceleration Override")]
        SpectralThrowDecelerationOverride = 2696,
        [Description("Maximum Life Taken As Physical Damage On Minion Death %")]
        MaximumLifeTakenAsPhysicalDamageOnMinionDeathPct = 2697,
        [Description("Maximum Es Taken As Physical Damage On Minion Death %")]
        MaximumEsTakenAsPhysicalDamageOnMinionDeathPct = 2698,
        [Description("Minion Skill Area Of Effect +%")]
        MinionSkillAreaOfEffectPosPct = 2699,
        [Description("Energy Shield Regeneration % Per Minute While Shocked")]
        EnergyShieldRegenerationPctPerMinuteWhileShocked = 2700,
        [Description("Chest Drops Extra Vaal Fragments")]
        ChestDropsExtraVaalFragments = 2701,
        [Description("Chest Drops Extra Rare Items Of Same Base Type")]
        ChestDropsExtraRareItemsOfSameBaseType = 2702,
        [Description("Ignite Art Variation")]
        IgniteArtVariation = 2703,
        [Description("Curse Apply As Aura")]
        CurseApplyAsAura = 2704,
        [Description("Combined Pvp Damage +% Final")]
        CombinedPvpDamagePosPctFinal = 2705,
        [Description("Support Cast On Death Pvp Damage +% Final")]
        SupportCastOnDeathPvpDamagePosPctFinal = 2706,
        [Description("Support Cast On Damage Taken Pvp Damage +% Final")]
        SupportCastOnDamageTakenPvpDamagePosPctFinal = 2707,
        [Description("Support Cast When Stunned Pvp Damage +% Final")]
        SupportCastWhenStunnedPvpDamagePosPctFinal = 2708,
        [Description("Support Cast On Crit Pvp Damage +% Final")]
        SupportCastOnCritPvpDamagePosPctFinal = 2709,
        [Description("Support Bloodlust Melee Physical Damage +% Final Vs Bleeding Enemies")]
        SupportBloodlustMeleePhysicalDamagePosPctFinalVsBleedingEnemies = 2710,
        [Description("Support Bloodlust Melee Physical Damage +% Final")]
        SupportBloodlustMeleePhysicalDamagePosPctFinal = 2711,
        [Description("Cannot Be Damaged By Nonplayer Damage")]
        CannotBeDamagedByNonplayerDamage = 2712,
        [Description("Cannot Cause Bleeding")]
        CannotCauseBleeding = 2713,
        [Description("Inspiring Cry Damage +% Per One Hundred Nearby Enemies")]
        InspiringCryDamagePosPctPerOneHundredNearbyEnemies = 2714,
        [Description("Charge Duration +%")]
        ChargeDurationPosPct = 2715,
        [Description("Virtual Power Charge Duration +%")]
        VirtualPowerChargeDurationPosPct = 2716,
        [Description("Virtual Endurance Charge Duration +%")]
        VirtualEnduranceChargeDurationPosPct = 2717,
        [Description("Daresso Attack Combo Physical Damage % To Add As Cold")]
        DaressoAttackComboPhysicalDamagePctToAddAsCold = 2718,
        [Description("Old Do Not Use Life Leech From Attack Damage Permyriad Vs Chilled Enemies")]
        OldDoNotUseLifeLeechFromAttackDamagePermyriadVsChilledEnemies = 2719,
        [Description("Base Life Leech From Attack Damage Permyriad")]
        BaseLifeLeechFromAttackDamagePermyriad = 2720,
        [Description("Base Mana Leech From Attack Damage Permyriad")]
        BaseManaLeechFromAttackDamagePermyriad = 2721,
        [Description("Test Stat Check Code")]
        TestStatCheckCode = 2722,
        [Description("Monster Penalty Against Minions Damage +% Final")]
        MonsterPenaltyAgainstMinionsDamagePosPctFinal = 2723,
        [Description("Monster Penalty Against Minions Damage +% Final Vs Player Minions")]
        MonsterPenaltyAgainstMinionsDamagePosPctFinalVsPlayerMinions = 2724,
        [Description("Physical Damage Taken On Minion Death")]
        PhysicalDamageTakenOnMinionDeath = 2725,
        [Description("Abyssal Cry Movement Velocity +% Per One Hundred Nearby Enemies")]
        AbyssalCryMovementVelocityPosPctPerOneHundredNearbyEnemies = 2726,
        [Description("Onslaught Buff Duration On Culling Strike Ms")]
        OnslaughtBuffDurationOnCullingStrikeMs = 2727,
        [Description("Base Avoid Chill % While Have Onslaught")]
        BaseAvoidChillPctWhileHaveOnslaught = 2728,
        [Description("Base Avoid Freeze % While Have Onslaught")]
        BaseAvoidFreezePctWhileHaveOnslaught = 2729,
        [Description("Base Avoid Shock % While Have Onslaught")]
        BaseAvoidShockPctWhileHaveOnslaught = 2730,
        [Description("Base Avoid Ignite % While Have Onslaught")]
        BaseAvoidIgnitePctWhileHaveOnslaught = 2731,
        [Description("Avoid Chill % While Have Onslaught")]
        AvoidChillPctWhileHaveOnslaught = 2732,
        [Description("Avoid Freeze % While Have Onslaught")]
        AvoidFreezePctWhileHaveOnslaught = 2733,
        [Description("Avoid Shock % While Have Onslaught")]
        AvoidShockPctWhileHaveOnslaught = 2734,
        [Description("Avoid Ignite % While Have Onslaught")]
        AvoidIgnitePctWhileHaveOnslaught = 2735,
        [Description("Attack Minimum Added Lightning Damage While Unarmed")]
        AttackMinimumAddedLightningDamageWhileUnarmed = 2736,
        [Description("Attack Maximum Added Lightning Damage While Unarmed")]
        AttackMaximumAddedLightningDamageWhileUnarmed = 2737,
        [Description("Spell Minimum Added Lightning Damage While Unarmed")]
        SpellMinimumAddedLightningDamageWhileUnarmed = 2738,
        [Description("Spell Maximum Added Lightning Damage While Unarmed")]
        SpellMaximumAddedLightningDamageWhileUnarmed = 2739,
        [Description("Gain X Energy Shield On Killing Shocked Enemy")]
        GainXEnergyShieldOnKillingShockedEnemy = 2740,
        [Description("Support Concentrated Effect Skill Area Of Effect +% Final")]
        SupportConcentratedEffectSkillAreaOfEffectPosPctFinal = 2741,
        [Description("Elemental Damage +% Per Frenzy Charge")]
        ElementalDamagePosPctPerFrenzyCharge = 2742,
        [Description("Chaos Damage Poisons")]
        ChaosDamagePoisons = 2743,
        [Description("Mine Extra Uses")]
        MineExtraUses = 2744,
        [Description("From Code Active Skill Damage +% Final")]
        FromCodeActiveSkillDamagePosPctFinal = 2745,
        [Description("Newshocknova First Ring Damage +% Final")]
        NewshocknovaFirstRingDamagePosPctFinal = 2746,
        [Description("Ice Crash Second Hit Damage +% Final")]
        IceCrashSecondHitDamagePosPctFinal = 2747,
        [Description("Killed Monster Dropped Item Rarity +% When Frozen")]
        KilledMonsterDroppedItemRarityPosPctWhenFrozen = 2748,
        [Description("Local Six Linked Sockets")]
        LocalSixLinkedSockets = 2749,
        [Description("Local Display Socketed Gems Get Generosity Level")]
        LocalDisplaySocketedGemsGetGenerosityLevel = 2750,
        [Description("Local Display Socketed Gems Get Remote Mine Level")]
        LocalDisplaySocketedGemsGetRemoteMineLevel = 2751,
        [Description("Local Display Aura Life Regeneration Rate Per Minute %")]
        LocalDisplayAuraLifeRegenerationRatePerMinutePct = 2752,
        [Description("Local Display Aura Mana Regeneration Rate +%")]
        LocalDisplayAuraManaRegenerationRatePosPct = 2753,
        [Description("Unique Insanity Do Weird Things")]
        UniqueInsanityDoWeirdThings = 2754,
        [Description("Base Elemental Damage Heals")]
        BaseElementalDamageHeals = 2755,
        [Description("Base Fire Damage Heals")]
        BaseFireDamageHeals = 2756,
        [Description("Base Cold Damage Heals")]
        BaseColdDamageHeals = 2757,
        [Description("Base Lightning Damage Heals")]
        BaseLightningDamageHeals = 2758,
        [Description("Fire Damage Heals")]
        FireDamageHeals = 2759,
        [Description("Cold Damage Heals")]
        ColdDamageHeals = 2760,
        [Description("Lightning Damage Heals")]
        LightningDamageHeals = 2761,
        [Description("Chance To Gain Power Charge On Melee Stun %")]
        ChanceToGainPowerChargeOnMeleeStunPct = 2762,
        [Description("Gain Unholy Might For 2 Seconds On Melee Crit")]
        GainUnholyMightFor2SecondsOnMeleeCrit = 2763,
        [Description("Unique Mine Damage +% Final")]
        UniqueMineDamagePosPctFinal = 2764,
        [Description("Abyssal Cry % Max Life As Chaos On Death")]
        AbyssalCryPctMaxLifeAsChaosOnDeath = 2765,
        [Description("Ignites Reflected To Self")]
        IgnitesReflectedToSelf = 2766,
        [Description("Avoid Freeze Chill Ignite % While Have Onslaught")]
        AvoidFreezeChillIgnitePctWhileHaveOnslaught = 2767,
        [Description("Sword Physical Damage % To Add As Fire")]
        SwordPhysicalDamagePctToAddAsFire = 2768,
        [Description("Gain Onslaught When Ignited Ms")]
        GainOnslaughtWhenIgnitedMs = 2769,
        [Description("Blind Nearby Enemies When Ignited %")]
        BlindNearbyEnemiesWhenIgnitedPct = 2770,
        [Description("Map Has Weather")]
        MapHasWeather = 2771,
        [Description("Malachai Elemental Cone Spell Minimum Damage")]
        MalachaiElementalConeSpellMinimumDamage = 2772,
        [Description("Malachai Elemental Cone Spell Maximum Damage")]
        MalachaiElementalConeSpellMaximumDamage = 2773,
        [Description("Local Display Socketed Gems Supported By Pierce Level")]
        LocalDisplaySocketedGemsSupportedByPierceLevel = 2774,
        [Description("Map Non Unique Equipment Drops As Sell Price")]
        MapNonUniqueEquipmentDropsAsSellPrice = 2775,
        [Description("Local Flask Use Causes Monster Flee Chance %")]
        LocalFlaskUseCausesMonsterFleeChancePct = 2776,
        [Description("Local Unique Lions Roar Melee Physical Damage +% Final During Flask Effect")]
        LocalUniqueLionsRoarMeleePhysicalDamagePosPctFinalDuringFlaskEffect = 2777,
        [Description("Unique Lions Roar Melee Physical Damage +% Final")]
        UniqueLionsRoarMeleePhysicalDamagePosPctFinal = 2778,
        [Description("Local Flask Adds Knockback During Flask Effect")]
        LocalFlaskAddsKnockbackDuringFlaskEffect = 2779,
        [Description("Map Items Drop Corrupted")]
        MapItemsDropCorrupted = 2780,
        [Description("Chest Number Of Additional Spider Uniques To Drop")]
        ChestNumberOfAdditionalSpiderUniquesToDrop = 2781,
        [Description("Virtual Mana Gain Per Target")]
        VirtualManaGainPerTarget = 2782,
        [Description("Life And Mana Gain Per Hit")]
        LifeAndManaGainPerHit = 2783,
        [Description("Life And Mana Leech From Physical Damage Permyriad")]
        LifeAndManaLeechFromPhysicalDamagePermyriad = 2784,
        [Description("Cannot Inflict Status Ailments")]
        CannotInflictStatusAilments = 2785,
        [Description("Map Weapons Drop Animated")]
        MapWeaponsDropAnimated = 2786,
        [Description("Attacks Bleed On Stun")]
        AttacksBleedOnStun = 2787,
        [Description("Chance To Fortify On Melee Hit +%")]
        ChanceToFortifyOnMeleeHitPosPct = 2788,
        [Description("Taunt Target Id")]
        TauntTargetId = 2789,
        [Description("Spell Minimum Base Cold Damage + Per 10 Intelligence")]
        SpellMinimumBaseColdDamagePosPer10Intelligence = 2790,
        [Description("Spell Maximum Base Cold Damage + Per 10 Intelligence")]
        SpellMaximumBaseColdDamagePosPer10Intelligence = 2791,
        [Description("Skill Effect Duration +% Per 10 Strength")]
        SkillEffectDurationPosPctPer10Strength = 2792,
        [Description("Virtual Skill Effect Duration +%")]
        VirtualSkillEffectDurationPosPct = 2793,
        [Description("Skill Is Fire Skill")]
        SkillIsFireSkill = 2794,
        [Description("Skill Is Cold Skill")]
        SkillIsColdSkill = 2795,
        [Description("Skill Is Lightning Skill")]
        SkillIsLightningSkill = 2796,
        [Description("Ground Slam Cone Angle Override")]
        GroundSlamConeAngleOverride = 2797,
        [Description("Virtual Minion Movement Velocity +%")]
        VirtualMinionMovementVelocityPosPct = 2798,
        [Description("Map Disable Torment Spirits")]
        MapDisableTormentSpirits = 2799,
        [Description("Map Spawn Extra Torment Spirits")]
        MapSpawnExtraTormentSpirits = 2800,
        [Description("Use Goddess Player Audio")]
        UseGoddessPlayerAudio = 2801,
        [Description("Local Display Grants Skill Gluttony Of Elements Level")]
        LocalDisplayGrantsSkillGluttonyOfElementsLevel = 2802,
        [Description("Local Display Socketed Gems Get Pierce Level")]
        LocalDisplaySocketedGemsGetPierceLevel = 2803,
        [Description("Damage With Fire Skills +%")]
        DamageWithFireSkillsPosPct = 2804,
        [Description("Damage With Cold Skills +%")]
        DamageWithColdSkillsPosPct = 2805,
        [Description("Damage With Lightning Skills +%")]
        DamageWithLightningSkillsPosPct = 2806,
        [Description("Cast Speed For Fire Skills +%")]
        CastSpeedForFireSkillsPosPct = 2807,
        [Description("Cast Speed For Cold Skills +%")]
        CastSpeedForColdSkillsPosPct = 2808,
        [Description("Cast Speed For Lightning Skills +%")]
        CastSpeedForLightningSkillsPosPct = 2809,
        [Description("Movement Velocity +% While Phasing")]
        MovementVelocityPosPctWhilePhasing = 2810,
        [Description("Phase On Vaal Skill Use Duration Ms")]
        PhaseOnVaalSkillUseDurationMs = 2811,
        [Description("Monster Inherent Damage Taken +% Final")]
        MonsterInherentDamageTakenPosPctFinal = 2812,
        [Description("Taunt Duration +%")]
        TauntDurationPosPct = 2813,
        [Description("Cyclone Ice Path Radius")]
        CycloneIcePathRadius = 2814,
        [Description("Unarmed Melee Physical Damage +%")]
        UnarmedMeleePhysicalDamagePosPct = 2815,
        [Description("Unarmed Melee Attack Speed +%")]
        UnarmedMeleeAttackSpeedPosPct = 2816,
        [Description("Cast Speed +% While Holding Shield")]
        CastSpeedPosPctWhileHoldingShield = 2817,
        [Description("Cast Speed +% While Holding Staff")]
        CastSpeedPosPctWhileHoldingStaff = 2818,
        [Description("Virtual Energy Shield Gain Per Target")]
        VirtualEnergyShieldGainPerTarget = 2819,
        [Description("Energy Shield Gain Per Target")]
        EnergyShieldGainPerTarget = 2820,
        [Description("Axe Critical Strike Chance +%")]
        AxeCriticalStrikeChancePosPct = 2821,
        [Description("Claw Critical Strike Multiplier +")]
        ClawCriticalStrikeMultiplierPos = 2822,
        [Description("Staff Critical Strike Multiplier +")]
        StaffCriticalStrikeMultiplierPos = 2823,
        [Description("Local Jewel Effect Base Radius")]
        LocalJewelEffectBaseRadius = 2824,
        [Description("Local Jewel Nearby Passives Str To Dex")]
        LocalJewelNearbyPassivesStrToDex = 2825,
        [Description("Local Jewel Nearby Passives Dex To Str")]
        LocalJewelNearbyPassivesDexToStr = 2826,
        [Description("Local Jewel Nearby Passives Str To Int")]
        LocalJewelNearbyPassivesStrToInt = 2827,
        [Description("Local Jewel Nearby Passives Int To Str")]
        LocalJewelNearbyPassivesIntToStr = 2828,
        [Description("Local Jewel Nearby Passives Dex To Int")]
        LocalJewelNearbyPassivesDexToInt = 2829,
        [Description("Local Jewel Nearby Passives Int To Dex")]
        LocalJewelNearbyPassivesIntToDex = 2830,
        [Description("Critical Strike Chance While Wielding Shield +%")]
        CriticalStrikeChanceWhileWieldingShieldPosPct = 2831,
        [Description("Trap Critical Strike Chance +%")]
        TrapCriticalStrikeChancePosPct = 2832,
        [Description("Mine Critical Strike Chance +%")]
        MineCriticalStrikeChancePosPct = 2833,
        [Description("Projectiles Can Shotgun")]
        ProjectilesCanShotgun = 2834,
        [Description("Life Recovery Rate +%")]
        LifeRecoveryRatePosPct = 2835,
        [Description("Mana Recovery Rate +%")]
        ManaRecoveryRatePosPct = 2836,
        [Description("Energy Shield Recovery Rate +%")]
        EnergyShieldRecoveryRatePosPct = 2837,
        [Description("Spell Chance To Shock Frozen Enemies %")]
        SpellChanceToShockFrozenEnemiesPct = 2838,
        [Description("Cannot Be Taunted")]
        CannotBeTaunted = 2839,
        [Description("Cannot Be Taunted When Taunted Ms")]
        CannotBeTauntedWhenTauntedMs = 2840,
        [Description("Attacks Do Not Cost Mana")]
        AttacksDoNotCostMana = 2841,
        [Description("Cannot Leech Or Regenerate Mana")]
        CannotLeechOrRegenerateMana = 2842,
        [Description("Virtual Global Cannot Crit")]
        VirtualGlobalCannotCrit = 2843,
        [Description("Virtual Global Attacks Always Hit")]
        VirtualGlobalAttacksAlwaysHit = 2844,
        [Description("Resolute Technique")]
        ResoluteTechnique = 2845,
        [Description("Local Life And Mana Leech From Physical Damage Permyriad")]
        LocalLifeAndManaLeechFromPhysicalDamagePermyriad = 2846,
        [Description("Main Hand Local Life And Mana Leech From Physical Damage Permyriad")]
        MainHandLocalLifeAndManaLeechFromPhysicalDamagePermyriad = 2847,
        [Description("Off Hand Local Life And Mana Leech From Physical Damage Permyriad")]
        OffHandLocalLifeAndManaLeechFromPhysicalDamagePermyriad = 2848,
        [Description("Local Flask Use Causes Area Knockback")]
        LocalFlaskUseCausesAreaKnockback = 2849,
        [Description("Skill Is Chaos Skill")]
        SkillIsChaosSkill = 2850,
        [Description("Critical Strike Multiplier Is 100")]
        CriticalStrikeMultiplierIs100 = 2851,
        [Description("Can Inflict Multiple Ignites")]
        CanInflictMultipleIgnites = 2852,
        [Description("Ignite Duration -%")]
        IgniteDurationNegPct = 2853,
        [Description("Passive Can Be Allocated Without Connection")]
        PassiveCanBeAllocatedWithoutConnection = 2854,
        [Description("Local Unique Jewel Nearby Disconnected Passives Can Be Allocated")]
        LocalUniqueJewelNearbyDisconnectedPassivesCanBeAllocated = 2855,
        [Description("Local Chance To Bleed On Hit %")]
        LocalChanceToBleedOnHitPct = 2856,
        [Description("Main Hand Local Chance To Bleed On Hit %")]
        MainHandLocalChanceToBleedOnHitPct = 2857,
        [Description("Off Hand Local Chance To Bleed On Hit %")]
        OffHandLocalChanceToBleedOnHitPct = 2858,
        [Description("Skill Total Pvp Damage +% Final")]
        SkillTotalPvpDamagePosPctFinal = 2859,
        [Description("Fire Critical Strike Chance +%")]
        FireCriticalStrikeChancePosPct = 2860,
        [Description("Lightning Critical Strike Chance +%")]
        LightningCriticalStrikeChancePosPct = 2861,
        [Description("Cold Critical Strike Chance +%")]
        ColdCriticalStrikeChancePosPct = 2862,
        [Description("Elemental Critical Strike Chance +%")]
        ElementalCriticalStrikeChancePosPct = 2863,
        [Description("Chaos Critical Strike Chance +%")]
        ChaosCriticalStrikeChancePosPct = 2864,
        [Description("Pvp Shield Damage +% Final")]
        PvpShieldDamagePosPctFinal = 2865,
        [Description("Skill Area Of Effect When Unarmed +%")]
        SkillAreaOfEffectWhenUnarmedPosPct = 2866,
        [Description("Gain X Random Rare Monster Mods On Kill")]
        GainXRandomRareMonsterModsOnKill = 2867,
        [Description("Chance To Gain Power Charge On Stun %")]
        ChanceToGainPowerChargeOnStunPct = 2868,
        [Description("Gain Unholy Might For 2 Seconds On Crit")]
        GainUnholyMightFor2SecondsOnCrit = 2869,
        [Description("Monster Life +% Final From Rarity")]
        MonsterLifePosPctFinalFromRarity = 2870,
        [Description("Monster Life +% Final From Map")]
        MonsterLifePosPctFinalFromMap = 2871,
        [Description("Melee Critical Strike Multiplier + While Wielding Shield")]
        MeleeCriticalStrikeMultiplierPosWhileWieldingShield = 2872,
        [Description("Trap Critical Strike Multiplier +")]
        TrapCriticalStrikeMultiplierPos = 2873,
        [Description("Mine Critical Strike Multiplier +")]
        MineCriticalStrikeMultiplierPos = 2874,
        [Description("Fire Critical Strike Multiplier +")]
        FireCriticalStrikeMultiplierPos = 2875,
        [Description("Lightning Critical Strike Multiplier +")]
        LightningCriticalStrikeMultiplierPos = 2876,
        [Description("Cold Critical Strike Multiplier +")]
        ColdCriticalStrikeMultiplierPos = 2877,
        [Description("Elemental Critical Strike Multiplier +")]
        ElementalCriticalStrikeMultiplierPos = 2878,
        [Description("Chaos Critical Strike Multiplier +")]
        ChaosCriticalStrikeMultiplierPos = 2879,
        [Description("Cast Speed For Chaos Skills +%")]
        CastSpeedForChaosSkillsPosPct = 2880,
        [Description("Spell Block While Dual Wielding %")]
        SpellBlockWhileDualWieldingPct = 2881,
        [Description("Spell Block With Staff %")]
        SpellBlockWithStaffPct = 2882,
        [Description("Recover % Maximum Life When Corpse Destroyed Or Consumed")]
        RecoverPctMaximumLifeWhenCorpseDestroyedOrConsumed = 2883,
        [Description("Local Unique Jewel Totem Life +x% Per 10 Str In Radius")]
        LocalUniqueJewelTotemLifePosXPctPer10StrInRadius = 2884,
        [Description("Minion Chance To Dodge %")]
        MinionChanceToDodgePct = 2885,
        [Description("Local Unique Jewel With 4 Notables Gain X Random Rare Monster Mods On Kill")]
        LocalUniqueJewelWith4NotablesGainXRandomRareMonsterModsOnKill = 2886,
        [Description("Minimum Added Fire Damage Per Active Buff")]
        MinimumAddedFireDamagePerActiveBuff = 2887,
        [Description("Maximum Added Fire Damage Per Active Buff")]
        MaximumAddedFireDamagePerActiveBuff = 2888,
        [Description("Recover % Of Maximum Life On Block")]
        RecoverPctOfMaximumLifeOnBlock = 2889,
        [Description("Minion Recover % Of Maximum Life On Block")]
        MinionRecoverPctOfMaximumLifeOnBlock = 2890,
        [Description("Totems Cannot Be Stunned")]
        TotemsCannotBeStunned = 2891,
        [Description("Is Leeching")]
        IsLeeching = 2892,
        [Description("Damage +% While Leeching")]
        DamagePosPctWhileLeeching = 2893,
        [Description("Is Life Leeching")]
        IsLifeLeeching = 2894,
        [Description("Is Mana Leeching")]
        IsManaLeeching = 2895,
        [Description("Is Es Leeching")]
        IsEsLeeching = 2896,
        [Description("Movement Velocity +% While Ignited")]
        MovementVelocityPosPctWhileIgnited = 2897,
        [Description("Bow Damage +%")]
        BowDamagePosPct = 2898,
        [Description("Display Bow Range +")]
        DisplayBowRangePos = 2899,
        [Description("Bleed On Bow Attack Chance %")]
        BleedOnBowAttackChancePct = 2900,
        [Description("Bow Physical Damage +% While Holding Shield")]
        BowPhysicalDamagePosPctWhileHoldingShield = 2901,
        [Description("Bow Steal Power Frenzy Endurance Charges On Hit %")]
        BowStealPowerFrenzyEnduranceChargesOnHitPct = 2902,
        [Description("Life Leech From Physical Damage With Bow Permyriad")]
        LifeLeechFromPhysicalDamageWithBowPermyriad = 2903,
        [Description("Mana Leech From Physical Damage With Bow Permyriad")]
        ManaLeechFromPhysicalDamageWithBowPermyriad = 2904,
        [Description("Poison On Critical Strike With Bow")]
        PoisonOnCriticalStrikeWithBow = 2905,
        [Description("Bow Elemental Damage +%")]
        BowElementalDamagePosPct = 2906,
        [Description("With Bow Additional Block %")]
        WithBowAdditionalBlockPct = 2907,
        [Description("Bow Enemy Block -%")]
        BowEnemyBlockNegPct = 2908,
        [Description("Local Unique Jewel Melee Applies To Bow")]
        LocalUniqueJewelMeleeAppliesToBow = 2909,
        [Description("Local Unique Jewel Chaos Damage +% Per 10 Int In Radius")]
        LocalUniqueJewelChaosDamagePosPctPer10IntInRadius = 2910,
        [Description("Local Unique Jewel Passives In Radius Applied To Minions Instead")]
        LocalUniqueJewelPassivesInRadiusAppliedToMinionsInstead = 2911,
        [Description("Life Gained On Hit Per Enemy Status Ailment")]
        LifeGainedOnHitPerEnemyStatusAilment = 2912,
        [Description("Life Gained On Spell Hit Per Enemy Status Ailment")]
        LifeGainedOnSpellHitPerEnemyStatusAilment = 2913,
        [Description("Life Regeneration Rate +% While Es Full")]
        LifeRegenerationRatePosPctWhileEsFull = 2914,
        [Description("Local Unique Jewel With X Int In Radius +1 Curse")]
        LocalUniqueJewelWithXIntInRadiusPos1Curse = 2915,
        [Description("Melee Range + While Unarmed")]
        MeleeRangePosWhileUnarmed = 2916,
        [Description("Damage +% Per Equipped Magic Item")]
        DamagePosPctPerEquippedMagicItem = 2917,
        [Description("Number Of Equipped Magic Items")]
        NumberOfEquippedMagicItems = 2918,
        [Description("Base Number Of Golems Allowed")]
        BaseNumberOfGolemsAllowed = 2919,
        [Description("Number Of Golems Allowed")]
        NumberOfGolemsAllowed = 2920,
        [Description("Fire Golem Grants Damage +%")]
        FireGolemGrantsDamagePosPct = 2921,
        [Description("Ice Golem Grants Critical Strike Chance +%")]
        IceGolemGrantsCriticalStrikeChancePosPct = 2922,
        [Description("Ice Golem Grants Accuracy +%")]
        IceGolemGrantsAccuracyPosPct = 2923,
        [Description("Chaos Golem Grants Additional Physical Damage Reduction %")]
        ChaosGolemGrantsAdditionalPhysicalDamageReductionPct = 2924,
        [Description("Spell Damage +% While Es Full")]
        SpellDamagePosPctWhileEsFull = 2925,
        [Description("Virtual Number Of Additional Projectiles")]
        VirtualNumberOfAdditionalProjectiles = 2926,
        [Description("Totem Number Of Additional Projectiles")]
        TotemNumberOfAdditionalProjectiles = 2927,
        [Description("Chance To Dodge Spells % While Es Full")]
        ChanceToDodgeSpellsPctWhileEsFull = 2928,
        [Description("Chance To Gain Unholy Might On Melee Kill %")]
        ChanceToGainUnholyMightOnMeleeKillPct = 2929,
        [Description("Spell Damage +% While No Mana Reserved")]
        SpellDamagePosPctWhileNoManaReserved = 2930,
        [Description("Mana Reserved")]
        ManaReserved = 2931,
        [Description("Spell Damage +% While Not Low Mana")]
        SpellDamagePosPctWhileNotLowMana = 2932,
        [Description("Mana Cost +% While Not Low Mana")]
        ManaCostPosPctWhileNotLowMana = 2933,
        [Description("Local Display Grants Skill Icestorm Level")]
        LocalDisplayGrantsSkillIcestormLevel = 2934,
        [Description("Spell Damage +% Per 10 Int")]
        SpellDamagePosPctPer10Int = 2935,
        [Description("Virtual Firestorm Drop Chilled Ground Duration Ms")]
        VirtualFirestormDropChilledGroundDurationMs = 2936,
        [Description("Virtual Firestorm Drop Shocked Ground Duration Ms")]
        VirtualFirestormDropShockedGroundDurationMs = 2937,
        [Description("Virtual Firestorm Drop Burning Ground Duration Ms")]
        VirtualFirestormDropBurningGroundDurationMs = 2938,
        [Description("Number Of Assigned Keystones")]
        NumberOfAssignedKeystones = 2939,
        [Description("All Attributes +% Per Assigned Keystone")]
        AllAttributesPosPctPerAssignedKeystone = 2940,
        [Description("Number Of Additional Clones")]
        NumberOfAdditionalClones = 2941,
        [Description("Damage Taken +% From Hits")]
        DamageTakenPosPctFromHits = 2942,
        [Description("Chance To Gain Frenzy Charge On Killing Frozen Enemy %")]
        ChanceToGainFrenzyChargeOnKillingFrozenEnemyPct = 2943,
        [Description("Damage +% Vs Frozen Enemies")]
        DamagePosPctVsFrozenEnemies = 2944,
        [Description("Support Hypothermia Damage +% Vs Chilled Enemies Final")]
        SupportHypothermiaDamagePosPctVsChilledEnemiesFinal = 2945,
        [Description("Additional Chance To Freeze Chilled Enemies %")]
        AdditionalChanceToFreezeChilledEnemiesPct = 2946,
        [Description("Onslaught Time Granted On Killing Shocked Enemy Ms")]
        OnslaughtTimeGrantedOnKillingShockedEnemyMs = 2947,
        [Description("Support Hypothermia Damage +% Final")]
        SupportHypothermiaDamagePosPctFinal = 2948,
        [Description("Object Inherent Attack Skills Damage +% Final Per Frenzy Charge")]
        ObjectInherentAttackSkillsDamagePosPctFinalPerFrenzyCharge = 2949,
        [Description("Skill Effect Duration Per 100 Int")]
        SkillEffectDurationPer100Int = 2950,
        [Description("Local Unique Jewel Intelligence Per Unallocated Node In Radius")]
        LocalUniqueJewelIntelligencePerUnallocatedNodeInRadius = 2951,
        [Description("Local Unique Jewel With 70 Dex Physical Damage To Add As Chaos %")]
        LocalUniqueJewelWith70DexPhysicalDamageToAddAsChaosPct = 2952,
        [Description("Local Unique Jewel With 70 Str Life Recovery Speed +%")]
        LocalUniqueJewelWith70StrLifeRecoverySpeedPosPct = 2953,
        [Description("Cannot Be Cursed With Silence")]
        CannotBeCursedWithSilence = 2954,
        [Description("Number Of Equipped Corrupted Items")]
        NumberOfEquippedCorruptedItems = 2955,
        [Description("Vaal Skill Damage +%")]
        VaalSkillDamagePosPct = 2956,
        [Description("Skill Is Vaal Skill")]
        SkillIsVaalSkill = 2957,
        [Description("Damage +% While Dead")]
        DamagePosPctWhileDead = 2958,
        [Description("Chaos Damage +% Per Equipped Corrupted Item")]
        ChaosDamagePosPctPerEquippedCorruptedItem = 2959,
        [Description("Life Leech Speed +% Per Equipped Corrupted Item")]
        LifeLeechSpeedPosPctPerEquippedCorruptedItem = 2960,
        [Description("Virtual Life Leech Speed +%")]
        VirtualLifeLeechSpeedPosPct = 2961,
        [Description("Mana Leech Speed +% Per Equipped Corrupted Item")]
        ManaLeechSpeedPosPctPerEquippedCorruptedItem = 2962,
        [Description("Virtual Mana Leech Speed +%")]
        VirtualManaLeechSpeedPosPct = 2963,
        [Description("Skill Is Attack")]
        SkillIsAttack = 2964,
        [Description("Hundred Times Non Spell Casts Per Second")]
        HundredTimesNonSpellCastsPerSecond = 2965,
        [Description("Sound On Rare Kill Ice Whisper")]
        SoundOnRareKillIceWhisper = 2966,
        [Description("Chance To Gain Vaal Soul On Kill %")]
        ChanceToGainVaalSoulOnKillPct = 2967,
        [Description("Piety Fire Form Hits Cause Stacking Damage Taken")]
        PietyFireFormHitsCauseStackingDamageTaken = 2968,
        [Description("Vaal Skill Effect Duration +%")]
        VaalSkillEffectDurationPosPct = 2969,
        [Description("Energy Shield Protects Mana")]
        EnergyShieldProtectsMana = 2970,
        [Description("Spend Energy Shield For Costs Before Mana")]
        SpendEnergyShieldForCostsBeforeMana = 2971,
        [Description("Vaal Skill Critical Strike Chance +%")]
        VaalSkillCriticalStrikeChancePosPct = 2972,
        [Description("Local Unique Item Limit")]
        LocalUniqueItemLimit = 2973,
        [Description("Vaal Skill Critical Strike Multiplier +")]
        VaalSkillCriticalStrikeMultiplierPos = 2974,
        [Description("Local Display Aura Allies Have Culling Strike")]
        LocalDisplayAuraAlliesHaveCullingStrike = 2975,
        [Description("Local Display Aura Allies Have Increased Item Rarity +%")]
        LocalDisplayAuraAlliesHaveIncreasedItemRarityPosPct = 2976,
        [Description("Chance To Gain Vaal Soul On Enemy Shatter %")]
        ChanceToGainVaalSoulOnEnemyShatterPct = 2977,
        [Description("Mana Cost +% On Totemified Aura Skills")]
        ManaCostPosPctOnTotemifiedAuraSkills = 2978,
        [Description("Skill Is Aura Skill")]
        SkillIsAuraSkill = 2979,
        [Description("Corrupted Gem Experience Gain +%")]
        CorruptedGemExperienceGainPosPct = 2980,
        [Description("Active Skill Attack Damage Final Permyriad")]
        ActiveSkillAttackDamageFinalPermyriad = 2981,
        [Description("Fortify Duration +%")]
        FortifyDurationPosPct = 2982,
        [Description("Support Slower Projectiles Damage +% Final")]
        SupportSlowerProjectilesDamagePosPctFinal = 2983,
        [Description("Chance To Evade Melee Attacks +%")]
        ChanceToEvadeMeleeAttacksPosPct = 2984,
        [Description("Support Elemental Proliferation Damage +% Final")]
        SupportElementalProliferationDamagePosPctFinal = 2985,
        [Description("Flicker Strike More Attack Speed +% Final")]
        FlickerStrikeMoreAttackSpeedPosPctFinal = 2986,
        [Description("Support Minion Damage +% Final")]
        SupportMinionDamagePosPctFinal = 2987,
        [Description("Damage +% Final From Support Minion Damage")]
        DamagePosPctFinalFromSupportMinionDamage = 2988,
        [Description("Life Leech Uses Chaos Damage When X Corrupted Items Equipped")]
        LifeLeechUsesChaosDamageWhenXCorruptedItemsEquipped = 2989,
        [Description("Half Physical Bypasses Es Half Chaos Damages Es When X Corrupted Items Equipped")]
        HalfPhysicalBypassesEsHalfChaosDamagesEsWhenXCorruptedItemsEquipped = 2990,
        [Description("Chaos Damage Damages Energy Shield %")]
        ChaosDamageDamagesEnergyShieldPct = 2991,
        [Description("Physical Damage Bypass Energy Shield %")]
        PhysicalDamageBypassEnergyShieldPct = 2992,
        [Description("Gain Soul Eater With Equipped Corrupted Items On Vaal Skill Use Ms")]
        GainSoulEaterWithEquippedCorruptedItemsOnVaalSkillUseMs = 2993,
        [Description("Base Spell Lightning Damage +%")]
        BaseSpellLightningDamagePosPct = 2994,
        [Description("Wrath Aura Spell Lightning Damage +% Final")]
        WrathAuraSpellLightningDamagePosPctFinal = 2995,
        [Description("Support Slower Projectiles Projectile Speed +% Final")]
        SupportSlowerProjectilesProjectileSpeedPosPctFinal = 2996,
        [Description("Support Reduced Duration Skill Effect Duration +% Final")]
        SupportReducedDurationSkillEffectDurationPosPctFinal = 2997,
        [Description("Maximum Mana % Gained On Kill")]
        MaximumManaPctGainedOnKill = 2998,
        [Description("Maximum Life % Lost On Kill")]
        MaximumLifePctLostOnKill = 2999,
        [Description("Maximum Energy Shield % Lost On Kill")]
        MaximumEnergyShieldPctLostOnKill = 3000,
        [Description("Passive Applies To Minions")]
        PassiveAppliesToMinions = 3001,
        [Description("Chance To Curse Self With Punishment On Kill %")]
        ChanceToCurseSelfWithPunishmentOnKillPct = 3002,
        [Description("Damage Taken +% While Es Full")]
        DamageTakenPosPctWhileEsFull = 3003,
        [Description("Base Deal No Damage")]
        BaseDealNoDamage = 3004,
        [Description("Voll Slam Damage +% Final At Centre")]
        VollSlamDamagePosPctFinalAtCentre = 3005,
        [Description("Local Unique Jewel Evasion Rating +% Per X Dex In Radius")]
        LocalUniqueJewelEvasionRatingPosPctPerXDexInRadius = 3006,
        [Description("Local Unique Jewel Claw Physical Damage +% Per X Dex In Radius")]
        LocalUniqueJewelClawPhysicalDamagePosPctPerXDexInRadius = 3007,
        [Description("Local Unique Jewel Damage Increases Applies To Fire Damage")]
        LocalUniqueJewelDamageIncreasesAppliesToFireDamage = 3008,
        [Description("Fire Sword Damage +%")]
        FireSwordDamagePosPct = 3009,
        [Description("Fire Wand Damage +%")]
        FireWandDamagePosPct = 3010,
        [Description("Two Handed Melee Fire Damage +%")]
        TwoHandedMeleeFireDamagePosPct = 3011,
        [Description("Spell Fire Damage +%")]
        SpellFireDamagePosPct = 3012,
        [Description("Melee Fire Damage +% While Holding Shield")]
        MeleeFireDamagePosPctWhileHoldingShield = 3013,
        [Description("Fire Staff Damage +%")]
        FireStaffDamagePosPct = 3014,
        [Description("Fire Mace Damage +%")]
        FireMaceDamagePosPct = 3015,
        [Description("Fire Damage While Dual Wielding +%")]
        FireDamageWhileDualWieldingPosPct = 3016,
        [Description("Fire Dagger Damage +%")]
        FireDaggerDamagePosPct = 3017,
        [Description("Fire Claw Damage +%")]
        FireClawDamagePosPct = 3018,
        [Description("Fire Bow Damage +%")]
        FireBowDamagePosPct = 3019,
        [Description("Fire Axe Damage +%")]
        FireAxeDamagePosPct = 3020,
        [Description("Fire Attack Damage +%")]
        FireAttackDamagePosPct = 3021,
        [Description("One Handed Melee Fire Damage +%")]
        OneHandedMeleeFireDamagePosPct = 3022,
        [Description("Melee Fire Damage +%")]
        MeleeFireDamagePosPct = 3023,
        [Description("Fire Damage Over Time +%")]
        FireDamageOverTimePosPct = 3024,
        [Description("Local Unique Jewel Physical Damage Increases Applies To Cold Damage")]
        LocalUniqueJewelPhysicalDamageIncreasesAppliesToColdDamage = 3025,
        [Description("Cold Sword Damage +%")]
        ColdSwordDamagePosPct = 3026,
        [Description("Cold Wand Damage +%")]
        ColdWandDamagePosPct = 3027,
        [Description("Two Handed Melee Cold Damage +%")]
        TwoHandedMeleeColdDamagePosPct = 3028,
        [Description("Spell Cold Damage +%")]
        SpellColdDamagePosPct = 3029,
        [Description("Melee Cold Damage +% While Holding Shield")]
        MeleeColdDamagePosPctWhileHoldingShield = 3030,
        [Description("Cold Staff Damage +%")]
        ColdStaffDamagePosPct = 3031,
        [Description("Cold Mace Damage +%")]
        ColdMaceDamagePosPct = 3032,
        [Description("Cold Damage While Dual Wielding +%")]
        ColdDamageWhileDualWieldingPosPct = 3033,
        [Description("Cold Dagger Damage +%")]
        ColdDaggerDamagePosPct = 3034,
        [Description("Cold Claw Damage +%")]
        ColdClawDamagePosPct = 3035,
        [Description("Cold Bow Damage +%")]
        ColdBowDamagePosPct = 3036,
        [Description("Cold Axe Damage +%")]
        ColdAxeDamagePosPct = 3037,
        [Description("Cold Attack Damage +%")]
        ColdAttackDamagePosPct = 3038,
        [Description("One Handed Melee Cold Damage +%")]
        OneHandedMeleeColdDamagePosPct = 3039,
        [Description("Melee Cold Damage +%")]
        MeleeColdDamagePosPct = 3040,
        [Description("Cold Damage Over Time +%")]
        ColdDamageOverTimePosPct = 3041,
        [Description("Additional Staff Block %")]
        AdditionalStaffBlockPct = 3042,
        [Description("Local Unique Jewel Cold Damage Increases Applies To Physical Damage")]
        LocalUniqueJewelColdDamageIncreasesAppliesToPhysicalDamage = 3043,
        [Description("Local Unique Jewel One Additional Maximum Lightning Damage Per X Dex")]
        LocalUniqueJewelOneAdditionalMaximumLightningDamagePerXDex = 3044,
        [Description("Local Unique Jewel Additional Life Per X Int In Radius")]
        LocalUniqueJewelAdditionalLifePerXIntInRadius = 3045,
        [Description("Local Unique Jewel Chaos Damage +% Per X Int In Radius")]
        LocalUniqueJewelChaosDamagePosPctPerXIntInRadius = 3046,
        [Description("Local Unique Jewel Chill Freeze Duration -% Per X Dex In Radius")]
        LocalUniqueJewelChillFreezeDurationNegPctPerXDexInRadius = 3047,
        [Description("Local Unique Jewel Dex And Int Apply To Str Melee Damage Bonus In Radius")]
        LocalUniqueJewelDexAndIntApplyToStrMeleeDamageBonusInRadius = 3048,
        [Description("Melee Damage Bonus Attributes From Jewels")]
        MeleeDamageBonusAttributesFromJewels = 3049,
        [Description("Kaom Number Of Spawners Triggered")]
        KaomNumberOfSpawnersTriggered = 3050,
        [Description("Melee Damage Vs Bleeding Enemies +%")]
        MeleeDamageVsBleedingEnemiesPosPct = 3051,
        [Description("Number Of Active Buffs")]
        NumberOfActiveBuffs = 3052,
        [Description("Fire Mortar Second Hit Damage +% Final")]
        FireMortarSecondHitDamagePosPctFinal = 3053,
        [Description("Support Trap And Mine Damage +% Final")]
        SupportTrapAndMineDamagePosPctFinal = 3054,
        [Description("Active Skill Minion Added Damage +% Final")]
        ActiveSkillMinionAddedDamagePosPctFinal = 3055,
        [Description("Minion Added Damage +% Final From Skill")]
        MinionAddedDamagePosPctFinalFromSkill = 3056,
        [Description("Newpunishment Melee Physical Damage +% Final")]
        NewpunishmentMeleePhysicalDamagePosPctFinal = 3057,
        [Description("Physical Damage +% While Life Leeching")]
        PhysicalDamagePosPctWhileLifeLeeching = 3058,
        [Description("Spell Staff Damage +%")]
        SpellStaffDamagePosPct = 3059,
        [Description("Spell Damage +% While Holding Shield")]
        SpellDamagePosPctWhileHoldingShield = 3060,
        [Description("Spell Damage +% While Dual Wielding")]
        SpellDamagePosPctWhileDualWielding = 3061,
        [Description("Cyclone Places Ground Fire Damage Per Minute")]
        CyclonePlacesGroundFireDamagePerMinute = 3062,
        [Description("Newpunishment Melee Damage +% Final")]
        NewpunishmentMeleeDamagePosPctFinal = 3063,
        [Description("Newpunishment Attack Speed +%")]
        NewpunishmentAttackSpeedPosPct = 3064,
        [Description("Base Strength And Dexterity")]
        BaseStrengthAndDexterity = 3065,
        [Description("Base Strength And Intelligence")]
        BaseStrengthAndIntelligence = 3066,
        [Description("Base Dexterity And Intelligence")]
        BaseDexterityAndIntelligence = 3067,
        [Description("Base Physical Damage % Of Maximum Life To Deal Per Minute")]
        BasePhysicalDamagePctOfMaximumLifeToDealPerMinute = 3068,
        [Description("Has Fortify")]
        HasFortify = 3069,
        [Description("Physical Damage Reduction Rating +% While Fortify Is Active")]
        PhysicalDamageReductionRatingPosPctWhileFortifyIsActive = 3070,
        [Description("Evasion Rating +% While Onslaught Is Active")]
        EvasionRatingPosPctWhileOnslaughtIsActive = 3071,
        [Description("Fortify Effect +%")]
        FortifyEffectPosPct = 3072,
        [Description("Melee Physical Damage +% While Fortify Is Active")]
        MeleePhysicalDamagePosPctWhileFortifyIsActive = 3073,
        [Description("Local Unique Jewel Unarmed Damage +% Per X Dex In Radius")]
        LocalUniqueJewelUnarmedDamagePosPctPerXDexInRadius = 3074,
        [Description("Increased Critical Strike Chance Buff For X Milliseconds On Placing A Totem")]
        IncreasedCriticalStrikeChanceBuffForXMillisecondsOnPlacingATotem = 3075,
        [Description("% Chance To Gain Power Charge On Trap Triggered By An Enemy")]
        PctChanceToGainPowerChargeOnTrapTriggeredByAnEnemy = 3076,
        [Description("% Chance To Gain Power Charge On Mine Detonated Targeting An Enemy")]
        PctChanceToGainPowerChargeOnMineDetonatedTargetingAnEnemy = 3077,
        [Description("Totem Critical Strike Chance +%")]
        TotemCriticalStrikeChancePosPct = 3078,
        [Description("Totem Critical Strike Multiplier +")]
        TotemCriticalStrikeMultiplierPos = 3079,
        [Description("Damage +% Per Active Curse On Self")]
        DamagePosPctPerActiveCurseOnSelf = 3080,
        [Description("Map Force Topology")]
        MapForceTopology = 3081,
        [Description("Maximum Life Leech Rate % Per Minute")]
        MaximumLifeLeechRatePctPerMinute = 3082,
        [Description("Maximum Mana Leech Rate % Per Minute")]
        MaximumManaLeechRatePctPerMinute = 3083,
        [Description("Chill Enemy When Hit Duration Ms")]
        ChillEnemyWhenHitDurationMs = 3084,
        [Description("Ice Crash Third Hit Damage +% Final")]
        IceCrashThirdHitDamagePosPctFinal = 3085,
        [Description("Newpunishment Applied Buff Duration Ms")]
        NewpunishmentAppliedBuffDurationMs = 3086,
        [Description("Recover X Life On Block")]
        RecoverXLifeOnBlock = 3087,
        [Description("Minion Recover X Life On Block")]
        MinionRecoverXLifeOnBlock = 3088,
        [Description("Base Physical Damage % Of Maximum Energy Shield To Deal Per Minute")]
        BasePhysicalDamagePctOfMaximumEnergyShieldToDealPerMinute = 3089,
        [Description("Base Physical Damage % Of Maximum Energy Shield Taken Per Minute")]
        BasePhysicalDamagePctOfMaximumEnergyShieldTakenPerMinute = 3090,
        [Description("Minimum Added Fire Attack Damage Per Active Buff")]
        MinimumAddedFireAttackDamagePerActiveBuff = 3091,
        [Description("Maximum Added Fire Attack Damage Per Active Buff")]
        MaximumAddedFireAttackDamagePerActiveBuff = 3092,
        [Description("Minimum Added Fire Spell Damage Per Active Buff")]
        MinimumAddedFireSpellDamagePerActiveBuff = 3093,
        [Description("Maximum Added Fire Spell Damage Per Active Buff")]
        MaximumAddedFireSpellDamagePerActiveBuff = 3094,
        [Description("Revenant Revive Explode Damage %")]
        RevenantReviveExplodeDamagePct = 3095,
        [Description("New Arctic Armour Physical Damage Taken When Hit +% Final")]
        NewArcticArmourPhysicalDamageTakenWhenHitPosPctFinal = 3096,
        [Description("New Arctic Armour Fire Damage Taken When Hit +% Final")]
        NewArcticArmourFireDamageTakenWhenHitPosPctFinal = 3097,
        [Description("Firestorm Use Server Effects")]
        FirestormUseServerEffects = 3098,
        [Description("Monster No Map Drops")]
        MonsterNoMapDrops = 3099,
        [Description("Local Life Gain Per Target")]
        LocalLifeGainPerTarget = 3100,
        [Description("Base Main Hand Local Life Gain Per Target")]
        BaseMainHandLocalLifeGainPerTarget = 3101,
        [Description("Base Off Hand Local Life Gain Per Target")]
        BaseOffHandLocalLifeGainPerTarget = 3102,
        [Description("Local Mana Gain Per Target")]
        LocalManaGainPerTarget = 3103,
        [Description("Base Main Hand Local Mana Gain Per Target")]
        BaseMainHandLocalManaGainPerTarget = 3104,
        [Description("Base Off Hand Local Mana Gain Per Target")]
        BaseOffHandLocalManaGainPerTarget = 3105,
        [Description("Local Unique Chaos Damage Does Not Bypass Energy Shield During Flask Effect")]
        LocalUniqueChaosDamageDoesNotBypassEnergyShieldDuringFlaskEffect = 3106,
        [Description("Local Unique Remove Life And Regen Es From Removed Life")]
        LocalUniqueRemoveLifeAndRegenEsFromRemovedLife = 3107,
        [Description("Local Unique Regen Es From Removed Life Duration Ms")]
        LocalUniqueRegenEsFromRemovedLifeDurationMs = 3108,
        [Description("Elemental Strike Physical Damage % To Convert")]
        ElementalStrikePhysicalDamagePctToConvert = 3109,
        [Description("Main Hand Local Life Gain Per Target")]
        MainHandLocalLifeGainPerTarget = 3110,
        [Description("Off Hand Local Life Gain Per Target")]
        OffHandLocalLifeGainPerTarget = 3111,
        [Description("Local Life And Mana Gain Per Target")]
        LocalLifeAndManaGainPerTarget = 3112,
        [Description("Base Main Hand Local Life And Mana Gain Per Target")]
        BaseMainHandLocalLifeAndManaGainPerTarget = 3113,
        [Description("Base Off Hand Local Life And Mana Gain Per Target")]
        BaseOffHandLocalLifeAndManaGainPerTarget = 3114,
        [Description("Main Hand Local Mana Gain Per Target")]
        MainHandLocalManaGainPerTarget = 3115,
        [Description("Off Hand Local Mana Gain Per Target")]
        OffHandLocalManaGainPerTarget = 3116,
        [Description("Local Life Leech From Physical Damage Permyriad")]
        LocalLifeLeechFromPhysicalDamagePermyriad = 3117,
        [Description("Main Hand Local Life Leech From Physical Damage Permyriad")]
        MainHandLocalLifeLeechFromPhysicalDamagePermyriad = 3118,
        [Description("Off Hand Local Life Leech From Physical Damage Permyriad")]
        OffHandLocalLifeLeechFromPhysicalDamagePermyriad = 3119,
        [Description("Local Mana Leech From Physical Damage Permyriad")]
        LocalManaLeechFromPhysicalDamagePermyriad = 3120,
        [Description("Main Hand Local Mana Leech From Physical Damage Permyriad")]
        MainHandLocalManaLeechFromPhysicalDamagePermyriad = 3121,
        [Description("Off Hand Local Mana Leech From Physical Damage Permyriad")]
        OffHandLocalManaLeechFromPhysicalDamagePermyriad = 3122,
        [Description("Life Leech From Physical Attack Damage Permyriad")]
        LifeLeechFromPhysicalAttackDamagePermyriad = 3123,
        [Description("Mana Leech From Physical Attack Damage Permyriad")]
        ManaLeechFromPhysicalAttackDamagePermyriad = 3124,
        [Description("Local Flask Life Leech Permyriad While Healing")]
        LocalFlaskLifeLeechPermyriadWhileHealing = 3125,
        [Description("Local Flask Mana Leech Permyriad While Healing")]
        LocalFlaskManaLeechPermyriadWhileHealing = 3126,
        [Description("Base Life Leech From Spell Damage Permyriad")]
        BaseLifeLeechFromSpellDamagePermyriad = 3127,
        [Description("Base Mana Leech From Spell Damage Permyriad")]
        BaseManaLeechFromSpellDamagePermyriad = 3128,
        [Description("Life Leech From Spell Damage Permyriad")]
        LifeLeechFromSpellDamagePermyriad = 3129,
        [Description("Mana Leech From Spell Damage Permyriad")]
        ManaLeechFromSpellDamagePermyriad = 3130,
        [Description("Mana Leech From Physical Damage Permyriad Per Power Charge")]
        ManaLeechFromPhysicalDamagePermyriadPerPowerCharge = 3131,
        [Description("Global Mana Leech From Physical Attack Damage Permyriad Per Blue Socket On Item")]
        GlobalManaLeechFromPhysicalAttackDamagePermyriadPerBlueSocketOnItem = 3132,
        [Description("Base Mana Leech Permyriad Vs Shocked Enemies")]
        BaseManaLeechPermyriadVsShockedEnemies = 3133,
        [Description("Base Life Leech Permyriad Vs Frozen Enemies")]
        BaseLifeLeechPermyriadVsFrozenEnemies = 3134,
        [Description("Mana Leech Permyriad Vs Shocked Enemies")]
        ManaLeechPermyriadVsShockedEnemies = 3135,
        [Description("Life Leech Permyriad Vs Frozen Enemies")]
        LifeLeechPermyriadVsFrozenEnemies = 3136,
        [Description("Base Life Leech From Physical Damage Permyriad")]
        BaseLifeLeechFromPhysicalDamagePermyriad = 3137,
        [Description("Base Life Leech From Fire Damage Permyriad")]
        BaseLifeLeechFromFireDamagePermyriad = 3138,
        [Description("Base Life Leech From Cold Damage Permyriad")]
        BaseLifeLeechFromColdDamagePermyriad = 3139,
        [Description("Base Life Leech From Lightning Damage Permyriad")]
        BaseLifeLeechFromLightningDamagePermyriad = 3140,
        [Description("Base Mana Leech From Lightning Damage Permyriad")]
        BaseManaLeechFromLightningDamagePermyriad = 3141,
        [Description("Local Unique Flask Life Leech From Chaos Damage Permyriad While Healing")]
        LocalUniqueFlaskLifeLeechFromChaosDamagePermyriadWhileHealing = 3142,
        [Description("Base Life Leech From Elemental Damage Permyriad")]
        BaseLifeLeechFromElementalDamagePermyriad = 3143,
        [Description("Life Leech Permyriad On Crit")]
        LifeLeechPermyriadOnCrit = 3144,
        [Description("Base Life Leech Permyriad Vs Shocked Enemies")]
        BaseLifeLeechPermyriadVsShockedEnemies = 3145,
        [Description("Life Leech Permyriad Vs Shocked Enemies")]
        LifeLeechPermyriadVsShockedEnemies = 3146,
        [Description("Base Life Leech From Attack Damage Permyriad Vs Chilled Enemies")]
        BaseLifeLeechFromAttackDamagePermyriadVsChilledEnemies = 3147,
        [Description("Life Leech From Physical Damage With Claw Permyriad")]
        LifeLeechFromPhysicalDamageWithClawPermyriad = 3148,
        [Description("Minion Life Leech From Any Damage Permyriad")]
        MinionLifeLeechFromAnyDamagePermyriad = 3149,
        [Description("Mana Leech From Physical Damage With Claw Permyriad")]
        ManaLeechFromPhysicalDamageWithClawPermyriad = 3150,
        [Description("Life Leech From Attack Damage Permyriad Vs Chilled Enemies")]
        LifeLeechFromAttackDamagePermyriadVsChilledEnemies = 3151,
        [Description("Map Summon Exploding Buff Storms")]
        MapSummonExplodingBuffStorms = 3152,
        [Description("Map Items Have Random Quality")]
        MapItemsHaveRandomQuality = 3153,
        [Description("Map Summon Runic Circles")]
        MapSummonRunicCircles = 3154,
        [Description("Map Spawn Warbands")]
        MapSpawnWarbands = 3155,
        [Description("Chance To Gain Endurance Charge On Bow Crit %")]
        ChanceToGainEnduranceChargeOnBowCritPct = 3156,
        [Description("Global Critical Strike Chance +% While Holding Bow")]
        GlobalCriticalStrikeChancePosPctWhileHoldingBow = 3157,
        [Description("Global Critical Strike Multiplier + While Holding Bow")]
        GlobalCriticalStrikeMultiplierPosWhileHoldingBow = 3158,
        [Description("Map Spawn Extra Warbands")]
        MapSpawnExtraWarbands = 3159,
        [Description("Soul Is Consumed On Death")]
        SoulIsConsumedOnDeath = 3160,
        [Description("Some Passives Apply To Minions")]
        SomePassivesApplyToMinions = 3161,
        [Description("Damage +% With Movement Skills")]
        DamagePosPctWithMovementSkills = 3162,
        [Description("Attack Speed +% With Movement Skills")]
        AttackSpeedPosPctWithMovementSkills = 3163,
        [Description("Life Gained On Killing Ignited Enemies")]
        LifeGainedOnKillingIgnitedEnemies = 3164,
        [Description("Damage Taken +% From Skeletons")]
        DamageTakenPosPctFromSkeletons = 3165,
        [Description("Damage Taken +% From Ghosts")]
        DamageTakenPosPctFromGhosts = 3166,
        [Description("Skill Is Movement Skill")]
        SkillIsMovementSkill = 3167,
        [Description("Cannot Be Shocked While Frozen")]
        CannotBeShockedWhileFrozen = 3168,
        [Description("Local Display Grants Skill Lightning Warp Level")]
        LocalDisplayGrantsSkillLightningWarpLevel = 3169,
        [Description("Life Leech From Attack Damage Permyriad Vs Bleeding Enemies")]
        LifeLeechFromAttackDamagePermyriadVsBleedingEnemies = 3170,
        [Description("Number Of Additional Curses Allowed On Self")]
        NumberOfAdditionalCursesAllowedOnSelf = 3171,
        [Description("Map Spawn Warband Fire")]
        MapSpawnWarbandFire = 3172,
        [Description("Map Spawn Warband Cold")]
        MapSpawnWarbandCold = 3173,
        [Description("Map Spawn Warband Thunder")]
        MapSpawnWarbandThunder = 3174,
        [Description("Map Spawn Warband Chaos")]
        MapSpawnWarbandChaos = 3175,
        [Description("Map Max Warband Rank")]
        MapMaxWarbandRank = 3176,
        [Description("Monster Report Warband Destroyed On Death")]
        MonsterReportWarbandDestroyedOnDeath = 3177,
        [Description("Trap Throw Arm Time Override")]
        TrapThrowArmTimeOverride = 3178,
        [Description("Item Rarity +% While Using Flask")]
        ItemRarityPosPctWhileUsingFlask = 3179,
        [Description("Dropped Items Are Corrupted")]
        DroppedItemsAreCorrupted = 3180,
        [Description("Monster Dropped Non Unique Equipment Drops As Sell Price")]
        MonsterDroppedNonUniqueEquipmentDropsAsSellPrice = 3181,
        [Description("Monster Dropped Items Have Random Quality")]
        MonsterDroppedItemsHaveRandomQuality = 3182,
        [Description("Player Found Items Are Corrupted")]
        PlayerFoundItemsAreCorrupted = 3183,
        [Description("Player Non Unique Equipment Found As Sell Price")]
        PlayerNonUniqueEquipmentFoundAsSellPrice = 3184,
        [Description("Player Found Items Have Random Quality")]
        PlayerFoundItemsHaveRandomQuality = 3185,
        [Description("Map Storm Delay +%")]
        MapStormDelayPosPct = 3186,
        [Description("Map Storm Duration +%")]
        MapStormDurationPosPct = 3187,
        [Description("Map Storm Area Of Effect +%")]
        MapStormAreaOfEffectPosPct = 3188,
        [Description("Map Storm Buff Duration +%")]
        MapStormBuffDurationPosPct = 3189,
        [Description("Map Storm Buff Duration +% On Low Life Target")]
        MapStormBuffDurationPosPctOnLowLifeTarget = 3190,
        [Description("Map Tempest Random Monster Drops Unique")]
        MapTempestRandomMonsterDropsUnique = 3191,
        [Description("Map Tempest Random Monster Drops Map")]
        MapTempestRandomMonsterDropsMap = 3192,
        [Description("Map Tempest Fish School Size +%")]
        MapTempestFishSchoolSizePosPct = 3193,
        [Description("Monster Stormcall Individually Trigger")]
        MonsterStormcallIndividuallyTrigger = 3194,
        [Description("Map Tempest Random Monster Drops Vaal Fragment")]
        MapTempestRandomMonsterDropsVaalFragment = 3195,
        [Description("Map Bosses Have Phylacteral Link")]
        MapBossesHavePhylacteralLink = 3196,
        [Description("Monster Can Have Bloodline")]
        MonsterCanHaveBloodline = 3197,
        [Description("Local Socketed Warcry Gem Level +")]
        LocalSocketedWarcryGemLevelPos = 3198,
        [Description("Mana Gained On Hitting Taunted Enemy")]
        ManaGainedOnHittingTauntedEnemy = 3199,
        [Description("Life Gained On Taunting Enemy")]
        LifeGainedOnTauntingEnemy = 3200,
        [Description("Onslaught Buff Duration On Killing Taunted Enemy Ms")]
        OnslaughtBuffDurationOnKillingTauntedEnemyMs = 3201,
        [Description("Local Socketed Golem Gem Level +")]
        LocalSocketedGolemGemLevelPos = 3202,
        [Description("Local Display Socketed Gems Supported By X Increased Minion Life Level")]
        LocalDisplaySocketedGemsSupportedByXIncreasedMinionLifeLevel = 3203,
        [Description("Local Display Socketed Gems Supported By X Lesser Multiple Projectiles Level")]
        LocalDisplaySocketedGemsSupportedByXLesserMultipleProjectilesLevel = 3204,
        [Description("Local Display Socketed Gems Supported By X Increased Minion Damage Level")]
        LocalDisplaySocketedGemsSupportedByXIncreasedMinionDamageLevel = 3205,
        [Description("Local Display Socketed Gems Supported By X Increased Critical Damage Level")]
        LocalDisplaySocketedGemsSupportedByXIncreasedCriticalDamageLevel = 3206,
        [Description("Number Of Power Charges To Gain")]
        NumberOfPowerChargesToGain = 3207,
        [Description("Number Of Frenzy Charges To Gain")]
        NumberOfFrenzyChargesToGain = 3208,
        [Description("Number Of Endurance Charges To Gain")]
        NumberOfEnduranceChargesToGain = 3209,
        [Description("Animate Weapon Duration +%")]
        AnimateWeaponDurationPosPct = 3210,
        [Description("Totem Skill Area Of Effect +%")]
        TotemSkillAreaOfEffectPosPct = 3211,
        [Description("Life Leech From Skills Used By Totems Permyriad")]
        LifeLeechFromSkillsUsedByTotemsPermyriad = 3212,
        [Description("Damage Reflected To Enemies % Gained As Life")]
        DamageReflectedToEnemiesPctGainedAsLife = 3213,
        [Description("Animate Weapon Number Of Additional Copies")]
        AnimateWeaponNumberOfAdditionalCopies = 3214,
        [Description("Cannot Drop Below % Life")]
        CannotDropBelowPctLife = 3215,
        [Description("Local Display Socketed Gems Supported By X Increased Minion Speed Level")]
        LocalDisplaySocketedGemsSupportedByXIncreasedMinionSpeedLevel = 3216,
        [Description("Attack Is Not Melee Override")]
        AttackIsNotMeleeOverride = 3217,
        [Description("Map Storm Delay +% Final")]
        MapStormDelayPosPctFinal = 3218,
        [Description("Map Storm Duration +% Final")]
        MapStormDurationPosPctFinal = 3219,
        [Description("Map Always Has Weather")]
        MapAlwaysHasWeather = 3220,
        [Description("Melee Weapon Range +")]
        MeleeWeaponRangePos = 3221,
        [Description("Damage +% Vs Players")]
        DamagePosPctVsPlayers = 3222,
        [Description("Immune Vaal Lighting Warp")]
        ImmuneVaalLightingWarp = 3223,
        [Description("Base Secondary Skill Effect Duration")]
        BaseSecondarySkillEffectDuration = 3224,
        [Description("Secondary Skill Effect Duration")]
        SecondarySkillEffectDuration = 3225,
        [Description("Enemy Aggro Radius +%")]
        EnemyAggroRadiusPosPct = 3226,
        [Description("Skill Effect Duration +% Per Frenzy Charge")]
        SkillEffectDurationPosPctPerFrenzyCharge = 3227,
        [Description("Chilled Ground Effect On Self +%")]
        ChilledGroundEffectOnSelfPosPct = 3228,
        [Description("Burning Ground Effect On Self +%")]
        BurningGroundEffectOnSelfPosPct = 3229,
        [Description("Shocked Ground Effect On Self +%")]
        ShockedGroundEffectOnSelfPosPct = 3230,
        [Description("Desecrated Ground Effect On Self +%")]
        DesecratedGroundEffectOnSelfPosPct = 3231,
        [Description("Spell And Attack Minimum Added Lightning Damage")]
        SpellAndAttackMinimumAddedLightningDamage = 3232,
        [Description("Spell And Attack Maximum Added Lightning Damage")]
        SpellAndAttackMaximumAddedLightningDamage = 3233,
        [Description("Shocked Ground When Hit %")]
        ShockedGroundWhenHitPct = 3234,
        [Description("Map Tempest Base Ground Fire Damage To Deal Per Minute")]
        MapTempestBaseGroundFireDamageToDealPerMinute = 3235,
        [Description("Map Tempest Base Ground Desecration Damage To Deal Per Minute")]
        MapTempestBaseGroundDesecrationDamageToDealPerMinute = 3236,
        [Description("Map Tempest Ground Ice")]
        MapTempestGroundIce = 3237,
        [Description("Map Tempest Ground Tar Movement Speed +%")]
        MapTempestGroundTarMovementSpeedPosPct = 3238,
        [Description("Map Tempest Ground Lightning")]
        MapTempestGroundLightning = 3239,
        [Description("Map Tempest Ground Effect Patches Per 100 Tiles")]
        MapTempestGroundEffectPatchesPer100Tiles = 3240,
        [Description("Map Tempest Ground Effect Radius")]
        MapTempestGroundEffectRadius = 3241,
        [Description("Projectile Minimum Range")]
        ProjectileMinimumRange = 3242,
        [Description("Projectile Speed Variation +%")]
        ProjectileSpeedVariationPosPct = 3243,
        [Description("Secondary Buff Effect Duration")]
        SecondaryBuffEffectDuration = 3244,
        [Description("Level 1 To 40 Life +% Final")]
        Level1To40LifePosPctFinal = 3245,
        [Description("Level 41 To 57 Life +% Final")]
        Level41To57LifePosPctFinal = 3246,
        [Description("Level 58 To 70 Life +% Final")]
        Level58To70LifePosPctFinal = 3247,
        [Description("Local Unique Jewel Energy Shield Increases Applies To Armour Doubled")]
        LocalUniqueJewelEnergyShieldIncreasesAppliesToArmourDoubled = 3248,
        [Description("Local Unique Jewel Life Increases Applies To Energy Shield")]
        LocalUniqueJewelLifeIncreasesAppliesToEnergyShield = 3249,
        [Description("Local Unique Jewel Life Increases Applies To Mana Doubled")]
        LocalUniqueJewelLifeIncreasesAppliesToManaDoubled = 3250,
        [Description("Cyclone First Hit Damage +% Final")]
        CycloneFirstHitDamagePosPctFinal = 3251,
        [Description("Cannot Use Warcries")]
        CannotUseWarcries = 3252,
        [Description("Map Debug Disable Nonboss Monsters")]
        MapDebugDisableNonbossMonsters = 3253,
        [Description("Totem Mana +%")]
        TotemManaPosPct = 3254,
        [Description("Totem Energy Shield +%")]
        TotemEnergyShieldPosPct = 3255,
        [Description("Minion Maximum Mana +%")]
        MinionMaximumManaPosPct = 3256,
        [Description("Minion Maximum Energy Shield +%")]
        MinionMaximumEnergyShieldPosPct = 3257,
        [Description("Base Maximum Life Per Red Socket On Item")]
        BaseMaximumLifePerRedSocketOnItem = 3258,
        [Description("Base Maximum Energy Shield Per Blue Socket On Item")]
        BaseMaximumEnergyShieldPerBlueSocketOnItem = 3259,
        [Description("Base Maximum Mana Per Green Socket On Item")]
        BaseMaximumManaPerGreenSocketOnItem = 3260,
        [Description("Currently Has No Energy Shield")]
        CurrentlyHasNoEnergyShield = 3261,
        [Description("Damage +% When Currently Has No Energy Shield")]
        DamagePosPctWhenCurrentlyHasNoEnergyShield = 3262,
        [Description("Chance To Gain Unholy Might On Block %")]
        ChanceToGainUnholyMightOnBlockPct = 3263,
        [Description("Damage +% When On Burning Ground")]
        DamagePosPctWhenOnBurningGround = 3264,
        [Description("Life Regeneration Rate Per Minute % When On Chilled Ground")]
        LifeRegenerationRatePerMinutePctWhenOnChilledGround = 3265,
        [Description("Movement Velocity +% When On Shocked Ground")]
        MovementVelocityPosPctWhenOnShockedGround = 3266,
        [Description("Is On Ground Fire Burn")]
        IsOnGroundFireBurn = 3267,
        [Description("Is On Ground Ice Chill")]
        IsOnGroundIceChill = 3268,
        [Description("Is On Ground Lightning Shock")]
        IsOnGroundLightningShock = 3269,
        [Description("Damage Taken Goes To Mana % Per Power Charge")]
        DamageTakenGoesToManaPctPerPowerCharge = 3270,
        [Description("Power Charge Art Variation")]
        PowerChargeArtVariation = 3271,
        [Description("Map Tempest Display Prefix")]
        MapTempestDisplayPrefix = 3272,
        [Description("Map Tempest Display Suffix")]
        MapTempestDisplaySuffix = 3273,
        [Description("Temporal Chains Action Speed +% Final")]
        TemporalChainsActionSpeedPosPctFinal = 3274,
        [Description("Virtual Action Speed +%")]
        VirtualActionSpeedPosPct = 3275,
        [Description("Light Radius +% While Phased")]
        LightRadiusPosPctWhilePhased = 3276,
        [Description("Map Monsters Area Of Effect +%")]
        MapMonstersAreaOfEffectPosPct = 3277,
        [Description("Map Monsters Avoid Freeze And Chill %")]
        MapMonstersAvoidFreezeAndChillPct = 3278,
        [Description("Map Monsters Avoid Ignite %")]
        MapMonstersAvoidIgnitePct = 3279,
        [Description("Map Monsters Avoid Shock %")]
        MapMonstersAvoidShockPct = 3280,
        [Description("Map Monsters Avoid Elemental Ailments %")]
        MapMonstersAvoidElementalAilmentsPct = 3281,
        [Description("Map Monsters Critical Strike Chance +%")]
        MapMonstersCriticalStrikeChancePosPct = 3282,
        [Description("Map Monsters Critical Strike Multiplier +")]
        MapMonstersCriticalStrikeMultiplierPos = 3283,
        [Description("Map Monsters Life Leech Resistance %")]
        MapMonstersLifeLeechResistancePct = 3284,
        [Description("Map Monsters Mana Leech Resistance %")]
        MapMonstersManaLeechResistancePct = 3285,
        [Description("Map Boss Maximum Life +%")]
        MapBossMaximumLifePosPct = 3286,
        [Description("Map Boss Area Of Effect +%")]
        MapBossAreaOfEffectPosPct = 3287,
        [Description("Map Hidden Experience Gain +%")]
        MapHiddenExperienceGainPosPct = 3288,
        [Description("Map Hidden Rare Monsters Have Nemesis Mod")]
        MapHiddenRareMonstersHaveNemesisMod = 3289,
        [Description("Map Hidden Spawn Extra Exiles")]
        MapHiddenSpawnExtraExiles = 3290,
        [Description("Map Hidden Spawn Extra Torment Spirits")]
        MapHiddenSpawnExtraTormentSpirits = 3291,
        [Description("Map Hidden Magic Pack Mod Rules")]
        MapHiddenMagicPackModRules = 3292,
        [Description("Map Hidden Monsters Additional Fire Resistance")]
        MapHiddenMonstersAdditionalFireResistance = 3293,
        [Description("Map Hidden Monsters Additional Cold Resistance")]
        MapHiddenMonstersAdditionalColdResistance = 3294,
        [Description("Map Hidden Monsters Additional Lightning Resistance")]
        MapHiddenMonstersAdditionalLightningResistance = 3295,
        [Description("Map Hidden Monsters Poison On Hit")]
        MapHiddenMonstersPoisonOnHit = 3296,
        [Description("Map Hidden Monsters % Physical Damage To Add As Fire")]
        MapHiddenMonstersPctPhysicalDamageToAddAsFire = 3297,
        [Description("Map Hidden Monsters % Physical Damage To Add As Cold")]
        MapHiddenMonstersPctPhysicalDamageToAddAsCold = 3298,
        [Description("Map Hidden Monsters % Physical Damage To Add As Lightning")]
        MapHiddenMonstersPctPhysicalDamageToAddAsLightning = 3299,
        [Description("Map Hidden Monsters % Physical Damage To Add As Chaos")]
        MapHiddenMonstersPctPhysicalDamageToAddAsChaos = 3300,
        [Description("Map Hidden Packs Are Totems")]
        MapHiddenPacksAreTotems = 3301,
        [Description("Skill Effect Duration Per 100 Int +%")]
        SkillEffectDurationPer100IntPosPct = 3302,
        [Description("Map Equipment Drops Identified")]
        MapEquipmentDropsIdentified = 3303,
        [Description("Player Found Equipment Drops Identified")]
        PlayerFoundEquipmentDropsIdentified = 3304,
        [Description("Monster Equipment Drops Identified")]
        MonsterEquipmentDropsIdentified = 3305,
        [Description("Flask Charges Gained +% During Flask Effect")]
        FlaskChargesGainedPosPctDuringFlaskEffect = 3306,
        [Description("Mana Regeneration Rate +% During Flask Effect")]
        ManaRegenerationRatePosPctDuringFlaskEffect = 3307,
        [Description("Movement Speed +% During Flask Effect")]
        MovementSpeedPosPctDuringFlaskEffect = 3308,
        [Description("Map Player Has Level X Punishment")]
        MapPlayerHasLevelXPunishment = 3309,
        [Description("Item Found Quantity +% Per White Socket On Item")]
        ItemFoundQuantityPosPctPerWhiteSocketOnItem = 3310,
        [Description("Monster Number Of Additional Players")]
        MonsterNumberOfAdditionalPlayers = 3311,
        [Description("Local Unique Jewel Physical Attack Damage +1% Per X Strength In Radius")]
        LocalUniqueJewelPhysicalAttackDamagePos1PctPerXStrengthInRadius = 3312,
        [Description("Local Unique Jewel Fortify Duration +1% Per X Int In Radius")]
        LocalUniqueJewelFortifyDurationPos1PctPerXIntInRadius = 3313,
        [Description("Local Unique Jewel Fire Damage +1% Per X Int In Radius")]
        LocalUniqueJewelFireDamagePos1PctPerXIntInRadius = 3314,
        [Description("Local Unique Jewel Cold Damage +1% Per X Int In Radius")]
        LocalUniqueJewelColdDamagePos1PctPerXIntInRadius = 3315,
        [Description("Local Unique Jewel Physical Damage +1% Per Int In Radius")]
        LocalUniqueJewelPhysicalDamagePos1PctPerIntInRadius = 3316,
        [Description("Local Unique Jewel Physical Attack Damage +1% Per X Dex In Radius")]
        LocalUniqueJewelPhysicalAttackDamagePos1PctPerXDexInRadius = 3317,
        [Description("Local Unique Jewel Projectile Damage +1% Per X Dex In Radius")]
        LocalUniqueJewelProjectileDamagePos1PctPerXDexInRadius = 3318,
        [Description("Local Unique Jewel Fireball Explosion Radius 20% Less At Close Range 50% More At Long Range With X Int In Radius")]
        LocalUniqueJewelFireballExplosionRadius20PctLessAtCloseRange50PctMoreAtLongRangeWithXIntInRadius = 3319,
        [Description("Local Unique Jewel Glacial Cascade Additional Sequence With X Int In Radius")]
        LocalUniqueJewelGlacialCascadeAdditionalSequenceWithXIntInRadius = 3320,
        [Description("Local Unique Jewel Animate Weapon Animates Bows And Wands With X Dex In Radius")]
        LocalUniqueJewelAnimateWeaponAnimatesBowsAndWandsWithXDexInRadius = 3321,
        [Description("Local Unique Jewel Split Arrow Fires Additional Arrow With X Dex In Radius")]
        LocalUniqueJewelSplitArrowFiresAdditionalArrowWithXDexInRadius = 3322,
        [Description("Vigilant Strike Applies To Nearby Allies For X Seconds")]
        VigilantStrikeAppliesToNearbyAlliesForXSeconds = 3323,
        [Description("Split Arrow Number Of Additional Arrows")]
        SplitArrowNumberOfAdditionalArrows = 3324,
        [Description("Animate Weapon Can Animate Bows")]
        AnimateWeaponCanAnimateBows = 3325,
        [Description("Animate Weapon Can Animate Wands")]
        AnimateWeaponCanAnimateWands = 3326,
        [Description("Fireball Explosion Radius 20% Less At Close Range 50% More At Long Range")]
        FireballExplosionRadius20PctLessAtCloseRange50PctMoreAtLongRange = 3327,
        [Description("Total Physical Damage Taken Per Minute")]
        TotalPhysicalDamageTakenPerMinute = 3328,
        [Description("Total Fire Damage Taken Per Minute")]
        TotalFireDamageTakenPerMinute = 3329,
        [Description("Total Cold Damage Taken Per Minute")]
        TotalColdDamageTakenPerMinute = 3330,
        [Description("Total Lightning Damage Taken Per Minute")]
        TotalLightningDamageTakenPerMinute = 3331,
        [Description("Total Chaos Damage Taken Per Minute")]
        TotalChaosDamageTakenPerMinute = 3332,
        [Description("Total Nonlethal Fire Damage Taken Per Minute")]
        TotalNonlethalFireDamageTakenPerMinute = 3333,
        [Description("Total Damage Taken Per Minute To Energy Shield")]
        TotalDamageTakenPerMinuteToEnergyShield = 3334,
        [Description("Total Damage Taken Per Minute To Life")]
        TotalDamageTakenPerMinuteToLife = 3335,
        [Description("Total Nonlethal Damage Taken Per Minute To Energy Shield")]
        TotalNonlethalDamageTakenPerMinuteToEnergyShield = 3336,
        [Description("Total Nonlethal Damage Taken Per Minute To Life")]
        TotalNonlethalDamageTakenPerMinuteToLife = 3337,
        [Description("Total Healing From Damage Taken Per Minute")]
        TotalHealingFromDamageTakenPerMinute = 3338,
        [Description("Chance To Gain Unholy Might On Kill For 3 Seconds %")]
        ChanceToGainUnholyMightOnKillFor3SecondsPct = 3339,
        [Description("Chance To Grant Nearby Enemies Onslaught On Kill %")]
        ChanceToGrantNearbyEnemiesOnslaughtOnKillPct = 3340,
        [Description("Chance To Grant Nearby Enemies Unholy Might On Kill %")]
        ChanceToGrantNearbyEnemiesUnholyMightOnKillPct = 3341,
        [Description("Recover % Maximum Life On Kill")]
        RecoverPctMaximumLifeOnKill = 3342,
        [Description("Chance To Cast On Kill % Target Self")]
        ChanceToCastOnKillPctTargetSelf = 3343,
        [Description("Socketed Trap Skills Create Smoke Cloud")]
        SocketedTrapSkillsCreateSmokeCloud = 3344,
        [Description("Fire Damage +% To Blinded Enemies")]
        FireDamagePosPctToBlindedEnemies = 3345,
        [Description("Spell Damage Taken +% From Blinded Enemies")]
        SpellDamageTakenPosPctFromBlindedEnemies = 3346,
        [Description("Curse Enemies With Level X Assassins Mark When Curse Cast")]
        CurseEnemiesWithLevelXAssassinsMarkWhenCurseCast = 3347,
        [Description("Disable Weapons")]
        DisableWeapons = 3348,
        [Description("Shock Dispelled On Full Energy Shield")]
        ShockDispelledOnFullEnergyShield = 3349,
        [Description("Local Display Nearby Enemies Take X Lightning Damage Per Minute")]
        LocalDisplayNearbyEnemiesTakeXLightningDamagePerMinute = 3350,
        [Description("Item Destroyed On Death")]
        ItemDestroyedOnDeath = 3351,
        [Description("Summoned Monsters Set Parent")]
        SummonedMonstersSetParent = 3352,
        [Description("Maximum Number Of Spinning Blades")]
        MaximumNumberOfSpinningBlades = 3353,
        [Description("Ball Lightning Damage +%")]
        BallLightningDamagePosPct = 3354,
        [Description("Cast When Critically Hit %")]
        CastWhenCriticallyHitPct = 3355,
        [Description("Attack Trigger On Hit %")]
        AttackTriggerOnHitPct = 3356,
        [Description("Cast On Hit %")]
        CastOnHitPct = 3357,
        [Description("Map Spawn Talismans")]
        MapSpawnTalismans = 3358,
        [Description("Map Spawn Extra Talismans")]
        MapSpawnExtraTalismans = 3359,
        [Description("Map Hidden Num Extra Invasion Bosses")]
        MapHiddenNumExtraInvasionBosses = 3360,
        [Description("Monster No Talismans")]
        MonsterNoTalismans = 3361,
        [Description("Enchantment Boots Life And Mana Regen Per Minute % For 4 Seconds When Hit")]
        EnchantmentBootsLifeAndManaRegenPerMinutePctFor4SecondsWhenHit = 3362,
        [Description("Fire Damage Taken % As Lightning")]
        FireDamageTakenPctAsLightning = 3363,
        [Description("Fire Damage Taken % As Cold")]
        FireDamageTakenPctAsCold = 3364,
        [Description("Lightning Damage Taken % As Cold")]
        LightningDamageTakenPctAsCold = 3365,
        [Description("Lightning Damage Taken % As Fire")]
        LightningDamageTakenPctAsFire = 3366,
        [Description("Cold Damage Taken % As Lightning")]
        ColdDamageTakenPctAsLightning = 3367,
        [Description("Cold Damage Taken % As Fire")]
        ColdDamageTakenPctAsFire = 3368,
        [Description("All Attributes +%")]
        AllAttributesPosPct = 3369,
        [Description("Base Cooldown Speed +%")]
        BaseCooldownSpeedPosPct = 3370,
        [Description("Virtual Cooldown Speed +%")]
        VirtualCooldownSpeedPosPct = 3371,
        [Description("Base Righteous Lightning % Of Max Mana To Deal To Nearby Per Minute")]
        BaseRighteousLightningPctOfMaxManaToDealToNearbyPerMinute = 3372,
        [Description("Righteous Lightning Critical Strike Chance +%")]
        RighteousLightningCriticalStrikeChancePosPct = 3373,
        [Description("Mana Degeneration Per Minute %")]
        ManaDegenerationPerMinutePct = 3374,
        [Description("Active Skill Index")]
        ActiveSkillIndex = 3375,
        [Description("Stun Threshold Based On % Mana Instead Of Life")]
        StunThresholdBasedOnPctManaInsteadOfLife = 3376,
        [Description("Local Flask Gain X Seconds Of Onslaught Per Frenzy Charge")]
        LocalFlaskGainXSecondsOfOnslaughtPerFrenzyCharge = 3377,
        [Description("Life Leech Applies To Enemies %")]
        LifeLeechAppliesToEnemiesPct = 3378,
        [Description("Enchantment Boots Minimum Added Fire Damage On Kill 4s")]
        EnchantmentBootsMinimumAddedFireDamageOnKill4s = 3379,
        [Description("Enchantment Boots Maximum Added Fire Damage On Kill 4s")]
        EnchantmentBootsMaximumAddedFireDamageOnKill4s = 3380,
        [Description("Enchantment Boots Movement Speed +% When Not Hit For 4 Seconds")]
        EnchantmentBootsMovementSpeedPosPctWhenNotHitFor4Seconds = 3381,
        [Description("Enchantment Boots Dodge Chance When Critically Hit %")]
        EnchantmentBootsDodgeChanceWhenCriticallyHitPct = 3382,
        [Description("Enchantment Boots Status Ailment Chance +% When Havent Crit For 4 Seconds")]
        EnchantmentBootsStatusAilmentChancePosPctWhenHaventCritFor4Seconds = 3383,
        [Description("Base Chance To Stun %")]
        BaseChanceToStunPct = 3384,
        [Description("Display Cast Word Of Flames On Kill %")]
        DisplayCastWordOfFlamesOnKillPct = 3385,
        [Description("Display Cast Word Of Blades On Kill %")]
        DisplayCastWordOfBladesOnKillPct = 3386,
        [Description("Display Cast Word Of Reflection On Kill %")]
        DisplayCastWordOfReflectionOnKillPct = 3387,
        [Description("Display Cast Word Of Force On Hit %")]
        DisplayCastWordOfForceOnHitPct = 3388,
        [Description("Display Cast Word Of Light When Hit %")]
        DisplayCastWordOfLightWhenHitPct = 3389,
        [Description("Display Cast Word Of Thunder On Hit %")]
        DisplayCastWordOfThunderOnHitPct = 3390,
        [Description("Display Cast Word Of The Grave On Kill %")]
        DisplayCastWordOfTheGraveOnKillPct = 3391,
        [Description("Display Cast Word Of War On Kill %")]
        DisplayCastWordOfWarOnKillPct = 3392,
        [Description("Map Spawn Stone Circles")]
        MapSpawnStoneCircles = 3393,
        [Description("Map Force Stone Circle")]
        MapForceStoneCircle = 3394,
        [Description("Base Poison Damage +%")]
        BasePoisonDamagePosPct = 3395,
        [Description("Base Poison Duration +%")]
        BasePoisonDurationPosPct = 3396,
        [Description("Poison Duration +%")]
        PoisonDurationPosPct = 3397,
        [Description("Poison Skill Effect Duration")]
        PoisonSkillEffectDuration = 3398,
        [Description("Base Chance To Poison On Hit %")]
        BaseChanceToPoisonOnHitPct = 3399,
        [Description("Quake Slam Fully Charged Explosion Damage +% Final")]
        QuakeSlamFullyChargedExplosionDamagePosPctFinal = 3400,
        [Description("Local Unique Jewel Glacial Hammer Item Rarity On Shattering Enemy +% With 50 Strength In Radius")]
        LocalUniqueJewelGlacialHammerItemRarityOnShatteringEnemyPosPctWith50StrengthInRadius = 3401,
        [Description("Local Unique Jewel Spectral Throw Damage For Each Enemy Hit With Spectral Weapon +% With 50 Dexterity In Radius")]
        LocalUniqueJewelSpectralThrowDamageForEachEnemyHitWithSpectralWeaponPosPctWith50DexterityInRadius = 3402,
        [Description("Local Unique Jewel Double Strike Chance To Trigger On Kill Effects An Additional Time % With 50 Dexterity In Radius")]
        LocalUniqueJewelDoubleStrikeChanceToTriggerOnKillEffectsAnAdditionalTimePctWith50DexterityInRadius = 3403,
        [Description("Local Unique Jewel Viper Strike Attack Damage Per Poison On Enemy +% With 50 Dexterity In Radius")]
        LocalUniqueJewelViperStrikeAttackDamagePerPoisonOnEnemyPosPctWith50DexterityInRadius = 3404,
        [Description("Local Unique Jewel Heavy Strike Chance To Deal Double Damage % With 50 Strength In Radius")]
        LocalUniqueJewelHeavyStrikeChanceToDealDoubleDamagePctWith50StrengthInRadius = 3405,
        [Description("Enchantment Boots Mana Costs When Hit +%")]
        EnchantmentBootsManaCostsWhenHitPosPct = 3406,
        [Description("Enchantment Boots Stun Avoid % On Kill")]
        EnchantmentBootsStunAvoidPctOnKill = 3407,
        [Description("Enchantment Boots Spell Dodge When Hit By Spells %")]
        EnchantmentBootsSpellDodgeWhenHitBySpellsPct = 3408,
        [Description("Enchantment Boots Attack And Cast Speed +% For 4 Seconds On Kill")]
        EnchantmentBootsAttackAndCastSpeedPosPctFor4SecondsOnKill = 3409,
        [Description("Enchantment Boots Added Cold Damage When Hit Minimum")]
        EnchantmentBootsAddedColdDamageWhenHitMinimum = 3410,
        [Description("Enchantment Boots Added Cold Damage When Hit Maximum")]
        EnchantmentBootsAddedColdDamageWhenHitMaximum = 3411,
        [Description("Enchantment Boots Minimum Added Lightning Damage When You Havent Killed For 4 Seconds")]
        EnchantmentBootsMinimumAddedLightningDamageWhenYouHaventKilledFor4Seconds = 3412,
        [Description("Enchantment Boots Maximum Added Lightning Damage When You Havent Killed For 4 Seconds")]
        EnchantmentBootsMaximumAddedLightningDamageWhenYouHaventKilledFor4Seconds = 3413,
        [Description("Enchantment Boots Life And Mana Leech On Kill Permyriad")]
        EnchantmentBootsLifeAndManaLeechOnKillPermyriad = 3414,
        [Description("Enchantment Critical Strike Chance +% If You Havent Crit For 4 Seconds")]
        EnchantmentCriticalStrikeChancePosPctIfYouHaventCritFor4Seconds = 3415,
        [Description("No Extra Bleed Damage While Moving")]
        NoExtraBleedDamageWhileMoving = 3416,
        [Description("Action Speed Cannot Be Reduced Below Base")]
        ActionSpeedCannotBeReducedBelowBase = 3417,
        [Description("Movement Speed Cannot Be Reduced Below Base")]
        MovementSpeedCannotBeReducedBelowBase = 3418,
        [Description("Damage +% While Fortified")]
        DamagePosPctWhileFortified = 3419,
        [Description("Life Regeneration Per Minute % While Fortified")]
        LifeRegenerationPerMinutePctWhileFortified = 3420,
        [Description("Damage +% Per Endurance Charge")]
        DamagePosPctPerEnduranceCharge = 3421,
        [Description("Warcry Duration +%")]
        WarcryDurationPosPct = 3422,
        [Description("Restore Life And Mana On Warcry %")]
        RestoreLifeAndManaOnWarcryPct = 3423,
        [Description("Attack Speed +% When Hit")]
        AttackSpeedPosPctWhenHit = 3424,
        [Description("Movement Velocity While Not Hit +%")]
        MovementVelocityWhileNotHitPosPct = 3425,
        [Description("Is Warcry")]
        IsWarcry = 3426,
        [Description("Map Player Corrupt Blood When Hit % Average Damage To Deal Per Minute Per Stack")]
        MapPlayerCorruptBloodWhenHitPctAverageDamageToDealPerMinutePerStack = 3427,
        [Description("Damage +% When Not On Low Life")]
        DamagePosPctWhenNotOnLowLife = 3428,
        [Description("Gain Life And Mana Leech On Kill Permyriad")]
        GainLifeAndManaLeechOnKillPermyriad = 3429,
        [Description("Number Of Active Minions")]
        NumberOfActiveMinions = 3430,
        [Description("Number Of Active Totems")]
        NumberOfActiveTotems = 3431,
        [Description("Damage +% While Totem Active")]
        DamagePosPctWhileTotemActive = 3432,
        [Description("Physical Damage % Added As Fire Damage On Kill")]
        PhysicalDamagePctAddedAsFireDamageOnKill = 3433,
        [Description("Totems Gain % Of Players Armour")]
        TotemsGainPctOfPlayersArmour = 3434,
        [Description("Attack And Cast Speed +% On Placing Totem")]
        AttackAndCastSpeedPosPctOnPlacingTotem = 3435,
        [Description("Damage +% To Rare And Unique Enemies")]
        DamagePosPctToRareAndUniqueEnemies = 3436,
        [Description("Life Leech On Overkill Damage %")]
        LifeLeechOnOverkillDamagePct = 3437,
        [Description("Attack Speed +% While Leeching")]
        AttackSpeedPosPctWhileLeeching = 3438,
        [Description("Life Leech Does Not Stop At Full Life")]
        LifeLeechDoesNotStopAtFullLife = 3439,
        [Description("Cannot Be Stunned While Leeching")]
        CannotBeStunnedWhileLeeching = 3440,
        [Description("Attacks Use Life In Place Of Mana")]
        AttacksUseLifeInPlaceOfMana = 3441,
        [Description("Chance To Taunt On Hit %")]
        ChanceToTauntOnHitPct = 3442,
        [Description("Bleeding Enemies Explode For % Life As Physical Damage")]
        BleedingEnemiesExplodeForPctLifeAsPhysicalDamage = 3443,
        [Description("Attack And Cast Speed When Hit +%")]
        AttackAndCastSpeedWhenHitPosPct = 3444,
        [Description("Physical Damage On Block +%")]
        PhysicalDamageOnBlockPosPct = 3445,
        [Description("Block Chance On Damage Taken %")]
        BlockChanceOnDamageTakenPct = 3446,
        [Description("Damage While No Damage Taken +%")]
        DamageWhileNoDamageTakenPosPct = 3447,
        [Description("Recover % Life On Gained Fortify")]
        RecoverPctLifeOnGainedFortify = 3448,
        [Description("Recover % Life On Lost Fortify")]
        RecoverPctLifeOnLostFortify = 3449,
        [Description("Attack Speed While Fortified +%")]
        AttackSpeedWhileFortifiedPosPct = 3450,
        [Description("Taunted Enemies Damage Taken +%")]
        TauntedEnemiesDamageTakenPosPct = 3451,
        [Description("Taunted Enemies Chance To Be Stunned +%")]
        TauntedEnemiesChanceToBeStunnedPosPct = 3452,
        [Description("Armour And Evasion On Low Life +%")]
        ArmourAndEvasionOnLowLifePosPct = 3453,
        [Description("Is Taunted")]
        IsTaunted = 3454,
        [Description("Summoned Monsters Set Monster Mortar Parent")]
        SummonedMonstersSetMonsterMortarParent = 3455,
        [Description("Storm Cloud Charged Damage +% Final")]
        StormCloudChargedDamagePosPctFinal = 3456,
        [Description("Chaos Damage Taken +%")]
        ChaosDamageTakenPosPct = 3457,
        [Description("Number Of Melee Skeletons To Summon As Mage Skeletons")]
        NumberOfMeleeSkeletonsToSummonAsMageSkeletons = 3458,
        [Description("Local Unique Jewel With 50 Int In Radius Summon X Melee Skeletons As Mage Skeletons")]
        LocalUniqueJewelWith50IntInRadiusSummonXMeleeSkeletonsAsMageSkeletons = 3459,
        [Description("Local Display Socketed Trap Skills Create Smoke Cloud")]
        LocalDisplaySocketedTrapSkillsCreateSmokeCloud = 3460,
        [Description("Glacial Hammer Item Rarity On Shattering Enemy +%")]
        GlacialHammerItemRarityOnShatteringEnemyPosPct = 3461,
        [Description("Spectral Throw Damage For Each Enemy Hit With Spectral Weapon +%")]
        SpectralThrowDamageForEachEnemyHitWithSpectralWeaponPosPct = 3462,
        [Description("Double Strike Chance To Trigger On Kill Effects An Additional Time %")]
        DoubleStrikeChanceToTriggerOnKillEffectsAnAdditionalTimePct = 3463,
        [Description("Viper Strike Attack Damage Per Poison On Enemy +%")]
        ViperStrikeAttackDamagePerPoisonOnEnemyPosPct = 3464,
        [Description("Heavy Strike Chance To Deal Double Damage %")]
        HeavyStrikeChanceToDealDoubleDamagePct = 3465,
        [Description("Local Unique Jewel Vigilant Strike Fortifies Nearby Allies For X Seconds With 50 Str In Radius")]
        LocalUniqueJewelVigilantStrikeFortifiesNearbyAlliesForXSecondsWith50StrInRadius = 3466,
        [Description("Local Unique Jewel Fireball Radius Up To +% At Longer Ranges With 50 Int In Radius")]
        LocalUniqueJewelFireballRadiusUpToPosPctAtLongerRangesWith50IntInRadius = 3467,
        [Description("Fireball Radius Up To +% At Longer Ranges")]
        FireballRadiusUpToPosPctAtLongerRanges = 3468,
        [Description("Local Unique Jewel Animate Weapon Can Animate Up To X Additional Ranged Weapons With 50 Dex In Radius")]
        LocalUniqueJewelAnimateWeaponCanAnimateUpToXAdditionalRangedWeaponsWith50DexInRadius = 3469,
        [Description("Animate Weapon Can Animate Up To X Additional Ranged Weapons")]
        AnimateWeaponCanAnimateUpToXAdditionalRangedWeapons = 3470,
        [Description("Local Unique Jewel Ground Slam Angle +% With 50 Str In Radius")]
        LocalUniqueJewelGroundSlamAnglePosPctWith50StrInRadius = 3471,
        [Description("Ground Slam Angle +%")]
        GroundSlamAnglePosPct = 3472,
        [Description("Local Unique Jewel Cold Snap Gain Power Charge On Kill % With 50 Int In Radius")]
        LocalUniqueJewelColdSnapGainPowerChargeOnKillPctWith50IntInRadius = 3473,
        [Description("Cold Snap Gain Power Charge On Kill %")]
        ColdSnapGainPowerChargeOnKillPct = 3474,
        [Description("Local Unique Jewel Rallying Cry Damage Taken Goes To Mana % With 50 Int In Radius")]
        LocalUniqueJewelRallyingCryDamageTakenGoesToManaPctWith50IntInRadius = 3475,
        [Description("Rallying Cry Damage Taken Goes To Mana %")]
        RallyingCryDamageTakenGoesToManaPct = 3476,
        [Description("Local Unique Jewel Barrage Final Volley Fires X Additional Projectiles Simultaneously With 50 Dex In Radius")]
        LocalUniqueJewelBarrageFinalVolleyFiresXAdditionalProjectilesSimultaneouslyWith50DexInRadius = 3477,
        [Description("Barrage Final Volley Fires X Additional Projectiles Simultaneously")]
        BarrageFinalVolleyFiresXAdditionalProjectilesSimultaneously = 3478,
        [Description("Never Block")]
        NeverBlock = 3479,
        [Description("Mana Cost -% Per Endurance Charge")]
        ManaCostNegPctPerEnduranceCharge = 3480,
        [Description("Gain Rampage While At Maximum Endurance Charges")]
        GainRampageWhileAtMaximumEnduranceCharges = 3481,
        [Description("Lose Endurance Charges On Rampage End")]
        LoseEnduranceChargesOnRampageEnd = 3482,
        [Description("Physical Attack Damage +% While Holding A Shield")]
        PhysicalAttackDamagePosPctWhileHoldingAShield = 3483,
        [Description("Cold Attack Damage +% While Holding A Shield")]
        ColdAttackDamagePosPctWhileHoldingAShield = 3484,
        [Description("Fire Attack Damage +% While Holding A Shield")]
        FireAttackDamagePosPctWhileHoldingAShield = 3485,
        [Description("Base Number Of Ranged Animated Weapons Allowed")]
        BaseNumberOfRangedAnimatedWeaponsAllowed = 3486,
        [Description("Virtual Number Of Ranged Animated Weapons Allowed")]
        VirtualNumberOfRangedAnimatedWeaponsAllowed = 3487,
        [Description("Virtual Player Gain Rampage Stacks")]
        VirtualPlayerGainRampageStacks = 3488,
        [Description("Minion Does Not Equip Quiver")]
        MinionDoesNotEquipQuiver = 3489,
        [Description("Number Of Grasping Ornaments")]
        NumberOfGraspingOrnaments = 3490,
        [Description("Grasping Ornament Placement Radius")]
        GraspingOrnamentPlacementRadius = 3491,
        [Description("Local No Block Chance")]
        LocalNoBlockChance = 3492,
        [Description("Support Controlled Destruction Spell Damage +% Final")]
        SupportControlledDestructionSpellDamagePosPctFinal = 3493,
        [Description("Support Void Manipulation Chaos Damage +% Final")]
        SupportVoidManipulationChaosDamagePosPctFinal = 3494,
        [Description("Support Rapid Decay Damage Over Time +% Final")]
        SupportRapidDecayDamageOverTimePosPctFinal = 3495,
        [Description("Cast On Any Damage Taken %")]
        CastOnAnyDamageTakenPct = 3496,
        [Description("Stun Threshold +%")]
        StunThresholdPosPct = 3497,
        [Description("Number Of Active Spectres")]
        NumberOfActiveSpectres = 3498,
        [Description("Number Of Active Skeletons")]
        NumberOfActiveSkeletons = 3499,
        [Description("Number Of Active Raging Spirits")]
        NumberOfActiveRagingSpirits = 3500,
        [Description("Number Of Active Zombies")]
        NumberOfActiveZombies = 3501,
        [Description("Minion Attack And Cast Speed +% Per Active Skeleton")]
        MinionAttackAndCastSpeedPosPctPerActiveSkeleton = 3502,
        [Description("Minion Duration +% Per Active Zombie")]
        MinionDurationPosPctPerActiveZombie = 3503,
        [Description("Minion Damage +% Per Active Spectre")]
        MinionDamagePosPctPerActiveSpectre = 3504,
        [Description("Minion Life Regeneration Per Minute Per Active Raging Spirit")]
        MinionLifeRegenerationPerMinutePerActiveRagingSpirit = 3505,
        [Description("Virtual Skill Effect Duration Pluspercent Final")]
        VirtualSkillEffectDurationPluspercentFinal = 3506,
        [Description("Virtual Additional Skill Effect Duration")]
        VirtualAdditionalSkillEffectDuration = 3507,
        [Description("Offering Of Judgement Counter")]
        OfferingOfJudgementCounter = 3508,
        [Description("Gain Her Blessing For 3 Seconds On Ignite %")]
        GainHerBlessingFor3SecondsOnIgnitePct = 3509,
        [Description("Blind Nearby Enemies When Gaining Her Blessing %")]
        BlindNearbyEnemiesWhenGainingHerBlessingPct = 3510,
        [Description("Have Her Blessing")]
        HaveHerBlessing = 3511,
        [Description("Avoid Freeze Chill Ignite % With Her Blessing")]
        AvoidFreezeChillIgnitePctWithHerBlessing = 3512,
        [Description("Attack And Movement Speed +% With Her Blessing")]
        AttackAndMovementSpeedPosPctWithHerBlessing = 3513,
        [Description("Warcry Speed +%")]
        WarcrySpeedPosPct = 3514,
        [Description("Gain Power Charge On Non Critical Strike %")]
        GainPowerChargeOnNonCriticalStrikePct = 3515,
        [Description("Critical Strike Multiplier + Per Power Charge")]
        CriticalStrikeMultiplierPosPerPowerCharge = 3516,
        [Description("Apply Poison On Hit Vs Bleeding Enemies %")]
        ApplyPoisonOnHitVsBleedingEnemiesPct = 3517,
        [Description("Avoid Blind %")]
        AvoidBlindPct = 3518,
        [Description("Damage Taken +% From Blinded Enemies")]
        DamageTakenPosPctFromBlindedEnemies = 3519,
        [Description("Attack Damage +% Per Frenzy Charge")]
        AttackDamagePosPctPerFrenzyCharge = 3520,
        [Description("Attack Damage +% While Onslaught Active")]
        AttackDamagePosPctWhileOnslaughtActive = 3521,
        [Description("Onslaught Effect +%")]
        OnslaughtEffectPosPct = 3522,
        [Description("Critical Strike Multiplier + Vs Bleeding Enemies")]
        CriticalStrikeMultiplierPosVsBleedingEnemies = 3523,
        [Description("Critical Strike Chance +% Vs Poisoned Enemies")]
        CriticalStrikeChancePosPctVsPoisonedEnemies = 3524,
        [Description("Elemental Damage Taken +%")]
        ElementalDamageTakenPosPct = 3525,
        [Description("Damage Taken From Traps And Mines +%")]
        DamageTakenFromTrapsAndMinesPosPct = 3526,
        [Description("Maim On Hit % Vs Poisoned Enemies")]
        MaimOnHitPctVsPoisonedEnemies = 3527,
        [Description("Raider Passive Evade Melee Attacks While Onslaughted +% Final")]
        RaiderPassiveEvadeMeleeAttacksWhileOnslaughtedPosPctFinal = 3528,
        [Description("Raider Passive Evade Projectile Attacks While Onslaughted +% Final")]
        RaiderPassiveEvadeProjectileAttacksWhileOnslaughtedPosPctFinal = 3529,
        [Description("Dispel Status Ailments On Flask Use")]
        DispelStatusAilmentsOnFlaskUse = 3530,
        [Description("Avoid Status Ailments % During Flask Effect")]
        AvoidStatusAilmentsPctDuringFlaskEffect = 3531,
        [Description("Attack Speed +% During Flask Effect")]
        AttackSpeedPosPctDuringFlaskEffect = 3532,
        [Description("Poison On Hit During Flask Effect %")]
        PoisonOnHitDuringFlaskEffectPct = 3533,
        [Description("Cyclone Places Ground Lightning")]
        CyclonePlacesGroundLightning = 3534,
        [Description("Cyclone Lightning Path Radius")]
        CycloneLightningPathRadius = 3535,
        [Description("Local Unique Flask Shock Nearby Enemies During Flask Effect")]
        LocalUniqueFlaskShockNearbyEnemiesDuringFlaskEffect = 3536,
        [Description("Local Unique Flask Shocked During Flask Effect")]
        LocalUniqueFlaskShockedDuringFlaskEffect = 3537,
        [Description("Local Unique Flask Leech Lightning Damage % As Life During Flask Effect")]
        LocalUniqueFlaskLeechLightningDamagePctAsLifeDuringFlaskEffect = 3538,
        [Description("Local Unique Flask Leech Lightning Damage % As Mana During Flask Effect")]
        LocalUniqueFlaskLeechLightningDamagePctAsManaDuringFlaskEffect = 3539,
        [Description("Local Unique Flask Leech Is Instant During Flask Effect")]
        LocalUniqueFlaskLeechIsInstantDuringFlaskEffect = 3540,
        [Description("Local Unique Flask Minimum Added Lightning Damage To Attacks During Flask Effect")]
        LocalUniqueFlaskMinimumAddedLightningDamageToAttacksDuringFlaskEffect = 3541,
        [Description("Local Unique Flask Maximum Added Lightning Damage To Attacks During Flask Effect")]
        LocalUniqueFlaskMaximumAddedLightningDamageToAttacksDuringFlaskEffect = 3542,
        [Description("Local Unique Flask Minimum Added Lightning Damage To Spells During Flask Effect")]
        LocalUniqueFlaskMinimumAddedLightningDamageToSpellsDuringFlaskEffect = 3543,
        [Description("Local Unique Flask Maximum Added Lightning Damage To Spells During Flask Effect")]
        LocalUniqueFlaskMaximumAddedLightningDamageToSpellsDuringFlaskEffect = 3544,
        [Description("Local Unique Flask Physical Damage % Converted To Lightning During Flask Effect")]
        LocalUniqueFlaskPhysicalDamagePctConvertedToLightningDuringFlaskEffect = 3545,
        [Description("Local Unique Flask Lightning Resistance Penetration % During Flask Effect")]
        LocalUniqueFlaskLightningResistancePenetrationPctDuringFlaskEffect = 3546,
        [Description("Leech Is Instant")]
        LeechIsInstant = 3547,
        [Description("Mana Leech Is Instant")]
        ManaLeechIsInstant = 3548,
        [Description("Projectiles Drop Ground Fire")]
        ProjectilesDropGroundFire = 3549,
        [Description("Projectiles Drop Ground Lightning")]
        ProjectilesDropGroundLightning = 3550,
        [Description("Projectiles Drop Ground Ice")]
        ProjectilesDropGroundIce = 3551,
        [Description("Projectiles Drop Ground Effects On Client")]
        ProjectilesDropGroundEffectsOnClient = 3552,
        [Description("Base Projectile Ground Effect Duration")]
        BaseProjectileGroundEffectDuration = 3553,
        [Description("Base Projectile Skill Dot Ground Fire Area Damage Per Minute")]
        BaseProjectileSkillDotGroundFireAreaDamagePerMinute = 3554,
        [Description("Projectile Ground Effect Duration")]
        ProjectileGroundEffectDuration = 3555,
        [Description("Projectile Skill Dot Ground Fire Area Damage Per Minute")]
        ProjectileSkillDotGroundFireAreaDamagePerMinute = 3556,
        [Description("Chaos Damage Can Chill")]
        ChaosDamageCanChill = 3557,
        [Description("Explode On Kill % Chaos Damage To Deal")]
        ExplodeOnKillPctChaosDamageToDeal = 3558,
        [Description("Enchantment Boots Damage Penetrates Elemental Resistance % While You Havent Killed For 4 Seconds")]
        EnchantmentBootsDamagePenetratesElementalResistancePctWhileYouHaventKilledFor4Seconds = 3559,
        [Description("Enchantment Boots Physical Damage % Added As Elements In Spells That Hit You In Past 4 Seconds")]
        EnchantmentBootsPhysicalDamagePctAddedAsElementsInSpellsThatHitYouInPast4Seconds = 3560,
        [Description("Enchantment Boots Minimum Added Chaos Damage For 4 Seconds When Crit 4s")]
        EnchantmentBootsMinimumAddedChaosDamageFor4SecondsWhenCrit4s = 3561,
        [Description("Enchantment Boots Maximum Added Chaos Damage For 4 Seconds When Crit 4s")]
        EnchantmentBootsMaximumAddedChaosDamageFor4SecondsWhenCrit4s = 3562,
        [Description("Life Leech Permyriad From Elemental Damage Against Enemies With Elemental Status Ailments")]
        LifeLeechPermyriadFromElementalDamageAgainstEnemiesWithElementalStatusAilments = 3563,
        [Description("Movement Speed +% While Not Affected By Status Ailments")]
        MovementSpeedPosPctWhileNotAffectedByStatusAilments = 3564,
        [Description("Stacking Spell Damage +% When You Or Your Totems Kill An Enemy For 2 Seconds")]
        StackingSpellDamagePosPctWhenYouOrYourTotemsKillAnEnemyFor2Seconds = 3565,
        [Description("Give Parent Stacking Spell Damage +% For 2 Seconds On Kill")]
        GiveParentStackingSpellDamagePosPctFor2SecondsOnKill = 3566,
        [Description("Totems Explode For % Of Max Life As Fire Damage On Low Life")]
        TotemsExplodeForPctOfMaxLifeAsFireDamageOnLowLife = 3567,
        [Description("Chance To Avoid Stun % Aura While Wielding A Staff")]
        ChanceToAvoidStunPctAuraWhileWieldingAStaff = 3568,
        [Description("Map Monsters Have Onslaught")]
        MapMonstersHaveOnslaught = 3569,
        [Description("Monster Is Invasion Boss")]
        MonsterIsInvasionBoss = 3570,
        [Description("Virtual Minion Attack Speed +%")]
        VirtualMinionAttackSpeedPosPct = 3571,
        [Description("Virtual Minion Cast Speed +%")]
        VirtualMinionCastSpeedPosPct = 3572,
        [Description("Virtual Minion Life Regeneration Per Minute")]
        VirtualMinionLifeRegenerationPerMinute = 3573,
        [Description("Dropbear Desecration Area Of Effect +%")]
        DropbearDesecrationAreaOfEffectPosPct = 3574,
        [Description("Physical Damage To Return To Melee Attacker")]
        PhysicalDamageToReturnToMeleeAttacker = 3575,
        [Description("Cold Damage To Return To Melee Attacker")]
        ColdDamageToReturnToMeleeAttacker = 3576,
        [Description("Fire Damage To Return To Melee Attacker")]
        FireDamageToReturnToMeleeAttacker = 3577,
        [Description("Lightning Damage To Return To Melee Attacker")]
        LightningDamageToReturnToMeleeAttacker = 3578,
        [Description("Chaos Damage To Return To Melee Attacker")]
        ChaosDamageToReturnToMeleeAttacker = 3579,
        [Description("Physical Damage To Return When Hit")]
        PhysicalDamageToReturnWhenHit = 3580,
        [Description("Cold Damage To Return When Hit")]
        ColdDamageToReturnWhenHit = 3581,
        [Description("Fire Damage To Return When Hit")]
        FireDamageToReturnWhenHit = 3582,
        [Description("Lightning Damage To Return When Hit")]
        LightningDamageToReturnWhenHit = 3583,
        [Description("Chaos Damage To Return When Hit")]
        ChaosDamageToReturnWhenHit = 3584,
        [Description("Trap Idle Duration")]
        TrapIdleDuration = 3585,
        [Description("Trap Retracts")]
        TrapRetracts = 3586,
        [Description("Physical Damage Taken +% While Frozen")]
        PhysicalDamageTakenPosPctWhileFrozen = 3587,
        [Description("Damage +% For 4 Seconds On Crit")]
        DamagePosPctFor4SecondsOnCrit = 3588,
        [Description("Damage And Minion Damage +% For 4 Seconds On Consume Corpse")]
        DamageAndMinionDamagePosPctFor4SecondsOnConsumeCorpse = 3589,
        [Description("Enemies Damage Taken +% While Cursed")]
        EnemiesDamageTakenPosPctWhileCursed = 3590,
        [Description("Spectre Damage +%")]
        SpectreDamagePosPct = 3591,
        [Description("Critical Strike Chance +% For 4 Seconds On Kill")]
        CriticalStrikeChancePosPctFor4SecondsOnKill = 3592,
        [Description("Ignite Effect +%")]
        IgniteEffectPosPct = 3593,
        [Description("Chill Effect +%")]
        ChillEffectPosPct = 3594,
        [Description("Shock Effect +%")]
        ShockEffectPosPct = 3595,
        [Description("Frozen Effect +%")]
        FrozenEffectPosPct = 3596,
        [Description("Critical Strikes Ignore Elemental Resistances")]
        CriticalStrikesIgnoreElementalResistances = 3597,
        [Description("Physical Damage Reduction And Minion Physical Damage Reduction % Per Raised Zombie")]
        PhysicalDamageReductionAndMinionPhysicalDamageReductionPctPerRaisedZombie = 3598,
        [Description("Damage Taken +% From Bleeding Enemies")]
        DamageTakenPosPctFromBleedingEnemies = 3599,
        [Description("Maim Bleeding Enemies On Hit %")]
        MaimBleedingEnemiesOnHitPct = 3600,
        [Description("One Handed Attack Speed +%")]
        OneHandedAttackSpeedPosPct = 3601,
        [Description("Movement Speed +% For 4 Seconds On Block")]
        MovementSpeedPosPctFor4SecondsOnBlock = 3602,
        [Description("Movement Speed +% While Fortified")]
        MovementSpeedPosPctWhileFortified = 3603,
        [Description("Elemental Damage Taken +% At Maximum Endurance Charges")]
        ElementalDamageTakenPosPctAtMaximumEnduranceCharges = 3604,
        [Description("Status Ailments Removed At Low Life")]
        StatusAilmentsRemovedAtLowLife = 3605,
        [Description("Gain Frenzy Charge On Main Hand Kill %")]
        GainFrenzyChargeOnMainHandKillPct = 3606,
        [Description("Gain Endurance Charge On Main Hand Kill %")]
        GainEnduranceChargeOnMainHandKillPct = 3607,
        [Description("Damage Taken +% For 4 Seconds On Kill")]
        DamageTakenPosPctFor4SecondsOnKill = 3608,
        [Description("Avoid Stun % For 4 Seconds On Kill")]
        AvoidStunPctFor4SecondsOnKill = 3609,
        [Description("Damage Taken +% For 4 Seconds On Killing Taunted Enemy")]
        DamageTakenPosPctFor4SecondsOnKillingTauntedEnemy = 3610,
        [Description("Warcry Cooldown Speed +%")]
        WarcryCooldownSpeedPosPct = 3611,
        [Description("Always Stun Enemies That Are On Full Life")]
        AlwaysStunEnemiesThatAreOnFullLife = 3612,
        [Description("Stun Duration +% Vs Enemies That Are On Full Life")]
        StunDurationPosPctVsEnemiesThatAreOnFullLife = 3613,
        [Description("Stun Duration +% Vs Enemies That Are On Low Life")]
        StunDurationPosPctVsEnemiesThatAreOnLowLife = 3614,
        [Description("Damage +% With One Handed Weapons")]
        DamagePosPctWithOneHandedWeapons = 3615,
        [Description("Damage +% With Two Handed Weapons")]
        DamagePosPctWithTwoHandedWeapons = 3616,
        [Description("Damage Reduction Rating From Body Armour Doubled")]
        DamageReductionRatingFromBodyArmourDoubled = 3617,
        [Description("Damage Reduction Rating % With Active Totem")]
        DamageReductionRatingPctWithActiveTotem = 3618,
        [Description("Virtual Physical Damage Taken +%")]
        VirtualPhysicalDamageTakenPosPct = 3619,
        [Description("Virtual Elemental Damage Taken +%")]
        VirtualElementalDamageTakenPosPct = 3620,
        [Description("Is Burning")]
        IsBurning = 3621,
        [Description("Ignite Effect On Self +%")]
        IgniteEffectOnSelfPosPct = 3622,
        [Description("Shocked Effect On Self +%")]
        ShockedEffectOnSelfPosPct = 3623,
        [Description("Ancestor Totem Parent Activiation Range")]
        AncestorTotemParentActiviationRange = 3624,
        [Description("Support Clustertrap Damage +% Final")]
        SupportClustertrapDamagePosPctFinal = 3625,
        [Description("Local Display Cast Level X Manifest Rageblade")]
        LocalDisplayCastLevelXManifestRageblade = 3626,
        [Description("Local Display Manifest Rageblade Disables Weapons")]
        LocalDisplayManifestRagebladeDisablesWeapons = 3627,
        [Description("Local Display Manifest Rageblade Destroy On End Rampage")]
        LocalDisplayManifestRagebladeDestroyOnEndRampage = 3628,
        [Description("Minions Grant Onslaught")]
        MinionsGrantOnslaught = 3629,
        [Description("Ground Fire Art Variation")]
        GroundFireArtVariation = 3630,
        [Description("Frost Blades Damage +%")]
        FrostBladesDamagePosPct = 3631,
        [Description("Frost Blades Projectile Speed +%")]
        FrostBladesProjectileSpeedPosPct = 3632,
        [Description("Frost Blades Number Of Additional Projectiles In Chain")]
        FrostBladesNumberOfAdditionalProjectilesInChain = 3633,
        [Description("Summoned Raging Spirit Duration +%")]
        SummonedRagingSpiritDurationPosPct = 3634,
        [Description("Summoned Raging Spirit Chance To Spawn Additional Minion %")]
        SummonedRagingSpiritChanceToSpawnAdditionalMinionPct = 3635,
        [Description("Discharge Damage +%")]
        DischargeDamagePosPct = 3636,
        [Description("Discharge Radius +%")]
        DischargeRadiusPosPct = 3637,
        [Description("Discharge Chance Not To Consume Charges %")]
        DischargeChanceNotToConsumeChargesPct = 3638,
        [Description("Anger Mana Reservation +%")]
        AngerManaReservationPosPct = 3639,
        [Description("Anger Aura Effect +%")]
        AngerAuraEffectPosPct = 3640,
        [Description("Lightning Trap Damage +%")]
        LightningTrapDamagePosPct = 3641,
        [Description("Lightning Trap Number Of Additional Projectiles")]
        LightningTrapNumberOfAdditionalProjectiles = 3642,
        [Description("Lightning Trap Cooldown Speed +%")]
        LightningTrapCooldownSpeedPosPct = 3643,
        [Description("Virtual Number Of Additional Projectiles In Chain")]
        VirtualNumberOfAdditionalProjectilesInChain = 3644,
        [Description("Ambush Passive Critical Strike Chance Vs Enemies On Full Life +% Final")]
        AmbushPassiveCriticalStrikeChanceVsEnemiesOnFullLifePosPctFinal = 3645,
        [Description("Critical Strike Multiplier Vs Enemies On Full Life +")]
        CriticalStrikeMultiplierVsEnemiesOnFullLifePos = 3646,
        [Description("Assassinate Passive Critical Strike Chance Vs Enemies On Low Life +% Final")]
        AssassinatePassiveCriticalStrikeChanceVsEnemiesOnLowLifePosPctFinal = 3647,
        [Description("Ambush Passive Critical Strike Chance +% Final")]
        AmbushPassiveCriticalStrikeChancePosPctFinal = 3648,
        [Description("Assassinate Passive Critical Strike Chance +% Final")]
        AssassinatePassiveCriticalStrikeChancePosPctFinal = 3649,
        [Description("Immune To Lava Damage")]
        ImmuneToLavaDamage = 3650,
        [Description("Number Of Additional Storm Clouds Allowed")]
        NumberOfAdditionalStormCloudsAllowed = 3651,
        [Description("Local Flask Consumes X Frenzy Charges On Use")]
        LocalFlaskConsumesXFrenzyChargesOnUse = 3652,
        [Description("Local Flask Consumes X Endurance Charges On Use")]
        LocalFlaskConsumesXEnduranceChargesOnUse = 3653,
        [Description("Local Flask Consumes X Power Charges On Use")]
        LocalFlaskConsumesXPowerChargesOnUse = 3654,
        [Description("Map Shrines Are Darkshrines")]
        MapShrinesAreDarkshrines = 3655,
        [Description("Physical Damage +% While Frozen")]
        PhysicalDamagePosPctWhileFrozen = 3656,
        [Description("Local Recharge On Crit %")]
        LocalRechargeOnCritPct = 3657,
        [Description("Mana And Es Regeneration Per Minute % When You Freeze Shock Or Ignite An Enemy")]
        ManaAndEsRegenerationPerMinutePctWhenYouFreezeShockOrIgniteAnEnemy = 3658,
        [Description("Damage Taken +% To An Element For 4 Seconds When Hit By Damage From An Element")]
        DamageTakenPosPctToAnElementFor4SecondsWhenHitByDamageFromAnElement = 3659,
        [Description("Cold Damage Taken +%")]
        ColdDamageTakenPosPct = 3660,
        [Description("Lightning Damage Taken +%")]
        LightningDamageTakenPosPct = 3661,
        [Description("Burning Arrow Spread Burning Ground When Igniting Enemy On Hit %")]
        BurningArrowSpreadBurningGroundWhenIgnitingEnemyOnHitPct = 3662,
        [Description("Burning Arrow Spread Tar Ground When Not Igniting Enemy On Hit %")]
        BurningArrowSpreadTarGroundWhenNotIgnitingEnemyOnHitPct = 3663,
        [Description("Local Unique Jewel Burning Arrow Spread Burning Ground When Igniting Enemy On Hit % With 50 Dexterity In Radius")]
        LocalUniqueJewelBurningArrowSpreadBurningGroundWhenIgnitingEnemyOnHitPctWith50DexterityInRadius = 3664,
        [Description("Local Unique Jewel Burning Arrow Spread Tar Ground When Not Igniting Enemy On Hit % With 50 Dexterity In Radius")]
        LocalUniqueJewelBurningArrowSpreadTarGroundWhenNotIgnitingEnemyOnHitPctWith50DexterityInRadius = 3665,
        [Description("Bleed On Hit With Attacks %")]
        BleedOnHitWithAttacksPct = 3666,
        [Description("Gain Flask Chance On Crit %")]
        GainFlaskChanceOnCritPct = 3667,
        [Description("Player Far Shot")]
        PlayerFarShot = 3668,
        [Description("Fire Elemental Meteor Landing Range")]
        FireElementalMeteorLandingRange = 3669,
        [Description("Virtual Aura Effect Pluspercent")]
        VirtualAuraEffectPluspercent = 3670,
        [Description("Cannot Be Poisoned")]
        CannotBePoisoned = 3671,
        [Description("Avoid Fire Damage %")]
        AvoidFireDamagePct = 3672,
        [Description("Avoid Cold Damage %")]
        AvoidColdDamagePct = 3673,
        [Description("Avoid Lightning Damage %")]
        AvoidLightningDamagePct = 3674,
        [Description("Avoid Chaos Damage %")]
        AvoidChaosDamagePct = 3675,
        [Description("Avoid Physical Damage %")]
        AvoidPhysicalDamagePct = 3676,
        [Description("Remove Bleed On Flask Use")]
        RemoveBleedOnFlaskUse = 3677,
        [Description("Slayer Ascendancy Melee Splash Damage +% Final")]
        SlayerAscendancyMeleeSplashDamagePosPctFinal = 3678,
        [Description("Slayer Ascendancy Melee Splash Damage +% Final For Splash")]
        SlayerAscendancyMeleeSplashDamagePosPctFinalForSplash = 3679,
        [Description("Guardian Reserved Mana % Given To You And Nearby Allies As Base Maximum Energy Shield")]
        GuardianReservedManaPctGivenToYouAndNearbyAlliesAsBaseMaximumEnergyShield = 3680,
        [Description("Virtual Base Maximum Energy Shield To Grant To You And Nearby Allies")]
        VirtualBaseMaximumEnergyShieldToGrantToYouAndNearbyAllies = 3681,
        [Description("Virtual Armour To Grant To You And Nearby Allies")]
        VirtualArmourToGrantToYouAndNearbyAllies = 3682,
        [Description("Number Of Additional Siege Ballistae Per 200 Dexterity")]
        NumberOfAdditionalSiegeBallistaePer200Dexterity = 3683,
        [Description("Attack Minimum Added Physical Damage Per 25 Dexterity")]
        AttackMinimumAddedPhysicalDamagePer25Dexterity = 3684,
        [Description("Attack Maximum Added Physical Damage Per 25 Dexterity")]
        AttackMaximumAddedPhysicalDamagePer25Dexterity = 3685,
        [Description("Local Display Nearby Enemies Are Blinded")]
        LocalDisplayNearbyEnemiesAreBlinded = 3686,
        [Description("Local Display Nearby Enemies Movement Speed +%")]
        LocalDisplayNearbyEnemiesMovementSpeedPosPct = 3687,
        [Description("Local Display Socketed Gems Supported By X Hypothermia")]
        LocalDisplaySocketedGemsSupportedByXHypothermia = 3688,
        [Description("Local Display Socketed Gems Supported By X Ice Bite")]
        LocalDisplaySocketedGemsSupportedByXIceBite = 3689,
        [Description("Local Display Socketed Gems Supported By X Cold Penetration")]
        LocalDisplaySocketedGemsSupportedByXColdPenetration = 3690,
        [Description("Local Display Socketed Gems Supported By X Mana Leech")]
        LocalDisplaySocketedGemsSupportedByXManaLeech = 3691,
        [Description("Local Display Socketed Gems Supported By X Added Cold Damage")]
        LocalDisplaySocketedGemsSupportedByXAddedColdDamage = 3692,
        [Description("Local Display Socketed Gems Supported By X Reduced Mana Cost")]
        LocalDisplaySocketedGemsSupportedByXReducedManaCost = 3693,
        [Description("Projectile Nova Extend Projectiles Forward By X Units")]
        ProjectileNovaExtendProjectilesForwardByXUnits = 3694,
        [Description("Storm Cloud Destroy When Caster Dies")]
        StormCloudDestroyWhenCasterDies = 3695,
        [Description("Chance To Gain Onslaught On Kill For 4 Seconds %")]
        ChanceToGainOnslaughtOnKillFor4SecondsPct = 3696,
        [Description("Chance To Cast On Rampage Tier %")]
        ChanceToCastOnRampageTierPct = 3697,
        [Description("Local Display Minions Grant Onslaught")]
        LocalDisplayMinionsGrantOnslaught = 3698,
        [Description("% Of Life And Energy Shield To Deal As Damage")]
        PctOfLifeAndEnergyShieldToDealAsDamage = 3699,
        [Description("Critical Strike Chance +% Vs Blinded Enemies")]
        CriticalStrikeChancePosPctVsBlindedEnemies = 3700,
        [Description("Is In Singularity")]
        IsInSingularity = 3701,
        [Description("Chilled Ground On Freeze % Chance For 3 Seconds")]
        ChilledGroundOnFreezePctChanceFor3Seconds = 3702,
        [Description("Consecrate Ground On Kill % For 3 Seconds")]
        ConsecrateGroundOnKillPctFor3Seconds = 3703,
        [Description("In Symbol")]
        InSymbol = 3704,
        [Description("Damage Taken +% From Enemies In Symbols")]
        DamageTakenPosPctFromEnemiesInSymbols = 3705,
        [Description("Local Display Socketed Aura Gems Reserve No Mana")]
        LocalDisplaySocketedAuraGemsReserveNoMana = 3706,
        [Description("No Mana Reserved")]
        NoManaReserved = 3707,
        [Description("Piercing Attacks Cause Bleeding")]
        PiercingAttacksCauseBleeding = 3708,
        [Description("Spell Damage Modifiers Apply To Skill Dot")]
        SpellDamageModifiersApplyToSkillDot = 3709,
        [Description("Shadow Blades Projectile Spread")]
        ShadowBladesProjectileSpread = 3710,
        [Description("Map Disable Bloodlines")]
        MapDisableBloodlines = 3711,
        [Description("Map Disable Nemesis")]
        MapDisableNemesis = 3712,
        [Description("Is Poisoned")]
        IsPoisoned = 3713,
        [Description("Is Vinktar Lightning Bond Source")]
        IsVinktarLightningBondSource = 3714,
        [Description("Is Vinktar Lightning Bond Target")]
        IsVinktarLightningBondTarget = 3715,
        [Description("Energy Shield Recharges On Block %")]
        EnergyShieldRechargesOnBlockPct = 3716,
        [Description("Dropped Weapons Have 20 Quality")]
        DroppedWeaponsHave20Quality = 3717,
        [Description("Drop Additional 20 Quality Gems")]
        DropAdditional20QualityGems = 3718,
        [Description("Killed Rare Monsters Drop Additional Unique Items")]
        KilledRareMonstersDropAdditionalUniqueItems = 3719,
        [Description("Poison Duration Is Skill Duration")]
        PoisonDurationIsSkillDuration = 3720,
        [Description("Map Players Gain Rare Monster Mods On Kill Ms")]
        MapPlayersGainRareMonsterModsOnKillMs = 3721,
        [Description("Soul Eater On Rare Kill Ms")]
        SoulEaterOnRareKillMs = 3722,
        [Description("Map Players Gain Soul Eater On Rare Kill Ms")]
        MapPlayersGainSoulEaterOnRareKillMs = 3723,
        [Description("Gain Soul Eater During Flask Effect")]
        GainSoulEaterDuringFlaskEffect = 3724,
        [Description("Lose Soul Eater Souls On Flask Use")]
        LoseSoulEaterSoulsOnFlaskUse = 3725,
        [Description("Totemified Skills Taunt On Hit %")]
        TotemifiedSkillsTauntOnHitPct = 3726,
        [Description("Virtual Chance To Taunt On Hit %")]
        VirtualChanceToTauntOnHitPct = 3727,
        [Description("Offerings Also Buff You")]
        OfferingsAlsoBuffYou = 3728,
        [Description("Caustic Cloud On Death Maximum Life Per Minute To Deal As Chaos Damage %")]
        CausticCloudOnDeathMaximumLifePerMinuteToDealAsChaosDamagePct = 3729,
        [Description("Minion Caustic Cloud On Death Maximum Life Per Minute To Deal As Chaos Damage %")]
        MinionCausticCloudOnDeathMaximumLifePerMinuteToDealAsChaosDamagePct = 3730,
        [Description("Storm Cloud Charge Count")]
        StormCloudChargeCount = 3731,
        [Description("Monster Is Duplicated")]
        MonsterIsDuplicated = 3732,
        [Description("Gain Life Leech From Any Damage Permyriad As Life For 4 Seconds If Taken Savage Hit")]
        GainLifeLeechFromAnyDamagePermyriadAsLifeFor4SecondsIfTakenSavageHit = 3733,
        [Description("Gain Damage +% For 4 Seconds If Taken Savage Hit")]
        GainDamagePosPctFor4SecondsIfTakenSavageHit = 3734,
        [Description("Gain Attack Speed +% For 4 Seconds If Taken Savage Hit")]
        GainAttackSpeedPosPctFor4SecondsIfTakenSavageHit = 3735,
        [Description("Damage +% Vs Burning Enemies")]
        DamagePosPctVsBurningEnemies = 3736,
        [Description("Endurance Charge On Off Hand Kill %")]
        EnduranceChargeOnOffHandKillPct = 3737,
        [Description("Aura Melee Physical Damage +% Per 10 Strength")]
        AuraMeleePhysicalDamagePosPctPer10Strength = 3738,
        [Description("Attack On Death %")]
        AttackOnDeathPct = 3739,
        [Description("Siphon Life Leech From Damage Permyriad")]
        SiphonLifeLeechFromDamagePermyriad = 3740,
        [Description("Total Base Maximum Mana")]
        TotalBaseMaximumMana = 3741,
        [Description("Combined Mana +%")]
        CombinedManaPosPct = 3742,
        [Description("Combined Mana +% Final")]
        CombinedManaPosPctFinal = 3743,
        [Description("You And Your Totems Gain An Endurance Charge On Burning Enemy Kill %")]
        YouAndYourTotemsGainAnEnduranceChargeOnBurningEnemyKillPct = 3744,
        [Description("Minions Grant Owner And Owners Totems Gains Endurance Charge On Burning Enemy Kill %")]
        MinionsGrantOwnerAndOwnersTotemsGainsEnduranceChargeOnBurningEnemyKillPct = 3745,
        [Description("Grant Owner And Owners Totems An Endurance Charge On Burning Enemy Kill %")]
        GrantOwnerAndOwnersTotemsAnEnduranceChargeOnBurningEnemyKillPct = 3746,
        [Description("Auras Grant Additional Physical Damage Reduction % To You And Your Allies")]
        AurasGrantAdditionalPhysicalDamageReductionPctToYouAndYourAllies = 3747,
        [Description("Auras Grant Damage +% To You And Your Allies")]
        AurasGrantDamagePosPctToYouAndYourAllies = 3748,
        [Description("Auras Grant Attack And Cast Speed +% To You And Your Allies")]
        AurasGrantAttackAndCastSpeedPosPctToYouAndYourAllies = 3749,
        [Description("Placing Traps Cooldown Recovery +%")]
        PlacingTrapsCooldownRecoveryPosPct = 3750,
        [Description("Damage +% Vs Enemies Affected By Status Ailments")]
        DamagePosPctVsEnemiesAffectedByStatusAilments = 3751,
        [Description("Warcries Are Instant")]
        WarcriesAreInstant = 3752,
        [Description("Aura Grant Shield Defences To Nearby Allies")]
        AuraGrantShieldDefencesToNearbyAllies = 3753,
        [Description("Minion Additional Physical Damage Reduction %")]
        MinionAdditionalPhysicalDamageReductionPct = 3754,
        [Description("Phasing For 4 Seconds On Kill %")]
        PhasingFor4SecondsOnKillPct = 3755,
        [Description("Skill Area Of Effect +% Per Active Mine")]
        SkillAreaOfEffectPosPctPerActiveMine = 3756,
        [Description("Damage +% Per Active Trap")]
        DamagePosPctPerActiveTrap = 3757,
        [Description("Immune To Status Ailments While Phased")]
        ImmuneToStatusAilmentsWhilePhased = 3758,
        [Description("Chance To Dodge Spells % While Phased")]
        ChanceToDodgeSpellsPctWhilePhased = 3759,
        [Description("Additional Critical Strike Chance Per Power Charge Permyriad")]
        AdditionalCriticalStrikeChancePerPowerChargePermyriad = 3760,
        [Description("Movement Skills Cost No Mana")]
        MovementSkillsCostNoMana = 3761,
        [Description("Attack And Cast Speed +% For 4 Seconds On Movement Skill Use")]
        AttackAndCastSpeedPosPctFor4SecondsOnMovementSkillUse = 3762,
        [Description("Recover 10% Of Maximum Mana On Skill Use %")]
        Recover10PctOfMaximumManaOnSkillUsePct = 3763,
        [Description("Mine Laying Speed +% For 4 Seconds On Detonation")]
        MineLayingSpeedPosPctFor4SecondsOnDetonation = 3764,
        [Description("Damage +% For 4 Seconds On Detonation")]
        DamagePosPctFor4SecondsOnDetonation = 3765,
        [Description("Flask Charges Recovered Per 3 Seconds")]
        FlaskChargesRecoveredPer3Seconds = 3766,
        [Description("Trap Skill Area Of Effect +%")]
        TrapSkillAreaOfEffectPosPct = 3767,
        [Description("Number Of Active Mines")]
        NumberOfActiveMines = 3768,
        [Description("Number Of Active Traps")]
        NumberOfActiveTraps = 3769,
        [Description("Is Spike Trap")]
        IsSpikeTrap = 3770,
        [Description("Is Arrow Trap")]
        IsArrowTrap = 3771,
        [Description("Damage Taken +% From Spike Traps Final")]
        DamageTakenPosPctFromSpikeTrapsFinal = 3772,
        [Description("Damage Taken +% From Arrow Traps Final")]
        DamageTakenPosPctFromArrowTrapsFinal = 3773,
        [Description("Minion Damage Taken +% From Spike Traps Final")]
        MinionDamageTakenPosPctFromSpikeTrapsFinal = 3774,
        [Description("Minion Damage Taken +% From Arrow Traps Final")]
        MinionDamageTakenPosPctFromArrowTrapsFinal = 3775,
        [Description("Labyrinth Trap Degen Effect On Self +%")]
        LabyrinthTrapDegenEffectOnSelfPosPct = 3776,
        [Description("Minions Have Labyrinth Trap Degen Effect +%")]
        MinionsHaveLabyrinthTrapDegenEffectPosPct = 3777,
        [Description("Immune To Labyrinth Degen Effect")]
        ImmuneToLabyrinthDegenEffect = 3778,
        [Description("Minions Are Immune To Labyrinth Degen Effect")]
        MinionsAreImmuneToLabyrinthDegenEffect = 3779,
        [Description("Nearby Traps Within X Units Also Trigger On Triggering Trap")]
        NearbyTrapsWithinXUnitsAlsoTriggerOnTriggeringTrap = 3780,
        [Description("Number Of Additional Mines To Place")]
        NumberOfAdditionalMinesToPlace = 3781,
        [Description("Chance To Place An Additional Mine %")]
        ChanceToPlaceAnAdditionalMinePct = 3782,
        [Description("Immune To Shunt Geal")]
        ImmuneToShuntGeal = 3783,
        [Description("Chance For Elemental Damage To Be Added As Additional Chaos Damage %")]
        ChanceForElementalDamageToBeAddedAsAdditionalChaosDamagePct = 3784,
        [Description("Critical Strike Chance +% Vs Enemies Without Elemental Status Ailments")]
        CriticalStrikeChancePosPctVsEnemiesWithoutElementalStatusAilments = 3785,
        [Description("Spell Damage +% For 4 Seconds On Cast")]
        SpellDamagePosPctFor4SecondsOnCast = 3786,
        [Description("Attack Damage +% For 4 Seconds On Cast")]
        AttackDamagePosPctFor4SecondsOnCast = 3787,
        [Description("Attack Speed +% For 4 Seconds On Attack")]
        AttackSpeedPosPctFor4SecondsOnAttack = 3788,
        [Description("Cast Speed +% For 4 Seconds On Attack")]
        CastSpeedPosPctFor4SecondsOnAttack = 3789,
        [Description("Attack And Cast Speed +% For 4 Seconds On Begin Es Recharge")]
        AttackAndCastSpeedPosPctFor4SecondsOnBeginEsRecharge = 3790,
        [Description("Display Attack With Commandment Of Force On Hit %")]
        DisplayAttackWithCommandmentOfForceOnHitPct = 3791,
        [Description("Display Attack With Commandment Of Fury On Hit %")]
        DisplayAttackWithCommandmentOfFuryOnHitPct = 3792,
        [Description("Display Attack With Commandment Of Light When Critically Hit %")]
        DisplayAttackWithCommandmentOfLightWhenCriticallyHitPct = 3793,
        [Description("Display Attack With Commandment Of Spite When Hit %")]
        DisplayAttackWithCommandmentOfSpiteWhenHitPct = 3794,
        [Description("Display Attack With Decree Of Force On Hit %")]
        DisplayAttackWithDecreeOfForceOnHitPct = 3795,
        [Description("Display Attack With Decree Of Fury On Hit %")]
        DisplayAttackWithDecreeOfFuryOnHitPct = 3796,
        [Description("Display Attack With Decree Of Light When Critically Hit %")]
        DisplayAttackWithDecreeOfLightWhenCriticallyHitPct = 3797,
        [Description("Display Attack With Decree Of Spite When Hit %")]
        DisplayAttackWithDecreeOfSpiteWhenHitPct = 3798,
        [Description("Display Attack With Edict Of Force On Hit %")]
        DisplayAttackWithEdictOfForceOnHitPct = 3799,
        [Description("Display Attack With Edict Of Fury On Hit %")]
        DisplayAttackWithEdictOfFuryOnHitPct = 3800,
        [Description("Display Attack With Edict Of Ire When Hit %")]
        DisplayAttackWithEdictOfIreWhenHitPct = 3801,
        [Description("Display Attack With Edict Of Light When Critically Hit %")]
        DisplayAttackWithEdictOfLightWhenCriticallyHitPct = 3802,
        [Description("Display Attack With Edict Of Spite When Hit %")]
        DisplayAttackWithEdictOfSpiteWhenHitPct = 3803,
        [Description("Display Attack With Word Of Force On Hit %")]
        DisplayAttackWithWordOfForceOnHitPct = 3804,
        [Description("Display Attack With Word Of Fury On Hit %")]
        DisplayAttackWithWordOfFuryOnHitPct = 3805,
        [Description("Display Attack With Word Of Light When Critically Hit %")]
        DisplayAttackWithWordOfLightWhenCriticallyHitPct = 3806,
        [Description("Display Attack With Word Of Ire When Hit %")]
        DisplayAttackWithWordOfIreWhenHitPct = 3807,
        [Description("Display Attack With Word Of Spite When Hit %")]
        DisplayAttackWithWordOfSpiteWhenHitPct = 3808,
        [Description("Display Cast Commandment Of Blades On Hit % ")]
        DisplayCastCommandmentOfBladesOnHitPct = 3809,
        [Description("Display Cast Commandment Of Inferno On Kill %")]
        DisplayCastCommandmentOfInfernoOnKillPct = 3810,
        [Description("Display Cast Commandment Of Reflection When Hit %")]
        DisplayCastCommandmentOfReflectionWhenHitPct = 3811,
        [Description("Display Cast Commandment Of Tempest On Hit %")]
        DisplayCastCommandmentOfTempestOnHitPct = 3812,
        [Description("Display Cast Commandment Of The Grave On Kill %")]
        DisplayCastCommandmentOfTheGraveOnKillPct = 3813,
        [Description("Display Cast Commandment Of War On Kill %")]
        DisplayCastCommandmentOfWarOnKillPct = 3814,
        [Description("Display Cast Commandment Of Winter When Hit %")]
        DisplayCastCommandmentOfWinterWhenHitPct = 3815,
        [Description("Display Cast Decree Of Blades On Hit %  ")]
        DisplayCastDecreeOfBladesOnHitPct = 3816,
        [Description("Display Cast Decree Of Inferno On Kill %")]
        DisplayCastDecreeOfInfernoOnKillPct = 3817,
        [Description("Display Cast Decree Of Reflection When Hit %")]
        DisplayCastDecreeOfReflectionWhenHitPct = 3818,
        [Description("Display Cast Decree Of Tempest On Hit %")]
        DisplayCastDecreeOfTempestOnHitPct = 3819,
        [Description("Display Cast Decree Of The Grave On Kill %")]
        DisplayCastDecreeOfTheGraveOnKillPct = 3820,
        [Description("Display Cast Decree Of War On Kill %")]
        DisplayCastDecreeOfWarOnKillPct = 3821,
        [Description("Display Cast Decree Of Winter When Hit %")]
        DisplayCastDecreeOfWinterWhenHitPct = 3822,
        [Description("Display Cast Edict Of Blades On Hit % ")]
        DisplayCastEdictOfBladesOnHitPct = 3823,
        [Description("Display Cast Edict Of Inferno On Kill %")]
        DisplayCastEdictOfInfernoOnKillPct = 3824,
        [Description("Display Cast Edict Of Reflection When Hit %")]
        DisplayCastEdictOfReflectionWhenHitPct = 3825,
        [Description("Display Cast Edict Of Tempest On Hit %")]
        DisplayCastEdictOfTempestOnHitPct = 3826,
        [Description("Display Cast Edict Of The Grave On Kill %")]
        DisplayCastEdictOfTheGraveOnKillPct = 3827,
        [Description("Display Cast Edict Of War On Kill %")]
        DisplayCastEdictOfWarOnKillPct = 3828,
        [Description("Display Cast Edict Of Winter When Hit %")]
        DisplayCastEdictOfWinterWhenHitPct = 3829,
        [Description("Display Cast Word Of Blades On Hit %")]
        DisplayCastWordOfBladesOnHitPct = 3830,
        [Description("Display Cast Word Of Inferno On Kill %")]
        DisplayCastWordOfInfernoOnKillPct = 3831,
        [Description("Display Cast Word Of Reflection When Hit %")]
        DisplayCastWordOfReflectionWhenHitPct = 3832,
        [Description("Display Cast Word Of Tempest On Hit %")]
        DisplayCastWordOfTempestOnHitPct = 3833,
        [Description("Display Cast Word Of Winter When Hit %")]
        DisplayCastWordOfWinterWhenHitPct = 3834,
        [Description("Life Es And Mana Recovery +% For 4 Seconds On Killing Enemies Affected By Your Degen")]
        LifeEsAndManaRecoveryPosPctFor4SecondsOnKillingEnemiesAffectedByYourDegen = 3835,
        [Description("Trickster Passive Chance To Evade Attacks While Not On Full Energy Shield +% Final")]
        TricksterPassiveChanceToEvadeAttacksWhileNotOnFullEnergyShieldPosPctFinal = 3836,
        [Description("Display Cast Word Of Flames On Hit %")]
        DisplayCastWordOfFlamesOnHitPct = 3837,
        [Description("Display Cast Edict Of Flames On Hit %")]
        DisplayCastEdictOfFlamesOnHitPct = 3838,
        [Description("Display Cast Decree Of Flames On Hit %")]
        DisplayCastDecreeOfFlamesOnHitPct = 3839,
        [Description("Display Cast Commandment Of Flames On Hit %")]
        DisplayCastCommandmentOfFlamesOnHitPct = 3840,
        [Description("Display Cast Word Of Frost On Kill %")]
        DisplayCastWordOfFrostOnKillPct = 3841,
        [Description("Display Cast Edict Of Frost On Kill %")]
        DisplayCastEdictOfFrostOnKillPct = 3842,
        [Description("Display Cast Decree Of Frost On Kill %")]
        DisplayCastDecreeOfFrostOnKillPct = 3843,
        [Description("Display Cast Commandment Of Frost On Kill %")]
        DisplayCastCommandmentOfFrostOnKillPct = 3844,
        [Description("Display Cast Word Of Thunder On Kill %")]
        DisplayCastWordOfThunderOnKillPct = 3845,
        [Description("Display Cast Edict Of Thunder On Kill %")]
        DisplayCastEdictOfThunderOnKillPct = 3846,
        [Description("Display Cast Decree Of Thunder On Kill %")]
        DisplayCastDecreeOfThunderOnKillPct = 3847,
        [Description("Display Cast Commandment Of Thunder On Kill %")]
        DisplayCastCommandmentOfThunderOnKillPct = 3848,
        [Description("Display Cast Fire Burst On Kill")]
        DisplayCastFireBurstOnKill = 3849,
        [Description("Local Stat Monsters Pick Up Item")]
        LocalStatMonstersPickUpItem = 3850,
        [Description("Stone Golem Grants Base Life Regeneration Rate Per Minute")]
        StoneGolemGrantsBaseLifeRegenerationRatePerMinute = 3851,
        [Description("Bladefall Damage Per Stage +% Final")]
        BladefallDamagePerStagePosPctFinal = 3852,
        [Description("Global Maim On Hit")]
        GlobalMaimOnHit = 3853,
        [Description("Consecrate Ground For 3 Seconds When Hit %")]
        ConsecrateGroundFor3SecondsWhenHitPct = 3854,
        [Description("Damage +% On Consecrated Ground")]
        DamagePosPctOnConsecratedGround = 3855,
        [Description("Mana Cost +% On Consecrated Ground")]
        ManaCostPosPctOnConsecratedGround = 3856,
        [Description("Avoid Ailments % On Consecrated Ground")]
        AvoidAilmentsPctOnConsecratedGround = 3857,
        [Description("On Consecrated Ground")]
        OnConsecratedGround = 3858,
        [Description("Inquisitor Aura Elemental Damage +% Final")]
        InquisitorAuraElementalDamagePosPctFinal = 3859,
        [Description("Critical Strike Multiplier + Vs Enemies Affected By Elemental Status Ailment")]
        CriticalStrikeMultiplierPosVsEnemiesAffectedByElementalStatusAilment = 3860,
        [Description("Non Critical Strikes Penetrate Elemental Resistances %")]
        NonCriticalStrikesPenetrateElementalResistancesPct = 3861,
        [Description("Virtual Penetrate Elemental Resistances %")]
        VirtualPenetrateElementalResistancesPct = 3862,
        [Description("Base Penetrate Elemental Resistances %")]
        BasePenetrateElementalResistancesPct = 3863,
        [Description("Virtual Minion Additional Physical Damage Reduction Percent")]
        VirtualMinionAdditionalPhysicalDamageReductionPercent = 3864,
        [Description("Chance To Poison On Hit With Attacks %")]
        ChanceToPoisonOnHitWithAttacksPct = 3865,
        [Description("Chance To Double Stun Duration %")]
        ChanceToDoubleStunDurationPct = 3866,
        [Description("Is Guillotine Trap")]
        IsGuillotineTrap = 3867,
        [Description("Damage Taken +% From Guillotine Traps Final")]
        DamageTakenPosPctFromGuillotineTrapsFinal = 3868,
        [Description("Minion Damage Taken +% From Guillotine Traps Final")]
        MinionDamageTakenPosPctFromGuillotineTrapsFinal = 3869,
        [Description("Labyrinth Arrow Movement Speed +% Final")]
        LabyrinthArrowMovementSpeedPosPctFinal = 3870,
        [Description("Map Disable Portal Use")]
        MapDisablePortalUse = 3871,
        [Description("Jorrhasts Blacksteel Animate Weapon Duration +% Final")]
        JorrhastsBlacksteelAnimateWeaponDurationPosPctFinal = 3872,
        [Description("Shockwave Slam Explosion Damage +% Final")]
        ShockwaveSlamExplosionDamagePosPctFinal = 3873,
        [Description("Display Monster Casts Wither")]
        DisplayMonsterCastsWither = 3874,
        [Description("Display Monster Causes Ground Desecration")]
        DisplayMonsterCausesGroundDesecration = 3875,
        [Description("Spread Tar Ground When Not Igniting Enemy On Hit %")]
        SpreadTarGroundWhenNotIgnitingEnemyOnHitPct = 3876,
        [Description("Spread Burning Ground When Igniting Enemy On Hit %")]
        SpreadBurningGroundWhenIgnitingEnemyOnHitPct = 3877,
        [Description("Non Curse Aura Effect +%")]
        NonCurseAuraEffectPosPct = 3878,
        [Description("Max Talisman Degen Stacks")]
        MaxTalismanDegenStacks = 3879,
        [Description("Current Talisman Degen Stacks")]
        CurrentTalismanDegenStacks = 3880,
        [Description("Base Physical Damage Taken Per Minute Per Talisman Degen Stack")]
        BasePhysicalDamageTakenPerMinutePerTalismanDegenStack = 3881,
        [Description("Melee Splash Area Of Effect +% Final")]
        MeleeSplashAreaOfEffectPosPctFinal = 3882,
        [Description("Unarmed Damage +% Vs Bleeding Enemies")]
        UnarmedDamagePosPctVsBleedingEnemies = 3883,
        [Description("Life Gained On Bleeding Enemy Hit")]
        LifeGainedOnBleedingEnemyHit = 3884,
        [Description("Base Critical Strike Chance While Unarmed %")]
        BaseCriticalStrikeChanceWhileUnarmedPct = 3885,
        [Description("Modifiers To Claw Damage Also Affect Unarmed Damage")]
        ModifiersToClawDamageAlsoAffectUnarmedDamage = 3886,
        [Description("Damage +% While Unarmed")]
        DamagePosPctWhileUnarmed = 3887,
        [Description("Bloodworm On Damage Taken %")]
        BloodwormOnDamageTakenPct = 3888,
        [Description("Map Sidearea Level Override")]
        MapSideareaLevelOverride = 3889,
        [Description("Map Boss Talisman Tier")]
        MapBossTalismanTier = 3890,
        [Description("Map Boss Talisman Rarity")]
        MapBossTalismanRarity = 3891,
        [Description("Local Display Illusory Warp Level")]
        LocalDisplayIllusoryWarpLevel = 3892,
        [Description("Fortify Effect On Self +%")]
        FortifyEffectOnSelfPosPct = 3893,
        [Description("Local Implicit Stat Magnitude +%")]
        LocalImplicitStatMagnitudePosPct = 3894,
        [Description("Using Flask")]
        UsingFlask = 3895,
        [Description("Chance To Poison On Hit %")]
        ChanceToPoisonOnHitPct = 3896,
        [Description("Flask Charges Gained +%")]
        FlaskChargesGainedPosPct = 3897,
        [Description("Soul Eater From Stat")]
        SoulEaterFromStat = 3898,
        [Description("Gain Power Charge On Kill With Hit %")]
        GainPowerChargeOnKillWithHitPct = 3899,
        [Description("Killed Monster Dropped Item Rarity +% When Shattered")]
        KilledMonsterDroppedItemRarityPosPctWhenShattered = 3900,
        [Description("Energy Shield Delay During Flask Effect -%")]
        EnergyShieldDelayDuringFlaskEffectNegPct = 3901,
        [Description("Virtual Energy Shield Delay -%")]
        VirtualEnergyShieldDelayNegPct = 3902,
        [Description("Energy Shield Recharge Rate During Flask Effect +%")]
        EnergyShieldRechargeRateDuringFlaskEffectPosPct = 3903,
        [Description("Virtual Energy Shield Recharge Rate +%")]
        VirtualEnergyShieldRechargeRatePosPct = 3904,
        [Description("Base Cold Damage % Of Maximum Life Plus Maximum Es Taken Per Minute")]
        BaseColdDamagePctOfMaximumLifePlusMaximumESTakenPerMinute = 3905,
        [Description("Base Lightning Damage % Of Maximum Life Plus Maximum Es Taken Per Minute")]
        BaseLightningDamagePctOfMaximumLifePlusMaximumESTakenPerMinute = 3906,
        [Description("Modifiers To Claw Attack Speed Also Affect Unarmed Attack Speed")]
        ModifiersToClawAttackSpeedAlsoAffectUnarmedAttackSpeed = 3907,
        [Description("Modifiers To Claw Critical Strike Chance Also Affect Unarmed Critical Strike Chance")]
        ModifiersToClawCriticalStrikeChanceAlsoAffectUnarmedCriticalStrikeChance = 3908,
        [Description("Main Hand Chance To Poison On Critical Strike %")]
        MainHandChanceToPoisonOnCriticalStrikePct = 3909,
        [Description("Off Hand Chance To Poison On Critical Strike %")]
        OffHandChanceToPoisonOnCriticalStrikePct = 3910,
        [Description("Chance To Poison On Critical Strike With Dagger %")]
        ChanceToPoisonOnCriticalStrikeWithDaggerPct = 3911,
        [Description("Minion Duration")]
        MinionDuration = 3912,
        [Description("Number Of Wolves Allowed")]
        NumberOfWolvesAllowed = 3913,
        [Description("Whirling Leap Bloodworms To Spawn")]
        WhirlingLeapBloodwormsToSpawn = 3914,
        [Description("Map Display Unique Boss Drops X Maps")]
        MapDisplayUniqueBossDropsXMaps = 3915,
        [Description("Endurance Charge On Kill %")]
        EnduranceChargeOnKillPct = 3916,
        [Description("Fishing Bite Sensitivity +%")]
        FishingBiteSensitivityPosPct = 3917,
        [Description("Local Display Summon Wolf On Kill %")]
        LocalDisplaySummonWolfOnKillPct = 3918,
        [Description("Corrupted Blood On Hit % Average Damage To Deal Per Minute Per Stack")]
        CorruptedBloodOnHitPctAverageDamageToDealPerMinutePerStack = 3919,
        [Description("Maim On Hit % With At Least 3 Stacks Of Corrupted Blood")]
        MaimOnHitPctWithAtLeast3StacksOfCorruptedBlood = 3920,
        [Description("Monster Can Spawn With Talisman")]
        MonsterCanSpawnWithTalisman = 3921,
        [Description("Monster Explodes On Death Text")]
        MonsterExplodesOnDeathText = 3922,
        [Description("Number Of Active Wolves")]
        NumberOfActiveWolves = 3923,
        [Description("Active Skill Area Of Effect +% Final")]
        ActiveSkillAreaOfEffectPosPctFinal = 3924,
        [Description("Cold Damage +% Per 1% Block Chance")]
        ColdDamagePosPctPer1PctBlockChance = 3925,
        [Description("Maximum Mana +% Per 2% Spell Block Chance")]
        MaximumManaPosPctPer2PctSpellBlockChance = 3926,
        [Description("Physical Damage Reduction Rating +% While Chilled Or Frozen")]
        PhysicalDamageReductionRatingPosPctWhileChilledOrFrozen = 3927,
        [Description("Support Reduced Duration Damage +% Final")]
        SupportReducedDurationDamagePosPctFinal = 3928,
        [Description("Map Players Action Speed +% While Chilled")]
        MapPlayersActionSpeedPosPctWhileChilled = 3929,
        [Description("Action Speed +% While Chilled")]
        ActionSpeedPosPctWhileChilled = 3930,
        [Description("Extra Gore Chance Override %")]
        ExtraGoreChanceOverridePct = 3931,
        [Description("Siphon Base Chaos Damage To Deal Per Minute")]
        SiphonBaseChaosDamageToDealPerMinute = 3932,
        [Description("Blade Vortex Buff Range")]
        BladeVortexBuffRange = 3933,
        [Description("Spell And Attack Minimum Added Cold Damage")]
        SpellAndAttackMinimumAddedColdDamage = 3934,
        [Description("Spell And Attack Maximum Added Cold Damage")]
        SpellAndAttackMaximumAddedColdDamage = 3935,
        [Description("Reduce Enemy Cold Resistance With Weapons %")]
        ReduceEnemyColdResistanceWithWeaponsPct = 3936,
        [Description("Reduce Enemy Fire Resistance With Weapons %")]
        ReduceEnemyFireResistanceWithWeaponsPct = 3937,
        [Description("Reduce Enemy Lightning Resistance With Weapons %")]
        ReduceEnemyLightningResistanceWithWeaponsPct = 3938,
        [Description("Reduce Enemy Chaos Resistance With Weapons %")]
        ReduceEnemyChaosResistanceWithWeaponsPct = 3939,
        [Description("Support Minefield Mine Damage +% Final")]
        SupportMinefieldMineDamagePosPctFinal = 3940,
        [Description("Modifiers To Map Item Drop Quantity Also Apply To Map Item Drop Rarity")]
        ModifiersToMapItemDropQuantityAlsoApplyToMapItemDropRarity = 3941,
        [Description("Map Monster Drop Higher Level Gear")]
        MapMonsterDropHigherLevelGear = 3942,
        [Description("Support Gem Elemental Damage +% Final")]
        SupportGemElementalDamagePosPctFinal = 3943,
        [Description("Keystone Elemental Overload Damage +% Final")]
        KeystoneElementalOverloadDamagePosPctFinal = 3944,
        [Description("Keystone Elemental Overload")]
        KeystoneElementalOverload = 3945,
        [Description("Local Smoke Ground On Flask Use Radius")]
        LocalSmokeGroundOnFlaskUseRadius = 3946,
        [Description("Local Consecrate Ground On Flask Use Radius")]
        LocalConsecrateGroundOnFlaskUseRadius = 3947,
        [Description("Gain Onslaught During Flask Effect")]
        GainOnslaughtDuringFlaskEffect = 3948,
        [Description("Cast Linked Curses On Curse")]
        CastLinkedCursesOnCurse = 3949,
        [Description("Reduce Enemy Elemental Resistance With Weapons %")]
        ReduceEnemyElementalResistanceWithWeaponsPct = 3950,
        [Description("% Chance To Gain Frenzy Charge On Trap Triggered By An Enemy")]
        PctChanceToGainFrenzyChargeOnTrapTriggeredByAnEnemy = 3951,
        [Description("% Chance To Gain Endurance Charge On Trap Triggered By An Enemy")]
        PctChanceToGainEnduranceChargeOnTrapTriggeredByAnEnemy = 3952,
        [Description("Local Number Of Bloodworms To Spawn On Flask Use")]
        LocalNumberOfBloodwormsToSpawnOnFlaskUse = 3953,
        [Description("Add Power Charge On Hit %")]
        AddPowerChargeOnHitPct = 3954,
        [Description("Lose All Power Charges On Reaching Maximum Power Charges")]
        LoseAllPowerChargesOnReachingMaximumPowerCharges = 3955,
        [Description("Shocked For 4 Seconds On Reaching Maximum Power Charges")]
        ShockedFor4SecondsOnReachingMaximumPowerCharges = 3956,
        [Description("Local Display Molten Burst On Melee Hit %")]
        LocalDisplayMoltenBurstOnMeleeHitPct = 3957,
        [Description("Max Frost Nova Stacks")]
        MaxFrostNovaStacks = 3958,
        [Description("Current Frost Nova Stacks")]
        CurrentFrostNovaStacks = 3959,
        [Description("Reverse Projectile Spread")]
        ReverseProjectileSpread = 3960,
        [Description("Base Cold Damage +% Per Frost Nova Stack")]
        BaseColdDamagePosPctPerFrostNovaStack = 3961,
        [Description("Frost Nova Cold Damage +% Per Frost Nova Stack")]
        FrostNovaColdDamagePosPctPerFrostNovaStack = 3962,
        [Description("Is Petrified")]
        IsPetrified = 3963,
        [Description("Cast On Melee Hit %")]
        CastOnMeleeHitPct = 3964,
        [Description("Izaro Curse On Hit Level Temporal Chains")]
        IzaroCurseOnHitLevelTemporalChains = 3965,
        [Description("Izaro Curse On Hit Level Elemental Weakness")]
        IzaroCurseOnHitLevelElementalWeakness = 3966,
        [Description("Izaro Curse On Hit Level Vulnerability")]
        IzaroCurseOnHitLevelVulnerability = 3967,
        [Description("Labyrinth Trinket Instantly Kill Next Pylon")]
        LabyrinthTrinketInstantlyKillNextPylon = 3968,
        [Description("Labyrinth Trinket Instantly Kill Next Lieutenant")]
        LabyrinthTrinketInstantlyKillNextLieutenant = 3969,
        [Description("Labyrinth Trinket Instantly Kill Next Elemental")]
        LabyrinthTrinketInstantlyKillNextElemental = 3970,
        [Description("Labyrinth Trinket Instantly Kill Next Gargoyle")]
        LabyrinthTrinketInstantlyKillNextGargoyle = 3971,
        [Description("Labyrinth Trinket Permanently Disable Next Statue")]
        LabyrinthTrinketPermanentlyDisableNextStatue = 3972,
        [Description("Labyrinth Trinket Permanently Disable Next Symbol")]
        LabyrinthTrinketPermanentlyDisableNextSymbol = 3973,
        [Description("Labyrinth Trinket Reactivate Next Charge Disruptor After 5 Seconds")]
        LabyrinthTrinketReactivateNextChargeDisruptorAfter5Seconds = 3974,
        [Description("Add Endurance Charge On Gain Power Charge %")]
        AddEnduranceChargeOnGainPowerChargePct = 3975,
        [Description("Stacking Damage +% On Kill For 4 Seconds")]
        StackingDamagePosPctOnKillFor4Seconds = 3976,
        [Description("Grant Owner Stacking Damage +% On Kill For 4 Seconds")]
        GrantOwnerStackingDamagePosPctOnKillFor4Seconds = 3977,
        [Description("Attack And Cast Speed +% While Totem Active")]
        AttackAndCastSpeedPosPctWhileTotemActive = 3978,
        [Description("Number Of Additional Totems Allowed On Kill For 8 Seconds")]
        NumberOfAdditionalTotemsAllowedOnKillFor8Seconds = 3979,
        [Description("Owner Number Of Additional Totems Allowed On Kill For 8 Seconds")]
        OwnerNumberOfAdditionalTotemsAllowedOnKillFor8Seconds = 3980,
        [Description("Map Monsters Base Self Critical Strike Multiplier -%")]
        MapMonstersBaseSelfCriticalStrikeMultiplierNegPct = 3981,
        [Description("Local Flask Is Petrified")]
        LocalFlaskIsPetrified = 3982,
        [Description("Hierophant Helmet Supported By Elemental Penetration")]
        HierophantHelmetSupportedByElementalPenetration = 3983,
        [Description("Hierophant Gloves Supported By Increased Area Of Effect")]
        HierophantGlovesSupportedByIncreasedAreaOfEffect = 3984,
        [Description("Hierophant Boots Supported By Life Leech")]
        HierophantBootsSupportedByLifeLeech = 3985,
        [Description("Power Frenzy Or Endurance Charge On Kill %")]
        PowerFrenzyOrEnduranceChargeOnKillPct = 3986,
        [Description("Local Flask Effect +%")]
        LocalFlaskEffectPosPct = 3987,
        [Description("Local Flask Poison Immunity During Flask Effect")]
        LocalFlaskPoisonImmunityDuringFlaskEffect = 3988,
        [Description("Immune To Poison")]
        ImmuneToPoison = 3989,
        [Description("Local Flask Additional Physical Damage Reduction %")]
        LocalFlaskAdditionalPhysicalDamageReductionPct = 3990,
        [Description("Unique Spread Poison To Nearby Allies As 200 Life Regeneration Per Second On Kill")]
        UniqueSpreadPoisonToNearbyAlliesAs200LifeRegenerationPerSecondOnKill = 3991,
        [Description("Support Pierce Projectile Damage +% Final")]
        SupportPierceProjectileDamagePosPctFinal = 3992,
        [Description("Elementalist Damage With An Element +% For 4 Seconds After Being Hit By An Element")]
        ElementalistDamageWithAnElementPosPctFor4SecondsAfterBeingHitByAnElement = 3993,
        [Description("Elementalist Elemental Damage +% For 4 Seconds Every 10 Seconds")]
        ElementalistElementalDamagePosPctFor4SecondsEvery10Seconds = 3994,
        [Description("Elementalist Cold Penetration % For 4 Seconds On Using Fire Skill")]
        ElementalistColdPenetrationPctFor4SecondsOnUsingFireSkill = 3995,
        [Description("Elementalist Lightning Penetration % For 4 Seconds On Using Cold Skill")]
        ElementalistLightningPenetrationPctFor4SecondsOnUsingColdSkill = 3996,
        [Description("Elementalist Fire Penetration % For 4 Seconds On Using Lightning Skill")]
        ElementalistFirePenetrationPctFor4SecondsOnUsingLightningSkill = 3997,
        [Description("Elementalist Summon Elemental Golem On Killing Enemy With Element %")]
        ElementalistSummonElementalGolemOnKillingEnemyWithElementPct = 3998,
        [Description("Elementalist All Damage Causes Chill Shock And Ignite For 4 Seconds On Kill %")]
        ElementalistAllDamageCausesChillShockAndIgniteFor4SecondsOnKillPct = 3999,
        [Description("Elementalist Elemental Status Effect Aura Radius")]
        ElementalistElementalStatusEffectAuraRadius = 4000,
        [Description("Elementalist Elemental Damage Rotation")]
        ElementalistElementalDamageRotation = 4001,
        [Description("Virtual Elemental Status Effect Aura Radius")]
        VirtualElementalStatusEffectAuraRadius = 4002,
        [Description("All Damage Can Chill Ignite Shock")]
        AllDamageCanChillIgniteShock = 4003,
        [Description("Is Blighted")]
        IsBlighted = 4004,
        [Description("Virtual Life Leech Permyriad On Crit")]
        VirtualLifeLeechPermyriadOnCrit = 4005,
        [Description("Occultist Gain % Of Non Chaos Damage As Chaos Damage Per Curse On Target On Kill For 4 Seconds")]
        OccultistGainPctOfNonChaosDamageAsChaosDamagePerCurseOnTargetOnKillFor4Seconds = 4006,
        [Description("Occultist Energy Shield Always Recovers For 4 Seconds After Starting Recovery")]
        OccultistEnergyShieldAlwaysRecoversFor4SecondsAfterStartingRecovery = 4007,
        [Description("Occultist Stun Threshold Is Based On Energy Shield Instead Of Life")]
        OccultistStunThresholdIsBasedOnEnergyShieldInsteadOfLife = 4008,
        [Description("Is Counterattack")]
        IsCounterattack = 4009,
        [Description("Knockback On Counterattack %")]
        KnockbackOnCounterattackPct = 4010,
        [Description("Local Flask Chilled Ground On Flask Use Radius")]
        LocalFlaskChilledGroundOnFlaskUseRadius = 4011,
        [Description("Local Flask Duration +%")]
        LocalFlaskDurationPosPct = 4012,
        [Description("Max Charged Attack Stacks")]
        MaxChargedAttackStacks = 4013,
        [Description("Current Charged Attack Stacks")]
        CurrentChargedAttackStacks = 4014,
        [Description("Local Display Socketed Curse Gems Supported By Level X Blasphemy")]
        LocalDisplaySocketedCurseGemsSupportedByLevelXBlasphemy = 4015,
        [Description("Chill On You Proliferates To Nearby Enemies Within X Radius")]
        ChillOnYouProliferatesToNearbyEnemiesWithinXRadius = 4016,
        [Description("Freeze On You Proliferates To Nearby Enemies Within X Radius")]
        FreezeOnYouProliferatesToNearbyEnemiesWithinXRadius = 4017,
        [Description("Animate Weapon Damage +%")]
        AnimateWeaponDamagePosPct = 4018,
        [Description("Burning Arrow Damage +%")]
        BurningArrowDamagePosPct = 4019,
        [Description("Cleave Damage +%")]
        CleaveDamagePosPct = 4020,
        [Description("Double Strike Damage +%")]
        DoubleStrikeDamagePosPct = 4021,
        [Description("Dual Strike Damage +%")]
        DualStrikeDamagePosPct = 4022,
        [Description("Fire Trap Damage +%")]
        FireTrapDamagePosPct = 4023,
        [Description("Fireball Damage +%")]
        FireballDamagePosPct = 4024,
        [Description("Freezing Pulse Damage +%")]
        FreezingPulseDamagePosPct = 4025,
        [Description("Glacial Hammer Damage +%")]
        GlacialHammerDamagePosPct = 4026,
        [Description("Ground Slam Damage +%")]
        GroundSlamDamagePosPct = 4027,
        [Description("Heavy Strike Damage +%")]
        HeavyStrikeDamagePosPct = 4028,
        [Description("Infernal Blow Damage +%")]
        InfernalBlowDamagePosPct = 4029,
        [Description("Lightning Strike Damage +%")]
        LightningStrikeDamagePosPct = 4030,
        [Description("Lightning Tendrils Damage +%")]
        LightningTendrilsDamagePosPct = 4031,
        [Description("Magma Orb Damage +%")]
        MagmaOrbDamagePosPct = 4032,
        [Description("Molten Strike Damage +%")]
        MoltenStrikeDamagePosPct = 4033,
        [Description("Zombie Damage +%")]
        ZombieDamagePosPct = 4034,
        [Description("Reave Damage +%")]
        ReaveDamagePosPct = 4035,
        [Description("Spark Damage +%")]
        SparkDamagePosPct = 4036,
        [Description("Spectral Throw Damage +%")]
        SpectralThrowDamagePosPct = 4037,
        [Description("Split Arrow Damage +%")]
        SplitArrowDamagePosPct = 4038,
        [Description("Ethereal Knives Damage +%")]
        EtherealKnivesDamagePosPct = 4039,
        [Description("Ice Shot Damage +%")]
        IceShotDamagePosPct = 4040,
        [Description("Rain Of Arrows Damage +%")]
        RainOfArrowsDamagePosPct = 4041,
        [Description("Raging Spirit Damage +%")]
        RagingSpiritDamagePosPct = 4042,
        [Description("Viper Strike Damage +%")]
        ViperStrikeDamagePosPct = 4043,
        [Description("Flicker Strike Damage +%")]
        FlickerStrikeDamagePosPct = 4044,
        [Description("Leap Slam Damage +%")]
        LeapSlamDamagePosPct = 4045,
        [Description("Lightning Arrow Damage +%")]
        LightningArrowDamagePosPct = 4046,
        [Description("Lightning Warp Damage +%")]
        LightningWarpDamagePosPct = 4047,
        [Description("Puncture Damage +%")]
        PunctureDamagePosPct = 4048,
        [Description("Shield Charge Damage +%")]
        ShieldChargeDamagePosPct = 4049,
        [Description("Skeletons Damage +%")]
        SkeletonsDamagePosPct = 4050,
        [Description("Arc Damage +%")]
        ArcDamagePosPct = 4051,
        [Description("Barrage Damage +%")]
        BarrageDamagePosPct = 4052,
        [Description("Fire Nova Mine Damage +%")]
        FireNovaMineDamagePosPct = 4053,
        [Description("Fire Storm Damage +%")]
        FireStormDamagePosPct = 4054,
        [Description("Flame Surge Damage +%")]
        FlameSurgeDamagePosPct = 4055,
        [Description("Ice Nova Damage +%")]
        IceNovaDamagePosPct = 4056,
        [Description("Ice Spear Damage +%")]
        IceSpearDamagePosPct = 4057,
        [Description("Incinerate Damage +%")]
        IncinerateDamagePosPct = 4058,
        [Description("Power Siphon Damage +%")]
        PowerSiphonDamagePosPct = 4059,
        [Description("Searing Bond Damage +%")]
        SearingBondDamagePosPct = 4060,
        [Description("Static Strike Damage +%")]
        StaticStrikeDamagePosPct = 4061,
        [Description("Storm Call Damage +%")]
        StormCallDamagePosPct = 4062,
        [Description("Sweep Damage +%")]
        SweepDamagePosPct = 4063,
        [Description("Frenzy Damage +%")]
        FrenzyDamagePosPct = 4064,
        [Description("Righteous Fire Damage +%")]
        RighteousFireDamagePosPct = 4065,
        [Description("Elemental Hit Damage +%")]
        ElementalHitDamagePosPct = 4066,
        [Description("Cyclone Damage +%")]
        CycloneDamagePosPct = 4067,
        [Description("Tornado Shot Damage +%")]
        TornadoShotDamagePosPct = 4068,
        [Description("Arctic Breath Damage +%")]
        ArcticBreathDamagePosPct = 4069,
        [Description("Explosive Arrow Damage +%")]
        ExplosiveArrowDamagePosPct = 4070,
        [Description("Flameblast Damage +%")]
        FlameblastDamagePosPct = 4071,
        [Description("Glacial Cascade Damage +%")]
        GlacialCascadeDamagePosPct = 4072,
        [Description("Ice Crash Damage +%")]
        IceCrashDamagePosPct = 4073,
        [Description("Kinetic Blast Damage +%")]
        KineticBlastDamagePosPct = 4074,
        [Description("Shock Nova Damage +%")]
        ShockNovaDamagePosPct = 4075,
        [Description("Shockwave Totem Damage +%")]
        ShockwaveTotemDamagePosPct = 4076,
        [Description("Wild Strike Damage +%")]
        WildStrikeDamagePosPct = 4077,
        [Description("Detonate Dead Damage +%")]
        DetonateDeadDamagePosPct = 4078,
        [Description("Caustic Arrow Damage +%")]
        CausticArrowDamagePosPct = 4079,
        [Description("Chaos Golem Damage +%")]
        ChaosGolemDamagePosPct = 4080,
        [Description("Flame Golem Damage +%")]
        FlameGolemDamagePosPct = 4081,
        [Description("Ice Golem Damage +%")]
        IceGolemDamagePosPct = 4082,
        [Description("Cold Snap Damage +%")]
        ColdSnapDamagePosPct = 4083,
        [Description("Flame Totem Damage +%")]
        FlameTotemDamagePosPct = 4084,
        [Description("Animate Guardian Damage +%")]
        AnimateGuardianDamagePosPct = 4085,
        [Description("Bear Trap Damage +%")]
        BearTrapDamagePosPct = 4086,
        [Description("Frost Wall Damage +%")]
        FrostWallDamagePosPct = 4087,
        [Description("Molten Shell Damage +%")]
        MoltenShellDamagePosPct = 4088,
        [Description("Reckoning Damage +%")]
        ReckoningDamagePosPct = 4089,
        [Description("Vigilant Strike Damage +%")]
        VigilantStrikeDamagePosPct = 4090,
        [Description("Whirling Blades Damage +%")]
        WhirlingBladesDamagePosPct = 4091,
        [Description("Flame Dash Damage +%")]
        FlameDashDamagePosPct = 4092,
        [Description("Freeze Mine Damage +%")]
        FreezeMineDamagePosPct = 4093,
        [Description("Herald Of Ash Damage +%")]
        HeraldOfAshDamagePosPct = 4094,
        [Description("Herald Of Ice Damage +%")]
        HeraldOfIceDamagePosPct = 4095,
        [Description("Herald Of Thunder Damage +%")]
        HeraldOfThunderDamagePosPct = 4096,
        [Description("Tempest Shield Damage +%")]
        TempestShieldDamagePosPct = 4097,
        [Description("Desecrate Damage +%")]
        DesecrateDamagePosPct = 4098,
        [Description("Blink Arrow And Blink Arrow Clone Damage +%")]
        BlinkArrowAndBlinkArrowCloneDamagePosPct = 4099,
        [Description("Mirror Arrow And Mirror Arrow Clone Damage +%")]
        MirrorArrowAndMirrorArrowCloneDamagePosPct = 4100,
        [Description("Riposte Damage +%")]
        RiposteDamagePosPct = 4101,
        [Description("Vengeance Damage +%")]
        VengeanceDamagePosPct = 4102,
        [Description("Converted Enemies Damage +%")]
        ConvertedEnemiesDamagePosPct = 4103,
        [Description("Abyssal Cry Damage +%")]
        AbyssalCryDamagePosPct = 4104,
        [Description("Shrapnel Shot Damage +%")]
        ShrapnelShotDamagePosPct = 4105,
        [Description("Blast Rain Damage +%")]
        BlastRainDamagePosPct = 4106,
        [Description("Essence Drain Damage +%")]
        EssenceDrainDamagePosPct = 4107,
        [Description("Contagion Damage +%")]
        ContagionDamagePosPct = 4108,
        [Description("Blade Vortex Damage +%")]
        BladeVortexDamagePosPct = 4109,
        [Description("Bladefall Damage +%")]
        BladefallDamagePosPct = 4110,
        [Description("Ice Trap Damage +%")]
        IceTrapDamagePosPct = 4111,
        [Description("Earthquake Damage +%")]
        EarthquakeDamagePosPct = 4112,
        [Description("Stone Golem Damage +%")]
        StoneGolemDamagePosPct = 4113,
        [Description("Frost Bomb Damage +%")]
        FrostBombDamagePosPct = 4114,
        [Description("Orb Of Storms Damage +%")]
        OrbOfStormsDamagePosPct = 4115,
        [Description("Siege Ballista Damage +%")]
        SiegeBallistaDamagePosPct = 4116,
        [Description("Blight Damage +%")]
        BlightDamagePosPct = 4117,
        [Description("Shockwave Slam Damage +%")]
        ShockwaveSlamDamagePosPct = 4118,
        [Description("Fire Beam Damage +%")]
        FireBeamDamagePosPct = 4119,
        [Description("Life Regeneration Per Minute % While Frozen")]
        LifeRegenerationPerMinutePctWhileFrozen = 4120,
        [Description("Occultist Stacking Energy Shield Regeneration Rate Per Minute % On Kill For 4 Seconds")]
        OccultistStackingEnergyShieldRegenerationRatePerMinutePctOnKillFor4Seconds = 4121,
        [Description("Occultist Immune To Stun While On Full Energy Shield")]
        OccultistImmuneToStunWhileOnFullEnergyShield = 4122,
        [Description("Totem Damage +% Final Per Active Totem")]
        TotemDamagePosPctFinalPerActiveTotem = 4123,
        [Description("Totem Damage +% Final")]
        TotemDamagePosPctFinal = 4124,
        [Description("Cannot Be Affected By Flasks")]
        CannotBeAffectedByFlasks = 4125,
        [Description("Flasks Apply To Your Zombies And Spectres")]
        FlasksApplyToYourZombiesAndSpectres = 4126,
        [Description("Modifiers To Minion Damage Also Affect You")]
        ModifiersToMinionDamageAlsoAffectYou = 4127,
        [Description("Modifiers To Minion Attack Speed Also Affect You")]
        ModifiersToMinionAttackSpeedAlsoAffectYou = 4128,
        [Description("Modifiers To Minion Cast Speed Also Affect You")]
        ModifiersToMinionCastSpeedAlsoAffectYou = 4129,
        [Description("Modifiers To Minion Life Regeneration Also Affect You")]
        ModifiersToMinionLifeRegenerationAlsoAffectYou = 4130,
        [Description("Modifiers To Minion Movement Speed Also Affect You")]
        ModifiersToMinionMovementSpeedAlsoAffectYou = 4131,
        [Description("Modifiers To Minion Resistances Also Affect You")]
        ModifiersToMinionResistancesAlsoAffectYou = 4132,
        [Description("Cast On Gain Skill")]
        CastOnGainSkill = 4133,
        [Description("Base Lightning Damage Taken Per Second")]
        BaseLightningDamageTakenPerSecond = 4134,
        [Description("Current Izaro Charges")]
        CurrentIzaroCharges = 4135,
        [Description("Attack Speed +% Per Izaro Charge")]
        AttackSpeedPosPctPerIzaroCharge = 4136,
        [Description("Cast Speed +% Per Izaro Charge")]
        CastSpeedPosPctPerIzaroCharge = 4137,
        [Description("Damage +% Per Izaro Charge Final")]
        DamagePosPctPerIzaroChargeFinal = 4138,
        [Description("Physical Damage Reduction % Per Izaro Charge")]
        PhysicalDamageReductionPctPerIzaroCharge = 4139,
        [Description("Resist All Elements % Per Izaro Charge")]
        ResistAllElementsPctPerIzaroCharge = 4140,
        [Description("Critical Strike Chance +% Per Izaro Charge")]
        CriticalStrikeChancePosPctPerIzaroCharge = 4141,
        [Description("Shield Charge Scaling Stun Threshold Reduction +% At Maximum Range")]
        ShieldChargeScalingStunThresholdReductionPosPctAtMaximumRange = 4142,
        [Description("Map Spawn Perandus Chests")]
        MapSpawnPerandusChests = 4143,
        [Description("Set User Life To 1 On Skill Use")]
        SetUserLifeTo1OnSkillUse = 4144,
        [Description("Grant Izaro Buff On Skill Use")]
        GrantIzaroBuffOnSkillUse = 4145,
        [Description("Local Double Damage To Chilled Enemies")]
        LocalDoubleDamageToChilledEnemies = 4146,
        [Description("Main Hand Double Damage To Chilled Enemies")]
        MainHandDoubleDamageToChilledEnemies = 4147,
        [Description("Off Hand Double Damage To Chilled Enemies")]
        OffHandDoubleDamageToChilledEnemies = 4148,
        [Description("Global Number Of Times Damage Is Doubled")]
        GlobalNumberOfTimesDamageIsDoubled = 4149,
        [Description("Main Hand Number Of Times Damage Is Doubled")]
        MainHandNumberOfTimesDamageIsDoubled = 4150,
        [Description("Off Hand Number Of Times Damage Is Doubled")]
        OffHandNumberOfTimesDamageIsDoubled = 4151,
        [Description("Base Main Hand Number Of Times Damage Is Doubled")]
        BaseMainHandNumberOfTimesDamageIsDoubled = 4152,
        [Description("Base Off Hand Number Of Times Damage Is Doubled")]
        BaseOffHandNumberOfTimesDamageIsDoubled = 4153,
        [Description("Local Elemental Penetration %")]
        LocalElementalPenetrationPct = 4154,
        [Description("Main Hand Elemental Penetration %")]
        MainHandElementalPenetrationPct = 4155,
        [Description("Off Hand Elemental Penetration %")]
        OffHandElementalPenetrationPct = 4156,
        [Description("Damage While No Frenzy Charges +%")]
        DamageWhileNoFrenzyChargesPosPct = 4157,
        [Description("Local Flask Ghost Reaver")]
        LocalFlaskGhostReaver = 4158,
        [Description("Local Flask Zealots Oath")]
        LocalFlaskZealotsOath = 4159,
        [Description("Critical Strike Chance Against Enemies On Full Life +%")]
        CriticalStrikeChanceAgainstEnemiesOnFullLifePosPct = 4160,
        [Description("Spirit Offering Life % Added As Base Maximum Energy Shield Per Corpse Consumed")]
        SpiritOfferingLifePctAddedAsBaseMaximumEnergyShieldPerCorpseConsumed = 4161,
        [Description("Minions Deal % Of Physical Damage As Additional Chaos Damage")]
        MinionsDealPctOfPhysicalDamageAsAdditionalChaosDamage = 4162,
        [Description("Attack Critical Strike Damage Life Leech Permyriad")]
        AttackCriticalStrikeDamageLifeLeechPermyriad = 4163,
        [Description("Minion Attack Minimum Added Physical Damage")]
        MinionAttackMinimumAddedPhysicalDamage = 4164,
        [Description("Minion Attack Maximum Added Physical Damage")]
        MinionAttackMaximumAddedPhysicalDamage = 4165,
        [Description("Attack Physical Damage % To Add As Lightning")]
        AttackPhysicalDamagePctToAddAsLightning = 4166,
        [Description("Attack Physical Damage % To Add As Fire")]
        AttackPhysicalDamagePctToAddAsFire = 4167,
        [Description("Maximum Energy Shield + Per 5 Strength")]
        MaximumEnergyShieldPosPer5Strength = 4168,
        [Description("Attack Always Crit")]
        AttackAlwaysCrit = 4169,
        [Description("Totem Aura Enemy Damage +% Final")]
        TotemAuraEnemyDamagePosPctFinal = 4170,
        [Description("Totem Aura Enemy Fire And Physical Damage Taken +%")]
        TotemAuraEnemyFireAndPhysicalDamageTakenPosPct = 4171,
        [Description("Local Varunastra Weapon Counts As All 1h Melee Weapon Types")]
        LocalVarunastraWeaponCountsAsAll1hMeleeWeaponTypes = 4172,
        [Description("Main Hand Varunastra Weapon Counts As All 1h Melee Weapon Types")]
        MainHandVarunastraWeaponCountsAsAll1hMeleeWeaponTypes = 4173,
        [Description("Off Hand Varunastra Weapon Counts As All 1h Melee Weapon Types")]
        OffHandVarunastraWeaponCountsAsAll1hMeleeWeaponTypes = 4174,
        [Description("Guardian Warcry Grant Attack Cast And Movement Speed To You And Nearby Allies +%")]
        GuardianWarcryGrantAttackCastAndMovementSpeedToYouAndNearbyAlliesPosPct = 4175,
        [Description("Guardian Auras Grant Life Regeneration Per Minute %")]
        GuardianAurasGrantLifeRegenerationPerMinutePct = 4176,
        [Description("Guardian Nearby Enemies Cannot Gain Charges")]
        GuardianNearbyEnemiesCannotGainCharges = 4177,
        [Description("Guardian Reserved Life Granted To You And Allies As Armour %")]
        GuardianReservedLifeGrantedToYouAndAlliesAsArmourPct = 4178,
        [Description("Guardian Remove Curses And Status Ailments Every 10 Seconds")]
        GuardianRemoveCursesAndStatusAilmentsEvery10Seconds = 4179,
        [Description("Guardian Gain Life Regeneration Per Minute % For 1 Second Every 10 Seconds")]
        GuardianGainLifeRegenerationPerMinutePctFor1SecondEvery10Seconds = 4180,
        [Description("Life Reserved")]
        LifeReserved = 4181,
        [Description("Cannot Gain Charges")]
        CannotGainCharges = 4182,
        [Description("Max Izaro Charges")]
        MaxIzaroCharges = 4183,
        [Description("Local Display Socketed Gems Supported By Level X Fortify")]
        LocalDisplaySocketedGemsSupportedByLevelXFortify = 4184,
        [Description("Base Fire Immunity")]
        BaseFireImmunity = 4185,
        [Description("Totem Fire Immunity")]
        TotemFireImmunity = 4186,
        [Description("Base % Maximum Life Inflicted As Aoe Fire Damage When Hit")]
        BasePctMaximumLifeInflictedAsAoeFireDamageWhenHit = 4187,
        [Description("Totem % Maximum Life Inflicted As Aoe Fire Damage When Hit")]
        TotemPctMaximumLifeInflictedAsAoeFireDamageWhenHit = 4188,
        [Description("Active Skill Attack Speed +% Final Per Frenzy Charge")]
        ActiveSkillAttackSpeedPosPctFinalPerFrenzyCharge = 4189,
        [Description("Trap Damage Buildup Damage +% Final")]
        TrapDamageBuildupDamagePosPctFinal = 4190,
        [Description("Trap Damage Buildup Damage +% Final When First Set")]
        TrapDamageBuildupDamagePosPctFinalWhenFirstSet = 4191,
        [Description("Trap Damage Buildup Damage +% Final After 4 Seconds")]
        TrapDamageBuildupDamagePosPctFinalAfter4Seconds = 4192,
        [Description("Local Display Grants Level X Summon Stone Golem")]
        LocalDisplayGrantsLevelXSummonStoneGolem = 4193,
        [Description("Global Total Minimum Added Physical Damage")]
        GlobalTotalMinimumAddedPhysicalDamage = 4194,
        [Description("Global Total Maximum Added Physical Damage")]
        GlobalTotalMaximumAddedPhysicalDamage = 4195,
        [Description("Local Flask Immune To Damage")]
        LocalFlaskImmuneToDamage = 4196,
        [Description("Local Weapon Always Crit")]
        LocalWeaponAlwaysCrit = 4197,
        [Description("Main Hand Weapon Always Crit")]
        MainHandWeaponAlwaysCrit = 4198,
        [Description("Off Hand Weapon Always Crit")]
        OffHandWeaponAlwaysCrit = 4199,
        [Description("Trap And Mine Minimum Added Physical Damage")]
        TrapAndMineMinimumAddedPhysicalDamage = 4200,
        [Description("Trap And Mine Maximum Added Physical Damage")]
        TrapAndMineMaximumAddedPhysicalDamage = 4201,
        [Description("Trap % Chance To Trigger Twice")]
        TrapPctChanceToTriggerTwice = 4202,
        [Description("Trap Has Triggered")]
        TrapHasTriggered = 4203,
        [Description("Physical Damage Over Time Per 10 Dexterity +%")]
        PhysicalDamageOverTimePer10DexterityPosPct = 4204,
        [Description("Bleed Duration Per 12 Intelligence +%")]
        BleedDurationPer12IntelligencePosPct = 4205,
        [Description("% Chance To Cause Bleeding Enemies To Flee On Hit")]
        PctChanceToCauseBleedingEnemiesToFleeOnHit = 4206,
        [Description("Labyrinth Trinket Permanently Disable Statue Healing")]
        LabyrinthTrinketPermanentlyDisableStatueHealing = 4207,
        [Description("Labyrinth Trinket Instantly Kill Next Pedestal")]
        LabyrinthTrinketInstantlyKillNextPedestal = 4208,
        [Description("Labyrinth Trinket Instantly Kill Next Portal")]
        LabyrinthTrinketInstantlyKillNextPortal = 4209,
        [Description("Number Of Perandus Coin Stacks To Drop")]
        NumberOfPerandusCoinStacksToDrop = 4210,
        [Description("Melee Ancestor Totem Grant Owner Attack Speed +% Final")]
        MeleeAncestorTotemGrantOwnerAttackSpeedPosPctFinal = 4211,
        [Description("Gain Cannot Be Stunned Aura For 4 Seconds On Block Radius")]
        GainCannotBeStunnedAuraFor4SecondsOnBlockRadius = 4212,
        [Description("Cleave Radius +%")]
        CleaveRadiusPosPct = 4213,
        [Description("Ground Slam Radius +%")]
        GroundSlamRadiusPosPct = 4214,
        [Description("Infernal Blow Radius +%")]
        InfernalBlowRadiusPosPct = 4215,
        [Description("Lightning Tendrils Radius +%")]
        LightningTendrilsRadiusPosPct = 4216,
        [Description("Magma Orb Radius +%")]
        MagmaOrbRadiusPosPct = 4217,
        [Description("Reave Radius +%")]
        ReaveRadiusPosPct = 4218,
        [Description("Molten Strike Radius +%")]
        MoltenStrikeRadiusPosPct = 4219,
        [Description("Ice Shot Radius +%")]
        IceShotRadiusPosPct = 4220,
        [Description("Rain Of Arrows Radius +%")]
        RainOfArrowsRadiusPosPct = 4221,
        [Description("Leap Slam Radius +%")]
        LeapSlamRadiusPosPct = 4222,
        [Description("Lightning Arrow Radius +%")]
        LightningArrowRadiusPosPct = 4223,
        [Description("Ice Nova Radius +%")]
        IceNovaRadiusPosPct = 4224,
        [Description("Static Strike Radius +%")]
        StaticStrikeRadiusPosPct = 4225,
        [Description("Storm Call Radius +%")]
        StormCallRadiusPosPct = 4226,
        [Description("Sweep Radius +%")]
        SweepRadiusPosPct = 4227,
        [Description("Righteous Fire Radius +%")]
        RighteousFireRadiusPosPct = 4228,
        [Description("Arctic Breath Radius +%")]
        ArcticBreathRadiusPosPct = 4229,
        [Description("Ball Lightning Radius +%")]
        BallLightningRadiusPosPct = 4230,
        [Description("Explosive Arrow Radius +%")]
        ExplosiveArrowRadiusPosPct = 4231,
        [Description("Flameblast Radius +%")]
        FlameblastRadiusPosPct = 4232,
        [Description("Glacial Cascade Radius +%")]
        GlacialCascadeRadiusPosPct = 4233,
        [Description("Wild Strike Radius +%")]
        WildStrikeRadiusPosPct = 4234,
        [Description("Detonate Dead Radius +%")]
        DetonateDeadRadiusPosPct = 4235,
        [Description("Ice Crash Radius +%")]
        IceCrashRadiusPosPct = 4236,
        [Description("Kinetic Blast Radius +%")]
        KineticBlastRadiusPosPct = 4237,
        [Description("Caustic Arrow Radius +%")]
        CausticArrowRadiusPosPct = 4238,
        [Description("Cold Snap Radius +%")]
        ColdSnapRadiusPosPct = 4239,
        [Description("Decoy Totem Radius +%")]
        DecoyTotemRadiusPosPct = 4240,
        [Description("Shock Nova Radius +%")]
        ShockNovaRadiusPosPct = 4241,
        [Description("Shockwave Totem Radius +%")]
        ShockwaveTotemRadiusPosPct = 4242,
        [Description("Cleave Attack Speed +%")]
        CleaveAttackSpeedPosPct = 4243,
        [Description("Double Strike Attack Speed +%")]
        DoubleStrikeAttackSpeedPosPct = 4244,
        [Description("Dual Strike Attack Speed +%")]
        DualStrikeAttackSpeedPosPct = 4245,
        [Description("Heavy Strike Attack Speed +%")]
        HeavyStrikeAttackSpeedPosPct = 4246,
        [Description("Zombie Attack Speed +%")]
        ZombieAttackSpeedPosPct = 4247,
        [Description("Rain Of Arrows Attack Speed +%")]
        RainOfArrowsAttackSpeedPosPct = 4248,
        [Description("Leap Slam Attack Speed +%")]
        LeapSlamAttackSpeedPosPct = 4249,
        [Description("Shield Charge Attack Speed +%")]
        ShieldChargeAttackSpeedPosPct = 4250,
        [Description("Barrage Attack Speed +%")]
        BarrageAttackSpeedPosPct = 4251,
        [Description("Elemental Hit Attack Speed +%")]
        ElementalHitAttackSpeedPosPct = 4252,
        [Description("Cyclone Attack Speed +%")]
        CycloneAttackSpeedPosPct = 4253,
        [Description("Power Siphon Attack Speed +%")]
        PowerSiphonAttackSpeedPosPct = 4254,
        [Description("Spectre Attack And Cast Speed +%")]
        SpectreAttackAndCastSpeedPosPct = 4255,
        [Description("Freezing Pulse Cast Speed +%")]
        FreezingPulseCastSpeedPosPct = 4256,
        [Description("Fireball Cast Speed +%")]
        FireballCastSpeedPosPct = 4257,
        [Description("Fire Nova Mine Cast Speed +%")]
        FireNovaMineCastSpeedPosPct = 4258,
        [Description("Lightning Warp Cast Speed +%")]
        LightningWarpCastSpeedPosPct = 4259,
        [Description("Fire Trap Cooldown Speed +%")]
        FireTrapCooldownSpeedPosPct = 4260,
        [Description("Flicker Strike Cooldown Speed +%")]
        FlickerStrikeCooldownSpeedPosPct = 4261,
        [Description("Cold Snap Cooldown Speed +%")]
        ColdSnapCooldownSpeedPosPct = 4262,
        [Description("Ball Lightning Projectile Speed +%")]
        BallLightningProjectileSpeedPosPct = 4263,
        [Description("Freezing Pulse Projectile Speed +%")]
        FreezingPulseProjectileSpeedPosPct = 4264,
        [Description("Spark Projectile Speed +%")]
        SparkProjectileSpeedPosPct = 4265,
        [Description("Spectral Throw Projectile Speed +%")]
        SpectralThrowProjectileSpeedPosPct = 4266,
        [Description("Ethereal Knives Projectile Speed +%")]
        EtherealKnivesProjectileSpeedPosPct = 4267,
        [Description("Flame Totem Projectile Speed +%")]
        FlameTotemProjectileSpeedPosPct = 4268,
        [Description("Incinerate Projectile Speed +%")]
        IncinerateProjectileSpeedPosPct = 4269,
        [Description("Dominating Blow Duration +%")]
        DominatingBlowDurationPosPct = 4270,
        [Description("Puncture Duration +%")]
        PunctureDurationPosPct = 4271,
        [Description("Viper Strike Poison Duration +%")]
        ViperStrikePoisonDurationPosPct = 4272,
        [Description("Firestorm Duration +%")]
        FirestormDurationPosPct = 4273,
        [Description("Static Strike Duration +%")]
        StaticStrikeDurationPosPct = 4274,
        [Description("Storm Call Duration +%")]
        StormCallDurationPosPct = 4275,
        [Description("Arctic Breath Duration +%")]
        ArcticBreathDurationPosPct = 4276,
        [Description("Lightning Warp Duration +%")]
        LightningWarpDurationPosPct = 4277,
        [Description("Ice Shot Duration +%")]
        IceShotDurationPosPct = 4278,
        [Description("Caustic Arrow Duration +%")]
        CausticArrowDurationPosPct = 4279,
        [Description("Double Strike Critical Strike Chance +%")]
        DoubleStrikeCriticalStrikeChancePosPct = 4280,
        [Description("Dual Strike Critical Strike Chance +%")]
        DualStrikeCriticalStrikeChancePosPct = 4281,
        [Description("Split Arrow Critical Strike Chance +%")]
        SplitArrowCriticalStrikeChancePosPct = 4282,
        [Description("Viper Strike Critical Strike Chance +%")]
        ViperStrikeCriticalStrikeChancePosPct = 4283,
        [Description("Flameblast Critical Strike Chance +%")]
        FlameblastCriticalStrikeChancePosPct = 4284,
        [Description("Flame Surge Critical Strike Chance +%")]
        FlameSurgeCriticalStrikeChancePosPct = 4285,
        [Description("Tornado Shot Critical Strike Chance +%")]
        TornadoShotCriticalStrikeChancePosPct = 4286,
        [Description("Lightning Strike Num Of Additional Projectiles")]
        LightningStrikeNumOfAdditionalProjectiles = 4287,
        [Description("Molten Strike Num Of Additional Projectiles")]
        MoltenStrikeNumOfAdditionalProjectiles = 4288,
        [Description("Spark Num Of Additional Projectiles")]
        SparkNumOfAdditionalProjectiles = 4289,
        [Description("Split Arrow Num Of Additional Projectiles")]
        SplitArrowNumOfAdditionalProjectiles = 4290,
        [Description("Barrage Num Of Additional Projectiles")]
        BarrageNumOfAdditionalProjectiles = 4291,
        [Description("Tornado Shot Num Of Secondary Projectiles")]
        TornadoShotNumOfSecondaryProjectiles = 4292,
        [Description("Magma Orb Num Of Additional Projectiles In Chain")]
        MagmaOrbNumOfAdditionalProjectilesInChain = 4293,
        [Description("Arc Num Of Additional Projectiles In Chain")]
        ArcNumOfAdditionalProjectilesInChain = 4294,
        [Description("Flame Totem Num Of Additional Projectiles")]
        FlameTotemNumOfAdditionalProjectiles = 4295,
        [Description("Burning Arrow Ignite Chance %")]
        BurningArrowIgniteChancePct = 4296,
        [Description("Burning Arrow Physical Damage % To Add As Fire Damage")]
        BurningArrowPhysicalDamagePctToAddAsFireDamage = 4297,
        [Description("Infernal Blow Physical Damage % To Add As Fire Damage")]
        InfernalBlowPhysicalDamagePctToAddAsFireDamage = 4298,
        [Description("Fire Trap Burning Damage +%")]
        FireTrapBurningDamagePosPct = 4299,
        [Description("Fireball Ignite Chance %")]
        FireballIgniteChancePct = 4300,
        [Description("Glacial Hammer Freeze Chance %")]
        GlacialHammerFreezeChancePct = 4301,
        [Description("Ice Nova Freeze Chance %")]
        IceNovaFreezeChancePct = 4302,
        [Description("Reave Attack Speed Per Reave Stack +%")]
        ReaveAttackSpeedPerReaveStackPosPct = 4303,
        [Description("Spectral Throw Projectile Deceleration +%")]
        SpectralThrowProjectileDecelerationPosPct = 4304,
        [Description("Flicker Strike Damage +% Per Frenzy Charge")]
        FlickerStrikeDamagePosPctPerFrenzyCharge = 4305,
        [Description("Puncture Maim On Hit % Chance")]
        PunctureMaimOnHitPctChance = 4306,
        [Description("Arc Shock Chance %")]
        ArcShockChancePct = 4307,
        [Description("Fire Nova Mine Num Of Additional Repeats")]
        FireNovaMineNumOfAdditionalRepeats = 4308,
        [Description("Firestorm Explosion Area Of Effect +%")]
        FirestormExplosionAreaOfEffectPosPct = 4309,
        [Description("Flame Surge Damage +% Vs Burning Enemies")]
        FlameSurgeDamagePosPctVsBurningEnemies = 4310,
        [Description("Ice Spear % Chance To Gain Power Charge On Critical Strike")]
        IceSpearPctChanceToGainPowerChargeOnCriticalStrike = 4311,
        [Description("Power Siphon % Chance To Gain Power Charge On Kill")]
        PowerSiphonPctChanceToGainPowerChargeOnKill = 4312,
        [Description("Searing Bond Totem Placement Speed +%")]
        SearingBondTotemPlacementSpeedPosPct = 4313,
        [Description("Sweep Knockback Chance %")]
        SweepKnockbackChancePct = 4314,
        [Description("Frenzy Damage +% Per Frenzy Charge")]
        FrenzyDamagePosPctPerFrenzyCharge = 4315,
        [Description("Frenzy % Chance To Gain Additional Frenzy Charge")]
        FrenzyPctChanceToGainAdditionalFrenzyCharge = 4316,
        [Description("Elemental Hit Chance To Freeze Shock Ignite %")]
        ElementalHitChanceToFreezeShockIgnitePct = 4317,
        [Description("Glacial Cascade Physical Damage % To Convert To Cold")]
        GlacialCascadePhysicalDamagePctToConvertToCold = 4318,
        [Description("Glacial Hammer Physical Damage % To Add As Cold Damage")]
        GlacialHammerPhysicalDamagePctToAddAsColdDamage = 4319,
        [Description("Ice Crash Physical Damage % To Add As Cold Damage")]
        IceCrashPhysicalDamagePctToAddAsColdDamage = 4320,
        [Description("Spectre Elemental Resistances %")]
        SpectreElementalResistancesPct = 4321,
        [Description("Zombie Elemental Resistances %")]
        ZombieElementalResistancesPct = 4322,
        [Description("Flame Golem Elemental Resistances %")]
        FlameGolemElementalResistancesPct = 4323,
        [Description("Chaos Golem Elemental Resistances %")]
        ChaosGolemElementalResistancesPct = 4324,
        [Description("Ice Golem Elemental Resistances %")]
        IceGolemElementalResistancesPct = 4325,
        [Description("Shock Nova Ring Damage +%")]
        ShockNovaRingDamagePosPct = 4326,
        [Description("Detonate Dead % Chance To Detonate Additional Corpse")]
        DetonateDeadPctChanceToDetonateAdditionalCorpse = 4327,
        [Description("Animate Weapon Chance To Create Additional Copy %")]
        AnimateWeaponChanceToCreateAdditionalCopyPct = 4328,
        [Description("Decoy Totem Life +%")]
        DecoyTotemLifePosPct = 4329,
        [Description("Devouring Totem Leech Per Second +%")]
        DevouringTotemLeechPerSecondPosPct = 4330,
        [Description("Rejuvenation Totem % Life Regeneration Added As Mana Regeneration")]
        RejuvenationTotemPctLifeRegenerationAddedAsManaRegeneration = 4331,
        [Description("Rejuvenation Totem Aura Effect +%")]
        RejuvenationTotemAuraEffectPosPct = 4332,
        [Description("Summon Skeletons Num Additional Warrior Skeletons")]
        SummonSkeletonsNumAdditionalWarriorSkeletons = 4333,
        [Description("Wild Strike Num Of Additional Projectiles In Chain")]
        WildStrikeNumOfAdditionalProjectilesInChain = 4334,
        [Description("Shockwave Totem Cast Speed +%")]
        ShockwaveTotemCastSpeedPosPct = 4335,
        [Description("Devouring Totem % Chance To Consume Additional Corpse")]
        DevouringTotemPctChanceToConsumeAdditionalCorpse = 4336,
        [Description("Incinerate Damage +% Per Stage")]
        IncinerateDamagePosPctPerStage = 4337,
        [Description("Siege Ballista Totem Placement Speed +%")]
        SiegeBallistaTotemPlacementSpeedPosPct = 4338,
        [Description("Virtual Curse Effect +%")]
        VirtualCurseEffectPosPct = 4339,
        [Description("Poachers Mark Curse Effect +%")]
        PoachersMarkCurseEffectPosPct = 4340,
        [Description("Projectile Weakness Curse Effect +%")]
        ProjectileWeaknessCurseEffectPosPct = 4341,
        [Description("Temporal Chains Curse Effect +%")]
        TemporalChainsCurseEffectPosPct = 4342,
        [Description("Assassins Mark Curse Effect +%")]
        AssassinsMarkCurseEffectPosPct = 4343,
        [Description("Conductivity Curse Effect +%")]
        ConductivityCurseEffectPosPct = 4344,
        [Description("Elemental Weakness Curse Effect +%")]
        ElementalWeaknessCurseEffectPosPct = 4345,
        [Description("Enfeeble Curse Effect +%")]
        EnfeebleCurseEffectPosPct = 4346,
        [Description("Flammability Curse Effect +%")]
        FlammabilityCurseEffectPosPct = 4347,
        [Description("Frostbite Curse Effect +%")]
        FrostbiteCurseEffectPosPct = 4348,
        [Description("Punishment Curse Effect +%")]
        PunishmentCurseEffectPosPct = 4349,
        [Description("Vulnerability Curse Effect +%")]
        VulnerabilityCurseEffectPosPct = 4350,
        [Description("Warlords Mark Curse Effect +%")]
        WarlordsMarkCurseEffectPosPct = 4351,
        [Description("Lightning Golem Grants Attack And Cast Speed +%")]
        LightningGolemGrantsAttackAndCastSpeedPosPct = 4352,
        [Description("Lightning Golem Grants Added Lightning Damage")]
        LightningGolemGrantsAddedLightningDamage = 4353,
        [Description("Arctic Armour Mana Reservation +%")]
        ArcticArmourManaReservationPosPct = 4354,
        [Description("Herald Of Ash Mana Reservation +%")]
        HeraldOfAshManaReservationPosPct = 4355,
        [Description("Herald Of Ice Mana Reservation +%")]
        HeraldOfIceManaReservationPosPct = 4356,
        [Description("Herald Of Thunder Mana Reservation +%")]
        HeraldOfThunderManaReservationPosPct = 4357,
        [Description("Clarity Mana Reservation +%")]
        ClarityManaReservationPosPct = 4358,
        [Description("Hatred Mana Reservation +%")]
        HatredManaReservationPosPct = 4359,
        [Description("Purity Of Ice Mana Reservation +%")]
        PurityOfIceManaReservationPosPct = 4360,
        [Description("Determination Mana Reservation +%")]
        DeterminationManaReservationPosPct = 4361,
        [Description("Discipline Mana Reservation +%")]
        DisciplineManaReservationPosPct = 4362,
        [Description("Purity Of Elements Mana Reservation +%")]
        PurityOfElementsManaReservationPosPct = 4363,
        [Description("Purity Of Fire Mana Reservation +%")]
        PurityOfFireManaReservationPosPct = 4364,
        [Description("Purity Of Lightning Mana Reservation +%")]
        PurityOfLightningManaReservationPosPct = 4365,
        [Description("Vitality Mana Reservation +%")]
        VitalityManaReservationPosPct = 4366,
        [Description("Wrath Mana Reservation +%")]
        WrathManaReservationPosPct = 4367,
        [Description("Grace Mana Reservation +%")]
        GraceManaReservationPosPct = 4368,
        [Description("Haste Mana Reservation +%")]
        HasteManaReservationPosPct = 4369,
        [Description("Immortal Call Duration +%")]
        ImmortalCallDurationPosPct = 4370,
        [Description("Bone Offering Duration +%")]
        BoneOfferingDurationPosPct = 4371,
        [Description("Flesh Offering Duration +%")]
        FleshOfferingDurationPosPct = 4372,
        [Description("Smoke Mine Duration +%")]
        SmokeMineDurationPosPct = 4373,
        [Description("Frost Wall Duration +%")]
        FrostWallDurationPosPct = 4374,
        [Description("Vigilant Strike Fortify Duration +%")]
        VigilantStrikeFortifyDurationPosPct = 4375,
        [Description("Poachers Mark Duration +%")]
        PoachersMarkDurationPosPct = 4376,
        [Description("Projectile Weakness Duration +%")]
        ProjectileWeaknessDurationPosPct = 4377,
        [Description("Temporal Chains Duration +%")]
        TemporalChainsDurationPosPct = 4378,
        [Description("Warlords Mark Duration +%")]
        WarlordsMarkDurationPosPct = 4379,
        [Description("Vulnerability Duration +%")]
        VulnerabilityDurationPosPct = 4380,
        [Description("Punishment Duration +%")]
        PunishmentDurationPosPct = 4381,
        [Description("Frostbite Duration +%")]
        FrostbiteDurationPosPct = 4382,
        [Description("Flammability Duration +%")]
        FlammabilityDurationPosPct = 4383,
        [Description("Enfeeble Duration +%")]
        EnfeebleDurationPosPct = 4384,
        [Description("Elemental Weakness Duration +%")]
        ElementalWeaknessDurationPosPct = 4385,
        [Description("Conductivity Duration +%")]
        ConductivityDurationPosPct = 4386,
        [Description("Assassins Mark Duration +%")]
        AssassinsMarkDurationPosPct = 4387,
        [Description("Rallying Cry Duration +%")]
        RallyingCryDurationPosPct = 4388,
        [Description("Abyssal Cry Duration +%")]
        AbyssalCryDurationPosPct = 4389,
        [Description("Contagion Duration +%")]
        ContagionDurationPosPct = 4390,
        [Description("Siphon Duration +%")]
        SiphonDurationPosPct = 4391,
        [Description("Wither Duration +%")]
        WitherDurationPosPct = 4392,
        [Description("Blade Vortex Duration +%")]
        BladeVortexDurationPosPct = 4393,
        [Description("Earthquake Duration +%")]
        EarthquakeDurationPosPct = 4394,
        [Description("Blight Duration +%")]
        BlightDurationPosPct = 4395,
        [Description("Blight Secondary Skill Effect Duration +%")]
        BlightSecondarySkillEffectDurationPosPct = 4396,
        [Description("Convocation Cooldown Speed +%")]
        ConvocationCooldownSpeedPosPct = 4397,
        [Description("Bear Trap Cooldown Speed +%")]
        BearTrapCooldownSpeedPosPct = 4398,
        [Description("Frost Wall Cooldown Speed +%")]
        FrostWallCooldownSpeedPosPct = 4399,
        [Description("Reckoning Cooldown Speed +%")]
        ReckoningCooldownSpeedPosPct = 4400,
        [Description("Flame Dash Cooldown Speed +%")]
        FlameDashCooldownSpeedPosPct = 4401,
        [Description("Desecrate Cooldown Speed +%")]
        DesecrateCooldownSpeedPosPct = 4402,
        [Description("Blink Arrow Cooldown Speed +%")]
        BlinkArrowCooldownSpeedPosPct = 4403,
        [Description("Mirror Arrow Cooldown Speed +%")]
        MirrorArrowCooldownSpeedPosPct = 4404,
        [Description("Riposte Cooldown Speed +%")]
        RiposteCooldownSpeedPosPct = 4405,
        [Description("Vengeance Cooldown Speed +%")]
        VengeanceCooldownSpeedPosPct = 4406,
        [Description("Enduring Cry Cooldown Speed +%")]
        EnduringCryCooldownSpeedPosPct = 4407,
        [Description("Frost Bomb Cooldown Speed +%")]
        FrostBombCooldownSpeedPosPct = 4408,
        [Description("Conversion Trap Cooldown Speed +%")]
        ConversionTrapCooldownSpeedPosPct = 4409,
        [Description("Ice Trap Cooldown Speed +%")]
        IceTrapCooldownSpeedPosPct = 4410,
        [Description("Siege Ballista Attack Speed +%")]
        SiegeBallistaAttackSpeedPosPct = 4411,
        [Description("Shockwave Slam Attack Speed +%")]
        ShockwaveSlamAttackSpeedPosPct = 4412,
        [Description("Mirror Arrow And Mirror Arrow Clone Attack Speed +%")]
        MirrorArrowAndMirrorArrowCloneAttackSpeedPosPct = 4413,
        [Description("Freeze Mine Radius +%")]
        FreezeMineRadiusPosPct = 4414,
        [Description("Shrapnel Shot Radius +%")]
        ShrapnelShotRadiusPosPct = 4415,
        [Description("Blast Rain Radius +%")]
        BlastRainRadiusPosPct = 4416,
        [Description("Contagion Radius +%")]
        ContagionRadiusPosPct = 4417,
        [Description("Wither Radius +%")]
        WitherRadiusPosPct = 4418,
        [Description("Blade Vortex Radius +%")]
        BladeVortexRadiusPosPct = 4419,
        [Description("Bladefall Radius +%")]
        BladefallRadiusPosPct = 4420,
        [Description("Ice Trap Radius +%")]
        IceTrapRadiusPosPct = 4421,
        [Description("Earthquake Radius +%")]
        EarthquakeRadiusPosPct = 4422,
        [Description("Frost Bomb Radius +%")]
        FrostBombRadiusPosPct = 4423,
        [Description("Storm Cloud Radius +%")]
        StormCloudRadiusPosPct = 4424,
        [Description("Blight Radius +%")]
        BlightRadiusPosPct = 4425,
        [Description("Shockwave Slam Radius +%")]
        ShockwaveSlamRadiusPosPct = 4426,
        [Description("Display Attack With Decree Of Ire When Hit %")]
        DisplayAttackWithDecreeOfIreWhenHitPct = 4427,
        [Description("Display Attack With Commandment Of Ire When Hit %")]
        DisplayAttackWithCommandmentOfIreWhenHitPct = 4428,
        [Description("Blink Arrow And Blink Arrow Clone Attack Speed +%")]
        BlinkArrowAndBlinkArrowCloneAttackSpeedPosPct = 4429,
        [Description("Whirling Blades Attack Speed +%")]
        WhirlingBladesAttackSpeedPosPct = 4430,
        [Description("Arctic Armour Buff Effect +%")]
        ArcticArmourBuffEffectPosPct = 4431,
        [Description("Immortal Call % Chance To Not Consume Endurance Charges")]
        ImmortalCallPctChanceToNotConsumeEnduranceCharges = 4432,
        [Description("Phase Run % Chance To Not Consume Frenzy Charges")]
        PhaseRunPctChanceToNotConsumeFrenzyCharges = 4433,
        [Description("Animate Guardian Elemental Resistances %")]
        AnimateGuardianElementalResistancesPct = 4434,
        [Description("Shrapnel Shot Physical Damage % To Add As Lightning Damage")]
        ShrapnelShotPhysicalDamagePctToAddAsLightningDamage = 4435,
        [Description("Bladefall Critical Strike Chance +%")]
        BladefallCriticalStrikeChancePosPct = 4436,
        [Description("Storm Cloud Critical Strike Chance +%")]
        StormCloudCriticalStrikeChancePosPct = 4437,
        [Description("Tempest Shield Num Of Additional Projectiles In Chain")]
        TempestShieldNumOfAdditionalProjectilesInChain = 4438,
        [Description("Map Labyrinth Secret1 Override")]
        MapLabyrinthSecret1Override = 4439,
        [Description("Map Labyrinth Secret2 Override")]
        MapLabyrinthSecret2Override = 4440,
        [Description("Melee Ancestor Totem Granted Attack Speed +% Final")]
        MeleeAncestorTotemGrantedAttackSpeedPosPctFinal = 4441,
        [Description("Cannot Be Stunned While At Max Endurance Charges")]
        CannotBeStunnedWhileAtMaxEnduranceCharges = 4442,
        [Description("Life Regenerate Rate Per Second % While Totem Active")]
        LifeRegenerateRatePerSecondPctWhileTotemActive = 4443,
        [Description("Gain Attack And Cast Speed +% For 4 Seconds If Taken Savage Hit")]
        GainAttackAndCastSpeedPosPctFor4SecondsIfTakenSavageHit = 4444,
        [Description("Berserker Damage +% Final")]
        BerserkerDamagePosPctFinal = 4445,
        [Description("Elemental Damage Taken +% While On Consecrated Ground")]
        ElementalDamageTakenPosPctWhileOnConsecratedGround = 4446,
        [Description("Critical Strike Chance +% Vs Enemies With Elemental Status Ailments")]
        CriticalStrikeChancePosPctVsEnemiesWithElementalStatusAilments = 4447,
        [Description("Scion Helmet Skill Maximum Totems +")]
        ScionHelmetSkillMaximumTotemsPos = 4448,
        [Description("% Chance To Gain Power Charge On Placing A Totem")]
        PctChanceToGainPowerChargeOnPlacingATotem = 4449,
        [Description("Attack And Cast Speed +% For You And Allies Affected By Your Auras")]
        AttackAndCastSpeedPosPctForYouAndAlliesAffectedByYourAuras = 4450,
        [Description("Gain Elemental Conflux For X Ms When You Kill A Rare Or Unique Enemy")]
        GainElementalConfluxForXMsWhenYouKillARareOrUniqueEnemy = 4451,
        [Description("Enemies Chaos Resistance % While Cursed")]
        EnemiesChaosResistancePctWhileCursed = 4452,
        [Description("Damage +% For 4 Seconds When You Kill A Cursed Enemy")]
        DamagePosPctFor4SecondsWhenYouKillACursedEnemy = 4453,
        [Description("Physical Damage Reduction And Minion Physical Damage Reduction %")]
        PhysicalDamageReductionAndMinionPhysicalDamageReductionPct = 4454,
        [Description("Offering Spells Effect +%")]
        OfferingSpellsEffectPosPct = 4455,
        [Description("Damage +% For You And Allies Affected By Your Auras")]
        DamagePosPctForYouAndAlliesAffectedByYourAuras = 4456,
        [Description("You And Minion Attack And Cast Speed +% For 4 Seconds When Corpse Destroyed")]
        YouAndMinionAttackAndCastSpeedPosPctFor4SecondsWhenCorpseDestroyed = 4457,
        [Description("% Chance To Gain Power Charge On Hit Against Enemies On Full Life")]
        PctChanceToGainPowerChargeOnHitAgainstEnemiesOnFullLife = 4458,
        [Description("Cause Maim On Critical Strike Attack")]
        CauseMaimOnCriticalStrikeAttack = 4459,
        [Description("% Chance To Create Smoke Cloud On Mine Or Trap Creation")]
        PctChanceToCreateSmokeCloudOnMineOrTrapCreation = 4460,
        [Description("Damage +% For Each Trap And Mine Active")]
        DamagePosPctForEachTrapAndMineActive = 4461,
        [Description("Evasion Rating While Es Full +% Final")]
        EvasionRatingWhileEsFullPosPctFinal = 4462,
        [Description("Damage +% While Es Not Full")]
        DamagePosPctWhileEsNotFull = 4463,
        [Description("Mana Regeneration +% For 4 Seconds On Movement Skill Use")]
        ManaRegenerationPosPctFor4SecondsOnMovementSkillUse = 4464,
        [Description("Gain Onslaught While Frenzy Charges Full")]
        GainOnslaughtWhileFrenzyChargesFull = 4465,
        [Description("Projectile Damage +% Max As Distance Travelled Increases")]
        ProjectileDamagePosPctMaxAsDistanceTravelledIncreases = 4466,
        [Description("Damage +% During Flask Effect")]
        DamagePosPctDuringFlaskEffect = 4467,
        [Description("Avoid Freeze Shock Ignite Bleed % During Flask Effect")]
        AvoidFreezeShockIgniteBleedPctDuringFlaskEffect = 4468,
        [Description("Elemental Damage Taken +% During Flask Effect")]
        ElementalDamageTakenPosPctDuringFlaskEffect = 4469,
        [Description("Damage +% For 4 Seconds When You Kill A Bleeding Enemy")]
        DamagePosPctFor4SecondsWhenYouKillABleedingEnemy = 4470,
        [Description("Damage +% To You And Nearby Allies While You Have Fortify")]
        DamagePosPctToYouAndNearbyAlliesWhileYouHaveFortify = 4471,
        [Description("Damage Taken +% From Taunted Enemies")]
        DamageTakenPosPctFromTauntedEnemies = 4472,
        [Description("Attack And Cast Speed +% While Leeching")]
        AttackAndCastSpeedPosPctWhileLeeching = 4473,
        [Description("Base Avoid Bleed %")]
        BaseAvoidBleedPct = 4474,
        [Description("Avoid Bleed %")]
        AvoidBleedPct = 4475,
        [Description("Virtual Phase Through Objects")]
        VirtualPhaseThroughObjects = 4476,
        [Description("Virtual Has Onslaught")]
        VirtualHasOnslaught = 4477,
        [Description("Shield Charge Damage Per Target Hit +%")]
        ShieldChargeDamagePerTargetHitPosPct = 4478,
        [Description("Number Of Mines To Place")]
        NumberOfMinesToPlace = 4479,
        [Description("Local Flask Life Gain On Skill Use % Mana Cost")]
        LocalFlaskLifeGainOnSkillUsePctManaCost = 4480,
        [Description("Life Gain On Skill Use Percent Mana Cost")]
        LifeGainOnSkillUsePercentManaCost = 4481,
        [Description("Traps And Mines % Chance To Poison")]
        TrapsAndMinesPctChanceToPoison = 4482,
        [Description("Damage +% Of Each Type That You Have An Active Golem Of")]
        DamagePosPctOfEachTypeThatYouHaveAnActiveGolemOf = 4483,
        [Description("Elemental Golem Immunity To Elemental Damage")]
        ElementalGolemImmunityToElementalDamage = 4484,
        [Description("Elemental Golem Granted Buff Effect +%")]
        ElementalGolemGrantedBuffEffectPosPct = 4485,
        [Description("Current Number Of Fire Golems")]
        CurrentNumberOfFireGolems = 4486,
        [Description("Current Number Of Ice Golems")]
        CurrentNumberOfIceGolems = 4487,
        [Description("Current Number Of Lightning Golems")]
        CurrentNumberOfLightningGolems = 4488,
        [Description("Current Number Of Stone Golems")]
        CurrentNumberOfStoneGolems = 4489,
        [Description("Current Number Of Chaos Golems")]
        CurrentNumberOfChaosGolems = 4490,
        [Description("Base Cold Immunity")]
        BaseColdImmunity = 4491,
        [Description("Base Lightning Immunity")]
        BaseLightningImmunity = 4492,
        [Description("Gain Elemental Penetration For 4 Seconds On Mine Detonation")]
        GainElementalPenetrationFor4SecondsOnMineDetonation = 4493,
        [Description("Display Can Take Character Start Point")]
        DisplayCanTakeCharacterStartPoint = 4494,
        [Description("Fire Damage Immunity")]
        FireDamageImmunity = 4495,
        [Description("Cold Damage Immunity")]
        ColdDamageImmunity = 4496,
        [Description("Lightning Damage Immunity")]
        LightningDamageImmunity = 4497,
        [Description("Chaos Damage Immunity")]
        ChaosDamageImmunity = 4498,
        [Description("Elemental Damage Immunity")]
        ElementalDamageImmunity = 4499,
        [Description("Global Total Minimum Added Lightning Damage")]
        GlobalTotalMinimumAddedLightningDamage = 4500,
        [Description("Global Total Maximum Added Lightning Damage")]
        GlobalTotalMaximumAddedLightningDamage = 4501,
        [Description("Have Killed Recently")]
        HaveKilledRecently = 4502,
        [Description("Track Have Killed Recently")]
        TrackHaveKilledRecently = 4503,
        [Description("Number Of Times Have Been Hit Recently")]
        NumberOfTimesHaveBeenHitRecently = 4504,
        [Description("Track Have Been Hit Recently")]
        TrackHaveBeenHitRecently = 4505,
        [Description("Have Crit Recently")]
        HaveCritRecently = 4506,
        [Description("Track Have Crit Recently")]
        TrackHaveCritRecently = 4507,
        [Description("Base Body Armour Physical Damage Reduction Rating")]
        BaseBodyArmourPhysicalDamageReductionRating = 4508,
        [Description("Chance To Grant Power Charge To Nearby Allies On Kill %")]
        ChanceToGrantPowerChargeToNearbyAlliesOnKillPct = 4509,
        [Description("Chance To Grant Frenzy Charge To Nearby Allies On Hit %")]
        ChanceToGrantFrenzyChargeToNearbyAlliesOnHitPct = 4510,
        [Description("Blood Rage Grants Additional Attack Speed +%")]
        BloodRageGrantsAdditionalAttackSpeedPosPct = 4511,
        [Description("Blood Rage Grants Additional % Chance To Gain Frenzy On Kill")]
        BloodRageGrantsAdditionalPctChanceToGainFrenzyOnKill = 4512,
        [Description("Play Tempestuous Steel Sounds")]
        PlayTempestuousSteelSounds = 4513,
        [Description("From Totem Aura Damage +% Final")]
        FromTotemAuraDamagePosPctFinal = 4514,
        [Description("Explode Enemies For 25% Life As Chaos On Kill Chance %")]
        ExplodeEnemiesFor25PctLifeAsChaosOnKillChancePct = 4515,
        [Description("Explode Cursed Enemies For 25% Life As Chaos On Kill Chance %")]
        ExplodeCursedEnemiesFor25PctLifeAsChaosOnKillChancePct = 4516,
        [Description("Base Minion Duration +%")]
        BaseMinionDurationPosPct = 4517,
        [Description("Skill Specific Minion Duration +% Final")]
        SkillSpecificMinionDurationPosPctFinal = 4518,
        [Description("Base Chaos Golem Granted Buff Effect +%")]
        BaseChaosGolemGrantedBuffEffectPosPct = 4519,
        [Description("Base Stone Golem Granted Buff Effect +%")]
        BaseStoneGolemGrantedBuffEffectPosPct = 4520,
        [Description("Base Fire Golem Granted Buff Effect +%")]
        BaseFireGolemGrantedBuffEffectPosPct = 4521,
        [Description("Base Ice Golem Granted Buff Effect +%")]
        BaseIceGolemGrantedBuffEffectPosPct = 4522,
        [Description("Base Lightning Golem Granted Buff Effect +%")]
        BaseLightningGolemGrantedBuffEffectPosPct = 4523,
        [Description("Stone Golem Elemental Resistances %")]
        StoneGolemElementalResistancesPct = 4524,
        [Description("Dominating Blow Minion Damage +%")]
        DominatingBlowMinionDamagePosPct = 4525,
        [Description("Dominating Blow Skill Attack Damage +%")]
        DominatingBlowSkillAttackDamagePosPct = 4526,
        [Description("Lightning Golem Elemental Resistances %")]
        LightningGolemElementalResistancesPct = 4527,
        [Description("Lightning Golem Damage +%")]
        LightningGolemDamagePosPct = 4528,
        [Description("Is Hindered")]
        IsHindered = 4529,
        [Description("Damage +% Vs Hindered Enemies")]
        DamagePosPctVsHinderedEnemies = 4530,
        [Description("Blast Rain Number Of Blasts")]
        BlastRainNumberOfBlasts = 4531,
        [Description("Local Display Socketed Curse Gems Have Mana Reservation +%")]
        LocalDisplaySocketedCurseGemsHaveManaReservationPosPct = 4532,
        [Description("Bone Offering Block Chance +%")]
        BoneOfferingBlockChancePosPct = 4533,
        [Description("Map Number Of Explicit Mods")]
        MapNumberOfExplicitMods = 4534,
        [Description("Curse Orb Additional Height")]
        CurseOrbAdditionalHeight = 4535,
        [Description("Curse Orb Additional Radius")]
        CurseOrbAdditionalRadius = 4536,
        [Description("Phase Run Skill Effect Duration +%")]
        PhaseRunSkillEffectDurationPosPct = 4537,
        [Description("Lightning Tendrils Critical Strike Chance +%")]
        LightningTendrilsCriticalStrikeChancePosPct = 4538,
        [Description("Searing Totem Elemental Resistance +%")]
        SearingTotemElementalResistancePosPct = 4539,
        [Description("Flesh Offering Attack Speed +%")]
        FleshOfferingAttackSpeedPosPct = 4540,
        [Description("Smoke Mine Base Movement Velocity +%")]
        SmokeMineBaseMovementVelocityPosPct = 4541,
        [Description("Convocation Buff Effect +%")]
        ConvocationBuffEffectPosPct = 4542,
        [Description("Molten Shell Buff Effect +%")]
        MoltenShellBuffEffectPosPct = 4543,
        [Description("Enduring Cry Buff Effect +%")]
        EnduringCryBuffEffectPosPct = 4544,
        [Description("Righteous Fire Spell Damage +%")]
        RighteousFireSpellDamagePosPct = 4545,
        [Description("Rallying Cry Buff Effect +%")]
        RallyingCryBuffEffectPosPct = 4546,
        [Description("Attack Trigger When Critically Hit %")]
        AttackTriggerWhenCriticallyHitPct = 4547,
        [Description("Cast When Hit %")]
        CastWhenHitPct = 4548,
        [Description("Attack Trigger When Hit %")]
        AttackTriggerWhenHitPct = 4549,
        [Description("Attack Trigger On Kill %")]
        AttackTriggerOnKillPct = 4550,
        [Description("Decrement Parent Counter On Death")]
        DecrementParentCounterOnDeath = 4551,
        [Description("Minions Explode On Death For % Max Life At End Of Duration")]
        MinionsExplodeOnDeathForPctMaxLifeAtEndOfDuration = 4552,
        [Description("Explode On Death For % Max Life At End Of Duration")]
        ExplodeOnDeathForPctMaxLifeAtEndOfDuration = 4553,
        [Description("Melee Ancestor Totem Damage +%")]
        MeleeAncestorTotemDamagePosPct = 4554,
        [Description("Melee Ancestor Totem Placement Speed +%")]
        MeleeAncestorTotemPlacementSpeedPosPct = 4555,
        [Description("Melee Ancestor Totem Elemental Resistance %")]
        MeleeAncestorTotemElementalResistancePct = 4556,
        [Description("Blast Rain % Chance For Additional Blast")]
        BlastRainPctChanceForAdditionalBlast = 4557,
        [Description("Perandus Chest Revive Targeted Monster")]
        PerandusChestReviveTargetedMonster = 4558,
        [Description("Current Difficulty")]
        CurrentDifficulty = 4559,
        [Description("Base Fire Damage % Of Maximum Life Plus Maximum Es Taken Per Minute In Cruel")]
        BaseFireDamagePctOfMaximumLifePlusMaximumESTakenPerMinuteInCruel = 4560,
        [Description("Base Fire Damage % Of Maximum Life Plus Maximum Es Taken Per Minute In Merciless")]
        BaseFireDamagePctOfMaximumLifePlusMaximumESTakenPerMinuteInMerciless = 4561,
        [Description("Kinetic Blast % Chance For Additional Blast")]
        KineticBlastPctChanceForAdditionalBlast = 4562,
        [Description("Share Charges With Party Members In Aura")]
        ShareChargesWithPartyMembersInAura = 4563,
        [Description("Guardian Nearby Allies Share Charges")]
        GuardianNearbyAlliesShareCharges = 4564,
        [Description("Bleed Duration +%")]
        BleedDurationPosPct = 4565,
        [Description("Summoned Monsters Are Parented To My Parent")]
        SummonedMonstersAreParentedToMyParent = 4566,
        [Description("Monster Grants No Experience After X Revives")]
        MonsterGrantsNoExperienceAfterXRevives = 4567,
        [Description("Consecrate Ground On Shatter % Chance For 3 Seconds")]
        ConsecrateGroundOnShatterPctChanceFor3Seconds = 4568,
        [Description("Summoned Monsters Decrement Parent Counter")]
        SummonedMonstersDecrementParentCounter = 4569,
        [Description("Skill Buff Effect +%")]
        SkillBuffEffectPosPct = 4570,
        [Description("Glows In Area With Unique Fish")]
        GlowsInAreaWithUniqueFish = 4571,
        [Description("Local Display Summon Raging Spirit On Kill %")]
        LocalDisplaySummonRagingSpiritOnKillPct = 4572,
        [Description("Attacks Num Of Additional Chains")]
        AttacksNumOfAdditionalChains = 4573,
        [Description("Monster Do Not Give Soul To Soul Eater")]
        MonsterDoNotGiveSoulToSoulEater = 4574,
        [Description("Monster Grants No Flask Charges")]
        MonsterGrantsNoFlaskCharges = 4575,
        [Description("Used Teleports")]
        UsedTeleports = 4576,
        [Description("Explosive Arrow Attack Speed +%")]
        ExplosiveArrowAttackSpeedPosPct = 4577,
        [Description("Slam Ancestor Totem Grant Owner Melee Damage +% Final")]
        SlamAncestorTotemGrantOwnerMeleeDamagePosPctFinal = 4578,
        [Description("Slash Ancestor Totem Grant Owner Physical Damage Added As Fire +%")]
        SlashAncestorTotemGrantOwnerPhysicalDamageAddedAsFirePosPct = 4579,
        [Description("Slam Ancestor Totem Granted Melee Damage +% Final")]
        SlamAncestorTotemGrantedMeleeDamagePosPctFinal = 4580,
        [Description("Perandus Chest Spawned Bosses")]
        PerandusChestSpawnedBosses = 4581,
        [Description("Lightning Damage +% Per 10 Intelligence")]
        LightningDamagePosPctPer10Intelligence = 4582,
        [Description("Shield Charge Range +%")]
        ShieldChargeRangePosPct = 4583,
        [Description("Local Maim On Hit")]
        LocalMaimOnHit = 4584,
        [Description("Main Hand Maim On Hit")]
        MainHandMaimOnHit = 4585,
        [Description("Off Hand Maim On Hit")]
        OffHandMaimOnHit = 4586,
        [Description("Warcries Cost No Mana")]
        WarcriesCostNoMana = 4587,
        [Description("Is On Ground Maelstrom")]
        IsOnGroundMaelstrom = 4588,
        [Description("Gain A Power Charge When You Or Your Totems Kill % Chance")]
        GainAPowerChargeWhenYouOrYourTotemsKillPctChance = 4589,
        [Description("Give Parent Power Charge On Kill % Chance")]
        GiveParentPowerChargeOnKillPctChance = 4590,
        [Description("Buff Visuals Show While Hidden Override")]
        BuffVisualsShowWhileHiddenOverride = 4591,
        [Description("Always Pierce")]
        AlwaysPierce = 4592,
        [Description("Always Crit Shocked Enemies")]
        AlwaysCritShockedEnemies = 4593,
        [Description("Cannot Crit Non Shocked Enemies")]
        CannotCritNonShockedEnemies = 4594,
        [Description("Map Prophecy")]
        MapProphecy = 4595,
        [Description("Frost Bolt Damage +%")]
        FrostBoltDamagePosPct = 4596,
        [Description("Frost Bolt Nova Damage +%")]
        FrostBoltNovaDamagePosPct = 4597,
        [Description("Double Slash Damage +%")]
        DoubleSlashDamagePosPct = 4598,
        [Description("Charged Attack Damage +%")]
        ChargedAttackDamagePosPct = 4599,
        [Description("Slam Ancestor Totem Damage +%")]
        SlamAncestorTotemDamagePosPct = 4600,
        [Description("Slash Ancestor Totem Damage +%")]
        SlashAncestorTotemDamagePosPct = 4601,
        [Description("Slash Ancestor Totem Radius +%")]
        SlashAncestorTotemRadiusPosPct = 4602,
        [Description("Slam Ancestor Totem Radius +%")]
        SlamAncestorTotemRadiusPosPct = 4603,
        [Description("Frost Bolt Nova Radius +%")]
        FrostBoltNovaRadiusPosPct = 4604,
        [Description("Double Slash Critical Strike Chance +%")]
        DoubleSlashCriticalStrikeChancePosPct = 4605,
        [Description("Charged Attack Radius +%")]
        ChargedAttackRadiusPosPct = 4606,
        [Description("Double Slash Radius +%")]
        DoubleSlashRadiusPosPct = 4607,
        [Description("Charged Attack Damage Per Stack +% Final")]
        ChargedAttackDamagePerStackPosPctFinal = 4608,
        [Description("% Of Life And Energy Shield To Take As Damage On Using A Movement Skill")]
        PctOfLifeAndEnergyShieldToTakeAsDamageOnUsingAMovementSkill = 4609,
        [Description("Remove % Of Targets Current Flask Charges On Hit")]
        RemovePctOfTargetsCurrentFlaskChargesOnHit = 4610,
        [Description("Virtual Reduce Enemy Cold Resistance With Weapons %")]
        VirtualReduceEnemyColdResistanceWithWeaponsPct = 4611,
        [Description("Virtual Reduce Enemy Fire Resistance With Weapons %")]
        VirtualReduceEnemyFireResistanceWithWeaponsPct = 4612,
        [Description("Virtual Reduce Enemy Lightning Resistance With Weapons %")]
        VirtualReduceEnemyLightningResistanceWithWeaponsPct = 4613,
        [Description("Minions % Chance To Blind On Hit")]
        MinionsPctChanceToBlindOnHit = 4614,
        [Description("Minions Cannot Be Blinded")]
        MinionsCannotBeBlinded = 4615,
        [Description("Display Socketed Minion Gems Supported By Level X Life Leech")]
        DisplaySocketedMinionGemsSupportedByLevelXLifeLeech = 4616,
        [Description("Magic Items Drop Identified")]
        MagicItemsDropIdentified = 4617,
        [Description("Number Of Stackable Unique Jewels")]
        NumberOfStackableUniqueJewels = 4618,
        [Description("X Mana Per Stackable Unique Jewel")]
        XManaPerStackableUniqueJewel = 4619,
        [Description("X Armour Per Stackable Unique Jewel")]
        XArmourPerStackableUniqueJewel = 4620,
        [Description("Elemental Damage +% Per Stackable Unique Jewel")]
        ElementalDamagePosPctPerStackableUniqueJewel = 4621,
        [Description("Base Fire Damage % Of Maximum Life Plus Maximum Es Taken Per Minute In Normal")]
        BaseFireDamagePctOfMaximumLifePlusMaximumESTakenPerMinuteInNormal = 4622,
        [Description("Projectile Uses Contact Position")]
        ProjectileUsesContactPosition = 4623,
        [Description("Skeletal Chains Aoe % Health Dealt As Chaos Damage")]
        SkeletalChainsAoePctHealthDealtAsChaosDamage = 4624,
        [Description("Virtual Number Of Inca Minions Allowed")]
        VirtualNumberOfIncaMinionsAllowed = 4625,
        [Description("Virtual Number Of Insects Allowed")]
        VirtualNumberOfInsectsAllowed = 4626,
        [Description("Virtual Number Of Taniwha Tails Allowed")]
        VirtualNumberOfTaniwhaTailsAllowed = 4627,
        [Description("Virtual Number Of Wolves Allowed")]
        VirtualNumberOfWolvesAllowed = 4628,
        [Description("You Cannot Have Non Golem Minions")]
        YouCannotHaveNonGolemMinions = 4629,
        [Description("Lightning Damage % Taken From Mana Before Life")]
        LightningDamagePctTakenFromManaBeforeLife = 4630,
        [Description("Recover % Maximum Mana When Enemy Shocked")]
        RecoverPctMaximumManaWhenEnemyShocked = 4631,
        [Description("Ground Caustic Art Variation")]
        GroundCausticArtVariation = 4632,
        [Description("Global Life Leech From Physical Attack Damage Per Red Socket On Item Permyriad")]
        GlobalLifeLeechFromPhysicalAttackDamagePerRedSocketOnItemPermyriad = 4633,
        [Description("Spell Dodge Chance +% If You Have Taken Attack Damage Recently")]
        SpellDodgeChancePosPctIfYouHaveTakenAttackDamageRecently = 4634,
        [Description("Dodge Chance +% If You Have Taken Spell Damage Recently")]
        DodgeChancePosPctIfYouHaveTakenSpellDamageRecently = 4635,
        [Description("Quantity Of Items Dropped By Maimed Enemies +%")]
        QuantityOfItemsDroppedByMaimedEnemiesPosPct = 4636,
        [Description("Rarity Of Items Dropped By Maimed Enemies +%")]
        RarityOfItemsDroppedByMaimedEnemiesPosPct = 4637,
        [Description("Damage Taken +% If You Have Taken A Savage Hit Recently")]
        DamageTakenPosPctIfYouHaveTakenASavageHitRecently = 4638,
        [Description("Is Maimed")]
        IsMaimed = 4639,
        [Description("Track Have Been Savage Hit Recently")]
        TrackHaveBeenSavageHitRecently = 4640,
        [Description("Have Been Savage Hit Recently")]
        HaveBeenSavageHitRecently = 4641,
        [Description("Track Have Taken Attack Damage Recently")]
        TrackHaveTakenAttackDamageRecently = 4642,
        [Description("Have Taken Attack Damage Recently")]
        HaveTakenAttackDamageRecently = 4643,
        [Description("Track Have Taken Spell Damage Recently")]
        TrackHaveTakenSpellDamageRecently = 4644,
        [Description("Have Taken Spell Damage Recently")]
        HaveTakenSpellDamageRecently = 4645,
        [Description("Stun Duration On Self +%")]
        StunDurationOnSelfPosPct = 4646,
        [Description("Melee Damage +% Per Endurance Charge")]
        MeleeDamagePosPctPerEnduranceCharge = 4647,
        [Description("Totems Resist All Elements +% Per Active Totem")]
        TotemsResistAllElementsPosPctPerActiveTotem = 4648,
        [Description("Summon Your Maximum Number Of Totems In Formation")]
        SummonYourMaximumNumberOfTotemsInFormation = 4649,
        [Description("Gain Life Regeneration % Per Second For 1 Second If Taken Savage Hit")]
        GainLifeRegenerationPctPerSecondFor1SecondIfTakenSavageHit = 4650,
        [Description("Maximum Life % To Add As Maximum Energy Shield")]
        MaximumLifePctToAddAsMaximumEnergyShield = 4651,
        [Description("Total Base Maximum Life")]
        TotalBaseMaximumLife = 4652,
        [Description("Combined Life +%")]
        CombinedLifePosPct = 4653,
        [Description("Combined Life +% Final")]
        CombinedLifePosPctFinal = 4654,
        [Description("Cannot Be Shocked While At Maximum Endurance Charges")]
        CannotBeShockedWhileAtMaximumEnduranceCharges = 4655,
        [Description("Movement Speed +% If Used A Warcry Recently")]
        MovementSpeedPosPctIfUsedAWarcryRecently = 4656,
        [Description("Mana Leech From Attack Damage Permyriad Vs Poisoned Enemies")]
        ManaLeechFromAttackDamagePermyriadVsPoisonedEnemies = 4657,
        [Description("Have Used A Warcry Recently")]
        HaveUsedAWarcryRecently = 4658,
        [Description("Track Have Used A Warcry Recently")]
        TrackHaveUsedAWarcryRecently = 4659,
        [Description("Totems Spells Cast Speed +% Per Active Totem")]
        TotemsSpellsCastSpeedPosPctPerActiveTotem = 4660,
        [Description("Movement Skills Mana Cost +%")]
        MovementSkillsManaCostPosPct = 4661,
        [Description("Global Critical Strike Mulitplier + Per Green Socket On Item")]
        GlobalCriticalStrikeMulitplierPosPerGreenSocketOnItem = 4662,
        [Description("Additional Block Chance % When In Off Hand")]
        AdditionalBlockChancePctWhenInOffHand = 4663,
        [Description("Critical Strike Chance +% When In Main Hand")]
        CriticalStrikeChancePosPctWhenInMainHand = 4664,
        [Description("Spirit Offering Duration +%")]
        SpiritOfferingDurationPosPct = 4665,
        [Description("Spirit Offering Physical Damage % To Add As Chaos")]
        SpiritOfferingPhysicalDamagePctToAddAsChaos = 4666,
        [Description("Base Fire Damage % Of Maximum Life Taken Per Minute In Normal")]
        BaseFireDamagePctOfMaximumLifeTakenPerMinuteInNormal = 4667,
        [Description("Base Fire Damage % Of Maximum Es Taken Per Minute In Normal")]
        BaseFireDamagePctOfMaximumEsTakenPerMinuteInNormal = 4668,
        [Description("Base Fire Damage % Of Maximum Life Taken Per Minute In Cruel")]
        BaseFireDamagePctOfMaximumLifeTakenPerMinuteInCruel = 4669,
        [Description("Base Fire Damage % Of Maximum Es Taken Per Minute In Cruel")]
        BaseFireDamagePctOfMaximumEsTakenPerMinuteInCruel = 4670,
        [Description("Base Fire Damage % Of Maximum Life Taken Per Minute In Merciless")]
        BaseFireDamagePctOfMaximumLifeTakenPerMinuteInMerciless = 4671,
        [Description("Base Fire Damage % Of Maximum Es Taken Per Minute In Merciless")]
        BaseFireDamagePctOfMaximumEsTakenPerMinuteInMerciless = 4672,
        [Description("% Of Life To Deal As Damage")]
        PctOfLifeToDealAsDamage = 4673,
        [Description("% Of Es To Deal As Damage")]
        PctOfEsToDealAsDamage = 4674,
        [Description("% Of Life To Take As Damage On Using A Movement Skill")]
        PctOfLifeToTakeAsDamageOnUsingAMovementSkill = 4675,
        [Description("% Of Energy Shield To Take As Damage On Using A Movement Skill")]
        PctOfEnergyShieldToTakeAsDamageOnUsingAMovementSkill = 4676,
        [Description("% Of Life To Deal As Damage On Using A Movement Skill")]
        PctOfLifeToDealAsDamageOnUsingAMovementSkill = 4677,
        [Description("% Of Energy Shield To Deal As Damage On Using A Movement Skill")]
        PctOfEnergyShieldToDealAsDamageOnUsingAMovementSkill = 4678,
        [Description("Local Unique Overflowing Chalice Flask Cannot Gain Flask Charges During Flask Effect")]
        LocalUniqueOverflowingChaliceFlaskCannotGainFlaskChargesDuringFlaskEffect = 4679,
        [Description("Using Flask Overflowing Chalice")]
        UsingFlaskOverflowingChalice = 4680,
        [Description("Cannot Be Chained From")]
        CannotBeChainedFrom = 4681,
        [Description("Damage Taken +% If Not Hit Recently Final")]
        DamageTakenPosPctIfNotHitRecentlyFinal = 4682,
        [Description("Evasion +% If Hit Recently")]
        EvasionPosPctIfHitRecently = 4683,
        [Description("Cast Socketed Spells On X Mana Spent")]
        CastSocketedSpellsOnXManaSpent = 4684,
        [Description("Cast Socketed Spells On Mana Spent % Chance")]
        CastSocketedSpellsOnManaSpentPctChance = 4685,
        [Description("Block Chance % Vs Taunted Enemies")]
        BlockChancePctVsTauntedEnemies = 4686,
        [Description("Minion Cold Damage Resistance %")]
        MinionColdDamageResistancePct = 4687,
        [Description("Minion Physical Damage % To Add As Cold")]
        MinionPhysicalDamagePctToAddAsCold = 4688,
        [Description("Armour And Evasion Rating +% If Killed A Taunted Enemy Recently")]
        ArmourAndEvasionRatingPosPctIfKilledATauntedEnemyRecently = 4689,
        [Description("Have Killed A Taunted Enemy Recently")]
        HaveKilledATauntedEnemyRecently = 4690,
        [Description("Map Owner Master Exp Favour +%")]
        MapOwnerMasterExpFavourPosPct = 4691,
        [Description("Support Cast On Mana Spent")]
        SupportCastOnManaSpent = 4692,
        [Description("Num Of Additional Chains At Max Frenzy Charges")]
        NumOfAdditionalChainsAtMaxFrenzyCharges = 4693,
        [Description("Critical Strikes Do Not Always Freeze")]
        CriticalStrikesDoNotAlwaysFreeze = 4694,
        [Description("Damage +% For Each Level The Enemy Is Higher Than You")]
        DamagePosPctForEachLevelTheEnemyIsHigherThanYou = 4695,
        [Description("Local Unique Flask Charges Gained +% During Flask Effect")]
        LocalUniqueFlaskChargesGainedPosPctDuringFlaskEffect = 4696,
        [Description("Gain Phasing For 4 Seconds On Begin Es Recharge")]
        GainPhasingFor4SecondsOnBeginEsRecharge = 4697,
        [Description("Chance To Dodge Attacks % While Phasing")]
        ChanceToDodgeAttacksPctWhilePhasing = 4698,
        [Description("Item Found Rarity +% While Phasing")]
        ItemFoundRarityPosPctWhilePhasing = 4699,
        [Description("Hexproof")]
        Hexproof = 4700,
        [Description("Map Monsters Are Hexproof")]
        MapMonstersAreHexproof = 4701,
        [Description("Ignore Hexproof")]
        IgnoreHexproof = 4702,
        [Description("Totems Attack Speed +% Per Active Totem")]
        TotemsAttackSpeedPosPctPerActiveTotem = 4703,
        [Description("Attacks Num Of Additional Chains When In Main Hand")]
        AttacksNumOfAdditionalChainsWhenInMainHand = 4704,
        [Description("Attacks Number Of Additional Projectiles")]
        AttacksNumberOfAdditionalProjectiles = 4705,
        [Description("Attacks Number Of Additional Projectiles When In Off Hand")]
        AttacksNumberOfAdditionalProjectilesWhenInOffHand = 4706,
        [Description("Counter Attacks Minimum Added Physical Damage")]
        CounterAttacksMinimumAddedPhysicalDamage = 4707,
        [Description("Counter Attacks Maximum Added Physical Damage")]
        CounterAttacksMaximumAddedPhysicalDamage = 4708,
        [Description("Golem Damage +% Per Active Golem Type")]
        GolemDamagePosPctPerActiveGolemType = 4709,
        [Description("Life +% With No Corrupted Equipped Items")]
        LifePosPctWithNoCorruptedEquippedItems = 4710,
        [Description("Life Regeneration Per Minute With No Corrupted Equipped Items")]
        LifeRegenerationPerMinuteWithNoCorruptedEquippedItems = 4711,
        [Description("Energy Shield Recharge Rate Per Minute With All Corrupted Equipped Items")]
        EnergyShieldRechargeRatePerMinuteWithAllCorruptedEquippedItems = 4712,
        [Description("Local Display Nearby Enemies Take X Chaos Damage Per Minute")]
        LocalDisplayNearbyEnemiesTakeXChaosDamagePerMinute = 4713,
        [Description("Number Of Equipped Items")]
        NumberOfEquippedItems = 4714,
        [Description("Virtual Mana Leech From Any Damage Permyriad")]
        VirtualManaLeechFromAnyDamagePermyriad = 4715,
        [Description("Virtual Current Number Of Golem Types")]
        VirtualCurrentNumberOfGolemTypes = 4716,
        [Description("Local Display Socketed Skills Summon Your Maximum Number Of Totems In Formation")]
        LocalDisplaySocketedSkillsSummonYourMaximumNumberOfTotemsInFormation = 4717,
        [Description("Energy Shield Regeneration Rate Per Minute % While On Low Life")]
        EnergyShieldRegenerationRatePerMinutePctWhileOnLowLife = 4718,
        [Description("Counter Attacks Minimum Added Cold Damage")]
        CounterAttacksMinimumAddedColdDamage = 4719,
        [Description("Counter Attacks Maximum Added Cold Damage")]
        CounterAttacksMaximumAddedColdDamage = 4720,
        [Description("Movement Speed +% If Pierced Recently")]
        MovementSpeedPosPctIfPiercedRecently = 4721,
        [Description("Have Pierced Recently")]
        HavePiercedRecently = 4722,
        [Description("Track Have Pierced Recently")]
        TrackHavePiercedRecently = 4723,
        [Description("Item Found Quantity +% If Wearing A Magic Item")]
        ItemFoundQuantityPosPctIfWearingAMagicItem = 4724,
        [Description("Item Found Rarity +% If Wearing A Normal Item")]
        ItemFoundRarityPosPctIfWearingANormalItem = 4725,
        [Description("Number Of Equipped Normal Items")]
        NumberOfEquippedNormalItems = 4726,
        [Description("Poison Cursed Enemies On Hit")]
        PoisonCursedEnemiesOnHit = 4727,
        [Description("Base Fire Damage % To Convert To Chaos 60% Value")]
        BaseFireDamagePctToConvertToChaos60PctValue = 4728,
        [Description("Base Lightning Damage % To Convert To Chaos 60% Value")]
        BaseLightningDamagePctToConvertToChaos60PctValue = 4729,
        [Description("Gain Onslaught For X Ms On Killing Rare Or Unique Monster")]
        GainOnslaughtForXMsOnKillingRareOrUniqueMonster = 4730,
        [Description("Kill Enemy On Hit If Under 20% Life")]
        KillEnemyOnHitIfUnder20PctLife = 4731,
        [Description("Immune To Bleeding While Leeching")]
        ImmuneToBleedingWhileLeeching = 4732,
        [Description("Damage +% If Enemy Killed Recently Final")]
        DamagePosPctIfEnemyKilledRecentlyFinal = 4733,
        [Description("Skill Area Of Effect +% If Enemy Killed Recently")]
        SkillAreaOfEffectPosPctIfEnemyKilledRecently = 4734,
        [Description("Virtual Immune To Bleeding")]
        VirtualImmuneToBleeding = 4735,
        [Description("Have Killed A Maimed Enemy Recently")]
        HaveKilledAMaimedEnemyRecently = 4736,
        [Description("Track Have Killed A Maimed Enemy Recently")]
        TrackHaveKilledAMaimedEnemyRecently = 4737,
        [Description("Skill Effect Duration +% If Killed Maimed Enemy Recently")]
        SkillEffectDurationPosPctIfKilledMaimedEnemyRecently = 4738,
        [Description("Have Taunted An Enemy Recently")]
        HaveTauntedAnEnemyRecently = 4739,
        [Description("Track Have Taunted An Enemy Recently")]
        TrackHaveTauntedAnEnemyRecently = 4740,
        [Description("Damage Taken +% If Taunted An Enemy Recently")]
        DamageTakenPosPctIfTauntedAnEnemyRecently = 4741,
        [Description("Life Regeneration Rate Per Minute % If Taunted An Enemy Recently")]
        LifeRegenerationRatePerMinutePctIfTauntedAnEnemyRecently = 4742,
        [Description("Immune To Elemental Status Ailments During Flask Effect")]
        ImmuneToElementalStatusAilmentsDuringFlaskEffect = 4743,
        [Description("Elemental Damage +% During Flask Effect")]
        ElementalDamagePosPctDuringFlaskEffect = 4744,
        [Description("Chance To Freeze Shock Ignite % During Flask Effect")]
        ChanceToFreezeShockIgnitePctDuringFlaskEffect = 4745,
        [Description("Summoned Monster Types Arent Duplicated")]
        SummonedMonsterTypesArentDuplicated = 4746,
        [Description("Slash Ancestor Totem Elemental Resistance %")]
        SlashAncestorTotemElementalResistancePct = 4747,
        [Description("Melee Ancestor Totem Grant Owner Attack Speed +%")]
        MeleeAncestorTotemGrantOwnerAttackSpeedPosPct = 4748,
        [Description("Slam Ancestor Totem Grant Owner Melee Damage +%")]
        SlamAncestorTotemGrantOwnerMeleeDamagePosPct = 4749,
        [Description("Frost Bolt Cast Speed +%")]
        FrostBoltCastSpeedPosPct = 4750,
        [Description("Frost Bolt Freeze Chance %")]
        FrostBoltFreezeChancePct = 4751,
        [Description("Frost Bolt Nova Duration +%")]
        FrostBoltNovaDurationPosPct = 4752,
        [Description("Chest Drop Additional Fire Warband Uniques")]
        ChestDropAdditionalFireWarbandUniques = 4753,
        [Description("Chest Drop Additional Cold Warband Uniques")]
        ChestDropAdditionalColdWarbandUniques = 4754,
        [Description("Chest Drop Additional Lightning Warband Uniques")]
        ChestDropAdditionalLightningWarbandUniques = 4755,
        [Description("Chest Drop Additional Chaos Warband Uniques")]
        ChestDropAdditionalChaosWarbandUniques = 4756,
        [Description("Weapons Drop Animated")]
        WeaponsDropAnimated = 4757,
        [Description("Es And Mana Regeneration Rate Per Minute % While On Consecrated Ground")]
        EsAndManaRegenerationRatePerMinutePctWhileOnConsecratedGround = 4758,
        [Description("Attack And Cast Speed +% While On Consecrated Ground")]
        AttackAndCastSpeedPosPctWhileOnConsecratedGround = 4759,
        [Description("Chest Display Summons Fire Warband")]
        ChestDisplaySummonsFireWarband = 4760,
        [Description("Chest Display Summons Cold Warband")]
        ChestDisplaySummonsColdWarband = 4761,
        [Description("Chest Display Summons Lightning Warband")]
        ChestDisplaySummonsLightningWarband = 4762,
        [Description("Chest Display Summons Chaos Warband")]
        ChestDisplaySummonsChaosWarband = 4763,
        [Description("Is Dominated")]
        IsDominated = 4764,
        [Description("Blast Rain Arrow Delay Ms")]
        BlastRainArrowDelayMs = 4765,
        [Description("Additional Block Chance % For 1 Second Every 5 Seconds")]
        AdditionalBlockChancePctFor1SecondEvery5Seconds = 4766,
        [Description("Mine Arming Speed +%")]
        MineArmingSpeedPosPct = 4767,
        [Description("Flasks % Chance To Not Consume Charges")]
        FlasksPctChanceToNotConsumeCharges = 4768,
        [Description("Critical Strike Chance +% Vs Bleeding Enemies")]
        CriticalStrikeChancePosPctVsBleedingEnemies = 4769,
        [Description("Physical Damage +% For 4 Seconds When You Block A Unique Enemy Hit")]
        PhysicalDamagePosPctFor4SecondsWhenYouBlockAUniqueEnemyHit = 4770,
        [Description("Your Consecrated Ground Grants Damage +%")]
        YourConsecratedGroundGrantsDamagePosPct = 4771,
        [Description("Attack Speed +% If Enemy Not Killed Recently")]
        AttackSpeedPosPctIfEnemyNotKilledRecently = 4772,
        [Description("Physical Damage +% While At Maximum Frenzy Charges Final")]
        PhysicalDamagePosPctWhileAtMaximumFrenzyChargesFinal = 4773,
        [Description("Physical Damage Taken +% While At Maximum Endurance Charges")]
        PhysicalDamageTakenPosPctWhileAtMaximumEnduranceCharges = 4774,
        [Description("Totem Damage Leeched As Life To You Permyriad")]
        TotemDamageLeechedAsLifeToYouPermyriad = 4775,
        [Description("Damage Leeched As Life To Parent Permyriad")]
        DamageLeechedAsLifeToParentPermyriad = 4776,
        [Description("Attack Speed +% Per 200 Accuracy Rating")]
        AttackSpeedPosPctPer200AccuracyRating = 4777,
        [Description("Gain Phasing While At Maximum Frenzy Charges")]
        GainPhasingWhileAtMaximumFrenzyCharges = 4778,
        [Description("Gain Phasing While You Have Onslaught")]
        GainPhasingWhileYouHaveOnslaught = 4779,
        [Description("Gain Maximum Endurance Charges On Endurance Charge Gained % Chance")]
        GainMaximumEnduranceChargesOnEnduranceChargeGainedPctChance = 4780,
        [Description("Elementalist Skill Area Of Effect +% For 4 Seconds Every 10 Seconds")]
        ElementalistSkillAreaOfEffectPosPctFor4SecondsEvery10Seconds = 4781,
        [Description("Physical Damage % To Add As Chaos Vs Bleeding Enemies")]
        PhysicalDamagePctToAddAsChaosVsBleedingEnemies = 4782,
        [Description("Elemental Resistances +% For You And Allies Affected By Your Auras")]
        ElementalResistancesPosPctForYouAndAlliesAffectedByYourAuras = 4783,
        [Description("Gain X Life On Trap Triggered By An Enemy")]
        GainXLifeOnTrapTriggeredByAnEnemy = 4784,
        [Description("Gain X Es On Trap Triggered By An Enemy")]
        GainXEsOnTrapTriggeredByAnEnemy = 4785,
        [Description("Phasing % For 3 Seconds On Trap Triggered By An Enemy")]
        PhasingPctFor3SecondsOnTrapTriggeredByAnEnemy = 4786,
        [Description("Visual Always Use Smallest Blood Effect")]
        VisualAlwaysUseSmallestBloodEffect = 4787,
        [Description("Attack Skills Additional Totems Allowed")]
        AttackSkillsAdditionalTotemsAllowed = 4788,
        [Description("Global Defences +% Per White Socket On Item")]
        GlobalDefencesPosPctPerWhiteSocketOnItem = 4789,
        [Description("Global Total Minimum Added Cold Damage")]
        GlobalTotalMinimumAddedColdDamage = 4790,
        [Description("Global Total Maximum Added Cold Damage")]
        GlobalTotalMaximumAddedColdDamage = 4791,
        [Description("Poison From Critical Strikes Damage +% Final")]
        PoisonFromCriticalStrikesDamagePosPctFinal = 4792,
        [Description("Bleed Damage +% Vs Maimed Enemies Final")]
        BleedDamagePosPctVsMaimedEnemiesFinal = 4793,
        [Description("Flask Charges +% From Enemies With Status Ailments")]
        FlaskChargesPosPctFromEnemiesWithStatusAilments = 4794,
        [Description("Mana Cost +% While On Full Energy Shield")]
        ManaCostPosPctWhileOnFullEnergyShield = 4795,
        [Description("Permanently Intimidate Enemies You Hit On Full Life")]
        PermanentlyIntimidateEnemiesYouHitOnFullLife = 4796,
        [Description("Number Of Corpses Consumed Recently")]
        NumberOfCorpsesConsumedRecently = 4797,
        [Description("Track Number Of Corpses Consumed Recently")]
        TrackNumberOfCorpsesConsumedRecently = 4798,
        [Description("Damage +% If You Have Consumed A Corpse Recently")]
        DamagePosPctIfYouHaveConsumedACorpseRecently = 4799,
        [Description("Attack And Cast Speed +% Per Corpse Consumed Recently")]
        AttackAndCastSpeedPosPctPerCorpseConsumedRecently = 4800,
        [Description("Armour And Evasion +% While Fortified")]
        ArmourAndEvasionPosPctWhileFortified = 4801,
        [Description("Melee Damage +% While Fortified")]
        MeleeDamagePosPctWhileFortified = 4802,
        [Description("Desecrate Creates X Additional Corpses")]
        DesecrateCreatesXAdditionalCorpses = 4803,
        [Description("Mana Regeneration Rate +% While Phasing")]
        ManaRegenerationRatePosPctWhilePhasing = 4804,
        [Description("Chaos Skill Effect Duration +%")]
        ChaosSkillEffectDurationPosPct = 4805,
        [Description("Damage +% Final Vs Non Taunt Target From Ot")]
        DamagePosPctFinalVsNonTauntTargetFromOt = 4806,
        [Description("Damage +% Final Vs Non Taunt Target From Passive")]
        DamagePosPctFinalVsNonTauntTargetFromPassive = 4807,
        [Description("Damage +% Final From Damaging Non Taunt Target")]
        DamagePosPctFinalFromDamagingNonTauntTarget = 4808,
        [Description("Taunted Enemies Damage +% Final Vs Non Taunt Target")]
        TauntedEnemiesDamagePosPctFinalVsNonTauntTarget = 4809,
        [Description("Chest Drop Additional Deshret Uniques")]
        ChestDropAdditionalDeshretUniques = 4810,
        [Description("Chest Drop Additional Rare Maraketh Weapons")]
        ChestDropAdditionalRareMarakethWeapons = 4811,
        [Description("Chest Display Spawns Torment Spirits Continuously")]
        ChestDisplaySpawnsTormentSpiritsContinuously = 4812,
        [Description("Chance To Cast On Owned Kill %")]
        ChanceToCastOnOwnedKillPct = 4813,
        [Description("Local Flask Cannot Be Stunned During Flask Effect")]
        LocalFlaskCannotBeStunnedDuringFlaskEffect = 4814,
        [Description("Local Flask Lose All Charges On Entering New Area")]
        LocalFlaskLoseAllChargesOnEnteringNewArea = 4815,
        [Description("Summon Specific Monsters Radius +%")]
        SummonSpecificMonstersRadiusPosPct = 4816,
        [Description("Monster Drop Additional Currency Items With Quality")]
        MonsterDropAdditionalCurrencyItemsWithQuality = 4817,
        [Description("Prophecy Spawned Monster Magic Minimum Rarity")]
        ProphecySpawnedMonsterMagicMinimumRarity = 4818,
        [Description("Gain Life Leech On Kill Permyriad")]
        GainLifeLeechOnKillPermyriad = 4819,
        [Description("Immune To Shock")]
        ImmuneToShock = 4820,
        [Description("Poison On Melee Hit")]
        PoisonOnMeleeHit = 4821,
        [Description("Life Leech Permyriad Vs Cursed Enemies")]
        LifeLeechPermyriadVsCursedEnemies = 4822,
        [Description("Movement Speed +% If Enemy Killed Recently")]
        MovementSpeedPosPctIfEnemyKilledRecently = 4823,
        [Description("Local Display Socketed Gems Supported By X Controlled Destruction")]
        LocalDisplaySocketedGemsSupportedByXControlledDestruction = 4824,
        [Description("Local Unique Flask Kiaras Determination")]
        LocalUniqueFlaskKiarasDetermination = 4825,
        [Description("Map Items Dropped Are Mirrored")]
        MapItemsDroppedAreMirrored = 4826,
        [Description("Monster Is Corrupted Display")]
        MonsterIsCorruptedDisplay = 4827,
        [Description("Monster Casts Fire Nova Text")]
        MonsterCastsFireNovaText = 4828,
        [Description("Monster Casts Flask Charge Nova Text")]
        MonsterCastsFlaskChargeNovaText = 4829,
        [Description("Monster Has Damage Taken Aura Text")]
        MonsterHasDamageTakenAuraText = 4830,
        [Description("Monster Has Temporal Chains Aura Text")]
        MonsterHasTemporalChainsAuraText = 4831,
        [Description("Monster Has Movement Skill Damage Aura Text")]
        MonsterHasMovementSkillDamageAuraText = 4832,
        [Description("Monster Casts Bleed Nova Text")]
        MonsterCastsBleedNovaText = 4833,
        [Description("Weapon Physical Damage % To Add As Each Element")]
        WeaponPhysicalDamagePctToAddAsEachElement = 4834,
        [Description("Map Force Labyrinth Trial")]
        MapForceLabyrinthTrial = 4835,
        [Description("Unique Cold Damage Can Also Ignite")]
        UniqueColdDamageCanAlsoIgnite = 4836,
        [Description("Monster Throws Chaos Bombs Text")]
        MonsterThrowsChaosBombsText = 4837,
        [Description("Attack Trigger On Melee Hit %")]
        AttackTriggerOnMeleeHitPct = 4838,
        [Description("Physical Damage % Added As Fire Damage If Enemy Killed Recently By You Or Your Totems")]
        PhysicalDamagePctAddedAsFireDamageIfEnemyKilledRecentlyByYouOrYourTotems = 4839,
        [Description("Give Parent Physical Damage % Added As Fire Damage If Enemy Killed Recently")]
        GiveParentPhysicalDamagePctAddedAsFireDamageIfEnemyKilledRecently = 4840,
        [Description("Unique Boss Curse Effect On Self +% Final")]
        UniqueBossCurseEffectOnSelfPosPctFinal = 4841,
        [Description("Chest Drop Additional Unique Item Divination Cards")]
        ChestDropAdditionalUniqueItemDivinationCards = 4842,
        [Description("Chest Drop Additional Corrupted Item Divination Cards")]
        ChestDropAdditionalCorruptedItemDivinationCards = 4843,
        [Description("Chest Drop Additional Currency Item Divination Cards")]
        ChestDropAdditionalCurrencyItemDivinationCards = 4844,
        [Description("Chest Drop Additional Divination Cards From Current World Area")]
        ChestDropAdditionalDivinationCardsFromCurrentWorldArea = 4845,
        [Description("Chest Drop Additional Divination Cards From Same Set")]
        ChestDropAdditionalDivinationCardsFromSameSet = 4846,
        [Description("Global Critical Strike Chance While Dual Wielding +%")]
        GlobalCriticalStrikeChanceWhileDualWieldingPosPct = 4847,
        [Description("Global Critical Strike Multiplier While Dual Wielding +")]
        GlobalCriticalStrikeMultiplierWhileDualWieldingPos = 4848,
        [Description("Doom Arrow Number Of Arrows")]
        DoomArrowNumberOfArrows = 4849,
        [Description("Stance Movement Speed +% Final")]
        StanceMovementSpeedPosPctFinal = 4850,
        [Description("Base Physical Damage Reduction And Evasion Rating")]
        BasePhysicalDamageReductionAndEvasionRating = 4851,
        [Description("First Blood Extra Gore")]
        FirstBloodExtraGore = 4852,
        [Description("Cast When Triggered By Other Skill %")]
        CastWhenTriggeredByOtherSkillPct = 4853,
        [Description("Local Display Socketed Gems Minimum Added Fire Damage")]
        LocalDisplaySocketedGemsMinimumAddedFireDamage = 4854,
        [Description("Local Display Socketed Gems Maximum Added Fire Damage")]
        LocalDisplaySocketedGemsMaximumAddedFireDamage = 4855,
        [Description("Local Display Socketed Gems Attack And Cast Speed +% Final")]
        LocalDisplaySocketedGemsAttackAndCastSpeedPosPctFinal = 4856,
        [Description("Local Display Socketed Gems Physical Damage % To Add As Lightning")]
        LocalDisplaySocketedGemsPhysicalDamagePctToAddAsLightning = 4857,
        [Description("Local Display Socketed Gems Elemental Damage +% Final")]
        LocalDisplaySocketedGemsElementalDamagePosPctFinal = 4858,
        [Description("Curse Nova Damage +% Final Per Curse Removed")]
        CurseNovaDamagePosPctFinalPerCurseRemoved = 4859,
        [Description("Elemental Penetration % During Flask Effect")]
        ElementalPenetrationPctDuringFlaskEffect = 4860,
        [Description("Additional Physical Damage Reduction % During Flask Effect")]
        AdditionalPhysicalDamageReductionPctDuringFlaskEffect = 4861,
        [Description("Reflect Damage Taken +%")]
        ReflectDamageTakenPosPct = 4862,
        [Description("Power Charge On Block % Chance")]
        PowerChargeOnBlockPctChance = 4863,
        [Description("Nearby Enemies Chilled On Block")]
        NearbyEnemiesChilledOnBlock = 4864,
        [Description("Arrow Projectile Variation")]
        ArrowProjectileVariation = 4865,
        [Description("Essence Buff Elemental Damage Taken +%")]
        EssenceBuffElementalDamageTakenPosPct = 4866,
        [Description("Essence Buff Ground Fire Damage To Deal Per Second")]
        EssenceBuffGroundFireDamageToDealPerSecond = 4867,
        [Description("Essence Buff Ground Fire Duration Ms")]
        EssenceBuffGroundFireDurationMs = 4868,
        [Description("Trigger Spawners Override Row")]
        TriggerSpawnersOverrideRow = 4869,
        [Description("Trigger Spawners Max Count")]
        TriggerSpawnersMaxCount = 4870,
        [Description("Map Race Data")]
        MapRaceData = 4871,
        [Description("Map Packs Have Pop Up Traps")]
        MapPacksHavePopUpTraps = 4872,
        [Description("Permanent Damage Taken +% On Minion Death")]
        PermanentDamageTakenPosPctOnMinionDeath = 4873,
        [Description("Permanent Actor Scale +% On Minion Death")]
        PermanentActorScalePosPctOnMinionDeath = 4874,
        [Description("Permanent Item Quantity +% On Minion Death")]
        PermanentItemQuantityPosPctOnMinionDeath = 4875,
        [Description("Permanent Item Rarity +% On Minion Death")]
        PermanentItemRarityPosPctOnMinionDeath = 4876,
        [Description("Ground Maelstrom Art Variation")]
        GroundMaelstromArtVariation = 4877,
        [Description("Do Not Revive After Time")]
        DoNotReviveAfterTime = 4878,
        [Description("Chaos Damage Taken Over Time +%")]
        ChaosDamageTakenOverTimePosPct = 4879,
        [Description("Local Display Socketed Gems Additional Critical Strike Chance %")]
        LocalDisplaySocketedGemsAdditionalCriticalStrikeChancePct = 4880,
        [Description("Attack And Cast Speed +% During Flask Effect")]
        AttackAndCastSpeedPosPctDuringFlaskEffect = 4881,
        [Description("Minimum Added Cold Damage Per Frenzy Charge")]
        MinimumAddedColdDamagePerFrenzyCharge = 4882,
        [Description("Maximum Added Cold Damage Per Frenzy Charge")]
        MaximumAddedColdDamagePerFrenzyCharge = 4883,
        [Description("Minimum Added Fire Damage If Blocked Recently")]
        MinimumAddedFireDamageIfBlockedRecently = 4884,
        [Description("Maximum Added Fire Damage If Blocked Recently")]
        MaximumAddedFireDamageIfBlockedRecently = 4885,
        [Description("Track Have Blocked Attack Recently")]
        TrackHaveBlockedAttackRecently = 4886,
        [Description("Have Blocked Attack Recently")]
        HaveBlockedAttackRecently = 4887,
        [Description("Global Total Minimum Added Fire Damage")]
        GlobalTotalMinimumAddedFireDamage = 4888,
        [Description("Global Total Maximum Added Fire Damage")]
        GlobalTotalMaximumAddedFireDamage = 4889,
        [Description("Stun Threshold Based On Energy Shield Instead Of Life")]
        StunThresholdBasedOnEnergyShieldInsteadOfLife = 4890,
        [Description("Cannot Leech Life From Critical Strikes")]
        CannotLeechLifeFromCriticalStrikes = 4891,
        [Description("% Chance To Blind On Critical Strike")]
        PctChanceToBlindOnCriticalStrike = 4892,
        [Description("Bleed On Melee Critical Strike")]
        BleedOnMeleeCriticalStrike = 4893,
        [Description("Map Has Monoliths")]
        MapHasMonoliths = 4894,
        [Description("In Lava")]
        InLava = 4895,
        [Description("Base Life Regeneration Per Minute % While In Lava")]
        BaseLifeRegenerationPerMinutePctWhileInLava = 4896,
        [Description("Lava Buff Effect On Self +%")]
        LavaBuffEffectOnSelfPosPct = 4897,
        [Description("Current Fire Beam Stacks")]
        CurrentFireBeamStacks = 4898,
        [Description("Max Fire Beam Stacks")]
        MaxFireBeamStacks = 4899,
        [Description("Marker Warp Marker Variation")]
        MarkerWarpMarkerVariation = 4900,
        [Description("Self Take No Extra Damage From Critical Strikes")]
        SelfTakeNoExtraDamageFromCriticalStrikes = 4901,
        [Description("Enemies You Shock Cast Speed +%")]
        EnemiesYouShockCastSpeedPosPct = 4902,
        [Description("Enemies You Shock Movement Speed +%")]
        EnemiesYouShockMovementSpeedPosPct = 4903,
        [Description("Burning Damage +% If Ignited An Enemy Recently")]
        BurningDamagePosPctIfIgnitedAnEnemyRecently = 4904,
        [Description("Recover % Maximum Life On Enemy Ignited")]
        RecoverPctMaximumLifeOnEnemyIgnited = 4905,
        [Description("Melee Physical Damage +% Vs Ignited Enemies")]
        MeleePhysicalDamagePosPctVsIgnitedEnemies = 4906,
        [Description("Critical Strike Chance +% For Forking Arrows")]
        CriticalStrikeChancePosPctForForkingArrows = 4907,
        [Description("Arrows Always Pierce After Chaining")]
        ArrowsAlwaysPierceAfterChaining = 4908,
        [Description("Arrows That Pierce Cause Bleeding")]
        ArrowsThatPierceCauseBleeding = 4909,
        [Description("Spells Number Of Additional Projectiles")]
        SpellsNumberOfAdditionalProjectiles = 4910,
        [Description("Minion Damage +% If Enemy Hit Recently")]
        MinionDamagePosPctIfEnemyHitRecently = 4911,
        [Description("Have Hit An Enemy Recently")]
        HaveHitAnEnemyRecently = 4912,
        [Description("Track Have Hit An Enemy Recently")]
        TrackHaveHitAnEnemyRecently = 4913,
        [Description("Minion Damage Increases And Reductions Also Affects You")]
        MinionDamageIncreasesAndReductionsAlsoAffectsYou = 4914,
        [Description("Projectile Attack Damage +% Per 200 Accuracy")]
        ProjectileAttackDamagePosPctPer200Accuracy = 4915,
        [Description("Map Bosses Have Union Of Souls")]
        MapBossesHaveUnionOfSouls = 4916,
        [Description("Map Extra Monoliths")]
        MapExtraMonoliths = 4917,
        [Description("Minion Dies When Parent Deleted")]
        MinionDiesWhenParentDeleted = 4918,
        [Description("Spectral Throw Projectile Scale +%")]
        SpectralThrowProjectileScalePosPct = 4919,
        [Description("Gain Onslaught For 3 Seconds % Chance When Hit")]
        GainOnslaughtFor3SecondsPctChanceWhenHit = 4920,
        [Description("Local Display Socketed Gems Damage Over Time +% Final")]
        LocalDisplaySocketedGemsDamageOverTimePosPctFinal = 4921,
        [Description("Deal Chaos Damage Per Second For 10 Seconds On Hit")]
        DealChaosDamagePerSecondFor10SecondsOnHit = 4922,
        [Description("Movement Speed +% While On Burning Chilled Shocked Ground")]
        MovementSpeedPosPctWhileOnBurningChilledShockedGround = 4923,
        [Description("Mana % Gained On Block")]
        ManaPctGainedOnBlock = 4924,
        [Description("Projectiles Drop Caustic Cloud")]
        ProjectilesDropCausticCloud = 4925,
        [Description("Base Projectile Ground Caustic Cloud Damage Per Minute")]
        BaseProjectileGroundCausticCloudDamagePerMinute = 4926,
        [Description("Local Display Socketed Non Curse Aura Gems Effect +%")]
        LocalDisplaySocketedNonCurseAuraGemsEffectPosPct = 4927,
        [Description("Local Display Fire Burst On Hit %")]
        LocalDisplayFireBurstOnHitPct = 4928,
        [Description("Essence Support Attack And Cast Speed +% Final")]
        EssenceSupportAttackAndCastSpeedPosPctFinal = 4929,
        [Description("Essence Support Elemental Damage +% Final")]
        EssenceSupportElementalDamagePosPctFinal = 4930,
        [Description("Base Number Of Essence Spirits Allowed")]
        BaseNumberOfEssenceSpiritsAllowed = 4931,
        [Description("Number Of Essence Spirits Allowed")]
        NumberOfEssenceSpiritsAllowed = 4932,
        [Description("Number Of Active Essence Spirits")]
        NumberOfActiveEssenceSpirits = 4933,
        [Description("Chest Drop Additional Prophecy Coins")]
        ChestDropAdditionalProphecyCoins = 4934,
        [Description("Ground Effect Variation")]
        GroundEffectVariation = 4935,
        [Description("Essence Support Damage Over Time +% Final")]
        EssenceSupportDamageOverTimePosPctFinal = 4936,
        [Description("Local Unique Jewel Spectres Gain Soul Eater On Kill % Chance With 50 Int In Radius")]
        LocalUniqueJewelSpectresGainSoulEaterOnKillPctChanceWith50IntInRadius = 4937,
        [Description("Spectres Gain Soul Eater For 30 Seconds On Kill % Chance")]
        SpectresGainSoulEaterFor30SecondsOnKillPctChance = 4938,
        [Description("Gain Soul Eater For 30 Seconds On Kill % Chance")]
        GainSoulEaterFor30SecondsOnKillPctChance = 4939,
        [Description("Local Unique Cast Socketed Cold Skills On Melee Critical Strike")]
        LocalUniqueCastSocketedColdSkillsOnMeleeCriticalStrike = 4940,
        [Description("Main Hand Local Unique Cast Socketed Cold Skills On Melee Critical Strike")]
        MainHandLocalUniqueCastSocketedColdSkillsOnMeleeCriticalStrike = 4941,
        [Description("Off Hand Local Unique Cast Socketed Cold Skills On Melee Critical Strike")]
        OffHandLocalUniqueCastSocketedColdSkillsOnMeleeCriticalStrike = 4942,
        [Description("Global Critical Strike Chance +% Vs Chilled Enemies")]
        GlobalCriticalStrikeChancePosPctVsChilledEnemies = 4943,
        [Description("Unique Cospris Malice Cold Spells Triggered")]
        UniqueCosprisMaliceColdSpellsTriggered = 4944,
        [Description("Projectile Ground Caustic Cloud Radius")]
        ProjectileGroundCausticCloudRadius = 4945,
        [Description("Gain Phasing If Enemy Killed Recently")]
        GainPhasingIfEnemyKilledRecently = 4946,
        [Description("Movement Skills Deal No Physical Damage")]
        MovementSkillsDealNoPhysicalDamage = 4947,
        [Description("X Mana Per 4 Strength")]
        XManaPer4Strength = 4948,
        [Description("Energy Shield +% Per 10 Strength")]
        EnergyShieldPosPctPer10Strength = 4949,
        [Description("X Life Per 4 Dexterity")]
        XLifePer4Dexterity = 4950,
        [Description("Melee Physical Damage +% Per 10 Dexterity")]
        MeleePhysicalDamagePosPctPer10Dexterity = 4951,
        [Description("X Accuracy Per 2 Intelligence")]
        XAccuracyPer2Intelligence = 4952,
        [Description("Evasion +% Per 10 Intelligence")]
        EvasionPosPctPer10Intelligence = 4953,
        [Description("Maximum Life % To Add As Maximum Armour")]
        MaximumLifePctToAddAsMaximumArmour = 4954,
        [Description("Monster No Drops If Death Timer Expired")]
        MonsterNoDropsIfDeathTimerExpired = 4955,
        [Description("Attack Area Of Effect +%")]
        AttackAreaOfEffectPosPct = 4956,
        [Description("Physical Damage Can Shock")]
        PhysicalDamageCanShock = 4957,
        [Description("Deal No Elemental Damage")]
        DealNoElementalDamage = 4958,
        [Description("Immune To Freeze")]
        ImmuneToFreeze = 4959,
        [Description("Immune To Ignite")]
        ImmuneToIgnite = 4960,
        [Description("Immune To Chill")]
        ImmuneToChill = 4961,
        [Description("Monster Drop No Essences")]
        MonsterDropNoEssences = 4962,
        [Description("Base Immune To Freeze")]
        BaseImmuneToFreeze = 4963,
        [Description("Base Immune To Chill")]
        BaseImmuneToChill = 4964,
        [Description("Base Immune To Ignite")]
        BaseImmuneToIgnite = 4965,
        [Description("Base Immune To Shock")]
        BaseImmuneToShock = 4966,
        [Description("Base Cannot Gain Bleeding")]
        BaseCannotGainBleeding = 4967,
        [Description("Map Boss Dropped Unique Items +")]
        MapBossDroppedUniqueItemsPos = 4968,
        [Description("Map Boss Drops Corrupted Items")]
        MapBossDropsCorruptedItems = 4969,
        [Description("Map Players And Monsters Damage +% Per Curse")]
        MapPlayersAndMonstersDamagePosPctPerCurse = 4970,
        [Description("Map Players And Monsters Critical Strike Chance +%")]
        MapPlayersAndMonstersCriticalStrikeChancePosPct = 4971,
        [Description("Map Monsters Steal Charges")]
        MapMonstersStealCharges = 4972,
        [Description("Map Unidentified Maps Item Quantity +%")]
        MapUnidentifiedMapsItemQuantityPosPct = 4973,
        [Description("Map Boss Dropped Item Quantity +%")]
        MapBossDroppedItemQuantityPosPct = 4974,
        [Description("Map Number Of Additional Mods")]
        MapNumberOfAdditionalMods = 4975,
        [Description("Map Nemesis Dropped Items +")]
        MapNemesisDroppedItemsPos = 4976,
        [Description("Map Contains Master")]
        MapContainsMaster = 4977,
        [Description("Buff Impl Stat")]
        BuffImplStat = 4978,
        [Description("Cannot Be Shocked")]
        CannotBeShocked = 4979,
        [Description("Restore Skill Life %")]
        RestoreSkillLifePct = 4980,
        [Description("Restore Skill Mana %")]
        RestoreSkillManaPct = 4981,
        [Description("Restore Skill Es %")]
        RestoreSkillEsPct = 4982,
        [Description("Ground Tar Art Variation")]
        GroundTarArtVariation = 4983,
        [Description("Fire Damage Taken When Enemy Ignited")]
        FireDamageTakenWhenEnemyIgnited = 4984,
        [Description("Life Leech From Fire Damage While Ignited Permyriad")]
        LifeLeechFromFireDamageWhileIgnitedPermyriad = 4985,
        [Description("Action Ignores Crit Tracking")]
        ActionIgnoresCritTracking = 4986,
        [Description("Movement Velocity While Spider +%")]
        MovementVelocityWhileSpiderPosPct = 4987,
        [Description("Is Spider")]
        IsSpider = 4988,
        [Description("Projectile Attack Damage +%")]
        ProjectileAttackDamagePosPct = 4989,
        [Description("Covered In Spiders Damage +% Final")]
        CoveredInSpidersDamagePosPctFinal = 4990,
        [Description("Covered In Spiders Attack And Cast Speed +% Final")]
        CoveredInSpidersAttackAndCastSpeedPosPctFinal = 4991,
        [Description("Map Create Instance Terrain Plugin")]
        MapCreateInstanceTerrainPlugin = 4992,
        [Description("Monster Map Boss Take Critical Strike Chance +% Final")]
        MonsterMapBossTakeCriticalStrikeChancePosPctFinal = 4993,
        [Description("Monster Map Boss Extra Damage Taken From Crit +% Final")]
        MonsterMapBossExtraDamageTakenFromCritPosPctFinal = 4994,
        [Description("Extra Damage Taken From Crit +%")]
        ExtraDamageTakenFromCritPosPct = 4995,
        [Description("Chance To Gain Frenzy Charge On Stun %")]
        ChanceToGainFrenzyChargeOnStunPct = 4996,
        [Description("Local Unique Flask Damage Over Time +% During Flask Effect")]
        LocalUniqueFlaskDamageOverTimePosPctDuringFlaskEffect = 4997,
        [Description("Local Unique Flask Nearby Enemies Cursed With Level X Despair During Flask Effect")]
        LocalUniqueFlaskNearbyEnemiesCursedWithLevelXDespairDuringFlaskEffect = 4998,
        [Description("Restore Skill Life Regeneration Rate Per Minute %")]
        RestoreSkillLifeRegenerationRatePerMinutePct = 4999,
        [Description("Restore Skill Mana Regeneration Rate Per Minute %")]
        RestoreSkillManaRegenerationRatePerMinutePct = 5000,
        [Description("Restore Skill Es Regeneration Rate Per Minute %")]
        RestoreSkillEsRegenerationRatePerMinutePct = 5001,
        [Description("Projectiles Pierce While Phasing")]
        ProjectilesPierceWhilePhasing = 5002,
        [Description("Avoid Projectiles While Phasing % Chance")]
        AvoidProjectilesWhilePhasingPctChance = 5003,
        [Description("Essence Display Drop Burning Ground While Moving Fire Damage Per Second")]
        EssenceDisplayDropBurningGroundWhileMovingFireDamagePerSecond = 5004,
        [Description("Essence Display Elemental Damage Taken While Not Moving +%")]
        EssenceDisplayElementalDamageTakenWhileNotMovingPosPct = 5005,
        [Description("Local Flask Area Of Effect +% During Flask Effect")]
        LocalFlaskAreaOfEffectPosPctDuringFlaskEffect = 5006,
        [Description("Local Flask Number Of Additional Projectiles During Flask Effect")]
        LocalFlaskNumberOfAdditionalProjectilesDuringFlaskEffect = 5007,
        [Description("Corrupted Blood On Hit Duration")]
        CorruptedBloodOnHitDuration = 5008,
        [Description("Take No Actions While Parent Dead")]
        TakeNoActionsWhileParentDead = 5009,
        [Description("Cast On Hide %")]
        CastOnHidePct = 5010,
        [Description("Map Item Level Override")]
        MapItemLevelOverride = 5011,
        [Description("Hallowed Ground Boss Use Clone Attack")]
        HallowedGroundBossUseCloneAttack = 5012,
        [Description("Hallowed Ground Boss Drop Tar On Ground Slam")]
        HallowedGroundBossDropTarOnGroundSlam = 5013,
        [Description("Drop Ground Tar On Hit %")]
        DropGroundTarOnHitPct = 5014,
        [Description("Map Drop Stacked Deck On Death Permyriad")]
        MapDropStackedDeckOnDeathPermyriad = 5015,
        [Description("Magic Monster Dropped Item Rarity +%")]
        MagicMonsterDroppedItemRarityPosPct = 5016,
        [Description("Normal Monster Dropped Item Quantity +%")]
        NormalMonsterDroppedItemQuantityPosPct = 5017,
        [Description("Map Player Has Level X Projectile Weakness")]
        MapPlayerHasLevelXProjectileWeakness = 5018,
        [Description("Map Player Has Level X Conductivity")]
        MapPlayerHasLevelXConductivity = 5019,
        [Description("Map Player Has Level X Flammability")]
        MapPlayerHasLevelXFlammability = 5020,
        [Description("Map Player Has Level X Frostbite")]
        MapPlayerHasLevelXFrostbite = 5021,
        [Description("Support Cast On Crit Spell Damage +% Final")]
        SupportCastOnCritSpellDamagePosPctFinal = 5022,
        [Description("Support Cast On Melee Kill Spell Damage +% Final")]
        SupportCastOnMeleeKillSpellDamagePosPctFinal = 5023,
        [Description("Avoid Projectiles % Chance")]
        AvoidProjectilesPctChance = 5024,
        [Description("Monster Inside Monolith")]
        MonsterInsideMonolith = 5025,
        [Description("Map Spawn Extra Perandus Chests")]
        MapSpawnExtraPerandusChests = 5026,
        [Description("Map Spawn Cadiro % Chance")]
        MapSpawnCadiroPctChance = 5027,
        [Description("Cast On Unhide %")]
        CastOnUnhidePct = 5028,
        [Description("Map Players And Monsters Have Resolute Technique")]
        MapPlayersAndMonstersHaveResoluteTechnique = 5029,
        [Description("Map Resolute Technique")]
        MapResoluteTechnique = 5030,
        [Description("Map Unique Boss Drops Divination Cards")]
        MapUniqueBossDropsDivinationCards = 5031,
        [Description("All Damage Can Chill")]
        AllDamageCanChill = 5032,
        [Description("All Damage Can Shock")]
        AllDamageCanShock = 5033,
        [Description("All Damage Can Ignite")]
        AllDamageCanIgnite = 5034,
        [Description("Elementalist Gain Shaper Of Desolation Every 10 Seconds")]
        ElementalistGainShaperOfDesolationEvery10Seconds = 5035,
        [Description("Monster Delay Item Drops Millis")]
        MonsterDelayItemDropsMillis = 5036,
        [Description("Map Area Contains Grandmaster Ally")]
        MapAreaContainsGrandmasterAlly = 5037,
        [Description("Map Contains Creeping Agony")]
        MapContainsCreepingAgony = 5038,
        [Description("Map Portals Do Not Expire")]
        MapPortalsDoNotExpire = 5039,
        [Description("Map Monsters Are Converted On Kill")]
        MapMonstersAreConvertedOnKill = 5040,
        [Description("Map Contains X Fewer Portals")]
        MapContainsXFewerPortals = 5041,
        [Description("Monsters Are Converted On Kill")]
        MonstersAreConvertedOnKill = 5042,
        [Description("Map No Uniques Drop Randomly")]
        MapNoUniquesDropRandomly = 5043,
        [Description("Map Players Additional Number Of Projectiles")]
        MapPlayersAdditionalNumberOfProjectiles = 5044,
        [Description("Map Damage +% Of Type Inflicted By Current Ground Effect You Are On")]
        MapDamagePosPctOfTypeInflictedByCurrentGroundEffectYouAreOn = 5045,
        [Description("On Desecrated Ground")]
        OnDesecratedGround = 5046,
        [Description("Map Players And Monsters Curses Are Reflected")]
        MapPlayersAndMonstersCursesAreReflected = 5047,
        [Description("Map Player Has Level X Silence")]
        MapPlayerHasLevelXSilence = 5048,
        [Description("Map Strongbox Items Dropped Are Mirrored")]
        MapStrongboxItemsDroppedAreMirrored = 5049,
        [Description("Map Players Are Poisoned While Moving Chaos Damage Per Second")]
        MapPlayersArePoisonedWhileMovingChaosDamagePerSecond = 5050,
        [Description("Discharge Triggered Damage +% Final")]
        DischargeTriggeredDamagePosPctFinal = 5051,
        [Description("Map Normal Items Drop As Magic")]
        MapNormalItemsDropAsMagic = 5052,
        [Description("Monster No Additional Player Scaling")]
        MonsterNoAdditionalPlayerScaling = 5053,
        [Description("Phase Through Objects While Spider")]
        PhaseThroughObjectsWhileSpider = 5054,
        [Description("Map Flask Charges Recovered Per 3 Seconds %")]
        MapFlaskChargesRecoveredPer3SecondsPct = 5055,
        [Description("Virtual Flask Charges Recovered Per 3 Seconds %")]
        VirtualFlaskChargesRecoveredPer3SecondsPct = 5056,
        [Description("Combined Hit All Damage +% Final")]
        CombinedHitAllDamagePosPctFinal = 5057,
        [Description("Support Remote Mine Hit Damage +% Final")]
        SupportRemoteMineHitDamagePosPctFinal = 5058,
        [Description("Map Magic Items Drop As Normal")]
        MapMagicItemsDropAsNormal = 5059,
        [Description("Flask Charges Recovered Per 3 Seconds %")]
        FlaskChargesRecoveredPer3SecondsPct = 5060,
        [Description("Support Trap Hit Damage +% Final")]
        SupportTrapHitDamagePosPctFinal = 5061,
        [Description("Damage Vs Tiki Totems +%")]
        DamageVsTikiTotemsPosPct = 5062,
        [Description("Is Tiki Totem")]
        IsTikiTotem = 5063,
        [Description("Self Ignite Duration +% Final")]
        SelfIgniteDurationPosPctFinal = 5064,
        [Description("Self Bleed Duration +% Final")]
        SelfBleedDurationPosPctFinal = 5065,
        [Description("Self Poison Duration +% Final")]
        SelfPoisonDurationPosPctFinal = 5066,
        [Description("Treasure Pile Damage +% Final")]
        TreasurePileDamagePosPctFinal = 5067,
        [Description("Map Contains Additional Packs Of Fire Monsters")]
        MapContainsAdditionalPacksOfFireMonsters = 5068,
        [Description("Map Contains Additional Packs Of Chaos Monsters")]
        MapContainsAdditionalPacksOfChaosMonsters = 5069,
        [Description("Map Contains Additional Packs Of Physical Monsters")]
        MapContainsAdditionalPacksOfPhysicalMonsters = 5070,
        [Description("Map Contains Additional Packs Of Lightning Monsters")]
        MapContainsAdditionalPacksOfLightningMonsters = 5071,
        [Description("Map Contains Additional Packs Of Cold Monsters")]
        MapContainsAdditionalPacksOfColdMonsters = 5072,
        [Description("Map Players And Monsters Fire Damage Taken +%")]
        MapPlayersAndMonstersFireDamageTakenPosPct = 5073,
        [Description("Map Players And Monsters Chaos Damage Taken +%")]
        MapPlayersAndMonstersChaosDamageTakenPosPct = 5074,
        [Description("Map Players And Monsters Physical Damage Taken +%")]
        MapPlayersAndMonstersPhysicalDamageTakenPosPct = 5075,
        [Description("Map Players And Monsters Lightning Damage Taken +%")]
        MapPlayersAndMonstersLightningDamageTakenPosPct = 5076,
        [Description("Map Players And Monsters Cold Damage Taken +%")]
        MapPlayersAndMonstersColdDamageTakenPosPct = 5077,
        [Description("Map Players And Monsters Have Onslaught If Hit Recently")]
        MapPlayersAndMonstersHaveOnslaughtIfHitRecently = 5078,
        [Description("Map Players And Monsters Damage Taken +% While Stationary")]
        MapPlayersAndMonstersDamageTakenPosPctWhileStationary = 5079,
        [Description("Chance To Poison On Melee Hit %")]
        ChanceToPoisonOnMeleeHitPct = 5080,
        [Description("Chilled Ground Effect +%")]
        ChilledGroundEffectPosPct = 5081,
        [Description("Damage Vs Spiders While Spider +%")]
        DamageVsSpidersWhileSpiderPosPct = 5082,
        [Description("Damage Taken From Spiders While Spider +%")]
        DamageTakenFromSpidersWhileSpiderPosPct = 5083,
        [Description("Map Players And Monsters Movement Speed +%")]
        MapPlayersAndMonstersMovementSpeedPosPct = 5084,
        [Description("Damage Taken +% For 4 Seconds After Spending 200 Mana")]
        DamageTakenPosPctFor4SecondsAfterSpending200Mana = 5085,
        [Description("Life Regeneration Per Minute Per Active Buff")]
        LifeRegenerationPerMinutePerActiveBuff = 5086,
        [Description("Buff Effect +% On Low Energy Shield")]
        BuffEffectPosPctOnLowEnergyShield = 5087,
        [Description("On Low Energy Shield")]
        OnLowEnergyShield = 5088,
        [Description("Map Ground Haste Action Speed +%")]
        MapGroundHasteActionSpeedPosPct = 5089,
        [Description("Map Drops All Maps")]
        MapDropsAllMaps = 5090,
        [Description("Essence Delirium Spawn Monster On Death Variation")]
        EssenceDeliriumSpawnMonsterOnDeathVariation = 5091,
        [Description("Essence Anguish Spawn Monster On Death Variation")]
        EssenceAnguishSpawnMonsterOnDeathVariation = 5092,
        [Description("Essence Suffering Spawn Monster On Death Variation")]
        EssenceSufferingSpawnMonsterOnDeathVariation = 5093,
        [Description("Essence Corrupt Spawn Monster On Death Variation")]
        EssenceCorruptSpawnMonsterOnDeathVariation = 5094,
        [Description("Map Ground Haste Effect Patches Per 100 Tiles")]
        MapGroundHasteEffectPatchesPer100Tiles = 5095,
        [Description("Map Ground Haste Effect Radius")]
        MapGroundHasteEffectRadius = 5096,
        [Description("Map Breach Rules")]
        MapBreachRules = 5097,
        [Description("Cannot Regenerate Energy Shield")]
        CannotRegenerateEnergyShield = 5098,
        [Description("Cannot Recharge Energy Shield")]
        CannotRechargeEnergyShield = 5099,
        [Description("Energy Shield Lost Per Minute %")]
        EnergyShieldLostPerMinutePct = 5100,
        [Description("Life Leech Applies To Energy Shield On Full Life")]
        LifeLeechAppliesToEnergyShieldOnFullLife = 5101,
        [Description("Virtual Leech Energy Shield Instead Of Life")]
        VirtualLeechEnergyShieldInsteadOfLife = 5102,
        [Description("Current Number Of Spinning Blades")]
        CurrentNumberOfSpinningBlades = 5103,
        [Description("Fire Beam Additional Stack Damage +% Final")]
        FireBeamAdditionalStackDamagePosPctFinal = 5104,
        [Description("Number Of Blood Ravens To Summon")]
        NumberOfBloodRavensToSummon = 5105,
        [Description("Map Fishy Effect 0")]
        MapFishyEffect0 = 5106,
        [Description("Map Hidden Players Have Insanity")]
        MapHiddenPlayersHaveInsanity = 5107,
        [Description("Map Monster And Player Onslaught Effect +%")]
        MapMonsterAndPlayerOnslaughtEffectPosPct = 5108,
        [Description("Map Damage While Stationary +%")]
        MapDamageWhileStationaryPosPct = 5109,
        [Description("Map Damage Taken While Stationary +%")]
        MapDamageTakenWhileStationaryPosPct = 5110,
        [Description("Map Item Drop Quality Also Applies To Map Item Drop Rarity")]
        MapItemDropQualityAlsoAppliesToMapItemDropRarity = 5111,
        [Description("Map Has X% Quality")]
        MapHasXPctQuality = 5112,
        [Description("Map Unique Monsters Drop Corrupted Items")]
        MapUniqueMonstersDropCorruptedItems = 5113,
        [Description("Fire Beam Degen Spread To Enemies In Radius On Kill")]
        FireBeamDegenSpreadToEnemiesInRadiusOnKill = 5114,
        [Description("Fire Beam Enemy Fire Resistance % Per Stack")]
        FireBeamEnemyFireResistancePctPerStack = 5115,
        [Description("Fire Beam Cast Speed +%")]
        FireBeamCastSpeedPosPct = 5116,
        [Description("Map Corrupted Bosses Drop X Additional Vaal Items")]
        MapCorruptedBossesDropXAdditionalVaalItems = 5117,
        [Description("Map Strongboxes Are Corrupted")]
        MapStrongboxesAreCorrupted = 5118,
        [Description("Map Players Cannot Take Reflected Damage")]
        MapPlayersCannotTakeReflectedDamage = 5119,
        [Description("Map Player Flask Recovery Is Instant")]
        MapPlayerFlaskRecoveryIsInstant = 5120,
        [Description("Map Contains X Additional Packs With Mirrored Rare Monsters")]
        MapContainsXAdditionalPacksWithMirroredRareMonsters = 5121,
        [Description("Map Contains X Additional Healing Packs")]
        MapContainsXAdditionalHealingPacks = 5122,
        [Description("Map Contains X Additional Normal Packs")]
        MapContainsXAdditionalNormalPacks = 5123,
        [Description("Map Contains X Additional Magic Packs")]
        MapContainsXAdditionalMagicPacks = 5124,
        [Description("Map Contains X Additional Rare Packs")]
        MapContainsXAdditionalRarePacks = 5125,
        [Description("Map Contains X Additional Packs That Convert On Death")]
        MapContainsXAdditionalPacksThatConvertOnDeath = 5126,
        [Description("Map Contains X Additional Packs On Their Own Team")]
        MapContainsXAdditionalPacksOnTheirOwnTeam = 5127,
        [Description("Map On Complete Drop X Additional Maps")]
        MapOnCompleteDropXAdditionalMaps = 5128,
        [Description("Monster Converts On Death")]
        MonsterConvertsOnDeath = 5129,
        [Description("Flask Recovery Is Instant")]
        FlaskRecoveryIsInstant = 5130,
        [Description("Map Fishy Effect 1")]
        MapFishyEffect1 = 5131,
        [Description("Map Fishy Effect 2")]
        MapFishyEffect2 = 5132,
        [Description("Map Fishy Effect 3")]
        MapFishyEffect3 = 5133,
        [Description("Map Magic Pack Size +%")]
        MapMagicPackSizePosPct = 5134,
        [Description("Map Rogue Exiles Damage +%")]
        MapRogueExilesDamagePosPct = 5135,
        [Description("Map Rogue Exiles Maximum Life +%")]
        MapRogueExilesMaximumLifePosPct = 5136,
        [Description("Map Rogue Exiles Drop X Additional Jewels")]
        MapRogueExilesDropXAdditionalJewels = 5137,
        [Description("Monster Drop Additional Jewels")]
        MonsterDropAdditionalJewels = 5138,
        [Description("Map Strongbox Monsters Item Quantity +%")]
        MapStrongboxMonstersItemQuantityPosPct = 5139,
        [Description("Map Strongbox Monsters Actor Scale +%")]
        MapStrongboxMonstersActorScalePosPct = 5140,
        [Description("Map Strongbox Monsters Attack Speed +%")]
        MapStrongboxMonstersAttackSpeedPosPct = 5141,
        [Description("Map Strongbox Monsters Movement Velocity +%")]
        MapStrongboxMonstersMovementVelocityPosPct = 5142,
        [Description("Strongbox Monsters Item Quantity +%")]
        StrongboxMonstersItemQuantityPosPct = 5143,
        [Description("Strongbox Monsters Actor Scale +%")]
        StrongboxMonstersActorScalePosPct = 5144,
        [Description("Strongbox Monsters Attack Speed +%")]
        StrongboxMonstersAttackSpeedPosPct = 5145,
        [Description("Strongbox Monsters Movement Velocity +%")]
        StrongboxMonstersMovementVelocityPosPct = 5146,
        [Description("Damage +% Per Poison Stack")]
        DamagePosPctPerPoisonStack = 5147,
        [Description("Movement Velocity +% Per Poison Stack")]
        MovementVelocityPosPctPerPoisonStack = 5148,
        [Description("Map Damage +% Per Poison Stack")]
        MapDamagePosPctPerPoisonStack = 5149,
        [Description("Map Movement Velocity +% Per Poison Stack")]
        MapMovementVelocityPosPctPerPoisonStack = 5150,
        [Description("Map Contains X Additional Poison Packs")]
        MapContainsXAdditionalPoisonPacks = 5151,
        [Description("Inspiring Cry Enemy Count Override")]
        InspiringCryEnemyCountOverride = 5152,
        [Description("Map Area Contains X Additional Clusters Of Explosive Barrels")]
        MapAreaContainsXAdditionalClustersOfExplosiveBarrels = 5153,
        [Description("Map Bonus Barrel %")]
        MapBonusBarrelPct = 5154,
        [Description("Empowering Cry Physical Damage Added As Fire Damage %")]
        EmpoweringCryPhysicalDamageAddedAsFireDamagePct = 5155,
        [Description("Map Boss Accompanied By Bodyguards")]
        MapBossAccompaniedByBodyguards = 5156,
        [Description("Blade Vortex Hit Rate +% Per Blade")]
        BladeVortexHitRatePosPctPerBlade = 5157,
        [Description("Blade Vortex Damage +% Per Blade Final")]
        BladeVortexDamagePosPctPerBladeFinal = 5158,
        [Description("Golem Maximum Life +%")]
        GolemMaximumLifePosPct = 5159,
        [Description("Golem Life Regeneration Per Minute %")]
        GolemLifeRegenerationPerMinutePct = 5160,
        [Description("Have Summoned A Golem In Past 8 Seconds")]
        HaveSummonedAGolemInPast8Seconds = 5161,
        [Description("Damage +% If Golem Summoned In Past 8 Seconds")]
        DamagePosPctIfGolemSummonedInPast8Seconds = 5162,
        [Description("Golem Damage +% If Summoned In Past 8 Seconds")]
        GolemDamagePosPctIfSummonedInPast8Seconds = 5163,
        [Description("Golem Skill Cooldown Recovery +%")]
        GolemSkillCooldownRecoveryPosPct = 5164,
        [Description("Golem Cooldown Recovery +%")]
        GolemCooldownRecoveryPosPct = 5165,
        [Description("Golem Buff Effect +%")]
        GolemBuffEffectPosPct = 5166,
        [Description("Golem Attack And Cast Speed +%")]
        GolemAttackAndCastSpeedPosPct = 5167,
        [Description("Golem Physical Damage Reduction Rating")]
        GolemPhysicalDamageReductionRating = 5168,
        [Description("Primordial Jewel Count")]
        PrimordialJewelCount = 5169,
        [Description("Number Of Golems Allowed With 3 Primordial Jewels")]
        NumberOfGolemsAllowedWith3PrimordialJewels = 5170,
        [Description("Map Monster Curse Effect On Self +%")]
        MapMonsterCurseEffectOnSelfPosPct = 5171,
        [Description("Map Player Curse Effect On Self +%")]
        MapPlayerCurseEffectOnSelfPosPct = 5172,
        [Description("Thrown Shield Num Additional Projectiles")]
        ThrownShieldNumAdditionalProjectiles = 5173,
        [Description("Buff Damage While Stationery +%")]
        BuffDamageWhileStationeryPosPct = 5174,
        [Description("Buff Damage Taken While Stationery +%")]
        BuffDamageTakenWhileStationeryPosPct = 5175,
        [Description("Map Display Strongbox Monsters Are Enraged")]
        MapDisplayStrongboxMonstersAreEnraged = 5176,
        [Description("Celestial Footprints From Item")]
        CelestialFootprintsFromItem = 5177,
        [Description("Deal 1000 Chaos Damage Per Second For 10 Seconds On Hit")]
        Deal1000ChaosDamagePerSecondFor10SecondsOnHit = 5178,
        [Description("Map Strongboxes Minimum Rarity")]
        MapStrongboxesMinimumRarity = 5179,
        [Description("Map Area Contains X Additional Clusters Of Wealthy Barrels")]
        MapAreaContainsXAdditionalClustersOfWealthyBarrels = 5180,
        [Description("Map Area Contains X Additional Clusters Of Volatile Barrels")]
        MapAreaContainsXAdditionalClustersOfVolatileBarrels = 5181,
        [Description("Map Area Contains X Additional Clusters Of Bloodworm Barrels")]
        MapAreaContainsXAdditionalClustersOfBloodwormBarrels = 5182,
        [Description("Map Area Contains X Additional Clusters Of Parasite Barrels")]
        MapAreaContainsXAdditionalClustersOfParasiteBarrels = 5183,
        [Description("Map Area Contains X Additional Clusters Of Beacon Barrels")]
        MapAreaContainsXAdditionalClustersOfBeaconBarrels = 5184,
        [Description("Map Contains X Additional Rare Packs If Rare")]
        MapContainsXAdditionalRarePacksIfRare = 5185,
        [Description("Map Contains X Additional Magic Packs If Magic")]
        MapContainsXAdditionalMagicPacksIfMagic = 5186,
        [Description("Map Contains X Additional Normal Packs If Normal")]
        MapContainsXAdditionalNormalPacksIfNormal = 5187,
        [Description("Map Boss Drops X Additional Vaal Items")]
        MapBossDropsXAdditionalVaalItems = 5188,
        [Description("Fire Beam Length +%")]
        FireBeamLengthPosPct = 5189,
        [Description("Is Breach Monster")]
        IsBreachMonster = 5190,
        [Description("Cast Linked Spells On Shocked Enemy Kill %")]
        CastLinkedSpellsOnShockedEnemyKillPct = 5191,
        [Description("Map Equipment Drops Identified In Identified Areas")]
        MapEquipmentDropsIdentifiedInIdentifiedAreas = 5192,
        [Description("Map Items Drop Corrupted %")]
        MapItemsDropCorruptedPct = 5193,
        [Description("Doom Arrow Area Of Effect +% Final Per Frenzy Charge")]
        DoomArrowAreaOfEffectPosPctFinalPerFrenzyCharge = 5194,
        [Description("Bonespire Number Of Bone Piles To Spawn")]
        BonespireNumberOfBonePilesToSpawn = 5195,
        [Description("Mortar Cone Angle")]
        MortarConeAngle = 5196,
        [Description("Current Consume Charges")]
        CurrentConsumeCharges = 5197,
        [Description("Maximum Consume Charges")]
        MaximumConsumeCharges = 5198,
        [Description("Expend Consume Charges On Skill Use")]
        ExpendConsumeChargesOnSkillUse = 5199,
        [Description("Gain Consume Charges On Skill Use")]
        GainConsumeChargesOnSkillUse = 5200,
        [Description("Secondary Skill Effect Duration +%")]
        SecondarySkillEffectDurationPosPct = 5201,
        [Description("X Armour Per Active Totem")]
        XArmourPerActiveTotem = 5202,
        [Description("Map Pack Size +% In Unidentified Areas")]
        MapPackSizePosPctInUnidentifiedAreas = 5203,
        [Description("Chance To Dodge % At Max Charged Attack Stacks")]
        ChanceToDodgePctAtMaxChargedAttackStacks = 5204,
        [Description("Critical Strikes Deal No Damage")]
        CriticalStrikesDealNoDamage = 5205,
        [Description("Spell Damage +% If Have Crit Recently")]
        SpellDamagePosPctIfHaveCritRecently = 5206,
        [Description("Critical Strike Multiplier + If Have Dealt Non Crit Recently")]
        CriticalStrikeMultiplierPosIfHaveDealtNonCritRecently = 5207,
        [Description("Track Have Dealt Non Crit Recently")]
        TrackHaveDealtNonCritRecently = 5208,
        [Description("Have Dealt Non Crit Recently")]
        HaveDealtNonCritRecently = 5209,
        [Description("Total Base Armour Rating")]
        TotalBaseArmourRating = 5210,
        [Description("Combined Only Armour +%")]
        CombinedOnlyArmourPosPct = 5211,
        [Description("Combined Armour +%")]
        CombinedArmourPosPct = 5212,
        [Description("Combined Only Armour +% Final")]
        CombinedOnlyArmourPosPctFinal = 5213,
        [Description("Combined Evasion Rating +% Final")]
        CombinedEvasionRatingPosPctFinal = 5214,
        [Description("Combined Only Armour From Shield +%")]
        CombinedOnlyArmourFromShieldPosPct = 5215,
        [Description("Combined Armour From Shield +%")]
        CombinedArmourFromShieldPosPct = 5216,
        [Description("Armour Differs Against Projectiles")]
        ArmourDiffersAgainstProjectiles = 5217,
        [Description("Armour While Stationary")]
        ArmourWhileStationary = 5218,
        [Description("Mana Regeneration Rate +% While Stationary")]
        ManaRegenerationRatePosPctWhileStationary = 5219,
        [Description("Non Critical Strikes Deal No Damage")]
        NonCriticalStrikesDealNoDamage = 5220,
        [Description("Chilled Ground When Hit With Attack %")]
        ChilledGroundWhenHitWithAttackPct = 5221,
        [Description("Critical Strike Multiplier + Per 1% Block Chance")]
        CriticalStrikeMultiplierPosPer1PctBlockChance = 5222,
        [Description("Local Flask Unholy Might During Flask Effect")]
        LocalFlaskUnholyMightDuringFlaskEffect = 5223,
        [Description("Spell Minimum Added Cold Damage Per Power Charge")]
        SpellMinimumAddedColdDamagePerPowerCharge = 5224,
        [Description("Spell Maximum Added Cold Damage Per Power Charge")]
        SpellMaximumAddedColdDamagePerPowerCharge = 5225,
        [Description("Recover X Mana On Killing Frozen Enemy")]
        RecoverXManaOnKillingFrozenEnemy = 5226,
        [Description("Chance To Gain Power Charge On Killing Frozen Enemy %")]
        ChanceToGainPowerChargeOnKillingFrozenEnemyPct = 5227,
        [Description("Damage +% If You Have Frozen Enemy Recently")]
        DamagePosPctIfYouHaveFrozenEnemyRecently = 5228,
        [Description("Track Have Frozen Enemy Recently")]
        TrackHaveFrozenEnemyRecently = 5229,
        [Description("Have Frozen Enemy Recently")]
        HaveFrozenEnemyRecently = 5230,
        [Description("Maximum Added Lightning Damage Per 10 Int")]
        MaximumAddedLightningDamagePer10Int = 5231,
        [Description("Attack Speed +% Per 25 Dex")]
        AttackSpeedPosPctPer25Dex = 5232,
        [Description("Number Of Shocked Enemies Killed Recently")]
        NumberOfShockedEnemiesKilledRecently = 5233,
        [Description("Minimum Added Lightning Damage Per Shocked Enemy Killed Recently")]
        MinimumAddedLightningDamagePerShockedEnemyKilledRecently = 5234,
        [Description("Maximum Added Lightning Damage Per Shocked Enemy Killed Recently")]
        MaximumAddedLightningDamagePerShockedEnemyKilledRecently = 5235,
        [Description("Reflect Shocks")]
        ReflectShocks = 5236,
        [Description("Movement Speed +% While Bleeding")]
        MovementSpeedPosPctWhileBleeding = 5237,
        [Description("Physical Damage Taken +% While Moving")]
        PhysicalDamageTakenPosPctWhileMoving = 5238,
        [Description("Physical Damage Reduction Rating % While Not Moving")]
        PhysicalDamageReductionRatingPctWhileNotMoving = 5239,
        [Description("Display Max Fire Beam Stacks")]
        DisplayMaxFireBeamStacks = 5240,
        [Description("Display Max Blight Stacks")]
        DisplayMaxBlightStacks = 5241,
        [Description("Virtual Track Movement")]
        VirtualTrackMovement = 5242,
        [Description("Is Moving")]
        IsMoving = 5243,
        [Description("Mass Flicker Strike Number Of Teleports")]
        MassFlickerStrikeNumberOfTeleports = 5244,
        [Description("Blind Chilled Enemies On Hit %")]
        BlindChilledEnemiesOnHitPct = 5245,
        [Description("Cold Damage +% Per Frenzy Charge")]
        ColdDamagePosPctPerFrenzyCharge = 5246,
        [Description("Gain Frenzy Charge On Reaching Maximum Power Charges")]
        GainFrenzyChargeOnReachingMaximumPowerCharges = 5247,
        [Description("Gain Frenzy Charge On Hit While Bleeding")]
        GainFrenzyChargeOnHitWhileBleeding = 5248,
        [Description("Virtual Chaos Damage Does Not Bypass Energy Shield")]
        VirtualChaosDamageDoesNotBypassEnergyShield = 5249,
        [Description("Chaos Damage Does Not Bypass Energy Shield While Not Low Life Or Mana")]
        ChaosDamageDoesNotBypassEnergyShieldWhileNotLowLifeOrMana = 5250,
        [Description("Local Display Grants Level X Reckoning")]
        LocalDisplayGrantsLevelXReckoning = 5251,
        [Description("Reflect Shocks To Enemies In Radius")]
        ReflectShocksToEnemiesInRadius = 5252,
        [Description("Recover % Maximum Life On Killing Poisoned Enemy")]
        RecoverPctMaximumLifeOnKillingPoisonedEnemy = 5253,
        [Description("Minions Recover % Maximum Life On Killing Poisoned Enemy")]
        MinionsRecoverPctMaximumLifeOnKillingPoisonedEnemy = 5254,
        [Description("Recover X Life On Enemy Ignited")]
        RecoverXLifeOnEnemyIgnited = 5255,
        [Description("Cold Penetration % Vs Chilled Enemies")]
        ColdPenetrationPctVsChilledEnemies = 5256,
        [Description("Local Display Grants Level X Envy")]
        LocalDisplayGrantsLevelXEnvy = 5257,
        [Description("Cast On Cyclone Contact %")]
        CastOnCycloneContactPct = 5258,
        [Description("Cyclone Has Triggered Skill")]
        CycloneHasTriggeredSkill = 5259,
        [Description("Minions Chance To Poison On Hit %")]
        MinionsChanceToPoisonOnHitPct = 5260,
        [Description("X Armour If You Have Blocked Recently")]
        XArmourIfYouHaveBlockedRecently = 5261,
        [Description("Enemies Explode On Kill")]
        EnemiesExplodeOnKill = 5262,
        [Description("Local Display Attack With Level X Bone Nova On Bleeding Enemy Kill")]
        LocalDisplayAttackWithLevelXBoneNovaOnBleedingEnemyKill = 5263,
        [Description("Attack Trigger On Killing Bleeding Enemy %")]
        AttackTriggerOnKillingBleedingEnemyPct = 5264,
        [Description("Permanently Intimidate Enemy On Block")]
        PermanentlyIntimidateEnemyOnBlock = 5265,
        [Description("Receive Bleeding Chance % When Hit By Attack")]
        ReceiveBleedingChancePctWhenHitByAttack = 5266,
        [Description("Attacks Cause Bleeding Vs Cursed Enemies")]
        AttacksCauseBleedingVsCursedEnemies = 5267,
        [Description("Armour Increased By Uncapped Fire Resistance")]
        ArmourIncreasedByUncappedFireResistance = 5268,
        [Description("Evasion Rating Increased By Uncapped Cold Resistance")]
        EvasionRatingIncreasedByUncappedColdResistance = 5269,
        [Description("Critical Strike Chance Increased By Uncapped Lightning Resistance")]
        CriticalStrikeChanceIncreasedByUncappedLightningResistance = 5270,
        [Description("Combined Critical Strike Chance +%")]
        CombinedCriticalStrikeChancePosPct = 5271,
        [Description("Combined Critical Strike Chance +% Final")]
        CombinedCriticalStrikeChancePosPctFinal = 5272,
        [Description("Totems Cannot Evade")]
        TotemsCannotEvade = 5273,
        [Description("Disable Seek Seal Prophecies")]
        DisableSeekSealProphecies = 5274,
        [Description("Mortar Distance In Front Of Target")]
        MortarDistanceInFrontOfTarget = 5275,
        [Description("Apply Covered In Ash To Attacker When Hit %")]
        ApplyCoveredInAshToAttackerWhenHitPct = 5276,
        [Description("Covered In Ash Movement Speed +% Final")]
        CoveredInAshMovementSpeedPosPctFinal = 5277,
        [Description("Secondary Total Minimum Base Physical Damage")]
        SecondaryTotalMinimumBasePhysicalDamage = 5278,
        [Description("Secondary Total Maximum Base Physical Damage")]
        SecondaryTotalMaximumBasePhysicalDamage = 5279,
        [Description("Minimum Secondary Physical Damage Per 15 Strength")]
        MinimumSecondaryPhysicalDamagePer15Strength = 5280,
        [Description("Maximum Secondary Physical Damage Per 15 Strength")]
        MaximumSecondaryPhysicalDamagePer15Strength = 5281,
        [Description("Flame Geyser Number Of Splits")]
        FlameGeyserNumberOfSplits = 5282,
        [Description("Keystone Avatar Of Fire")]
        KeystoneAvatarOfFire = 5283,
        [Description("Keystone Eldritch Battery")]
        KeystoneEldritchBattery = 5284,
        [Description("Keystone Ancestral Bond")]
        KeystoneAncestralBond = 5285,
        [Description("Skeletal Chains No Minions Damage +% Final")]
        SkeletalChainsNoMinionsDamagePosPctFinal = 5286,
        [Description("Virtual Energy Shield Protects Mana")]
        VirtualEnergyShieldProtectsMana = 5287,
        [Description("Virtual Spend Energy Shield For Costs Before Mana")]
        VirtualSpendEnergyShieldForCostsBeforeMana = 5288,
        [Description("Shock Nova Skill Area Of Effect +% Per Contact Point")]
        ShockNovaSkillAreaOfEffectPosPctPerContactPoint = 5289,
        [Description("Spell Skills Deal No Damage")]
        SpellSkillsDealNoDamage = 5290,
        [Description("Ignite Proliferation Radius")]
        IgniteProliferationRadius = 5291,
        [Description("Base Ignite Proliferation Radius")]
        BaseIgniteProliferationRadius = 5292,
        [Description("Transition Objects At State")]
        TransitionObjectsAtState = 5293,
        [Description("Fire Beam Enemy Fire Resistance % At Max Stacks")]
        FireBeamEnemyFireResistancePctAtMaxStacks = 5294,
        [Description("Attack Damage +1% Per 300 Of Min Of Armour Or Evasion")]
        AttackDamagePos1PctPer300OfMinOfArmourOrEvasion = 5295,
        [Description("Chance To Fortify On Melee Stun %")]
        ChanceToFortifyOnMeleeStunPct = 5296,
        [Description("Gain Onslaught While You Have Fortify")]
        GainOnslaughtWhileYouHaveFortify = 5297,
        [Description("Local Six Linked Random Sockets")]
        LocalSixLinkedRandomSockets = 5298,
        [Description("Local Can Only Socket Corrupted Gems")]
        LocalCanOnlySocketCorruptedGems = 5299,
        [Description("Fire Beam Enemy Fire Resistance % Maximum")]
        FireBeamEnemyFireResistancePctMaximum = 5300,
        [Description("Proximity Shield Ground Lightning Duration Ms")]
        ProximityShieldGroundLightningDurationMs = 5301,
        [Description("Map Player Charges Gained +%")]
        MapPlayerChargesGainedPosPct = 5302,
        [Description("Curse Effect On Self +% Final")]
        CurseEffectOnSelfPosPctFinal = 5303,
        [Description("Map Monsters Curse Effect On Self +% Final")]
        MapMonstersCurseEffectOnSelfPosPctFinal = 5304,
        [Description("Map Monsters % Chance To Inflict Status Ailments")]
        MapMonstersPctChanceToInflictStatusAilments = 5305,
        [Description("Map Monsters Movement Speed Cannot Be Reduced Below Base")]
        MapMonstersMovementSpeedCannotBeReducedBelowBase = 5306,
        [Description("Map Monsters Cannot Be Taunted")]
        MapMonstersCannotBeTaunted = 5307,
        [Description("Map Monsters Always Ignite")]
        MapMonstersAlwaysIgnite = 5308,
        [Description("Map Monsters Additional Chaos Resistance")]
        MapMonstersAdditionalChaosResistance = 5309,
        [Description("Map Monsters Avoid Poison Blind Bleed %")]
        MapMonstersAvoidPoisonBlindBleedPct = 5310,
        [Description("Base Avoid Poison %")]
        BaseAvoidPoisonPct = 5311,
        [Description("Map Players Have Point Blank")]
        MapPlayersHavePointBlank = 5312,
        [Description("Map Players Block Chance +%")]
        MapPlayersBlockChancePosPct = 5313,
        [Description("Map Players Armour +% Final")]
        MapPlayersArmourPosPctFinal = 5314,
        [Description("Map Monsters Accuracy Rating +%")]
        MapMonstersAccuracyRatingPosPct = 5315,
        [Description("Map Players Extra Dodge Rolls")]
        MapPlayersExtraDodgeRolls = 5316,
        [Description("Extra Dodge Rolls")]
        ExtraDodgeRolls = 5317,
        [Description("Map Players Skill Area Of Effect +% Final")]
        MapPlayersSkillAreaOfEffectPosPctFinal = 5318,
        [Description("Cannot Gain Frenzy Charges")]
        CannotGainFrenzyCharges = 5319,
        [Description("Cannot Gain Power Charges")]
        CannotGainPowerCharges = 5320,
        [Description("Map Players Cannot Gain Power Charges")]
        MapPlayersCannotGainPowerCharges = 5321,
        [Description("Map Players Cannot Gain Frenzy Charges")]
        MapPlayersCannotGainFrenzyCharges = 5322,
        [Description("Map Players Cannot Gain Endurance Charges")]
        MapPlayersCannotGainEnduranceCharges = 5323,
        [Description("Map Players No Regeneration Including Es")]
        MapPlayersNoRegenerationIncludingEs = 5324,
        [Description("Map Player Life And Es Recovery Speed +% Final")]
        MapPlayerLifeAndEsRecoverySpeedPosPctFinal = 5325,
        [Description("Armour +% Final")]
        ArmourPosPctFinal = 5326,
        [Description("Map Packs Are Abomination Monsters")]
        MapPacksAreAbominationMonsters = 5327,
        [Description("Gain Frenzy Charge On Hitting Rare Or Unique Enemy %")]
        GainFrenzyChargeOnHittingRareOrUniqueEnemyPct = 5328,
        [Description("Onslaught Duration +%")]
        OnslaughtDurationPosPct = 5329,
        [Description("Curse On Hit Level 10 Vulnerability %")]
        CurseOnHitLevel10VulnerabilityPct = 5330,
        [Description("Local Item Stats Are Doubled In Breach")]
        LocalItemStatsAreDoubledInBreach = 5331,
        [Description("Cast On Crit %")]
        CastOnCritPct = 5332,
        [Description("Local Unique Jewel Cold And Lightning Resistance To Melee Damage")]
        LocalUniqueJewelColdAndLightningResistanceToMeleeDamage = 5333,
        [Description("Local Unique Jewel Fire And Lightning Resistance To Projectile Attack Damage")]
        LocalUniqueJewelFireAndLightningResistanceToProjectileAttackDamage = 5334,
        [Description("Local Unique Jewel Fire And Cold Resistance To Spell Damage")]
        LocalUniqueJewelFireAndColdResistanceToSpellDamage = 5335,
        [Description("Local Unique Jewel Fire Resistance Also Grants Block Chance Scaled %")]
        LocalUniqueJewelFireResistanceAlsoGrantsBlockChanceScaledPct = 5336,
        [Description("Local Unique Jewel Cold Resistance Also Grants Dodge Chance Scaled %")]
        LocalUniqueJewelColdResistanceAlsoGrantsDodgeChanceScaledPct = 5337,
        [Description("Local Unique Jewel Lightning Resistance Also Grants Block Spells Chance Scaled %")]
        LocalUniqueJewelLightningResistanceAlsoGrantsBlockSpellsChanceScaledPct = 5338,
        [Description("Local Unique Jewel Fire Resistance Also Grants Endurance Charge On Kill Chance")]
        LocalUniqueJewelFireResistanceAlsoGrantsEnduranceChargeOnKillChance = 5339,
        [Description("Local Unique Jewel Cold Resistance Also Grants Frenzy Charge On Kill Chance")]
        LocalUniqueJewelColdResistanceAlsoGrantsFrenzyChargeOnKillChance = 5340,
        [Description("Local Unique Jewel Lightning Resistance Also Grants Power Charge On Kill Chance")]
        LocalUniqueJewelLightningResistanceAlsoGrantsPowerChargeOnKillChance = 5341,
        [Description("Cast While Channelling Time Ms")]
        CastWhileChannellingTimeMs = 5342,
        [Description("Support Cast While Channelling Triggered Skill Damage +% Final")]
        SupportCastWhileChannellingTriggeredSkillDamagePosPctFinal = 5343,
        [Description("Number Of Spider Minions Allowed")]
        NumberOfSpiderMinionsAllowed = 5344,
        [Description("Number Of Active Spider Minions")]
        NumberOfActiveSpiderMinions = 5345,
        [Description("Local Display Raise Spider On Kill % Chance")]
        LocalDisplayRaiseSpiderOnKillPctChance = 5346,
        [Description("Local Display Cast Lightning On Critical Strike")]
        LocalDisplayCastLightningOnCriticalStrike = 5347,
        [Description("Your Spells Are Disabled")]
        YourSpellsAreDisabled = 5348,
        [Description("Monster Ruleset Id")]
        MonsterRulesetId = 5349,
        [Description("Map Monsters Additional Elemental Resistance")]
        MapMonstersAdditionalElementalResistance = 5350,
        [Description("Support Minion Totem Resistance Elemental Damage +% Final")]
        SupportMinionTotemResistanceElementalDamagePosPctFinal = 5351,
        [Description("Elemental Damage +% Final On Minion From Resistance Support")]
        ElementalDamagePosPctFinalOnMinionFromResistanceSupport = 5352,
        [Description("Goat Footprints From Item")]
        GoatFootprintsFromItem = 5353,
        [Description("Totem Ignores Cooldown")]
        TotemIgnoresCooldown = 5354,
        [Description("Attack Minimum Added Lightning Damage Per 10 Int")]
        AttackMinimumAddedLightningDamagePer10Int = 5355,
        [Description("Attack Maximum Added Lightning Damage Per 10 Int")]
        AttackMaximumAddedLightningDamagePer10Int = 5356,
        [Description("Fire Damage +% Per 20 Strength")]
        FireDamagePosPctPer20Strength = 5357,
        [Description("Mana Recharge Rate Per Minute With All Corrupted Equipped Items")]
        ManaRechargeRatePerMinuteWithAllCorruptedEquippedItems = 5358,
        [Description("Life Leech Permyriad Vs Poisoned Enemies")]
        LifeLeechPermyriadVsPoisonedEnemies = 5359,
        [Description("Minion Life Leech Permyriad Vs Poisoned Enemies")]
        MinionLifeLeechPermyriadVsPoisonedEnemies = 5360,
        [Description("Display Vaal Breach No Drops Xp")]
        DisplayVaalBreachNoDropsXp = 5361,
        [Description("Golems Larger Aggro Radius")]
        GolemsLargerAggroRadius = 5362,
        [Description("Maximum Life % To Convert To Maximum Energy Shield")]
        MaximumLifePctToConvertToMaximumEnergyShield = 5363,
        [Description("Display Abberaths Hooves Skill Level")]
        DisplayAbberathsHoovesSkillLevel = 5364,
        [Description("Cannot Be Used As Minion")]
        CannotBeUsedAsMinion = 5365,
        [Description("Breach Map Time To Portal Ms")]
        BreachMapTimeToPortalMs = 5366,
        [Description("Breach Map Initial Time Ms")]
        BreachMapInitialTimeMs = 5367,
        [Description("Breach Team Warp Buff Damage Taken +%")]
        BreachTeamWarpBuffDamageTakenPosPct = 5368,
        [Description("Local Poison On Hit %")]
        LocalPoisonOnHitPct = 5369,
        [Description("Main Hand Local Poison On Hit %")]
        MainHandLocalPoisonOnHitPct = 5370,
        [Description("Off Hand Local Poison On Hit %")]
        OffHandLocalPoisonOnHitPct = 5371,
        [Description("Breach Team Warp Buff Movement Velocity +%")]
        BreachTeamWarpBuffMovementVelocityPosPct = 5372,
        [Description("Breach Team Warp Buff Lightning Damage +%")]
        BreachTeamWarpBuffLightningDamagePosPct = 5373,
        [Description("Base Blade Vortex Hit Rate Ms")]
        BaseBladeVortexHitRateMs = 5374,
        [Description("Blade Vortex Hit Rate Ms")]
        BladeVortexHitRateMs = 5375,
        [Description("Additional Maximum All Resistances % With No Endurance Charges")]
        AdditionalMaximumAllResistancesPctWithNoEnduranceCharges = 5376,
        [Description("Spell Damage +% While Shocked")]
        SpellDamagePosPctWhileShocked = 5377,
        [Description("Display Skill Minions Level Is Corpse Level")]
        DisplaySkillMinionsLevelIsCorpseLevel = 5378,
        [Description("Monster Beyond Portal Chance +%")]
        MonsterBeyondPortalChancePosPct = 5379,
        [Description("Life Leech Uses Chaos Damage")]
        LifeLeechUsesChaosDamage = 5380,
        [Description("Base Cannot Gain Endurance Charges")]
        BaseCannotGainEnduranceCharges = 5381,
        [Description("Gain Onslaught While At Maximum Endurance Charges")]
        GainOnslaughtWhileAtMaximumEnduranceCharges = 5382,
        [Description("Number Of Zombies Allowed +1 Per X Strength")]
        NumberOfZombiesAllowedPos1PerXStrength = 5383,
        [Description("Minions Gain Your Strength")]
        MinionsGainYourStrength = 5384,
        [Description("Avarius Cast On Charge Contact")]
        AvariusCastOnChargeContact = 5385,
        [Description("Zombie Damage Leeched As Life To You Permyriad If Over 1000 Strength")]
        ZombieDamageLeechedAsLifeToYouPermyriadIfOver1000Strength = 5386,
        [Description("Virtual Minion Additional Strength")]
        VirtualMinionAdditionalStrength = 5387,
        [Description("Virtual Zombie Damage Leeched As Life To You Permyriad")]
        VirtualZombieDamageLeechedAsLifeToYouPermyriad = 5388,
        [Description("Base Bleed Duration +%")]
        BaseBleedDurationPosPct = 5389,
        [Description("Item Found Rarity +1% Per X Rampage Stacks")]
        ItemFoundRarityPos1PctPerXRampageStacks = 5390,
        [Description("Is Channelling")]
        IsChannelling = 5391,
        [Description("Warcries Knock Back Enemies")]
        WarcriesKnockBackEnemies = 5392,
        [Description("Map Monsters No Drops Or Experience")]
        MapMonstersNoDropsOrExperience = 5393,
        [Description("Off Hand Minimum Added Physical Damage Per 5 Shield Armour And Evasion Rating")]
        OffHandMinimumAddedPhysicalDamagePer5ShieldArmourAndEvasionRating = 5394,
        [Description("Off Hand Maximum Added Physical Damage Per 5 Shield Armour And Evasion Rating")]
        OffHandMaximumAddedPhysicalDamagePer5ShieldArmourAndEvasionRating = 5395,
        [Description("Off Hand Minimum Added Physical Damage Per 5 Shield Armour")]
        OffHandMinimumAddedPhysicalDamagePer5ShieldArmour = 5396,
        [Description("Off Hand Maximum Added Physical Damage Per 5 Shield Armour")]
        OffHandMaximumAddedPhysicalDamagePer5ShieldArmour = 5397,
        [Description("Off Hand Minimum Added Physical Damage Per 5 Shield Evasion Rating")]
        OffHandMinimumAddedPhysicalDamagePer5ShieldEvasionRating = 5398,
        [Description("Off Hand Maximum Added Physical Damage Per 5 Shield Evasion Rating")]
        OffHandMaximumAddedPhysicalDamagePer5ShieldEvasionRating = 5399,
        [Description("Gain Vaal Soul On Hit Cooldown Ms")]
        GainVaalSoulOnHitCooldownMs = 5400,
        [Description("Unique Spells Triggered On Shocked Kill")]
        UniqueSpellsTriggeredOnShockedKill = 5401,
        [Description("Maximum Life Per 2% Increased Item Found Rarity")]
        MaximumLifePer2PctIncreasedItemFoundRarity = 5402,
        [Description("Damage +% Per 1% Increased Item Found Quantity")]
        DamagePosPctPer1PctIncreasedItemFoundQuantity = 5403,
        [Description("Item Found Quantity +% Per Chest Opened Recently")]
        ItemFoundQuantityPosPctPerChestOpenedRecently = 5404,
        [Description("Number Of Chests Opened Recently")]
        NumberOfChestsOpenedRecently = 5405,
        [Description("Track Number Of Chests Opened Recently")]
        TrackNumberOfChestsOpenedRecently = 5406,
        [Description("Movement Speed +% Per Chest Opened Recently")]
        MovementSpeedPosPctPerChestOpenedRecently = 5407,
        [Description("Immune To Burning Shocks And Chilled Ground")]
        ImmuneToBurningShocksAndChilledGround = 5408,
        [Description("Maximum Life Per 10 Dexterity")]
        MaximumLifePer10Dexterity = 5409,
        [Description("Life Regeneration Per Minute While Moving")]
        LifeRegenerationPerMinuteWhileMoving = 5410,
        [Description("Chest Number Of Additional Pirate Uniques To Drop")]
        ChestNumberOfAdditionalPirateUniquesToDrop = 5411,
        [Description("Shrapnel Shot Number Of Additional Cones")]
        ShrapnelShotNumberOfAdditionalCones = 5412,
        [Description("Local Unique Jewel Shrapnel Shot Number Of Additional Cones With 50 Dex In Radius")]
        LocalUniqueJewelShrapnelShotNumberOfAdditionalConesWith50DexInRadius = 5413,
        [Description("Burning Arrow Additional Ignite Stacks")]
        BurningArrowAdditionalIgniteStacks = 5414,
        [Description("Local Unique Jewel Burning Arrow Additional Ignite Stacks With 50 Dex In Radius")]
        LocalUniqueJewelBurningArrowAdditionalIgniteStacksWith50DexInRadius = 5415,
        [Description("Cleave Fortify On Hit")]
        CleaveFortifyOnHit = 5416,
        [Description("Local Unique Jewel Cleave Fortify On Hit With 50 Str In Radius")]
        LocalUniqueJewelCleaveFortifyOnHitWith50StrInRadius = 5417,
        [Description("Cleave Skill Area Of Effect +% Per Nearby Enemy")]
        CleaveSkillAreaOfEffectPosPctPerNearbyEnemy = 5418,
        [Description("Local Unique Jewel Cleave Skill Area Of Effect +% Per Nearby Enemy With 50 Str In Radius")]
        LocalUniqueJewelCleaveSkillAreaOfEffectPosPctPerNearbyEnemyWith50StrInRadius = 5419,
        [Description("Freezing Pulse Number Of Additional Projectiles")]
        FreezingPulseNumberOfAdditionalProjectiles = 5420,
        [Description("Local Unique Jewel Freezing Pulse Number Of Additional Projectiles With 50 Int In Radius")]
        LocalUniqueJewelFreezingPulseNumberOfAdditionalProjectilesWith50IntInRadius = 5421,
        [Description("Freezing Pulse Damage +% If Enemy Shattered Recently")]
        FreezingPulseDamagePosPctIfEnemyShatteredRecently = 5422,
        [Description("Local Unique Jewel Freezing Pulse Damage +% If Enemy Shattered Recently With 50 Int In Radius")]
        LocalUniqueJewelFreezingPulseDamagePosPctIfEnemyShatteredRecentlyWith50IntInRadius = 5423,
        [Description("Local Unique Jewel Ice Shot Explosion Skill Area Of Effect +% With 50 Dex In Radius")]
        LocalUniqueJewelIceShotExplosionSkillAreaOfEffectPosPctWith50DexInRadius = 5424,
        [Description("Ice Shot Damage +% To Chilled Enemies")]
        IceShotDamagePosPctToChilledEnemies = 5425,
        [Description("Local Unique Jewel Ice Shot Damage +% To Chilled Enemies With 50 Dex In Radius")]
        LocalUniqueJewelIceShotDamagePosPctToChilledEnemiesWith50DexInRadius = 5426,
        [Description("Local Unique Jewel Molten Strike Number Of Additional Projectiles With 50 Str In Radius")]
        LocalUniqueJewelMoltenStrikeNumberOfAdditionalProjectilesWith50StrInRadius = 5427,
        [Description("Local Unique Jewel Molten Strike Skill Area Of Effect +% With 50 Str In Radius")]
        LocalUniqueJewelMoltenStrikeSkillAreaOfEffectPosPctWith50StrInRadius = 5428,
        [Description("Frost Blades Melee Cold Damage +% Per Frenzy Charge")]
        FrostBladesMeleeColdDamagePosPctPerFrenzyCharge = 5429,
        [Description("Local Unique Jewel Frost Blades Melee Cold Damage +% Per Frenzy Charge With 50 Dex In Radius")]
        LocalUniqueJewelFrostBladesMeleeColdDamagePosPctPerFrenzyChargeWith50DexInRadius = 5430,
        [Description("Dual Strike Melee Splash With Off Hand Weapon")]
        DualStrikeMeleeSplashWithOffHandWeapon = 5431,
        [Description("Local Unique Jewel Dual Strike Melee Splash With Off Hand Weapon With 50 Dex In Radius")]
        LocalUniqueJewelDualStrikeMeleeSplashWithOffHandWeaponWith50DexInRadius = 5432,
        [Description("Frostbolt Projectile Acceleration")]
        FrostboltProjectileAcceleration = 5433,
        [Description("Local Unique Jewel Frostbolt Projectile Acceleration With 50 Int In Radius")]
        LocalUniqueJewelFrostboltProjectileAccelerationWith50IntInRadius = 5434,
        [Description("Ethereal Knives Projectiles Nova")]
        EtherealKnivesProjectilesNova = 5435,
        [Description("Local Unique Jewel Ethereal Knives Projectiles Nova With 50 Dex In Radius")]
        LocalUniqueJewelEtherealKnivesProjectilesNovaWith50DexInRadius = 5436,
        [Description("Ethereal Knives Number Of Additional Projectiles")]
        EtherealKnivesNumberOfAdditionalProjectiles = 5437,
        [Description("Local Unique Jewel Ethereal Knives Number Of Additional Projectiles With 50 Dex In Radius")]
        LocalUniqueJewelEtherealKnivesNumberOfAdditionalProjectilesWith50DexInRadius = 5438,
        [Description("Ethereal Knives Projectile Speed +% Per Frenzy Charge")]
        EtherealKnivesProjectileSpeedPosPctPerFrenzyCharge = 5439,
        [Description("Local Unique Jewel Ethereal Knives Projectile Speed +% Per Frenzy Charge With 50 Dex In Radius")]
        LocalUniqueJewelEtherealKnivesProjectileSpeedPosPctPerFrenzyChargeWith50DexInRadius = 5440,
        [Description("Ethereal Knives Grant Frenzy Charge On Kill")]
        EtherealKnivesGrantFrenzyChargeOnKill = 5441,
        [Description("Local Unique Jewel Ethereal Knives Grant Frenzy Charge On Kill With 50 Dex In Radius")]
        LocalUniqueJewelEtherealKnivesGrantFrenzyChargeOnKillWith50DexInRadius = 5442,
        [Description("Lightning Tendrils Skill Area Of Effect +% Per Enemy Hit")]
        LightningTendrilsSkillAreaOfEffectPosPctPerEnemyHit = 5443,
        [Description("Local Unique Jewel Lightning Tendrils Skill Area Of Effect +% Per Enemy Hit With 50 Int In Radius")]
        LocalUniqueJewelLightningTendrilsSkillAreaOfEffectPosPctPerEnemyHitWith50IntInRadius = 5444,
        [Description("Magma Orb Skill Area Of Effect +% Per Bounce")]
        MagmaOrbSkillAreaOfEffectPosPctPerBounce = 5445,
        [Description("Local Unique Jewel Magma Orb Skill Area Of Effect +% Per Bounce With 50 Int In Radius")]
        LocalUniqueJewelMagmaOrbSkillAreaOfEffectPosPctPerBounceWith50IntInRadius = 5446,
        [Description("Glacial Hammer Melee Splash With Cold Damage")]
        GlacialHammerMeleeSplashWithColdDamage = 5447,
        [Description("Local Unique Jewel Glacial Hammer Melee Splash With Cold Damage With 50 Str In Radius")]
        LocalUniqueJewelGlacialHammerMeleeSplashWithColdDamageWith50StrInRadius = 5448,
        [Description("Glacial Hammer Physical Damage % To Convert To Cold")]
        GlacialHammerPhysicalDamagePctToConvertToCold = 5449,
        [Description("Local Unique Jewel Glacial Hammer Physical Damage % To Convert To Cold With 50 Str In Radius")]
        LocalUniqueJewelGlacialHammerPhysicalDamagePctToConvertToColdWith50StrInRadius = 5450,
        [Description("Blight Skill Area Of Effect +% After 1 Second Channelling")]
        BlightSkillAreaOfEffectPosPctAfter1SecondChannelling = 5451,
        [Description("Local Unique Jewel Blight Skill Area Of Effect +% After 1 Second Channelling With 50 Int In Radius")]
        LocalUniqueJewelBlightSkillAreaOfEffectPosPctAfter1SecondChannellingWith50IntInRadius = 5452,
        [Description("Fortify On Hit")]
        FortifyOnHit = 5453,
        [Description("Melee Splash Cold Damage Only")]
        MeleeSplashColdDamageOnly = 5454,
        [Description("Track Have Shattered Recently")]
        TrackHaveShatteredRecently = 5455,
        [Description("Have Shattered Recently")]
        HaveShatteredRecently = 5456,
        [Description("Can Gain Vaal Souls From No Experience Monsters")]
        CanGainVaalSoulsFromNoExperienceMonsters = 5457,
        [Description("Maim On Hit %")]
        MaimOnHitPct = 5458,
        [Description("Total Skill Area Of Effect Radius +% Including Final")]
        TotalSkillAreaOfEffectRadiusPosPctIncludingFinal = 5459,
        [Description("Melee Splash Off Hand Only")]
        MeleeSplashOffHandOnly = 5460,
        [Description("Classic Remaining Areas To Apply Leaguestone")]
        ClassicRemainingAreasToApplyLeaguestone = 5461,
        [Description("Map Spawn Leaguestones")]
        MapSpawnLeaguestones = 5462,
        [Description("Monster Can Spawn With Leaguestone")]
        MonsterCanSpawnWithLeaguestone = 5463,
        [Description("Monster No Leaguestone")]
        MonsterNoLeaguestone = 5464,
        [Description("Local Unique Jewel Shrapnel Shot Cone % Chance To Deal Double Damage With 50 Dex In Radius")]
        LocalUniqueJewelShrapnelShotConePctChanceToDealDoubleDamageWith50DexInRadius = 5465,
        [Description("Shrapnel Shot Cone % Chance To Deal Double Damage")]
        ShrapnelShotConePctChanceToDealDoubleDamage = 5466,
        [Description("Local Unique Jewel Shrapnel Shot Radius +% With 50 Dex In Radius")]
        LocalUniqueJewelShrapnelShotRadiusPosPctWith50DexInRadius = 5467,
        [Description("Endurance Charge On Kill Percent Chance While Holding Shield")]
        EnduranceChargeOnKillPercentChanceWhileHoldingShield = 5468,
        [Description("Frenzy Charge On Kill Percent Chance While Holding Shield")]
        FrenzyChargeOnKillPercentChanceWhileHoldingShield = 5469,
        [Description("Power Charge On Kill Percent Chance While Holding Shield")]
        PowerChargeOnKillPercentChanceWhileHoldingShield = 5470,
        [Description("Block Chance % While Holding Shield")]
        BlockChancePctWhileHoldingShield = 5471,
        [Description("Dodge Chance % While Holding Shield")]
        DodgeChancePctWhileHoldingShield = 5472,
        [Description("Block Spells Chance % While Holding Shield")]
        BlockSpellsChancePctWhileHoldingShield = 5473,
        [Description("Local Unique Flask Elemental Damage Taken +% Of Lowest Uncapped Resistance Type")]
        LocalUniqueFlaskElementalDamageTakenPosPctOfLowestUncappedResistanceType = 5474,
        [Description("Local Unique Flask Elemental Penetration % Of Highest Uncapped Resistance Type")]
        LocalUniqueFlaskElementalPenetrationPctOfHighestUncappedResistanceType = 5475,
        [Description("Elemental Damage Taken +% Of Lowest Uncapped Resistance Type")]
        ElementalDamageTakenPosPctOfLowestUncappedResistanceType = 5476,
        [Description("Elemental Penetration % Of Highest Uncapped Resistance Type")]
        ElementalPenetrationPctOfHighestUncappedResistanceType = 5477,
        [Description("Virtual Fire Damage Taken +% From Lowest Uncapped Resistance Type")]
        VirtualFireDamageTakenPosPctFromLowestUncappedResistanceType = 5478,
        [Description("Virtual Cold Damage Taken +% From Lowest Uncapped Resistance Type")]
        VirtualColdDamageTakenPosPctFromLowestUncappedResistanceType = 5479,
        [Description("Virtual Lightning Damage Taken +% From Lowest Uncapped Resistance Type")]
        VirtualLightningDamageTakenPosPctFromLowestUncappedResistanceType = 5480,
        [Description("Virtual Fire Penetration % From Highest Uncapped Resistance Type")]
        VirtualFirePenetrationPctFromHighestUncappedResistanceType = 5481,
        [Description("Virtual Cold Penetration % From Highest Uncapped Resistance Type")]
        VirtualColdPenetrationPctFromHighestUncappedResistanceType = 5482,
        [Description("Virtual Lightning Penetration % From Highest Uncapped Resistance Type")]
        VirtualLightningPenetrationPctFromHighestUncappedResistanceType = 5483,
        [Description("Start At Zero Energy Shield")]
        StartAtZeroEnergyShield = 5484,
        [Description("Map Number Of Additional Silver Coin Drops")]
        MapNumberOfAdditionalSilverCoinDrops = 5485,
        [Description("Map Monsters That Drop Silver Coin Drop X Additional Silver Coins")]
        MapMonstersThatDropSilverCoinDropXAdditionalSilverCoins = 5486,
        [Description("Map Item Quantity From Monsters That Drop Silver Coin +%")]
        MapItemQuantityFromMonstersThatDropSilverCoinPosPct = 5487,
        [Description("Local Unique Jewel Spark Number Of Additional Projectiles With 50 Int In Radius")]
        LocalUniqueJewelSparkNumberOfAdditionalProjectilesWith50IntInRadius = 5488,
        [Description("Spark Num Of Additional Projectiles In Chain")]
        SparkNumOfAdditionalProjectilesInChain = 5489,
        [Description("Local Unique Jewel Spark Number Of Additional Chains With 50 Int In Radius")]
        LocalUniqueJewelSparkNumberOfAdditionalChainsWith50IntInRadius = 5490,
        [Description("Monster Slam Cooldown Speed +%")]
        MonsterSlamCooldownSpeedPosPct = 5491,
        [Description("Zombie Slam Cooldown Speed +%")]
        ZombieSlamCooldownSpeedPosPct = 5492,
        [Description("Local Unique Jewel Zombie Slam Cooldown Speed +% With 50 Int In Radius")]
        LocalUniqueJewelZombieSlamCooldownSpeedPosPctWith50IntInRadius = 5493,
        [Description("Monster Slam Damage +%")]
        MonsterSlamDamagePosPct = 5494,
        [Description("Zombie Slam Damage +%")]
        ZombieSlamDamagePosPct = 5495,
        [Description("Local Unique Jewel Zombie Slam Damage +% With 50 Int In Radius")]
        LocalUniqueJewelZombieSlamDamagePosPctWith50IntInRadius = 5496,
        [Description("Map Leaguestone Override Base Num Rogue Exiles")]
        MapLeaguestoneOverrideBaseNumRogueExiles = 5497,
        [Description("Map Rogue Exiles Are Doubled")]
        MapRogueExilesAreDoubled = 5498,
        [Description("Map Rogue Exile Drop Skill Gem With Quality")]
        MapRogueExileDropSkillGemWithQuality = 5499,
        [Description("Map Rogue Exile Attack Cast And Movement Speed +%")]
        MapRogueExileAttackCastAndMovementSpeedPosPct = 5500,
        [Description("Map Leaguestone Rogue Exiles Dropped Item Rarity +% Final")]
        MapLeaguestoneRogueExilesDroppedItemRarityPosPctFinal = 5501,
        [Description("Monster Drop Skill Gem With Quality")]
        MonsterDropSkillGemWithQuality = 5502,
        [Description("Map Leaguestone Override Base Num Breaches")]
        MapLeaguestoneOverrideBaseNumBreaches = 5503,
        [Description("Map Contains Additional Breaches")]
        MapContainsAdditionalBreaches = 5504,
        [Description("Map Rare Breach Monsters Drop Additional Shards")]
        MapRareBreachMonstersDropAdditionalShards = 5505,
        [Description("Map Breach Has Boss")]
        MapBreachHasBoss = 5506,
        [Description("Map Breach Has Large Chest")]
        MapBreachHasLargeChest = 5507,
        [Description("Map Breach Monster Quantity +%")]
        MapBreachMonsterQuantityPosPct = 5508,
        [Description("Map Leaguestone Override Base Num Monoliths")]
        MapLeaguestoneOverrideBaseNumMonoliths = 5509,
        [Description("Map Essence Monsters Have Additional Essences")]
        MapEssenceMonstersHaveAdditionalEssences = 5510,
        [Description("Map Essence Monsters Are Corrupted")]
        MapEssenceMonstersAreCorrupted = 5511,
        [Description("Map Essence Monsters Higher Tier")]
        MapEssenceMonstersHigherTier = 5512,
        [Description("Fire Beam Rotation Speed +%")]
        FireBeamRotationSpeedPosPct = 5513,
        [Description("Fire Beam Charge Up Time Ms")]
        FireBeamChargeUpTimeMs = 5514,
        [Description("Map Leaguestone Override Base Num Talismans")]
        MapLeaguestoneOverrideBaseNumTalismans = 5515,
        [Description("Map Talismans Higher Tier")]
        MapTalismansHigherTier = 5516,
        [Description("Map Talismans Dropped As Rare")]
        MapTalismansDroppedAsRare = 5517,
        [Description("Map Contains Talisman Boss With Higher Tier")]
        MapContainsTalismanBossWithHigherTier = 5518,
        [Description("Virtual Fire Damage Taken +%")]
        VirtualFireDamageTakenPosPct = 5519,
        [Description("Virtual Chaos Damage Taken +%")]
        VirtualChaosDamageTakenPosPct = 5520,
        [Description("Virtual Lightning Damage Taken +%")]
        VirtualLightningDamageTakenPosPct = 5521,
        [Description("Virtual Cold Damage Taken +%")]
        VirtualColdDamageTakenPosPct = 5522,
        [Description("Local Display Socketed Gems Supported By Level X Endurance Charge On Stun")]
        LocalDisplaySocketedGemsSupportedByLevelXEnduranceChargeOnStun = 5523,
        [Description("Number Of Generic Limited Minions Allowed")]
        NumberOfGenericLimitedMinionsAllowed = 5524,
        [Description("Number Of Active Generic Limited Minions")]
        NumberOfActiveGenericLimitedMinions = 5525,
        [Description("Local Unique Jewel Viper Strike Chance To Gain Unholy Might % On Hit Per Poison Stack On Enemy With 50 Dex In Radius")]
        LocalUniqueJewelViperStrikeChanceToGainUnholyMightPctOnHitPerPoisonStackOnEnemyWith50DexInRadius = 5526,
        [Description("Local Unique Jewel Ground Slam Chance To Gain Endurance Charge % On Stun With 50 Str In Radius")]
        LocalUniqueJewelGroundSlamChanceToGainEnduranceChargePctOnStunWith50StrInRadius = 5527,
        [Description("Viper Strike Chance To Gain Unholy Might % On Hit Per Poison Stack On Enemy")]
        ViperStrikeChanceToGainUnholyMightPctOnHitPerPoisonStackOnEnemy = 5528,
        [Description("Ground Slam Chance To Gain Endurance Charge % On Stun")]
        GroundSlamChanceToGainEnduranceChargePctOnStun = 5529,
        [Description("Classic Next Area Contains Talisman")]
        ClassicNextAreaContainsTalisman = 5530,
        [Description("Classic Next Area Contains Anarchy")]
        ClassicNextAreaContainsAnarchy = 5531,
        [Description("Map Area Contains Avatar Of Prophecy")]
        MapAreaContainsAvatarOfProphecy = 5532,
        [Description("Map Area Contains Avatar Of Breach")]
        MapAreaContainsAvatarOfBreach = 5533,
        [Description("Map Area Contains Avatar Of Essence")]
        MapAreaContainsAvatarOfEssence = 5534,
        [Description("Map Area Contains Avatar Of Perandus")]
        MapAreaContainsAvatarOfPerandus = 5535,
        [Description("Map Area Contains Avatar Of Anarchy")]
        MapAreaContainsAvatarOfAnarchy = 5536,
        [Description("Map Area Contains Avatar Of Talisman")]
        MapAreaContainsAvatarOfTalisman = 5537,
        [Description("Map Area Contains Avatar Of Tempest")]
        MapAreaContainsAvatarOfTempest = 5538,
        [Description("Map Random Area Prophecy")]
        MapRandomAreaProphecy = 5539,
        [Description("Map Contains Nevalis Monkey")]
        MapContainsNevalisMonkey = 5540,
        [Description("Armour +% While No Energy Shield")]
        ArmourPosPctWhileNoEnergyShield = 5541,
        [Description("Life Leech From Attack Damage Permyriad Vs Taunted Enemies")]
        LifeLeechFromAttackDamagePermyriadVsTauntedEnemies = 5542,
        [Description("Random Curse On Hit % Against Uncursed Enemies")]
        RandomCurseOnHitPctAgainstUncursedEnemies = 5543,
        [Description("Mana Leech From Attack Damage Permyriad Per Power Charge")]
        ManaLeechFromAttackDamagePermyriadPerPowerCharge = 5544,
        [Description("Virtual Life Leech From Attack Damage Permyriad")]
        VirtualLifeLeechFromAttackDamagePermyriad = 5545,
        [Description("Virtual Mana Leech From Attack Damage Permyriad")]
        VirtualManaLeechFromAttackDamagePermyriad = 5546,
        [Description("Gain X Life On Stun")]
        GainXLifeOnStun = 5547,
        [Description("Blood Offering % Of Life To Lose")]
        BloodOfferingPctOfLifeToLose = 5548,
        [Description("Blood Offering % Of Lost Life To Regenerate As Life Per Second")]
        BloodOfferingPctOfLostLifeToRegenerateAsLifePerSecond = 5549,
        [Description("Blood Offering Life Regenerated +% Final Per Corpse")]
        BloodOfferingLifeRegeneratedPosPctFinalPerCorpse = 5550,
        [Description("Damage +% Vs Chilled Enemies")]
        DamagePosPctVsChilledEnemies = 5551,
        [Description("Additional Block % While On Consecrated Ground")]
        AdditionalBlockPctWhileOnConsecratedGround = 5552,
        [Description("Warcry Buff Effect +%")]
        WarcryBuffEffectPosPct = 5553,
        [Description("Spell And Attack Minimum Added Fire Damage")]
        SpellAndAttackMinimumAddedFireDamage = 5554,
        [Description("Spell And Attack Maximum Added Fire Damage")]
        SpellAndAttackMaximumAddedFireDamage = 5555,
        [Description("Resist All Elements % With 200 Or More Strength")]
        ResistAllElementsPctWith200OrMoreStrength = 5556,
        [Description("Spell Block % If Blocked An Attack Recently")]
        SpellBlockPctIfBlockedAnAttackRecently = 5557,
        [Description("Track Have Blocked Spell Recently")]
        TrackHaveBlockedSpellRecently = 5558,
        [Description("Have Blocked Spell Recently")]
        HaveBlockedSpellRecently = 5559,
        [Description("Attack Block % If Blocked A Spell Recently")]
        AttackBlockPctIfBlockedASpellRecently = 5560,
        [Description("Life Regeneration Rate Per Minute % If Have Been Hit Recently")]
        LifeRegenerationRatePerMinutePctIfHaveBeenHitRecently = 5561,
        [Description("Life Regeneration Rate Per Minute % With 400 Or More Strength")]
        LifeRegenerationRatePerMinutePctWith400OrMoreStrength = 5562,
        [Description("Ground Tar When Hit % Chance")]
        GroundTarWhenHitPctChance = 5563,
        [Description("Spell And Attack Minimum Added Chaos Damage During Flask Effect")]
        SpellAndAttackMinimumAddedChaosDamageDuringFlaskEffect = 5564,
        [Description("Spell And Attack Maximum Added Chaos Damage During Flask Effect")]
        SpellAndAttackMaximumAddedChaosDamageDuringFlaskEffect = 5565,
        [Description("Fire Damage +% If You Have Been Hit Recently")]
        FireDamagePosPctIfYouHaveBeenHitRecently = 5566,
        [Description("Immune To Freeze And Chill While Ignited")]
        ImmuneToFreezeAndChillWhileIgnited = 5567,
        [Description("Fire Penetration % If You Have Blocked Recently")]
        FirePenetrationPctIfYouHaveBlockedRecently = 5568,
        [Description("Local Display Grants Level X Vengeance")]
        LocalDisplayGrantsLevelXVengeance = 5569,
        [Description("Gain X Power Charges On Using A Warcry")]
        GainXPowerChargesOnUsingAWarcry = 5570,
        [Description("Gain Onslaught Ms On Using A Warcry")]
        GainOnslaughtMsOnUsingAWarcry = 5571,
        [Description("Local Display Socketed Golem Buff Effect +%")]
        LocalDisplaySocketedGolemBuffEffectPosPct = 5572,
        [Description("Local Display Socketed Golem Chance To Taunt %")]
        LocalDisplaySocketedGolemChanceToTauntPct = 5573,
        [Description("Local Display Socketed Golem Life Regeneration Rate Per Minute %")]
        LocalDisplaySocketedGolemLifeRegenerationRatePerMinutePct = 5574,
        [Description("Minimum Added Cold Damage Vs Chilled Enemies")]
        MinimumAddedColdDamageVsChilledEnemies = 5575,
        [Description("Maximum Added Cold Damage Vs Chilled Enemies")]
        MaximumAddedColdDamageVsChilledEnemies = 5576,
        [Description("Map Area Contains Avatar Of Rampage")]
        MapAreaContainsAvatarOfRampage = 5577,
        [Description("Map Area Contains Avatar Of Beyond")]
        MapAreaContainsAvatarOfBeyond = 5578,
        [Description("Map Area Contains Avatar Of Onslaught")]
        MapAreaContainsAvatarOfOnslaught = 5579,
        [Description("Map Area Contains Avatar Of Ambush")]
        MapAreaContainsAvatarOfAmbush = 5580,
        [Description("Map Area Contains Avatar Of Bloodlines")]
        MapAreaContainsAvatarOfBloodlines = 5581,
        [Description("Map Area Contains Avatar Of Nemesis")]
        MapAreaContainsAvatarOfNemesis = 5582,
        [Description("Map Area Contains Avatar Of Torment")]
        MapAreaContainsAvatarOfTorment = 5583,
        [Description("Map Area Contains Avatar Of Domination")]
        MapAreaContainsAvatarOfDomination = 5584,
        [Description("Map Area Contains Avatar Of Invasion")]
        MapAreaContainsAvatarOfInvasion = 5585,
        [Description("Map Area Contains Avatar Of Warbands")]
        MapAreaContainsAvatarOfWarbands = 5586,
        [Description("Avoid Freeze And Chill % If You Have Used A Fire Skill Recently")]
        AvoidFreezeAndChillPctIfYouHaveUsedAFireSkillRecently = 5587,
        [Description("Track Have Used A Fire Skill Recently")]
        TrackHaveUsedAFireSkillRecently = 5588,
        [Description("Have Used A Fire Skill Recently")]
        HaveUsedAFireSkillRecently = 5589,
        [Description("Avoid Shock % While Chilled")]
        AvoidShockPctWhileChilled = 5590,
        [Description("Local Display Nearby Enemies Are Intimidated")]
        LocalDisplayNearbyEnemiesAreIntimidated = 5591,
        [Description("Chance To Shock Chilled Enemies %")]
        ChanceToShockChilledEnemiesPct = 5592,
        [Description("Map Area Contains Map Chest")]
        MapAreaContainsMapChest = 5593,
        [Description("Map Area Contains Unique Item Chest")]
        MapAreaContainsUniqueItemChest = 5594,
        [Description("Map Area Contains Currency Chest")]
        MapAreaContainsCurrencyChest = 5595,
        [Description("Map Area Contains Perandus Coin Chest")]
        MapAreaContainsPerandusCoinChest = 5596,
        [Description("Map Area Contains Jewellery Chest")]
        MapAreaContainsJewelleryChest = 5597,
        [Description("Perandus Double Number Of Coins Found")]
        PerandusDoubleNumberOfCoinsFound = 5598,
        [Description("Local Chill On Hit Ms If In Off Hand")]
        LocalChillOnHitMsIfInOffHand = 5599,
        [Description("Off Hand Local Chill On Hit Ms")]
        OffHandLocalChillOnHitMs = 5600,
        [Description("Movement Speed +% On Throwing Trap")]
        MovementSpeedPosPctOnThrowingTrap = 5601,
        [Description("Herald Of Thunder Buff Effect +%")]
        HeraldOfThunderBuffEffectPosPct = 5602,
        [Description("Local Display Movement Speed +% For You And Nearby Allies")]
        LocalDisplayMovementSpeedPosPctForYouAndNearbyAllies = 5603,
        [Description("Curse On Hit Level Flammability")]
        CurseOnHitLevelFlammability = 5604,
        [Description("Phasing On Trap Triggered By An Enemy Ms")]
        PhasingOnTrapTriggeredByAnEnemyMs = 5605,
        [Description("Global Attack Speed +% Per Level")]
        GlobalAttackSpeedPosPctPerLevel = 5606,
        [Description("Physical Damage +% Final For Minion")]
        PhysicalDamagePosPctFinalForMinion = 5607,
        [Description("Zombie Physical Damage +% Final")]
        ZombiePhysicalDamagePosPctFinal = 5608,
        [Description("Ground Tar When Hit Base Area Of Effect Radius")]
        GroundTarWhenHitBaseAreaOfEffectRadius = 5609,
        [Description("Ground Tar When Hit Duration Ms")]
        GroundTarWhenHitDurationMs = 5610,
        [Description("Ground Tar When Hit Movement Speed +%")]
        GroundTarWhenHitMovementSpeedPosPct = 5611,
        [Description("Chance To Gain Unholy Might On Block Ms")]
        ChanceToGainUnholyMightOnBlockMs = 5612,
        [Description("Old Dagger Implicit Critical Strike Chance +30%")]
        OldDaggerImplicitCriticalStrikeChancePos30Pct = 5613,
        [Description("Old Dagger Implicit Critical Strike Chance +40%")]
        OldDaggerImplicitCriticalStrikeChancePos40Pct = 5614,
        [Description("Old Dagger Implicit Critical Strike Chance +50%")]
        OldDaggerImplicitCriticalStrikeChancePos50Pct = 5615,
        [Description("Old Dagger Implicit Critical Strike Chance +30% From Main Hand")]
        OldDaggerImplicitCriticalStrikeChancePos30PctFromMainHand = 5616,
        [Description("Old Dagger Implicit Critical Strike Chance +40% From Main Hand")]
        OldDaggerImplicitCriticalStrikeChancePos40PctFromMainHand = 5617,
        [Description("Old Dagger Implicit Critical Strike Chance +50% From Main Hand")]
        OldDaggerImplicitCriticalStrikeChancePos50PctFromMainHand = 5618,
        [Description("Old Dagger Implicit Critical Strike Chance +30% From Off Hand")]
        OldDaggerImplicitCriticalStrikeChancePos30PctFromOffHand = 5619,
        [Description("Old Dagger Implicit Critical Strike Chance +40% From Off Hand")]
        OldDaggerImplicitCriticalStrikeChancePos40PctFromOffHand = 5620,
        [Description("Old Dagger Implicit Critical Strike Chance +50% From Off Hand")]
        OldDaggerImplicitCriticalStrikeChancePos50PctFromOffHand = 5621,
        [Description("Has Defender Conditional Damage Stats")]
        HasDefenderConditionalDamageStats = 5622,
        [Description("Area Transition Animation Index")]
        AreaTransitionAnimationIndex = 5623,
        [Description("Map Leaguestone Override Base Num Tormented Spirits")]
        MapLeaguestoneOverrideBaseNumTormentedSpirits = 5624,
        [Description("Map Leaguestone Additional Tormented Spirits")]
        MapLeaguestoneAdditionalTormentedSpirits = 5625,
        [Description("Map Random Unique Monster Is Possessed")]
        MapRandomUniqueMonsterIsPossessed = 5626,
        [Description("Map Tormented Spirits Drop X Additional Rare Items")]
        MapTormentedSpiritsDropXAdditionalRareItems = 5627,
        [Description("Map Area Contains Tormented Vaal Cultist")]
        MapAreaContainsTormentedVaalCultist = 5628,
        [Description("Map Area Contains Tormented Seditionist")]
        MapAreaContainsTormentedSeditionist = 5629,
        [Description("Map Area Contains Tormented Embezzler")]
        MapAreaContainsTormentedEmbezzler = 5630,
        [Description("Map Leaguestone Override Base Num Perandus Chests")]
        MapLeaguestoneOverrideBaseNumPerandusChests = 5631,
        [Description("Display Monster Uses Vaal Burning Arrow")]
        DisplayMonsterUsesVaalBurningArrow = 5632,
        [Description("Remove Parent Life On Death Permyriad")]
        RemoveParentLifeOnDeathPermyriad = 5633,
        [Description("Curse On Hit Level Projectile Weakness")]
        CurseOnHitLevelProjectileWeakness = 5634,
        [Description("Local Left Ring Slot Maximum Mana")]
        LocalLeftRingSlotMaximumMana = 5635,
        [Description("Local Right Ring Slot Energy Shield")]
        LocalRightRingSlotEnergyShield = 5636,
        [Description("Map Leaguestone Additional Breaches")]
        MapLeaguestoneAdditionalBreaches = 5637,
        [Description("Map Leaguestone Additional Monoliths")]
        MapLeaguestoneAdditionalMonoliths = 5638,
        [Description("Map Leaguestone Additional Talismans")]
        MapLeaguestoneAdditionalTalismans = 5639,
        [Description("Map Leaguestone Additional Rogue Exiles")]
        MapLeaguestoneAdditionalRogueExiles = 5640,
        [Description("Map Leaguestone Additional Perandus Chests")]
        MapLeaguestoneAdditionalPerandusChests = 5641,
        [Description("Local Left Ring Slot Mana Regeneration Rate Per Minute")]
        LocalLeftRingSlotManaRegenerationRatePerMinute = 5642,
        [Description("Local Right Ring Slot Maximum Mana")]
        LocalRightRingSlotMaximumMana = 5643,
        [Description("Local Left Ring Slot Energy Shield")]
        LocalLeftRingSlotEnergyShield = 5644,
        [Description("Local Display Cast Level X Consecrate On Crit")]
        LocalDisplayCastLevelXConsecrateOnCrit = 5645,
        [Description("Is Tormented Spirit")]
        IsTormentedSpirit = 5646,
        [Description("Shavronne Teleport Number Of Markers")]
        ShavronneTeleportNumberOfMarkers = 5647,
        [Description("Map Packs Are Spiders")]
        MapPacksAreSpiders = 5648,
        [Description("Map Packs Are Blackguards")]
        MapPacksAreBlackguards = 5649,
        [Description("Local Display Cast Level 1 Summon Lesser Shrine On Kill %")]
        LocalDisplayCastLevel1SummonLesserShrineOnKillPct = 5650,
        [Description("Shavronne Teleport No Teleport")]
        ShavronneTeleportNoTeleport = 5651,
        [Description("Debug Projectile Index Override")]
        DebugProjectileIndexOverride = 5652,
        [Description("Ground Slam Retarget After Contact Point")]
        GroundSlamRetargetAfterContactPoint = 5653,
        [Description("Map Leaguestone Override Base Num Warband Packs")]
        MapLeaguestoneOverrideBaseNumWarbandPacks = 5654,
        [Description("Map Leaguestone Additional Warband Packs")]
        MapLeaguestoneAdditionalWarbandPacks = 5655,
        [Description("Map Leaguestone Explicit Warband Type Override")]
        MapLeaguestoneExplicitWarbandTypeOverride = 5656,
        [Description("Map Leaguestone Contains Warband Leader")]
        MapLeaguestoneContainsWarbandLeader = 5657,
        [Description("Map Leaguestone Override Base Num Shrines")]
        MapLeaguestoneOverrideBaseNumShrines = 5658,
        [Description("Map Leaguestone Shrine Monster Rarity Override")]
        MapLeaguestoneShrineMonsterRarityOverride = 5659,
        [Description("Map Leaguestone Shrine Override Type")]
        MapLeaguestoneShrineOverrideType = 5660,
        [Description("Map Rampage Time +%")]
        MapRampageTimePosPct = 5661,
        [Description("Map Contains X Additional Animated Weapon Packs")]
        MapContainsXAdditionalAnimatedWeaponPacks = 5662,
        [Description("Map Leaguestones Currency Items Drop When First Reaching X Rampage Stacks")]
        MapLeaguestonesCurrencyItemsDropWhenFirstReachingXRampageStacks = 5663,
        [Description("Map Leaguestones Spawn Powerful Monster When Reaching X Rampage Stacks")]
        MapLeaguestonesSpawnPowerfulMonsterWhenReachingXRampageStacks = 5664,
        [Description("Map Contains Keepers Of The Trove Bloodline Pack")]
        MapContainsKeepersOfTheTroveBloodlinePack = 5665,
        [Description("Map Contains Wealthy Pack")]
        MapContainsWealthyPack = 5666,
        [Description("Map Leaguestone Implicit Tempest Random")]
        MapLeaguestoneImplicitTempestRandom = 5667,
        [Description("Map Leaguestone Explicit Tempest Type Override")]
        MapLeaguestoneExplicitTempestTypeOverride = 5668,
        [Description("Local Unique Jewel Frostbolt Additional Projectiles With 40 Int In Radius")]
        LocalUniqueJewelFrostboltAdditionalProjectilesWith40IntInRadius = 5669,
        [Description("Frostbolt Number Of Additional Projectiles")]
        FrostboltNumberOfAdditionalProjectiles = 5670,
        [Description("Skill Area Of Effect +% Final")]
        SkillAreaOfEffectPosPctFinal = 5671,
        [Description("Total Skill Area Of Effect +% Including Final")]
        TotalSkillAreaOfEffectPosPctIncludingFinal = 5672,
        [Description("Local Unique Jewel Magma Orb Additional Projectiles With 40 Int In Radius")]
        LocalUniqueJewelMagmaOrbAdditionalProjectilesWith40IntInRadius = 5673,
        [Description("Magma Orb Number Of Additional Projectiles")]
        MagmaOrbNumberOfAdditionalProjectiles = 5674,
        [Description("Curse On Hit Level Cold Weakness")]
        CurseOnHitLevelColdWeakness = 5675,
        [Description("Elemental Damage +% If Used A Warcry Recently")]
        ElementalDamagePosPctIfUsedAWarcryRecently = 5676,
        [Description("Local Display Socketed Golem Attack And Cast Speed +%")]
        LocalDisplaySocketedGolemAttackAndCastSpeedPosPct = 5677,
        [Description("Local Display Cast Animate Weapon On Kill % Chance")]
        LocalDisplayCastAnimateWeaponOnKillPctChance = 5678,
        [Description("Gain Onslaught Ms On Skill Use")]
        GainOnslaughtMsOnSkillUse = 5679,
        [Description("Local Display Socketed Golem Skill Grants Onslaught When Summoned")]
        LocalDisplaySocketedGolemSkillGrantsOnslaughtWhenSummoned = 5680,
        [Description("Has Unholy Might")]
        HasUnholyMight = 5681,
        [Description("Chest Drop Reliquary Items")]
        ChestDropReliquaryItems = 5682,
        [Description("Deal No Skill Dot Damage Over Time")]
        DealNoSkillDotDamageOverTime = 5683,
        [Description("Combined All Projectile Damage +%")]
        CombinedAllProjectileDamagePosPct = 5684,
        [Description("Combined All Projectile Damage +% Final")]
        CombinedAllProjectileDamagePosPctFinal = 5685,
        [Description("Combined All Area Damage +%")]
        CombinedAllAreaDamagePosPct = 5686,
        [Description("Combined All Area Damage +% Final")]
        CombinedAllAreaDamagePosPctFinal = 5687,
        [Description("Combined All Added Damage +% Final")]
        CombinedAllAddedDamagePosPctFinal = 5688,
        [Description("Combined Hit All Damage +%")]
        CombinedHitAllDamagePosPct = 5689,
        [Description("Combined Skill Dot All Damage Over Time +%")]
        CombinedSkillDotAllDamageOverTimePosPct = 5690,
        [Description("Combined Skill Dot All Damage Over Time +% Final")]
        CombinedSkillDotAllDamageOverTimePosPctFinal = 5691,
        [Description("Projectile Damage Modifiers Apply To Skill Dot")]
        ProjectileDamageModifiersApplyToSkillDot = 5692,
        [Description("Fire Beam Max Rotation Speed +%")]
        FireBeamMaxRotationSpeedPosPct = 5693,
        [Description("Map Player Onslaught On Kill %")]
        MapPlayerOnslaughtOnKillPct = 5694,
        [Description("Map Monster Attack Cast And Movement Speed +%")]
        MapMonsterAttackCastAndMovementSpeedPosPct = 5695,
        [Description("Map Rare Monsters Drop X Additional Rare Items")]
        MapRareMonstersDropXAdditionalRareItems = 5696,
        [Description("Map Area Contains X Rare Monsters With Inner Treasure")]
        MapAreaContainsXRareMonstersWithInnerTreasure = 5697,
        [Description("Map Leaguestone Invasion Boss Item Quantity And Rarity +% Final")]
        MapLeaguestoneInvasionBossItemQuantityAndRarityPosPctFinal = 5698,
        [Description("Map First Invasion Boss Killed Drops X Additional Currency")]
        MapFirstInvasionBossKilledDropsXAdditionalCurrency = 5699,
        [Description("Map Invasion Monsters Guarded By X Magic Packs")]
        MapInvasionMonstersGuardedByXMagicPacks = 5700,
        [Description("Map Leaguestone Override Base Num Strongboxes")]
        MapLeaguestoneOverrideBaseNumStrongboxes = 5701,
        [Description("Map Leaguestone Additional Strongboxes")]
        MapLeaguestoneAdditionalStrongboxes = 5702,
        [Description("Map First Strongbox Contains X Additional Rare Monsters")]
        MapFirstStrongboxContainsXAdditionalRareMonsters = 5703,
        [Description("Map Area Contains Gemcutters Strongbox")]
        MapAreaContainsGemcuttersStrongbox = 5704,
        [Description("Map Area Contains Cartographers Strongbox")]
        MapAreaContainsCartographersStrongbox = 5705,
        [Description("Map Area Contains Unique Strongbox")]
        MapAreaContainsUniqueStrongbox = 5706,
        [Description("Map Area Contains Arcanists Strongbox")]
        MapAreaContainsArcanistsStrongbox = 5707,
        [Description("Map Strongboxes Drop X Additional Rare Items")]
        MapStrongboxesDropXAdditionalRareItems = 5708,
        [Description("Map Leaguestone Beyond Monster Item Quantity And Rarity +% Final")]
        MapLeaguestoneBeyondMonsterItemQuantityAndRarityPosPctFinal = 5709,
        [Description("Map First Unique Beyond Boss Slain Drops X Beyond Uniques")]
        MapFirstUniqueBeyondBossSlainDropsXBeyondUniques = 5710,
        [Description("Map Leaguestone X Monsters Spawn Random Beyond Boss")]
        MapLeaguestoneXMonstersSpawnRandomBeyondBoss = 5711,
        [Description("Map Leaguestone X Monsters Spawn Abaxoth")]
        MapLeaguestoneXMonstersSpawnAbaxoth = 5712,
        [Description("Map Item Found Rarity +% Per 15 Rampage Stacks")]
        MapItemFoundRarityPosPctPer15RampageStacks = 5713,
        [Description("Item Found Rarity +% Per 15 Rampage Stacks")]
        ItemFoundRarityPosPctPer15RampageStacks = 5714,
        [Description("Leaguestone Spawn Beyond Monster On Death Index")]
        LeaguestoneSpawnBeyondMonsterOnDeathIndex = 5715,
        [Description("Map Contains Three Magic Packs With Attack Cast And Movement Speed +%")]
        MapContainsThreeMagicPacksWithAttackCastAndMovementSpeedPosPct = 5716,
        [Description("Map Contains Three Magic Packs With Item Quantity Of Dropped Items +% Final")]
        MapContainsThreeMagicPacksWithItemQuantityOfDroppedItemsPosPctFinal = 5717,
        [Description("Leaguestone Maximum Area Level")]
        LeaguestoneMaximumAreaLevel = 5718,
        [Description("Attack Minimum Added Physical Damage Per Level")]
        AttackMinimumAddedPhysicalDamagePerLevel = 5719,
        [Description("Attack Maximum Added Physical Damage Per Level")]
        AttackMaximumAddedPhysicalDamagePerLevel = 5720,
        [Description("Attack Minimum Added Fire Damage Per 10 Strength")]
        AttackMinimumAddedFireDamagePer10Strength = 5721,
        [Description("Attack Maximum Added Fire Damage Per 10 Strength")]
        AttackMaximumAddedFireDamagePer10Strength = 5722,
        [Description("Unique Ryuslathas Clutches Minimum Physical Attack Damage +% Final")]
        UniqueRyuslathasClutchesMinimumPhysicalAttackDamagePosPctFinal = 5723,
        [Description("Unique Ryuslathas Clutches Maximum Physical Attack Damage +% Final")]
        UniqueRyuslathasClutchesMaximumPhysicalAttackDamagePosPctFinal = 5724,
        [Description("Is Intimidated")]
        IsIntimidated = 5725,
        [Description("Local Unique Jewel Frost Blades Melee Damage Penetrates % Cold Resistance With 40 Dex In Radius")]
        LocalUniqueJewelFrostBladesMeleeDamagePenetratesPctColdResistanceWith40DexInRadius = 5726,
        [Description("Frost Blades Melee Damage Penetrates % Cold Resistance")]
        FrostBladesMeleeDamagePenetratesPctColdResistance = 5727,
        [Description("Melee Damage Penetrates % Cold Resistance")]
        MeleeDamagePenetratesPctColdResistance = 5728,
        [Description("Local Display Socketed Golem Skills Minions Life % To Add As Energy Shield")]
        LocalDisplaySocketedGolemSkillsMinionsLifePctToAddAsEnergyShield = 5729,
        [Description("Mana Leech Permyriad Vs Frozen Enemies")]
        ManaLeechPermyriadVsFrozenEnemies = 5730,
        [Description("Map Mini Monolith Monsters Are Magic")]
        MapMiniMonolithMonstersAreMagic = 5731,
        [Description("Map Shrines Grant A Random Additional Effect")]
        MapShrinesGrantARandomAdditionalEffect = 5732,
        [Description("Map Shrines Drop X Currency Items On Activation")]
        MapShrinesDropXCurrencyItemsOnActivation = 5733,
        [Description("Map Monsters Spawned With Talisman Drop Additional Rare Items")]
        MapMonstersSpawnedWithTalismanDropAdditionalRareItems = 5734,
        [Description("Chance To Cast On Kill %")]
        ChanceToCastOnKillPct = 5735,
        [Description("Map Warbands Packs Have Additional Grunts")]
        MapWarbandsPacksHaveAdditionalGrunts = 5736,
        [Description("Map Warbands Packs Have Additional Supports")]
        MapWarbandsPacksHaveAdditionalSupports = 5737,
        [Description("Map Warbands Packs Have Additional Elites")]
        MapWarbandsPacksHaveAdditionalElites = 5738,
        [Description("Map Leaguestone Warbands Packs Have Item Rarity +% Final")]
        MapLeaguestoneWarbandsPacksHaveItemRarityPosPctFinal = 5739,
        [Description("Map Leaguestone Warbands Packs Have Item Quantity +% Final")]
        MapLeaguestoneWarbandsPacksHaveItemQuantityPosPctFinal = 5740,
        [Description("Map Monsters Near Shrines Are Chilled")]
        MapMonstersNearShrinesAreChilled = 5741,
        [Description("Map Imprisoned Monsters Damage Taken +%")]
        MapImprisonedMonstersDamageTakenPosPct = 5742,
        [Description("Map Imprisoned Monsters Damage +%")]
        MapImprisonedMonstersDamagePosPct = 5743,
        [Description("Map Leaguestone Imprisoned Monsters Item Rarity +% Final")]
        MapLeaguestoneImprisonedMonstersItemRarityPosPctFinal = 5744,
        [Description("Map Leaguestone Imprisoned Monsters Item Quantity +% Final")]
        MapLeaguestoneImprisonedMonstersItemQuantityPosPctFinal = 5745,
        [Description("Map Leaguestone Strongboxes Rarity Override")]
        MapLeaguestoneStrongboxesRarityOverride = 5746,
        [Description("Has Shrine Effect")]
        HasShrineEffect = 5747,
        [Description("Map Player Dodge Chance % During Shrine Effect")]
        MapPlayerDodgeChancePctDuringShrineEffect = 5748,
        [Description("Dodge Chance % During Shrine Effect")]
        DodgeChancePctDuringShrineEffect = 5749,
        [Description("Map Player Damage +% Vs Breach Monsters")]
        MapPlayerDamagePosPctVsBreachMonsters = 5750,
        [Description("Map Player Damage Taken +% Vs Breach Monsters")]
        MapPlayerDamageTakenPosPctVsBreachMonsters = 5751,
        [Description("Damage +% Vs Breach Monsters")]
        DamagePosPctVsBreachMonsters = 5752,
        [Description("Damage Taken +% Vs Breach Monsters")]
        DamageTakenPosPctVsBreachMonsters = 5753,
        [Description("Map Rare Breach Monster Additional Breach Ring Drop Chance %")]
        MapRareBreachMonsterAdditionalBreachRingDropChancePct = 5754,
        [Description("Map Strongboxes Vaal Orb Drop Chance %")]
        MapStrongboxesVaalOrbDropChancePct = 5755,
        [Description("Map Player Shrine Effect Duration +%")]
        MapPlayerShrineEffectDurationPosPct = 5756,
        [Description("Monster Is Beyond Boss")]
        MonsterIsBeyondBoss = 5757,
        [Description("Active Skill Base Radius +")]
        ActiveSkillBaseRadiusPos = 5758,
        [Description("Map Leaguestone Area Contains X Additional Leaguestones")]
        MapLeaguestoneAreaContainsXAdditionalLeaguestones = 5759,
        [Description("Map Leaguestone Monolith Contains Essence Type")]
        MapLeaguestoneMonolithContainsEssenceType = 5760,
        [Description("Map Contains Uul Netol Breach")]
        MapContainsUulNetolBreach = 5761,
        [Description("Map Contains Chayula Breach")]
        MapContainsChayulaBreach = 5762,
        [Description("Number Of Animated Weapons Allowed")]
        NumberOfAnimatedWeaponsAllowed = 5763,
        [Description("Number Of Active Animated Weapons")]
        NumberOfActiveAnimatedWeapons = 5764,
        [Description("Map Leaguestone Perandus Chests Have Item Rarity +% Final")]
        MapLeaguestonePerandusChestsHaveItemRarityPosPctFinal = 5765,
        [Description("Map Leaguestone Perandus Chests Have Item Quantity +% Final")]
        MapLeaguestonePerandusChestsHaveItemQuantityPosPctFinal = 5766,
        [Description("Map Perandus Monsters Drop Perandus Coin Stack %")]
        MapPerandusMonstersDropPerandusCoinStackPct = 5767,
        [Description("Map Perandus Guards Are Rare")]
        MapPerandusGuardsAreRare = 5768,
        [Description("Map Contains Perandus Boss")]
        MapContainsPerandusBoss = 5769,
        [Description("Drop Perandus Coin Stack %")]
        DropPerandusCoinStackPct = 5770,
        [Description("Kills Count Twice For Rampage %")]
        KillsCountTwiceForRampagePct = 5771,
        [Description("Map Next Area Contains X Additional Voidspawn Of Abaxoth Packs")]
        MapNextAreaContainsXAdditionalVoidspawnOfAbaxothPacks = 5772,
        [Description("Map Next Area Contains X Additional Bearers Of The Guardian Packs")]
        MapNextAreaContainsXAdditionalBearersOfTheGuardianPacks = 5773,
        [Description("Map Gain Onslaught For X Ms On Killing Rare Monster")]
        MapGainOnslaughtForXMsOnKillingRareMonster = 5774,
        [Description("Gain Onslaught For X Ms On Killing Rare Monster")]
        GainOnslaughtForXMsOnKillingRareMonster = 5775,
        [Description("Monster Held Item Force No Drop Penalty")]
        MonsterHeldItemForceNoDropPenalty = 5776,
        [Description("Leaguestone Prefix Minimum Area Level")]
        LeaguestonePrefixMinimumAreaLevel = 5777,
        [Description("Leaguestone Suffix Minimum Area Level")]
        LeaguestoneSuffixMinimumAreaLevel = 5778,
        [Description("Map Rare Monsters Drop Rare Prismatic Ring On Death %")]
        MapRareMonstersDropRarePrismaticRingOnDeathPct = 5779,
        [Description("Drop Rare Prismatic Ring On Death %")]
        DropRarePrismaticRingOnDeathPct = 5780,
        [Description("Map Players Gain 1 Rare Monster Mods On Kill For 20 Seconds %")]
        MapPlayersGain1RareMonsterModsOnKillFor20SecondsPct = 5781,
        [Description("Gain 1 Rare Monster Mods On Kill For 20 Seconds %")]
        Gain1RareMonsterModsOnKillFor20SecondsPct = 5782,
        [Description("Monster Is Beyond Monster")]
        MonsterIsBeyondMonster = 5783,
        [Description("Map Spawn Beyond Boss When Beyond Boss Slain %")]
        MapSpawnBeyondBossWhenBeyondBossSlainPct = 5784,
        [Description("Map Damage Taken +% From Beyond Monsters")]
        MapDamageTakenPosPctFromBeyondMonsters = 5785,
        [Description("Damage Taken +% From Beyond Monsters")]
        DamageTakenPosPctFromBeyondMonsters = 5786,
        [Description("Map Monster Damage Taken +% While Possessed")]
        MapMonsterDamageTakenPosPctWhilePossessed = 5787,
        [Description("Monster Damage Taken +% While Possessed")]
        MonsterDamageTakenPosPctWhilePossessed = 5788,
        [Description("Map Invasion Bosses Drop X Additional Vaal Orbs")]
        MapInvasionBossesDropXAdditionalVaalOrbs = 5789,
        [Description("Map Invasion Bosses Dropped Items Are Fully Linked")]
        MapInvasionBossesDroppedItemsAreFullyLinked = 5790,
        [Description("Map Invasion Bosses Dropped Items Have X Additional Sockets")]
        MapInvasionBossesDroppedItemsHaveXAdditionalSockets = 5791,
        [Description("Is Holding Silver Coin")]
        IsHoldingSilverCoin = 5792,
        [Description("Map Monsters With Silver Coins Drop X Additional Rare Items")]
        MapMonstersWithSilverCoinsDropXAdditionalRareItems = 5793,
        [Description("Map Monsters With Silver Coins Drop X Additional Currency Items")]
        MapMonstersWithSilverCoinsDropXAdditionalCurrencyItems = 5794,
        [Description("Map Bloodline Packs Drop X Additional Rare Items")]
        MapBloodlinePacksDropXAdditionalRareItems = 5795,
        [Description("Map Bloodline Packs Drop X Additional Currency Items")]
        MapBloodlinePacksDropXAdditionalCurrencyItems = 5796,
        [Description("Map Player Attack Cast And Movement Speed +% During Onslaught")]
        MapPlayerAttackCastAndMovementSpeedPosPctDuringOnslaught = 5797,
        [Description("Attack Cast And Movement Speed +% During Onslaught")]
        AttackCastAndMovementSpeedPosPctDuringOnslaught = 5798,
        [Description("Map Leaguestone Additional Shrines")]
        MapLeaguestoneAdditionalShrines = 5799,
        [Description("Active Skill Area Of Effect Radius +% Final")]
        ActiveSkillAreaOfEffectRadiusPosPctFinal = 5800,
        [Description("Map Rare Monsters Are Hindered")]
        MapRareMonstersAreHindered = 5801,
        [Description("Map Players Movement Speed +%")]
        MapPlayersMovementSpeedPosPct = 5802,
        [Description("Map Magic Monsters Damage Taken +%")]
        MapMagicMonstersDamageTakenPosPct = 5803,
        [Description("Map Magic Monsters Are Maimed")]
        MapMagicMonstersAreMaimed = 5804,
        [Description("Map Players Gain Onslaught During Flask Effect")]
        MapPlayersGainOnslaughtDuringFlaskEffect = 5805,
        [Description("Map Players Gain Rare Monster Mods On Kill % Chance")]
        MapPlayersGainRareMonsterModsOnKillPctChance = 5806,
        [Description("Gain Rare Monster Mods On Kill % Chance")]
        GainRareMonsterModsOnKillPctChance = 5807,
        [Description("Map Invasion Bosses Are Twinned")]
        MapInvasionBossesAreTwinned = 5808,
        [Description("Map Tormented Spirits Movement Speed +%")]
        MapTormentedSpiritsMovementSpeedPosPct = 5809,
        [Description("Map Tormented Spirits Duration +%")]
        MapTormentedSpiritsDurationPosPct = 5810,
        [Description("Map Players Gain Onslaught After Opening A Strongbox Ms")]
        MapPlayersGainOnslaughtAfterOpeningAStrongboxMs = 5811,
        [Description("Gain Onslaught After Opening A Strongbox Ms")]
        GainOnslaughtAfterOpeningAStrongboxMs = 5812,
        [Description("Map Players Additional Spell Dodge %")]
        MapPlayersAdditionalSpellDodgePct = 5813,
        [Description("Map Rare Monsters Have Inner Treasure")]
        MapRareMonstersHaveInnerTreasure = 5814,
        [Description("Map Leaguestone Override Base Num Prophecy Coins")]
        MapLeaguestoneOverrideBaseNumProphecyCoins = 5815,
        [Description("Map Leaguestone Additional Prophecy Coins")]
        MapLeaguestoneAdditionalProphecyCoins = 5816,
        [Description("Map Leaguestone Override Base Num Invasion Bosses")]
        MapLeaguestoneOverrideBaseNumInvasionBosses = 5817,
        [Description("Map Leaguestone Additional Invasion Bosses")]
        MapLeaguestoneAdditionalInvasionBosses = 5818,
        [Description("Map Monster Beyond Portal Chance +%")]
        MapMonsterBeyondPortalChancePosPct = 5819,
        [Description("Local Unique Jewel Fireball Base Radius Up To + At Longer Ranges With 40 Int In Radius")]
        LocalUniqueJewelFireballBaseRadiusUpToPosAtLongerRangesWith40IntInRadius = 5820,
        [Description("Fireball Base Radius Up To + At Longer Ranges")]
        FireballBaseRadiusUpToPosAtLongerRanges = 5821,
        [Description("Local Display Cast Level X Shock Ground When Hit")]
        LocalDisplayCastLevelXShockGroundWhenHit = 5822,
        [Description("Curse With Enfeeble On Hit % Against Uncursed Enemies")]
        CurseWithEnfeebleOnHitPctAgainstUncursedEnemies = 5823,
        [Description("Map Rogue Exiles Drop Additional Currency Items With Quality")]
        MapRogueExilesDropAdditionalCurrencyItemsWithQuality = 5824,
        [Description("Map Rogue Exiles Dropped Items Are Duplicated")]
        MapRogueExilesDroppedItemsAreDuplicated = 5825,
        [Description("Map Rogue Exiles Dropped Items Are Corrupted")]
        MapRogueExilesDroppedItemsAreCorrupted = 5826,
        [Description("Map Rogue Exiles Dropped Items Are Fully Linked")]
        MapRogueExilesDroppedItemsAreFullyLinked = 5827,
        [Description("Drop Additional Vaal Orbs")]
        DropAdditionalVaalOrbs = 5828,
        [Description("Map Contains Additional Mandible Talisman")]
        MapContainsAdditionalMandibleTalisman = 5829,
        [Description("Map Contains Additional Chrysalis Talisman")]
        MapContainsAdditionalChrysalisTalisman = 5830,
        [Description("Map Contains Additional Writhing Talisman")]
        MapContainsAdditionalWrithingTalisman = 5831,
        [Description("Map Contains Additional Fangjaw Talisman")]
        MapContainsAdditionalFangjawTalisman = 5832,
        [Description("Map Contains Additional Clutching Talisman")]
        MapContainsAdditionalClutchingTalisman = 5833,
        [Description("Map Contains Additional Three Rat Talisman")]
        MapContainsAdditionalThreeRatTalisman = 5834,
        [Description("Map Contains Additional Unique Talisman")]
        MapContainsAdditionalUniqueTalisman = 5835,
        [Description("Map Tempest Frequency +%")]
        MapTempestFrequencyPosPct = 5836,
        [Description("Map Player Life Regeneration Rate Per Minute % Per 25 Rampage Stacks")]
        MapPlayerLifeRegenerationRatePerMinutePctPer25RampageStacks = 5837,
        [Description("Life Regeneration Rate Per Minute % Per 25 Rampage Stacks")]
        LifeRegenerationRatePerMinutePctPer25RampageStacks = 5838,
        [Description("Map Player Damage Taken +% While Rampaging")]
        MapPlayerDamageTakenPosPctWhileRampaging = 5839,
        [Description("Damage Taken +% While Rampaging")]
        DamageTakenPosPctWhileRampaging = 5840,
        [Description("Map Contains Corrupted Strongbox")]
        MapContainsCorruptedStrongbox = 5841,
        [Description("Number Of Monsters To Summon Override")]
        NumberOfMonstersToSummonOverride = 5842,
        [Description("Monster Beyond Portal Chance +% Final")]
        MonsterBeyondPortalChancePosPctFinal = 5843,
        [Description("Map Num Leaguestones Active")]
        MapNumLeaguestonesActive = 5844,
        [Description("Virtual Monster Dropped Item Rarity +%")]
        VirtualMonsterDroppedItemRarityPosPct = 5845,
        [Description("Virtual Monster Dropped Item Quantity +%")]
        VirtualMonsterDroppedItemQuantityPosPct = 5846,
        [Description("Virtual Chest Item Quantity +%")]
        VirtualChestItemQuantityPosPct = 5847,
        [Description("Virtual Chest Item Rarity +%")]
        VirtualChestItemRarityPosPct = 5848,
        [Description("Leaguestone Monster Dropped Item Rarity +% Final")]
        LeaguestoneMonsterDroppedItemRarityPosPctFinal = 5849,
        [Description("Leaguestone Monster Dropped Item Quantity +% Final")]
        LeaguestoneMonsterDroppedItemQuantityPosPctFinal = 5850,
        [Description("Leaguestone Chest Item Quantity +% Final")]
        LeaguestoneChestItemQuantityPosPctFinal = 5851,
        [Description("Leaguestone Chest Item Rarity +% Final")]
        LeaguestoneChestItemRarityPosPctFinal = 5852,
        [Description("Map Leaguestone Stone Circle % Chance")]
        MapLeaguestoneStoneCirclePctChance = 5853,
        [Description("Local Unique Jewel Frost Blades Projectile Speed +% With 40 Dex In Radius")]
        LocalUniqueJewelFrostBladesProjectileSpeedPosPctWith40DexInRadius = 5854,
        [Description("Local Unique Jewel Dual Strike Main Hand Deals Double Damage % With 40 Dex In Radius")]
        LocalUniqueJewelDualStrikeMainHandDealsDoubleDamagePctWith40DexInRadius = 5855,
        [Description("Dual Strike Main Hand Deals Double Damage %")]
        DualStrikeMainHandDealsDoubleDamagePct = 5856,
        [Description("Chance To Deal Double Damage %")]
        ChanceToDealDoubleDamagePct = 5857,
        [Description("Always Ignite While Burning")]
        AlwaysIgniteWhileBurning = 5858,
        [Description("Full Life Threshold")]
        FullLifeThreshold = 5859,
        [Description("Unique Rat Cage Chance To Squeak When Hit By Fire Damage")]
        UniqueRatCageChanceToSqueakWhenHitByFireDamage = 5860,
        [Description("Map Monster Slain Experience +%")]
        MapMonsterSlainExperiencePosPct = 5861,
        [Description("Map Imprisoned Monsters Action Speed +%")]
        MapImprisonedMonstersActionSpeedPosPct = 5862,
        [Description("Is Beyond Monster Daemon")]
        IsBeyondMonsterDaemon = 5863,
        [Description("Map Tempest Area Of Effect +% Visible")]
        MapTempestAreaOfEffectPosPctVisible = 5864,
        [Description("Fortify Applies To Nearby Allies For X Seconds")]
        FortifyAppliesToNearbyAlliesForXSeconds = 5865,
        [Description("Suppress Phasing Visual")]
        SuppressPhasingVisual = 5866,
        [Description("Show Phasing Visual")]
        ShowPhasingVisual = 5867,
        [Description("Energy Shield Has Started Recharging Recently")]
        EnergyShieldHasStartedRechargingRecently = 5868,
        [Description("Track Energy Shield Has Started Recharging Recently")]
        TrackEnergyShieldHasStartedRechargingRecently = 5869,
        [Description("Not Affected By Action Speed Modifiers")]
        NotAffectedByActionSpeedModifiers = 5870,
        [Description("Map Player Movement Velocity +%")]
        MapPlayerMovementVelocityPosPct = 5871,
        [Description("Lunaris Glaive Angle")]
        LunarisGlaiveAngle = 5872,
        [Description("Lunaris Glaive Acceleration X")]
        LunarisGlaiveAccelerationX = 5873,
        [Description("Lunaris Glaive Acceleration Y")]
        LunarisGlaiveAccelerationY = 5874,
        [Description("Maintain Projectile Direction When Using Contact Position")]
        MaintainProjectileDirectionWhenUsingContactPosition = 5875,
        [Description("Map Force Side Area")]
        MapForceSideArea = 5876,
        [Description("Map Num Sextant Mods")]
        MapNumSextantMods = 5877,
        [Description("Cannot Be Stunned If You Have Been Stunned Recently")]
        CannotBeStunnedIfYouHaveBeenStunnedRecently = 5878,
        [Description("Track Have Been Stunned Recently")]
        TrackHaveBeenStunnedRecently = 5879,
        [Description("Have Been Stunned Recently")]
        HaveBeenStunnedRecently = 5880,
        [Description("Cannot Be Frozen If You Have Been Frozen Recently")]
        CannotBeFrozenIfYouHaveBeenFrozenRecently = 5881,
        [Description("Track Have Been Frozen Recently")]
        TrackHaveBeenFrozenRecently = 5882,
        [Description("Have Been Frozen Recently")]
        HaveBeenFrozenRecently = 5883,
        [Description("Life And Energy Shield Recovery Rate +% If Stopped Taking Damage Over Time Recently")]
        LifeAndEnergyShieldRecoveryRatePosPctIfStoppedTakingDamageOverTimeRecently = 5884,
        [Description("Movement Speed +% While On Burning Ground")]
        MovementSpeedPosPctWhileOnBurningGround = 5885,
        [Description("Chaos Damage Over Time Resistance %")]
        ChaosDamageOverTimeResistancePct = 5886,
        [Description("While Stationary Gain Additional Physical Damage Reduction %")]
        WhileStationaryGainAdditionalPhysicalDamageReductionPct = 5887,
        [Description("While Stationary Gain Life Regeneration Rate Per Minute %")]
        WhileStationaryGainLifeRegenerationRatePerMinutePct = 5888,
        [Description("Fire Damage Taken +% While Moving")]
        FireDamageTakenPosPctWhileMoving = 5889,
        [Description("Cold And Lightning Damage Taken As Fire Damage When Hit % Chance")]
        ColdAndLightningDamageTakenAsFireDamageWhenHitPctChance = 5890,
        [Description("Life Flasks Gain X Charges Every 3 Seconds If You Have Not Used A Life Flask Recently")]
        LifeFlasksGainXChargesEvery3SecondsIfYouHaveNotUsedALifeFlaskRecently = 5891,
        [Description("Life Recovery +% From Flasks While On Low Life")]
        LifeRecoveryPosPctFromFlasksWhileOnLowLife = 5892,
        [Description("Virtual Flask Life To Recover +%")]
        VirtualFlaskLifeToRecoverPosPct = 5893,
        [Description("Additional % Chance To Evade Attacks If You Have Taken A Savage Hit Recently")]
        AdditionalPctChanceToEvadeAttacksIfYouHaveTakenASavageHitRecently = 5894,
        [Description("Physical Damage Reduction % Per Hit You Have Taken Recently")]
        PhysicalDamageReductionPctPerHitYouHaveTakenRecently = 5895,
        [Description("Curses Have No Effect On You For 4 Seconds Every 10 Seconds")]
        CursesHaveNoEffectOnYouFor4SecondsEvery10Seconds = 5896,
        [Description("Hinder Effect On Self +%")]
        HinderEffectOnSelfPosPct = 5897,
        [Description("Avoid Corrupted Blood % Chance")]
        AvoidCorruptedBloodPctChance = 5898,
        [Description("Avoid Maim % Chance")]
        AvoidMaimPctChance = 5899,
        [Description("Monster Ground Fire On Death Variation")]
        MonsterGroundFireOnDeathVariation = 5900,
        [Description("Traps Explode On Timeout")]
        TrapsExplodeOnTimeout = 5901,
        [Description("Physical Skill Dot Damage To Deal Per Minute")]
        PhysicalSkillDotDamageToDealPerMinute = 5902,
        [Description("Fire Skill Dot Damage To Deal Per Minute")]
        FireSkillDotDamageToDealPerMinute = 5903,
        [Description("Cold Skill Dot Damage To Deal Per Minute")]
        ColdSkillDotDamageToDealPerMinute = 5904,
        [Description("Lightning Skill Dot Damage To Deal Per Minute")]
        LightningSkillDotDamageToDealPerMinute = 5905,
        [Description("Chaos Skill Dot Damage To Deal Per Minute")]
        ChaosSkillDotDamageToDealPerMinute = 5906,
        [Description("Physical Area Damage To Deal Per Minute")]
        PhysicalAreaDamageToDealPerMinute = 5907,
        [Description("Fire Area Damage To Deal Per Minute")]
        FireAreaDamageToDealPerMinute = 5908,
        [Description("Cold Area Damage To Deal Per Minute")]
        ColdAreaDamageToDealPerMinute = 5909,
        [Description("Lightning Area Damage To Deal Per Minute")]
        LightningAreaDamageToDealPerMinute = 5910,
        [Description("Chaos Area Damage To Deal Per Minute")]
        ChaosAreaDamageToDealPerMinute = 5911,
        [Description("Physical Skill Dot Area Damage To Deal Per Minute")]
        PhysicalSkillDotAreaDamageToDealPerMinute = 5912,
        [Description("Fire Skill Dot Area Damage To Deal Per Minute")]
        FireSkillDotAreaDamageToDealPerMinute = 5913,
        [Description("Cold Skill Dot Area Damage To Deal Per Minute")]
        ColdSkillDotAreaDamageToDealPerMinute = 5914,
        [Description("Lightning Skill Dot Area Damage To Deal Per Minute")]
        LightningSkillDotAreaDamageToDealPerMinute = 5915,
        [Description("Chaos Skill Dot Area Damage To Deal Per Minute")]
        ChaosSkillDotAreaDamageToDealPerMinute = 5916,
        [Description("Combined Attack Elemental Damage Pluspercent")]
        CombinedAttackElementalDamagePluspercent = 5917,
        [Description("Combined Attack Lightning Damage Pluspercent")]
        CombinedAttackLightningDamagePluspercent = 5918,
        [Description("Combined Attack Lightning Damage Pluspercent Final")]
        CombinedAttackLightningDamagePluspercentFinal = 5919,
        [Description("Combined Skill Dot Elemental Damage Over Time +%")]
        CombinedSkillDotElementalDamageOverTimePosPct = 5920,
        [Description("Combined Skill Dot Fire Damage Over Time +%")]
        CombinedSkillDotFireDamageOverTimePosPct = 5921,
        [Description("Combined Skill Dot Cold Damage Over Time +%")]
        CombinedSkillDotColdDamageOverTimePosPct = 5922,
        [Description("Combined Skill Dot Lightning Damage Over Time +%")]
        CombinedSkillDotLightningDamageOverTimePosPct = 5923,
        [Description("Combined Skill Dot Lightning Damage Over Time +% Final")]
        CombinedSkillDotLightningDamageOverTimePosPctFinal = 5924,
        [Description("Ignite Damage +%")]
        IgniteDamagePosPct = 5925,
        [Description("Combined Ignite Damage Over Time +%")]
        CombinedIgniteDamageOverTimePosPct = 5926,
        [Description("Bleed Is Skill Dot")]
        BleedIsSkillDot = 5927,
        [Description("Ignite Is Skill Dot")]
        IgniteIsSkillDot = 5928,
        [Description("Poison Is Skill Dot")]
        PoisonIsSkillDot = 5929,
        [Description("Deal No Bleed Damage Over Time")]
        DealNoBleedDamageOverTime = 5930,
        [Description("Deal No Ignite Damage Over Time")]
        DealNoIgniteDamageOverTime = 5931,
        [Description("Deal No Poison Damage Over Time")]
        DealNoPoisonDamageOverTime = 5932,
        [Description("Minimum Bleed Damage To Deal Per Minute From Main Hand Physical Damage")]
        MinimumBleedDamageToDealPerMinuteFromMainHandPhysicalDamage = 5933,
        [Description("Maximum Bleed Damage To Deal Per Minute From Main Hand Physical Damage")]
        MaximumBleedDamageToDealPerMinuteFromMainHandPhysicalDamage = 5934,
        [Description("Keystone Ghost Reaver")]
        KeystoneGhostReaver = 5935,
        [Description("Infest On Hit Chance %")]
        InfestOnHitChancePct = 5936,
        [Description("Infest On Hit Duration Ms")]
        InfestOnHitDurationMs = 5937,
        [Description("Energy Shield Per Level")]
        EnergyShieldPerLevel = 5938,
        [Description("Minimum Bleed Damage To Deal Per Minute From Off Hand Physical Damage")]
        MinimumBleedDamageToDealPerMinuteFromOffHandPhysicalDamage = 5939,
        [Description("Maximum Bleed Damage To Deal Per Minute From Off Hand Physical Damage")]
        MaximumBleedDamageToDealPerMinuteFromOffHandPhysicalDamage = 5940,
        [Description("Virtual Physical Damage Can Ignite")]
        VirtualPhysicalDamageCanIgnite = 5941,
        [Description("Virtual Fire Damage Cannot Ignite")]
        VirtualFireDamageCannotIgnite = 5942,
        [Description("Virtual Cold Damage Can Ignite")]
        VirtualColdDamageCanIgnite = 5943,
        [Description("Virtual Lightning Damage Can Ignite")]
        VirtualLightningDamageCanIgnite = 5944,
        [Description("Virtual Chaos Damage Can Ignite")]
        VirtualChaosDamageCanIgnite = 5945,
        [Description("Minimum Ignite Damage To Deal Per Minute From Main Hand Physical Damage")]
        MinimumIgniteDamageToDealPerMinuteFromMainHandPhysicalDamage = 5946,
        [Description("Maximum Ignite Damage To Deal Per Minute From Main Hand Physical Damage")]
        MaximumIgniteDamageToDealPerMinuteFromMainHandPhysicalDamage = 5947,
        [Description("Minimum Ignite Damage To Deal Per Minute From Main Hand Fire Damage")]
        MinimumIgniteDamageToDealPerMinuteFromMainHandFireDamage = 5948,
        [Description("Maximum Ignite Damage To Deal Per Minute From Main Hand Fire Damage")]
        MaximumIgniteDamageToDealPerMinuteFromMainHandFireDamage = 5949,
        [Description("Minimum Ignite Damage To Deal Per Minute From Main Hand Cold Damage")]
        MinimumIgniteDamageToDealPerMinuteFromMainHandColdDamage = 5950,
        [Description("Maximum Ignite Damage To Deal Per Minute From Main Hand Cold Damage")]
        MaximumIgniteDamageToDealPerMinuteFromMainHandColdDamage = 5951,
        [Description("Minimum Ignite Damage To Deal Per Minute From Main Hand Lightning Damage")]
        MinimumIgniteDamageToDealPerMinuteFromMainHandLightningDamage = 5952,
        [Description("Maximum Ignite Damage To Deal Per Minute From Main Hand Lightning Damage")]
        MaximumIgniteDamageToDealPerMinuteFromMainHandLightningDamage = 5953,
        [Description("Minimum Ignite Damage To Deal Per Minute From Main Hand Chaos Damage")]
        MinimumIgniteDamageToDealPerMinuteFromMainHandChaosDamage = 5954,
        [Description("Maximum Ignite Damage To Deal Per Minute From Main Hand Chaos Damage")]
        MaximumIgniteDamageToDealPerMinuteFromMainHandChaosDamage = 5955,
        [Description("Minimum Ignite Damage To Deal Per Minute From Off Hand Physical Damage")]
        MinimumIgniteDamageToDealPerMinuteFromOffHandPhysicalDamage = 5956,
        [Description("Maximum Ignite Damage To Deal Per Minute From Off Hand Physical Damage")]
        MaximumIgniteDamageToDealPerMinuteFromOffHandPhysicalDamage = 5957,
        [Description("Minimum Ignite Damage To Deal Per Minute From Off Hand Fire Damage")]
        MinimumIgniteDamageToDealPerMinuteFromOffHandFireDamage = 5958,
        [Description("Maximum Ignite Damage To Deal Per Minute From Off Hand Fire Damage")]
        MaximumIgniteDamageToDealPerMinuteFromOffHandFireDamage = 5959,
        [Description("Minimum Ignite Damage To Deal Per Minute From Off Hand Cold Damage")]
        MinimumIgniteDamageToDealPerMinuteFromOffHandColdDamage = 5960,
        [Description("Maximum Ignite Damage To Deal Per Minute From Off Hand Cold Damage")]
        MaximumIgniteDamageToDealPerMinuteFromOffHandColdDamage = 5961,
        [Description("Minimum Ignite Damage To Deal Per Minute From Off Hand Lightning Damage")]
        MinimumIgniteDamageToDealPerMinuteFromOffHandLightningDamage = 5962,
        [Description("Maximum Ignite Damage To Deal Per Minute From Off Hand Lightning Damage")]
        MaximumIgniteDamageToDealPerMinuteFromOffHandLightningDamage = 5963,
        [Description("Minimum Ignite Damage To Deal Per Minute From Off Hand Chaos Damage")]
        MinimumIgniteDamageToDealPerMinuteFromOffHandChaosDamage = 5964,
        [Description("Maximum Ignite Damage To Deal Per Minute From Off Hand Chaos Damage")]
        MaximumIgniteDamageToDealPerMinuteFromOffHandChaosDamage = 5965,
        [Description("Minimum Ignite Damage To Deal Per Minute From Spell Physical Damage")]
        MinimumIgniteDamageToDealPerMinuteFromSpellPhysicalDamage = 5966,
        [Description("Maximum Ignite Damage To Deal Per Minute From Spell Physical Damage")]
        MaximumIgniteDamageToDealPerMinuteFromSpellPhysicalDamage = 5967,
        [Description("Minimum Ignite Damage To Deal Per Minute From Spell Fire Damage")]
        MinimumIgniteDamageToDealPerMinuteFromSpellFireDamage = 5968,
        [Description("Maximum Ignite Damage To Deal Per Minute From Spell Fire Damage")]
        MaximumIgniteDamageToDealPerMinuteFromSpellFireDamage = 5969,
        [Description("Minimum Ignite Damage To Deal Per Minute From Spell Cold Damage")]
        MinimumIgniteDamageToDealPerMinuteFromSpellColdDamage = 5970,
        [Description("Maximum Ignite Damage To Deal Per Minute From Spell Cold Damage")]
        MaximumIgniteDamageToDealPerMinuteFromSpellColdDamage = 5971,
        [Description("Minimum Ignite Damage To Deal Per Minute From Spell Lightning Damage")]
        MinimumIgniteDamageToDealPerMinuteFromSpellLightningDamage = 5972,
        [Description("Maximum Ignite Damage To Deal Per Minute From Spell Lightning Damage")]
        MaximumIgniteDamageToDealPerMinuteFromSpellLightningDamage = 5973,
        [Description("Minimum Ignite Damage To Deal Per Minute From Spell Chaos Damage")]
        MinimumIgniteDamageToDealPerMinuteFromSpellChaosDamage = 5974,
        [Description("Maximum Ignite Damage To Deal Per Minute From Spell Chaos Damage")]
        MaximumIgniteDamageToDealPerMinuteFromSpellChaosDamage = 5975,
        [Description("Minimum Ignite Damage To Deal Per Minute From Secondary Physical Damage")]
        MinimumIgniteDamageToDealPerMinuteFromSecondaryPhysicalDamage = 5976,
        [Description("Maximum Ignite Damage To Deal Per Minute From Secondary Physical Damage")]
        MaximumIgniteDamageToDealPerMinuteFromSecondaryPhysicalDamage = 5977,
        [Description("Minimum Ignite Damage To Deal Per Minute From Secondary Fire Damage")]
        MinimumIgniteDamageToDealPerMinuteFromSecondaryFireDamage = 5978,
        [Description("Maximum Ignite Damage To Deal Per Minute From Secondary Fire Damage")]
        MaximumIgniteDamageToDealPerMinuteFromSecondaryFireDamage = 5979,
        [Description("Minimum Ignite Damage To Deal Per Minute From Secondary Cold Damage")]
        MinimumIgniteDamageToDealPerMinuteFromSecondaryColdDamage = 5980,
        [Description("Maximum Ignite Damage To Deal Per Minute From Secondary Cold Damage")]
        MaximumIgniteDamageToDealPerMinuteFromSecondaryColdDamage = 5981,
        [Description("Minimum Ignite Damage To Deal Per Minute From Secondary Lightning Damage")]
        MinimumIgniteDamageToDealPerMinuteFromSecondaryLightningDamage = 5982,
        [Description("Maximum Ignite Damage To Deal Per Minute From Secondary Lightning Damage")]
        MaximumIgniteDamageToDealPerMinuteFromSecondaryLightningDamage = 5983,
        [Description("Minimum Ignite Damage To Deal Per Minute From Secondary Chaos Damage")]
        MinimumIgniteDamageToDealPerMinuteFromSecondaryChaosDamage = 5984,
        [Description("Maximum Ignite Damage To Deal Per Minute From Secondary Chaos Damage")]
        MaximumIgniteDamageToDealPerMinuteFromSecondaryChaosDamage = 5985,
        [Description("Global Total Minimum Added Chaos Damage")]
        GlobalTotalMinimumAddedChaosDamage = 5986,
        [Description("Global Total Maximum Added Chaos Damage")]
        GlobalTotalMaximumAddedChaosDamage = 5987,
        [Description("Minimum Ignite Damage To Deal Per Minute From Main Hand Damage")]
        MinimumIgniteDamageToDealPerMinuteFromMainHandDamage = 5988,
        [Description("Maximum Ignite Damage To Deal Per Minute From Main Hand Damage")]
        MaximumIgniteDamageToDealPerMinuteFromMainHandDamage = 5989,
        [Description("Minimum Ignite Damage To Deal Per Minute From Off Hand Damage")]
        MinimumIgniteDamageToDealPerMinuteFromOffHandDamage = 5990,
        [Description("Maximum Ignite Damage To Deal Per Minute From Off Hand Damage")]
        MaximumIgniteDamageToDealPerMinuteFromOffHandDamage = 5991,
        [Description("Minimum Ignite Damage To Deal Per Minute From Spell Damage")]
        MinimumIgniteDamageToDealPerMinuteFromSpellDamage = 5992,
        [Description("Maximum Ignite Damage To Deal Per Minute From Spell Damage")]
        MaximumIgniteDamageToDealPerMinuteFromSpellDamage = 5993,
        [Description("Minimum Ignite Damage To Deal Per Minute From Secondary Damage")]
        MinimumIgniteDamageToDealPerMinuteFromSecondaryDamage = 5994,
        [Description("Maximum Ignite Damage To Deal Per Minute From Secondary Damage")]
        MaximumIgniteDamageToDealPerMinuteFromSecondaryDamage = 5995,
        [Description("Virtual Always Ignite")]
        VirtualAlwaysIgnite = 5996,
        [Description("Trap Additional Random Duration Ms")]
        TrapAdditionalRandomDurationMs = 5997,
        [Description("Minions Hits Can Only Kill Ignited Enemies")]
        MinionsHitsCanOnlyKillIgnitedEnemies = 5998,
        [Description("Hits Can Only Kill Ignited Enemies")]
        HitsCanOnlyKillIgnitedEnemies = 5999,
        [Description("Additional Spell Block % While Cursed")]
        AdditionalSpellBlockPctWhileCursed = 6000,
        [Description("Additional Block % While Not Cursed")]
        AdditionalBlockPctWhileNotCursed = 6001,
        [Description("Ignite Damage From Attack Skills +%")]
        IgniteDamageFromAttackSkillsPosPct = 6002,
        [Description("Minimum Poison Damage To Deal Per Minute From Main Hand Physical Damage")]
        MinimumPoisonDamageToDealPerMinuteFromMainHandPhysicalDamage = 6003,
        [Description("Maximum Poison Damage To Deal Per Minute From Main Hand Physical Damage")]
        MaximumPoisonDamageToDealPerMinuteFromMainHandPhysicalDamage = 6004,
        [Description("Minimum Poison Damage To Deal Per Minute From Main Hand Fire Damage")]
        MinimumPoisonDamageToDealPerMinuteFromMainHandFireDamage = 6005,
        [Description("Maximum Poison Damage To Deal Per Minute From Main Hand Fire Damage")]
        MaximumPoisonDamageToDealPerMinuteFromMainHandFireDamage = 6006,
        [Description("Minimum Poison Damage To Deal Per Minute From Main Hand Cold Damage")]
        MinimumPoisonDamageToDealPerMinuteFromMainHandColdDamage = 6007,
        [Description("Maximum Poison Damage To Deal Per Minute From Main Hand Cold Damage")]
        MaximumPoisonDamageToDealPerMinuteFromMainHandColdDamage = 6008,
        [Description("Minimum Poison Damage To Deal Per Minute From Main Hand Lightning Damage")]
        MinimumPoisonDamageToDealPerMinuteFromMainHandLightningDamage = 6009,
        [Description("Maximum Poison Damage To Deal Per Minute From Main Hand Lightning Damage")]
        MaximumPoisonDamageToDealPerMinuteFromMainHandLightningDamage = 6010,
        [Description("Minimum Poison Damage To Deal Per Minute From Main Hand Chaos Damage")]
        MinimumPoisonDamageToDealPerMinuteFromMainHandChaosDamage = 6011,
        [Description("Maximum Poison Damage To Deal Per Minute From Main Hand Chaos Damage")]
        MaximumPoisonDamageToDealPerMinuteFromMainHandChaosDamage = 6012,
        [Description("Minimum Poison Damage To Deal Per Minute From Off Hand Physical Damage")]
        MinimumPoisonDamageToDealPerMinuteFromOffHandPhysicalDamage = 6013,
        [Description("Maximum Poison Damage To Deal Per Minute From Off Hand Physical Damage")]
        MaximumPoisonDamageToDealPerMinuteFromOffHandPhysicalDamage = 6014,
        [Description("Minimum Poison Damage To Deal Per Minute From Off Hand Fire Damage")]
        MinimumPoisonDamageToDealPerMinuteFromOffHandFireDamage = 6015,
        [Description("Maximum Poison Damage To Deal Per Minute From Off Hand Fire Damage")]
        MaximumPoisonDamageToDealPerMinuteFromOffHandFireDamage = 6016,
        [Description("Minimum Poison Damage To Deal Per Minute From Off Hand Cold Damage")]
        MinimumPoisonDamageToDealPerMinuteFromOffHandColdDamage = 6017,
        [Description("Maximum Poison Damage To Deal Per Minute From Off Hand Cold Damage")]
        MaximumPoisonDamageToDealPerMinuteFromOffHandColdDamage = 6018,
        [Description("Minimum Poison Damage To Deal Per Minute From Off Hand Lightning Damage")]
        MinimumPoisonDamageToDealPerMinuteFromOffHandLightningDamage = 6019,
        [Description("Maximum Poison Damage To Deal Per Minute From Off Hand Lightning Damage")]
        MaximumPoisonDamageToDealPerMinuteFromOffHandLightningDamage = 6020,
        [Description("Minimum Poison Damage To Deal Per Minute From Off Hand Chaos Damage")]
        MinimumPoisonDamageToDealPerMinuteFromOffHandChaosDamage = 6021,
        [Description("Maximum Poison Damage To Deal Per Minute From Off Hand Chaos Damage")]
        MaximumPoisonDamageToDealPerMinuteFromOffHandChaosDamage = 6022,
        [Description("Minimum Poison Damage To Deal Per Minute From Spell Physical Damage")]
        MinimumPoisonDamageToDealPerMinuteFromSpellPhysicalDamage = 6023,
        [Description("Maximum Poison Damage To Deal Per Minute From Spell Physical Damage")]
        MaximumPoisonDamageToDealPerMinuteFromSpellPhysicalDamage = 6024,
        [Description("Minimum Poison Damage To Deal Per Minute From Spell Fire Damage")]
        MinimumPoisonDamageToDealPerMinuteFromSpellFireDamage = 6025,
        [Description("Maximum Poison Damage To Deal Per Minute From Spell Fire Damage")]
        MaximumPoisonDamageToDealPerMinuteFromSpellFireDamage = 6026,
        [Description("Minimum Poison Damage To Deal Per Minute From Spell Cold Damage")]
        MinimumPoisonDamageToDealPerMinuteFromSpellColdDamage = 6027,
        [Description("Maximum Poison Damage To Deal Per Minute From Spell Cold Damage")]
        MaximumPoisonDamageToDealPerMinuteFromSpellColdDamage = 6028,
        [Description("Minimum Poison Damage To Deal Per Minute From Spell Lightning Damage")]
        MinimumPoisonDamageToDealPerMinuteFromSpellLightningDamage = 6029,
        [Description("Maximum Poison Damage To Deal Per Minute From Spell Lightning Damage")]
        MaximumPoisonDamageToDealPerMinuteFromSpellLightningDamage = 6030,
        [Description("Minimum Poison Damage To Deal Per Minute From Spell Chaos Damage")]
        MinimumPoisonDamageToDealPerMinuteFromSpellChaosDamage = 6031,
        [Description("Maximum Poison Damage To Deal Per Minute From Spell Chaos Damage")]
        MaximumPoisonDamageToDealPerMinuteFromSpellChaosDamage = 6032,
        [Description("Minimum Poison Damage To Deal Per Minute From Secondary Physical Damage")]
        MinimumPoisonDamageToDealPerMinuteFromSecondaryPhysicalDamage = 6033,
        [Description("Maximum Poison Damage To Deal Per Minute From Secondary Physical Damage")]
        MaximumPoisonDamageToDealPerMinuteFromSecondaryPhysicalDamage = 6034,
        [Description("Minimum Poison Damage To Deal Per Minute From Secondary Fire Damage")]
        MinimumPoisonDamageToDealPerMinuteFromSecondaryFireDamage = 6035,
        [Description("Maximum Poison Damage To Deal Per Minute From Secondary Fire Damage")]
        MaximumPoisonDamageToDealPerMinuteFromSecondaryFireDamage = 6036,
        [Description("Minimum Poison Damage To Deal Per Minute From Secondary Cold Damage")]
        MinimumPoisonDamageToDealPerMinuteFromSecondaryColdDamage = 6037,
        [Description("Maximum Poison Damage To Deal Per Minute From Secondary Cold Damage")]
        MaximumPoisonDamageToDealPerMinuteFromSecondaryColdDamage = 6038,
        [Description("Minimum Poison Damage To Deal Per Minute From Secondary Lightning Damage")]
        MinimumPoisonDamageToDealPerMinuteFromSecondaryLightningDamage = 6039,
        [Description("Maximum Poison Damage To Deal Per Minute From Secondary Lightning Damage")]
        MaximumPoisonDamageToDealPerMinuteFromSecondaryLightningDamage = 6040,
        [Description("Minimum Poison Damage To Deal Per Minute From Secondary Chaos Damage")]
        MinimumPoisonDamageToDealPerMinuteFromSecondaryChaosDamage = 6041,
        [Description("Maximum Poison Damage To Deal Per Minute From Secondary Chaos Damage")]
        MaximumPoisonDamageToDealPerMinuteFromSecondaryChaosDamage = 6042,
        [Description("Combined Poison Damage Over Time +%")]
        CombinedPoisonDamageOverTimePosPct = 6043,
        [Description("Poison Damage From Attack Skills +%")]
        PoisonDamageFromAttackSkillsPosPct = 6044,
        [Description("Virtual Physical Damage Cannot Poison")]
        VirtualPhysicalDamageCannotPoison = 6045,
        [Description("Virtual Fire Damage Can Poison")]
        VirtualFireDamageCanPoison = 6046,
        [Description("Virtual Cold Damage Can Poison")]
        VirtualColdDamageCanPoison = 6047,
        [Description("Virtual Lightning Damage Can Poison")]
        VirtualLightningDamageCanPoison = 6048,
        [Description("Virtual Chaos Damage Cannot Poison")]
        VirtualChaosDamageCannotPoison = 6049,
        [Description("Non Chaos Damage Cannot Poison")]
        NonChaosDamageCannotPoison = 6050,
        [Description("All Damage Can Poison")]
        AllDamageCanPoison = 6051,
        [Description("Minimum Poison Damage To Deal Per Minute From Main Hand Damage")]
        MinimumPoisonDamageToDealPerMinuteFromMainHandDamage = 6052,
        [Description("Maximum Poison Damage To Deal Per Minute From Main Hand Damage")]
        MaximumPoisonDamageToDealPerMinuteFromMainHandDamage = 6053,
        [Description("Minimum Poison Damage To Deal Per Minute From Off Hand Damage")]
        MinimumPoisonDamageToDealPerMinuteFromOffHandDamage = 6054,
        [Description("Maximum Poison Damage To Deal Per Minute From Off Hand Damage")]
        MaximumPoisonDamageToDealPerMinuteFromOffHandDamage = 6055,
        [Description("Minimum Poison Damage To Deal Per Minute From Spell Damage")]
        MinimumPoisonDamageToDealPerMinuteFromSpellDamage = 6056,
        [Description("Maximum Poison Damage To Deal Per Minute From Spell Damage")]
        MaximumPoisonDamageToDealPerMinuteFromSpellDamage = 6057,
        [Description("Minimum Poison Damage To Deal Per Minute From Secondary Damage")]
        MinimumPoisonDamageToDealPerMinuteFromSecondaryDamage = 6058,
        [Description("Maximum Poison Damage To Deal Per Minute From Secondary Damage")]
        MaximumPoisonDamageToDealPerMinuteFromSecondaryDamage = 6059,
        [Description("Minimum Poison Damage To Always Deal Per Minute From Main Hand Damage")]
        MinimumPoisonDamageToAlwaysDealPerMinuteFromMainHandDamage = 6060,
        [Description("Maximum Poison Damage To Always Deal Per Minute From Main Hand Damage")]
        MaximumPoisonDamageToAlwaysDealPerMinuteFromMainHandDamage = 6061,
        [Description("Minimum Poison Damage To Always Deal Per Minute From Off Hand Damage")]
        MinimumPoisonDamageToAlwaysDealPerMinuteFromOffHandDamage = 6062,
        [Description("Maximum Poison Damage To Always Deal Per Minute From Off Hand Damage")]
        MaximumPoisonDamageToAlwaysDealPerMinuteFromOffHandDamage = 6063,
        [Description("Minimum Poison Damage To Always Deal Per Minute From Spell Damage")]
        MinimumPoisonDamageToAlwaysDealPerMinuteFromSpellDamage = 6064,
        [Description("Maximum Poison Damage To Always Deal Per Minute From Spell Damage")]
        MaximumPoisonDamageToAlwaysDealPerMinuteFromSpellDamage = 6065,
        [Description("Minimum Poison Damage To Always Deal Per Minute From Secondary Damage")]
        MinimumPoisonDamageToAlwaysDealPerMinuteFromSecondaryDamage = 6066,
        [Description("Maximum Poison Damage To Always Deal Per Minute From Secondary Damage")]
        MaximumPoisonDamageToAlwaysDealPerMinuteFromSecondaryDamage = 6067,
        [Description("Ice Spear Second Form Damage +%")]
        IceSpearSecondFormDamagePosPct = 6068,
        [Description("Extra Damage Taken From Crit While No Power Charges +%")]
        ExtraDamageTakenFromCritWhileNoPowerChargesPosPct = 6069,
        [Description("Chest Display Weylams War")]
        ChestDisplayWeylamsWar = 6070,
        [Description("Minion Movement Speed +% Per 50 Dex")]
        MinionMovementSpeedPosPctPer50Dex = 6071,
        [Description("Minion Attack Speed +% Per 50 Dex")]
        MinionAttackSpeedPosPctPer50Dex = 6072,
        [Description("Main Hand Attack Minimum Added Lightning Damage Per 10 Int")]
        MainHandAttackMinimumAddedLightningDamagePer10Int = 6073,
        [Description("Main Hand Attack Maximum Added Lightning Damage Per 10 Int")]
        MainHandAttackMaximumAddedLightningDamagePer10Int = 6074,
        [Description("Off Hand Attack Minimum Added Lightning Damage Per 10 Int")]
        OffHandAttackMinimumAddedLightningDamagePer10Int = 6075,
        [Description("Off Hand Attack Maximum Added Lightning Damage Per 10 Int")]
        OffHandAttackMaximumAddedLightningDamagePer10Int = 6076,
        [Description("Main Hand Attack Minimum Added Fire Damage Per 10 Strength")]
        MainHandAttackMinimumAddedFireDamagePer10Strength = 6077,
        [Description("Main Hand Attack Maximum Added Fire Damage Per 10 Strength")]
        MainHandAttackMaximumAddedFireDamagePer10Strength = 6078,
        [Description("Off Hand Attack Minimum Added Fire Damage Per 10 Strength")]
        OffHandAttackMinimumAddedFireDamagePer10Strength = 6079,
        [Description("Off Hand Attack Maximum Added Fire Damage Per 10 Strength")]
        OffHandAttackMaximumAddedFireDamagePer10Strength = 6080,
        [Description("Fire Beam Start Angle Offset Variance")]
        FireBeamStartAngleOffsetVariance = 6081,
        [Description("Display Monster May Inflict Bleeding")]
        DisplayMonsterMayInflictBleeding = 6082,
        [Description("Combined Bleeding Damage Over Time +%")]
        CombinedBleedingDamageOverTimePosPct = 6083,
        [Description("Combined Bleeding Damage Over Time +% Final")]
        CombinedBleedingDamageOverTimePosPctFinal = 6084,
        [Description("Bleeding Damage +%")]
        BleedingDamagePosPct = 6085,
        [Description("Active Skill Bleeding Damage +% Final")]
        ActiveSkillBleedingDamagePosPctFinal = 6086,
        [Description("Frog God Number Of Orbs To Summon")]
        FrogGodNumberOfOrbsToSummon = 6087,
        [Description("Combined Ignite Damage Over Time +% Final")]
        CombinedIgniteDamageOverTimePosPctFinal = 6088,
        [Description("Physical Damage With Attack Skills +%")]
        PhysicalDamageWithAttackSkillsPosPct = 6089,
        [Description("Elemental Damage With Attack Skills +%")]
        ElementalDamageWithAttackSkillsPosPct = 6090,
        [Description("Fire Damage With Attack Skills +%")]
        FireDamageWithAttackSkillsPosPct = 6091,
        [Description("Cold Damage With Attack Skills +%")]
        ColdDamageWithAttackSkillsPosPct = 6092,
        [Description("Lightning Damage With Attack Skills +%")]
        LightningDamageWithAttackSkillsPosPct = 6093,
        [Description("Chaos Damage With Attack Skills +%")]
        ChaosDamageWithAttackSkillsPosPct = 6094,
        [Description("Doedre Aura Damage +% Final")]
        DoedreAuraDamagePosPctFinal = 6095,
        [Description("Base Fire Damage % Of Maximum Life Plus Maximum Es To Deal Per Minute")]
        BaseFireDamagePctOfMaximumLifePlusMaximumESToDealPerMinute = 6096,
        [Description("Cast At Teleport Start %")]
        CastAtTeleportStartPct = 6097,
        [Description("Cast At Teleport End %")]
        CastAtTeleportEndPct = 6098,
        [Description("Summoned Monsters Are Parented To My Target")]
        SummonedMonstersAreParentedToMyTarget = 6099,
        [Description("Cast At Mortar Impact %")]
        CastAtMortarImpactPct = 6100,
        [Description("Mortar Has Triggered Skills")]
        MortarHasTriggeredSkills = 6101,
        [Description("Active Skill Base Attack Damage Final Permyriad")]
        ActiveSkillBaseAttackDamageFinalPermyriad = 6102,
        [Description("Map Bosses Have Summon Zombie Giant")]
        MapBossesHaveSummonZombieGiant = 6103,
        [Description("Monster Spawn Bloodlines Zombie Giant")]
        MonsterSpawnBloodlinesZombieGiant = 6104,
        [Description("Base Critical Degen Multiplier")]
        BaseCriticalDegenMultiplier = 6105,
        [Description("Critical Degen Multiplier From Main Hand")]
        CriticalDegenMultiplierFromMainHand = 6106,
        [Description("Critical Degen Multiplier From Off Hand")]
        CriticalDegenMultiplierFromOffHand = 6107,
        [Description("Critical Degen Multiplier From Spell")]
        CriticalDegenMultiplierFromSpell = 6108,
        [Description("Critical Degen Multiplier From Secondary")]
        CriticalDegenMultiplierFromSecondary = 6109,
        [Description("Monster Ignite Damage +% Final")]
        MonsterIgniteDamagePosPctFinal = 6110,
        [Description("Monster Bleeding Damage +% Final")]
        MonsterBleedingDamagePosPctFinal = 6111,
        [Description("Monster Poison Damage +% Final")]
        MonsterPoisonDamagePosPctFinal = 6112,
        [Description("Combined Poison Damage Over Time +% Final")]
        CombinedPoisonDamageOverTimePosPctFinal = 6113,
        [Description("Bleeding Moving Damage % Of Base Override")]
        BleedingMovingDamagePctOfBaseOverride = 6114,
        [Description("Active Skill If Used Through Frostbolt Damage +% Final")]
        ActiveSkillIfUsedThroughFrostboltDamagePosPctFinal = 6115,
        [Description("Used Through Frostbolt")]
        UsedThroughFrostbolt = 6116,
        [Description("Display Monster May Inflict Maim")]
        DisplayMonsterMayInflictMaim = 6117,
        [Description("Support Attack Skills Elemental Damage +% Final")]
        SupportAttackSkillsElementalDamagePosPctFinal = 6118,
        [Description("Elemental Damage With Attack Skills +% While Using Flask")]
        ElementalDamageWithAttackSkillsPosPctWhileUsingFlask = 6119,
        [Description("Support Burning Damage +% Final")]
        SupportBurningDamagePosPctFinal = 6120,
        [Description("Bleeding Skill Effect Duration")]
        BleedingSkillEffectDuration = 6121,
        [Description("Bleed Duration Is Skill Duration")]
        BleedDurationIsSkillDuration = 6122,
        [Description("Base All Ailment Duration +%")]
        BaseAllAilmentDurationPosPct = 6123,
        [Description("Shocked Enemies Explode For % Life As Lightning Damage")]
        ShockedEnemiesExplodeForPctLifeAsLightningDamage = 6124,
        [Description("Track Have Shocked Recently")]
        TrackHaveShockedRecently = 6125,
        [Description("Have Shocked Recently")]
        HaveShockedRecently = 6126,
        [Description("Damage +% If You Have Shocked Recently")]
        DamagePosPctIfYouHaveShockedRecently = 6127,
        [Description("Herald Mana Reservation Override 45%")]
        HeraldManaReservationOverride45Pct = 6128,
        [Description("Avoid Stun 35% Per Active Herald")]
        AvoidStun35PctPerActiveHerald = 6129,
        [Description("Number Of Active Heralds")]
        NumberOfActiveHeralds = 6130,
        [Description("Base Avoid Stun %")]
        BaseAvoidStunPct = 6131,
        [Description("Herald Of Ash Burning Damage +% Final")]
        HeraldOfAshBurningDamagePosPctFinal = 6132,
        [Description("Depair Bear Upheaval Movement Speed +%")]
        DepairBearUpheavalMovementSpeedPosPct = 6133,
        [Description("Virtual Ignite Faster Burn %")]
        VirtualIgniteFasterBurnPct = 6134,
        [Description("Kill Traps Mines And Totems On Death")]
        KillTrapsMinesAndTotemsOnDeath = 6135,
        [Description("Chest Drop X Divination Cards")]
        ChestDropXDivinationCards = 6136,
        [Description("Chest Drop Divination Cards With Full Stack Number X")]
        ChestDropDivinationCardsWithFullStackNumberX = 6137,
        [Description("Keystone Ailment Crit")]
        KeystoneAilmentCrit = 6138,
        [Description("Fire Beam Prioritise Players For Targeting")]
        FireBeamPrioritisePlayersForTargeting = 6139,
        [Description("Support Ignite Proliferation Radius")]
        SupportIgniteProliferationRadius = 6140,
        [Description("Support Maimed Enemies Physical Damage Taken +%")]
        SupportMaimedEnemiesPhysicalDamageTakenPosPct = 6141,
        [Description("Support Chance To Ignite Fire Damage +% Final")]
        SupportChanceToIgniteFireDamagePosPctFinal = 6142,
        [Description("Support Better Ailments Ailment Damage +% Final")]
        SupportBetterAilmentsAilmentDamagePosPctFinal = 6143,
        [Description("Support Better Ailments Hit Damage +% Final")]
        SupportBetterAilmentsHitDamagePosPctFinal = 6144,
        [Description("Additional Chaos Resistance Against Damage Over Time %")]
        AdditionalChaosResistanceAgainstDamageOverTimePct = 6145,
        [Description("From Code Active Skill Hit Damage +% Final")]
        FromCodeActiveSkillHitDamagePosPctFinal = 6146,
        [Description("Hit Damage +%")]
        HitDamagePosPct = 6147,
        [Description("Uncapped Chaos Damage Over Time Resistance %")]
        UncappedChaosDamageOverTimeResistancePct = 6148,
        [Description("Attack Cast Movement Speed +% If Taken A Savage Hit Recently")]
        AttackCastMovementSpeedPosPctIfTakenASavageHitRecently = 6149,
        [Description("Chaos Resistance % For You And Allies Affected By Your Auras")]
        ChaosResistancePctForYouAndAlliesAffectedByYourAuras = 6150,
        [Description("Additional Block Chance % For You And Allies Affected By Your Auras")]
        AdditionalBlockChancePctForYouAndAlliesAffectedByYourAuras = 6151,
        [Description("Attack Cast Movement Speed +% For You And Allies Affected By Your Auras")]
        AttackCastMovementSpeedPosPctForYouAndAlliesAffectedByYourAuras = 6152,
        [Description("Mana Regeneration Rate Per Minute If Used Movement Skill Recently")]
        ManaRegenerationRatePerMinuteIfUsedMovementSkillRecently = 6153,
        [Description("Movement Speed +% If Placed Trap Or Mine Recently")]
        MovementSpeedPosPctIfPlacedTrapOrMineRecently = 6154,
        [Description("Trap And Mine Damage +% If Armed For 4 Seconds")]
        TrapAndMineDamagePosPctIfArmedFor4Seconds = 6155,
        [Description("Skill Effect And Damaging Ailment Duration +%")]
        SkillEffectAndDamagingAilmentDurationPosPct = 6156,
        [Description("Active Skill Damage Over Time From Projectile Hits +% Final")]
        ActiveSkillDamageOverTimeFromProjectileHitsPosPctFinal = 6157,
        [Description("Trigger Spawners Time Between Min Ms")]
        TriggerSpawnersTimeBetweenMinMs = 6158,
        [Description("Trigger Spawners Time Between Max Ms")]
        TriggerSpawnersTimeBetweenMaxMs = 6159,
        [Description("Cast On Delayed Skill Trigger %")]
        CastOnDelayedSkillTriggerPct = 6160,
        [Description("Track Have Used Movement Skill Recently")]
        TrackHaveUsedMovementSkillRecently = 6161,
        [Description("Have Used Movement Skill Recently")]
        HaveUsedMovementSkillRecently = 6162,
        [Description("Track Have Placed Trap Or Mine Recently")]
        TrackHavePlacedTrapOrMineRecently = 6163,
        [Description("Have Placed Trap Or Mine Recently")]
        HavePlacedTrapOrMineRecently = 6164,
        [Description("Blast Rain No Los Required")]
        BlastRainNoLosRequired = 6165,
        [Description("Despair Bear Upheaval Physical Damage To Deal Per Minute")]
        DespairBearUpheavalPhysicalDamageToDealPerMinute = 6166,
        [Description("Number Of Additional Ignites Allowed")]
        NumberOfAdditionalIgnitesAllowed = 6167,
        [Description("Cast On Trigger Charge Event %")]
        CastOnTriggerChargeEventPct = 6168,
        [Description("Monster Can Drop Hinekoras Sight")]
        MonsterCanDropHinekorasSight = 6169,
        [Description("Support Efficacy Spell Damage +% Final")]
        SupportEfficacySpellDamagePosPctFinal = 6170,
        [Description("Support Efficacy Damage Over Time +% Final")]
        SupportEfficacyDamageOverTimePosPctFinal = 6171,
        [Description("Support Debilitate Poison Damage +% Final")]
        SupportDebilitatePoisonDamagePosPctFinal = 6172,
        [Description("Support Debilitate Hit Damage +% Final")]
        SupportDebilitateHitDamagePosPctFinal = 6173,
        [Description("Support Debilitate Hit Damage +% Final Per Poison Stack")]
        SupportDebilitateHitDamagePosPctFinalPerPoisonStack = 6174,
        [Description("Support Debilitate Hit Damage Max Poison Stacks")]
        SupportDebilitateHitDamageMaxPoisonStacks = 6175,
        [Description("Support Minimum Added Fire Damage Vs Burning Enemies")]
        SupportMinimumAddedFireDamageVsBurningEnemies = 6176,
        [Description("Support Maximum Added Fire Damage Vs Burning Enemies")]
        SupportMaximumAddedFireDamageVsBurningEnemies = 6177,
        [Description("Support Unbound Ailments Ailment Damage +% Final")]
        SupportUnboundAilmentsAilmentDamagePosPctFinal = 6178,
        [Description("Trigger Charge Additional Block Chance Against Projectiles %")]
        TriggerChargeAdditionalBlockChanceAgainstProjectilesPct = 6179,
        [Description("Chaos Damage Resistance Is Doubled")]
        ChaosDamageResistanceIsDoubled = 6180,
        [Description("Skill Area Of Effect +% While No Frenzy Charges")]
        SkillAreaOfEffectPosPctWhileNoFrenzyCharges = 6181,
        [Description("Global Critical Strike Multiplier + While You Have No Frenzy Charges")]
        GlobalCriticalStrikeMultiplierPosWhileYouHaveNoFrenzyCharges = 6182,
        [Description("Gain Maximum Power Charges On Power Charge Gained % Chance")]
        GainMaximumPowerChargesOnPowerChargeGainedPctChance = 6183,
        [Description("Damage +% Per Power Charge")]
        DamagePosPctPerPowerCharge = 6184,
        [Description("Base Fire Damage Can Poison")]
        BaseFireDamageCanPoison = 6185,
        [Description("Base Cold Damage Can Poison")]
        BaseColdDamageCanPoison = 6186,
        [Description("Base Lightning Damage Can Poison")]
        BaseLightningDamageCanPoison = 6187,
        [Description("Fire Skills Chance To Poison On Hit %")]
        FireSkillsChanceToPoisonOnHitPct = 6188,
        [Description("Cold Skills Chance To Poison On Hit %")]
        ColdSkillsChanceToPoisonOnHitPct = 6189,
        [Description("Lightning Skills Chance To Poison On Hit %")]
        LightningSkillsChanceToPoisonOnHitPct = 6190,
        [Description("Movement Attack Skills Attack Speed +%")]
        MovementAttackSkillsAttackSpeedPosPct = 6191,
        [Description("Local Socketed Herald Gem Level +")]
        LocalSocketedHeraldGemLevelPos = 6192,
        [Description("Cold Damage +% If You Have Used A Fire Skill Recently")]
        ColdDamagePosPctIfYouHaveUsedAFireSkillRecently = 6193,
        [Description("Fire Damage +% If You Have Used A Cold Skill Recently")]
        FireDamagePosPctIfYouHaveUsedAColdSkillRecently = 6194,
        [Description("Track Have Used A Cold Skill Recently")]
        TrackHaveUsedAColdSkillRecently = 6195,
        [Description("Have Used A Cold Skill Recently")]
        HaveUsedAColdSkillRecently = 6196,
        [Description("Support Maim Chance Physical Damage +% Final")]
        SupportMaimChancePhysicalDamagePosPctFinal = 6197,
        [Description("Support Brutality Physical Damage +% Final")]
        SupportBrutalityPhysicalDamagePosPctFinal = 6198,
        [Description("Summon Specific Monsters In Front Offset")]
        SummonSpecificMonstersInFrontOffset = 6199,
        [Description("Trap And Mine Damage Penetrates % Elemental Resistance")]
        TrapAndMineDamagePenetratesPctElementalResistance = 6200,
        [Description("Cooldown Speed +% Per Additional Player")]
        CooldownSpeedPosPctPerAdditionalPlayer = 6201,
        [Description("Total Damage Taken Per Minute To Mana")]
        TotalDamageTakenPerMinuteToMana = 6202,
        [Description("Total Damage Taken Per Minute That Bypasses Es")]
        TotalDamageTakenPerMinuteThatBypassesEs = 6203,
        [Description("Total Damage Taken Per Minute That Damages Es")]
        TotalDamageTakenPerMinuteThatDamagesEs = 6204,
        [Description("Total Nonlethal Damage Taken Per Minute That Damages Es")]
        TotalNonlethalDamageTakenPerMinuteThatDamagesEs = 6205,
        [Description("Enemies That Hit You With Attack Recently Attack Speed +%")]
        EnemiesThatHitYouWithAttackRecentlyAttackSpeedPosPct = 6206,
        [Description("Vaal Skill Soul Cost +%")]
        VaalSkillSoulCostPosPct = 6207,
        [Description("Has Attacker Projectile Attack Conditional Damage Stats")]
        HasAttackerProjectileAttackConditionalDamageStats = 6208,
        [Description("Has Attacker Conditional Damage Stats")]
        HasAttackerConditionalDamageStats = 6209,
        [Description("Has Attacker Projectile Spell Conditional Damage Stats")]
        HasAttackerProjectileSpellConditionalDamageStats = 6210,
        [Description("Number Of Projectiles Override")]
        NumberOfProjectilesOverride = 6211,
        [Description("Map Pantheon Flask Capture Boss Soul")]
        MapPantheonFlaskCaptureBossSoul = 6212,
        [Description("Physical Damage Over Time Taken +% While Moving")]
        PhysicalDamageOverTimeTakenPosPctWhileMoving = 6213,
        [Description("Physical Damage Reduction % If Only One Enemy Nearby")]
        PhysicalDamageReductionPctIfOnlyOneEnemyNearby = 6214,
        [Description("Take Half Area Damage From Hit % Chance")]
        TakeHalfAreaDamageFromHitPctChance = 6215,
        [Description("Elemental Damage Taken +% If Not Hit Recently")]
        ElementalDamageTakenPosPctIfNotHitRecently = 6216,
        [Description("Self Take No Extra Damage From Critical Strikes If Have Been Crit Recently")]
        SelfTakeNoExtraDamageFromCriticalStrikesIfHaveBeenCritRecently = 6217,
        [Description("Have Been Crit Recently")]
        HaveBeenCritRecently = 6218,
        [Description("Track Have Been Crit Recently")]
        TrackHaveBeenCritRecently = 6219,
        [Description("Avoid Ailments % From Crit")]
        AvoidAilmentsPctFromCrit = 6220,
        [Description("Physical Damage Reduction % Per Nearby Enemy")]
        PhysicalDamageReductionPctPerNearbyEnemy = 6221,
        [Description("Movement Speed +% Per Nearby Enemy")]
        MovementSpeedPosPctPerNearbyEnemy = 6222,
        [Description("Base Avoid Projectiles % Chance")]
        BaseAvoidProjectilesPctChance = 6223,
        [Description("Dodge Attacks And Spells % Chance If Have Been Hit Recently")]
        DodgeAttacksAndSpellsPctChanceIfHaveBeenHitRecently = 6224,
        [Description("Prevent Projectile Chaining % Chance")]
        PreventProjectileChainingPctChance = 6225,
        [Description("Avoid Chained Projectile % Chance")]
        AvoidChainedProjectilePctChance = 6226,
        [Description("Cold Damage Taken +% If Have Been Hit Recently")]
        ColdDamageTakenPosPctIfHaveBeenHitRecently = 6227,
        [Description("Reflect Chill And Freeze % Chance")]
        ReflectChillAndFreezePctChance = 6228,
        [Description("Virtual Self Take No Extra Damage From Critical Strikes")]
        VirtualSelfTakeNoExtraDamageFromCriticalStrikes = 6229,
        [Description("Projectile Spread Radius Per Additional Projectile")]
        ProjectileSpreadRadiusPerAdditionalProjectile = 6230,
        [Description("Trigger Cascade Number Of Spikes")]
        TriggerCascadeNumberOfSpikes = 6231,
        [Description("Trigger Cascade Ms Between Spikes")]
        TriggerCascadeMsBetweenSpikes = 6232,
        [Description("Cast On Trigger Cascade Event %")]
        CastOnTriggerCascadeEventPct = 6233,
        [Description("Trigger Cascade Behaviour Variation")]
        TriggerCascadeBehaviourVariation = 6234,
        [Description("Garukhan Number Of Tornadoes")]
        GarukhanNumberOfTornadoes = 6235,
        [Description("Map Pack Subindex Override")]
        MapPackSubindexOverride = 6236,
        [Description("Map Boss Override")]
        MapBossOverride = 6237,
        [Description("Map Daily Mission Master Level")]
        MapDailyMissionMasterLevel = 6238,
        [Description("Number Of Nearby Enemies")]
        NumberOfNearbyEnemies = 6239,
        [Description("Track Number Of Nearby Enemies")]
        TrackNumberOfNearbyEnemies = 6240,
        [Description("Volatile Flameblood Spawn Monster On Death Variation")]
        VolatileFlamebloodSpawnMonsterOnDeathVariation = 6241,
        [Description("Hit And Poison Damage +%")]
        HitAndPoisonDamagePosPct = 6242,
        [Description("Hit And Poison Damage +% Per Poison On Enemy")]
        HitAndPoisonDamagePosPctPerPoisonOnEnemy = 6243,
        [Description("Attack Minimum Added Physical Damage With Weapons")]
        AttackMinimumAddedPhysicalDamageWithWeapons = 6244,
        [Description("Attack Maximum Added Physical Damage With Weapons")]
        AttackMaximumAddedPhysicalDamageWithWeapons = 6245,
        [Description("Trigger On Projectile Loop Count")]
        TriggerOnProjectileLoopCount = 6246,
        [Description("Trigger On Projectile Death")]
        TriggerOnProjectileDeath = 6247,
        [Description("Base Number Of Beast Minions Allowed")]
        BaseNumberOfBeastMinionsAllowed = 6248,
        [Description("Number Of Beast Minions Allowed")]
        NumberOfBeastMinionsAllowed = 6249,
        [Description("Local Display Grants Summon Beast Companion")]
        LocalDisplayGrantsSummonBeastCompanion = 6250,
        [Description("Molten Shell Explosion Cooldown Ms")]
        MoltenShellExplosionCooldownMs = 6251,
        [Description("From Code Active Skill Hit And Ailment Damage +% Final")]
        FromCodeActiveSkillHitAndAilmentDamagePosPctFinal = 6252,
        [Description("Tornado Movement Velocity +%")]
        TornadoMovementVelocityPosPct = 6253,
        [Description("Monster Aggro Radius +%")]
        MonsterAggroRadiusPosPct = 6254,
        [Description("Ground Ice Art Variation")]
        GroundIceArtVariation = 6255,
        [Description("Additional Projectiles Fire Parallel X Dist")]
        AdditionalProjectilesFireParallelXDist = 6256,
        [Description("Additional Projectiles Fire Parallel Y Dist")]
        AdditionalProjectilesFireParallelYDist = 6257,
        [Description("From Code Active Skill Ailment Damage +% Final")]
        FromCodeActiveSkillAilmentDamagePosPctFinal = 6258,
        [Description("Flameblast Ailment Damage +% Final Per Stack")]
        FlameblastAilmentDamagePosPctFinalPerStack = 6259,
        [Description("Trigger Cascade A")]
        TriggerCascadeA = 6260,
        [Description("Trigger Cascade B")]
        TriggerCascadeB = 6261,
        [Description("Trigger Cascade C")]
        TriggerCascadeC = 6262,
        [Description("Trigger Cascade D")]
        TriggerCascadeD = 6263,
        [Description("Trigger Cascade Angle")]
        TriggerCascadeAngle = 6264,
        [Description("Local Use Skill On Hit %")]
        LocalUseSkillOnHitPct = 6265,
        [Description("Main Hand Use Skill On Hit %")]
        MainHandUseSkillOnHitPct = 6266,
        [Description("Off Hand Use Skill On Hit %")]
        OffHandUseSkillOnHitPct = 6267,
        [Description("Skill Has Trigger From Unique Item")]
        SkillHasTriggerFromUniqueItem = 6268,
        [Description("Local Display Use Level X Abyssal Cry On Hit")]
        LocalDisplayUseLevelXAbyssalCryOnHit = 6269,
        [Description("Accelerate Min")]
        AccelerateMin = 6270,
        [Description("Accelerate Max")]
        AccelerateMax = 6271,
        [Description("Accelerate Time")]
        AccelerateTime = 6272,
        [Description("Skill Is Minion Skill")]
        SkillIsMinionSkill = 6273,
        [Description("Minion Skill Mana Cost +%")]
        MinionSkillManaCostPosPct = 6274,
        [Description("Local Display Grants Skill Doryanis Touch Level")]
        LocalDisplayGrantsSkillDoryanisTouchLevel = 6275,
        [Description("Trigger Cascade Target Variation")]
        TriggerCascadeTargetVariation = 6276,
        [Description("Trigger Cascade Number Of Arms")]
        TriggerCascadeNumberOfArms = 6277,
        [Description("Trigger Cascade Angle Between Arms")]
        TriggerCascadeAngleBetweenArms = 6278,
        [Description("Support Ruthless Big Hit Max Count")]
        SupportRuthlessBigHitMaxCount = 6279,
        [Description("Melee Damage +% Final From Ruthless Blow")]
        MeleeDamagePosPctFinalFromRuthlessBlow = 6280,
        [Description("Stun Base Duration Override Ms")]
        StunBaseDurationOverrideMs = 6281,
        [Description("Support Ruthless Big Hit Stun Base Duration Override Ms")]
        SupportRuthlessBigHitStunBaseDurationOverrideMs = 6282,
        [Description("Support Ruthless Big Hit Damage +% Final")]
        SupportRuthlessBigHitDamagePosPctFinal = 6283,
        [Description("Support Scion Onslaught On Killing Blow % Chance")]
        SupportScionOnslaughtOnKillingBlowPctChance = 6284,
        [Description("Support Scion Onslaught On Killing Blow Duration Ms")]
        SupportScionOnslaughtOnKillingBlowDurationMs = 6285,
        [Description("Support Arcane Surge Gain Buff On Mana Use Threshold")]
        SupportArcaneSurgeGainBuffOnManaUseThreshold = 6286,
        [Description("Support Arcane Surge Spell Damage +% Final")]
        SupportArcaneSurgeSpellDamagePosPctFinal = 6287,
        [Description("Spell Damage +% Final From Arcane Surge")]
        SpellDamagePosPctFinalFromArcaneSurge = 6288,
        [Description("Support Arcane Surge Duration Ms")]
        SupportArcaneSurgeDurationMs = 6289,
        [Description("Support Arcane Surge Base Duration Ms")]
        SupportArcaneSurgeBaseDurationMs = 6290,
        [Description("Support Arcane Surge Cast Speed +%")]
        SupportArcaneSurgeCastSpeedPosPct = 6291,
        [Description("Support Arcane Surge Mana Regeneration Rate Per Minute %")]
        SupportArcaneSurgeManaRegenerationRatePerMinutePct = 6292,
        [Description("Hidden Monster Can Have Auras")]
        HiddenMonsterCanHaveAuras = 6293,
        [Description("Projectile Number Of Targets To Pierce")]
        ProjectileNumberOfTargetsToPierce = 6294,
        [Description("Arrow Number Of Targets To Pierce")]
        ArrowNumberOfTargetsToPierce = 6295,
        [Description("Projectile Base Number Of Targets To Pierce")]
        ProjectileBaseNumberOfTargetsToPierce = 6296,
        [Description("Arrow Base Number Of Targets To Pierce")]
        ArrowBaseNumberOfTargetsToPierce = 6297,
        [Description("Arrows Always Pierce")]
        ArrowsAlwaysPierce = 6298,
        [Description("Base Arrows Always Pierce")]
        BaseArrowsAlwaysPierce = 6299,
        [Description("Virtual Always Pierce")]
        VirtualAlwaysPierce = 6300,
        [Description("Support Ignite Prolif Ignite Damage +% Final")]
        SupportIgniteProlifIgniteDamagePosPctFinal = 6301,
        [Description("Combined Ailment All Damage Over Time +% Final")]
        CombinedAilmentAllDamageOverTimePosPctFinal = 6302,
        [Description("Projectiles Always Pierce You")]
        ProjectilesAlwaysPierceYou = 6303,
        [Description("Arrow Damage +% Vs Pierced Targets")]
        ArrowDamagePosPctVsPiercedTargets = 6304,
        [Description("Projectiles Pierce X Additional Targets While You Have Phasing")]
        ProjectilesPierceXAdditionalTargetsWhileYouHavePhasing = 6305,
        [Description("Quiver Projectiles Pierce 1 Additional Target")]
        QuiverProjectilesPierce1AdditionalTarget = 6306,
        [Description("Quiver Projectiles Pierce 2 Additional Targets")]
        QuiverProjectilesPierce2AdditionalTargets = 6307,
        [Description("Quiver Projectiles Pierce 3 Additional Targets")]
        QuiverProjectilesPierce3AdditionalTargets = 6308,
        [Description("Projectiles Pierce All Nearby Targets")]
        ProjectilesPierceAllNearbyTargets = 6309,
        [Description("Projectiles Pierce 1 Additional Target Per 10 Stat Value")]
        ProjectilesPierce1AdditionalTargetPer10StatValue = 6310,
        [Description("Projectiles Pierce 1 Additional Target Per 15 Stat Value")]
        ProjectilesPierce1AdditionalTargetPer15StatValue = 6311,
        [Description("Talisman Implicit Projectiles Pierce 1 Additional Target Per 10")]
        TalismanImplicitProjectilesPierce1AdditionalTargetPer10 = 6312,
        [Description("Blade Vortex Ailment Damage +% Per Blade Final")]
        BladeVortexAilmentDamagePosPctPerBladeFinal = 6313,
        [Description("Bladefall Width +%")]
        BladefallWidthPosPct = 6314,
        [Description("Lightning Strike Additional Pierce Per 10 Old")]
        LightningStrikeAdditionalPiercePer10Old = 6315,
        [Description("Lightning Strike Additional Pierce")]
        LightningStrikeAdditionalPierce = 6316,
        [Description("Lightning Trap Additional Pierce Per 10 Old")]
        LightningTrapAdditionalPiercePer10Old = 6317,
        [Description("Lightning Trap Additional Pierce")]
        LightningTrapAdditionalPierce = 6318,
        [Description("Support Poison Poison Damage +% Final")]
        SupportPoisonPoisonDamagePosPctFinal = 6319,
        [Description("Attacks Chance To Poison % On Max Frenzy Charges")]
        AttacksChanceToPoisonPctOnMaxFrenzyCharges = 6320,
        [Description("Chance To Poison % Vs Cursed Enemies")]
        ChanceToPoisonPctVsCursedEnemies = 6321,
        [Description("Chaos Damage Chance To Poison %")]
        ChaosDamageChanceToPoisonPct = 6322,
        [Description("Virtual Chance To Poison On Hit With Attacks %")]
        VirtualChanceToPoisonOnHitWithAttacksPct = 6323,
        [Description("Support Innervate Minimum Added Lightning Damage")]
        SupportInnervateMinimumAddedLightningDamage = 6324,
        [Description("Support Innervate Maximum Added Lightning Damage")]
        SupportInnervateMaximumAddedLightningDamage = 6325,
        [Description("Support Innervate Buff Duration Ms")]
        SupportInnervateBuffDurationMs = 6326,
        [Description("Support Innervate Buff Base Duration Ms")]
        SupportInnervateBuffBaseDurationMs = 6327,
        [Description("Local Unique Jewel Spark Projectiles Nova With 40 Int In Radius")]
        LocalUniqueJewelSparkProjectilesNovaWith40IntInRadius = 6328,
        [Description("Spark Projectiles Nova")]
        SparkProjectilesNova = 6329,
        [Description("Local Unique Jewel Spark Number Of Additional Projectiles With 40 Int In Radius")]
        LocalUniqueJewelSparkNumberOfAdditionalProjectilesWith40IntInRadius = 6330,
        [Description("Spark Number Of Additional Projectiles")]
        SparkNumberOfAdditionalProjectiles = 6331,
        [Description("Local Unique Jewel Blight Hinder Enemy Chaos Damage Taken +% With 40 Int In Radius")]
        LocalUniqueJewelBlightHinderEnemyChaosDamageTakenPosPctWith40IntInRadius = 6332,
        [Description("Blight Hinder Enemy Chaos Damage Taken +%")]
        BlightHinderEnemyChaosDamageTakenPosPct = 6333,
        [Description("Local Unique Jewel Blight Hinder Duration +% With 40 Int In Radius")]
        LocalUniqueJewelBlightHinderDurationPosPctWith40IntInRadius = 6334,
        [Description("Local Unique Jewel Split Arrow Projectiles Fire In Parallel X Dist With 40 Dex In Radius")]
        LocalUniqueJewelSplitArrowProjectilesFireInParallelXDistWith40DexInRadius = 6335,
        [Description("Split Arrow Projectiles Fire In Parallel X Dist")]
        SplitArrowProjectilesFireInParallelXDist = 6336,
        [Description("Local Unique Jewel Split Arrow Projectiles Fire In Parallel Y Dist With 40 Dex In Radius")]
        LocalUniqueJewelSplitArrowProjectilesFireInParallelYDistWith40DexInRadius = 6337,
        [Description("Split Arrow Projectiles Fire In Parallel Y Dist")]
        SplitArrowProjectilesFireInParallelYDist = 6338,
        [Description("Local Unique Jewel Fire Trap Number Of Additional Traps To Throw With 40 Dex In Radius")]
        LocalUniqueJewelFireTrapNumberOfAdditionalTrapsToThrowWith40DexInRadius = 6339,
        [Description("Fire Trap Number Of Additional Traps To Throw")]
        FireTrapNumberOfAdditionalTrapsToThrow = 6340,
        [Description("Piercing Projectiles Critical Strike Chance +%")]
        PiercingProjectilesCriticalStrikeChancePosPct = 6341,
        [Description("Arrow Damage +50% Vs Pierced Targets")]
        ArrowDamagePos50PctVsPiercedTargets = 6342,
        [Description("Arrows Pierce Additional Target")]
        ArrowsPierceAdditionalTarget = 6343,
        [Description("Ice Shot Additional Pierce Per 10 Old")]
        IceShotAdditionalPiercePer10Old = 6344,
        [Description("Local Unique Jewel Ice Shot Additional Pierce Per 10 Old With 40 Dex In Radius")]
        LocalUniqueJewelIceShotAdditionalPiercePer10OldWith40DexInRadius = 6345,
        [Description("Virtual Cooldown Modifier Ms")]
        VirtualCooldownModifierMs = 6346,
        [Description("Base Cooldown Modifier Ms")]
        BaseCooldownModifierMs = 6347,
        [Description("Summon Skeletons Cooldown Modifier Ms")]
        SummonSkeletonsCooldownModifierMs = 6348,
        [Description("Trigger Cascade Use Contact Points")]
        TriggerCascadeUseContactPoints = 6349,
        [Description("Arrows Pierce 1 Additional Target Per 10 Stat Value")]
        ArrowsPierce1AdditionalTargetPer10StatValue = 6350,
        [Description("Summon Skeletons Additional Warrior Skeleton % Chance")]
        SummonSkeletonsAdditionalWarriorSkeletonPctChance = 6351,
        [Description("Map Spawn Harbingers")]
        MapSpawnHarbingers = 6352,
        [Description("Map Num Extra Harbingers")]
        MapNumExtraHarbingers = 6353,
        [Description("Map Packs Are Lunaris")]
        MapPacksAreLunaris = 6354,
        [Description("Map Packs Are Solaris")]
        MapPacksAreSolaris = 6355,
        [Description("Map Packs Are Ghosts")]
        MapPacksAreGhosts = 6356,
        [Description("Skeletal Chains No Minions Radius +")]
        SkeletalChainsNoMinionsRadiusPos = 6357,
        [Description("Skeletal Chains No Minions Targets Self")]
        SkeletalChainsNoMinionsTargetsSelf = 6358,
        [Description("Ice Shot Pierce +")]
        IceShotPiercePos = 6359,
        [Description("Local Unique Jewel Ice Shot Pierce + With 40 Dex In Radius")]
        LocalUniqueJewelIceShotPiercePosWith40DexInRadius = 6360,
        [Description("Non Damaging Ailment Effect +%")]
        NonDamagingAilmentEffectPosPct = 6361,
        [Description("Bleeding Stacks Up To X Times")]
        BleedingStacksUpToXTimes = 6362,
        [Description("Energy Shield Recharge Start When Stunned")]
        EnergyShieldRechargeStartWhenStunned = 6363,
        [Description("No Extra Bleed Damage While Target Is Moving")]
        NoExtraBleedDamageWhileTargetIsMoving = 6364,
        [Description("Keystone Crimson Dance Bleeding Damage +% Final")]
        KeystoneCrimsonDanceBleedingDamagePosPctFinal = 6365,
        [Description("Track Which Enemies Hit")]
        TrackWhichEnemiesHit = 6366,
        [Description("Skill Behaviour Variation")]
        SkillBehaviourVariation = 6367,
        [Description("Trigger Skill Restriction")]
        TriggerSkillRestriction = 6368,
        [Description("Prophecy Monster Spawn Level")]
        ProphecyMonsterSpawnLevel = 6369,
        [Description("Number Of Skeletons Allowed Per 2 Old")]
        NumberOfSkeletonsAllowedPer2Old = 6370,
        [Description("Cast On Trigger Cascade Event")]
        CastOnTriggerCascadeEvent = 6371,
        [Description("Spark Skill Effect Duration +%")]
        SparkSkillEffectDurationPosPct = 6372,
        [Description("Support Innervate Gain Buff On Killing Shocked Enemy")]
        SupportInnervateGainBuffOnKillingShockedEnemy = 6373,
        [Description("Additional Critical Strike Chance Permyriad While At Maximum Power Charges")]
        AdditionalCriticalStrikeChancePermyriadWhileAtMaximumPowerCharges = 6374,
        [Description("Object Inherent Spell Damage +% Final Per Power Charge")]
        ObjectInherentSpellDamagePosPctFinalPerPowerCharge = 6375,
        [Description("Damage Over Time +% Per Frenzy Charge")]
        DamageOverTimePosPctPerFrenzyCharge = 6376,
        [Description("Damage Over Time +% Per Power Charge")]
        DamageOverTimePosPctPerPowerCharge = 6377,
        [Description("Gain Frenzy And Power Charge On Kill %")]
        GainFrenzyAndPowerChargeOnKillPct = 6378,
        [Description("Maximum Power And Frenzy Charges +")]
        MaximumPowerAndFrenzyChargesPos = 6379,
        [Description("Labyrinth Darkshrine Players Damage Taken From Labyrinth Traps +%")]
        LabyrinthDarkshrinePlayersDamageTakenFromLabyrinthTrapsPosPct = 6380,
        [Description("Labyrinth Darkshrine Boss Room Traps Are Disabled")]
        LabyrinthDarkshrineBossRoomTrapsAreDisabled = 6381,
        [Description("Labyrinth Darkshrine Players Have Shrine Row X Effect For This Labyrinth")]
        LabyrinthDarkshrinePlayersHaveShrineRowXEffectForThisLabyrinth = 6382,
        [Description("Labyrinth Darkshrine Divine Font Grants One Additional Enchantment Use To Player X")]
        LabyrinthDarkshrineDivineFontGrantsOneAdditionalEnchantmentUseToPlayerX = 6383,
        [Description("Labyrinth Darkshrine Izaro Drops X Additional Treasure Keys")]
        LabyrinthDarkshrineIzaroDropsXAdditionalTreasureKeys = 6384,
        [Description("Damage Taken From Labyrinth Traps +%")]
        DamageTakenFromLabyrinthTrapsPosPct = 6385,
        [Description("Labyrinth Darkshrine Izaro Dropped Unique Items +")]
        LabyrinthDarkshrineIzaroDroppedUniqueItemsPos = 6386,
        [Description("Convocation Max Number Of Minions To Teleport")]
        ConvocationMaxNumberOfMinionsToTeleport = 6387,
        [Description("Local Chance To Bleed On Hit 25%")]
        LocalChanceToBleedOnHit25Pct = 6388,
        [Description("Main Hand Local Chance To Bleed On Hit 25%")]
        MainHandLocalChanceToBleedOnHit25Pct = 6389,
        [Description("Off Hand Local Chance To Bleed On Hit 25%")]
        OffHandLocalChanceToBleedOnHit25Pct = 6390,
        [Description("Recover % Maximum Mana On Kill")]
        RecoverPctMaximumManaOnKill = 6391,
        [Description("Arctic Armour Chill When Hit Duration")]
        ArcticArmourChillWhenHitDuration = 6392,
        [Description("Debuff Time Passed +%")]
        DebuffTimePassedPosPct = 6393,
        [Description("Skill Is Channelled")]
        SkillIsChannelled = 6394,
        [Description("Channelled Skill Damage +%")]
        ChannelledSkillDamagePosPct = 6395,
        [Description("Local Display Socketed Gems Supported By X Innervate Level")]
        LocalDisplaySocketedGemsSupportedByXInnervateLevel = 6396,
        [Description("Local Display Summon Harbinger X On Equip")]
        LocalDisplaySummonHarbingerXOnEquip = 6397,
        [Description("Skeleton Movement Speed +%")]
        SkeletonMovementSpeedPosPct = 6398,
        [Description("Skeleton Attack Speed +%")]
        SkeletonAttackSpeedPosPct = 6399,
        [Description("Skeleton Cast Speed +%")]
        SkeletonCastSpeedPosPct = 6400,
        [Description("Physical Damage Over Time Taken +%")]
        PhysicalDamageOverTimeTakenPosPct = 6401,
        [Description("Summon Skeletons Additional Warrior Skeleton One Twentieth Chance")]
        SummonSkeletonsAdditionalWarriorSkeletonOneTwentiethChance = 6402,
        [Description("Leapslam Overshoot Distance")]
        LeapslamOvershootDistance = 6403,
        [Description("Skill Is Projectile Skill")]
        SkillIsProjectileSkill = 6404,
        [Description("Projectile Attack Skill Critical Strike Chance +%")]
        ProjectileAttackSkillCriticalStrikeChancePosPct = 6405,
        [Description("Storm Burst Avoid Interruption While Casting %")]
        StormBurstAvoidInterruptionWhileCastingPct = 6406,
        [Description("Storm Burst Area Of Effect +%")]
        StormBurstAreaOfEffectPosPct = 6407,
        [Description("Skeletal Chains Cast Speed +%")]
        SkeletalChainsCastSpeedPosPct = 6408,
        [Description("Skeletal Chains Area Of Effect +%")]
        SkeletalChainsAreaOfEffectPosPct = 6409,
        [Description("Unique Volkuurs Clutch Poison Duration +% Final")]
        UniqueVolkuursClutchPoisonDurationPosPctFinal = 6410,
        [Description("Combined Poison Duration +% Final")]
        CombinedPoisonDurationPosPctFinal = 6411,
        [Description("Local Display Trigger Level X Darktongue Kiss On Curse")]
        LocalDisplayTriggerLevelXDarktongueKissOnCurse = 6412,
        [Description("Cast When Cast Curse %")]
        CastWhenCastCursePct = 6413,
        [Description("Move Daemon Number Of Daemons To Spawn")]
        MoveDaemonNumberOfDaemonsToSpawn = 6414,
        [Description("Move Daemon Movement Speed")]
        MoveDaemonMovementSpeed = 6415,
        [Description("Move Daemon Distance To Travel")]
        MoveDaemonDistanceToTravel = 6416,
        [Description("Move Daemon Delay Between Daemons Ms")]
        MoveDaemonDelayBetweenDaemonsMs = 6417,
        [Description("Move Daemon Rotation")]
        MoveDaemonRotation = 6418,
        [Description("Move Daemon Rotation Per Daemon")]
        MoveDaemonRotationPerDaemon = 6419,
        [Description("Move Daemon End Rotation")]
        MoveDaemonEndRotation = 6420,
        [Description("Move Daemon End Rotation Per Daemon")]
        MoveDaemonEndRotationPerDaemon = 6421,
        [Description("Move Daemon X Offset")]
        MoveDaemonXOffset = 6422,
        [Description("Move Daemon Y Offset")]
        MoveDaemonYOffset = 6423,
        [Description("Move Daemon X Offset Per Daemon")]
        MoveDaemonXOffsetPerDaemon = 6424,
        [Description("Move Daemon Y Offset Per Daemon")]
        MoveDaemonYOffsetPerDaemon = 6425,
        [Description("Move Daemon Pivot Variation")]
        MoveDaemonPivotVariation = 6426,
        [Description("Harbinger Minion Damage Taken +% Final Min")]
        HarbingerMinionDamageTakenPosPctFinalMin = 6427,
        [Description("Harbinger Minion Damage Taken +% Final Max")]
        HarbingerMinionDamageTakenPosPctFinalMax = 6428,
        [Description("Harbinger Minion Damage Taken +% Final Time")]
        HarbingerMinionDamageTakenPosPctFinalTime = 6429,
        [Description("Harbinger Minion Rare Chance %")]
        HarbingerMinionRareChancePct = 6430,
        [Description("Harbinger Minion Magic Chance %")]
        HarbingerMinionMagicChancePct = 6431,
        [Description("Harbinger Minion Remove Parent Life On Death Permyriad")]
        HarbingerMinionRemoveParentLifeOnDeathPermyriad = 6432,
        [Description("Critical Strike Chance Increased By Lightning Resistance")]
        CriticalStrikeChanceIncreasedByLightningResistance = 6433,
        [Description("Piercing Projectiles Critical Strike Chance +100%")]
        PiercingProjectilesCriticalStrikeChancePos100Pct = 6434,
        [Description("Cast On Skill Use %")]
        CastOnSkillUsePct = 6435,
        [Description("Local Display Trigger Level X Void Gaze On Skill Use")]
        LocalDisplayTriggerLevelXVoidGazeOnSkillUse = 6436,
        [Description("Cannot Be Stunned If You Have Blocked A Stun Recently")]
        CannotBeStunnedIfYouHaveBlockedAStunRecently = 6437,
        [Description("Track Have Blocked A Stun Recently")]
        TrackHaveBlockedAStunRecently = 6438,
        [Description("Have Blocked A Stun Recently")]
        HaveBlockedAStunRecently = 6439,
        [Description("Charged Dash Damage +% Maximum")]
        ChargedDashDamagePosPctMaximum = 6440,
        [Description("Local Display Trigger Level X Storm Cascade On Attack")]
        LocalDisplayTriggerLevelXStormCascadeOnAttack = 6441,
        [Description("Empty Action State Value")]
        EmptyActionStateValue = 6442,
        [Description("Minimum Added Chaos Damage Vs Enemies With 5+ Poisons")]
        MinimumAddedChaosDamageVsEnemiesWith5PosPoisons = 6443,
        [Description("Maximum Added Chaos Damage Vs Enemies With 5+ Poisons")]
        MaximumAddedChaosDamageVsEnemiesWith5PosPoisons = 6444,
        [Description("Main Hand Minimum Added Chaos Damage Vs Enemies With 5+ Poisons")]
        MainHandMinimumAddedChaosDamageVsEnemiesWith5PosPoisons = 6445,
        [Description("Main Hand Maximum Added Chaos Damage Vs Enemies With 5+ Poisons")]
        MainHandMaximumAddedChaosDamageVsEnemiesWith5PosPoisons = 6446,
        [Description("Off Hand Minimum Added Chaos Damage Vs Enemies With 5+ Poisons")]
        OffHandMinimumAddedChaosDamageVsEnemiesWith5PosPoisons = 6447,
        [Description("Off Hand Maximum Added Chaos Damage Vs Enemies With 5+ Poisons")]
        OffHandMaximumAddedChaosDamageVsEnemiesWith5PosPoisons = 6448,
        [Description("Life Leech From Attack Damage Permyriad Vs Poisoned Enemies")]
        LifeLeechFromAttackDamagePermyriadVsPoisonedEnemies = 6449,
        [Description("Poison Duration +% Per Power Charge")]
        PoisonDurationPosPctPerPowerCharge = 6450,
        [Description("Poison Damage +% Per Frenzy Charge")]
        PoisonDamagePosPctPerFrenzyCharge = 6451,
        [Description("Gain Frenzy Charge On Kill Vs Enemies With 5+ Poisons %")]
        GainFrenzyChargeOnKillVsEnemiesWith5PosPoisonsPct = 6452,
        [Description("Gain Power Charge On Kill Vs Enemies With Less Than 5 Poisons %")]
        GainPowerChargeOnKillVsEnemiesWithLessThan5PoisonsPct = 6453,
        [Description("Local Display Socketed Gems Supported By X Lesser Poison")]
        LocalDisplaySocketedGemsSupportedByXLesserPoison = 6454,
        [Description("Poison Duration +% With Over 150 Intelligence")]
        PoisonDurationPosPctWithOver150Intelligence = 6455,
        [Description("Poison Damage +% With Over 300 Dexterity")]
        PoisonDamagePosPctWithOver300Dexterity = 6456,
        [Description("Local Display Socketed Gems Supported By X Vile Toxins")]
        LocalDisplaySocketedGemsSupportedByXVileToxins = 6457,
        [Description("Local Display Grants Skill Blight Level")]
        LocalDisplayGrantsSkillBlightLevel = 6458,
        [Description("You Cannot Be Hindered")]
        YouCannotBeHindered = 6459,
        [Description("Support Melee Physical Damage Poison And Bleeding Damage +% Final From Melee Hits")]
        SupportMeleePhysicalDamagePoisonAndBleedingDamagePosPctFinalFromMeleeHits = 6460,
        [Description("Support Phys Proj Attack Damage Bleeing And Poison Damage +% Final From Projectile Hits")]
        SupportPhysProjAttackDamageBleeingAndPoisonDamagePosPctFinalFromProjectileHits = 6461,
        [Description("Support Ruthless Blow Bleeding Damage From Melee Hits +% Final")]
        SupportRuthlessBlowBleedingDamageFromMeleeHitsPosPctFinal = 6462,
        [Description("Melee Hit Bleeding Damage +% Final From Ruthless Blow")]
        MeleeHitBleedingDamagePosPctFinalFromRuthlessBlow = 6463,
        [Description("Support Chance To Bleed Bleeding Damage +% Final")]
        SupportChanceToBleedBleedingDamagePosPctFinal = 6464,
        [Description("Charged Dash Chance To Dodge % If Finished Channelling Recently")]
        ChargedDashChanceToDodgePctIfFinishedChannellingRecently = 6465,
        [Description("Charged Dash Area Of Effect Radius + Of Final Explosion")]
        ChargedDashAreaOfEffectRadiusPosOfFinalExplosion = 6466,
        [Description("Additional Physical Damage Reduction % If Not Player")]
        AdditionalPhysicalDamageReductionPctIfNotPlayer = 6467,
        [Description("Resist All Elements % If Not Player")]
        ResistAllElementsPctIfNotPlayer = 6468,
        [Description("Physical Damage % To Gain As Chaos While At Maximum Power Charges")]
        PhysicalDamagePctToGainAsChaosWhileAtMaximumPowerCharges = 6469,
        [Description("Attack Ailment Damage +% While Wielding Dagger")]
        AttackAilmentDamagePosPctWhileWieldingDagger = 6470,
        [Description("Attack Ailment Damage +% While Wielding Claw")]
        AttackAilmentDamagePosPctWhileWieldingClaw = 6471,
        [Description("Attack Ailment Damage +% While Wielding Sword")]
        AttackAilmentDamagePosPctWhileWieldingSword = 6472,
        [Description("Attack Ailment Damage +% While Wielding Bow")]
        AttackAilmentDamagePosPctWhileWieldingBow = 6473,
        [Description("Attack Ailment Damage +% While Wielding Axe")]
        AttackAilmentDamagePosPctWhileWieldingAxe = 6474,
        [Description("Attack Ailment Damage +% While Wielding Mace")]
        AttackAilmentDamagePosPctWhileWieldingMace = 6475,
        [Description("Attack Ailment Damage +% While Wielding One Handed Weapon")]
        AttackAilmentDamagePosPctWhileWieldingOneHandedWeapon = 6476,
        [Description("Attack Ailment Damage +% While Wielding Two Handed Weapon")]
        AttackAilmentDamagePosPctWhileWieldingTwoHandedWeapon = 6477,
        [Description("Attack Ailment Damage +% While Dual Wielding")]
        AttackAilmentDamagePosPctWhileDualWielding = 6478,
        [Description("Attack Ailment Damage +% While Holding Shield")]
        AttackAilmentDamagePosPctWhileHoldingShield = 6479,
        [Description("Attack Ailment Damage +% While Wielding Melee Weapon")]
        AttackAilmentDamagePosPctWhileWieldingMeleeWeapon = 6480,
        [Description("Combined Ailment Damage +% From Weapon Types")]
        CombinedAilmentDamagePosPctFromWeaponTypes = 6481,
        [Description("Immune To Status Ailments")]
        ImmuneToStatusAilments = 6482,
        [Description("Chance To Hit While Blinded +% Final")]
        ChanceToHitWhileBlindedPosPctFinal = 6483,
        [Description("Chance To Hit +% Final")]
        ChanceToHitPosPctFinal = 6484,
        [Description("Is Summoned Harbinger Monster")]
        IsSummonedHarbingerMonster = 6485,
        [Description("Ignored By Enemy Target Selection")]
        IgnoredByEnemyTargetSelection = 6486,
        [Description("Base Ignored By Enemy Target Selection")]
        BaseIgnoredByEnemyTargetSelection = 6487,
        [Description("Map Packs Have Belly Totems")]
        MapPacksHaveBellyTotems = 6488,
        [Description("Harbinger Minion Max Magic Count")]
        HarbingerMinionMaxMagicCount = 6489,
        [Description("Harbinger Minion Max Rare Count")]
        HarbingerMinionMaxRareCount = 6490,
        [Description("Cannot Be Stunned If Have Been Stunned Or Blocked Stunning Hit In Past 2 Seconds")]
        CannotBeStunnedIfHaveBeenStunnedOrBlockedStunningHitInPast2Seconds = 6491,
        [Description("Glacial Cascade Number Of Additional Bursts")]
        GlacialCascadeNumberOfAdditionalBursts = 6492,
        [Description("Local Unique Jewel Glacial Cascade Number Of Additional Bursts With 40 Int In Radius")]
        LocalUniqueJewelGlacialCascadeNumberOfAdditionalBurstsWith40IntInRadius = 6493,
        [Description("Number Of Active Beast Minions")]
        NumberOfActiveBeastMinions = 6494,
        [Description("Projectile Attacks Chance To Bleed On Hit % If You Have Beast Minion")]
        ProjectileAttacksChanceToBleedOnHitPctIfYouHaveBeastMinion = 6495,
        [Description("Attack Minimum Added Physical Damage If You Have Beast Minion")]
        AttackMinimumAddedPhysicalDamageIfYouHaveBeastMinion = 6496,
        [Description("Attack Maximum Added Physical Damage If You Have Beast Minion")]
        AttackMaximumAddedPhysicalDamageIfYouHaveBeastMinion = 6497,
        [Description("Projectile Attacks Chance To Maim On Hit % If You Have Beast Minion")]
        ProjectileAttacksChanceToMaimOnHitPctIfYouHaveBeastMinion = 6498,
        [Description("Attack And Movement Speed +% If You Have Beast Minion")]
        AttackAndMovementSpeedPosPctIfYouHaveBeastMinion = 6499,
        [Description("Projectile Attacks Chance To Poison On Hit % If You Have Beast Minion")]
        ProjectileAttacksChanceToPoisonOnHitPctIfYouHaveBeastMinion = 6500,
        [Description("Attack Minimum Added Chaos Damage If You Have Beast Minion")]
        AttackMinimumAddedChaosDamageIfYouHaveBeastMinion = 6501,
        [Description("Attack Maximum Added Chaos Damage If You Have Beast Minion")]
        AttackMaximumAddedChaosDamageIfYouHaveBeastMinion = 6502,
        [Description("Local Bleed On Critical Strike Chance %")]
        LocalBleedOnCriticalStrikeChancePct = 6503,
        [Description("Main Hand Local Bleed On Critical Strike Chance %")]
        MainHandLocalBleedOnCriticalStrikeChancePct = 6504,
        [Description("Off Hand Local Bleed On Critical Strike Chance %")]
        OffHandLocalBleedOnCriticalStrikeChancePct = 6505,
        [Description("Local Poison On Critical Strike Chance %")]
        LocalPoisonOnCriticalStrikeChancePct = 6506,
        [Description("Main Hand Local Poison On Critical Strike Chance %")]
        MainHandLocalPoisonOnCriticalStrikeChancePct = 6507,
        [Description("Off Hand Local Poison On Critical Strike Chance %")]
        OffHandLocalPoisonOnCriticalStrikeChancePct = 6508,
        [Description("Virtual Main Hand Chance To Bleed On Critical Strike %")]
        VirtualMainHandChanceToBleedOnCriticalStrikePct = 6509,
        [Description("Virtual Off Hand Chance To Bleed On Critical Strike %")]
        VirtualOffHandChanceToBleedOnCriticalStrikePct = 6510,
        [Description("Local Chance To Bleed On Crit 50%")]
        LocalChanceToBleedOnCrit50Pct = 6511,
        [Description("Main Hand Local Chance To Bleed On Crit 50%")]
        MainHandLocalChanceToBleedOnCrit50Pct = 6512,
        [Description("Off Hand Local Chance To Bleed On Crit 50%")]
        OffHandLocalChanceToBleedOnCrit50Pct = 6513,
        [Description("Cast On Attack Use %")]
        CastOnAttackUsePct = 6514,
        [Description("Ignite Slower Burn %")]
        IgniteSlowerBurnPct = 6515,
        [Description("Virtual Ignite Duration +% Final")]
        VirtualIgniteDurationPosPctFinal = 6516,
        [Description("Object Inherent Damage +% Final Per Frenzy Charge")]
        ObjectInherentDamagePosPctFinalPerFrenzyCharge = 6517,
        [Description("Local Maim On Hit %")]
        LocalMaimOnHitPct = 6518,
        [Description("Main Hand Local Maim On Hit %")]
        MainHandLocalMaimOnHitPct = 6519,
        [Description("Off Hand Local Maim On Hit %")]
        OffHandLocalMaimOnHitPct = 6520,
        [Description("Life Leech From Attack Damage Permyriad Vs Maimed Enemies")]
        LifeLeechFromAttackDamagePermyriadVsMaimedEnemies = 6521,
        [Description("Local Display Grants Skill Death Aura Level")]
        LocalDisplayGrantsSkillDeathAuraLevel = 6522,
        [Description("Chilled Ground Base Magnitude Override")]
        ChilledGroundBaseMagnitudeOverride = 6523,
        [Description("Shocked Ground Base Magnitude Override")]
        ShockedGroundBaseMagnitudeOverride = 6524,
        [Description("Harbinger Base Currency Shard Stack Tenths To Drop")]
        HarbingerBaseCurrencyShardStackTenthsToDrop = 6525,
        [Description("Charged Dash Damage +%")]
        ChargedDashDamagePosPct = 6526,
        [Description("Storm Burst Damage +%")]
        StormBurstDamagePosPct = 6527,
        [Description("Skeletal Chains Damage +%")]
        SkeletalChainsDamagePosPct = 6528,
        [Description("Whirling Blades Base Ground Chaos Damage To Deal Per Minute")]
        WhirlingBladesBaseGroundChaosDamageToDealPerMinute = 6529,
        [Description("Chill And Freeze Duration +%")]
        ChillAndFreezeDurationPosPct = 6530,
        [Description("Local Chance To Bleed On Hit 50%")]
        LocalChanceToBleedOnHit50Pct = 6531,
        [Description("Main Hand Local Chance To Bleed On Hit 50%")]
        MainHandLocalChanceToBleedOnHit50Pct = 6532,
        [Description("Off Hand Local Chance To Bleed On Hit 50%")]
        OffHandLocalChanceToBleedOnHit50Pct = 6533,
        [Description("Arrows That Pierce Chance To Bleed 25%")]
        ArrowsThatPierceChanceToBleed25Pct = 6534,
        [Description("Attacks Chance To Bleed 25% Vs Cursed Enemies")]
        AttacksChanceToBleed25PctVsCursedEnemies = 6535,
        [Description("Damage Taken +% Final")]
        DamageTakenPosPctFinal = 6536,
        [Description("Display One Harbinger Allowed")]
        DisplayOneHarbingerAllowed = 6537,
        [Description("Action Speed +% Minimum Value")]
        ActionSpeedPosPctMinimumValue = 6538,
        [Description("Shavronne Ball Lightning Held Projectile Damage +% Final")]
        ShavronneBallLightningHeldProjectileDamagePosPctFinal = 6539,
        [Description("Grant Rampage Kill To Parent On Hitting Unique Enemy %")]
        GrantRampageKillToParentOnHittingUniqueEnemyPct = 6540,
        [Description("Minion Grants Rampage Kill To Parent On Hitting Unique Enemy %")]
        MinionGrantsRampageKillToParentOnHittingUniqueEnemyPct = 6541,
        [Description("Monster Inherent Experience Granted +% Final Because Deleted On Death")]
        MonsterInherentExperienceGrantedPosPctFinalBecauseDeletedOnDeath = 6542,
        [Description("Monster Inherent Experience Granted +% Final If Deleted On Death")]
        MonsterInherentExperienceGrantedPosPctFinalIfDeletedOnDeath = 6543,
        [Description("Harbinger Minion Extra Monster Chance %")]
        HarbingerMinionExtraMonsterChancePct = 6544,
        [Description("Harbinger Minion Max Extra Monsters Count")]
        HarbingerMinionMaxExtraMonstersCount = 6545,
        [Description("Harbinger Minion Damage Taken +% Final")]
        HarbingerMinionDamageTakenPosPctFinal = 6546,
        [Description("Skill Global Actor Definition Index Override")]
        SkillGlobalActorDefinitionIndexOverride = 6547,
        [Description("Virtual Total Main Hand Chance To Bleed On Hit %")]
        VirtualTotalMainHandChanceToBleedOnHitPct = 6548,
        [Description("Virtual Total Off Hand Chance To Bleed On Hit %")]
        VirtualTotalOffHandChanceToBleedOnHitPct = 6549,
        [Description("Virtual Total Main Hand Chance To Ignite On Hit %")]
        VirtualTotalMainHandChanceToIgniteOnHitPct = 6550,
        [Description("Virtual Total Off Hand Chance To Ignite On Hit %")]
        VirtualTotalOffHandChanceToIgniteOnHitPct = 6551,
        [Description("Virtual Total Spell Chance To Ignite On Hit %")]
        VirtualTotalSpellChanceToIgniteOnHitPct = 6552,
        [Description("Virtual Total Secondary Chance To Ignite On Hit %")]
        VirtualTotalSecondaryChanceToIgniteOnHitPct = 6553,
        [Description("Virtual Total Main Hand Chance To Poison On Hit %")]
        VirtualTotalMainHandChanceToPoisonOnHitPct = 6554,
        [Description("Virtual Total Off Hand Chance To Poison On Hit %")]
        VirtualTotalOffHandChanceToPoisonOnHitPct = 6555,
        [Description("Virtual Total Spell Chance To Poison On Hit %")]
        VirtualTotalSpellChanceToPoisonOnHitPct = 6556,
        [Description("Virtual Total Secondary Chance To Poison On Hit %")]
        VirtualTotalSecondaryChanceToPoisonOnHitPct = 6557,
        [Description("Total Number Of Map Mods")]
        TotalNumberOfMapMods = 6558,
        [Description("Harbinger Currency Shard Stack Size +%")]
        HarbingerCurrencyShardStackSizePosPct = 6559,
        [Description("Map Force Monster Pack Index")]
        MapForceMonsterPackIndex = 6560,
        [Description("Volatile Dead Base Number Of Corpses To Consume")]
        VolatileDeadBaseNumberOfCorpsesToConsume = 6561,
        [Description("Chance To Cast When Your Trap Is Triggered %")]
        ChanceToCastWhenYourTrapIsTriggeredPct = 6562,
        [Description("Local Display Gain Power Charge On Spending Mana")]
        LocalDisplayGainPowerChargeOnSpendingMana = 6563,
        [Description("Is Untethered Pet")]
        IsUntetheredPet = 6564,
        [Description("Walk Emerge Distance")]
        WalkEmergeDistance = 6565,
        [Description("Walk Emerge Extra Distance")]
        WalkEmergeExtraDistance = 6566,
        [Description("Walk Emerge Height Offset")]
        WalkEmergeHeightOffset = 6567,
        [Description("Walk Emerge Tilt")]
        WalkEmergeTilt = 6568,
        [Description("Combined Armour And Evasion Rating +%")]
        CombinedArmourAndEvasionRatingPosPct = 6569,
        [Description("Herald Of Ash Burning % Overkill Damage Per Minute")]
        HeraldOfAshBurningPctOverkillDamagePerMinute = 6570,
        [Description("Local Display Grants Skill Scorching Ray Level")]
        LocalDisplayGrantsSkillScorchingRayLevel = 6571,
        [Description("Support Minion Maximum Life +% Final")]
        SupportMinionMaximumLifePosPctFinal = 6572,
        [Description("Max Life +% Final For Minion From Support")]
        MaxLifePosPctFinalForMinionFromSupport = 6573,
        [Description("Lightning Tendrils Channelled Larger Pulse Radius +")]
        LightningTendrilsChannelledLargerPulseRadiusPos = 6574,
        [Description("Lightning Tendrils Channelled Larger Pulse Damage +% Final")]
        LightningTendrilsChannelledLargerPulseDamagePosPctFinal = 6575,
        [Description("Discorectangle Slam Damage With Endurance Charge +% Final")]
        DiscorectangleSlamDamageWithEnduranceChargePosPctFinal = 6576,
        [Description("Discorectangle Slam Radius With Endurance Charge +")]
        DiscorectangleSlamRadiusWithEnduranceChargePos = 6577,
        [Description("Unearth Base Corpse Level")]
        UnearthBaseCorpseLevel = 6578,
        [Description("Map Tencent Event Shards Drop Rate")]
        MapTencentEventShardsDropRate = 6579,
        [Description("Is In Caustic Cloud")]
        IsInCausticCloud = 6580,
        [Description("Chaos Damage Taken Over Time +% While In Caustic Cloud")]
        ChaosDamageTakenOverTimePosPctWhileInCausticCloud = 6581,
        [Description("Local Can Socket Gems Ignoring Colour")]
        LocalCanSocketGemsIgnoringColour = 6582,
        [Description("Local No Attribute Requirements")]
        LocalNoAttributeRequirements = 6583,
        [Description("Local Socketed Gems In Red Sockets Get Level +")]
        LocalSocketedGemsInRedSocketsGetLevelPos = 6584,
        [Description("Local Socketed Gems In Green Sockets Get Quality %")]
        LocalSocketedGemsInGreenSocketsGetQualityPct = 6585,
        [Description("Local Socketed Gems In Blue Sockets Experience Gained +%")]
        LocalSocketedGemsInBlueSocketsExperienceGainedPosPct = 6586,
        [Description("Local Socketed Gems In White Sockets Get Nothing")]
        LocalSocketedGemsInWhiteSocketsGetNothing = 6587,
        [Description("Corpse Erruption Base Maximum Number Of Geyers")]
        CorpseErruptionBaseMaximumNumberOfGeyers = 6588,
        [Description("Thaumaturgy Rotation Active")]
        ThaumaturgyRotationActive = 6589,
        [Description("Thaumaturgy Rotation Buff Exists")]
        ThaumaturgyRotationBuffExists = 6590,
        [Description("Trigger On Delayed Blast")]
        TriggerOnDelayedBlast = 6591,
        [Description("Trigger On Delayed Blast %")]
        TriggerOnDelayedBlastPct = 6592,
        [Description("Delayed Blast Has Trigger")]
        DelayedBlastHasTrigger = 6593,
        [Description("Spirit Charge Tier")]
        SpiritChargeTier = 6594,
        [Description("Current Spirit Charges")]
        CurrentSpiritCharges = 6595,
        [Description("Maximum Spirit Charges")]
        MaximumSpiritCharges = 6596,
        [Description("Recover % Of Maximum Life On Gaining A Spirit Charge")]
        RecoverPctOfMaximumLifeOnGainingASpiritCharge = 6597,
        [Description("Corpse Skill Has Triggers")]
        CorpseSkillHasTriggers = 6598,
        [Description("Cast On Corpse Consume")]
        CastOnCorpseConsume = 6599,
        [Description("Cast On Corpse Consume %")]
        CastOnCorpseConsumePct = 6600,
        [Description("Cast On Damage Taken Also Tracks Dot")]
        CastOnDamageTakenAlsoTracksDot = 6601,
        [Description("Thrown Shield Projectile Max Distance")]
        ThrownShieldProjectileMaxDistance = 6602,
        [Description("Thrown Shield Projectile Fire Random Directions")]
        ThrownShieldProjectileFireRandomDirections = 6603,
        [Description("Thrown Shield Secondary Projectile Damage +% Final")]
        ThrownShieldSecondaryProjectileDamagePosPctFinal = 6604,
        [Description("Cast On Corpse Consume Id")]
        CastOnCorpseConsumeId = 6605,
        [Description("Gain Random Charge Per Second While Stationary")]
        GainRandomChargePerSecondWhileStationary = 6606,
        [Description("Lose All Charges On Starting Movement")]
        LoseAllChargesOnStartingMovement = 6607,
        [Description("Mana Regeneration Rate Per Minute Per Power Charge")]
        ManaRegenerationRatePerMinutePerPowerCharge = 6608,
        [Description("Spectre Maximum Life +")]
        SpectreMaximumLifePos = 6609,
        [Description("Accuracy Rating While At Maximum Frenzy Charges")]
        AccuracyRatingWhileAtMaximumFrenzyCharges = 6610,
        [Description("Display Map Inhabited By Solaris Fanatics")]
        DisplayMapInhabitedBySolarisFanatics = 6611,
        [Description("Display Map Inhabited By Lunaris Fanatics")]
        DisplayMapInhabitedByLunarisFanatics = 6612,
        [Description("Map Elder Boss Variation")]
        MapElderBossVariation = 6613,
        [Description("Ignite Triggered Ground Fire Base Damage Per Minute")]
        IgniteTriggeredGroundFireBaseDamagePerMinute = 6614,
        [Description("Virtual Shock Effect +%")]
        VirtualShockEffectPosPct = 6615,
        [Description("Virtual Chill Effect +%")]
        VirtualChillEffectPosPct = 6616,
        [Description("Local Unique Jewel Non Keystone Passive In Radius Effect +% Final")]
        LocalUniqueJewelNonKeystonePassiveInRadiusEffectPosPctFinal = 6617,
        [Description("Local Unique Jewel Notable Passive In Radius Does Nothing")]
        LocalUniqueJewelNotablePassiveInRadiusDoesNothing = 6618,
        [Description("Passive Skill Does Nothing")]
        PassiveSkillDoesNothing = 6619,
        [Description("Local Unique Hungry Loop Number Of Gems To Consume")]
        LocalUniqueHungryLoopNumberOfGemsToConsume = 6620,
        [Description("Local Unique Hungry Loop Has Consumed Gem")]
        LocalUniqueHungryLoopHasConsumedGem = 6621,
        [Description("Local Display Socketed Gems Supported By Level X Greater Multiple Projectiles")]
        LocalDisplaySocketedGemsSupportedByLevelXGreaterMultipleProjectiles = 6622,
        [Description("Local Display Socketed Gems Supported By Level X Increased Critical Strikes")]
        LocalDisplaySocketedGemsSupportedByLevelXIncreasedCriticalStrikes = 6623,
        [Description("Local Display Socketed Gems Supported By Level X Item Quantity")]
        LocalDisplaySocketedGemsSupportedByLevelXItemQuantity = 6624,
        [Description("Local Display Socketed Gems Supported By Level X Item Rarity")]
        LocalDisplaySocketedGemsSupportedByLevelXItemRarity = 6625,
        [Description("Local Display Socketed Gems Supported By Level X Increased Duration")]
        LocalDisplaySocketedGemsSupportedByLevelXIncreasedDuration = 6626,
        [Description("Local Display Socketed Gems Supported By Level X Chance To Ignite")]
        LocalDisplaySocketedGemsSupportedByLevelXChanceToIgnite = 6627,
        [Description("Local Display Socketed Gems Supported By Level X Bloodlust")]
        LocalDisplaySocketedGemsSupportedByLevelXBloodlust = 6628,
        [Description("Local Display Socketed Gems Supported By Level X Life Gain On Hit")]
        LocalDisplaySocketedGemsSupportedByLevelXLifeGainOnHit = 6629,
        [Description("Local Display Socketed Gems Supported By Level X Culling Strike")]
        LocalDisplaySocketedGemsSupportedByLevelXCullingStrike = 6630,
        [Description("Local Display Socketed Gems Supported By Level X Point Blank")]
        LocalDisplaySocketedGemsSupportedByLevelXPointBlank = 6631,
        [Description("Local Display Socketed Gems Supported By Level X Iron Grip")]
        LocalDisplaySocketedGemsSupportedByLevelXIronGrip = 6632,
        [Description("Local Display Socketed Gems Supported By Level X Melee Damage On Full Life")]
        LocalDisplaySocketedGemsSupportedByLevelXMeleeDamageOnFullLife = 6633,
        [Description("Local Display Socketed Gems Supported By Level X Ranged Attack Totem")]
        LocalDisplaySocketedGemsSupportedByLevelXRangedAttackTotem = 6634,
        [Description("Local Display Socketed Gems Supported By Level X Fire Penetration")]
        LocalDisplaySocketedGemsSupportedByLevelXFirePenetration = 6635,
        [Description("Local Display Socketed Gems Supported By Level X Lightning Penetration")]
        LocalDisplaySocketedGemsSupportedByLevelXLightningPenetration = 6636,
        [Description("Local Display Socketed Gems Supported By Level X Chain")]
        LocalDisplaySocketedGemsSupportedByLevelXChain = 6637,
        [Description("Local Display Socketed Gems Supported By Level X Multicast")]
        LocalDisplaySocketedGemsSupportedByLevelXMulticast = 6638,
        [Description("Local Display Socketed Gems Supported By Level X Power Charge On Crit")]
        LocalDisplaySocketedGemsSupportedByLevelXPowerChargeOnCrit = 6639,
        [Description("Local Display Socketed Gems Supported By Level X Increased Burning Damage")]
        LocalDisplaySocketedGemsSupportedByLevelXIncreasedBurningDamage = 6640,
        [Description("Local Display Socketed Gems Supported By Level X Summon Elemental Resistance")]
        LocalDisplaySocketedGemsSupportedByLevelXSummonElementalResistance = 6641,
        [Description("Local Display Socketed Gems Supported By Level X Curse On Hit")]
        LocalDisplaySocketedGemsSupportedByLevelXCurseOnHit = 6642,
        [Description("Local Display Socketed Gems Supported By Level X Cast On Kill")]
        LocalDisplaySocketedGemsSupportedByLevelXCastOnKill = 6643,
        [Description("Local Display Socketed Gems Supported By Level X Multi Trap")]
        LocalDisplaySocketedGemsSupportedByLevelXMultiTrap = 6644,
        [Description("Local Display Socketed Gems Supported By Level X Empower")]
        LocalDisplaySocketedGemsSupportedByLevelXEmpower = 6645,
        [Description("Local Display Socketed Gems Supported By Level X Slower Projectiles")]
        LocalDisplaySocketedGemsSupportedByLevelXSlowerProjectiles = 6646,
        [Description("Local Display Socketed Gems Supported By Level X Reduced Duration")]
        LocalDisplaySocketedGemsSupportedByLevelXReducedDuration = 6647,
        [Description("Local Display Socketed Gems Supported By Level X Cast On Damage Taken")]
        LocalDisplaySocketedGemsSupportedByLevelXCastOnDamageTaken = 6648,
        [Description("Local Display Socketed Gems Supported By Level X Enhance")]
        LocalDisplaySocketedGemsSupportedByLevelXEnhance = 6649,
        [Description("Local Display Socketed Gems Supported By Level X Physical Projectile Attack Damage")]
        LocalDisplaySocketedGemsSupportedByLevelXPhysicalProjectileAttackDamage = 6650,
        [Description("Local Display Socketed Gems Supported By Level X Enlighten")]
        LocalDisplaySocketedGemsSupportedByLevelXEnlighten = 6651,
        [Description("Local Display Socketed Gems Supported By Level X Physical To Lightning")]
        LocalDisplaySocketedGemsSupportedByLevelXPhysicalToLightning = 6652,
        [Description("Local Display Socketed Gems Supported By Level X Trap And Mine Damage")]
        LocalDisplaySocketedGemsSupportedByLevelXTrapAndMineDamage = 6653,
        [Description("Local Display Socketed Gems Supported By Level X Poison")]
        LocalDisplaySocketedGemsSupportedByLevelXPoison = 6654,
        [Description("Local Display Socketed Gems Supported By Level X Void Manipulation")]
        LocalDisplaySocketedGemsSupportedByLevelXVoidManipulation = 6655,
        [Description("Local Display Socketed Gems Supported By Level X Rapid Decay")]
        LocalDisplaySocketedGemsSupportedByLevelXRapidDecay = 6656,
        [Description("Local Display Socketed Gems Supported By Level X Cluster Trap")]
        LocalDisplaySocketedGemsSupportedByLevelXClusterTrap = 6657,
        [Description("Local Display Socketed Gems Supported By Level X Elemental Focus")]
        LocalDisplaySocketedGemsSupportedByLevelXElementalFocus = 6658,
        [Description("Local Display Socketed Gems Supported By Level X Minefield")]
        LocalDisplaySocketedGemsSupportedByLevelXMinefield = 6659,
        [Description("Local Display Socketed Gems Supported By Level X Trap Cooldown")]
        LocalDisplaySocketedGemsSupportedByLevelXTrapCooldown = 6660,
        [Description("Local Display Socketed Gems Supported By Level X Cast While Channelling")]
        LocalDisplaySocketedGemsSupportedByLevelXCastWhileChannelling = 6661,
        [Description("Local Display Socketed Gems Supported By Level X Ignite Proliferation")]
        LocalDisplaySocketedGemsSupportedByLevelXIgniteProliferation = 6662,
        [Description("Local Display Socketed Gems Supported By Level X Chance To Bleed")]
        LocalDisplaySocketedGemsSupportedByLevelXChanceToBleed = 6663,
        [Description("Local Display Socketed Gems Supported By Level X Deadly Ailments")]
        LocalDisplaySocketedGemsSupportedByLevelXDeadlyAilments = 6664,
        [Description("Local Display Socketed Gems Supported By Level X Decay")]
        LocalDisplaySocketedGemsSupportedByLevelXDecay = 6665,
        [Description("Local Display Socketed Gems Supported By Level X Efficacy")]
        LocalDisplaySocketedGemsSupportedByLevelXEfficacy = 6666,
        [Description("Local Display Socketed Gems Supported By Level X Maim")]
        LocalDisplaySocketedGemsSupportedByLevelXMaim = 6667,
        [Description("Local Display Socketed Gems Supported By Level X Immolate")]
        LocalDisplaySocketedGemsSupportedByLevelXImmolate = 6668,
        [Description("Local Display Socketed Gems Supported By Level X Unbound Ailments")]
        LocalDisplaySocketedGemsSupportedByLevelXUnboundAilments = 6669,
        [Description("Local Display Socketed Gems Supported By Level X Brutality")]
        LocalDisplaySocketedGemsSupportedByLevelXBrutality = 6670,
        [Description("Local Display Socketed Gems Supported By Level X Ruthless")]
        LocalDisplaySocketedGemsSupportedByLevelXRuthless = 6671,
        [Description("Local Display Socketed Gems Supported By Level X Onslaught")]
        LocalDisplaySocketedGemsSupportedByLevelXOnslaught = 6672,
        [Description("Local Display Socketed Gems Supported By Level X Arcane Surge")]
        LocalDisplaySocketedGemsSupportedByLevelXArcaneSurge = 6673,
        [Description("Local Display Socketed Gems Supported By Level X Reduced Block Chance")]
        LocalDisplaySocketedGemsSupportedByLevelXReducedBlockChance = 6674,
        [Description("Spectral Throw Gain Vaal Soul For Vaal Spectral Throw On Hit %")]
        SpectralThrowGainVaalSoulForVaalSpectralThrowOnHitPct = 6675,
        [Description("Local Unique Jewel Spectral Throw Gain Vaal Soul For Vaal St On Hit % With 40 Dex In Radius")]
        LocalUniqueJewelSpectralThrowGainVaalSoulForVaalStOnHitPctWith40DexInRadius = 6676,
        [Description("Trigger Socketed Spell On Attack %")]
        TriggerSocketedSpellOnAttackPct = 6677,
        [Description("Main Hand Trigger Socketed Spell On Attack %")]
        MainHandTriggerSocketedSpellOnAttackPct = 6678,
        [Description("Off Hand Trigger Socketed Spell On Attack %")]
        OffHandTriggerSocketedSpellOnAttackPct = 6679,
        [Description("Local Attack Minimum Added Physical Damage Per 3 Levels")]
        LocalAttackMinimumAddedPhysicalDamagePer3Levels = 6680,
        [Description("Local Attack Maximum Added Physical Damage Per 3 Levels")]
        LocalAttackMaximumAddedPhysicalDamagePer3Levels = 6681,
        [Description("Main Hand Attack Minimum Added Physical Damage Per 3 Levels")]
        MainHandAttackMinimumAddedPhysicalDamagePer3Levels = 6682,
        [Description("Main Hand Attack Maximum Added Physical Damage Per 3 Levels")]
        MainHandAttackMaximumAddedPhysicalDamagePer3Levels = 6683,
        [Description("Off Hand Attack Minimum Added Physical Damage Per 3 Levels")]
        OffHandAttackMinimumAddedPhysicalDamagePer3Levels = 6684,
        [Description("Off Hand Attack Maximum Added Physical Damage Per 3 Levels")]
        OffHandAttackMaximumAddedPhysicalDamagePer3Levels = 6685,
        [Description("Local Poison Duration +% During Flask Effect")]
        LocalPoisonDurationPosPctDuringFlaskEffect = 6686,
        [Description("Local Grant Perfect Agony During Flask Effect")]
        LocalGrantPerfectAgonyDuringFlaskEffect = 6687,
        [Description("Local Chance To Poison On Hit % During Flask Effect")]
        LocalChanceToPoisonOnHitPctDuringFlaskEffect = 6688,
        [Description("Local No Critical Strike Multiplier During Flask Effect")]
        LocalNoCriticalStrikeMultiplierDuringFlaskEffect = 6689,
        [Description("Local Socketed Skill Gem Level +1 Per X Player Levels")]
        LocalSocketedSkillGemLevelPos1PerXPlayerLevels = 6690,
        [Description("Map Spawn Abysses")]
        MapSpawnAbysses = 6691,
        [Description("Map Num Extra Abysses")]
        MapNumExtraAbysses = 6692,
        [Description("Lightning Tendrils Channelled Larger Pulse Interval")]
        LightningTendrilsChannelledLargerPulseInterval = 6693,
        [Description("Local Has X Abyss Sockets")]
        LocalHasXAbyssSockets = 6694,
        [Description("Melee Skills Area Of Effect +%")]
        MeleeSkillsAreaOfEffectPosPct = 6695,
        [Description("Skill Is Melee Skill")]
        SkillIsMeleeSkill = 6696,
        [Description("Local Unique Jewel Melee Skills Area Of Effect +% With Passive Tree Connected To Marauder Start")]
        LocalUniqueJewelMeleeSkillsAreaOfEffectPosPctWithPassiveTreeConnectedToMarauderStart = 6697,
        [Description("Local Unique Jewel Life Leech From Attack Damage Permyriad With Passive Tree Connected To Duelist Start")]
        LocalUniqueJewelLifeLeechFromAttackDamagePermyriadWithPassiveTreeConnectedToDuelistStart = 6698,
        [Description("Local Unique Jewel Movement Speed +% With Passive Tree Connected To Ranger Start")]
        LocalUniqueJewelMovementSpeedPosPctWithPassiveTreeConnectedToRangerStart = 6699,
        [Description("Local Unique Jewel Additional Critical Strike Chance Permyriad With Passive Tree Connected To Shadow Start")]
        LocalUniqueJewelAdditionalCriticalStrikeChancePermyriadWithPassiveTreeConnectedToShadowStart = 6700,
        [Description("Local Unique Jewel Mana Regeneration Rate Per Minute % With Passive Tree Connected To Witch Start")]
        LocalUniqueJewelManaRegenerationRatePerMinutePctWithPassiveTreeConnectedToWitchStart = 6701,
        [Description("Local Unique Jewel Elemental Penetration % With Passive Tree Connected To Templar Start")]
        LocalUniqueJewelElementalPenetrationPctWithPassiveTreeConnectedToTemplarStart = 6702,
        [Description("Local Unique Jewel Additional All Attributes With Passive Tree Connected To Scion Start")]
        LocalUniqueJewelAdditionalAllAttributesWithPassiveTreeConnectedToScionStart = 6703,
        [Description("Local Unique Jewel Glacial Cascade Physical Damage % To Convert To Cold With 40 Int In Radius")]
        LocalUniqueJewelGlacialCascadePhysicalDamagePctToConvertToColdWith40IntInRadius = 6704,
        [Description("Attack Critical Strike Chance +% Per 200 Accuracy Rating")]
        AttackCriticalStrikeChancePosPctPer200AccuracyRating = 6705,
        [Description("Attack Minimum Added Physical Damage With Wands")]
        AttackMinimumAddedPhysicalDamageWithWands = 6706,
        [Description("Attack Maximum Added Physical Damage With Wands")]
        AttackMaximumAddedPhysicalDamageWithWands = 6707,
        [Description("Attack Minimum Added Physical Damage With Daggers")]
        AttackMinimumAddedPhysicalDamageWithDaggers = 6708,
        [Description("Attack Maximum Added Physical Damage With Daggers")]
        AttackMaximumAddedPhysicalDamageWithDaggers = 6709,
        [Description("Attack Minimum Added Physical Damage With Claws")]
        AttackMinimumAddedPhysicalDamageWithClaws = 6710,
        [Description("Attack Maximum Added Physical Damage With Claws")]
        AttackMaximumAddedPhysicalDamageWithClaws = 6711,
        [Description("Attack Minimum Added Physical Damage With Swords")]
        AttackMinimumAddedPhysicalDamageWithSwords = 6712,
        [Description("Attack Maximum Added Physical Damage With Swords")]
        AttackMaximumAddedPhysicalDamageWithSwords = 6713,
        [Description("Attack Minimum Added Physical Damage With Axes")]
        AttackMinimumAddedPhysicalDamageWithAxes = 6714,
        [Description("Attack Maximum Added Physical Damage With Axes")]
        AttackMaximumAddedPhysicalDamageWithAxes = 6715,
        [Description("Attack Minimum Added Physical Damage With Maces")]
        AttackMinimumAddedPhysicalDamageWithMaces = 6716,
        [Description("Attack Maximum Added Physical Damage With Maces")]
        AttackMaximumAddedPhysicalDamageWithMaces = 6717,
        [Description("Attack Minimum Added Physical Damage With Staves")]
        AttackMinimumAddedPhysicalDamageWithStaves = 6718,
        [Description("Attack Maximum Added Physical Damage With Staves")]
        AttackMaximumAddedPhysicalDamageWithStaves = 6719,
        [Description("Attack Minimum Added Lightning Damage With Daggers")]
        AttackMinimumAddedLightningDamageWithDaggers = 6720,
        [Description("Attack Maximum Added Lightning Damage With Daggers")]
        AttackMaximumAddedLightningDamageWithDaggers = 6721,
        [Description("Attack Minimum Added Lightning Damage With Claws")]
        AttackMinimumAddedLightningDamageWithClaws = 6722,
        [Description("Attack Maximum Added Lightning Damage With Claws")]
        AttackMaximumAddedLightningDamageWithClaws = 6723,
        [Description("Attack Minimum Added Lightning Damage With Bows")]
        AttackMinimumAddedLightningDamageWithBows = 6724,
        [Description("Attack Maximum Added Lightning Damage With Bows")]
        AttackMaximumAddedLightningDamageWithBows = 6725,
        [Description("Attack Minimum Added Lightning Damage With Swords")]
        AttackMinimumAddedLightningDamageWithSwords = 6726,
        [Description("Attack Maximum Added Lightning Damage With Swords")]
        AttackMaximumAddedLightningDamageWithSwords = 6727,
        [Description("Attack Minimum Added Lightning Damage With Axes")]
        AttackMinimumAddedLightningDamageWithAxes = 6728,
        [Description("Attack Maximum Added Lightning Damage With Axes")]
        AttackMaximumAddedLightningDamageWithAxes = 6729,
        [Description("Attack Minimum Added Lightning Damage With Maces")]
        AttackMinimumAddedLightningDamageWithMaces = 6730,
        [Description("Attack Maximum Added Lightning Damage With Maces")]
        AttackMaximumAddedLightningDamageWithMaces = 6731,
        [Description("Attack Minimum Added Lightning Damage With Staves")]
        AttackMinimumAddedLightningDamageWithStaves = 6732,
        [Description("Attack Maximum Added Lightning Damage With Staves")]
        AttackMaximumAddedLightningDamageWithStaves = 6733,
        [Description("Attack Minimum Added Fire Damage With Daggers")]
        AttackMinimumAddedFireDamageWithDaggers = 6734,
        [Description("Attack Maximum Added Fire Damage With Daggers")]
        AttackMaximumAddedFireDamageWithDaggers = 6735,
        [Description("Attack Minimum Added Fire Damage With Claws")]
        AttackMinimumAddedFireDamageWithClaws = 6736,
        [Description("Attack Maximum Added Fire Damage With Claws")]
        AttackMaximumAddedFireDamageWithClaws = 6737,
        [Description("Attack Minimum Added Fire Damage With Swords")]
        AttackMinimumAddedFireDamageWithSwords = 6738,
        [Description("Attack Maximum Added Fire Damage With Swords")]
        AttackMaximumAddedFireDamageWithSwords = 6739,
        [Description("Attack Minimum Added Fire Damage With Axes")]
        AttackMinimumAddedFireDamageWithAxes = 6740,
        [Description("Attack Maximum Added Fire Damage With Axes")]
        AttackMaximumAddedFireDamageWithAxes = 6741,
        [Description("Attack Minimum Added Fire Damage With Maces")]
        AttackMinimumAddedFireDamageWithMaces = 6742,
        [Description("Attack Maximum Added Fire Damage With Maces")]
        AttackMaximumAddedFireDamageWithMaces = 6743,
        [Description("Attack Minimum Added Fire Damage With Staves")]
        AttackMinimumAddedFireDamageWithStaves = 6744,
        [Description("Attack Maximum Added Fire Damage With Staves")]
        AttackMaximumAddedFireDamageWithStaves = 6745,
        [Description("Attack Minimum Added Cold Damage With Daggers")]
        AttackMinimumAddedColdDamageWithDaggers = 6746,
        [Description("Attack Maximum Added Cold Damage With Daggers")]
        AttackMaximumAddedColdDamageWithDaggers = 6747,
        [Description("Attack Minimum Added Cold Damage With Claws")]
        AttackMinimumAddedColdDamageWithClaws = 6748,
        [Description("Attack Maximum Added Cold Damage With Claws")]
        AttackMaximumAddedColdDamageWithClaws = 6749,
        [Description("Attack Minimum Added Cold Damage With Bows")]
        AttackMinimumAddedColdDamageWithBows = 6750,
        [Description("Attack Maximum Added Cold Damage With Bows")]
        AttackMaximumAddedColdDamageWithBows = 6751,
        [Description("Attack Minimum Added Cold Damage With Swords")]
        AttackMinimumAddedColdDamageWithSwords = 6752,
        [Description("Attack Maximum Added Cold Damage With Swords")]
        AttackMaximumAddedColdDamageWithSwords = 6753,
        [Description("Attack Minimum Added Cold Damage With Axes")]
        AttackMinimumAddedColdDamageWithAxes = 6754,
        [Description("Attack Maximum Added Cold Damage With Axes")]
        AttackMaximumAddedColdDamageWithAxes = 6755,
        [Description("Attack Minimum Added Cold Damage With Maces")]
        AttackMinimumAddedColdDamageWithMaces = 6756,
        [Description("Attack Maximum Added Cold Damage With Maces")]
        AttackMaximumAddedColdDamageWithMaces = 6757,
        [Description("Attack Minimum Added Cold Damage With Staves")]
        AttackMinimumAddedColdDamageWithStaves = 6758,
        [Description("Attack Maximum Added Cold Damage With Staves")]
        AttackMaximumAddedColdDamageWithStaves = 6759,
        [Description("Attack Minimum Added Physical Damage While Unarmed")]
        AttackMinimumAddedPhysicalDamageWhileUnarmed = 6760,
        [Description("Attack Maximum Added Physical Damage While Unarmed")]
        AttackMaximumAddedPhysicalDamageWhileUnarmed = 6761,
        [Description("Attack Minimum Added Physical Damage While Holding A Shield")]
        AttackMinimumAddedPhysicalDamageWhileHoldingAShield = 6762,
        [Description("Attack Maximum Added Physical Damage While Holding A Shield")]
        AttackMaximumAddedPhysicalDamageWhileHoldingAShield = 6763,
        [Description("Spell Minimum Added Fire Damage While Dual Wielding")]
        SpellMinimumAddedFireDamageWhileDualWielding = 6764,
        [Description("Spell Maximum Added Fire Damage While Dual Wielding")]
        SpellMaximumAddedFireDamageWhileDualWielding = 6765,
        [Description("Spell Minimum Added Cold Damage While Dual Wielding")]
        SpellMinimumAddedColdDamageWhileDualWielding = 6766,
        [Description("Spell Maximum Added Cold Damage While Dual Wielding")]
        SpellMaximumAddedColdDamageWhileDualWielding = 6767,
        [Description("Spell Minimum Added Lightning Damage While Dual Wielding")]
        SpellMinimumAddedLightningDamageWhileDualWielding = 6768,
        [Description("Spell Maximum Added Lightning Damage While Dual Wielding")]
        SpellMaximumAddedLightningDamageWhileDualWielding = 6769,
        [Description("Spell Minimum Added Physical Damage While Dual Wielding")]
        SpellMinimumAddedPhysicalDamageWhileDualWielding = 6770,
        [Description("Spell Maximum Added Physical Damage While Dual Wielding")]
        SpellMaximumAddedPhysicalDamageWhileDualWielding = 6771,
        [Description("Spell Minimum Added Chaos Damage While Dual Wielding")]
        SpellMinimumAddedChaosDamageWhileDualWielding = 6772,
        [Description("Spell Maximum Added Chaos Damage While Dual Wielding")]
        SpellMaximumAddedChaosDamageWhileDualWielding = 6773,
        [Description("Spell Minimum Added Fire Damage While Wielding Two Handed Weapon")]
        SpellMinimumAddedFireDamageWhileWieldingTwoHandedWeapon = 6774,
        [Description("Spell Maximum Added Fire Damage While Wielding Two Handed Weapon")]
        SpellMaximumAddedFireDamageWhileWieldingTwoHandedWeapon = 6775,
        [Description("Spell Minimum Added Cold Damage While Wielding Two Handed Weapon")]
        SpellMinimumAddedColdDamageWhileWieldingTwoHandedWeapon = 6776,
        [Description("Spell Maximum Added Cold Damage While Wielding Two Handed Weapon")]
        SpellMaximumAddedColdDamageWhileWieldingTwoHandedWeapon = 6777,
        [Description("Spell Minimum Added Lightning Damage While Wielding Two Handed Weapon")]
        SpellMinimumAddedLightningDamageWhileWieldingTwoHandedWeapon = 6778,
        [Description("Spell Maximum Added Lightning Damage While Wielding Two Handed Weapon")]
        SpellMaximumAddedLightningDamageWhileWieldingTwoHandedWeapon = 6779,
        [Description("Spell Minimum Added Physical Damage While Wielding Two Handed Weapon")]
        SpellMinimumAddedPhysicalDamageWhileWieldingTwoHandedWeapon = 6780,
        [Description("Spell Maximum Added Physical Damage While Wielding Two Handed Weapon")]
        SpellMaximumAddedPhysicalDamageWhileWieldingTwoHandedWeapon = 6781,
        [Description("Spell Minimum Added Chaos Damage While Wielding Two Handed Weapon")]
        SpellMinimumAddedChaosDamageWhileWieldingTwoHandedWeapon = 6782,
        [Description("Spell Maximum Added Chaos Damage While Wielding Two Handed Weapon")]
        SpellMaximumAddedChaosDamageWhileWieldingTwoHandedWeapon = 6783,
        [Description("Spell Minimum Added Fire Damage While Holding A Shield")]
        SpellMinimumAddedFireDamageWhileHoldingAShield = 6784,
        [Description("Spell Maximum Added Fire Damage While Holding A Shield")]
        SpellMaximumAddedFireDamageWhileHoldingAShield = 6785,
        [Description("Spell Minimum Added Cold Damage While Holding A Shield")]
        SpellMinimumAddedColdDamageWhileHoldingAShield = 6786,
        [Description("Spell Maximum Added Cold Damage While Holding A Shield")]
        SpellMaximumAddedColdDamageWhileHoldingAShield = 6787,
        [Description("Spell Minimum Added Lightning Damage While Holding A Shield")]
        SpellMinimumAddedLightningDamageWhileHoldingAShield = 6788,
        [Description("Spell Maximum Added Lightning Damage While Holding A Shield")]
        SpellMaximumAddedLightningDamageWhileHoldingAShield = 6789,
        [Description("Spell Minimum Added Physical Damage While Holding A Shield")]
        SpellMinimumAddedPhysicalDamageWhileHoldingAShield = 6790,
        [Description("Spell Maximum Added Physical Damage While Holding A Shield")]
        SpellMaximumAddedPhysicalDamageWhileHoldingAShield = 6791,
        [Description("Spell Minimum Added Chaos Damage While Holding A Shield")]
        SpellMinimumAddedChaosDamageWhileHoldingAShield = 6792,
        [Description("Spell Maximum Added Chaos Damage While Holding A Shield")]
        SpellMaximumAddedChaosDamageWhileHoldingAShield = 6793,
        [Description("Damage Over Time +% While Dual Wielding")]
        DamageOverTimePosPctWhileDualWielding = 6794,
        [Description("Damage Over Time +% While Wielding Two Handed Weapon")]
        DamageOverTimePosPctWhileWieldingTwoHandedWeapon = 6795,
        [Description("Damage Over Time +% While Holding A Shield")]
        DamageOverTimePosPctWhileHoldingAShield = 6796,
        [Description("Minion Global Minimum Added Fire Damage")]
        MinionGlobalMinimumAddedFireDamage = 6797,
        [Description("Minion Global Maximum Added Fire Damage")]
        MinionGlobalMaximumAddedFireDamage = 6798,
        [Description("Minion Global Minimum Added Cold Damage")]
        MinionGlobalMinimumAddedColdDamage = 6799,
        [Description("Minion Global Maximum Added Cold Damage")]
        MinionGlobalMaximumAddedColdDamage = 6800,
        [Description("Minion Global Minimum Added Lightning Damage")]
        MinionGlobalMinimumAddedLightningDamage = 6801,
        [Description("Minion Global Maximum Added Lightning Damage")]
        MinionGlobalMaximumAddedLightningDamage = 6802,
        [Description("Minion Global Minimum Added Physical Damage")]
        MinionGlobalMinimumAddedPhysicalDamage = 6803,
        [Description("Minion Global Maximum Added Physical Damage")]
        MinionGlobalMaximumAddedPhysicalDamage = 6804,
        [Description("Minion Global Minimum Added Chaos Damage")]
        MinionGlobalMinimumAddedChaosDamage = 6805,
        [Description("Minion Global Maximum Added Chaos Damage")]
        MinionGlobalMaximumAddedChaosDamage = 6806,
        [Description("Minion Life Regeneration Rate Per Second")]
        MinionLifeRegenerationRatePerSecond = 6807,
        [Description("Energy Shield Regeneration Rate Per Second")]
        EnergyShieldRegenerationRatePerSecond = 6808,
        [Description("Local Attack Cast Movement Speed +% During Flask Effect")]
        LocalAttackCastMovementSpeedPosPctDuringFlaskEffect = 6809,
        [Description("Local Attack Cast Movement Speed +% Per Second During Flask Effect")]
        LocalAttackCastMovementSpeedPosPctPerSecondDuringFlaskEffect = 6810,
        [Description("Damage +% Vs Abyssal Monsters")]
        DamagePosPctVsAbyssalMonsters = 6811,
        [Description("Minion Damage +% Vs Abyssal Monsters")]
        MinionDamagePosPctVsAbyssalMonsters = 6812,
        [Description("Additional Physical Damage Reduction % Vs Abyssal Monsters")]
        AdditionalPhysicalDamageReductionPctVsAbyssalMonsters = 6813,
        [Description("Attacker Conditional Damage Stats Requires Tags")]
        AttackerConditionalDamageStatsRequiresTags = 6814,
        [Description("Defender Conditional Damage Stats Requires Tags")]
        DefenderConditionalDamageStatsRequiresTags = 6815,
        [Description("Chance To Block Spells % If Damaged By A Hit Recently")]
        ChanceToBlockSpellsPctIfDamagedByAHitRecently = 6816,
        [Description("Track Have Been Damaged By A Hit Recently")]
        TrackHaveBeenDamagedByAHitRecently = 6817,
        [Description("Have Been Damaged By A Hit Recently")]
        HaveBeenDamagedByAHitRecently = 6818,
        [Description("Movement Speed +% If Have Not Taken Damage Recently")]
        MovementSpeedPosPctIfHaveNotTakenDamageRecently = 6819,
        [Description("Track Have Stopped Taking Damage Over Time Recently")]
        TrackHaveStoppedTakingDamageOverTimeRecently = 6820,
        [Description("Have Stopped Taking Damage Over Time Recently")]
        HaveStoppedTakingDamageOverTimeRecently = 6821,
        [Description("Is Currently Taking Damage Over Time")]
        IsCurrentlyTakingDamageOverTime = 6822,
        [Description("Damage +% If Enemy Killed Recently")]
        DamagePosPctIfEnemyKilledRecently = 6823,
        [Description("Critical Strike Multiplier + If Enemy Killed Recently")]
        CriticalStrikeMultiplierPosIfEnemyKilledRecently = 6824,
        [Description("Armour +% If Enemy Not Killed Recently")]
        ArmourPosPctIfEnemyNotKilledRecently = 6825,
        [Description("Accuracy Rating +% If Enemy Not Killed Recently")]
        AccuracyRatingPosPctIfEnemyNotKilledRecently = 6826,
        [Description("Damage Penetrates % Elemental Resistance If Enemy Not Killed Recently")]
        DamagePenetratesPctElementalResistanceIfEnemyNotKilledRecently = 6827,
        [Description("Cast Speed +% If Player Minion Has Been Killed Recently")]
        CastSpeedPosPctIfPlayerMinionHasBeenKilledRecently = 6828,
        [Description("Track Has Player Minion Been Killed Recently")]
        TrackHasPlayerMinionBeenKilledRecently = 6829,
        [Description("Has Player Minion Been Killed Recently")]
        HasPlayerMinionBeenKilledRecently = 6830,
        [Description("Minion Damage +% If Have Used A Minion Skill Recently")]
        MinionDamagePosPctIfHaveUsedAMinionSkillRecently = 6831,
        [Description("Track Have Used A Minion Skill Recently")]
        TrackHaveUsedAMinionSkillRecently = 6832,
        [Description("Have Used A Minion Skill Recently")]
        HaveUsedAMinionSkillRecently = 6833,
        [Description("Evasion Rating +% While Moving")]
        EvasionRatingPosPctWhileMoving = 6834,
        [Description("Mana Regeneration Rate +% While Moving")]
        ManaRegenerationRatePosPctWhileMoving = 6835,
        [Description("Life Regeneration Rate Per Minute % While Moving")]
        LifeRegenerationRatePerMinutePctWhileMoving = 6836,
        [Description("Physical Damage % To Add As Fire If Have Crit Recently")]
        PhysicalDamagePctToAddAsFireIfHaveCritRecently = 6837,
        [Description("Attack Speed +% If Have Crit Recently")]
        AttackSpeedPosPctIfHaveCritRecently = 6838,
        [Description("Cast Speed +% If Have Crit Recently")]
        CastSpeedPosPctIfHaveCritRecently = 6839,
        [Description("Critical Strike Chance +% If Have Not Crit Recently")]
        CriticalStrikeChancePosPctIfHaveNotCritRecently = 6840,
        [Description("Minion Attack And Cast Speed +% If You Or Minions Have Killed Enemy Recently")]
        MinionAttackAndCastSpeedPosPctIfYouOrMinionsHaveKilledEnemyRecently = 6841,
        [Description("Notify Parent Have Killed Enemy Recently")]
        NotifyParentHaveKilledEnemyRecently = 6842,
        [Description("Minion Has Killed Enemy Recently")]
        MinionHasKilledEnemyRecently = 6843,
        [Description("Attacks Chance To Blind On Hit %")]
        AttacksChanceToBlindOnHitPct = 6844,
        [Description("Attacks Chance To Taunt On Hit %")]
        AttacksChanceToTauntOnHitPct = 6845,
        [Description("Spells Chance To Hinder On Hit %")]
        SpellsChanceToHinderOnHitPct = 6846,
        [Description("Minion Attacks Chance To Blind On Hit %")]
        MinionAttacksChanceToBlindOnHitPct = 6847,
        [Description("Minion Attacks Chance To Taunt On Hit %")]
        MinionAttacksChanceToTauntOnHitPct = 6848,
        [Description("Minion Spells Chance To Hinder On Hit %")]
        MinionSpellsChanceToHinderOnHitPct = 6849,
        [Description("Desecrate Maximum Number Of Corpses")]
        DesecrateMaximumNumberOfCorpses = 6850,
        [Description("Additional Physical Damage Reduction % If Not Damaged By A Hit Recently")]
        AdditionalPhysicalDamageReductionPctIfNotDamagedByAHitRecently = 6851,
        [Description("Has Aegis Shield Type")]
        HasAegisShieldType = 6852,
        [Description("Local Display Cast Fire Aegis On Gain Skill")]
        LocalDisplayCastFireAegisOnGainSkill = 6853,
        [Description("Local Display Cast Cold Aegis On Gain Skill")]
        LocalDisplayCastColdAegisOnGainSkill = 6854,
        [Description("Local Display Cast Elemental Aegis On Gain Skill")]
        LocalDisplayCastElementalAegisOnGainSkill = 6855,
        [Description("Poison Reflected To Self")]
        PoisonReflectedToSelf = 6856,
        [Description("Bleeding Reflected To Self")]
        BleedingReflectedToSelf = 6857,
        [Description("Chaos Damage Resistance % Per Poison Stack")]
        ChaosDamageResistancePctPerPoisonStack = 6858,
        [Description("Armour +% While Bleeding")]
        ArmourPosPctWhileBleeding = 6859,
        [Description("Avoid Poison %")]
        AvoidPoisonPct = 6860,
        [Description("Cannot Be Frozen")]
        CannotBeFrozen = 6861,
        [Description("Local Display Grants Level X Curse Pillar Skill")]
        LocalDisplayGrantsLevelXCursePillarSkill = 6862,
        [Description("Local Socketed Active Skill Gem Level +")]
        LocalSocketedActiveSkillGemLevelPos = 6863,
        [Description("Local Socketed Active Skill Gem Quality +")]
        LocalSocketedActiveSkillGemQualityPos = 6864,
        [Description("Aegis Unique Shield Max Value")]
        AegisUniqueShieldMaxValue = 6865,
        [Description("Move Daemon Rotation Per Repeat")]
        MoveDaemonRotationPerRepeat = 6866,
        [Description("Move Daemon End Rotation Per Repeat")]
        MoveDaemonEndRotationPerRepeat = 6867,
        [Description("Move Daemon X Offset Per Repeat")]
        MoveDaemonXOffsetPerRepeat = 6868,
        [Description("Move Daemon Y Offset Per Repeat")]
        MoveDaemonYOffsetPerRepeat = 6869,
        [Description("Map Tier +5")]
        MapTierPos5 = 6870,
        [Description("Map Tier 16")]
        MapTier16 = 6871,
        [Description("Raised Spectre Max Level")]
        RaisedSpectreMaxLevel = 6872,
        [Description("Summon Specific Monsters In Front Angle Offset")]
        SummonSpecificMonstersInFrontAngleOffset = 6873,
        [Description("Move Daemon Random Xy Offset")]
        MoveDaemonRandomXyOffset = 6874,
        [Description("Move Daemon Random X Offset")]
        MoveDaemonRandomXOffset = 6875,
        [Description("Move Daemon Random Y Offset")]
        MoveDaemonRandomYOffset = 6876,
        [Description("Endurance Charge Slam Damage +% Final With Endurance Charge")]
        EnduranceChargeSlamDamagePosPctFinalWithEnduranceCharge = 6877,
        [Description("Generic Skill Trigger Skills With Id")]
        GenericSkillTriggerSkillsWithId = 6878,
        [Description("Generic Skill Trigger Id")]
        GenericSkillTriggerId = 6879,
        [Description("Generic Skill Trigger %")]
        GenericSkillTriggerPct = 6880,
        [Description("Projectile Swap From To Locations")]
        ProjectileSwapFromToLocations = 6881,
        [Description("Projectile Angle Variance")]
        ProjectileAngleVariance = 6882,
        [Description("Maligaro Combo Attack Third Hit Damage +% Final")]
        MaligaroComboAttackThirdHitDamagePosPctFinal = 6883,
        [Description("Minions Cannot Be Damaged")]
        MinionsCannotBeDamaged = 6884,
        [Description("Minions Deal No Damage")]
        MinionsDealNoDamage = 6885,
        [Description("Curse On Hit Level Assassins Mark")]
        CurseOnHitLevelAssassinsMark = 6886,
        [Description("Projectile Distance Override")]
        ProjectileDistanceOverride = 6887,
        [Description("Triggered Skill Use Animation Event")]
        TriggeredSkillUseAnimationEvent = 6888,
        [Description("Map Atlas Influence Type")]
        MapAtlasInfluenceType = 6889,
        [Description("Combo Attack First Hit Damage +% Final")]
        ComboAttackFirstHitDamagePosPctFinal = 6890,
        [Description("Support Storm Barrier Physical Damage Taken When Hit +% Final")]
        SupportStormBarrierPhysicalDamageTakenWhenHitPosPctFinal = 6891,
        [Description("Support Storm Barrier Lightning Damage Taken When Hit +% Final")]
        SupportStormBarrierLightningDamageTakenWhenHitPosPctFinal = 6892,
        [Description("Support Storm Barrier Gain Power Charge When Hit %")]
        SupportStormBarrierGainPowerChargeWhenHitPct = 6893,
        [Description("Gain Power Charge When Hit %")]
        GainPowerChargeWhenHitPct = 6894,
        [Description("Local Display Socketed Gems Supported By Level X Storm Barrier")]
        LocalDisplaySocketedGemsSupportedByLevelXStormBarrier = 6895,
        [Description("Gain Critical Strike Chance % For 2 Seconds When You Spend 800 Mana")]
        GainCriticalStrikeChancePctFor2SecondsWhenYouSpend800Mana = 6896,
        [Description("Virtual Maximum Life Leech Rate % Per Minute")]
        VirtualMaximumLifeLeechRatePctPerMinute = 6897,
        [Description("Keystone Vaal Pact")]
        KeystoneVaalPact = 6898,
        [Description("Life Leech Speed Is Doubled")]
        LifeLeechSpeedIsDoubled = 6899,
        [Description("Maximum Life Leech Rate % Per Minute Is Doubled")]
        MaximumLifeLeechRatePctPerMinuteIsDoubled = 6900,
        [Description("Spectres Have Base Duration Ms")]
        SpectresHaveBaseDurationMs = 6901,
        [Description("Spectres Critical Strike Chance +%")]
        SpectresCriticalStrikeChancePosPct = 6902,
        [Description("Gain Her Embrace For X Ms On Enemy Ignited")]
        GainHerEmbraceForXMsOnEnemyIgnited = 6903,
        [Description("Has Her Embrace")]
        HasHerEmbrace = 6904,
        [Description("% Maximum Es And Life Taken As Fire Damage Per Minute Per Level While In Her Embrace")]
        PctMaximumEsAndLifeTakenAsFireDamagePerMinutePerLevelWhileInHerEmbrace = 6905,
        [Description("Projectile Uses Contact Direction")]
        ProjectileUsesContactDirection = 6906,
        [Description("Spell Base Fire Damage % Maximum Life")]
        SpellBaseFireDamagePctMaximumLife = 6907,
        [Description("Additional Critical Strike Chance Per 10 Shield Maximum Energy Shield Permyriad")]
        AdditionalCriticalStrikeChancePer10ShieldMaximumEnergyShieldPermyriad = 6908,
        [Description("Bone Lance Skill Behaviour Variation")]
        BoneLanceSkillBehaviourVariation = 6909,
        [Description("Gain Armour Equal To Mana Reserved")]
        GainArmourEqualToManaReserved = 6910,
        [Description("Gain Vaal Pact If You Have Crit Recently")]
        GainVaalPactIfYouHaveCritRecently = 6911,
        [Description("Virtual Keystone Vaal Pact")]
        VirtualKeystoneVaalPact = 6912,
        [Description("Support Parallel Projectile Number Of Points Per Side")]
        SupportParallelProjectileNumberOfPointsPerSide = 6913,
        [Description("Support Spell Cascade Number Of Cascades Per Side")]
        SupportSpellCascadeNumberOfCascadesPerSide = 6914,
        [Description("Support Spell Cascade Area Of Effect +% Per Cascade")]
        SupportSpellCascadeAreaOfEffectPosPctPerCascade = 6915,
        [Description("Support Spell Cascade Area Of Effect +% Final")]
        SupportSpellCascadeAreaOfEffectPosPctFinal = 6916,
        [Description("Local Display Socketed Gems Supported By Level X Parallel Projectiles")]
        LocalDisplaySocketedGemsSupportedByLevelXParallelProjectiles = 6917,
        [Description("Local Display Socketed Gems Supported By Level X Spell Cascade")]
        LocalDisplaySocketedGemsSupportedByLevelXSpellCascade = 6918,
        [Description("Map Display Area Contains Unbridged Gaps To Cross")]
        MapDisplayAreaContainsUnbridgedGapsToCross = 6919,
        [Description("Map Players Movement Skills Cooldown Speed +%")]
        MapPlayersMovementSkillsCooldownSpeedPosPct = 6920,
        [Description("Movement Skills Cooldown Speed +%")]
        MovementSkillsCooldownSpeedPosPct = 6921,
        [Description("Map Packs Are Kitava")]
        MapPacksAreKitava = 6922,
        [Description("Map Packs Have Anomalies")]
        MapPacksHaveAnomalies = 6923,
        [Description("Map Shaper Influence Spawn Shaper Clone")]
        MapShaperInfluenceSpawnShaperClone = 6924,
        [Description("Map Shaper Influence Additional Packs Of Space Monsters")]
        MapShaperInfluenceAdditionalPacksOfSpaceMonsters = 6925,
        [Description("Map Shaper Influence Spawn Boss Pack")]
        MapShaperInfluenceSpawnBossPack = 6926,
        [Description("Map Shaper Influence Spawn Maelstrom Cell")]
        MapShaperInfluenceSpawnMaelstromCell = 6927,
        [Description("Grasping Vines Movement Speed +% Final")]
        GraspingVinesMovementSpeedPosPctFinal = 6928,
        [Description("Support Parallel Projectiles Damage +% Final")]
        SupportParallelProjectilesDamagePosPctFinal = 6929,
        [Description("Is Trigger Daemon When Hit Triggered Skill")]
        IsTriggerDaemonWhenHitTriggeredSkill = 6930,
        [Description("Trigger Daemon When Hit Triggered Skill Chance %")]
        TriggerDaemonWhenHitTriggeredSkillChancePct = 6931,
        [Description("Cannot Be Ignited With Strength Higher Than Dex")]
        CannotBeIgnitedWithStrengthHigherThanDex = 6932,
        [Description("Cannot Be Frozen With Dex Higher Than Int")]
        CannotBeFrozenWithDexHigherThanInt = 6933,
        [Description("Cannot Be Shocked With Int Higher Than Strength")]
        CannotBeShockedWithIntHigherThanStrength = 6934,
        [Description("Damage +% Per 5 Of Your Lowest Attribute")]
        DamagePosPctPer5OfYourLowestAttribute = 6935,
        [Description("Cannot Be Ignited")]
        CannotBeIgnited = 6936,
        [Description("Attacks With This Weapon Minimum Added Cold Damage Per 10 Dexterity")]
        AttacksWithThisWeaponMinimumAddedColdDamagePer10Dexterity = 6937,
        [Description("Attacks With This Weapon Maximum Added Cold Damage Per 10 Dexterity")]
        AttacksWithThisWeaponMaximumAddedColdDamagePer10Dexterity = 6938,
        [Description("Main Hand Attacks With This Weapon Minimum Added Cold Damage Per 10 Dexterity")]
        MainHandAttacksWithThisWeaponMinimumAddedColdDamagePer10Dexterity = 6939,
        [Description("Main Hand Attacks With This Weapon Maximum Added Cold Damage Per 10 Dexterity")]
        MainHandAttacksWithThisWeaponMaximumAddedColdDamagePer10Dexterity = 6940,
        [Description("Off Hand Attacks With This Weapon Minimum Added Cold Damage Per 10 Dexterity")]
        OffHandAttacksWithThisWeaponMinimumAddedColdDamagePer10Dexterity = 6941,
        [Description("Off Hand Attacks With This Weapon Maximum Added Cold Damage Per 10 Dexterity")]
        OffHandAttacksWithThisWeaponMaximumAddedColdDamagePer10Dexterity = 6942,
        [Description("Local Chaos Damage Taken Per Minute During Flask Effect")]
        LocalChaosDamageTakenPerMinuteDuringFlaskEffect = 6943,
        [Description("Melee Attack Number Of Spirit Strikes")]
        MeleeAttackNumberOfSpiritStrikes = 6944,
        [Description("Cannot Taunt Enemies")]
        CannotTauntEnemies = 6945,
        [Description("Minions Cannot Taunt Enemies")]
        MinionsCannotTauntEnemies = 6946,
        [Description("Base Number Of Support Ghosts Allowed")]
        BaseNumberOfSupportGhostsAllowed = 6947,
        [Description("Chance To Summon Support Ghost On Killing Blow %")]
        ChanceToSummonSupportGhostOnKillingBlowPct = 6948,
        [Description("Support Ghost Base Duration")]
        SupportGhostBaseDuration = 6949,
        [Description("Support Ghost Duration")]
        SupportGhostDuration = 6950,
        [Description("Skill Can Own Support Ghosts")]
        SkillCanOwnSupportGhosts = 6951,
        [Description("Local Display Socketed Gems Supported By Level X Spirit Strike")]
        LocalDisplaySocketedGemsSupportedByLevelXSpiritStrike = 6952,
        [Description("Local Display Socketed Gems Supported By Level X Summon Ghost On Kill")]
        LocalDisplaySocketedGemsSupportedByLevelXSummonGhostOnKill = 6953,
        [Description("Support Spirit Strike Damage +% Final")]
        SupportSpiritStrikeDamagePosPctFinal = 6954,
        [Description("Local Display Socketed Attacks Additional Critical Strike Chance")]
        LocalDisplaySocketedAttacksAdditionalCriticalStrikeChance = 6955,
        [Description("Local Display Socketed Attacks Critical Strike Multiplier +")]
        LocalDisplaySocketedAttacksCriticalStrikeMultiplierPos = 6956,
        [Description("Local Display Socketed Spells Additional Critical Strike Chance")]
        LocalDisplaySocketedSpellsAdditionalCriticalStrikeChance = 6957,
        [Description("Local Display Socketed Spells Critical Strike Multiplier +")]
        LocalDisplaySocketedSpellsCriticalStrikeMultiplierPos = 6958,
        [Description("Keystone Shared Suffering")]
        KeystoneSharedSuffering = 6959,
        [Description("All Damage Can Cause Elemental Ailments You Are Suffering From")]
        AllDamageCanCauseElementalAilmentsYouAreSufferingFrom = 6960,
        [Description("Base All Damage Can Cause Elemental Ailments You Are Suffering From")]
        BaseAllDamageCanCauseElementalAilmentsYouAreSufferingFrom = 6961,
        [Description("Always Inflict Elemental Ailments You Are Suffering From")]
        AlwaysInflictElementalAilmentsYouAreSufferingFrom = 6962,
        [Description("Base Always Inflict Elemental Ailments You Are Suffering From")]
        BaseAlwaysInflictElementalAilmentsYouAreSufferingFrom = 6963,
        [Description("Remove Elemental Ailments From You When You Inflict Them")]
        RemoveElementalAilmentsFromYouWhenYouInflictThem = 6964,
        [Description("Base Remove Elemental Ailments From You When You Inflict Them")]
        BaseRemoveElementalAilmentsFromYouWhenYouInflictThem = 6965,
        [Description("Geometry Attack Shape")]
        GeometryAttackShape = 6966,
        [Description("Geometry Attack Length")]
        GeometryAttackLength = 6967,
        [Description("Geometry Attack Width")]
        GeometryAttackWidth = 6968,
        [Description("Geometry Attack Arc Angle")]
        GeometryAttackArcAngle = 6969,
        [Description("Map Packs Have Tentacle Fiends")]
        MapPacksHaveTentacleFiends = 6970,
        [Description("No Movement Speed")]
        NoMovementSpeed = 6971,
        [Description("Unaffected By Shock")]
        UnaffectedByShock = 6972,
        [Description("Unaffected By Shocked Ground")]
        UnaffectedByShockedGround = 6973,
        [Description("Unaffected By Burning Ground")]
        UnaffectedByBurningGround = 6974,
        [Description("Unaffected By Chilled Ground")]
        UnaffectedByChilledGround = 6975,
        [Description("Unaffected By Desecrated Ground")]
        UnaffectedByDesecratedGround = 6976,
        [Description("Flammability Mana Reservation +%")]
        FlammabilityManaReservationPosPct = 6977,
        [Description("Frostbite Mana Reservation +%")]
        FrostbiteManaReservationPosPct = 6978,
        [Description("Conductivity Mana Reservation +%")]
        ConductivityManaReservationPosPct = 6979,
        [Description("Vulnerability Mana Reservation +%")]
        VulnerabilityManaReservationPosPct = 6980,
        [Description("Chaos Weakness Mana Reservation +%")]
        ChaosWeaknessManaReservationPosPct = 6981,
        [Description("Local Display Grants Skill Decoy Totem Level")]
        LocalDisplayGrantsSkillDecoyTotemLevel = 6982,
        [Description("Local Display Grants Skill Enduring Cry Level")]
        LocalDisplayGrantsSkillEnduringCryLevel = 6983,
        [Description("Local Display Grants Skill Rallying Cry Level")]
        LocalDisplayGrantsSkillRallyingCryLevel = 6984,
        [Description("Local Display Grants Skill Abyssal Cry Level")]
        LocalDisplayGrantsSkillAbyssalCryLevel = 6985,
        [Description("Local Display Grants Skill Herald Of Ash Level")]
        LocalDisplayGrantsSkillHeraldOfAshLevel = 6986,
        [Description("Local Display Grants Skill Herald Of Ice Level")]
        LocalDisplayGrantsSkillHeraldOfIceLevel = 6987,
        [Description("Local Display Grants Skill Herald Of Thunder Level")]
        LocalDisplayGrantsSkillHeraldOfThunderLevel = 6988,
        [Description("Curse On Hit Level Poachers Mark")]
        CurseOnHitLevelPoachersMark = 6989,
        [Description("Curse On Hit Level Warlords Mark")]
        CurseOnHitLevelWarlordsMark = 6990,
        [Description("Elemental Damage Can Shock")]
        ElementalDamageCanShock = 6991,
        [Description("Ailment Types Apply Damage Taken +%")]
        AilmentTypesApplyDamageTakenPosPct = 6992,
        [Description("Evasion Rating +% While Leeching")]
        EvasionRatingPosPctWhileLeeching = 6993,
        [Description("Blind Enemies When Hit % Chance")]
        BlindEnemiesWhenHitPctChance = 6994,
        [Description("Evasion Rating +% If You Have Hit An Enemy Recently")]
        EvasionRatingPosPctIfYouHaveHitAnEnemyRecently = 6995,
        [Description("Gain 1 Rare Monster Mod On Kill For 10 Seconds % Chance")]
        Gain1RareMonsterModOnKillFor10SecondsPctChance = 6996,
        [Description("Enemy Evasion +% If You Have Hit Them Recently")]
        EnemyEvasionPosPctIfYouHaveHitThemRecently = 6997,
        [Description("Critical Strike Multiplier + If Have Not Dealt Critical Strike Recently")]
        CriticalStrikeMultiplierPosIfHaveNotDealtCriticalStrikeRecently = 6998,
        [Description("Number Of Additional Arrows While Main Hand Accuracy Is 3000 Or More")]
        NumberOfAdditionalArrowsWhileMainHandAccuracyIs3000OrMore = 6999,
        [Description("Accuracy Rating Is Doubled")]
        AccuracyRatingIsDoubled = 7000,
        [Description("Melee Physical Damage +% Per 10 Strength While Fortified")]
        MeleePhysicalDamagePosPctPer10StrengthWhileFortified = 7001,
        [Description("Chance To Dodge Attacks % While Off Hand Is Empty")]
        ChanceToDodgeAttacksPctWhileOffHandIsEmpty = 7002,
        [Description("Cold Damage +% While Off Hand Is Empty")]
        ColdDamagePosPctWhileOffHandIsEmpty = 7003,
        [Description("Iron Reflexes Rotation Active")]
        IronReflexesRotationActive = 7004,
        [Description("Unique Bow Arborix Close Range Bow Damage +% Final While Have Iron Reflexes")]
        UniqueBowArborixCloseRangeBowDamagePosPctFinalWhileHaveIronReflexes = 7005,
        [Description("Unique Bow Arborix Close Range Bow Damage +% Final")]
        UniqueBowArborixCloseRangeBowDamagePosPctFinal = 7006,
        [Description("Virtual Player Far Shot")]
        VirtualPlayerFarShot = 7007,
        [Description("Gain Player Far Shot While Do Not Have Iron Reflexes")]
        GainPlayerFarShotWhileDoNotHaveIronReflexes = 7008,
        [Description("Attack Cast And Movement Speed +% While Do Not Have Iron Reflexes")]
        AttackCastAndMovementSpeedPosPctWhileDoNotHaveIronReflexes = 7009,
        [Description("Local Display Trigger Death Walk On Equip Level")]
        LocalDisplayTriggerDeathWalkOnEquipLevel = 7010,
        [Description("Number Of Melee Abyss Jewels")]
        NumberOfMeleeAbyssJewels = 7011,
        [Description("Number Of Ranged Abyss Jewels")]
        NumberOfRangedAbyssJewels = 7012,
        [Description("Number Of Caster Abyss Jewels")]
        NumberOfCasterAbyssJewels = 7013,
        [Description("Number Of Minion Abyss Jewels")]
        NumberOfMinionAbyssJewels = 7014,
        [Description("Number Of Abyss Jewels")]
        NumberOfAbyssJewels = 7015,
        [Description("Number Of Abyss Jewel Types")]
        NumberOfAbyssJewelTypes = 7016,
        [Description("Damage +% Per Abyss Jewel Type")]
        DamagePosPctPerAbyssJewelType = 7017,
        [Description("Support Spell Cascade Damage +% Final")]
        SupportSpellCascadeDamagePosPctFinal = 7018,
        [Description("Virtual Physical Damage Can Chill")]
        VirtualPhysicalDamageCanChill = 7019,
        [Description("Virtual Fire Damage Can Chill")]
        VirtualFireDamageCanChill = 7020,
        [Description("Virtual Cold Damage Cannot Chill")]
        VirtualColdDamageCannotChill = 7021,
        [Description("Virtual Lightning Damage Can Chill")]
        VirtualLightningDamageCanChill = 7022,
        [Description("Virtual Chaos Damage Can Chill")]
        VirtualChaosDamageCanChill = 7023,
        [Description("Fire Damage Can Chill")]
        FireDamageCanChill = 7024,
        [Description("Lightning Damage Can Chill")]
        LightningDamageCanChill = 7025,
        [Description("Virtual Physical Damage Can Freeze")]
        VirtualPhysicalDamageCanFreeze = 7026,
        [Description("Virtual Fire Damage Can Freeze")]
        VirtualFireDamageCanFreeze = 7027,
        [Description("Virtual Cold Damage Cannot Freeze")]
        VirtualColdDamageCannotFreeze = 7028,
        [Description("Virtual Lightning Damage Can Freeze")]
        VirtualLightningDamageCanFreeze = 7029,
        [Description("Virtual Chaos Damage Can Freeze")]
        VirtualChaosDamageCanFreeze = 7030,
        [Description("Physical Damage Can Freeze")]
        PhysicalDamageCanFreeze = 7031,
        [Description("Fire Damage Can Freeze")]
        FireDamageCanFreeze = 7032,
        [Description("Chaos Damage Can Freeze")]
        ChaosDamageCanFreeze = 7033,
        [Description("All Damage Can Freeze")]
        AllDamageCanFreeze = 7034,
        [Description("Virtual Physical Damage Can Shock")]
        VirtualPhysicalDamageCanShock = 7035,
        [Description("Virtual Fire Damage Can Shock")]
        VirtualFireDamageCanShock = 7036,
        [Description("Virtual Cold Damage Can Shock")]
        VirtualColdDamageCanShock = 7037,
        [Description("Virtual Lightning Damage Cannot Shock")]
        VirtualLightningDamageCannotShock = 7038,
        [Description("Virtual Chaos Damage Can Shock")]
        VirtualChaosDamageCanShock = 7039,
        [Description("Cold Damage Can Shock")]
        ColdDamageCanShock = 7040,
        [Description("Chaos Damage Cannot Poison")]
        ChaosDamageCannotPoison = 7041,
        [Description("Physical Damage Cannot Poison")]
        PhysicalDamageCannotPoison = 7042,
        [Description("Area Of Effect +% With 500 Or More Strength")]
        AreaOfEffectPosPctWith500OrMoreStrength = 7043,
        [Description("Area Of Effect +% If Have Stunned An Enemy Recently")]
        AreaOfEffectPosPctIfHaveStunnedAnEnemyRecently = 7044,
        [Description("Track Have Stunned An Enemy Recently")]
        TrackHaveStunnedAnEnemyRecently = 7045,
        [Description("Have Stunned An Enemy Recently")]
        HaveStunnedAnEnemyRecently = 7046,
        [Description("Chance To Gain Endurance Charge On Hit % Vs Bleeding Enemy")]
        ChanceToGainEnduranceChargeOnHitPctVsBleedingEnemy = 7047,
        [Description("Local Display Socketed Movement Skills Have No Mana Cost")]
        LocalDisplaySocketedMovementSkillsHaveNoManaCost = 7048,
        [Description("Local Hits With This Weapon Always Hit If Have Blocked Recently")]
        LocalHitsWithThisWeaponAlwaysHitIfHaveBlockedRecently = 7049,
        [Description("Main Hand Hits With This Weapon Always Hit If Have Blocked Recently")]
        MainHandHitsWithThisWeaponAlwaysHitIfHaveBlockedRecently = 7050,
        [Description("Off Hand Hits With This Weapon Always Hit If Have Blocked Recently")]
        OffHandHitsWithThisWeaponAlwaysHitIfHaveBlockedRecently = 7051,
        [Description("Additional Block % Per Endurance Charge")]
        AdditionalBlockPctPerEnduranceCharge = 7052,
        [Description("Attack Speed +% If Have Blocked Recently")]
        AttackSpeedPosPctIfHaveBlockedRecently = 7053,
        [Description("Local Display Trigger Level X Smoke Cloud On Trap Triggered")]
        LocalDisplayTriggerLevelXSmokeCloudOnTrapTriggered = 7054,
        [Description("Area Of Effect +% While Fortified")]
        AreaOfEffectPosPctWhileFortified = 7055,
        [Description("Melee Weapon Range + If You Have Killed Recently")]
        MeleeWeaponRangePosIfYouHaveKilledRecently = 7056,
        [Description("Melee Weapon Range + While Fortified")]
        MeleeWeaponRangePosWhileFortified = 7057,
        [Description("Stun Duration +% Per 15 Strength")]
        StunDurationPosPctPer15Strength = 7058,
        [Description("Stun Threshold Reduction +% With 500 Or More Strength")]
        StunThresholdReductionPosPctWith500OrMoreStrength = 7059,
        [Description("Area Of Effect +% Per Endurance Charge")]
        AreaOfEffectPosPctPerEnduranceCharge = 7060,
        [Description("Area Damage +% Per 12 Strength")]
        AreaDamagePosPctPer12Strength = 7061,
        [Description("Damage +% Vs Taunted Enemies")]
        DamagePosPctVsTauntedEnemies = 7062,
        [Description("Chance To Gain Endurance Charge When You Taunt Enemy %")]
        ChanceToGainEnduranceChargeWhenYouTauntEnemyPct = 7063,
        [Description("Attacks Chance To Bleed On Hit % Vs Taunted Enemies")]
        AttacksChanceToBleedOnHitPctVsTauntedEnemies = 7064,
        [Description("Bleed Damage +% Per Endurance Charge")]
        BleedDamagePosPctPerEnduranceCharge = 7065,
        [Description("Melee Movement Skill Chance To Fortify On Hit %")]
        MeleeMovementSkillChanceToFortifyOnHitPct = 7066,
        [Description("Melee Weapon Range + While At Maximum Frenzy Charges")]
        MeleeWeaponRangePosWhileAtMaximumFrenzyCharges = 7067,
        [Description("Poison Damage +% Vs Bleeding Enemies")]
        PoisonDamagePosPctVsBleedingEnemies = 7068,
        [Description("Additional Physical Damage Reduction % While Moving")]
        AdditionalPhysicalDamageReductionPctWhileMoving = 7069,
        [Description("Elemental Damage Taken +% While Stationary")]
        ElementalDamageTakenPosPctWhileStationary = 7070,
        [Description("Map Monsters Avoid Ailments %")]
        MapMonstersAvoidAilmentsPct = 7071,
        [Description("Number Of Endurance Charges To Gain Every 4 Seconds While Stationary")]
        NumberOfEnduranceChargesToGainEvery4SecondsWhileStationary = 7072,
        [Description("Maximum Life +% Per Abyssal Jewel Affecting You")]
        MaximumLifePosPctPerAbyssalJewelAffectingYou = 7073,
        [Description("Maximum Mana +% Per Abyssal Jewel Affecting You")]
        MaximumManaPosPctPerAbyssalJewelAffectingYou = 7074,
        [Description("Cast Speed +% During Flask Effect")]
        CastSpeedPosPctDuringFlaskEffect = 7075,
        [Description("Melee Damage +% During Flask Effect")]
        MeleeDamagePosPctDuringFlaskEffect = 7076,
        [Description("Projectile Attack Damage +% During Flask Effect")]
        ProjectileAttackDamagePosPctDuringFlaskEffect = 7077,
        [Description("Spell Damage +% During Flask Effect")]
        SpellDamagePosPctDuringFlaskEffect = 7078,
        [Description("Local Crits Have Culling Strike")]
        LocalCritsHaveCullingStrike = 7079,
        [Description("Main Hand Local Crits Have Culling Strike")]
        MainHandLocalCritsHaveCullingStrike = 7080,
        [Description("Off Hand Local Crits Have Culling Strike")]
        OffHandLocalCritsHaveCullingStrike = 7081,
        [Description("Global Minimum Added Fire Damage Vs Ignited Enemies")]
        GlobalMinimumAddedFireDamageVsIgnitedEnemies = 7082,
        [Description("Global Maximum Added Fire Damage Vs Ignited Enemies")]
        GlobalMaximumAddedFireDamageVsIgnitedEnemies = 7083,
        [Description("Global Minimum Added Cold Damage Vs Chilled Or Frozen Enemies")]
        GlobalMinimumAddedColdDamageVsChilledOrFrozenEnemies = 7084,
        [Description("Global Maximum Added Cold Damage Vs Chilled Or Frozen Enemies")]
        GlobalMaximumAddedColdDamageVsChilledOrFrozenEnemies = 7085,
        [Description("Global Minimum Added Lightning Damage Vs Shocked Enemies")]
        GlobalMinimumAddedLightningDamageVsShockedEnemies = 7086,
        [Description("Global Maximum Added Lightning Damage Vs Shocked Enemies")]
        GlobalMaximumAddedLightningDamageVsShockedEnemies = 7087,
        [Description("Chill Attackers For 4 Seconds On Block % Chance")]
        ChillAttackersFor4SecondsOnBlockPctChance = 7088,
        [Description("Shock Attackers For 4 Seconds On Block % Chance")]
        ShockAttackersFor4SecondsOnBlockPctChance = 7089,
        [Description("Damage +% Per 1% Block Chance")]
        DamagePosPctPer1PctBlockChance = 7090,
        [Description("Dodge Attacks Chance % If You Have Blocked Recently")]
        DodgeAttacksChancePctIfYouHaveBlockedRecently = 7091,
        [Description("Damage +% Per 15 Strength")]
        DamagePosPctPer15Strength = 7092,
        [Description("Damage +% Per 15 Dex")]
        DamagePosPctPer15Dex = 7093,
        [Description("Damage +% Per 15 Int")]
        DamagePosPctPer15Int = 7094,
        [Description("Additional Block % With 5 Or More Nearby Enemies")]
        AdditionalBlockPctWith5OrMoreNearbyEnemies = 7095,
        [Description("Gain Random Charge On Block")]
        GainRandomChargeOnBlock = 7096,
        [Description("Chance To Evade Attacks %")]
        ChanceToEvadeAttacksPct = 7097,
        [Description("Mana Gained On Spell Hit")]
        ManaGainedOnSpellHit = 7098,
        [Description("Remove Ignite And Burning On Flask Use")]
        RemoveIgniteAndBurningOnFlaskUse = 7099,
        [Description("Remove Chill And Freeze On Flask Use")]
        RemoveChillAndFreezeOnFlaskUse = 7100,
        [Description("Remove Shock On Flask Use")]
        RemoveShockOnFlaskUse = 7101,
        [Description("Number Of Equipped Elder Items")]
        NumberOfEquippedElderItems = 7102,
        [Description("Maximum Life Per Equipped Elder Item")]
        MaximumLifePerEquippedElderItem = 7103,
        [Description("Non Damaging Ailment Effect +% Per Equipped Elder Item")]
        NonDamagingAilmentEffectPosPctPerEquippedElderItem = 7104,
        [Description("Ailment Damage +% Per Equipped Elder Item")]
        AilmentDamagePosPctPerEquippedElderItem = 7105,
        [Description("Remove Random Ailment On Flask Use If All Equipped Items Are Elder")]
        RemoveRandomAilmentOnFlaskUseIfAllEquippedItemsAreElder = 7106,
        [Description("Virtual Freeze Effect +%")]
        VirtualFreezeEffectPosPct = 7107,
        [Description("Virtual Ignite Effect +%")]
        VirtualIgniteEffectPosPct = 7108,
        [Description("Virtual Poison Effect +%")]
        VirtualPoisonEffectPosPct = 7109,
        [Description("Virtual Bleed Effect +%")]
        VirtualBleedEffectPosPct = 7110,
        [Description("Virtual Minion Elemental Resistance %")]
        VirtualMinionElementalResistancePct = 7111,
        [Description("Minion Elemental Resistance 30%")]
        MinionElementalResistance30Pct = 7112,
        [Description("Strength Damage Bonus Grants Melee Physical Damage +3% Per 10 Strength Instead")]
        StrengthDamageBonusGrantsMeleePhysicalDamagePos3PctPer10StrengthInstead = 7113,
        [Description("Fortify Duration +% Per 10 Strength")]
        FortifyDurationPosPctPer10Strength = 7114,
        [Description("Attack Additional Critical Strike Chance Permyriad")]
        AttackAdditionalCriticalStrikeChancePermyriad = 7115,
        [Description("Spell Additional Critical Strike Chance Permyriad")]
        SpellAdditionalCriticalStrikeChancePermyriad = 7116,
        [Description("Virtual Fortify Duration +%")]
        VirtualFortifyDurationPosPct = 7117,
        [Description("Virtual Fortify Effect On Self +%")]
        VirtualFortifyEffectOnSelfPosPct = 7118,
        [Description("Fortify Effect On Self +% While Stationary")]
        FortifyEffectOnSelfPosPctWhileStationary = 7119,
        [Description("Remove Bleeding On Warcry")]
        RemoveBleedingOnWarcry = 7120,
        [Description("Chance To Gain Endurance Charge When You Stun Enemy %")]
        ChanceToGainEnduranceChargeWhenYouStunEnemyPct = 7121,
        [Description("Critical Strike Multiplier + If You Have Blocked Recently")]
        CriticalStrikeMultiplierPosIfYouHaveBlockedRecently = 7122,
        [Description("Bleeding Damage +% Vs Poisoned Enemies")]
        BleedingDamagePosPctVsPoisonedEnemies = 7123,
        [Description("Area Of Effect +% If You Have Blocked Recently")]
        AreaOfEffectPosPctIfYouHaveBlockedRecently = 7124,
        [Description("Elemental Damage +% Per Power Charge")]
        ElementalDamagePosPctPerPowerCharge = 7125,
        [Description("Elemental Damage +% Per 12 Int")]
        ElementalDamagePosPctPer12Int = 7126,
        [Description("Elemental Damage +% Per 12 Strength")]
        ElementalDamagePosPctPer12Strength = 7127,
        [Description("Elemental Damage Taken +% Per Endurance Charge")]
        ElementalDamageTakenPosPctPerEnduranceCharge = 7128,
        [Description("Additional Block % If You Have Crit Recently")]
        AdditionalBlockPctIfYouHaveCritRecently = 7129,
        [Description("Area Of Effect +% Per 50 Strength")]
        AreaOfEffectPosPctPer50Strength = 7130,
        [Description("Local Life Gain Per Target Vs Blinded Enemies")]
        LocalLifeGainPerTargetVsBlindedEnemies = 7131,
        [Description("Main Hand Local Life Gain Per Target Vs Blinded Enemies")]
        MainHandLocalLifeGainPerTargetVsBlindedEnemies = 7132,
        [Description("Off Hand Local Life Gain Per Target Vs Blinded Enemies")]
        OffHandLocalLifeGainPerTargetVsBlindedEnemies = 7133,
        [Description("Local Culling Strike If Crit Recently")]
        LocalCullingStrikeIfCritRecently = 7134,
        [Description("Main Hand Culling Strike If Crit Recently")]
        MainHandCullingStrikeIfCritRecently = 7135,
        [Description("Off Hand Culling Strike If Crit Recently")]
        OffHandCullingStrikeIfCritRecently = 7136,
        [Description("Support Mirage Archer Base Duration")]
        SupportMirageArcherBaseDuration = 7137,
        [Description("Support Mirage Archer Duration")]
        SupportMirageArcherDuration = 7138,
        [Description("Summon Mirage Archer On Hit")]
        SummonMirageArcherOnHit = 7139,
        [Description("Skill Can Own Mirage Archers")]
        SkillCanOwnMirageArchers = 7140,
        [Description("Number Of Mirage Archers Allowed")]
        NumberOfMirageArchersAllowed = 7141,
        [Description("Support Mirage Archer Damage +% Final")]
        SupportMirageArcherDamagePosPctFinal = 7142,
        [Description("Use Scaled Contact Offset")]
        UseScaledContactOffset = 7143,
        [Description("Local Culling Strike Vs Bleeding Enemies")]
        LocalCullingStrikeVsBleedingEnemies = 7144,
        [Description("Main Hand Culling Strike Vs Bleeding Enemies")]
        MainHandCullingStrikeVsBleedingEnemies = 7145,
        [Description("Off Hand Culling Strike Vs Bleeding Enemies")]
        OffHandCullingStrikeVsBleedingEnemies = 7146,
        [Description("Local Display Grants Level X Blood Offering Skill")]
        LocalDisplayGrantsLevelXBloodOfferingSkill = 7147,
        [Description("Active Skill Projectile Speed +% Variation Final")]
        ActiveSkillProjectileSpeedPosPctVariationFinal = 7148,
        [Description("Local Socketed Abyss Jewel Effect +%")]
        LocalSocketedAbyssJewelEffectPosPct = 7149,
        [Description("Non Piercing Projectiles Critical Strike Chance +%")]
        NonPiercingProjectilesCriticalStrikeChancePosPct = 7150,
        [Description("Local Evasion Rating And Energy Shield")]
        LocalEvasionRatingAndEnergyShield = 7151,
        [Description("Number Of Additional Projectiles If You Have Been Hit Recently")]
        NumberOfAdditionalProjectilesIfYouHaveBeenHitRecently = 7152,
        [Description("Gain Iron Reflexes While Stationary")]
        GainIronReflexesWhileStationary = 7153,
        [Description("Armour +% While Stationary")]
        ArmourPosPctWhileStationary = 7154,
        [Description("Number Of Additional Projectiles If You Have Used Movement Skill Recently")]
        NumberOfAdditionalProjectilesIfYouHaveUsedMovementSkillRecently = 7155,
        [Description("Virtual Keystone Iron Reflexes")]
        VirtualKeystoneIronReflexes = 7156,
        [Description("Attacks Intimidate On Hit %")]
        AttacksIntimidateOnHitPct = 7157,
        [Description("Local Attacks Intimidate On Hit For 4 Seconds With Melee Abyss Jewel Socketed")]
        LocalAttacksIntimidateOnHitFor4SecondsWithMeleeAbyssJewelSocketed = 7158,
        [Description("Local Attacks Maim On Hit For 4 Seconds With Ranged Abyss Jewel Socketed")]
        LocalAttacksMaimOnHitFor4SecondsWithRangedAbyssJewelSocketed = 7159,
        [Description("Elemental Overload Rotation Active")]
        ElementalOverloadRotationActive = 7160,
        [Description("Gain Resolute Technique While Do Not Have Elemental Overload")]
        GainResoluteTechniqueWhileDoNotHaveElementalOverload = 7161,
        [Description("Virtual Keystone Resolute Technique")]
        VirtualKeystoneResoluteTechnique = 7162,
        [Description("Local Minimum Added Physical Damage Vs Ignited Enemies")]
        LocalMinimumAddedPhysicalDamageVsIgnitedEnemies = 7163,
        [Description("Local Maximum Added Physical Damage Vs Ignited Enemies")]
        LocalMaximumAddedPhysicalDamageVsIgnitedEnemies = 7164,
        [Description("Local Minimum Added Fire Damage Vs Bleeding Enemies")]
        LocalMinimumAddedFireDamageVsBleedingEnemies = 7165,
        [Description("Local Maximum Added Fire Damage Vs Bleeding Enemies")]
        LocalMaximumAddedFireDamageVsBleedingEnemies = 7166,
        [Description("Main Hand Minimum Added Physical Damage Vs Ignited Enemies")]
        MainHandMinimumAddedPhysicalDamageVsIgnitedEnemies = 7167,
        [Description("Main Hand Maximum Added Physical Damage Vs Ignited Enemies")]
        MainHandMaximumAddedPhysicalDamageVsIgnitedEnemies = 7168,
        [Description("Main Hand Minimum Added Fire Damage Vs Bleeding Enemies")]
        MainHandMinimumAddedFireDamageVsBleedingEnemies = 7169,
        [Description("Main Hand Maximum Added Fire Damage Vs Bleeding Enemies")]
        MainHandMaximumAddedFireDamageVsBleedingEnemies = 7170,
        [Description("Off Hand Minimum Added Physical Damage Vs Ignited Enemies")]
        OffHandMinimumAddedPhysicalDamageVsIgnitedEnemies = 7171,
        [Description("Off Hand Maximum Added Physical Damage Vs Ignited Enemies")]
        OffHandMaximumAddedPhysicalDamageVsIgnitedEnemies = 7172,
        [Description("Off Hand Minimum Added Fire Damage Vs Bleeding Enemies")]
        OffHandMinimumAddedFireDamageVsBleedingEnemies = 7173,
        [Description("Off Hand Maximum Added Fire Damage Vs Bleeding Enemies")]
        OffHandMaximumAddedFireDamageVsBleedingEnemies = 7174,
        [Description("Local Chance Bleed On Hit % Vs Ignited Enemies")]
        LocalChanceBleedOnHitPctVsIgnitedEnemies = 7175,
        [Description("Main Hand Chance Bleed On Hit % Vs Ignited Enemies")]
        MainHandChanceBleedOnHitPctVsIgnitedEnemies = 7176,
        [Description("Off Hand Chance Bleed On Hit % Vs Ignited Enemies")]
        OffHandChanceBleedOnHitPctVsIgnitedEnemies = 7177,
        [Description("Avatar Of Fire Rotation Active")]
        AvatarOfFireRotationActive = 7178,
        [Description("Critical Strike Chance +% While You Have Avatar Of Fire")]
        CriticalStrikeChancePosPctWhileYouHaveAvatarOfFire = 7179,
        [Description("Physical Damage % To Convert To Fire While You Have Avatar Of Fire")]
        PhysicalDamagePctToConvertToFireWhileYouHaveAvatarOfFire = 7180,
        [Description("Armour While You Do Not Have Avatar Of Fire")]
        ArmourWhileYouDoNotHaveAvatarOfFire = 7181,
        [Description("Non Chaos Damage To Add As Chaos Damage %")]
        NonChaosDamageToAddAsChaosDamagePct = 7182,
        [Description("Projectile Non Chaos Damage To Add As Chaos Damage % Per Chain")]
        ProjectileNonChaosDamageToAddAsChaosDamagePctPerChain = 7183,
        [Description("Attack Speed +% If Enemy Killed Recently")]
        AttackSpeedPosPctIfEnemyKilledRecently = 7184,
        [Description("Critical Strike Chance +% If Enemy Killed Recently")]
        CriticalStrikeChancePosPctIfEnemyKilledRecently = 7185,
        [Description("Projectile Damage +% Per Pierced Enemy")]
        ProjectileDamagePosPctPerPiercedEnemy = 7186,
        [Description("Recover Energy Shield % On Kill")]
        RecoverEnergyShieldPctOnKill = 7187,
        [Description("Map Monsters Add Power Charge On Hit %")]
        MapMonstersAddPowerChargeOnHitPct = 7188,
        [Description("Map Monsters Add Frenzy Charge On Hit %")]
        MapMonstersAddFrenzyChargeOnHitPct = 7189,
        [Description("Map Monsters Add Endurance Charge On Hit %")]
        MapMonstersAddEnduranceChargeOnHitPct = 7190,
        [Description("Local Life Gain Per Target While Leeching")]
        LocalLifeGainPerTargetWhileLeeching = 7191,
        [Description("Main Hand Life Gain Per Target While Leeching")]
        MainHandLifeGainPerTargetWhileLeeching = 7192,
        [Description("Off Hand Life Gain Per Target While Leeching")]
        OffHandLifeGainPerTargetWhileLeeching = 7193,
        [Description("Local Display Socketed Gems Supported By Level X Mirage Archer")]
        LocalDisplaySocketedGemsSupportedByLevelXMirageArcher = 7194,
        [Description("Spectre Duration")]
        SpectreDuration = 7195,
        [Description("Arrows That Pierce Also Return")]
        ArrowsThatPierceAlsoReturn = 7196,
        [Description("Predict Totem Maximum Life")]
        PredictTotemMaximumLife = 7197,
        [Description("Unique Monster Dropped Item Rarity +%")]
        UniqueMonsterDroppedItemRarityPosPct = 7198,
        [Description("Cannot Block Spells")]
        CannotBlockSpells = 7199,
        [Description("Gain Endurance Charge % Chance When You Lose Fortify")]
        GainEnduranceChargePctChanceWhenYouLoseFortify = 7200,
        [Description("Affected By Determination")]
        AffectedByDetermination = 7201,
        [Description("Affected By Grace")]
        AffectedByGrace = 7202,
        [Description("Affected By Discipline")]
        AffectedByDiscipline = 7203,
        [Description("Affected By Wrath")]
        AffectedByWrath = 7204,
        [Description("Affected By Anger")]
        AffectedByAnger = 7205,
        [Description("Affected By Hatred")]
        AffectedByHatred = 7206,
        [Description("Affected By Vitality")]
        AffectedByVitality = 7207,
        [Description("Affected By Clarity")]
        AffectedByClarity = 7208,
        [Description("Affected By Haste")]
        AffectedByHaste = 7209,
        [Description("Affected By Purity Of Fire")]
        AffectedByPurityOfFire = 7210,
        [Description("Affected By Purity Of Ice")]
        AffectedByPurityOfIce = 7211,
        [Description("Affected By Purity Of Lightning")]
        AffectedByPurityOfLightning = 7212,
        [Description("Affected By Purity Of Elements")]
        AffectedByPurityOfElements = 7213,
        [Description("Additional Physical Damage Reduction % While Affected By Determination")]
        AdditionalPhysicalDamageReductionPctWhileAffectedByDetermination = 7214,
        [Description("Block % While Affected By Determination")]
        BlockPctWhileAffectedByDetermination = 7215,
        [Description("Extra Damage Taken From Crit +% While Affected By Determination")]
        ExtraDamageTakenFromCritPosPctWhileAffectedByDetermination = 7216,
        [Description("Chance To Evade Attacks % While Affected By Grace")]
        ChanceToEvadeAttacksPctWhileAffectedByGrace = 7217,
        [Description("Chance To Dodge Attacks % While Affected By Grace")]
        ChanceToDodgeAttacksPctWhileAffectedByGrace = 7218,
        [Description("Movement Speed +% While Affected By Grace")]
        MovementSpeedPosPctWhileAffectedByGrace = 7219,
        [Description("Unaffected By Vulnerability While Affected By Determination")]
        UnaffectedByVulnerabilityWhileAffectedByDetermination = 7220,
        [Description("Unaffected By Enfeeble While Affected By Grace")]
        UnaffectedByEnfeebleWhileAffectedByGrace = 7221,
        [Description("Unaffected By Temporal Chains While Affected By Haste")]
        UnaffectedByTemporalChainsWhileAffectedByHaste = 7222,
        [Description("Unaffected By Burning Ground While Affected By Purity Of Fire")]
        UnaffectedByBurningGroundWhileAffectedByPurityOfFire = 7223,
        [Description("Unaffected By Flammability While Affected By Purity Of Fire")]
        UnaffectedByFlammabilityWhileAffectedByPurityOfFire = 7224,
        [Description("Unaffected By Chilled Ground While Affected By Purity Of Ice")]
        UnaffectedByChilledGroundWhileAffectedByPurityOfIce = 7225,
        [Description("Unaffected By Frostbite While Affected By Purity Of Ice")]
        UnaffectedByFrostbiteWhileAffectedByPurityOfIce = 7226,
        [Description("Unaffected By Shocked Ground While Affected By Purity Of Lightning")]
        UnaffectedByShockedGroundWhileAffectedByPurityOfLightning = 7227,
        [Description("Unaffected By Conductivity While Affected By Purity Of Lightning")]
        UnaffectedByConductivityWhileAffectedByPurityOfLightning = 7228,
        [Description("Unaffected By Elemental Weakness While Affected By Purity Of Elements")]
        UnaffectedByElementalWeaknessWhileAffectedByPurityOfElements = 7229,
        [Description("Reduce Enemy Cold Resistance % While Affected By Hatred")]
        ReduceEnemyColdResistancePctWhileAffectedByHatred = 7230,
        [Description("Reduce Enemy Fire Resistance % While Affected By Anger")]
        ReduceEnemyFireResistancePctWhileAffectedByAnger = 7231,
        [Description("Reduce Enemy Lightning Resistance % While Affected By Wrath")]
        ReduceEnemyLightningResistancePctWhileAffectedByWrath = 7232,
        [Description("Energy Shield Regeneration Rate Per Minute % While Affected By Discipline")]
        EnergyShieldRegenerationRatePerMinutePctWhileAffectedByDiscipline = 7233,
        [Description("Chance To Block Spells % While Affected By Discipline")]
        ChanceToBlockSpellsPctWhileAffectedByDiscipline = 7234,
        [Description("Energy Shield Delay -% While Affected By Discipline")]
        EnergyShieldDelayNegPctWhileAffectedByDiscipline = 7235,
        [Description("Energy Shield Gain Per Target Hit While Affected By Discipline")]
        EnergyShieldGainPerTargetHitWhileAffectedByDiscipline = 7236,
        [Description("Mana Leech From Lightning Damage Permyriad While Affected By Wrath")]
        ManaLeechFromLightningDamagePermyriadWhileAffectedByWrath = 7237,
        [Description("Physical Damage % To Add As Lightning Damage While Affected By Wrath")]
        PhysicalDamagePctToAddAsLightningDamageWhileAffectedByWrath = 7238,
        [Description("Base Physical Damage % To Convert To Lightning While Affected By Wrath")]
        BasePhysicalDamagePctToConvertToLightningWhileAffectedByWrath = 7239,
        [Description("Virtual Non Skill Physical Damage % To Convert To Fire")]
        VirtualNonSkillPhysicalDamagePctToConvertToFire = 7240,
        [Description("Virtual Non Skill Physical Damage % To Convert To Cold")]
        VirtualNonSkillPhysicalDamagePctToConvertToCold = 7241,
        [Description("Virtual Non Skill Physical Damage % To Convert To Lightning")]
        VirtualNonSkillPhysicalDamagePctToConvertToLightning = 7242,
        [Description("Virtual Non Skill Physical Damage % To Convert To Chaos")]
        VirtualNonSkillPhysicalDamagePctToConvertToChaos = 7243,
        [Description("Virtual Non Skill Lightning Damage % To Convert To Fire")]
        VirtualNonSkillLightningDamagePctToConvertToFire = 7244,
        [Description("Virtual Non Skill Lightning Damage % To Convert To Cold")]
        VirtualNonSkillLightningDamagePctToConvertToCold = 7245,
        [Description("Virtual Non Skill Lightning Damage % To Convert To Chaos")]
        VirtualNonSkillLightningDamagePctToConvertToChaos = 7246,
        [Description("Virtual Non Skill Cold Damage % To Convert To Fire")]
        VirtualNonSkillColdDamagePctToConvertToFire = 7247,
        [Description("Virtual Non Skill Cold Damage % To Convert To Chaos")]
        VirtualNonSkillColdDamagePctToConvertToChaos = 7248,
        [Description("Virtual Non Skill Fire Damage % To Convert To Chaos")]
        VirtualNonSkillFireDamagePctToConvertToChaos = 7249,
        [Description("Base Physical Damage % To Convert To Fire While Affected By Anger")]
        BasePhysicalDamagePctToConvertToFireWhileAffectedByAnger = 7250,
        [Description("Physical Damage % To Add As Fire Damage While Affected By Anger")]
        PhysicalDamagePctToAddAsFireDamageWhileAffectedByAnger = 7251,
        [Description("Life Leech From Fire Damage Permyriad While Affected By Anger")]
        LifeLeechFromFireDamagePermyriadWhileAffectedByAnger = 7252,
        [Description("Minimum Added Cold Damage While Affected By Hatred")]
        MinimumAddedColdDamageWhileAffectedByHatred = 7253,
        [Description("Maximum Added Cold Damage While Affected By Hatred")]
        MaximumAddedColdDamageWhileAffectedByHatred = 7254,
        [Description("Base Physical Damage % To Convert To Cold While Affected By Hatred")]
        BasePhysicalDamagePctToConvertToColdWhileAffectedByHatred = 7255,
        [Description("Additional Critical Strike Chance Permyriad While Affected By Hatred")]
        AdditionalCriticalStrikeChancePermyriadWhileAffectedByHatred = 7256,
        [Description("Life Leech From Any Damage Permyriad While Affected By Vitality")]
        LifeLeechFromAnyDamagePermyriadWhileAffectedByVitality = 7257,
        [Description("Life Regeneration Per Minute While Affected By Vitality")]
        LifeRegenerationPerMinuteWhileAffectedByVitality = 7258,
        [Description("Life Recovery Rate +% While Affected By Vitality")]
        LifeRecoveryRatePosPctWhileAffectedByVitality = 7259,
        [Description("Life Gain Per Target Hit While Affected By Vitality")]
        LifeGainPerTargetHitWhileAffectedByVitality = 7260,
        [Description("Virtual Skill Mana Cost +")]
        VirtualSkillManaCostPos = 7261,
        [Description("Skill Mana Cost + While Affected By Clarity")]
        SkillManaCostPosWhileAffectedByClarity = 7262,
        [Description("Damage Removed From Mana Before Life % While Affected By Clarity")]
        DamageRemovedFromManaBeforeLifePctWhileAffectedByClarity = 7263,
        [Description("Recover 10% Mana On Skill Use % Chance While Affected By Clarity")]
        Recover10PctManaOnSkillUsePctChanceWhileAffectedByClarity = 7264,
        [Description("Maximum Mana % To Add To Energy Shield While Affected By Clarity")]
        MaximumManaPctToAddToEnergyShieldWhileAffectedByClarity = 7265,
        [Description("Chance To Dodge Spells % While Affected By Haste")]
        ChanceToDodgeSpellsPctWhileAffectedByHaste = 7266,
        [Description("Gain Onslaught On Kill Ms While Affected By Haste")]
        GainOnslaughtOnKillMsWhileAffectedByHaste = 7267,
        [Description("Gain Phasing While Affected By Haste")]
        GainPhasingWhileAffectedByHaste = 7268,
        [Description("Physical Damage Taken % As Fire While Affected By Purity Of Fire")]
        PhysicalDamageTakenPctAsFireWhileAffectedByPurityOfFire = 7269,
        [Description("Physical Damage Taken % As Cold While Affected By Purity Of Ice")]
        PhysicalDamageTakenPctAsColdWhileAffectedByPurityOfIce = 7270,
        [Description("Physical Damage Taken % As Lightning While Affected By Purity Of Lightning")]
        PhysicalDamageTakenPctAsLightningWhileAffectedByPurityOfLightning = 7271,
        [Description("Physical Damage Taken % As Fire While Affected By Purity Of Elements")]
        PhysicalDamageTakenPctAsFireWhileAffectedByPurityOfElements = 7272,
        [Description("Physical Damage Taken % As Cold While Affected By Purity Of Elements")]
        PhysicalDamageTakenPctAsColdWhileAffectedByPurityOfElements = 7273,
        [Description("Physical Damage Taken % As Lightning While Affected By Purity Of Elements")]
        PhysicalDamageTakenPctAsLightningWhileAffectedByPurityOfElements = 7274,
        [Description("Immune To Ignite While Affected By Purity Of Fire")]
        ImmuneToIgniteWhileAffectedByPurityOfFire = 7275,
        [Description("Immune To Freeze While Affected By Purity Of Ice")]
        ImmuneToFreezeWhileAffectedByPurityOfIce = 7276,
        [Description("Immune To Shock While Affected By Purity Of Lightning")]
        ImmuneToShockWhileAffectedByPurityOfLightning = 7277,
        [Description("Virtual Physical Damage Taken % As Fire")]
        VirtualPhysicalDamageTakenPctAsFire = 7278,
        [Description("Virtual Physical Damage Taken % As Cold")]
        VirtualPhysicalDamageTakenPctAsCold = 7279,
        [Description("Virtual Physical Damage Taken % As Lightning")]
        VirtualPhysicalDamageTakenPctAsLightning = 7280,
        [Description("Disable Rarity Epk")]
        DisableRarityEpk = 7281,
        [Description("Cannot Spawn Support Ghosts")]
        CannotSpawnSupportGhosts = 7282,
        [Description("Chance To Gain Frenzy Charge On Block %")]
        ChanceToGainFrenzyChargeOnBlockPct = 7283,
        [Description("Spell Damage +% Per 10 Strength")]
        SpellDamagePosPctPer10Strength = 7284,
        [Description("Spell Damage +% Per 16 Dex")]
        SpellDamagePosPctPer16Dex = 7285,
        [Description("Spell Damage +% Per 16 Strength")]
        SpellDamagePosPctPer16Strength = 7286,
        [Description("Spell Damage +% Per 16 Int")]
        SpellDamagePosPctPer16Int = 7287,
        [Description("Deal No Non Elemental Damage")]
        DealNoNonElementalDamage = 7288,
        [Description("Cast Speed +% If Enemy Killed Recently")]
        CastSpeedPosPctIfEnemyKilledRecently = 7289,
        [Description("Trigger On Skill Use % If You Have A Spirit Charge")]
        TriggerOnSkillUsePctIfYouHaveASpiritCharge = 7290,
        [Description("Map Force Private Seed Debug")]
        MapForcePrivateSeedDebug = 7291,
        [Description("Active Skill Display Aegis Variation")]
        ActiveSkillDisplayAegisVariation = 7292,
        [Description("Volatile Dead Number Of Corpses To Consume")]
        VolatileDeadNumberOfCorpsesToConsume = 7293,
        [Description("Unearth Additional Corpse Level")]
        UnearthAdditionalCorpseLevel = 7294,
        [Description("Unearth Corpse Level")]
        UnearthCorpseLevel = 7295,
        [Description("Corpse Erruption Maximum Number Of Geyers")]
        CorpseErruptionMaximumNumberOfGeyers = 7296,
        [Description("Base Number Of Effigies Allowed")]
        BaseNumberOfEffigiesAllowed = 7297,
        [Description("Visual Attached Elder Tentacles")]
        VisualAttachedElderTentacles = 7298,
        [Description("Map Elder Influence Additional Packs Of Elder Monsters")]
        MapElderInfluenceAdditionalPacksOfElderMonsters = 7299,
        [Description("Bone Lance Damage +%")]
        BoneLanceDamagePosPct = 7300,
        [Description("Corpse Eruption Damage +%")]
        CorpseEruptionDamagePosPct = 7301,
        [Description("Volatile Dead Damage +%")]
        VolatileDeadDamagePosPct = 7302,
        [Description("Corpse Warp Damage +%")]
        CorpseWarpDamagePosPct = 7303,
        [Description("Bone Lance Cast Speed +%")]
        BoneLanceCastSpeedPosPct = 7304,
        [Description("Corpse Eruption Cast Speed +%")]
        CorpseEruptionCastSpeedPosPct = 7305,
        [Description("Volatile Dead Cast Speed +%")]
        VolatileDeadCastSpeedPosPct = 7306,
        [Description("Corpse Warp Cast Speed +%")]
        CorpseWarpCastSpeedPosPct = 7307,
        [Description("Display Attack Block Chance")]
        DisplayAttackBlockChance = 7308,
        [Description("Display Spell Block Chance")]
        DisplaySpellBlockChance = 7309,
        [Description("Minimum Added Chaos Damage Taken")]
        MinimumAddedChaosDamageTaken = 7310,
        [Description("Maximum Added Chaos Damage Taken")]
        MaximumAddedChaosDamageTaken = 7311,
        [Description("Chance To Be Maimed When Hit %")]
        ChanceToBeMaimedWhenHitPct = 7312,
        [Description("Energy Shield Gained On Spell Hit")]
        EnergyShieldGainedOnSpellHit = 7313,
        [Description("Monster Spirit Charges Are Infinite")]
        MonsterSpiritChargesAreInfinite = 7314,
        [Description("Gain Spirit Charge On Kill % Chance")]
        GainSpiritChargeOnKillPctChance = 7315,
        [Description("Gain % Life When Spirit Charge Expires Or Consumed")]
        GainPctLifeWhenSpiritChargeExpiresOrConsumed = 7316,
        [Description("Local Display Trigger Level X Spirit Burst On Skill Use If Have Spirit Charge")]
        LocalDisplayTriggerLevelXSpiritBurstOnSkillUseIfHaveSpiritCharge = 7317,
        [Description("Maximum Spirit Charges Per Abyss Jewel Equipped")]
        MaximumSpiritChargesPerAbyssJewelEquipped = 7318,
        [Description("Local Display Socketed Gems Supported By Level X Elemental Penetration")]
        LocalDisplaySocketedGemsSupportedByLevelXElementalPenetration = 7319,
        [Description("Skill Used By Mirage Archer")]
        SkillUsedByMirageArcher = 7320,
        [Description("Support Mirage Archer Attack Speed +% Final")]
        SupportMirageArcherAttackSpeedPosPctFinal = 7321,
        [Description("Virtual Maximum Spirit Charges")]
        VirtualMaximumSpiritCharges = 7322,
        [Description("Gain Debilitating Presence Ms On Kill Vs Rare Or Unique Enemy")]
        GainDebilitatingPresenceMsOnKillVsRareOrUniqueEnemy = 7323,
        [Description("Cast Speed +% From Grasping Tentacles")]
        CastSpeedPosPctFromGraspingTentacles = 7324,
        [Description("Charge Elder Art Variation")]
        ChargeElderArtVariation = 7325,
        [Description("Virtual Projectile Additional Height Offset")]
        VirtualProjectileAdditionalHeightOffset = 7326,
        [Description("Local Display Trigger Level 20 Shade Form On Skill Use %")]
        LocalDisplayTriggerLevel20ShadeFormOnSkillUsePct = 7327,
        [Description("Mirage Archer Projectile Additional Height Offset")]
        MirageArcherProjectileAdditionalHeightOffset = 7328,
        [Description("Minimum Added Physical Damage Per Endurance Charge")]
        MinimumAddedPhysicalDamagePerEnduranceCharge = 7329,
        [Description("Maximum Added Physical Damage Per Endurance Charge")]
        MaximumAddedPhysicalDamagePerEnduranceCharge = 7330,
        [Description("Chaos Damage Resistance % Per Endurance Charge")]
        ChaosDamageResistancePctPerEnduranceCharge = 7331,
        [Description("Elemental Damage Taken From Hits +% Per Endurance Charge")]
        ElementalDamageTakenFromHitsPosPctPerEnduranceCharge = 7332,
        [Description("Physical Damage Reduction Rating Per Endurance Charge")]
        PhysicalDamageReductionRatingPerEnduranceCharge = 7333,
        [Description("Fire Damage Taken Per Minute Per Endurance Charge If You Have Been Hit Recently")]
        FireDamageTakenPerMinutePerEnduranceChargeIfYouHaveBeenHitRecently = 7334,
        [Description("Minimum Added Lightning Damage To Spells Per Power Charge")]
        MinimumAddedLightningDamageToSpellsPerPowerCharge = 7335,
        [Description("Maximum Added Lightning Damage To Spells Per Power Charge")]
        MaximumAddedLightningDamageToSpellsPerPowerCharge = 7336,
        [Description("Additional Spell Block % Per Power Charge")]
        AdditionalSpellBlockPctPerPowerCharge = 7337,
        [Description("Lightning Damage Taken Per Minute Per Power Charge If Have Crit Recently")]
        LightningDamageTakenPerMinutePerPowerChargeIfHaveCritRecently = 7338,
        [Description("Avoid Elemental Damage % Per Frenzy Charge")]
        AvoidElementalDamagePctPerFrenzyCharge = 7339,
        [Description("Life Leech From Attack Damage Permyriad Per Frenzy Charge")]
        LifeLeechFromAttackDamagePermyriadPerFrenzyCharge = 7340,
        [Description("Cold Damage Taken Per Minute Per Frenzy Charge While Moving")]
        ColdDamageTakenPerMinutePerFrenzyChargeWhileMoving = 7341,
        [Description("Raise Spectre Mana Cost +%")]
        RaiseSpectreManaCostPosPct = 7342,
        [Description("Map Packs Have Tentacle Minions")]
        MapPacksHaveTentacleMinions = 7343,
        [Description("Map Elder Influence Spawn Daemon")]
        MapElderInfluenceSpawnDaemon = 7344,
        [Description("Monster Has Oni Goroshi")]
        MonsterHasOniGoroshi = 7345,
        [Description("Skill User Maximum Life")]
        SkillUserMaximumLife = 7346,
        [Description("Local Display Grant Level X Petrification Statue")]
        LocalDisplayGrantLevelXPetrificationStatue = 7347,
        [Description("Petrification Statue Gaze Action Speed -% Per Stack")]
        PetrificationStatueGazeActionSpeedNegPctPerStack = 7348,
        [Description("Chest Display Guarded By Dario")]
        ChestDisplayGuardedByDario = 7349,
        [Description("Base Physical Damage Over Time Taken +%")]
        BasePhysicalDamageOverTimeTakenPosPct = 7350,
        [Description("Ground Spores Art Variation")]
        GroundSporesArtVariation = 7351,
        [Description("Move Daemon Use Random Direction")]
        MoveDaemonUseRandomDirection = 7352,
        [Description("Disable Skill If Weapon Not Bow")]
        DisableSkillIfWeaponNotBow = 7353,
        [Description("Trigger On Skill Use From Chest %")]
        TriggerOnSkillUseFromChestPct = 7354,
        [Description("Thrown Weapon On Return Trigger Skills With Id")]
        ThrownWeaponOnReturnTriggerSkillsWithId = 7355,
        [Description("Thrown Weapon On Return Trigger Id")]
        ThrownWeaponOnReturnTriggerId = 7356,
        [Description("Thrown Weapon On Return Trigger %")]
        ThrownWeaponOnReturnTriggerPct = 7357,
        [Description("Skill Cannot Be Interrupted")]
        SkillCannotBeInterrupted = 7358,
        [Description("Skill Cannot Be Stunned")]
        SkillCannotBeStunned = 7359,
        [Description("Skill Cannot Be Knocked Back")]
        SkillCannotBeKnockedBack = 7360,
        [Description("Is Immobilised By Elder")]
        IsImmobilisedByElder = 7361,
        [Description("Recover % Maximum Life On Mana Flask Use")]
        RecoverPctMaximumLifeOnManaFlaskUse = 7362,
        [Description("Non Instant Mana Recovery From Flasks Also Recovers Life")]
        NonInstantManaRecoveryFromFlasksAlsoRecoversLife = 7363,
        [Description("Spell Damage +% Per 200 Mana Spent Recently")]
        SpellDamagePosPctPer200ManaSpentRecently = 7364,
        [Description("Mana Cost +% Per 200 Mana Spent Recently")]
        ManaCostPosPctPer200ManaSpentRecently = 7365,
        [Description("Virtual Track Mana Spent Recently")]
        VirtualTrackManaSpentRecently = 7366,
        [Description("Total Mana Spent Recently")]
        TotalManaSpentRecently = 7367,
        [Description("Left Ring Is Shaper Item")]
        LeftRingIsShaperItem = 7368,
        [Description("Left Ring Is Elder Item")]
        LeftRingIsElderItem = 7369,
        [Description("Right Ring Is Shaper Item")]
        RightRingIsShaperItem = 7370,
        [Description("Right Ring Is Elder Item")]
        RightRingIsElderItem = 7371,
        [Description("Cannot Be Stunned By Attacks If Other Ring Is Elder Item")]
        CannotBeStunnedByAttacksIfOtherRingIsElderItem = 7372,
        [Description("Cannot Be Stunned By Attacks If Left Ring Is Elder Item")]
        CannotBeStunnedByAttacksIfLeftRingIsElderItem = 7373,
        [Description("Cannot Be Stunned By Attacks If Right Ring Is Elder Item")]
        CannotBeStunnedByAttacksIfRightRingIsElderItem = 7374,
        [Description("Attack Damage +% If Other Ring Is Shaper Item")]
        AttackDamagePosPctIfOtherRingIsShaperItem = 7375,
        [Description("Attack Damage +% If Left Ring Is Shaper Item")]
        AttackDamagePosPctIfLeftRingIsShaperItem = 7376,
        [Description("Attack Damage +% If Right Ring Is Shaper Item")]
        AttackDamagePosPctIfRightRingIsShaperItem = 7377,
        [Description("Spell Damage +% If Other Ring Is Elder Item")]
        SpellDamagePosPctIfOtherRingIsElderItem = 7378,
        [Description("Spell Damage +% If Left Ring Is Elder Item")]
        SpellDamagePosPctIfLeftRingIsElderItem = 7379,
        [Description("Spell Damage +% If Right Ring Is Elder Item")]
        SpellDamagePosPctIfRightRingIsElderItem = 7380,
        [Description("Cannot Be Stunned By Spells If Other Ring Is Shaper Item")]
        CannotBeStunnedBySpellsIfOtherRingIsShaperItem = 7381,
        [Description("Cannot Be Stunned By Spells If Left Ring Is Shaper Item")]
        CannotBeStunnedBySpellsIfLeftRingIsShaperItem = 7382,
        [Description("Cannot Be Stunned By Spells If Right Ring Is Shaper Item")]
        CannotBeStunnedBySpellsIfRightRingIsShaperItem = 7383,
        [Description("Current Siphoning Charges")]
        CurrentSiphoningCharges = 7384,
        [Description("Virtual Maximum Siphoning Charges")]
        VirtualMaximumSiphoningCharges = 7385,
        [Description("Gain Siphoning Charge On Skill Use % Chance")]
        GainSiphoningChargeOnSkillUsePctChance = 7386,
        [Description("Maximum Siphoning Charges Per Elder Or Shaper Item Equipped")]
        MaximumSiphoningChargesPerElderOrShaperItemEquipped = 7387,
        [Description("Attack Minimum Added Physical Damage Per Siphoning Charge")]
        AttackMinimumAddedPhysicalDamagePerSiphoningCharge = 7388,
        [Description("Attack Maximum Added Physical Damage Per Siphoning Charge")]
        AttackMaximumAddedPhysicalDamagePerSiphoningCharge = 7389,
        [Description("Spell Minimum Added Physical Damage Per Siphoning Charge")]
        SpellMinimumAddedPhysicalDamagePerSiphoningCharge = 7390,
        [Description("Spell Maximum Added Physical Damage Per Siphoning Charge")]
        SpellMaximumAddedPhysicalDamagePerSiphoningCharge = 7391,
        [Description("Life Leech From Any Damage Permyriad Per Siphoning Charge")]
        LifeLeechFromAnyDamagePermyriadPerSiphoningCharge = 7392,
        [Description("Non Chaos Damage % To Add As Chaos Damage Per Siphoning Charge")]
        NonChaosDamagePctToAddAsChaosDamagePerSiphoningCharge = 7393,
        [Description("Additional Physical Damage Reduction Against Hits % Per Siphoning Charge")]
        AdditionalPhysicalDamageReductionAgainstHitsPctPerSiphoningCharge = 7394,
        [Description("Additional Physical Damage Reduction % Against Hits")]
        AdditionalPhysicalDamageReductionPctAgainstHits = 7395,
        [Description("Armour Differs Against Hits")]
        ArmourDiffersAgainstHits = 7396,
        [Description("Display Estimated Physical Damage Reduction Against Hits %")]
        DisplayEstimatedPhysicalDamageReductionAgainstHitsPct = 7397,
        [Description("Physical Damage Taken Per Minute Per Siphoning Charge If Have Used A Skill Recently")]
        PhysicalDamageTakenPerMinutePerSiphoningChargeIfHaveUsedASkillRecently = 7398,
        [Description("Track Have Used A Skill Recently")]
        TrackHaveUsedASkillRecently = 7399,
        [Description("Have Used A Skill Recently")]
        HaveUsedASkillRecently = 7400,
        [Description("Number Of Equipped Shaper Items")]
        NumberOfEquippedShaperItems = 7401,
        [Description("Virtual Physical Damage Taken Per Minute Per Siphoning Charge")]
        VirtualPhysicalDamageTakenPerMinutePerSiphoningCharge = 7402,
        [Description("Map Force Terrain Feature")]
        MapForceTerrainFeature = 7403,
        [Description("Volatile Dead Consume Additional Corpse")]
        VolatileDeadConsumeAdditionalCorpse = 7404,
        [Description("Projectile Skill Dot Ground Caustic Area Damage Per Minute")]
        ProjectileSkillDotGroundCausticAreaDamagePerMinute = 7405,
        [Description("Trigger Level X Void Shot On Arrow Fire While You Have Void Arrow")]
        TriggerLevelXVoidShotOnArrowFireWhileYouHaveVoidArrow = 7406,
        [Description("Trigger On Skill Use % If You Have A Void Arrow")]
        TriggerOnSkillUsePctIfYouHaveAVoidArrow = 7407,
        [Description("Current Void Arrows")]
        CurrentVoidArrows = 7408,
        [Description("Maximum Void Arrows")]
        MaximumVoidArrows = 7409,
        [Description("Local Display Grant Void Arrow Every X Ms")]
        LocalDisplayGrantVoidArrowEveryXMs = 7410,
        [Description("Cannot Be Stunned By Spells")]
        CannotBeStunnedBySpells = 7411,
        [Description("Cannot Be Stunned By Attacks")]
        CannotBeStunnedByAttacks = 7412,
        [Description("Virtual Chance To Evade Attacks %")]
        VirtualChanceToEvadeAttacksPct = 7413,
        [Description("Despair Duration +%")]
        DespairDurationPosPct = 7414,
        [Description("Despair Curse Effect +%")]
        DespairCurseEffectPosPct = 7415,
    }
}
