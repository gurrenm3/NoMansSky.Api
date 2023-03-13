using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCameraGlobals : NMSTemplate
{
	public Boolean OffsetCombatCameraHorizontal
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single OffsetCombatCameraHorizontalAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkModelRendererData FreighterCustomisationStandardCamera
	{
		get => GetValue<TkModelRendererData>();
		set => TrySetValue<TkModelRendererData>(value);
	}

	public VirtualList<GcCameraFollowSettings> Cameras
	{
		get => cache.GetOrAddValue(new VirtualList<GcCameraFollowSettings>(address + GetOffset()));
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings VehicleCamHmd
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings VehicleCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings MechFirstPersonCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public Single SpecialVehicleMouseRecentreTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpecialVehicleMouseRecentreWeaponTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HmdEyeLookAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HmdEyeExtraTurnAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HmdEyeExtraTurnMinHeadAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HmdEyeExtraTurnHeadAngleRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean PauseThirdPersonCamInPause
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single DebugPlanetJumpNearHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DebugPlanetJumpFarHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TogglePerspectiveBlendTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean LockFollowSpring
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single UnderwaterCameraSurfaceOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonAfterIntroCamBlendTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonSkipIntroCamBlendTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniportalFlashTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MiniportalFlashStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour MiniportalFlashColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single VehicleExitFlashTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleExitFlashStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour VehicleExitFlashColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single VehicleFirstToThirdExitOffsetY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleFirstToThirdExitOffsetZ
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipThirdPersonBlendTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipThirdPersonBlendWithOffsetTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipThirdPersonBlendOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipThirdPersonBlendOutTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipThirdPersonBlendOutOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipFirstPersonBlendTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipFirstPersonBlendOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipThirdPersonEnterBlendTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipThirdPersonEnterBlendOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlybyMinRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlybyRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlybyMinRelativeSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlybyRelativeSpeedRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlybyInVehicleDamper
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BinocularFlashTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BinocularFlashStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinFirstPersonCameraPitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxFirstPersonCameraPitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxCreatureRidingYaw
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonRotationBackAdjustAngleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonClosePitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonCloseDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonCloseDistanceX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonRotationBackAdjustAngleMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonUphillAdjustSpringTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonUphillAdjustSpringTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonDownhillAdjustSpringTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonDownhillAdjustSpringTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonDownhillAdjustMinAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonDownhillAdjustMaxAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonUphillAdjustMinAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonUphillAdjustMaxAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonDownhillAdjustMinAnglePrime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonDownhillAdjustMaxAnglePrime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonUphillAdjustMinAnglePrime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonUphillAdjustMaxAnglePrime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonUphillAdjustCrossSlopeMinAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonUphillAdjustCrossSlopeMaxAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleThirdPersonShootOffsetReturnTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleThirdPersonShootOffsetBlendOutTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechCameraNoExtraYTimeAfterLand
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechCameraExtraYPostLandingBlendTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechCameraArmShootOffsetY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechCameraCombatFakeSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCameraFollowSettings CharacterUnarmedCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings CharacterRunCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings CharacterCombatCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings CharacterMiningCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings CharacterIndoorCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings CharacterAbandCombatCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings CharacterAbandCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings CharacterNexusCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings CharacterAirborneCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings CharacterMeleeBoostCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings CharacterRocketBootsCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings CharacterRocketBootsChargeCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings CharacterFallingCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings CharacterAirborneCombatCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings CharacterSpaceCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings CharacterSteepSlopeCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings CharacterUnderwaterCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings CharacterUnderwaterCombatCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings CharacterUnderwaterJetpackCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings CharacterGrabbedCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings CharacterSitCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings CharacterRideCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings CharacterRideCamMedium
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings CharacterRideCamLarge
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings CharacterRideCamHuge
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public Single ThirdPersonCameraChangeBlendTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonCameraChangeMinimumBlend
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCameraFollowSettings BuggyFollowCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings HovercraftFollowCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings SubmarineFollowCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings BikeFollowCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings WheeledBikeFollowCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings TruckFollowCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings MechFollowCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings MechCombatCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings MechJetpackCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings SpaceshipFollowCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings DropshipFollowCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings ShuttleFollowCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings RoyalShipFollowCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings SailShipFollowCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings ScienceShipFollowCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings AlienShipFollowCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings BuildingIndoorsCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings BuildingOutdoorsCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public GcCameraFollowSettings BuildingUnderwaterCam
	{
		get => GetValue<GcCameraFollowSettings>();
		set => TrySetValue<GcCameraFollowSettings>(value);
	}

	public Single FrontendModelCameraSpringTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ModelViewFlashTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f ModelViewOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector2f ModelViewFocusOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector3f InteractionOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f InteractionOffsetExtraVR
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f InteractionOffsetExtraVRSeated
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f InteractionOffsetDefault
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f InteractionOffsetGek
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f InteractionShipFocusOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f InteractionHailingFocusOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f InteractionOffsetRecruitment
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single InteractionHeadHeightDefault
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionHeadHeightGek
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionHeadHeightVykeen
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionPitchAdjustTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionPitchAdjustStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionPitchAdjustDeadZone
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionHeadPosHeightAdjust
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrigateCaptainLateralShiftAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PilotDetailsLateralShiftAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RecruitmentLateralShiftAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCTradeLateralShiftAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NPCTradeLateralShiftTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceForFleetInteraction
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceForFrigateInteraction
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceForFrigatePurchaseInteraction
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f OffsetForFleetInteraction
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f OffsetForFrigateInteraction
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single FleetUIOrbitRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FleetUIVerticalMotionDuration
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FleetUIVerticalMotionAmplitude
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f PitchForFrigateInteraction
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f RotationForFrigateInteraction
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single InteractionModeBlendTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionModeFocusCamBlend
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionModeFoV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinInteractFocusAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ModelViewInterpTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonBlendInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonBlendOutTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonCollisionPushOffsetReducerStart
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonOffsetSpringTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean MaxBob
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single PhotoModeVelocitySmoothTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PhotoModeMoveSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PhotoModeTurnSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PhotoModeMaxDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PhotoModeMaxDistanceSpace
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PhotoModeMaxDistanceClampForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PhotoModeMaxDistanceClampBuffer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PhotoModeCollisionRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PhotoModeRollSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PhotoModeFlashDuration
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PhotoModeFlashIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f PhotoModeShipOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f BuildingModeInitialOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single BuildingModeMaxDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RunningFoVAdjust
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MeleeBoostedFoV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MeleeFoV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AerialViewDownDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AerialViewPause
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AerialViewStartTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AerialViewBackTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AerialViewBlendTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType AerialViewCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public GcCameraAerialViewData BeaconTransition
	{
		get => GetValue<GcCameraAerialViewData>();
		set => TrySetValue<GcCameraAerialViewData>(value);
	}

	public GcCameraAerialViewData SignalTransition
	{
		get => GetValue<GcCameraAerialViewData>();
		set => TrySetValue<GcCameraAerialViewData>(value);
	}

	public GcCameraAerialViewData WaypointTransition
	{
		get => GetValue<GcCameraAerialViewData>();
		set => TrySetValue<GcCameraAerialViewData>(value);
	}

	public GcCameraAerialViewData RadioTowerTransition
	{
		get => GetValue<GcCameraAerialViewData>();
		set => TrySetValue<GcCameraAerialViewData>(value);
	}

	public Single ScreenshotHorizonHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScreenshotHorizonFaceFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScreenshotBendDownAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScreenshotRightDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScreenshotBackDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScreenshotInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScreenshotOutTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechCamSpringStrengthMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MechCamSpringStrengthMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipCamSpringStrengthMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipCamSpringStrengthMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipCamTurn
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipCamPitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipCamPitchMod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipCamLookInterp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipCamMinReturnTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipCamReturnTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipCamMotionTurn
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipCamMotionPitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipCamMotionPitchMod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipCamMotionMaxLagTurnAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipCamMotionMaxLagPitchAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipCamMotionInterp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipCamRollAmountMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipCamRollAmountMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipCamRollSpeedScaler
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipCamAimFOV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MouseSensitivity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ModelViewRotateSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ModelViewMouseRotateSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ModelViewMouseRotateSnapStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ModelViewMouseMoveSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ModelViewDistSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ModelViewMinDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ModelViewMaxDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ModelViewDefaultPitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ModelViewDefaultYaw
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean DebugMoveCam
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single DebugMoveCamSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DebugMoveCamHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean DebugAICam
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single DebugAICamUp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DebugAICamAt
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PainShakeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipShakeDamper
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IndoorCamShakeDamper
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FirstPersonSlerpAway
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FirstPersonSlerpTowards
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcCameraShakeData> CameraShakeTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcCameraShakeData>(address + GetOffset()));
		set => TrySetValue<GcCameraShakeData>(value);
	}

	public Single BobAmountAbandFreighter
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BobFactorAbandFreighter
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BobAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BobFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BobFocus
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BobRollFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BobRollAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BobRollOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BobFwdAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CamSeed1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CamSeed2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CamWander1Phase
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CamWander2Phase
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CamWander1Amplitude
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CamWander2Amplitude
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DebugSpaceStationTeleportOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DebugCameraSlowFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DebugCameraFastFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DebugCameraSpaceFastFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DebugCameraHeightForAccelerateBegin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DebugCameraSpeedAtPlanetThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DebugCameraHeightForAccelerateEnd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DebugCameraMaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffsetCamFOV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f OffsetCamOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f OffsetCamRotation
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single ObjectFocusTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CharCamFocusHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CharCamMaxDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CharCamMinDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CharCamHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CharCamOffsetTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CharCamAutoDirStartTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CharCamLookOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CharCamLookOffsetFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CharCamDeflectSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CharCamMinSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CharCamRightStickX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CharCamRightStickY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FirstPersonCamHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<Vector3f> FirstPersonCamOffset
	{
		get => cache.GetOrAddValue(new VirtualList<Vector3f>(address + GetOffset()));
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f FirstPersonInShipCamOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single CloseFactorSpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FirstPersonFoV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonFoV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonCombatFoV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FirstPersonZoom1FoV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FirstPersonZoom2FoV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipFoVMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipFoVMin2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipFoVMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipWarpFoV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipFoVMin3rdPerson
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipFoVMax3rdPerson
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipFoVBoost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipFoVMiniJump
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipFoVSpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipMiniJumpFoVSpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FoVSpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FoVSpringSights
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FoVSpringSightsPassive
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FoVAdjust
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean CreatureInteractionInterpolateDuringHold
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single CreatureSizeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureSizeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureInteractionMinDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureInteractionPushCameraDownForCreatureBiggerThan
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureInteractionPushCameraDownAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureInteractionDistMulMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureInteractionDistMulMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureInteractionYawMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureInteractionYawMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureInteractionPitchSplit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureInteractionPitchMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureInteractionPitchMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureInteractionMaxDownhillPitchAroundPlayer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureInteractionDownhillPitchTransfer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureInteractionMaxUphillPitchAroundPlayer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureInteractionUphillPitchTransfer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureInteractionFoVSplitSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureInteractionFoVMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureInteractionFoVMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureInteractionCamSpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureInteractionHeadHeightSpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean FollowDrawCamProbes
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcCameraAnimationData AmbientCameraAnimations
	{
		get => GetValue<GcCameraAnimationData>();
		set => TrySetValue<GcCameraAnimationData>(value);
	}

	public TkModelResource AmbientDroneAnimations
	{
		get => GetValue<TkModelResource>();
		set => TrySetValue<TkModelResource>(value);
	}

	public NMSString0x80 CameraAmbientAnimationsData
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Single CameraAmbientAutoSwitchMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CameraAmbientAutoSwitchMaxTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkModelRendererData CameraNPCShipInteraction
	{
		get => GetValue<TkModelRendererData>();
		set => TrySetValue<TkModelRendererData>(value);
	}

	public TkModelRendererData CameraNPCShopInteraction
	{
		get => GetValue<TkModelRendererData>();
		set => TrySetValue<TkModelRendererData>(value);
	}

	public TkModelRendererData CameraCreatureCustomiseDefault
	{
		get => GetValue<TkModelRendererData>();
		set => TrySetValue<TkModelRendererData>(value);
	}

	public TkModelRendererData CameraCreatureCustomiseLeft
	{
		get => GetValue<TkModelRendererData>();
		set => TrySetValue<TkModelRendererData>(value);
	}

	public TkModelRendererData CameraCreatureCustomiseRight
	{
		get => GetValue<TkModelRendererData>();
		set => TrySetValue<TkModelRendererData>(value);
	}

	public TkModelRendererData CameraCreatureCustomiseFront
	{
		get => GetValue<TkModelRendererData>();
		set => TrySetValue<TkModelRendererData>(value);
	}

	public TkModelRendererData CameraCreatureCustomiseBack
	{
		get => GetValue<TkModelRendererData>();
		set => TrySetValue<TkModelRendererData>(value);
	}

	public VirtualList<TkPhysRelVectorData> SavedCameraPositions
	{
		get => cache.GetOrAddValue(new VirtualList<TkPhysRelVectorData>(address + GetOffset()));
		set => TrySetValue<TkPhysRelVectorData>(value);
	}

	public VirtualList<Vector3f> SavedCameraFacing
	{
		get => cache.GetOrAddValue(new VirtualList<Vector3f>(address + GetOffset()));
		set => TrySetValue<Vector3f>(value);
	}

	public GcCameraWarpSettings WarpSettings
	{
		get => GetValue<GcCameraWarpSettings>();
		set => TrySetValue<GcCameraWarpSettings>(value);
	}

	public GcCameraWarpSettings FreighterWarpSettings
	{
		get => GetValue<GcCameraWarpSettings>();
		set => TrySetValue<GcCameraWarpSettings>(value);
	}

	public GcCameraGlobals(long address) : base(address)
	{

	}
}
