using Newtonsoft.Json;
using System.Collections.Generic;

namespace App.Data
{
    [System.Serializable]
    public class WeaponConfig : BaseItemConfig
    {
        public string weaponClass { get; set; }
        public string weaponSubClass { get; set; }
        public float spawnRatioRelativeToOthers { get; set; }
        public int maxRarity { get; set; }
        public int minRarity { get; set; }
        public int maxRarityWorld { get; set; }
        public float moveSpeedMult { get; set; }
        public float moveSpeedMultAttack { get; set; }
        public float damageNormal { get; set; }
        public int breaksArmorAmount { get; set; }
        public float damageThroughArmor { get; set; }
        public float shotInterval { get; set; }
        public bool canHoldFire { get; set; }
        public float meleeStabTime { get; set; }
        public string attackSound { get; set; }
        public int attackSoundVariations { get; set; }
        public float attackSoundRange { get; set; }
        public string spineAttachmentKey { get; set; }
        public string spineAimAnimKey { get; set; }
        public string spineAtkAnimKey { get; set; }
        public string spineBulletBone { get; set; }
        public string meleeClangSound { get; set; }
        public string meleeWoodSound { get; set; }
        public string meleeBushSound { get; set; }
        public string equipSound { get; set; }

        public float overrideBreaksVehicleAmount { get; set; }
        public bool useCosmeticsAnimTrack { get; set; }
        public int fishing { get; set; }
        public int bugs { get; set; }
        public bool emuSummon { get; set; }

        public float damageFar { get; set; }
        public float addedDamagePerRarity { get; set; }
        public float addedDamagePerRarityFar { get; set; }
        public float bulletRangeBase { get; set; }
        public float bulletRangeAddedPerRarity { get; set; }
        public int clipSize { get; set; }
        public float reloadTime { get; set; }
        public string reloadSound { get; set; }
        public string reloadSpineAnimKey { get; set; }
        public bool reloadGoesAimInstantly { get; set; }
        public int ammoID { get; set; }
        public int ammoSpawnAmount { get; set; }
        public float bananafiedChance { get; set; }
        public int bulletsPerShot { get; set; }
        public float bulletSpreadDegreesMax { get; set; }
        public float bulletSpreadDegreesLessPerRarity { get; set; }
        public float bulletSpreadAddWhileCreeping { get; set; }
        public float bulletSpreadAddWhileRunning { get; set; }
        public float[] bulletSpreadOffsetsPerShot { get; set; }
        public float bulletSpreadOffsetsMovePercentAddition { get; set; }
        public float bulletSpreadOffsetsResetTime { get; set; }
        public float bulletSpreadOffsetsRandomDeg { get; set; }
        public float bulletSpreadOffsetsCustomModesMult { get; set; }
        public float bulletMoveSpeed { get; set; }
        public float bulletMoveSpeedAddedPerRarity { get; set; }
        public float recoilDegStartDefault { get; set; }
        public float recoilDegStartCreeping { get; set; }
        public float recoilDegStartRunning { get; set; }
        public float recoilDegAddPerShotLow { get; set; }
        public float recoilDegAddPerShotHigh { get; set; }
        public float recoilDegMax { get; set; }
        public float recoilDegResetRatePerS { get; set; }
        public float recoilDegResetRateCreepPerS { get; set; }
        public float recoilDegResetRateRunningPerS { get; set; }
        public float recoilRollMinSpread { get; set; }
        public float recoilCreepRollMinSpread { get; set; }
        public int lowAmmoSoundLoudness { get; set; }

        [JsonConverter(typeof(WeaponJsonConverter.SoundSkinCustomListConverter))]
        public List<SoundSkinCustom> attackSoundSkinCustom { get; set; } = new();

        [JsonConverter(typeof(WeaponJsonConverter.SkinSoundPairListConverter))]
        public List<SkinSoundPair> reloadSoundSkinCustom { get; set; } = new();

        [JsonConverter(typeof(WeaponJsonConverter.SlotAttachmentListConverter))]
        public List<SlotAttachment> spineSlotsAttachmentsRegions { get; set; } = new();

        public List<string> skinNames { get; set; } = new();
        public List<string> skinNamesAlt { get; set; } = new();
        public List<string> skinNames2 { get; set; } = new();
        public bool skin2IsLocal { get; set; }
        public float bulletSpawnInset { get; set; }
        public string muzzleFlash { get; set; }
        public Dictionary<string, string> muzzleFlashSkins { get; set; } = new();
        public List<string> shootEffects { get; set; } = new();
        public bool hideMuzzleGlow { get; set; }
        public string customProjectile { get; set; }
        public string customProjectileBounce { get; set; }
        public string customProjectileImpact { get; set; }
        public bool noProjectileObjectImpact { get; set; }
        public int projectileOverrideSparkEffectType { get; set; }
        public Dictionary<string, int> projectileOverrideSparkEffectSkins { get; set; } = new();
        public Dictionary<string, string> projectileSkins { get; set; } = new();
        public float creepZoom { get; set; }
        public float windupTime { get; set; }
        public float winddownTime { get; set; }
        public string windupSound { get; set; }
        public string winddownSound { get; set; }
        public string spineWindupAnimKey { get; set; }
        public string spineWinddownAnimKey { get; set; }
        public string spineWindedLoopAnimKey { get; set; }
        public bool windupIsHoldAndRelease { get; set; }
        public bool shootAutoReloads { get; set; }
        public bool windupAffectsDistAndSpeed { get; set; }
        public float windupMinDamagePercent { get; set; }
        public bool attackAnimForceNoLoop { get; set; }
        public bool canBeMysteryModeBanana { get; set; }
        public bool moveSpeedMultAttackIncludeRoll { get; set; }
        public string spineAtkAlternateAnimKey { get; set; }
        public string spineBulletBoneAlternate { get; set; }
        public string spineAimAnimNoAmmoKey { get; set; }
        public bool spineAimUseLowWeapBone { get; set; }
        public float spawnWeightCaches { get; set; }
        public float spawnWeightCachesTeamGames { get; set; }
        public float spawnWeightClams { get; set; }
        public float spawnFactorInfection { get; set; }
        public string spineLootSkin { get; set; }
        public string spine2PackLootSkin { get; set; }
        public string spineBunchLootSkin { get; set; }
        public string pickup2ForgeInto { get; set; }
        public bool mmoOnly { get; set; }
        public string mmoItem { get; set; }
        public bool noCustomize { get; set; }
        public List<string> skinUseExtrasAtlas { get; set; } = new();
        public string creepZoomSound { get; set; }
        public float creepZoomSoundRange { get; set; }
        public bool creepXray { get; set; }
        public float blastBack { get; set; }
        public int burst { get; set; }
        public float burstInterval { get; set; }
        public float trackTargetTimeBase { get; set; }
        public float trackTargetTimeAddPerRarity { get; set; }
        public float poisonDamagePerTick { get; set; }
        public int poisonNumTicks { get; set; }
        public int poisonMaxTicks { get; set; }
        public float healTeamPerTick { get; set; }
        public int healTicks { get; set; }
        public int healMaxTicks { get; set; }
        public float bounceRange { get; set; }
        public float bounceDmgMultBase { get; set; }
        public float bounceDmgMultAddPerRarity { get; set; }
        public int pierce { get; set; }
        public float pierceDmgMultPerHit { get; set; }
        public int ammoPerShot { get; set; }
        public bool alwaysZoom { get; set; }

        public AoeDamageInfo aoeDamageInfo { get; set; }
        public GrenadeInfo grenadeInfo { get; set; }
        public TrapInfo trapInfo { get; set; }
        public ArcStyleProjectile arcStyleProjectile { get; set; }
    }

    [System.Serializable]
    public class SoundSkinCustom
    {
        public string skin { get; set; }
        public string sound { get; set; }
        public int variations { get; set; }
        public string mode { get; set; }
    }

    [System.Serializable]
    public class SkinSoundPair
    {
        public string skin { get; set; }
        public string sound { get; set; }
    }

    [System.Serializable]
    public class SlotAttachment
    {
        public string slot { get; set; }
        public string attachment { get; set; }
        public string region { get; set; }
    }

    [System.Serializable]
    public class AoeDamageInfo
    {
        public float damageRadius { get; set; }
        public float damagePercentAtRadius { get; set; }
        public float selfDamagePercent { get; set; }
    }

    [System.Serializable]
    public class GrenadeInfo
    {
        public int worldSpawnAmount { get; set; }
        public string spineAttachment { get; set; }
        public string inAirImage { get; set; }
        public int carryMax { get; set; }
        public int carryMaxBandolier { get; set; }
        public int carryMaxInfection { get; set; }
        public int carryMaxInfectionBandolier { get; set; }
        public float maxThrowDistance { get; set; }
        public float initialSpeedBase { get; set; }
        public float initialSpeedMultOfDistance { get; set; }
        public float groundSpeed { get; set; }
        public float groundSpeedReductionMult { get; set; }
        public float lifetime { get; set; }
        public float gravity { get; set; }
        public float arcAngleNear { get; set; }
        public float arcAngleFar { get; set; }
        public float wallHitSpeedFactor { get; set; }
        public string explodePrefabName { get; set; }
        public float explodeSoundFarDist { get; set; }
        public string explodeSoundFar { get; set; }
        public string landingSound { get; set; }
        public string landingSoundWater { get; set; }
        public string fallingSound { get; set; }
        public string wallBounceSoundBase { get; set; }
        public int wallBounceSoundVariants { get; set; }
        public float rotationSpeedMin { get; set; }
        public float rotationSpeedMax { get; set; }
        public float maxSpeedForRotationCalc { get; set; }
        public bool movesOnConveyor { get; set; }
        public bool isTrap { get; set; }
        public bool moveFreezeDuringThrow { get; set; }
        public bool noArc { get; set; }
        public bool forceExplodeOnGround { get; set; }
    }

    [System.Serializable]
    public class TrapInfo
    {
        public int trapType { get; set; }
        public string makePrefab { get; set; }
        public float trapRadius { get; set; }
        public float trapPlacementOffsetY { get; set; }
        public bool trapDestroyedByExplosions { get; set; }
        public float trapTickInterval { get; set; }
        public int trapNumTicks { get; set; }
        public float trapSlowFactor { get; set; }
        public bool explodeOnLanding { get; set; }
        public bool canBeOnWater { get; set; }
        public float trapDamagePerTick { get; set; }
        public float trapDamagePeak { get; set; }
        public float trapDamageEdge { get; set; }
        public float trapArmingTime { get; set; }
        public float trapDamageDelay { get; set; }
        public string trapDelayTriggerPrefab { get; set; }
        public float trapHp { get; set; }
        public bool carryMaxIsSpawnLimit { get; set; }
        public string moveSightCollisions { get; set; }
        public string shadowPoly { get; set; }
        public float moveSightCollisionHeight { get; set; }
    }

    [System.Serializable]
    public class ArcStyleProjectile
    {
        public string inAirImage { get; set; }
        public float initialSpeedBase { get; set; }
        public float initialSpeedMultOfDistance { get; set; }
        public float groundSpeed { get; set; }
        public float groundSpeedReductionMult { get; set; }
        public float lifetime { get; set; }
        public float gravity { get; set; }
        public float ySpeedStartFactor { get; set; }
        public float arcAngleNear { get; set; }
        public float arcAngleFar { get; set; }
        public float wallHitSpeedFactor { get; set; }
        public string explodePrefabName { get; set; }
        public string wallBounceSoundBase { get; set; }
        public int wallBounceSoundVariants { get; set; }
        public string landingSoundWater { get; set; }
        public string fallingSound { get; set; }
        public float rotationSpeedMin { get; set; }
        public float rotationSpeedMax { get; set; }
        public float maxSpeedForRotationCalc { get; set; }
        public bool movesOnConveyor { get; set; }
        public bool isTrap { get; set; }
        public bool canHitMidAir { get; set; }
        public float midAirHitboxRadius { get; set; }
    }
}
