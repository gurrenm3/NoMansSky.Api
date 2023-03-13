using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCharacterGlobals : NMSTemplate
{
	public Single PitchTest
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RollTest
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaterEffectHeightOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaterEffectHeightRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaterEffectFadeSpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaterEffectSpeedFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaterEffectSpeedFadeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaterEffectSpeedOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaterEffectMinScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaterEffectSideOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaterEffectRearOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaterEffectRearBackOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CharacterRotationOffsetY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CharacterRoughHeadHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x80 CharacterFile
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcSeed CharacterSeedOverride
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public Single DontShowCharacterWithinCameraDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CharacterTurnSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CharacterRunTurnSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CharacterJetpackTurnSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CharacterJetpackTurnAimSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CharacterTurnAimSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CharacterSwimmingTurnSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CharacterSwimmingTurnAimSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RocketBootsLandedTurnSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RocketBootsTurnSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FeetShiftOnTurnSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FeetShiftOnTurnMaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinTurnAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single YawPullSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GunRotationSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimPitchAnimScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimYawAnimScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimPitchInterpSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinSwimmingPitchRotation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxSwimmingPitchRotation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JetpackSwimmingPitchRotation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinSwimmingRollRotation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxSwimmingRollRotation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SwimmingSmoothTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SwimmingSmoothTimeWithWeapon
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SwimmingRollSmoothTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SwimmingRollSmoothTimeWithWeapon
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LadderDistanceToAutoMount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LadderCooldownAfterBeforeAutoClimb
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 LadderClimbIdle
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 LadderClimbUp
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 LadderClimbDown
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 LadderMountBottom
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 LadderDismountBottom
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 LadderMountTop
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 LadderDismountTop
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single SlopeAngleForUphillClimb
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SlopeAngleForDownhillClimb
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SlidingBrake
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SlopeAngleForSlide
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UphillSpeedMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrudgeUphillSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxAnkleRotationAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RotateToFaceSlopeSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TimeNotOnGroundToBeConsideredInAir
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TimeNotOnGroundToUseFallingCamera
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TimeFallingUntilPanic
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BankingMinimumSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BankingMaxStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BankingSpeedForMaxStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinimumIdleToJogAnimSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RootedAnimInterpolationTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IKLegStretchStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IkBlendStrengthSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FootPlantedTolerance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FootPlantSpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BlendToNewFeetSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TimeAfterDeathRagdollIsEnabledForward
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TimeAfterDeathRagdollIsEnabledBackward
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TimeAfterDeathRagdollIsEnabledWhenBlocked
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

	public Single MinStickForIntoJogAnim
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SmoothVelocitySpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TimeToShowSplashEffect
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterToAirTolerance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaterBottomSmoothPushUp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaterBottomSmoothPushUpDepth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SitPostureChangeTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SitPostureChangeTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean NPCUseBehaviourTree
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean NPCLightsAlwaysOn
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcNPCPropType NPCForceProp
	{
		get => GetValue<GcNPCPropType>();
		set => TrySetValue<GcNPCPropType>(value);
	}

	public Single NPCPropScaleTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCReactionChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCReactCooldown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCIKBodyWeightNormalGek
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCIKBodyWeightNormal
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCIKBodyWeightSeated
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCSpineAdjustGek
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCSpineAdjustVykeen
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCAnimSpeedMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCAnimSpeedMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCBehaviourTimeModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean NPCBehaviourInfo
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single NPCStaticDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCStaticTimeUntilFail
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCPermittedNavigationDelayFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 NPCNumNavFailuresUntilNoPhysFallback
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single NPCWalkSpeedMech
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCWalkSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCWalkSpeedGek
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCRunSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCRunSpeedGek
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCArriveDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCIncreasedSteeringDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCMinTurnSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCMaxTurnSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCMinTurnSpeedMech
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCDecelerateStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCStaticTurnTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCTeleportEffectTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCMinStaticTurnAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCFastStaticTurnAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCSlowStaticTurnAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCMaxStaticTurnSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCActiveListenChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCLookAtThingChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCLookAtThingTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCLookAtThingTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCLookAwayTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCLookAwayTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCMaxLookAtAngleMoving
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCMaxLookAtAngleStatic
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCLookAtTerminateAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCSeatedLookAtLateralReduction
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCMinInteractionSearchDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCMaxInteractionSearchDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCMaxFreighterInteractionSearchDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCMaxSettlementInteractionSearchDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCSteeringSpringTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCPerceptionRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCSteeringObstacleAvoidStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCSteeringFollowStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCSteeringAvoidStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCSteeringRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCSteeringRepelDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCSteeringComingTowardsDegrees
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCSteeringCollisionAvoidAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCSteeringCollisionAvoidStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCSteeringRaySpread
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCSteeringRayLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCSteeringRaySphereSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCMaxRandomNavPathMinIndoorOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCMaxRandomNavPathMaxIndoorOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCMaxRandomNavPathMinOutdoorOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCMaxRandomNavPathMaxOutdoorOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCBlockedDestRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCFlavourIdleTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCFlavourIdleTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCMoodIdleDelayChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCMoodIdleLowIntensityChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCReactToPlayerPresenceDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCReactToPlayerPresenceIndividualCooldown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCReactToPlayerPresenceGloablCooldown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCReactToPlayerPresenceStaticTimer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCDisplayThoughtsMaxDuration
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCDisplayThoughtsMaxDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCDisplayThoughtsRefreshInterval
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCDisplayThoughtsProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCPOISelectionNearbyNPCBaseMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCharacterGlobals(long address) : base(address)
	{

	}
}
