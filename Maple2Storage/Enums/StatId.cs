﻿namespace Maple2Storage.Enums;

// Player Stats in Packet Order - Count: 35 (0x23)
public enum StatId : byte
{
    Str = 0,
    Dex = 1,
    Int = 2,
    Luk = 3,
    Hp = 4,
    HpRegen = 5,
    HpRegenInterval = 6,
    Spirit = 7,
    SpRegen = 8,
    SpRegenInterval = 9,
    Stamina = 10,
    StaminaRegen = 11,
    StaminaRegenInterval = 12,
    AttackSpeed = 13,
    MovementSpeed = 14,
    Accuracy = 15,
    Evasion = 16,
    CritRate = 17,
    CritDamage = 18,
    CritEvasion = 19,
    Defense = 20,
    PerfectGuard = 21,
    JumpHeight = 22,
    PhysicalAtk = 23,
    MagicAtk = 24,
    PhysicalRes = 25,
    MagicRes = 26,
    MinWeaponAtk = 27,
    MaxWeaponAtk = 28,
    MinDamage = 29,
    MaxDamage = 30,
    Pierce = 31,
    MountMovementSpeed = 32,
    BonusAtk = 33,
    PetBonusAtk = 34,
}

public enum SpecialStatId : short
{
    None = 0,
    ExpBonus = 1,
    MesoBonus = 2,
    SwimSpeed = 3,
    DashDistance = 4,
    TonicDropRate = 5,
    GearDropRate = 6,
    TotalDamage = 7,
    CriticalDamage = 8,
    Damage = 9,
    LeaderDamage = 10,
    EliteDamage = 11,
    BossDamage = 12, // This is actually used in conjunction with "sgi_target" in the XMLs. It's not boss damage, it's for a specified monster type. Currently ignoring it and just using it as boss damage, as nothing in the data uses it for non-boss mobs
    HpOnKill = 13,
    SpiritOnKill = 14,
    StaminaOnKill = 15,
    Heal = 16,
    AllyRecovery = 17,
    IceDamage = 18,
    FireDamage = 19,
    DarkDamage = 20,
    HolyDamage = 21,
    PoisonDamage = 22,
    ElectricDamage = 23,
    MeleeDamage = 24,
    RangedDamage = 25,
    PhysicalPiercing = 26,
    MagicPiercing = 27,
    IceDamageReduce = 28,
    FireDamageReduce = 29,
    DarkDamageReduce = 30,
    HolyDamageReduce = 31,
    PoisonDamageReduce = 32,
    ElectricDamageReduce = 33,
    StunReduce = 34,
    CooldownReduce = 35,
    DebuffDurationReduce = 36,
    MeleeDamageReduce = 37,
    RangedDamageReduce = 38,
    KnockbackReduce = 39,
    MeleeStun = 40, //melee chance to stun
    MeeleeKnockback = 42, //chance of knockback after meele att
    RangedKnockback = 43, //chance of knockback after ranged att
    RangedImmob = 45, //ranged chance to immob
    MeleeAoeDamage = 46, //melee chance to do aoe damage
    RangedAoeDamage = 47, //ranged chance to do aoe damage
    DropRate = 48,
    QuestExp = 49,
    QuestMeso = 50,
    PvPDamage = 54,
    PvPDefense = 55,
    GuildExp = 56,
    GuildCoin = 57,
    McKayXpOrb = 58, //mc-kay experience orb value bonus
    FishingExp = 59,
    ArcadeExp = 60,
    PerformanceExp = 61,
    AssistantMood = 62, //assistant mood improvement rate
    AssistantDiscount = 63,
    BlackMarketReduce = 64,
    EnchantCatalystDiscount = 65,
    MeretReviveFee = 66,
    MiningBonus = 67,
    RanchingBonus = 68,
    SmithingExp = 69,
    HandicraftMastery = 70,
    ForagingBonus = 71,
    FarmingBonus = 72,
    AlchemyMastery = 73,
    CookingMastery = 74,
    ForagingExp = 75,
    CraftingExp = 76,

    //techs
    TECH = 77, //level 1 skill
    TECH_2 = 78, //2nd level 1 skill
    TECH_10 = 79, //lv 10 skill
    TECH_13 = 80, //lv 13 skill
    TECH_19 = 81, // lv 16 skill
    TECH_22 = 82, // lv 19 skill
    TECH_3 = 83, // lv 22 skill
    TECH_25 = 84, // lv 25 skill
    TECH_28 = 85, // lv 28 skill
    TECH_31 = 86, // lv 31 skill
    TECH_34 = 87, // lv 34 skill
    TECH_37 = 88, // lv 37 skill
    TECH_40 = 89, // lv 40 skill
    TECH_43 = 90, // lv 43 skill

    OXQuizExp = 91,
    TrapMasterExp = 92,
    SoleSurvivorExp = 93,
    CrazyRunnerExp = 94,
    LudiEscapeExp = 95,
    SpringBeachExp = 96,
    DanceDanceExp = 97,
    OXMovementSpeed = 98,
    TrapMasterMovementSpeed = 99,
    SoleSurvivorMovementSpeed = 100,
    CrazyRunnerMovementSpeed = 101,
    LudiEscapeMovementSpeed = 102,
    SpringBeachMovementSpeed = 103,
    DanceDanceStopMovementSpeed = 104,
    GenerateSpiritOrbs = 105,
    GenerateStaminaOrbs = 106,
    ValorTokens = 107,
    PvPExp = 108,
    DarkDescentDamageBonus = 109,
    DarkDescentDamageReduce = 110,
    DarkDescentEvasion = 111,
    DoubleFishingMastery = 112,
    DoublePerformanceMastery = 113,
    ExploredAreasMovementSpeed = 114,
    AirMountAscentSpeed = 115,
    EnemyDefenseDecreaseOnHit = 117,
    EnemyAttackDecreaseOnHit = 118,
    IncreaseTotalDamageIf1NearbyEnemy = 119, // Increases damage if there is an enemy within 5m
    IncreaseTotalDamageIf3NearbyEnemies = 120, // Increases damage if there is at least 3 enemies within 5m
    IncreaseTotalDamageIf80Spirit = 121, // Increase damage if you have 80 or more spirit
    IncreaseTotalDamageIfFullStamina = 122,
    IncreaseTotalDamageIfHerbEffectActive = 123, // Increase damage if you have a herb-like effect active
    IncreaseTotalDamageToWorldBoss = 124,
    Effect95000026 = 125,
    Effect95000027 = 126,
    Effect95000028 = 127,
    Effect95000029 = 128,
    StaminaRecoverySpeed = 129,
    MaxWeaponAttack = 130,
    DoubleMiningProduction = 131,
    DoubleRanchingProduction = 132,
    DoubleForagingProduction = 133,
    DoubleFarmingProduction = 134,
    DoubleSmithingProduction = 135,
    DoubleHandicraftProduction = 136,
    DoubleAlchemyProduction = 137,
    DoubleCookingProduction = 138,
    DoubleMiningMastery = 139,
    DoubleRanchingMastery = 140,
    DoubleForagingMastery = 141,
    DoubleFarmingMastery = 142,
    DoubleSmithingMastery = 143,
    DoubleHandicraftMastery = 144,
    DoubleAlchemyMastery = 145,
    DoubleCookingMastery = 146,
    ChaosRaidWeaponAttack = 147,
    ChaosRaidAttackSpeed = 148,
    ChaosRaidAccuracy = 149,
    ChaosRaidHealth = 150,
    StaminaAndSpiritFromOrbs = 151,
    WorldBossExp = 152,
    WorldBossDropRate = 153,
    WorldBossDamageReduce = 154,
    Effect9500016 = 155,
    PetCaptureRewards = 156,
    MiningEfficency = 157,
    RanchingEfficiency = 158,
    ForagingEfficiency = 159,
    FarmingEfficiency = 160,
    ShanghaiCrazyRunnersExp = 161,
    ShanghaiCrazyRunnersMovementSpeed = 162,
    HealthBasedDamageReduce = 163
}