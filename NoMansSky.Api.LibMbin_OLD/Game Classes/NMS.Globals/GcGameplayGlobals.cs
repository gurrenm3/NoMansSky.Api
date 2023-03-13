using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;
using System.Collections.Generic;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGameplayGlobals : NMSTemplate
{
	public GcDifficultyConfig DifficultyConfig
	{
		get => GetValue<GcDifficultyConfig>();
		set => TrySetValue<GcDifficultyConfig>(value);
	}

	public NMSString0x10 PirateMissionPrimaryReward
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 PirateMissionSecondReward
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean UseSecondaryBiomeSubstances
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean TechMustBeInTechInventory
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single SpecialTechSlotBonus
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 RocketLockerFuelUse
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean EnableTechPackaging
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single CargoShieldStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TechDamageChanceShieldedMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TechDamageChanceShieldLevelMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TechDamageChanceShieldLevelMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TechDamageChanceToSelectPrimary
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateRaidAccelerator
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateGroundAccelerator
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateGroundInventoryAccelerator
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PoliceAcceleratorStationLockOn
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PoliceAcceleratorPulseExtra
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 PoliceAcceleratorSmugglingItemsMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single PoliceAcceleratorSmugglingMulMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PoliceAcceleratorNoCargoWealthy
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PoliceAcceleratorNoCargoNormal
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PoliceAcceleratorNoCargoSkipScanOdds
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipInterestAcceleratorInAsteroidField
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InfestedPlanetDeepSpaceFlybyMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SmugglerSellingMarkup
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IllegalTechProductTradingMod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CombatLevelBestWeaponBias
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CombatLevelBaseValueBoltcaster
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CombatLevelBaseValueShotgun
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CombatLevelBaseValueRailgun
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CombatLevelBaseValueSMG
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CombatLevelBaseValueCannon
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CombatLevelBaseValueGrenade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CombatLevelSClassValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 NexusRecipeCostType
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 NexusRecipeCostNaniteMultiplier
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single ShipScanPlanetRechargeMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipScanSpaceRechargeMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 FreeSuitSlotID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single InitialLocationProtectionRadiusMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PartyPlanetSearchDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterLightningDamageDistanceMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MaxActiveWeatherHazardGifts
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single WeatherHazardGiftMaxDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeatherHazardGiftLifeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcTechnologyCategory TechnologyOverrideForSmuggler
	{
		get => GetValue<GcTechnologyCategory>();
		set => TrySetValue<GcTechnologyCategory>(value);
	}

	public Single MaxMeteorSurfaceAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StormGravityChangeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StormBonusJetpackMod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StormBonusSprintMod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StormBonusMiningHeatMod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StormBonusMiningAmountMod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPlayerHazardType StormBonusJetpackWeather
	{
		get => GetValue<GcPlayerHazardType>();
		set => TrySetValue<GcPlayerHazardType>(value);
	}

	public GcPlayerHazardType StormBonusSprintWeather
	{
		get => GetValue<GcPlayerHazardType>();
		set => TrySetValue<GcPlayerHazardType>(value);
	}

	public GcPlayerHazardType StormBonusMiningHeatWeather
	{
		get => GetValue<GcPlayerHazardType>();
		set => TrySetValue<GcPlayerHazardType>(value);
	}

	public GcPlayerHazardType StormBonusMiningAmountWeather
	{
		get => GetValue<GcPlayerHazardType>();
		set => TrySetValue<GcPlayerHazardType>(value);
	}

	public Single AlienPodThreshold2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AlienPodThreshold1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour BulletTraceLineColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single BulletTraceLineWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipBulletTraceLineWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleAllIconScanTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 GPSRandomChangeTimeWide
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 GPSRandomChangeTimeMid
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 GPSRandomChangeTimeNarrow
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single SalvageValueAsProds
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 SalvageSubstanceValueThreshold
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<NMSString0x10> SalvageRewardsShuttle
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x10>(address + GetOffset(), 4));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualArray<NMSString0x10> SalvageRewardsDropship
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x10>(address + GetOffset(), 4));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualArray<NMSString0x10> SalvageRewardsFighter
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x10>(address + GetOffset(), 4));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualArray<NMSString0x10> SalvageRewardsScience
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x10>(address + GetOffset(), 4));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualArray<NMSString0x10> SalvageTechList
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x10>(address + GetOffset(), 5));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> SalvageProdsList
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> SalvageSubstancesList
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean AlwaysSpaceBattle
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single MultidimensionalFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleporterDistanceTravelledMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcScanEffectData BinocularSelectedEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public Colour BinocularSelectedColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour BinocularSelectedUnknownColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single CockpitScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxDistanceForLadderTeleport
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AngleFromBaseComputerWhenTeleporting
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceFromBaseComputerWhenTeleporting
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AutoTranslateWordChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean MissionSurveySuggestSurveyForNearScannables
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single MissionSurveyMaxGuidanceDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissionSurveyMaxGuidanceDistanceWorms
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 MissionSurveyWormID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single MissionSurveyMarkerAutoHideTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissionSurveyScanRangeMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissionSurveyMaxScanAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissionSurveyMaxScanAngleScannableComp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissionSurveyBeginScanPercentageScannable
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissionSurveyBeginScanPercentageEvent
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissionSurveyScanSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissionSurveyScanSpeedScannableComp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissionSurveyRevealWithoutScanDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissionSurveyAutoScanDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissionSurveyAutoScanFlattenRadiusMul
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissionSurveySonarMinPulseSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissionSurveySonarMaxPulseSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissionSurveySonarPulseSpeedBandCount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissionSurveyMaxAngleOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissionSurveyMaxSignalConeAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissionSurveyInShipArrivedDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SurveyBeginScanPercentage
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SurveyScanMinSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SurveyScanMaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SurveySonarPulseSpeedBandCount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SurveySonarMinPulseSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SurveySonarMaxPulseSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SurveySonarMiddleRangeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SurveySonarMiddleRangeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SurveyMaxDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 CreaturesToBaitForTutorial
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 CreaturesToFeedForTutorial
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean DisableGalaxyMapInQuickMenu
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableNexusInQuickMenu
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EnableTeleporters
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AllowSpaceScanEvents
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CanMoveTechnology
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single NormalModeHeatBonus
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseLaserHeatTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeatAlertTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeatDamageBoost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeatWidthBoost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeatWidthBoostAlt
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OverheatGenerosity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeatMaxPowerPoint
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OverheatDecay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType OverheatCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Boolean UseOverheatColour
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Colour OverHeatColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour OverHeatBarColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public TkCurveType OverheatColourCurveShip
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public TkCurveType OverheatColourCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Int32 RefinerProductsMadeInTime
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 RefinerSubsMadeInTime
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 RefinerProductsMadeInTimeSurvival
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 RefinerSubsMadeInTimeSurvival
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<NMSString0x10> HyperdriveAccess
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> FreighterHyperdriveAccess
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single SeasonalMessageModuleAttractDistanceMul
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HmdInteractionRangeMinRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HmdInteractionRangeMinDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HmdInteractionRangeMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean InstallTechWithInteraction
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean FreighterRequiresRGBHyperdriveUpgrades
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DisableAnomalyAmbientSpawn
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AllowDeconstruct
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AllowBinocularMarker
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EveryMaintenanceIsBroken
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SpawnResourceBlobsOnPartDelete
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EnableShootHitEffect
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 MaxNumSameGroupTech
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single ShootableArmourHighlightHitTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShootableAggroMinStartTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShootableAggroForgetTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour RefinerColour1A
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour RefinerColour1B
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour RefinerColour1C
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour RefinerColour1D
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single AtmosphereEntryTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AtmosphereEntryFadeTimeFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AtmosphereEntryOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType AtmosphereEntryCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single AtmosphereEntryErrorTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 AsteroidScanMaxShown
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single AsteroidScanTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AsteroidScanRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TerrainResourceScanTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TerrainResourceScanRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TerrainResourceCompassRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean BinocsDisplayUnknownCreatures
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single BinocularScanTargetMinHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BinocularScanTargetHeightRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BinocTimeBeforeScan
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BinocMinScanTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BinocScanTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BinocCreatureScanTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType BinocularScanTargetHeightCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single BinocularScanTargetInitialFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BinocularScanTargetScaler
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BinocularScanTargetLineWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BinocularScanTargetFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour BinocularScanTargetColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public GcScanEffectData BinocularScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public Single ScannerIconsClumpRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScannableComponentMarkerOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScannableComponentPlaceMarkerOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissionEventAllowResetDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AllRecipesKnownNanitesMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AllRecipesKnownNanitesMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxPossibleShipDamagePotential
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlayerBaseIconOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CriticalHitMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HitEffectMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GrabPlayerCooldownTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TapInteractionIncreaseAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TapInteractionDecay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcScanEffectData DeconstructEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcScanEffectData HitEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcScanEffectData HitEffectCritical
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public Single CommunicatorSpawnOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CommunicatorSpawnHeightOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f CommunicatorShipSpawnOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single CommunicatorSpawnScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CommunicatorSpawnRotation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CommunicatorCargoScanDroneScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CommunicatorCargoScanDroneScaleFallback
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CommunicatorCargoScanDroneUpOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CommunicatorCargoScanDroneUpOffsetFallback
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CommunicatorCargoScanDroneAtOffsetFallback
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CommunicatorCargoScanDronePitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CommunicatorCargoScanDroneRoll
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CommunicatorCargoScanDroneYaw
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CommunicatorFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcScanEffectData> CommunicatorEffectTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcScanEffectData>(address + GetOffset()));
		set => TrySetValue<GcScanEffectData>(value);
	}

	public Int32 MaxNumMissionsFromMissionGiver
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single InteractionMinTimeBeforeHighlightedOptionSelection
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionMinTimeBetweenStickOptionHighlights
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionStickOptionStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionMessageModuleDisplayTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionAttractTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionDescriptionTextTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionMinTimeForResponseText
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean InteractionOverride
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcInteractionType InteractionOverrideFrom
	{
		get => GetValue<GcInteractionType>();
		set => TrySetValue<GcInteractionType>(value);
	}

	public GcInteractionType InteractionOverrideTo
	{
		get => GetValue<GcInteractionType>();
		set => TrySetValue<GcInteractionType>(value);
	}

	public Single DestroyEffectHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DestroyEffectMaxScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EventTargetSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 SpecialMiningAmount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single SpecialMiningTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 HardModeTechDamageMidNum
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 HardModeTechDamageMidPercent
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 HardModeTechDamageHighPercent
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 EarlyPiratesToBeKilled
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 PlanetPirateFlybyMaxRepeatCounter
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 PirateInterestOverride
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single PirateInterestDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateInterestDistanceMPMission
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Int32> PirateInterestLevels
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 3));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Int32> PirateInterestLevelsSurvival
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 3));
		set => TrySetValue<Int32>(value);
	}

	public Int32 PoliceInterestOverride
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single PoliceInterestDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PoliceInterestDistanceMPMission
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Int32> PoliceInterestLevels
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 3));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Int32> PoliceInterestLevelsSurvival
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 3));
		set => TrySetValue<Int32>(value);
	}

	public Single SpaceCombatRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 WarpsBetweenBattles
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single HoursBetweenBattles
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceBattleRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceBattleAnyHostileShipsRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterBattleRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissileMaxTurnAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissileLockTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissileReloadTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissileRotateMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissileRotateMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissileMaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissileForceMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissileForceMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissileBrakeForceMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissileBrakeForceMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissileThreatTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissileBrakeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissileHitRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissileOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissileMinCircleTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissileApproachTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissileRotateSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanStartTimeDelayMinDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanStartTimeDelayRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanStartTimeDistanceDelayTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanStickyDecay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureScanStickyDecay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureScanAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureMinScanTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NewDiscoveryDisplayTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean FailToFindBuildings
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single WaterLandingDamageMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 CritDamage
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single CritScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 NumMissionsPerSolarSystem
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single EmergencyBuildingScanEventDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EmergencyBuildingScanEventTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ProjectileLightIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AggressiveSentinelProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AggressiveSentinelProbabilitySurvival
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LowSentinelProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LowSentinelProbabilitySurvival
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NonAggressiveLushSurvivalProbabability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MaxDronesLow
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxDronesLowSurvival
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxDronesNormal
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxDronesNormalSurvival
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxDronesAggressive
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxDronesAggressiveSurvival
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcExperienceTimers SentinelTimersLow
	{
		get => GetValue<GcExperienceTimers>();
		set => TrySetValue<GcExperienceTimers>(value);
	}

	public GcExperienceTimers SentinelTimersNormal
	{
		get => GetValue<GcExperienceTimers>();
		set => TrySetValue<GcExperienceTimers>(value);
	}

	public Int32 FreighterStartPecent
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcExperienceTimers FreighterTimers
	{
		get => GetValue<GcExperienceTimers>();
		set => TrySetValue<GcExperienceTimers>(value);
	}

	public GcExperienceTimers PlanetPirateTimers
	{
		get => GetValue<GcExperienceTimers>();
		set => TrySetValue<GcExperienceTimers>(value);
	}

	public GcExperienceTimers SpacePirateTimers
	{
		get => GetValue<GcExperienceTimers>();
		set => TrySetValue<GcExperienceTimers>(value);
	}

	public VirtualList<Single> PirateEarlySpawnChances
	{
		get => cache.GetOrAddValue(new VirtualList<Single>(address + GetOffset()));
		set => TrySetValue<Single>(value);
	}

	public Single PirateEarlySpawnTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcExperienceTimers FlybyTimers
	{
		get => GetValue<GcExperienceTimers>();
		set => TrySetValue<GcExperienceTimers>(value);
	}

	public GcExperienceTimers SpaceFlybyTimers
	{
		get => GetValue<GcExperienceTimers>();
		set => TrySetValue<GcExperienceTimers>(value);
	}

	public GcExperienceTimers PoliceTimers
	{
		get => GetValue<GcExperienceTimers>();
		set => TrySetValue<GcExperienceTimers>(value);
	}

	public VirtualArray<Int32> FreighterTechQualityWeightings
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 6));
		set => TrySetValue<Int32>(value);
	}

	public Int32 SentinelsHigh
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 SentinelsLow
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single AsteroidHitForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AsteroidTorqueForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AsteroidCarveRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 DeathMoneyPenalty
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxResourceCrystalBlobSize
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single BuildingBeamDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaypointScanTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 RareSubstanceEffectiveness
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 CommonProductEffectiveness
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 RareProductEffectiveness
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 AsteroidResourceReducer
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 TunnelStatReducer
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single VoxelAsteroidResourceChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 ResourceReducer
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ResourceMinAmount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ResourceMaxAmount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ResourceCommonReducer
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ResourceCommonMinAmount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ResourceCommonMaxAmount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ResourceDirtReducer
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ResourceDirtMinAmount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ResourceDirtMaxAmount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x10 ResourceDirtSubstanceID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 SandwormTerrainResource
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 BioShipTerrainResource
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20 RobotResource
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x20 DepotResource
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Single DockNodeBuyRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BeaconInteractRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipInteractRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcResourceCollectEffect AsteroidResourceCollect
	{
		get => GetValue<GcResourceCollectEffect>();
		set => TrySetValue<GcResourceCollectEffect>(value);
	}

	public Single ScanAngleCutoff
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcScanData ToolScan
	{
		get => GetValue<GcScanData>();
		set => TrySetValue<GcScanData>(value);
	}

	public GcScanData ToolScanHardMode
	{
		get => GetValue<GcScanData>();
		set => TrySetValue<GcScanData>(value);
	}

	public GcScanData WaypointScan
	{
		get => GetValue<GcScanData>();
		set => TrySetValue<GcScanData>(value);
	}

	public GcScanData BeaconScan
	{
		get => GetValue<GcScanData>();
		set => TrySetValue<GcScanData>(value);
	}

	public GcScanData RadioTowerScan
	{
		get => GetValue<GcScanData>();
		set => TrySetValue<GcScanData>(value);
	}

	public GcScanData ObservatoryScan
	{
		get => GetValue<GcScanData>();
		set => TrySetValue<GcScanData>(value);
	}

	public GcScanData DistressSignalScan
	{
		get => GetValue<GcScanData>();
		set => TrySetValue<GcScanData>(value);
	}

	public GcScanData DebugScanPlanet
	{
		get => GetValue<GcScanData>();
		set => TrySetValue<GcScanData>(value);
	}

	public GcScanData DebugScanSpace
	{
		get => GetValue<GcScanData>();
		set => TrySetValue<GcScanData>(value);
	}

	public GcScanData ShipScan
	{
		get => GetValue<GcScanData>();
		set => TrySetValue<GcScanData>(value);
	}

	public GcScanData VisualScan
	{
		get => GetValue<GcScanData>();
		set => TrySetValue<GcScanData>(value);
	}

	public Single ZoomFindBuildingRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TimeToDisplayScanResults
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverTimeToScan
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverTimeToScanCreatures
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 HoverVisiblePointsNeeded
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<GcZoomData> ZoomLevels
	{
		get => cache.GetOrAddValue(new VirtualList<GcZoomData>(address + GetOffset()));
		set => TrySetValue<GcZoomData>(value);
	}

	public GcScanEffectData PassiveScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcScanEffectData BuildingScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcScanEffectData TargetShipScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcScanEffectData HUDShipScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcScanEffectData CreatureScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcScanEffectData ObjectsScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcScanEffectData VRGhostScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcScanEffectData BlankScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcScanEffectData BaseBuildingValidScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcScanEffectData BaseBuildingPreviewSelectionScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcScanEffectData BaseBuildingSelectionScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcScanEffectData BaseBuildingDeleteScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcScanEffectData BaseBuildingGhostScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcScanEffectData BaseBuildingSpawnStaticEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcScanEffectData BaseBuildingVisionScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcScanEffectData BaseBuildingErrorInsideScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcScanEffectData BaseBuildingErrorCollisionScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcScanEffectData BaseBuildingErrorImpossibleScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcScanEffectData BaseBuildingErrorUnaffordableScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcScanEffectData BaseBuildingErrorAboveWaterScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcScanEffectData BaseBuildingErrorBelowWaterScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcScanEffectData BaseBuildingRemotePlayerValidScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcScanEffectData BaseBuildingRemotePlayerSelectionScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public Single BaseBuildingRemotePlayerErrorAlphaScanEffect
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean UseDebugScan
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DebugScanForceBuilding
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcBuildingClassification DebugScanForceBuildingType
	{
		get => GetValue<GcBuildingClassification>();
		set => TrySetValue<GcBuildingClassification>(value);
	}

	public Single ShipScanOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipScanOffsetGap
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType ShipScanCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single ScannerMarkerFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScannerSmallMarkerFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScannerPhysicsProbeAABBSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScannerAnalyzeFXRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScannerSubstanceTimePerTrigger
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScannerTuningA
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScannerTuningB
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScannerTuningC
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScannerTuningD
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScannerTuningResourceOffset1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScannerTuningResourceOffset2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScannerTuningSmoothStepAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScannerTuningTrailingEdge
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean Autolevel
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Colour ScannerColour1
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ScannerColour2
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single HUDStoreFlashTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExcitingViewAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExcitingViewRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExcitingNearRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ProjectileSpeedBoost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LineWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LockOffFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffscreenFadeDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffscreenMinDot
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean HUDUpdateFromData
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single HUDLockOnAudioTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDArrowPrimaryScaler
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f HUDDamageSize
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f HUDDamageSplatSize
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Colour HUDDamageSplatShieldColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour HUDDamageSplatPainColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single HUDDamageOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDDamageScaler
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDDamageRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcShipHUDTargetData HUDTarget
	{
		get => GetValue<GcShipHUDTargetData>();
		set => TrySetValue<GcShipHUDTargetData>(value);
	}

	public Single HUDLabelTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDLabelAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDLabelAngleOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDLabelOffsetX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDLabelOffsetY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDLabelOffsetZ
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDLabelScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean PlayHitEffectsOnZeroDamage
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single MaxSpawnTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x80 ResourceParticleFile
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Single ResourceParticleSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ResourceParticleSpread
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 ResourceParticleMaxNum
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ResourceParticleMinNum
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single MapHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MapOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MapTargetOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MapFOV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MapRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDScaleAdd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDScaleRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDScaleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDScaleMinAim
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDScaleMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDScaleFarTarget
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDReticuleMoveBack
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDReticuleMoveAim
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MouseSensitivity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MouseSensitivityShip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MouseSensitivityVehicle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PainTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType PainCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Colour PainColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single GunOffsetX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GunOffsetY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GunOffsetZ
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GunOffsetAggressiveX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GunOffsetAggressiveY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GunOffsetAggressiveZ
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GunDownAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GunUpAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BarrelOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HitOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcTracerData BulletTracer
	{
		get => GetValue<GcTracerData>();
		set => TrySetValue<GcTracerData>(value);
	}

	public GcTracerData ShipTracer
	{
		get => GetValue<GcTracerData>();
		set => TrySetValue<GcTracerData>(value);
	}

	public NMSString0x10 DefaultAnim
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean DebugDrawTriggerBoxes
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single SpeedReadoutMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceSpeedReadoutMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CombatSpeedReadoutMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 TorchCookieIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single TorchFoV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TorchStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 TorchDimCookieIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single TorchDimFoV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TorchDimStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionTorchFoV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionTorchStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UndergroundTorchFoV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UndergroundTorchFoVFar
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UndergroundTorchStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UndergroundTorchStrengthFar
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TorchOffsetX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TorchOffsetY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TorchOffsetZ
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TorchOffsetZMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TorchOffsetZSpeedRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TorchOffsetZMinSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TorchHandOffsetX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TorchHandOffsetY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TorchHandOffsetZ
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean TorchDisabledInTheDay
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single TorchRotation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TorchFollowCameraPitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TorchFollowCameraTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour TorchColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single PlayerAmbientSpotLightIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour PlayerAmbientSpotLightColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single PlayerAmbientSpotLightOffsetY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlayerAmbientSpotLightOffsetZ
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SimpleInteractionPickupAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SimpleInteractionPickupRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SimpleInteractionMessageTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionPickupAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionPickupRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExplosionRadiusMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExplosionForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExplosionForceMaxForceRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaserExplosionForceRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaserExplosionForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaserExplosionForceMaxForceRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x80 InitialDebrisScene
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Single BonusSameTypeElementsAdd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BonusSameTypeElementsMultiply
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BonusChildTypeElementsAdd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BonusChildTypeElementsMultiply
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionComponentUpdateDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GoalGapVoxelDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BlackHoleJumpVoxelDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BlackHoleJumpVoxelVariation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JumpToCenterFuelCost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 WarpsBetweenMiniStation
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single HoursBetweenMiniStation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x80 LegacyBaseBuildingTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 BaseBuildingTable
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Single BaseBuildingHoverTimeToKnowPart
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public UInt64 NPCWorkerInteractionCooldown
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public Single LightStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AirLockDoorRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean DisableBasePowerHUDOverlay
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean KeepAttackingMaxWantedLevel
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseMultiplierBonus
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single ShipDisplayDamageMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean UseTradingCostTable
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ChangePricesLocally
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShowPriceMarkupsAsPercentages
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 ProductItemStockDecayTime
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ProductItemStockReplenishTime
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 SubstanceItemStockDecayTime
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 SubstanceItemStockReplenishTime
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcPortalData Portal
	{
		get => GetValue<GcPortalData>();
		set => TrySetValue<GcPortalData>(value);
	}

	public Int32 FourthRaceSpawnPercentage
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 NonDominantRaceSpawnPercentage
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 NonDominantRaceSpawnPercentagePirate
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single ViciousSentinelProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ViciousStormProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ViciousWeatherProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScrapDroneProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxRespawnOnGroundHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DeadPlanetGravityFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcScanEffectData ShipSalvageScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public Single SalvageShipPitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SalvageShipHeightOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SalvageShipExplodeSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SalvageShipShowShipSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SalvageShipShowShipDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SalvageShipExplodeShipDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SalvageShipOneRevolutionTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x20A CommunicatorFireteamNexusExitDialog
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A CommunicatorNexusExitAbandonWarningDialog
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Single BackgroundSpaceEncounterCheckTimer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseEncounterCheckTimer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseEncounterChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseEncounterChanceStandard
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseEncounterChanceRed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseEncounterChanceGreen
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseEncounterChanceBlue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseEncounterStopPower
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseEncounterStopSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DerelictPulseEncounterAtmosphericEffectChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Int32> AlienShipEvolveCosts
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 6));
		set => TrySetValue<Int32>(value);
	}

	public Single SpawnerWeaponRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkModelResource WeaponSpawnObject
	{
		get => GetValue<TkModelResource>();
		set => TrySetValue<TkModelResource>(value);
	}

	public TkModelResource WeaponSpawnAltObject
	{
		get => GetValue<TkModelResource>();
		set => TrySetValue<TkModelResource>(value);
	}

	public Boolean UseCustomSaveDirectory
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Vector2f FrigateFlybyTimer
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Int32 PersonalInventoryMinWidthMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 PersonalInventoryMinHeightMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 PersonalTechInventoryMinWidthMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 PersonalTechInventoryMinHeightMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ShipInventoryMinWidthMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ShipInventoryMinHeightMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ShipTechInventoryMinWidthMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ShipTechInventoryMinHeightMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 VehicleInventoryMinWidthMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 VehicleInventoryMinHeightMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 WeaponInventoryMinWidthMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 WeaponInventoryMinHeightMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcGameplayGlobals(long address) : base(address)
	{

	}
}
