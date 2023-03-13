using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureGlobals : NMSTemplate
{
	public Int32 NumCreaturesRequiredForDiscoveryMission
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 AllCreaturesDiscoveredBonusMul
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Colour AllCreaturesDiscoveredColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public NMSString0x20A PetCarePuzzleOverrideID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Single CreatureInteractionRangeBoostHuge
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureInteractionRangeBoostLarge
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureInteractionRangeBoostMedium
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureInteractionRangeBoostSmall
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureInteractionRangeBoostRun
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureInteractionRangeBoostSprint
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureInteractionRangeReducePredator
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean CreatureInteractWithoutRaycasts
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single CreatureInteractBaseRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetInteractBaseRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<NMSString0x20A> Temperments
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 11));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> TempermentDescriptions
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 11));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> Diets
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 4));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> WaterDiets
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 4));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> DietMeat
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 16));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> DietVeg
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 16));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> DietDescriptions
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 4));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> WaterDietDescriptions
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 4));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> BiomeDescriptions
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 16));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> BiomeWaterDescriptions
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 16));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> BiomeAirDescriptions
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 16));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> WeirdBiomeDescriptions
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 27));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> PetBiomeClimates
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 16));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean IsHurtingCreaturesACrime
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EnableFlyingSnakeTails
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EnableNewStuff
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean InstantCreatureRide
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EnableVRCreatureRide
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EnableMPCreatureRide
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single RidingReplicationRangeMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RidingRollAdjustMaxAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RidingRollMaxAngleAt
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RidingFirstPersonOffsetFwd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RidingFirstPersonOffsetUp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureScaleMangle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean CreatureRideDirectControl
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean StaticCreatureRide
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single RideSpeedSlow
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RideSpeedFast
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RideSpeedChangeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RiderLeanTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PostRideMoveTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RideIdleTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinRideSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxCreatureSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxRideLeanCounterRotate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetMinSummonDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetMaxSummonDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetSummonRotation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlayerDamageTransferScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcSeed CreatureSeed
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public NMSString0x20A CreatureFilter
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Int32 MaxEcosystemCreaturesNormal
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxEcosystemCreaturesLow
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single LowPerfFlockReduce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean UncapSpawningforVideo
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AllowSpawningOnscreen
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single ResourceSpawnTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurnInPlaceIdleTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurnInPlaceMaxAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurnInPlaceMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurnInPlaceMaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurnInPlaceMaxSpeedIndoor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SceneTerrainSpawnMinDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureMinAlignSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PatrolMinDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PatrolMaxDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PatrolHeightOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PatrolGradientFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureWaryTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureMinRunTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureHearingRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureSightRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureMoveIdle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureTurnMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureTurnMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureBrakeForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureMinAnimMoveSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureLookBeforeGoingTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureLookBeforeFleeingTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureLookBeforeFleeingIfShotTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureLookScaryThingTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureLookPlayerForceLookTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LookMaxYawMoving
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LookMaxYawStatic
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LookPitchAtMaxYaw
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LookMaxPitchWhenMoving
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LookRollAtMaxYaw
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LookRollWhenMoving
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FootPlantError
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RecoverHealthTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCameraShakeData PainShake
	{
		get => GetValue<GcCameraShakeData>();
		set => TrySetValue<GcCameraShakeData>(value);
	}

	public Single PatrolSwitchMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExtraFollowStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExtraFollowFreq1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExtraFollowFreq2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SandWormChangeDirectionTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SandWormSteerAdjustTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SandWormMaxSteer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SandWormMaxHeightAdjust
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SandWormJumpHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SandWormJumpTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SandWormSubmergeDepth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SandWormSubmergeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SandWormSurfaceTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 SandWormMaxJumps
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single SandWormDespawnDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SandWormSpawnTimer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SandWormSpawnChanceMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SandWormSpawnChanceMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SandWormSpawnChanceInfested
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundWormSpawnRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundWormSpawnSpacing
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundWormSpawnTimeOut
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 GroundWormSpawnMin
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 GroundWormSpawnMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single GroundWormSpawnerActivateRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundWormSpawnerDestroyRadiusActive
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundWormSpawnerDestroyRadiusInactive
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundWormSpawnChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundWormScaleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundWormScaleMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShieldFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SharkAlongPathSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SwarmBrakingForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SharkToPathYDamp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SharkAttackSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SharkAttackAccel
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SharkPatrolSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SharkPatrolRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SharkPatrolEnd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SharkGetToPathSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SharkAlignSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FishBobFrequency
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FishBobAmplitude
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterJellyBobFrequency
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterJellyBobAmplitude
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InfluenceRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InfluenceForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InfluenceThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InfluenceDeflect
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TargetSearchTimeout
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttractMinDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SwarmMoveYFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneExplodeRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeaponRepelRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeaponRepelAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VelocityAlignStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VelocityAlignSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeightLookAhead
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxHeightTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlayerBirdDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FishSpeedMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FishSpeedMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FishSwimMaxAcceleration
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AlertDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RepelRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RepelAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FishTurn
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TargetReachedDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxTorque
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinWaterSpawnDepth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaterSpawnOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpawnDistanceModifierForUnderwater
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FootDustGroundTintStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StickToGroundSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StickToGroundCastBegin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StickToGroundCastEnd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AnimationStickToGroundSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcFlyingSnakeData FlyingSnakeData
	{
		get => GetValue<GcFlyingSnakeData>();
		set => TrySetValue<GcFlyingSnakeData>(value);
	}

	public VirtualList<GcCreatureAlertData> AlertTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureAlertData>(address + GetOffset()));
		set => TrySetValue<GcCreatureAlertData>(value);
	}

	public Boolean ShowScale
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single PetFootShakeModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureMedMinSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureLargeMinSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureHugeMinSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureRidingMedMinSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureRidingLargeMinSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureRidingHugeMinSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureBlobRidingMedMinSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureBlobRidingLargeMinSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureBlobRidingHugeMinSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 CreatureSmallHealth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 CreatureMedHealth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 CreatureLargeHealth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 CreatureHugeHealth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x10 CreatureLargeWalkShake
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single CreatureLargeWalkMaxShakeDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 CreatureLargeRunShake
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single CreatureLargeRunMaxShakeDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 CreatureHugeWalkShake
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single CreatureHugeWalkMaxShakeDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 CreatureHugeRunShake
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single CreatureHugeRunMaxShakeDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SmallCreaturePerceptionDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single largeCreaturePerceptionDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SmallCreatureFleePlayerDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LargeCreatureFleePlayerDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SmallCreatureAvoidPlayerDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LargeCreatureAvoidPlayerDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PredatorPerceptionDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PredatorFishPerceptionDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PassiveFleePlayerDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AdultBabyKilledNoticeDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PercentagePlayerPredators
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 PredatorSmallHealth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 PredatorMedHealth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 PredatorLargeHealth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 PredatorHugeHealth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single PlayerPredatorHealthModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PredatorApproachTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PredatorNoticePauseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PredatorStealthDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PredatorChargeDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PredatorChargeDistScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FishPredatorChargeDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FishPredatorChargeDistScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PredatorBoredomDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlayerPredatorBoredomDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PredatorRegainInterestTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlayerPredatorRegainInterestTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PredatorRunAwayDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PredatorRoarProbAfterHit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PredatorRoarProbAfterMiss
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PredatorRunAwayHealthPercent
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PredatorEnergyRecoverRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PredatorEnergyUseChasing
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean AggressiveSharks
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single DelayAfterRespawnBeforeAttackable
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IndoorTurnTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IndoorObstacleAvoidStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IndoorSteeringRayLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IndoorSteeringRaySphereSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IndoorSteeringRaySpread
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterSpawnDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterDespawnDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ScuttlersCanAttack
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 ScuttlerHealth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single ScuttlerInitialNoAttackTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScuttlerMoveTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScuttlerMoveTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScuttlerIdleTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScuttlerIdleTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScuttlerZigZagTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScuttlerZigZagTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScuttlerZigZagStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScuttlerSpitDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScuttlerSpitChargeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniDroneEnergyRecoverRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniDroneEnergyUsePerShot
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniDroneShotDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniDroneShotMaxAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean FiendsCanAttack
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean FiendOnscreenMarkers
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single FiendPounceDistanceModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 FiendHealth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single FiendPerceptionDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FiendSpawnDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FiendDespawnDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FiendReplicateStartDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FiendReplicateEndDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FiendAggroTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 FiendMaxEngaged
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 FiendMaxAttackers
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single FiendMaxVerticalForPounce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FiendZigZagSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FiendZigZagStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 FiendEggsToUnlockSpit
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxFiendsToSpawn
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single FiendMinSpawnTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FiendMaxSpawnTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FiendAggroIncreaseDamageEgg
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FiendAggroIncreaseDestroyEgg
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FiendAggroDecreasePerSpawn
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FiendCritAreaSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FiendDistToConsiderTargetSwtich
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FiendDistReduceForBeingShot
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FiendBeingShotMemoryTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MaxFishFiends
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 FishFiendSmallHealth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 FishFiendBigHealth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single FishFiendSmallBoostStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FishFiendSmallBoostTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FishFiendSmallScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FishFiendBigBoostStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FishFiendBigBoostTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FishFiendBigScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AsteroidCreatureSpawnPercentOverride
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AsteroidCreatureRichSystemSpawnPercent
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RoutineSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RoutineOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RagdollTau
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RagdollDamping
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RagdollConeLimit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RagdollTwistLimit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RagdollMotorFadeStart
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RagdollMotorFadeEnd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MaxRagdollsBeforeDespawnOffscreen
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxRagdollsBeforeDespawnOnscreen
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single TurnRadiusMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxTurnRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurnSlowAreaCos
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BadTurnPercent
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BadTurnWeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinScaleForNavMap
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ImpassabilityBrakeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ImpassabilityUnbrakeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ImpassabilityTurnSpeedMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NavMapLookAhead
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VelocityAlignYFactorMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VelocityAlignYFactorMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BrakingForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BrakingForceY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlowFieldWeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FollowWeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RidingSteerWeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AvoidCreaturesWeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AvoidImpassableWeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseAndTerrainModImpassableStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FollowLeaderAlignWeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FollowLeaderCohereWeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SoftenAvoidanceRadiusMod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterJellySwimSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandJellySwimSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceJellySwimSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DefaultSwimSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FastSwimSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DefaultWalkMoveSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DefaultTrotMoveSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DefaultRunMoveSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PredatorWalkMoveSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PredatorTrotMoveSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PredatorRunMoveSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeightDiffPenalty
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EdgeClosenessPenalty
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PelvisIkStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SteeringUpdateRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathOverestimate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FishWaterSurfaceAnticipate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FishWaterSurfaceAvoidStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FishDesiredDepth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FishMinHeightAboveSeaBed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FishSeaBedAvoidStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FishObstacleAvoidStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FishPlayerAttractionFrontDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FishPlayerAttractionAhead
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FishPlayerAttractionMinDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FishPlayerAttractionMaxDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FishPlayerAttractionStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackPlayerDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpawnCameraAngleCos
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpawnMinDistPercentage
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpawnOnscreenDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FadeScaleMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FadeScalePower
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FadeDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpawnDistAtMinSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpawnDistAtMaxSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DespawnDistFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ProcessPendingSpawnRequests
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single SpawnsAvoidBaseMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 PerceptionUpdateRate
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean AllowSleeping
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DebugDrawTrails
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single TrailHalfLife
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean EnableTrailIk
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single DetailAnimBlendInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DetailAnimBlendOutTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DetailAnimMinPauseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DetailAnimMaxPauseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean DetailAnimPlayWhileWalking
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 CreatureDeathEffectSmall
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 CreatureDeathEffectMedium
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 CreatureDeathEffectBig
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 FishDeathEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single FootParticleTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean PiedPiper
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single PetInteractTurnToFaceMinAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FollowPlayerDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FollowRunPlayerDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FollowRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetPlayerSpeedSmoothTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetStickySideBiasAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetWalkAtHeelChanceDevoted
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetWalkAtHeelChanceIndependent
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetWalkAtHeelDistMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetWalkAtHeelDistMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetRunAtHeelDistMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetRunAtHeelDistMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetHeelDistSwitchTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetHeelDistSwitchTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetRunAtHeelLateralShiftMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetRunAtHeelLateralShiftMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetHeelLateralShiftTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetHeelLateralShiftTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetWalkAtHeelLateralShift
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetHeelPosSpringTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcScanData PetScan
	{
		get => GetValue<GcScanData>();
		set => TrySetValue<GcScanData>(value);
	}

	public Single PetRadialCentre
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetRadialRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetRadialWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetRadialPulseMul
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetRadialPulseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetHeartMaxSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetHeartChangePerLayer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetHeartResponseLoopTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetHeartResponseTotalTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetLastActionReportTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetMoodSmoothTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetFollowRunPlayerDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetFollowRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour PetRadialBadColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour PetRadialNeutralColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour PetRadialGoodColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour PetRadialBoostColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single PetChatCooldown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetChatUseTraitTemplateChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetEffectSpawnOffsetSmall
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetEffectSpawnOffsetMed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetEffectSpawnOffsetLarge
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetEffectSpawnOffsetHuge
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetTickleChatChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetTreatChatChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean UseCreatureAdoptOSD
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single SearchItemDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SearchItemFrequency
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SearchItemGiveUpDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SearchItemGiveUpTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SearchItemNotifyTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SearchSpawnRandomItemProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiningRandomProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean DebugSearch
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 FriendlyCreatureLimit
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 FeedingTaskAmount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single FeedingFollowTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FeedingNoticeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FeedingNoticeDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttractedMinAvoidCreaturesStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttractedMinAvoidCreaturesDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttractedMaxAvoidCreaturesStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttractedMaxAvoidCreaturesDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean PetsShowTraitClassesAsWords
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 PetSlotsUnlockedByDefault
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 PetGrowthTime
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 PetIncubationTime
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 PetTrustChangeInterval
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single PetTrustOnAdoption
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetTrustOnHatch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetTrustIncreaseStep
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetTrustDecreaseStep
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetTrustIncreaseThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetTrustDecreaseThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetMinTrust
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetEggLayingDuration
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 PetEggLayingInterval
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 PetEggFirstEggDelay
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 PetEggModificationTime
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 PetEggModificationItemLimit
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x10 PetEggMaxChangeProduct
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single PetEggSubstanceModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetEggScaleRangeModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetEggScaleRangeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetEggTraitRangeModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetEggTraitRangeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetEggMinDistStep
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetEggMaxDistStep
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetEggOverdosageModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetEggMaxOverdosage
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetEggMaxTopDescriptorChangeChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetEggAccessoryChanceModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetEggMaxAccessoriesChangeChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetEggColourChanceModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetEggMaxColourChangeChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetEggHatchScaleChange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetEggHatchTraitChange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetEggHatchColourChangeChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPetBehaviours PetForceBehaviour
	{
		get => GetValue<GcPetBehaviours>();
		set => TrySetValue<GcPetBehaviours>(value);
	}

	public Single PetMaxSizeOffPlanet
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetTeleportDistOffPlanet
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetTeleportDistOnPlanet
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean PetCanSummonOnFreighter
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single PetAnimSpeedBoostSmallerThan
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetAnimSpeedBoostStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetAnimSpeedMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetAnimSpeedMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetNavRadForMinTurn
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetNavRadForMaxTurn
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetMinTurnRad
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetMaxTurnRad
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetMoodCurvePower
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcScanEffectData PetOffPlanetEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public NMSString0x80 PetEggResourceFile
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 PetEggHatchResourceFile
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Single PetEggHatchScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetEggHatchOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetEggMaxLonely
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetEggMaxHungry
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetEggMinGrowthToLay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean PetForceSummonFromEgg
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 PetEggsplosionEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean RidingPositionTest
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean PetAnimTest
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UsePetTeleportEffect
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single PetTeleportEffectTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetThrowArcRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour PetThrowArcColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single PetOrderMinRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetOrderMaxRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetAccessoryMoodDisplayThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetAccessoryStateInterval
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetInteractionLightHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetInteractionLightIntensityMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetInteractionLightIntensityMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour PetInteractionLightColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single AnimChangeCoolDown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroupRunProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroupBabyRunProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroupRunStormProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroupLookAtProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroupLookAtDurationMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroupLookAtDurationMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroupRunDurationMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroupRunDurationMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroupFemaleProportion
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroupBabyProportion
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroupBabyScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroupBabyHealthMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxBirdsProportion
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HerdGroupSizeMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean DrawRoutineFollowDebug
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DrawRoutineInfo
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single AdultCorrelationValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GrassHeightForMaxPush
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GrassHeightForMinPush
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GrassPushMaxStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GrassPushMinStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GrassPushMaxLimit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GrassPushMinLimit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GrassPushRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GrassPushMaxSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean DrawGrassPushRadius
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single CreatureIndoorSpeedMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureSpeedMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PredatorSpeedMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 DefaultKillingSubstance
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 AlienShipQuestKillingSubstance
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 AlienShipQuestCreatureWeapon
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> KillingSubstances
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 CreatureKillRewardAmountSmall
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 CreatureKillRewardAmountMed
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 CreatureKillRewardAmountLarge
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 CreatureKillRewardAmountHuge
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<GcCreatureSubstanceList> KillingProducts
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureSubstanceList>(address + GetOffset()));
		set => TrySetValue<GcCreatureSubstanceList>(value);
	}

	public VirtualList<GcCreatureHarvestSubstanceList> HarvestingProducts
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureHarvestSubstanceList>(address + GetOffset()));
		set => TrySetValue<GcCreatureHarvestSubstanceList>(value);
	}

	public Int32 CreatureHarvestAmountSmall
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 CreatureHarvestAmountMed
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 CreatureHarvestAmountLarge
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 CreatureHarvestAmountHuge
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single HarvestCooldownMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HarvestCooldownMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 BasicFeedingProduct
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 RobotFeedingProduct
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean AllBaitIsBasic
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CanAlwaysLayEgg
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcCreatureFoodList> HerbivoreFeedingProducts
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureFoodList>(address + GetOffset()));
		set => TrySetValue<GcCreatureFoodList>(value);
	}

	public VirtualList<GcCreatureFoodList> CarnivoreFeedingProducts
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureFoodList>(address + GetOffset()));
		set => TrySetValue<GcCreatureFoodList>(value);
	}

	public GcWeirdCreatureRewardList WeirdKillingRewards
	{
		get => GetValue<GcWeirdCreatureRewardList>();
		set => TrySetValue<GcWeirdCreatureRewardList>(value);
	}

	public VirtualList<NMSString0x10> LootItems
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single RockTransformGlobalChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<Single> RockTransformChanceModifiers
	{
		get => cache.GetOrAddValue(new VirtualList<Single>(address + GetOffset()));
		set => TrySetValue<Single>(value);
	}

	public Single AngryRockProportionNormal
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AngryRockProportionSurvival
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 PauseBetweenCreatureSpawnRequests
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single CreatureUpdateRateMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCreatureGlobals(long address) : base(address)
	{

	}
}
