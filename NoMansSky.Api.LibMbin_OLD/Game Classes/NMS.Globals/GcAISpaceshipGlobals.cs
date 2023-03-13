using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;
using System.Collections.Generic;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAISpaceshipGlobals : NMSTemplate
{
	public GcPlayerSquadronConfig PlayerSquadronConfig
	{
		get => GetValue<GcPlayerSquadronConfig>();
		set => TrySetValue<GcPlayerSquadronConfig>(value);
	}

	public Boolean DisplayShipAttackTypes
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single MaxDifficultySpaceCombatTurnExtra
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxDifficultySpaceCombatSpeedExtra
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinimumCircleTimeBeforeLanding
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinimumTimeBetweenOutpostLandings
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VisibleDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean TradersAttackPirates
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean FreightersAlwaysAttackPlayer
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean GroundEffectEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AtmosphereEffectEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean FillUpOutposts
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single SalvageTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SalvageRemovalTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SalvageValueMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DockingWaitDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MaxNumActiveTraders
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single MaxNumActiveTraderRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MaxNumActivePolice
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single MaxNumActivePoliceRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MinAggroDamage
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single TrailLandingFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean EnergyShieldsEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x80 EnergyShield
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x10 EnergyShieldDepletedEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 EnergyShieldStartRechargeEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 EnergyShieldStartRechargeFromDepletedEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean EnergyShieldAlwaysVisible
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single EnergyShieldFadeMinOpacityInCombat
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EnergyShieldFadeNonPlayerHitOpacity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EnergyShieldFadeInRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EnergyShieldFadeOutRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinLaserFireTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipAlertPirateRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlanetaryPirateHostileShipPerceptionRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlanetaryPirateRaidFocusBuildingsTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlanetaryPirateRaidTradersEngageTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 PlanetaryPirateRaidMaxTradersJoinCombat
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single EscapeRollTimePlanet
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EscapeRollTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EscapeRollPlanet
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EscapeRoll
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 CrashedShipMinNonBrokenSlots
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single CrashedShipBrokenSlotChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrashedShipBrokenTechChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrashedShipRepairSlotCostIncreaseFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrashedShipGeneralCostDiscount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrashedShipTechSlotsCostDiscount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateSpawnSpacing
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceFlareMinDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceFlareRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceFlareMinScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceFlareMaxScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceFlareMinSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceFlareSpeedRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceFlareFlickerFreq
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceFlareFlickerAmp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean AttackRepositionBoost
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AttackShipsFollowLeader
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single AttackTooCloseMinRelSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<NMSString0x10> ProjectileWeaponMuzzleFlashes
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x10>(address + GetOffset(), 7));
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single RewardLootOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RewardLootOffsetSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RewardLootAngularSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlybyPlanetLandingProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCombatEffectsComponentData CombatEffectsComponentData
	{
		get => GetValue<GcCombatEffectsComponentData>();
		set => TrySetValue<GcCombatEffectsComponentData>(value);
	}

	public GcSpaceshipTravelData FallbackTravelData
	{
		get => GetValue<GcSpaceshipTravelData>();
		set => TrySetValue<GcSpaceshipTravelData>(value);
	}

	public GcSpaceshipTravelData SlowCombatEffectAttackTravel
	{
		get => GetValue<GcSpaceshipTravelData>();
		set => TrySetValue<GcSpaceshipTravelData>(value);
	}

	public GcSpaceshipTravelData AsteroidMiningPositioningTravelData
	{
		get => GetValue<GcSpaceshipTravelData>();
		set => TrySetValue<GcSpaceshipTravelData>(value);
	}

	public GcSpaceshipTravelData AsteroidMiningTravelData
	{
		get => GetValue<GcSpaceshipTravelData>();
		set => TrySetValue<GcSpaceshipTravelData>(value);
	}

	public Single AsteroidMiningSearchRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AsteroidMiningMaxAsteroidRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AsteroidMiningMaxViewAngleYaw
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AsteroidMiningMinViewAnglePitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AsteroidMiningMaxViewAnglePitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AsteroidMiningMinDistFromPlayer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AsteroidMiningMinMiningAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AsteroidMiningMaxMiningTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackShipAvoidStartTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackMinimumTimeBeforeTargetSwitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateExtraDamage
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Boolean> PirateAttackableBuildingClasses
	{
		get => cache.GetOrAddValue(new VirtualArray<Boolean>(address + GetOffset(), 52));
		set => TrySetValue<Boolean>(value);
	}

	public Single PirateMaintainBuildingTargetTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShieldCollisionRadiusMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CollisionRayLengthMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CollisionRayLengthMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcSpaceshipTravelData OutpostLanding
	{
		get => GetValue<GcSpaceshipTravelData>();
		set => TrySetValue<GcSpaceshipTravelData>(value);
	}

	public GcSpaceshipTravelData PlanetLanding
	{
		get => GetValue<GcSpaceshipTravelData>();
		set => TrySetValue<GcSpaceshipTravelData>(value);
	}

	public Single OutpostLandingNoiseFreq
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OutpostLandingNoiseAmp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OutpostLandingNoiseOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OutpostDockUpAlignMaxAngleFirstPerson
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OutpostDockUpAlignMaxAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OutpostDockMaxApproachSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OutpostDockOverspeedBrake
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OutpostDockGetToApproachForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OutpostDockGetToApproachBrakeForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OutpostDockGetToApproachExtraBrakeForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OutpostDockApproachSpeedForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OutpostDockApproachDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OutpostDockApproachSpeedUpDamper
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OutpostDockAIGetToApproachForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OutpostDockAIGetToApproachBrakeForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OutpostDockAIApproachSpeedForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OutpostDockMaxForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OutpostDockMinTipLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OutpostDockMaxTipLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OutpostDockApproachUpAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OutpostDockApproachRenderRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OutpostDockApproachRenderFlickerOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandingTipAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandingLongTipAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f SpaceBattleSpawnAngle
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f SpaceBattleSpawnPitch
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f SpaceBattleSpawnOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f SpaceBattleSunHeightAngle
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f SpaceBattleSunAroundAngle
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public VirtualList<Vector2f> SpaceBattleSpawnRange
	{
		get => cache.GetOrAddValue(new VirtualList<Vector2f>(address + GetOffset()));
		set => TrySetValue<Vector2f>(value);
	}

	public VirtualList<Vector2f> SpaceBattlePirateRange
	{
		get => cache.GetOrAddValue(new VirtualList<Vector2f>(address + GetOffset()));
		set => TrySetValue<Vector2f>(value);
	}

	public VirtualList<Vector2f> SpaceBattleGuardsRange
	{
		get => cache.GetOrAddValue(new VirtualList<Vector2f>(address + GetOffset()));
		set => TrySetValue<Vector2f>(value);
	}

	public Single SpaceBattleGuardOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceBattleGuardUpOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceBattleInitialPirateUpOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceBattleInitialPirateOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceBattleObstructionRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceBattleFlybyTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 SpaceBattleLevel
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Vector2f ConeSpawnOffsetFactor
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single ConeSpawnFlattenUp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ConeSpawnFlattenDown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean FreighterAlertLights
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single FreighterAlertLightCapitalSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x80 LegacyHangarFilename
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 HangarFilename
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Single PoliceFreighterWarpOutRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissileRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour FreighterDoorColourActive
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour FreighterDoorColourInactive
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour AlertLightColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public TkHitCurveData FreighterLightHitCurve
	{
		get => GetValue<TkHitCurveData>();
		set => TrySetValue<TkHitCurveData>(value);
	}

	public Single FreighterAlertLightTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterAlertLightIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MaxNumTurretMissiles
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single TurretOriginOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurretAlertLightIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f TurretAlertLightOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Boolean DisableTradeRoutes
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single AttackFreighterGetThereBoost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackFreighterApproach
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackFreighterWingmanAlignMinDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackFreighterWingmanAlignRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackFreighterApproachDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackFreighterAttackRunStartDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackFreighterBugOutDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackFreighterButOutTurnUp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackFreighterButOutSpeedUp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackFreighterWingmanRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackFreighterWingmanOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackFreighterWingmanLockAlign
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackFreighterWingmanLock
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackFreighterWingmanMaxForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackFreighterAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackFreighterRunOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackFreighterWingmanStart
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateFreighterWarpOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f PirateFreighterAttackRange
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single MissileLaunchSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackAfterSpawnTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f FreighterMiniSpeeds
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single AttackBuildingGetThereBoost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackBuildingApproachDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackBuildingRunStartDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackBuildingAttackRunDistTolerance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackBuildingFiringAngleTolerance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackBuildingBugOutDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackBuildingBugOutTurnUp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackBuildingBugOutSpeedUp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackBuildingRunAngleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackBuildingRunAngleMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackBuildingNextRunAngleDeltaMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackBuildingNextRunAngleDeltaMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackBuildingTargetGroundOffsetScaleStart
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackBuildingTargetGroundOffsetScaleEnd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AsteroidShootAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TraderWantedTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TraderRequestTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TraderPostCombatRequestTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TradingPostTraderRequestTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TradingPostTraderRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TradingPostTraderRangeSpace
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceStationTraderRequestTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AbandonedSystemShipSpawnProbablity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 FlybyCloseOdds
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single BountySpawnAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PoliceLaunchSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PoliceLaunchTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PolicePauseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PolicePauseTimeSpaceBattle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PoliceEscapeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PoliceEscapeMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PoliceStationWaveTimer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PoliceStationEngageRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 PoliceStationNumToLaunch
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 TraderIgnoreHits
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single PirateFreighterSpawnAttackAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateFreighterSpawnAttackOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateFreighterSpawnAttackSpread
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateSpawnAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateBattleMaxTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateArriveTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateStartSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateBattleStartSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateInterestTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateBattleInterestTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TraderArriveSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TraderArriveTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeightTestSampleDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeightTestSampleTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OutpostToLandingDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean FreightersSamePalette
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single PlanetUpAlignTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CollisionReactionTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean PoliceSpawnEffect
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 MaxNumFreighters
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single ShipSpawnStationRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipSpawnAnomalyRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BattleSpawnStationMinDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PoliceSpawnViewAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PoliceEntranceStartTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PoliceEntranceProbe
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PoliceEntranceEscalateProbingTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PoliceEntranceEscalateIncomingTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PoliceEntranceCargoScanStartTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PoliceEntranceCargoProbingTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PoliceEntranceCargoOpenCommsWaitTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PoliceEntranceCargoAttackWaitTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PoliceEntranceCargoScanHailNotificationWaitTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PoliceArriveTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PoliceAbortRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PoliceWarnBeaconPulseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ArrivalStaggerOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrailScaleMinDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrailScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrailScaleRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrailScaleMaxScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrailScaleFreighterMaxScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType TrailScaleCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single TradeRouteSeekOutpostRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TradeRouteFollowOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x100 TradeRouteIcon
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public Single TradeRouteSpawnDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TradeRouteTrailDrawDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TradeRouteTrailFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TradeRouteTrailTimeOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TradeRouteStationRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TradeRouteSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TradeRouteSlowRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TradeRouteSlowSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 TradeRouteDivisions
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single TradeRouteFlickerFreq
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TradeRouteFlickerAmp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 TradeRouteMaxNum
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<Colour> TradeRouteColours
	{
		get => cache.GetOrAddValue(new VirtualList<Colour>(address + GetOffset()));
		set => TrySetValue<Colour>(value);
	}

	public Boolean EnableLoot
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single LaserHitOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DirectionBrakeThresholdSq
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 PoliceNumPerTarget
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Vector2f PoliceSideOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f PoliceUpOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single WitnessHearingRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WitnessSightRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WitnessSightAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterImpactScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterAlertThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterAttackDisengageDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterAttackAlertThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterAlertTimeOutRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterAlertTimeOutMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterShipLaunchSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterLaunchTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterLaunchStartTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean FreighterIgnorePlayer
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 FreighterNotifySquadAlertLevel
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 FreighterMaxNumLaunchedShips
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single FreighterSpawnMargin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterSpawnRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterSpawnRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterSpawnViewAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterSpawnVisibleFreightersDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrigateSpawnMargin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EngineFlareAccelMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EngineFlareAccelMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EngineFlareSizeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EngineFlareSizeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EngineFlareVibrateAmp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EngineFlareVibrateFreq
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EngineFlareOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EngineFireSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PitchFlip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackAimTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackRunSlowdown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PiratePlayerAttackRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MoveHeightAdjust
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MoveAvoidRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MoveHeightNumSamples
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single MoveHeightSampleSectionSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MoveHeightCheckTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurretRandomOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurretRandomAIShipOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PoliceLaunchDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Scaler
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScaleTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScalerMinDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScalerMaxDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScaleHeightMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScaleHeightMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ScaleDisabledWhenOnFreighter
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single WarpInPlayerLocatorTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpInPlayerLocatorMinOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpFadeInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpInTimeFreighter
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType WarpInCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single WarpInVariance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpInDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpInPostSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpInPostSpeedFreighter
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpInAudioFXDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpOutDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<NMSString0x10> WarpStartEffectIDs
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x10>(address + GetOffset(), 7));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualArray<NMSString0x10> WarpArriveEffectIDs
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x10>(address + GetOffset(), 7));
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single ShipEscapeTimeBeforeWarpOut
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipEscortLockOnDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipEscortVelocityBand
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipEscortVelocityBandForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipEscortFwdForceTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipEscortBackForceTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipEscortPerpForceTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipEscortRadialOffsetScaleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipEscortRadialOffsetScaleMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipEscortForwardOffsetScaleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipEscortForwardOffsetScaleMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateFlybyLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlybyLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlybyHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlybyOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcProjectileLineData ShipBullet
	{
		get => GetValue<GcProjectileLineData>();
		set => TrySetValue<GcProjectileLineData>(value);
	}

	public Single WingmanLockDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanLockBetweenTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanLockArriveTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanMinHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanHeightAdjust
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanStartTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanOffsetStart
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanSideOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanRotate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanAtTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanAtTimeBack
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanPerpTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanVelocityBand
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanVelocityBandForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TraderAtTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TraderAtTimeBack
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TraderPerpTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TraderVelocityBand
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TraderVelocityBandForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanAlign
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrailSpeedFadeMinSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrailSpeedFadeFalloff
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DockingLandingTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DockingLandingTimeDirectional
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DockingSpringTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DockingLandingBounceTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DockingLandingBounceHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DockingRotateStartTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DockingRotateSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DockWaitMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DockWaitMaxTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TakeOffHoverPointReachedDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TakeOffExitHeightOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TakeOffExtraAIHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandingManuevreTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandingManeuvreAlignTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandingHoverPointReachedDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandingDirectionalHoverPointReachedDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AtmosphereTerminalSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CircleApproachDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TravelMinBoostTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundCircleHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundCircleHeightMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OrbitHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AtmosphereEffectMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AtmosphereEffectMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxTorque
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipAngularFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RollAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RollMinTurnAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FinalDeathExplosionScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FinalDeathExplosionTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FinalDeathFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcShipAIDeathData Death
	{
		get => GetValue<GcShipAIDeathData>();
		set => TrySetValue<GcShipAIDeathData>(value);
	}

	public GcShipAIPlanetPatrolData WingmanPathData
	{
		get => GetValue<GcShipAIPlanetPatrolData>();
		set => TrySetValue<GcShipAIPlanetPatrolData>(value);
	}

	public VirtualList<GcAIShipDebugSpawnData> DebugShipSpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcAIShipDebugSpawnData>(address + GetOffset()));
		set => TrySetValue<GcAIShipDebugSpawnData>(value);
	}

	public GcAISpaceshipGlobals(long address) : base(address)
	{

	}
}
