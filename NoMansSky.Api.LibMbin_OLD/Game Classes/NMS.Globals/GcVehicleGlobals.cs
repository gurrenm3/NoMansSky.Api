using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcVehicleGlobals : NMSTemplate
{
	public Single UnderwaterScannerIconRangeBoost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleSolarRegenFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 VehicleStrongLaser
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 MechStrongLaser
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 SentinelRightArmTech
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 SentinelLeftArmTech
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20A SentinelRightArmTechNameOverride
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x10 SentinelRightLeftArmLaserData
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean UseFirstPersonCamera
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single LevelVehicleCameraFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ShowAllCheckpoints
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single ControlStickRecenterSpeedDegPerSec
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SteeringWheelPushRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SteeringWheelPitchAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SteeringWheelSpringBothHands
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SteeringWheelSpringOneHand
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SteeringWheelCentreOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType SteeringWheelOutputCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single RemoteBoostingEffectTimeout
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TestFrictionStat
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TestSkidFrictionStat
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean TestAnims
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single TestAnimThrust
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TestAnimBoost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TestAnimTurn
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VisualTurnUnderwaterSpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VisualTurnSpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour DefaultBoosterColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single WheelDustColourLightFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f MechMovementStickSpeedLimit
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f MechLookStickSpeedLimit
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Int32 DamageTechNumHitsRequired
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single DamageTechMinHitIntervalSeconds
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechAIResummonTriggerDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechAIResummonMinSpawnDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechAIResummonMinSpeedForVelBasedSpawnPos
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechAIResummonVelBasedSpawnSpeedMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean MechStrafeEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean MechAltJumpMode
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single MechContrailAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechJetpackJetScaleTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 MechLandingImpactEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 MechJetpackEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 MechJetpackLaunchEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 MechJetpackLaunchGroundEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single MechPlayerGroundTurnSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechAIGroundTurnSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechJetpackTurnSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechArmPitchAngleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechArmPitchAngleMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechArmPitchLerpSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 MechArmPitchAnimLeft
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 MechArmPitchAnimRight
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single MechMaxTurnAngleWhileStationary
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechTurretTurnTimeGround
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechTurretMaxAngleGround
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechTurretTurnTimeGroundPlayerCombat
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechTurretTurnTimeAir
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechTurretMaxAngleAir
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechTurretTimeVRModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f MechCrouchOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f MechWalkBackwardsCoGOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single MechCoGAdjustTimeWindUp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechCoGAdjustTimeAir
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechCoGAdjustTimeLand
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechCrouchTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechWalkToRunTimeIdle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechWalkToRunTimeSkid
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechArmSwingAngleWalk
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechArmSwingPhaseWalk
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType MechArmSwingCurveWalk
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single MechArmSwingAngleFastWalk
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechArmSwingPhaseFastWalk
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType MechArmSwingCurveFastWalk
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single MechLandBrake
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechJetpackStrafeStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechJetpackLandTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechJetpackForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechJetpackBrake
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechJetpackMaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechJetpackMaxUpSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechJetpackUpForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechJetpackAvoidGroundForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechJetpackFallForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechJetpackAvoidGroundProbeLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechJetpackIgnitionForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechJetpackIgnitionTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechJetpackMaxCoGAdjustX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechCameraOffsetTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechCameraOffsetAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechJetpackDrainRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechJetpackFillRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechDefaultBlendTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechSpeedBlendTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechLandBlendTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechJumpBlendTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechJumpFlyBlendTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechJumpDownBlendTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechIdleLowBlendTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechIdleLowDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechIdleStopDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechFirstPersonTurretTurnModerator
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechFirstPersonTurretPitchModerator
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean MechFirstPersonTurretTweaksEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single MechFirstPersonTurretShootTimer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechFirstPersonTurretBaseThrottleThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechFirstPersonIgnoreReverseThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechFirstPersonTurretThrottleLookThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechFirstPersonTurretBaseTurnThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechFirstPersonTurretAngleThrottleThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechFirstPersonTurretAngleThrottleStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechFirstPersonDamping
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechFirstPersonStickXModerator
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechFirstPersonMaxTurnTurret
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechFirstPersonMaxLookTurret
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechFirstPersonCrouchAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechPowerUpTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechCockPitBobX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechCockPitBobY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechCockPitBobPitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechCockPitBobRoll
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechCockPitBobYaw
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechCockPowerDownY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechTitanFallHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean MechTitanFallTerrainEditEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single MechTitanFallTerrainEditSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechTitanFallTerrainEditOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechTitanFallLandIdleTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechTitanFallLandIntroTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechTitanFallCameraShakeDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechLandCameraShakeDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechFootprintFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechFootprintFadeDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcMechAudioEventTable MechAudioEventTable
	{
		get => GetValue<GcMechAudioEventTable>();
		set => TrySetValue<GcMechAudioEventTable>(value);
	}

	public Single AIMechLaserFireDurationMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AIMechLaserFireDurationMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 AIMechGunProjectile
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single AIMechGunFireInterval
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 AIMechGunNumShotsMin
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 AIMechGunNumShotsMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single AIMechGunExplosionRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AIMechGunInheritVelocity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechWeaponInterpSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<NMSString0x20> MechWeaponLocatorNames
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20>(address + GetOffset(), 4));
		set => TrySetValue<NMSString0x20>(value);
	}

	public VirtualArray<GcExoMechWeaponData> MechWeaponData
	{
		get => cache.GetOrAddValue(new VirtualArray<GcExoMechWeaponData>(address + GetOffset(), 4));
		set => TrySetValue<GcExoMechWeaponData>(value);
	}

	public GcMechMeshPartTable MechMeshPartsTable
	{
		get => GetValue<GcMechMeshPartTable>();
		set => TrySetValue<GcMechMeshPartTable>(value);
	}

	public Single WeaponInterpSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SubmarineMinSummonDepth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SubmarineEjectRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SubmarineEjectDownOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SubmarineFirstPersonSteeringSensitivity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FirstPersonSteeringAdditionalForward
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FirstPersonSteeringAdditionalForwardThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FirstPersonSteeringAdditionalReverseThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FirstPersonSteeringMinThrottleHardLeftRight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FirstPersonSteeringLowSpeedTurnDamping
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f FirstPersonNonVRCameraOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f FirstPersonNonVRCameraOffsetMech
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single UnderwaterBuoyancySurfaceOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterBuoyancyRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterSummonSurfaceOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterSurfaceTension
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterSurfaceOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterSurfaceGravity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterFlattenMinDepth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterFlattenRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterSurfaceForceFlatteningAngleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterSurfaceForceFlatteningAngleRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterSurfaceSplashdownForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterSurfaceSplashdownMinSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterJumpForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcSpaceshipAvoidanceData UnderwaterAvoidance
	{
		get => GetValue<GcSpaceshipAvoidanceData>();
		set => TrySetValue<GcSpaceshipAvoidanceData>(value);
	}

	public VirtualList<Vector3f> UnderwaterBubbleOffset
	{
		get => cache.GetOrAddValue(new VirtualList<Vector3f>(address + GetOffset()));
		set => TrySetValue<Vector3f>(value);
	}

	public Single HeadlightIntensitySpringTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean VehicleAltControlScheme
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single VehicleAltControlStickSmoothInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleAltControlStickSmoothOutTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleBoostSpeedMultiplierPercent
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleGarageHologramMinFadeRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleGarageHologramFadeRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CheckpointPlacementOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CheckpointPlacementRayLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CheckpointDeleteDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CheckpointDeleteAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BoostPadTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BoostPadStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DisablePhysicsRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RaceMultipleStartOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RaceMultipleStartCaptureRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiningLaserDrainSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ProjectileDrainPerShot
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RaceStartSpawnUpOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RaceInteractRespawnOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RaceInteractRespawnUpOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StickTurnReducer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StickTurnReducerVR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StickTurnReducerAlt
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TravelSpeedReportReducer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HornScareRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HornScareFleeRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HornScareTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttractAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttractMaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttractAlign
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttractDirectionBrakeThresholdSq
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExitStopTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExitStopForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GunFireRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SummoningRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CheckpointRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RaceCooldown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean RaceFinishAtStart
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single RaceResetFlashDuration
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RaceResetFlashIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CheckpointFlashDuration
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CheckpointFlashIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour CheckpointBeamColourActive
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour CheckpointBeamColourNormal
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public VirtualList<NMSString0x10> DefaultBuggyLoadout
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> DefaultBikeLoadout
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<NMSString0x10> DefaultTruckLoadout
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single CheckpointBeamSizeNormal
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CheckpointBeamSizeActive
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CheckpointBeamOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpawnRotation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechSpawnRotation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiningLaserRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MiningLaserMiningDamage
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MiningLaserDamage
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single MiningLaserSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 GunBaseDamage
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 StunGunBaseDamage
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single StunGunFireRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 GunBaseMiningDamage
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single ResourceCollectOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleWheelNoise
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleWheelNoiseScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelSideVerticalFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SuspensionDamping
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SuspensionDampingAngularFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ShowTempVehicleMesh
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShowVehicleDebugging
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShowVehicleWheelGuards
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShowVehicleText
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single VehicleTextSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ShowVehicleParticleDebug
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean VehicleDrawAudioDebug
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single VehicleSuspensionAudioSpacing
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleSuspensionAudioDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleSuspensionAudioScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleSuspensionAudioTrigger
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleMinSummonDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleMaxSummonDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleMaxSummonDistanceUnderwater
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleDeactivateRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleBoostFuelRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleBoostFuelRateSurvival
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleFuelRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleFuelRateTruckMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleJumpTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleJumpTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleJumpCooldown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleMotionDeadZone
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WheelForceHalflife
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ThrottleButtonCamRelative
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single StickReverseTurnThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StickReverseTurnStiffness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcScanData VehicleScan
	{
		get => GetValue<GcScanData>();
		set => TrySetValue<GcScanData>(value);
	}

	public GcScanData VehicleLocalScan
	{
		get => GetValue<GcScanData>();
		set => TrySetValue<GcScanData>(value);
	}

	public VirtualArray<GcVehicleMuzzleData> VehicleWeaponMuzzleFlash
	{
		get => cache.GetOrAddValue(new VirtualArray<GcVehicleMuzzleData>(address + GetOffset(), 7));
		set => TrySetValue<GcVehicleMuzzleData>(value);
	}

	public VirtualList<GcVehicleWeaponMuzzleData> VehicleWeaponMuzzleDataTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcVehicleWeaponMuzzleData>(address + GetOffset()));
		set => TrySetValue<GcVehicleWeaponMuzzleData>(value);
	}

	public VirtualList<GcVehicleData> VehicleDataTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcVehicleData>(address + GetOffset()));
		set => TrySetValue<GcVehicleData>(value);
	}

	public GcVehicleGlobals(long address) : base(address)
	{

	}
}
