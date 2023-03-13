using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSpaceshipGlobals : NMSTemplate
{
	public Single ShieldLeechMul
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AtmosphereCombatHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 SailShipCoreTechID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean AllowSideScreenPointing
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AddShipToCollectionOnEnter
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EnablePulseDriveSpaceStationOrient
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single DockingApproachRollHmdMod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DockingApproachSpeedHmdMod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DockingApproachBrakeHmdMod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandingDirectionalSideOffsetFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandingHoverOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandingMaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandingMaxAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandingMargin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandingObstacleMinHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandingTooManyLowPointsFraction
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VignetteAmountAcceleration
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VignetteAmountTurning
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseDriveBoostDoubleTapTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RudderToRollMultiplierMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RudderToRollMultiplierMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RudderToRollMultiplierOpposite
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RudderToRollMultiplierSpace
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RudderToRollMultiplierLow
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RudderToRollCutoffRotation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RudderToRollUpsideDownRotation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType RudderToRollCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single RudderToRollAngleUpMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RudderToRollAngleDownMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RudderToRollAngleDownMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseDriveStationApproachAngleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseDriveStationApproachAngleRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseDriveStationApproachPerpAngleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseDriveStationApproachPerpAngleRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseDriveStationApproachOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseDriveStationApproachSlowdown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseDriveStationApproachSlowdownRangeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseDriveStationApproachSlowdownRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControllerActiveBlendMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControllerActiveBlendTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f HandControllerValueMultiplier
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f HandControllerValueMultiplierSpace
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f HandControllerDeadZone
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f HandControllerExtents
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single HandControllerXReorientationMove
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControllerZReorientationMove
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControllerXReorientation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControllerZReorientation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControllerThrottleDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControllerThrottleRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControllerThrottleDeadZone
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControllerDirOffsetAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControllerDirOffsetAngleMove
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CockpitRollAngleHmd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CockpitPitchCorrectAngleHmd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CockpitDriftAngleHmd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CockpitRollAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CockpitPitchCorrectAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CockpitDriftAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CockpitRollAngleExtra
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CockpitRollTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CockpitRollMultiplierCentre
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CockpitRollMultiplierOpposite
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaximumDistanceFromShipWhenExiting
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaximumHeightWhenExitingShip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceFromShipToAllowSpawningOnFreighter
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterBattleIgnoreFriendlyFireDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean AltControls
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SpaceMapInWorld
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean _3rdPersonShipEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AimZoomAuto
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EnableDepthTestedCrosshairSections
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CritsFromBehind
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DrawLineLockTarget
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ApplyHeightForce
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ApplyHeightAlign
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DoPreCollision
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SpeedTrackModeEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 TrailMaxNumPointsPerFrameOverride
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single TestTrailSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TestTrailRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CockpitExitAnimTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CockpitExitAnimOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType CockpitExitAnimCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single WingmanSpeedTrackForceMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanSpeedTrackForceMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanSpeedTrackDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanSpeedTrackOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanSpeedApproachSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanSpeedApproachSpeedSpace
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DockingAttractAlign
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DockingAttractAlignRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour LandingEffectSpaceColourOverride
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour GroundEffectBuildingColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour GroundEffectWaterColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single GroundNearEffectLightFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundNearEffectWaterLightFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundWaterSpeedFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AtmosphereLightIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f AtmosphereLightOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single OutpostDockSpeedAlignMinDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OutpostDockSpeedAlignRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NearGroundPitchCorrectMinHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NearGroundPitchCorrectRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NearGroundPitchCorrectMinHeightRemote
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NearGroundPitchCorrectRangeRemote
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpMarkerApproachSlowdown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpMarkerAlignSlowdown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpMarkerAlignSlowdownRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpAlignSlerp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpInFlashTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpInRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpInTimeFreighter
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpInFlashTimeFreighter
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpInRangeFreighter
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpScaleFreighter
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpFadeInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpInLineWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType WarpInCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single WarpOutRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpOutTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpInTimeNexus
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpInFlashTimeNexus
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpInRangeNexus
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpScaleNexus
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpNexusRotation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpNexusPitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpNexusDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NetworkDockSearchRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DirectionDockingIndicatorRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DirectionDockingIndicatorClearAngleRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DirectionDockingIndicatorAngleRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DirectionDockingIndicatorMinHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DirectionDockingIndicatorMaxHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour DirectionDockingInRangeColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour DirectionDockingOutRangeColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single DirectionDockingCircleOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DirectionDockingCircleOffsetExtra
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DirectionDockingCircleWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DirectionDockingCircleRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DirectionDockingCircleRadiusExtra
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DirectionDockingIndicatorSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType DirectionDockingIndicatorCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single ExhaustSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LowAltitudeAnimationHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LowAltitudeAnimationHysteresisTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LowAltitudeAnimationTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LowAltitudeContrailFadeAtAnimProgress
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundNearEffectHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundNearEffectRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundNearEffectNormalOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundNearEffectBuildingFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean TestShipAnims
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single TestShipAnimRoll
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TestShipAnimThrust
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TestShipAnimPulse
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TestShipAnimSpace
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TestShipAnimLowAltitude
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcSpaceshipAvoidanceData Avoidance
	{
		get => GetValue<GcSpaceshipAvoidanceData>();
		set => TrySetValue<GcSpaceshipAvoidanceData>(value);
	}

	public Single DefaultTrailInitialSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DefaultTrailSpeedDamping
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DefaultTrailMinForwardSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrailVelocityFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ContrailSpeedDamping
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxOverspeedBrake
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PostWarpSlowDownTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PostFreighterWarpTransitionTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseDrivePlanetApproachMinAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseDrivePlanetApproachMaxAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseDrivePlanetApproachHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TestJetsStage1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TestJetsStage2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TestJetsBoost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TestTrailThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ContrailDefaultAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EngineJetLightIntensityMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EngineEffectsThrustContribution
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TestShieldEffect
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShieldEffectHitTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType ShieldEffectHitCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public GcScanEffectData ShieldEffectScanData
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public Single AcrobaticLowFlightLevel
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonUpOffsetRollChangeSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonRollAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonRollAngleDropship
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonRollAngleScience
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonRollAngleAlien
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonPitchAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonYawAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonYawAngleLateralExtra
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonAngleSpringTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonAngleMinSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonAngleSpeedRangePitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonAngleSpeedRangeYaw
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonLowHeightMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonLowHeightMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonLowHeightOffsetVertRotationY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonLowHeightOffsetY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonLowHeightSpringTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonAvoidanceAdjustPitchFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonHeightForceAdjustPitchFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonAvoidanceAdjustRollFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonAvoidanceAdjustYawFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonFlashIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonFlashDuration
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonTransitionTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonWarpXWander
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonWarpYWander
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonWarpZWander
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonWarpWanderStartTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonWarpWanderSpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonWarpWanderTimeX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonWarpWanderTimeY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single _3rdPersonWarpWanderTimeZ
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType _3rdPersonWarpWanderCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single AvoidancePower
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AvoidanceDistancePower
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CollisionDeflectForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CollisionAlignStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f DefaultCentreOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f DefaultCentreOffsetDropship
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f DefaultCentreOffsetScientific
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f DefaultCentreOffsetRoyal
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f DefaultCentreOffsetSail
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single WeaponDamagePotentialReferenceRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DirectionBrakeVerticalMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LateralDriftRollAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LateralDriftRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PadTurnSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PadThrustSmoothTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single KBThrustSmoothTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverTakeoffHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverAlignTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverTimeAlt
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverAlignTimeAlt
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverSpeedFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverHeightFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverMinSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverLandReachedMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverLandReachedDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverLandManeuvreTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverLandManeuvreTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverLandManeuvreTimeHmdMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverLandManeuvreTimeHmdMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverLandManeuvreBrake
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandingOnGroundTip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean LandingCheckBuildings
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single LandingCheckBuildingRadiusFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AutoLevelWaterMargin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AutoLevelWaterTorque
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AutoLevelWaterAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AutoLevelPitchCorrectMargin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f PostCollisionAngularFactor
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single DrawLineLockTargetLineWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageFlashScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageFlashMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandingButtonMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandingPushNoseUpFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundHeightSoftForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundHeightSoft
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundHeightSoftHorizontal
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType GroundHeightSoftCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single GroundHeightHard
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundHeightHardHorizontal
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType GroundHeightHardCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single GroundHeightPostCollisionMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundHeightPostCollisionMultiplierTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundHeightDownSpeedMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundHeightBrakeMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PitchCorrectDownSpeedMinSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PitchCorrectDownSpeedRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PitchCorrectDownSpeedSoftAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PitchCorrectDownSpeedMaxDownAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PitchCorrectDownSpeedHeightMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PitchCorrectDownSpeedHeightMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PitchCorrectCockpitSpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PitchCorrectSoftDownAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PitchCorrectMaxDownAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PitchCorrectMaxDownAnglePostCollision
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PitchCorrectSoftDownAnglePostCollision
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PitchCorrectMaxDownAngleWater
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PitchCorrectSoftDownAngleWater
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PitchCorrectTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PitchCorrectTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PitchCorrectTimeHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PitchCorrectHeightSpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PitchCorrectHeightMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PitchCorrectHeightMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType PitchCorrectHeightCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public TkCurveType LandingCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public TkCurveType LandingCurveHeavy
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public GcPlayerSpaceshipControlData Control
	{
		get => GetValue<GcPlayerSpaceshipControlData>();
		set => TrySetValue<GcPlayerSpaceshipControlData>(value);
	}

	public GcPlayerSpaceshipControlData ControlLight
	{
		get => GetValue<GcPlayerSpaceshipControlData>();
		set => TrySetValue<GcPlayerSpaceshipControlData>(value);
	}

	public GcPlayerSpaceshipControlData ControlHeavy
	{
		get => GetValue<GcPlayerSpaceshipControlData>();
		set => TrySetValue<GcPlayerSpaceshipControlData>(value);
	}

	public GcPlayerSpaceshipClassBonuses ControlBonusC
	{
		get => GetValue<GcPlayerSpaceshipClassBonuses>();
		set => TrySetValue<GcPlayerSpaceshipClassBonuses>(value);
	}

	public GcPlayerSpaceshipClassBonuses ControlBonusB
	{
		get => GetValue<GcPlayerSpaceshipClassBonuses>();
		set => TrySetValue<GcPlayerSpaceshipClassBonuses>(value);
	}

	public GcPlayerSpaceshipClassBonuses ControlBonusA
	{
		get => GetValue<GcPlayerSpaceshipClassBonuses>();
		set => TrySetValue<GcPlayerSpaceshipClassBonuses>(value);
	}

	public GcPlayerSpaceshipClassBonuses ControlBonusS
	{
		get => GetValue<GcPlayerSpaceshipClassBonuses>();
		set => TrySetValue<GcPlayerSpaceshipClassBonuses>(value);
	}

	public Single HaulerTakeOffMod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FighterTakeOffMod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShuttleTakeOffMod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExplorerTakeOffMod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RoyalTakeOffMod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour AlarmLightColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour AlarmLightColourHostile
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public VirtualList<Vector3f> AlarmLightOffsets
	{
		get => cache.GetOrAddValue(new VirtualList<Vector3f>(address + GetOffset()));
		set => TrySetValue<Vector3f>(value);
	}

	public Single AlarmLightIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AlarmRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AlarmLightIntensityHostile
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AlarmRateHostileMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AlarmRateHostileMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AlarmLastHitTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LockTargetMinDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LockTargetRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LockTargetMinScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LockTargetMaxScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AutoLevelMinPitchAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AutoLevelMaxPitchAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AutoLevelMinAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AutoLevelMaxAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean AutoEjectOnLanding
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean LandedCockpitFreeLook
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single FrigateTargetLockRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ResetTargetLockAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TargetLockRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TargetLockNearestAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RemotePlayerLockTimeAfterShot
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour TargetLockPassiveColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour TargetLockDangerColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single ShieldRechargeMinHitTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShieldRechargeRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NoBoostStationDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NoBoostAnomalyDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NoBoostSpaceAnomalyDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NoBoostFreighterDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NoBoostFreighterAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NoBoostShipDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NoBoostShipNearMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NoBoostShipLastHitTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NoBoostCombatEventMinBattleTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NoBoostCombatEventMinFreighterBattleTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NoBoostCombatEventTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThrustDecaySpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThrustDecaySpringCombat
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DriftEffectIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpeedCoolOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpeedCoolNormalSpeedAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 HitAsteroidDamage
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single CameraPostWarpFovTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CameraPostWarpFov
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlayerFreighterClearSpaceRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DriftSpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DriftTurnStrengthMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DriftTurnBrakeMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DirectionBrakeVRBoost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurnRudderStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MuzzleLightIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MuzzleAnimSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkHitCurveData MuzzleLightCurve
	{
		get => GetValue<TkHitCurveData>();
		set => TrySetValue<TkHitCurveData>(value);
	}

	public Colour MuzzleLightColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Vector3f DamageLightOffsetTop
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f DamageLightOffsetLeft
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f DamageLightOffsetRight
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single DamageLightIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkHitCurveData DamageLightCurve
	{
		get => GetValue<TkHitCurveData>();
		set => TrySetValue<TkHitCurveData>(value);
	}

	public Colour DamageLightColourShield
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour DamageLightColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Boolean AltAtmosphere
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single AsteroidHitAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AsteroidHitAngleBoosting
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimCritAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimCritMinFwdAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimCritBehindAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissileShootTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CruiseHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CruiseHeightRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CruiseOffAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CruiseOffAngleRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CruiseForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverMaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverStopTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimFoVBoost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimFoVBoostTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimFoVBoostTimeAuto
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimTurnSlower
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimMaxAutoAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverBrakeStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StickyTurnMinAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StickyTurnAngleRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StickyTurnLow
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StickyTurnHigh
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StickyStickAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipMotionDeadZone
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f DeathSpinRoll
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f DeathSpinPitch
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Int32 MiniWarpLinesNum
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single MiniWarpLinesSpacing
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpLinesOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpLinesHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GravityDropMinHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GravityDropMaxForceHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GravityDropMaxHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GravityDropForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPlayerStickData StickData
	{
		get => GetValue<GcPlayerStickData>();
		set => TrySetValue<GcPlayerStickData>(value);
	}

	public Single ResourceCollectOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimSpeedTrackDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimSpeedTrackForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CombatBoostMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CombatBoostTurnDamp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MarkerEventTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 GunAmmoMultiplier
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<GcPlayerSpaceshipAim> LaserAimArray
	{
		get => cache.GetOrAddValue(new VirtualList<GcPlayerSpaceshipAim>(address + GetOffset()));
		set => TrySetValue<GcPlayerSpaceshipAim>(value);
	}

	public Int32 LaserAimLevel
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<GcPlayerSpaceshipAim> GunAimArray
	{
		get => cache.GetOrAddValue(new VirtualList<GcPlayerSpaceshipAim>(address + GetOffset()));
		set => TrySetValue<GcPlayerSpaceshipAim>(value);
	}

	public Int32 TakeOffCost
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 LandingCost
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 GunAimLevel
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcPlayerSpaceshipAim MissileAim
	{
		get => GetValue<GcPlayerSpaceshipAim>();
		set => TrySetValue<GcPlayerSpaceshipAim>(value);
	}

	public Single MissileLockSpeedUp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissileLockTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AutoPilotAlignStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AutoPilotSmallShipAlignStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AutoPilotCallDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AutoPilotCallAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AutoPilotCallAngleVertical
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AutoPilotPositionAlignStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterApproachDistanceMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterApproachDistanceMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterApproachSpeedDamper
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterApproachExtraMargin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpShakeStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpPlanetRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpStationRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpFuelTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpAlignStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpChargeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpTopSpeedTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpCooldownTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpStoppingMarginPlanet
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpMinPlanetDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpStoppingMarginDefault
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpStoppingMarginLong
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpTrackingMargin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpExitSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpExitSpeedStation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpExitTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpHUDArrowAttractAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpHUDArrowAttractAngleStation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpHUDArrowAttractAngleOtherPlayerStuff
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpHUDArrowAttractAngleSaveBeacon
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpHUDArrowAttractAngleDense
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MiniWarpHUDArrowNumMarkersToBeDense
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkCurveType MiniWarpCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single MiniWarpFlashIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpFlashDuration
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpFlashDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniWarpNoAsteroidRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BoostNoAsteroidRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipHeatAlertTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaserOverheatTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaserOverheatDownTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaserCoolFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaserFireTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaserWaitTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ProjectileOverheatTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ProjectileFireRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ProjectileReloadTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 ProjectileClipSize
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single SummonShipAnywhereHeightOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SummonShipAnywhereFwdOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SummonShipAnywhereRangeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SummonShipAnywhereRangeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SummonShipHeightOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SummonShipApproachOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandingHelperMinAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandingHelperTurnTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandingHelperRollTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AnomalyStationMaxApproachSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TakeOffSphereCastLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TakeOffSphereCastRadiusMul
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandGroundTakeOffTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandLookingForward
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandHeightThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandWidthThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandSlopeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandingAreaRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandingAreaFloorOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TargetLockTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TargetLockChangeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TargetLockLoseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BoostChargeRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageMinHitTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageMaxHitTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageMinWoundTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceBrakeMinAngularSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceBrakeAngularRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CollisionSpeedDamageAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CollisionDeflectTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CollisionDeflectDamping
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CollisionDeflectNormalFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CollisionAsteroidDamp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CollisionGroundDamp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CollisionDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CollisionDistanceGround
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CollisionDistanceAsteroid
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CollisionDistanceAsteroidSide
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CollisionDistanceSpaceships
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DeflectDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DeflectAlignTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DeflectAlignTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType DeflectCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single CollisionRadiusMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundHeightHardTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundHeightHardTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundHeightPostCollisionDamper
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundHeightSpeedLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundHeightSpeedAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundHeightSpeedAngleRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 GroundHeightNumRays
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single GroundHeightSmoothTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LinearDamping
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AngularDamping
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DirectionDockingAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DirectionDockTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DirectionDockingInfoRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LootAttractDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LootAttractTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LootDampForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LootCollectDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GunOffset3rdPersonMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f GunOffsetLeft
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f GunOffsetRight
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f GunOffsetLeft2
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f GunOffsetRight2
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f GunOffset3rdPersonLeft
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f GunOffset3rdPersonRight
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public GcPlayerSpaceshipWarpData Warp
	{
		get => GetValue<GcPlayerSpaceshipWarpData>();
		set => TrySetValue<GcPlayerSpaceshipWarpData>(value);
	}

	public Single DockingRotateSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DockingRotateSpeedVR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EjectAnimSwitchPoint
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EjectAnimSpeedFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipDifferentRepelRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipDifferentRepelAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AtmosphereSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AtmosphereAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneAlignUpTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneDustHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneMinHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneHeightAdjust
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneWarpTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneWarpMinForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneWarpMaxForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f CockpitScale
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single ShakePowerScaler
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShakeSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShakeMaxPower
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShakeMaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShakeAlignBrake
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanAtTimeStart
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

	public Single WingmanAttackOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanAttackRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanAttackMinRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanAttackAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanViewerAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanAttackAimAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanAttackTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanAttackTimeout
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanAttackCoolTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanSpawnDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanAlign
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanAngle2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanFwd1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WingmanFwd2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DronePlanetAttackRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DronePlanetAttackMinRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneShootTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneAlertAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneAlertRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DronePatrolRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneMoveArrivedRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DronePatrolTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipEnterRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipEnterAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipEnterTransitionTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipEnterSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipEnterMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<NMSString0x80> ShipModels
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x80>(address + GetOffset()));
		set => TrySetValue<NMSString0x80>(value);
	}

	public Single HUDBoostUpgradeMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaunchThrustersRegenTimePeriod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaunchThrustersMinimumSummonPercentage
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaunchThrustersSummonCostMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpeedUpDistanceThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpeedUpDistanceFadeThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpeedUpVelocityThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpeedUpVelocityCoeff
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxSpeedUpDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxSpeedUpVelocity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StickLandThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StickPulseThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f StickAnimationDamping
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single SpaceCombatFollowModeMaxTorque
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceCombatFollowModeAimTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceCombatFollowModeTargetDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceCombatFollowModeEvadeRoll
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceCombatFollowModeEvadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceCombatFollowModeBrakeBehindAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceCombatFollowModeMaxBrakeBehind
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceCombatFollowModeMaxBrakeHeadOn
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceCombatFollowModeEvadeThrust
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean SpaceCombatFollowModeUseEvadeTarget
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SpaceCombatFollowModeUseBoost
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcSpaceshipGlobals(long address) : base(address)
	{

	}
}
