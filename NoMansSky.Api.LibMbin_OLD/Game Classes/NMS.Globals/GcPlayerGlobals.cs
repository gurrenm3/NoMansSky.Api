using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;
using libMBIN.NMS.Globals;
using System.Collections.Generic;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerGlobals : NMSTemplate
{
	public Boolean ForceFreighterProcTechRandom
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single AlienPodAggroDecay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AlienPodAggroSpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FoodValueThresholdBest
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FoodValueThresholdGood
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FoodValueThresholdAverage
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FoodValueThresholdBad
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FoodValueThresholdWorst
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportAppearEffectSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportDisappearEffectSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniportalAppearEffectTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniportalDisappearEffectTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean RecenterViewWhenEnteringShip
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseInitialFacingForMoveDirection
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EmulateNoHandsForHandScreens
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single BinocularAimOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BinocularScopeScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BinocularScopeSmoothing
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxArmExtension
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinArmExtension
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SummonArcRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionAimOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcProjectorOffsetData QuickMenuLauncherTransforms
	{
		get => GetValue<GcProjectorOffsetData>();
		set => TrySetValue<GcProjectorOffsetData>(value);
	}

	public GcProjectorOffsetData WeaponMenuLauncherTransforms
	{
		get => GetValue<GcProjectorOffsetData>();
		set => TrySetValue<GcProjectorOffsetData>(value);
	}

	public GcInWorldUIScreenData QuickMenuOffset
	{
		get => GetValue<GcInWorldUIScreenData>();
		set => TrySetValue<GcInWorldUIScreenData>(value);
	}

	public GcInWorldUIScreenData InventoryOffset
	{
		get => GetValue<GcInWorldUIScreenData>();
		set => TrySetValue<GcInWorldUIScreenData>(value);
	}

	public GcInWorldUIScreenData FrontendOffset
	{
		get => GetValue<GcInWorldUIScreenData>();
		set => TrySetValue<GcInWorldUIScreenData>(value);
	}

	public GcInWorldUIScreenData FrontendMessagesOffset
	{
		get => GetValue<GcInWorldUIScreenData>();
		set => TrySetValue<GcInWorldUIScreenData>(value);
	}

	public GcInWorldUIScreenData DefaultLeftHandTransform
	{
		get => GetValue<GcInWorldUIScreenData>();
		set => TrySetValue<GcInWorldUIScreenData>(value);
	}

	public GcInWorldUIScreenData DefaultLeftHandTransformVehicle
	{
		get => GetValue<GcInWorldUIScreenData>();
		set => TrySetValue<GcInWorldUIScreenData>(value);
	}

	public GcInWorldUIScreenData BinocularInfoScreenOffset
	{
		get => GetValue<GcInWorldUIScreenData>();
		set => TrySetValue<GcInWorldUIScreenData>(value);
	}

	public GcInWorldUIScreenData BinocularInfoScreenOffsetGun
	{
		get => GetValue<GcInWorldUIScreenData>();
		set => TrySetValue<GcInWorldUIScreenData>(value);
	}

	public GcInWorldUIScreenData FrontendPhotoModeVROffset
	{
		get => GetValue<GcInWorldUIScreenData>();
		set => TrySetValue<GcInWorldUIScreenData>(value);
	}

	public GcInWorldUIScreenData FrontendBaseScreenshotVROffset
	{
		get => GetValue<GcInWorldUIScreenData>();
		set => TrySetValue<GcInWorldUIScreenData>(value);
	}

	public Single BinocularRayThicknessVR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BincoularRayThickness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f BinocularScopeOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single BinocularsHUDDistanceVR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BinocularsHUDScaleVR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportMaxTravelDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportMaxTravelDistanceVertical
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportChargeMinDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportChargeMaxDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportChargeMoveSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportChargeMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportChargeFadeInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportBallFadeMinDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportBallFadeRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportBallDistanceFadeAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportBallRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportTravelSurfaceAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportBallCompletionFactorFadeout
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FingerTipOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FingerButtonClickSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FingerButtonRadiusOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FingerButtonClickTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FingerButtonQuickMenuOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f FingerButtonQuickMenuButtonSize
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single HandInteractionLightIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandInteractionLightIntensityMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandInteractionFresnel
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandInteractionFresnelMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandInteractionLightOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandInteractionLightOffsetAt
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandInteractionLightTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandScreenLookActiveAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandScreenMinAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandScreenMinAngleWithPoint
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandScreenAngleRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandScreenActivationRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandScreenActivationAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandScreenActivationAngleOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandScreenActivationAngleDown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandScreenPenetration
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandScreenRestingTurnAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f HandScreenRoboOnScreenOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public GcInWorldUIScreenData InWorldCompass
	{
		get => GetValue<GcInWorldUIScreenData>();
		set => TrySetValue<GcInWorldUIScreenData>(value);
	}

	public Single FistClenchBlendInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FistClenchBlendOutTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean DoPlayerAppearInVehicleEffect
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single StickYDampingThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean RequireHandsOnShipControls
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShowFirstPersonCharacterShadowPCVR
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShowFirstPersonCharacterShadowPSVR
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean InteractNearbyRadiusEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single InteractNearbyRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean PassiveLook
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single BodyRealignmentDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PointDownToMoveAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PointDownToMoveBackAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean EnableLeaning
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EnablePointDownToSmoothMove
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean HmdSmoothTurnAlways
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single HmdTurnSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HmdTurnSpeedPad
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public UInt64 PointingWristAdjustmentTimeMilliseconds
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public Vector3f PointingWristAngles
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Boolean HolsterOnHip
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single HolsterHeadRotX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f HolsterHeadOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f HolsterGunHandOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single GroundWalkForceMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundWalkBrake
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundWalkBrakeWhileMoving
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundWalkSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundWalkSpeedTeleportHmd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundRunSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundWalkSpeedLowG
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundRunSpeedLowG
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GroundWalkRecoverySpeedDamper
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandSmoothMinAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandSmoothAngleRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HmdResetButtonTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SummonShipDirectionChangeDeadZoneAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportArcRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportArcRadiusInner
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportStrafeDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NoStickTeleportDirectionChangeDeadzoneAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportHmdMinFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportHmdMaxFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportHmdOutFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportBeamGravity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportBeamGravityMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportArcLengthMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportBeamAnimSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportBeamAnimHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportLastKnownThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportLineEndFadeStart
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportLineEndFadeEnd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportLineFadeStart
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportLineFadeRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportInitiateThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean TeleportRecentre
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single TeleportLineBezierOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportLineBezierDistanceFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionLineSplineOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionLineSplineOffsetMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionLineSplineMinDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionLineSplineOffsetRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionLineCircleRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionLineCircleThickness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionLineCircleSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionLineCircleOffsetMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionLineCircleOffsetMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionLineNumCirclesPerMetre
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 WordCategoriesRequiredToConverse
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxWordCategoriesToSayPerNPC
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Colour InteractionLineActiveColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour InteractionLineBaseColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public GcScanEffectData InteractHighlightEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public GcScanEffectData HolsterHighlightEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public Single HandHoldInteractDistanceRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandHoldInteractAngleRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandSwimMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandSwimMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandSwimDecayTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandSwimForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandSwimMaxForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean HandSwimEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single HmdTurnThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HmdTurnAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HmdTurnAnglePad
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportInstantTravelDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportDirectionAltHandRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportMotionOffsetAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportMotionOffsetUp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportTotalTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x80 NoShadowMaterial
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Single HolsterGrabRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HolsterGrabFrontOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HolsterScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HolsterRotY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HolsterRotZ
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean HolsterHold
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Vector3f HolsterOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single HeadBinocularsOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeadBinocularsRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 DebugSearchGroup
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Colour SearchGroupIconColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public NMSString0x80 DefaultShipFilename
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcSeed DefaultShipSeed
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public GcScanEffectData ArmourHighlightScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public Single HitReactNoiseAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HitReactBlendOutSpeedMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HitReactBlendOutSpeedMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JetpackUnderwaterDrainRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JetpackUnderwaterFillRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterMargin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterMinDepth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterSurfaceTension
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterSurfaceTensionOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterSurfaceForceFlattenAngleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterSurfaceForceFlattenAngleRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterImpact
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterMaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterMaxJetpackSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterJetpackForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterMaxJetpackEscapeSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterJetpackEscapeForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterBrake
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterFloat
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterFloatForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterFloatRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnderwaterFloatFreq
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RespawnOnPadRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DeepWaterDepth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CockpitEjectTestRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CockpitEjectTestStartHeightOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CockpitEjectTestEndHeightOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CockpitEjectFirstPersonOffsetTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CockpitEjectFirstPersonOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BinocularRangePlanet
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BinocularRangeSpace
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinBinocActiveTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BinocularCreatureCastSphereSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 RobotMultiplierWithFriends
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single DroneStartLocationRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipSummonLastSafeMargin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterSpawnedOnYouFadeInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreativeModeDeathFadeInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreativeModeDeathFadeOutTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean CreatureRideFade
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single CreatureRideFadeInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureRideFadeOutTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HMDResetFlashTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 NumberOfWarpsRequiredForFreightersToSpawn
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single SpawningDistanceBetweenPlayersAfterWarp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpawningSpaceBattleLookOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpawningSpaceBattleLookOffsetUp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean MultiplayerShareWanted
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ReportAllProjectileDamage
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 DefaultHitPoints
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 DefaultHealthPips
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 DefaultShipHealthPips
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxHealthPips
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean UseLargeHealthBar
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single DroneSpawnAccelerator
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrackArrowStaticTargetOffsetMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WitnessSenseEnhancementTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WitnessSenseEnhancement
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MultiplayerMinWanteEscalationTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HealthRechargeMinTimeSinceDamage
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HealthPipRechargeRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinEnergyPercentOnRespawn
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleRaceResultsHintTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OtherPlayerTrackArrowRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WantedLevelPlayerRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WantedLevelPlayerRangeSpace
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlayerTransferRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlayerSpaceTransferRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneScanTimeToForget
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GhostbusterStartLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GhostbusterStart1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GhostbusterSpeed1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GhostbusterFreq1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GhostbusterAmp1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GhostbusterStart2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GhostbusterSpeed2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GhostbusterFreq2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GhostbusterAmp2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GhostbusterStart3
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GhostbusterSpeed3
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GhostbusterFreq3
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GhostbusterAmp3
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean FireButtonReloadsWeapon
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShowLowAmmoWarning
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean WeaponZoomEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single WeaponZoomFOV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PassiveWeaponZoomFOV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PassiveWeaponZoomFOVThirdPerson
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeaponZoomRecoilMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeaponZoomVertRotation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeaponZoomHorzRotation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean FrontShieldEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single FrontShieldOffsetOff
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontShieldOffsetOn
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontShieldSpeedSlowdown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontShieldSlerpTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CombatSpawnMinWantedTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExperiencePiratesDifficultyVariance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExperienceHardPiratesDamageMaxOdds
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExperienceMediumPiratesDamageMaxOdds
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CommunicatorSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinDistanceToCommunicatorTarget
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GrenadeBounceDamping
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GrenadeBounceMaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GrenadeStopExplodeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CockpitEjectTestSphereRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CockpitEjectTestSphereRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CockpitEjectSideTestRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeaponShotgunSlowdown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.Globals.GcPlayerGlobals.MouseSmoothModeEnum MouseSmoothMode
	{
		get => GetValue<libMBIN.NMS.Globals.GcPlayerGlobals.MouseSmoothModeEnum>();
		set => TrySetValue<libMBIN.NMS.Globals.GcPlayerGlobals.MouseSmoothModeEnum>(value);
	}

	public Vector2f MouseSpringStrength
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f MouseSpringStrengthMinDelta
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f MouseSpringStrengthMaxDelta
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single HazardDamageMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EnergyDamageMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EnergyDischargeRateLow
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EnergyDischargeRateMedium
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EnergyDischargeRateHigh
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EnergyDischargeRateFloatingInSpace
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EnergyPainRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SolarRegenFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour DefaultMuzzleColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour TerrainEditorMuzzleColourSubtract
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour TerrainEditorMuzzleColourAdd
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour TerrainEditorMuzzleColourFlatten
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour TerrainEditorMuzzleColourUndo
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour DefaultMuzzleLaserColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single JetpackJetAnimateOutTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JetpackJetAnimateInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreeJetpackRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreeJetpackRangePrime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreeJetpackRangeNonTerrain
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JetpackDrainHorizontalFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinTimeAfterMeleeBeforeBoost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxTimeAfterMeleeBeforeBoost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MeleeBoostAirForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MeleeToAirBoostInitialImpulse
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxTimeInMeleeBoost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean RocketBootsEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean RocketBootsUseCustomCamera
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single RocketBootsActivationWindow
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RocketBootsDoubleTapTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RocketBootsImpulse
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RocketBootsBoostForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RocketBootsDriftForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RocketBootsForceStartTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RocketBootsForceDuration
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RocketBootsMinDesiredHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RocketBootsMaxDesiredHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RocketBootsHeightAdjustTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RocketBootsHeightAdjustUpStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RocketBootsHeightAdjustDownStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RocketBootsJetpackMinLevel
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RocketBootsBoostTankDrainSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RocketBootsDriftTankDrainSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RocketBootsBoostOnTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RocketBootsBoostOffTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RocketBootsZigZagStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RocketBootsZigZagForceDuration
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RocketBootsMaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RocketBootsDriftEndTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RocketBootsWindUpBraking
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RocketBootsDriftBraking
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RocketBootsDriftDownwardForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StealthMinLevel
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StealthDrainRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StealthRechargeRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JetpackForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JetpackBrake
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JetpackMinLevel
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JetpackMaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JetpackMaxUpSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JetpackUpForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JetpackIgnitionForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JetpackIgnitionTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JetpackMinIgnitionTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<Single> JetpackTankTimes
	{
		get => cache.GetOrAddValue(new VirtualList<Single>(address + GetOffset()));
		set => TrySetValue<Single>(value);
	}

	public Single JetpackFillRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JetpackFillRateMidair
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JetpackFillRateSpaceStationMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JetpackFillRateFleetMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JetpackFillRateNexusMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JetpackUpForceDeadPlanetExtra
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JetpackForceDeadPlanetExtra
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JetpackIgnitionForceDeadPlanetExtra
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JoystickOrientationTrimAltOc
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JoystickOrientationTrimAltOp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceJetpackForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceJetpackUpForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceJetpackIgnitionForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceJetpackMaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceJetpackDrainRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean EnableHeadMovements
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ClampPitch
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single DamageRepairFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AbandonedFreighterStaminaRecoveryMod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AbandonedFreighterStaminaRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VRModeHazardTimeMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VRStartHazardTimeMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EarlyHazardTimeMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StartHazardTimeMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterAbandonedHazardTimeMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AbandonedFreighterRechargeMod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NormalModeHazardTimeMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NormalModeHazardDamageRateMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NormalModeHazardDamageWoundRateMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NormalModeHazardRechargeUnderground
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HardModeHazardTimeMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HardModeHazardDamageRateMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HardModeHazardDamageWoundRateMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HardModeHazardRechargeUnderground
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleHazardDampingModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterProbeScanTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MaxNumDestroyEffects
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MinNumDestroyEffects
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single ProjectileEndTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExplosionTimePerEffect
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExplosionTimeVariance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExplosionScaleVariance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExplosionBoundingInset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExplosionBoundingInsetRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DestroyEffectFinalDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipPriceExp2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeaponPriceExp2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterPriceExp2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipCoolFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeaponCoolFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterCoolFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean MouseCrosshairVisible
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single MouseMaxLengthOld
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MouseDeadZoneOld
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MouseMaxLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MouseDeadZone
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MouseMaxLengthVehicle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MouseDeadZoneVehicle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MouseAimZone
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MouseCrosshairMaxAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MouseCrosshairAlphaFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MouseCrosshairAlphaFadeSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MouseCrosshairLineAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MouseCrosshairLineWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MouseCrosshairShipStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MouseCrosshairMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MouseCrosshairShipStrengthOld
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MouseFlightCorrectionMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MouseFlightCorrectionBrakeMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType MouseFlightCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single MaximumCrouchVR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaximumHeadHeightIncreaseVR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaximumHorizontalOffsetVR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrouchHeightToDisableLegBlendingVR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean UseEnergy
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseHazardProtection
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean HideHazardPanel
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean InventoryDamage
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean NeverPreyedOn
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean PermanantFire
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean PermanantAltFire
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean LuckyWithTech
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 ChanceHighGradeIllegal
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 BulletCostReducer
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 BulletClipMultiplier
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single LootForceMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WoundTimeMinimum
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WoundDamageLimit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WoundDamageLimitShip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WoundDamageDecayTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ResourceBlobFinalScaleDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaserPlayerOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerAlertRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerSightRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkerSightAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CombatEscalateTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CombatEscapeRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CombatEscapeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean UpgradeExosuitWithProduct
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 ExosuitUpgradeProduct
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 SuitInventoryStartSeed
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxNumShipsAttackingPlayer
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single ObjectScanTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneProbeScanTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 PirateHailPercent
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single PirateBountyInitTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateBountyMaxDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateBountyTimeoutTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateProbeInitTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateProbeAttackWaitTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateProbeAttackWarnTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateProbeScanTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateProbeScanTotalTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateProbeHailPause
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateFlybyAttackDistancePastPlayer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateFlybyAttackProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateFlybyAttackMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateFlybyAttackMaxTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateRaidMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateRaidMaxTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateBattleMarkerRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateBattleWarnTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateBattleMarkerTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateBattleMaxTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x20A TraderHailReceiveOSDLoc
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A TraderHailRefusedOSDLoc
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Single TraderHailTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TraderApproachTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TraderHailDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TraderApproachDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TraderSpamTimeWait
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TraderStayCloseLockOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TraderStayCloseLockSin1Coeff
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TraderStayCloseLockSin1Offset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TraderStayCloseLockSin2Coeff
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TraderStayCloseLockSin2Offset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TraderStayCloseLockSinsAdd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TraderStayCloseLockSpread
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TraderStayCloseLockSpreadAdd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TraderStayCloseLockSpreadTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f TraderStayCloseLockBaseOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single TraderHealthFightThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 TraderCommunicationBanMinTime
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 TraderCommunicationBanMaxTime
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single FrigateFlybyMarkerAlwaysShowDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrigateFlybyMarkerAlwaysHideDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseEncounterMinTimeInPulse
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseEncounterProbeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseEncounterProbeTimeRare
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseEncounterMarkerShowAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseEncounterMarkerAlwaysShowDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseEncounterMarkerAlwaysHideDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseEncounterSpawnEffectDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseEncounterSpawnEffectTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 PulseEncounterSpaceEggID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single LaserMiningDamageMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShieldRechargeMinTimeSinceDamage
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShieldRechargeRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MoveStickHighRangeLimit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WitnessAIDamageDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WitnessAIDamageAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DeathDamageDrainChargeFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 DeathDamageTechBrokenPercent
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single MaxProjectileRadiusMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HardLandPainTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 GunBaseClipSize
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 GrenadeBaseClipSize
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single MeleeCooldown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ChargeMeleeCooldown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MeleeDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MeleeDistance3P
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MeleeRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MeleeHitTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MeleeSpeedBoost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MeleeSpeedDamageBoost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MeleeSpeedBoostRangeMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MeleeStaminaDrain
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MeleeCooldownAlt
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MeleePosDelta
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MeleeDamageScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MeleeRadiusAlt
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MeleeDistanceAlt
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcScanEffectData MeleeHitEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public Single TemperatureDisplaySampleTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour StarFieldColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single StarFieldRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StarFieldDensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StarFieldStarSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpeedLinesSpeedMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpeedLinesSpeedMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpeedLinesLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpeedLinesTotalLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpeedLinesWidthMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpeedLinesWidthMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpeedLinesRadiusStartMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpeedLinesRadiusStartMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpeedLinesRadiusIncrement
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpeedLinesStartFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpeedLinesMinAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpeedLinesMaxAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpeedLinesOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SleepFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StaminaRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StaminaRecoveryRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StaminaRecoveredFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanLabelTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanWobbleFreq
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanWobbleAmp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanWobbleFreq2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanWobbleAmp2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanRotate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanRotateDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanRotateWobbleAmp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanFadeInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanFadeOutTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanBeamWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanRotateBeamWdith
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanBeamMainWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WantedDroneEventRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WantedMinSpaceTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WantedMinPlanetTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WantedLevelDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WantedWitnessTimer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WantedWitnessFuzzyTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WantedMinorCrimeAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WantedTimeoutAggressive
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<Single> WantedTimeout
	{
		get => cache.GetOrAddValue(new VirtualList<Single>(address + GetOffset()));
		set => TrySetValue<Single>(value);
	}

	public VirtualList<Single> WantedEscalateTime
	{
		get => cache.GetOrAddValue(new VirtualList<Single>(address + GetOffset()));
		set => TrySetValue<Single>(value);
	}

	public VirtualList<Single> WantedExtremeEscalateTime
	{
		get => cache.GetOrAddValue(new VirtualList<Single>(address + GetOffset()));
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.Globals.GcPlayerGlobals.ControlModesEnum ControlModes
	{
		get => GetValue<libMBIN.NMS.Globals.GcPlayerGlobals.ControlModesEnum>();
		set => TrySetValue<libMBIN.NMS.Globals.GcPlayerGlobals.ControlModesEnum>(value);
	}

	public Single PlayerViewTargetRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionScanRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionButtonRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionButtonRangeVehicle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionFocusIncrease
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionFocusIncreaseCreature
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionFocusIncreasePet
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionFocusTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionFocusTimeCreature
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionFocusTimePet
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionSubstanceRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeatShieldTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaserShakeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaserShakeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GunRecoil
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaserRecoil
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BeamRecoil
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GrenadeRecoil
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GunRecoilSpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BlastRecoilSpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RailRecoilSpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PulseRecoilSpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CannonRecoilSpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GunRecoilSettleSpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonRecoilMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GunRecoilMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GunRecoilMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean BoltcasterHasTracer
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single ProjectileDamageFalloff
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShotgunDispersion
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlamethrowerDispersion
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MuzzleFlashMulThirdPerson
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcResourceCollectEffect TerrainResourceCollect
	{
		get => GetValue<GcResourceCollectEffect>();
		set => TrySetValue<GcResourceCollectEffect>(value);
	}

	public GcResourceCollectEffect TerrainResourceMiniCollect
	{
		get => GetValue<GcResourceCollectEffect>();
		set => TrySetValue<GcResourceCollectEffect>(value);
	}

	public GcResourceCollectEffect TerrainResourceMeleeCollect
	{
		get => GetValue<GcResourceCollectEffect>();
		set => TrySetValue<GcResourceCollectEffect>(value);
	}

	public GcResourceCollectEffect CrystalResourceCollect
	{
		get => GetValue<GcResourceCollectEffect>();
		set => TrySetValue<GcResourceCollectEffect>(value);
	}

	public GcResourceCollectEffect ShardResourceCollect
	{
		get => GetValue<GcResourceCollectEffect>();
		set => TrySetValue<GcResourceCollectEffect>(value);
	}

	public GcBoidData MissileSwarm
	{
		get => GetValue<GcBoidData>();
		set => TrySetValue<GcBoidData>(value);
	}

	public GcPlayerStickData StickData
	{
		get => GetValue<GcPlayerStickData>();
		set => TrySetValue<GcPlayerStickData>(value);
	}

	public Boolean AutoAim
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single AutoAimMaxAccelFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AutoAimFixedInterceptSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AutoAimTimeOut
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AutoAimMaxAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AutoAimMinScreenDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AutoAimRadiusExtra
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AutoAimStickyRailgun
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AutoAimStickyMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AutoAimStickyMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType AutoAimDotCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public TkCurveType AutoAimCentreOffsetCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single AimDistanceShip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimWeightAdd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimMinWeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimDecay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimShootableTargetAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimDisperseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimDisperseMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimDisperseCooldownTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AimDisperseCooldownFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType AimDisperseCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single CrosshairTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BeaconActivateRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 ExperienceMaxCivilianShipSpawnsOnPlanet
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ExperienceMaxCivilianShipSpawnsInSpace
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single ExperiencePirateFreighterAttackRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExperienceWalkerSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExperienceInterestingPoliceDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExperienceInterestingShipDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExperienceInterestingFreighterDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExperienceInterestingDroneDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExperienceShipTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExperienceShipTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 ExperiencePirateCloseAttackPercentage
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single ExperiencePirateTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExperiencePirateTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExperienceDroneTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExperienceDroneTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExperienceFlybyScareRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExperienceFlybyScareTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f ExperienceFlybyStartAngle
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single ExperienceAlertRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExperienceAlertSightRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExperienceAlertSightAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExperienceDroneSpawnOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExperienceDroneSpawnAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExperienceMessageBroadcastNearbyDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExperienceDefeatLevel5SentinelsRewardDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 ExperienceDefeatLevel5SentinelsReward
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 ExperienceDefeatLevel5SentinelsNearHiveReward
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single ExperienceDefeatLevel5SentinelsDisableWantedTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WantedEnemyAttackAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x80 Gun
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Single StickDeadZoneMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StickDeadZoneMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType StickCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single AutoLandRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AutoLandTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LabelSpringTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LabelOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AtmosphereEffectTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AtmosphereEffectOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcCreatureAlertData> AlertTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureAlertData>(address + GetOffset()));
		set => TrySetValue<GcCreatureAlertData>(value);
	}

	public Single PainFlickerAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PainColourSeperateAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PainTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcProjectileLineData PlayerBullet
	{
		get => GetValue<GcProjectileLineData>();
		set => TrySetValue<GcProjectileLineData>(value);
	}

	public GcProjectileLineData RobotBullet
	{
		get => GetValue<GcProjectileLineData>();
		set => TrySetValue<GcProjectileLineData>(value);
	}

	public GcProjectileLineData ShipBullet
	{
		get => GetValue<GcProjectileLineData>();
		set => TrySetValue<GcProjectileLineData>(value);
	}

	public Single ExplodeShakeMaxDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExplodeShakeMaxDistSpace
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExplodeShakeStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlashSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlashPosX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlashPosY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlashPosZ
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlashSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlashPulse
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlashGrow
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GunRightOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GunUpOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaserBeamMineRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaserBeamCore
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaserBeamFlickerAmp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaserBeamFlickerFreq
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaserEndOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GrenadeTerrainDeformRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaserBeamTerrainDeformRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaserBeamTerrainDeformVariance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaserBeamAmmoUseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ReloadButtonHoldTimeToHolster
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeaponChangeModeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f WeaponBarrelOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f WeaponOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single WeaponLowerDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeaponHolsterDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeaponLag
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeaponBobFactorWalkDeadZone
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeaponBobFactorWalk
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeaponBobFactorRun
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeaponBobBlendTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType WeaponBobBlendCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single WeaponCannonMinWeaponTimer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeaponCannonMinUnchargedShotThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeaponCannonMinUnchargedShotTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeaponGrenadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeaponGunTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeaponRailFireTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeaponRailRechargeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MaxBuildHeight
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single SpaceMaxGravityDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMinGravityDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BulletBend
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShootSizeMinZ
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShootSizeMaxZ
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShootSizeMinXY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShootSizeMaxXY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShootSizeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShootSizeBase
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShootOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShootPrepTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GrenadeCarveRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ChargeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EnergyBallSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ChargedEnergyBallSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LookRayRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PickRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageRateWhenUnderNoGravity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TakeDamageImpulse
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HardLandTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HardLandMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HardLandMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MeleeRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MeleeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MeleeForcePush
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MeleeOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PushForceAirFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 HUDHeightPosX
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 HUDHeightPosY
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single TargetDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TargetRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoldForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoldTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoldActionDistX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoldActionDistY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoldActionDistZ
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoldDistX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoldDistY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoldDistZ
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoldMaxForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoldRotate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BalanceStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BalanceSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExertionSmoothTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExertionFromPainTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AnimWalkSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AnimRunSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AnimWalkToRunSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AnimWalkBlendPoint
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AnimRunBlendPoint
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxSlopeAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SlopeSlidingSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SlopeSlideBrake
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinSlideTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxWalkableSlopeAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinSpidermanSlopeAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinTimeToHoldSpidermanPose
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxSpidermanSlopeAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxClingableSlopeAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinimumPushOffForceToSlide
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreeJetpackSlopeAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreeJetpackSlopeAnglePrime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FullClipReloadSpeedMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ReloadTapButtonSpeedIncrease
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 FootDustEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single FootDustScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ClingBrakeMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ClingAngleThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ClingSpeedThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ClimbableStickinessAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinUpAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FootOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxFallSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PushForceDecay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LeanFwdMaxAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LeanBackMaxAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LeanLeftMaxAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LeanRightMaxAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LeanAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LeanAmountFwd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HelmetLag
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HelmetMaxLag
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HelmetBob
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single JetpackHelmetBob
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipCameraLag
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxResource
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 ShieldMaximum
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single ShieldRestoreSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShieldRestoreDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TimeHoldDownAccelerateToLaunchFromOutpost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DeathScreenFadeInThirdPerson
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DeathScreenFadeInUnderwaterThirdPerson
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DeathScreenFadeInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DeathScreenShipFadeInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DeathScreenPauseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DeathScreenMaxRegenWaitTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DeathScreenMinRegenWaitTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DeathScreenFadeOutTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public UInt64 AutoSaveMaxTime
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public UInt64 AutoSaveMinTime
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public Single AutoSaveRangeOnFoot
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AutoSaveRangeInVehicle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AutoSaveRangeInSpace
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPlayerStickData LookStickData
	{
		get => GetValue<GcPlayerStickData>();
		set => TrySetValue<GcPlayerStickData>(value);
	}

	public GcPlayerStickData AmbientModeLookStickData
	{
		get => GetValue<GcPlayerStickData>();
		set => TrySetValue<GcPlayerStickData>(value);
	}

	public Int32 LowHealthEffectPips
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 LowHealthEffectShield
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single CriticalHitTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CriticalHitDesatTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CriticalHitDesatFreq
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcCameraSpawnSetupData> FirstSpawnDataTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcCameraSpawnSetupData>(address + GetOffset()));
		set => TrySetValue<GcCameraSpawnSetupData>(value);
	}

	public GcInventoryValueData ShipValueData
	{
		get => GetValue<GcInventoryValueData>();
		set => TrySetValue<GcInventoryValueData>(value);
	}

	public GcInventoryValueData WeaponValueData
	{
		get => GetValue<GcInventoryValueData>();
		set => TrySetValue<GcInventoryValueData>(value);
	}

	public GcInventoryValueData FreighterValueData
	{
		get => GetValue<GcInventoryValueData>();
		set => TrySetValue<GcInventoryValueData>(value);
	}

	public VirtualList<Single> TechRarityData
	{
		get => cache.GetOrAddValue(new VirtualList<Single>(address + GetOffset()));
		set => TrySetValue<Single>(value);
	}

	public VirtualList<Single> TechLearningProbabilities
	{
		get => cache.GetOrAddValue(new VirtualList<Single>(address + GetOffset()));
		set => TrySetValue<Single>(value);
	}

	public Int32 NumTechShopSlots
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single GrassPushDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GrassPushDistanceFeet
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCameraAnomalySetupData AnomalyBlachHoleSpawnData
	{
		get => GetValue<GcCameraAnomalySetupData>();
		set => TrySetValue<GcCameraAnomalySetupData>(value);
	}

	public GcCameraAnomalySetupData AnomalyAtlasStationSpawnData
	{
		get => GetValue<GcCameraAnomalySetupData>();
		set => TrySetValue<GcCameraAnomalySetupData>(value);
	}

	public GcCameraAnomalySetupData AnomalyMiniStationSpawnData
	{
		get => GetValue<GcCameraAnomalySetupData>();
		set => TrySetValue<GcCameraAnomalySetupData>(value);
	}

	public GcJourneyMedalTiers MedalTiers
	{
		get => GetValue<GcJourneyMedalTiers>();
		set => TrySetValue<GcJourneyMedalTiers>(value);
	}

	public Int32 LowGuildRank
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MedGuildRank
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 HighGuildRank
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 BestGuildRank
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single LaserWeaponRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaserShipRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TerrainLaserRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleLaserRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPlayerCommunicatorMessage PoliceScanHailMessage
	{
		get => GetValue<GcPlayerCommunicatorMessage>();
		set => TrySetValue<GcPlayerCommunicatorMessage>(value);
	}

	public GcPlayerCommunicatorMessage PirateHailMessage
	{
		get => GetValue<GcPlayerCommunicatorMessage>();
		set => TrySetValue<GcPlayerCommunicatorMessage>(value);
	}

	public GcShipDialogue TraderHailMessages
	{
		get => GetValue<GcShipDialogue>();
		set => TrySetValue<GcShipDialogue>(value);
	}

	public VirtualArray<GcShipDialogueTreeEnum> TraderHailReceiveRegular
	{
		get => cache.GetOrAddValue(new VirtualArray<GcShipDialogueTreeEnum>(address + GetOffset(), 4));
		set => TrySetValue<GcShipDialogueTreeEnum>(value);
	}

	public VirtualArray<GcShipDialogueTreeEnum> TraderHailReceiveFight
	{
		get => cache.GetOrAddValue(new VirtualArray<GcShipDialogueTreeEnum>(address + GetOffset(), 2));
		set => TrySetValue<GcShipDialogueTreeEnum>(value);
	}

	public VirtualArray<GcShipDialogueTreeEnum> TraderHailSend
	{
		get => cache.GetOrAddValue(new VirtualArray<GcShipDialogueTreeEnum>(address + GetOffset(), 2));
		set => TrySetValue<GcShipDialogueTreeEnum>(value);
	}

	public GcPlayerGlobals(long address) : base(address)
	{

	}
}
