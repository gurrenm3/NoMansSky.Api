using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcUIGlobals : NMSTemplate
{
	public Boolean ShowDifficultyForBases
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShowPadlockForLockedSettings
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 DebugMedalRank
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkCurveType PadCursorUICurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Colour JoaoBoxCompletedObjectiveColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour InvSlotGradientBaseColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single InvSlotGradientFactorMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InvSlotGradientFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InvSlotGradientTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour SuperchargePopupColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour SuperchargeGradientBaseColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour SuperchargeGradientBlendColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour SuperchargeGradientTechColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single SuperchargeGradientFactorMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SuperchargeGradientFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SuperchargeGradientTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GridDecayRateSwitchValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PadCursorUICurveStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ReplaceItemBarWithNumbers
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 DebugInventoryHint
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 MaxSubstanceMaxAmountForAmountFraction
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean UseSquareSlots
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean BigPicking
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean BigPickingUsesNumbers
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single FreighterMegaWarpTransitionTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean EnablePopupUses
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean TechBoxesCanStack
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 UnknownWordsToShowInCatalogue
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean UseIntermediateMissionGiverOptions
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single SentinelsDisabledHUDMessageTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UseZoomedOutBuildCamRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ParagraphAutoScrollSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean AutoScrollParagraphs
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single EggModifiyAnimMaxSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EggModifiyAnimLoopTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 SeasonFinalStageIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<GcSeasonalRingArray> SeasonalRingTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcSeasonalRingArray>(address + GetOffset()));
		set => TrySetValue<GcSeasonalRingArray>(value);
	}

	public Single SeasonalRingMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SeasonalRingPulseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SeasonalRingChangeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinSeasonPlayTimeInDays
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExpeditionStageChangeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MilestoneStingDisplayTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StageStingDisplayTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EndOfSeasonAlertDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 ShowHoursIfLessThan
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ShowDaysIfLessThan
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ShowWeeksIfLessThan
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x10 ExplorationLogMissionID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 ForceOpenHazardProtInventoryThreshold
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single PlanetDataExtraRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StackSizeRateChangeRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StackSizeChangeMinRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StackSizeChangeMaxRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ClosestDoorMarkerBuffer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean SkipShopIntro
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single ZoomFactorOverride
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandheldZoomFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlacedMarkerFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LoadingTravelDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LoadingScreenTravelSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LoadingScreenTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OSDMessagePauseOffscreenAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuickMenuCentrePos
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuickMenuSideOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuickMenuCentreSideOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InWorldInteractLabelScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InWorldScreenScaleDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f InWorldInteractLabelAlignment
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector3f InWorldInteractLabelCentreOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f InWorldInteractLabelTopOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f InWorldInteractLabelLineOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single InWorldInteractLabelMinHeadOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InWorldInteractLabelNearDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InWorldInteractLabelNearRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InWorldInteractLabelFarDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InWorldInteractLabelFarRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipHUDMarkerHideDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipHUDMarkerOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExocraftHUDMarkerHideDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExocraftHUDMarkerOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetSlotUnlockBounceTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetHUDMarkerExtraFollowInfoDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetHUDMarkerHideDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetHUDMarkerHideDistanceShort
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetHUDMarkerOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetMoodMarkerOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BeaconHUDMarkerOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f BinocularEdgeFade
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single BinocularScreenOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BinocularScreenScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BinocularMarkerSideAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BinocularMarkerUpAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean BinocularScanScreen
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single BinocularsNearIconOpacity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BinocularsNearIconDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BinocularsNearIconFadeDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BinocularsMidIconOpacity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BinocularsFarIconOpacity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BinocularsFarIconDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BinocularsFarIconFadeDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AlignmentRequiredToDisableFrostedGlass
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f BinocularPanelLinePointOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single FrontendOffsetVR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ProjectorScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CockpitGlassFrostTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CockpitGlassDefrostTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TextPrintoutMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TextPrintoutMultiplierAlien
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean EnableHandMenuButtons
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AllowInWorldDebugBorders
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Vector2f MarkerDistanceVRAlignment
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single CompassIconOffsetVR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LowerHelmetScreenScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LowerHelmetScreenPitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f LowerHelmetScreenOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single InWorldScreenMinScreenDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InWorldScreenForwardOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InWorldNGuiScreenScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f InWorldNGuiScreenRotation
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector2f InWorldNGuiParallax
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f InWorldGameGuiAlignment
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Int32 InWorldInteractLabelWidth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 InWorldInteractLabelHeight
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x20 VRDistanceWarningUIFile
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Boolean ShowVRDistanceWarning
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Vector3f FaceLockedScreenOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Int32 VRFaceLockedScreenWidth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 VRFaceLockedScreenHeight
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean OnlyShowEjectHandlesInVR
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 CompassScreenWidth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 CompassScreenHeight
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single CompassLineContractionStartAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CompassLineContractionEndAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CompassLineContractionTargetAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 CompassLineNumNotches
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single CompassLineThickness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CompassLineOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CompassLineNotchAngleRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CompassLineNotchThickness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CompassLineNotchLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean EnableHandMenuDebug
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single HandControlMenuCursorScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuickMenuCursorScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuickMenuAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandScreenGraphicsWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandScreenGraphicsHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandScreenNearActivateDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandButtonRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandButtonRadiusTouch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandButtonRadiusTouchNear
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandButtonRadiusTouchNearActive
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandButtonPostClickTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandButtonReleaseThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandButtonReleaseThresholdInit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandButtonCursorScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandButtonPushDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandButtonNearDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandButtonRadiusClick
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandButtonClickTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandButtonTouchReturnTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandButtonFrontendCursorScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandButtonThickness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandButtonDotRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandButtonPulseRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandButtonPulseThickness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipSideScreenHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SolidPointerScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SolidPointerLengthScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SolidPointerMaxLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InWorldInteractionScreenScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InWorldNPCInteractionScreenScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean EnableCraftingTree
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean QuickMenuEnableSwipe
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single QuickMenuSwipeHeightMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuickMenuSwipeHeightMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildMenuItemNavAnimTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildMenuItemNextNavAnimTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildMenuItemNextNavAnimWait
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuickMenuInteractAdjustX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuickMenuInteractAdjustY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 QuickMenuScreenWidth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 QuickMenuScreenHeight
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single QuickMenuHighlightRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControlButtonSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControlPointMargin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControlPointActiveMargin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControlMenuMoveDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControlMenuMoveDistanceScroll
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControlMenuMoveDistanceVertical
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControlMenuMoveActionDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControlMenuAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControlMenuSurfaceOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControlMenuSelectRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControlMenuSelectRadius1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControlMenuSelectRadius2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControlTopMenuSelectRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 HandScreenWeaponWidth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 HandScreenWeaponHeight
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 HandScreenWidth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 HandScreenHeight
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Colour DebugEditorAxisColourUpInactive
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour DebugEditorAxisColourUpActive
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour DebugEditorAxisColourRightInactive
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour DebugEditorAxisColourRightActive
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour DebugEditorAxisColourAtInactive
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour DebugEditorAxisColourAtActive
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour QuickMenuSelectedItemColour1
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour QuickMenuSelectedItemColour2
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public TkModelRendererData ShipThumbnailModelView
	{
		get => GetValue<TkModelRendererData>();
		set => TrySetValue<TkModelRendererData>(value);
	}

	public TkModelRendererData PetThumbnailModelView
	{
		get => GetValue<TkModelRendererData>();
		set => TrySetValue<TkModelRendererData>(value);
	}

	public TkModelRendererData MultitoolThumbnailModelView
	{
		get => GetValue<TkModelRendererData>();
		set => TrySetValue<TkModelRendererData>(value);
	}

	public TkModelRendererData LargeMultitoolThumbnailModelView
	{
		get => GetValue<TkModelRendererData>();
		set => TrySetValue<TkModelRendererData>(value);
	}

	public Colour FrontendCursorBackgroundColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single NGuiHmdOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HmdFramerateScreenPitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f HmdFramerateScreenOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single CrosshairScaleHmd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrosshairOffsetHmd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrosshairOffsetHmdUp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 CrosshairScreenWidth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 CrosshairScreenHeight
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single HUDMarkerHoverAngleTestGroundHmd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerWideHoverAngleTestHmd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean InteractionInWorldPlayerCamAlways
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single InteractionInWorldPitchDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionInWorldMinScreenDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionInWorldSeatedNPCHeightAdjust
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TravelTargetRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TravelLineThickness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour TravelLineColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour TravelLineTooFarColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour TravelLineTooSteepColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour TravelLineInvalidColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour TravelLineNotAllowedColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour TravelTargetColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Boolean AlwaysCloseQuickMenu
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseWorldNodesForRepair
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean RepairTechUseTechIcon
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DebugMissionLogText
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DebugShowMaintenanceScreenCentre
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DebugPopupSizes
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DebugInventoryIndices
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean FixedInventoryIconPositions
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcHUDEffectRewardData OSDRareItemRewardEffect
	{
		get => GetValue<GcHUDEffectRewardData>();
		set => TrySetValue<GcHUDEffectRewardData>(value);
	}

	public GcHUDEffectRewardData OSDEpicItemRewardEffect
	{
		get => GetValue<GcHUDEffectRewardData>();
		set => TrySetValue<GcHUDEffectRewardData>(value);
	}

	public Single OSDMessageQueueSpeedMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 OSDMessageQueueMin
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 OSDMessageQueueMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single PopupValueSectionBaseHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PopupValueSectionHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour ProcProductColourCommon
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ProcProductColourUncommon
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ProcProductColourRare
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public VirtualList<Vector2f> InventoryIconPositions
	{
		get => cache.GetOrAddValue(new VirtualList<Vector2f>(address + GetOffset()));
		set => TrySetValue<Vector2f>(value);
	}

	public Colour PickedItemBorderColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour MultiplayerMissionParticipantsColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public NMSString0x10 MultiplayerMissionInteractStartTrigger
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 MultiplayerMissionInteractEndTrigger
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single NotificationHazardMinTimeAfterRecharge
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LoadFadeInDefaultTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneIndicatorRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneIndicatorCentreRadiusMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneIndicatorCentreRadiusMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneIndicatorFadeRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WantedDetectMessageTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WantedDetectMinTimeout
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TakeoffFuelMessageTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MarkerHorizonOffsetAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MarkerHorizonMinOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MarkerHorizonApproachAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MarkerOffsetTypeAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MarkerOffsetTypeAngleBattle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MarkerOffsetTypeAngleBounty
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MarkerOffsetTypeAnglePlayerShip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MarkerOffsetTypeAngleAsteroid
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MarkerHorizonOffPlanetLightBeamAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MarkerHorizonShipApproachOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TransferPopupCursorOffsetFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScannableIconMergeAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureIconMergeAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MaxNumMessageBeaconIcons
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single MissionObjectiveBaseHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissionObjectiveDoneHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissionObjectiveScrollingExtra
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissionDetailsPageBaseHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MarkerTagAppearDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f CompassCentre
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single CompassHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CompassWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CompassDistanceScaleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CompassDistanceScaleRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CompassDistanceSpaceScaleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CompassDistanceSpaceScaleRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CompassDistanceScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CompassDistanceShipMinScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CompassDistanceMaxAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CompassDistanceYOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CompassAngleClamp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CompassAngleFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType CompassCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single CompassAngleClampSpace
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseComplexityDangerFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseComplexityWarningFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour BaseComplexityDefaultColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour BaseComplexityWarningColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour BaseComplexityDangerColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single BuildMenuActionMessageDuration
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<NMSString0x20A> BuildMenuOnActionLocIDs
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 16));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> BuildMenuOnActionDisabledLocIDs
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 16));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> BuildMenuOnActionErrorLocIDs
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 16));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<Boolean> BuildMenuUseSmallIconOnPad
	{
		get => cache.GetOrAddValue(new VirtualArray<Boolean>(address + GetOffset(), 16));
		set => TrySetValue<Boolean>(value);
	}

	public Colour BuildMenuPassiveErrorTextColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour BuildMenuPassiveErrorTextOutlineColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour BuildMenuErrorTextColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour BuildMenuErrorTextOutlineColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour BuildMenuErrorTextFlashColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour BuildMenuErrorTextOutlineFlashColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour BuildMenuInfoTextColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour BuildMenuInfoTextOutlineColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single IconGlowStrengthError
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IconGlowStrengthActive
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IconGlowStrengthNeutral
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IconGlowStrengthHighlight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour IconGlowColourError
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour IconGlowColourActive
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour IconGlowColourNeutral
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour IconGlowColourHighlight
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single BaseBuildingPinHighlightDuration
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseBuildingInputHighlightDuration
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseBuildingInputHighlightAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseBuildingScaleSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseBuildingMinFreeRotateSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseBuildingMaxFreeRotateSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseBuildingTimeToMaxRotationSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseBuildingRotationResetRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseBuildingFreeRotateSpeedPadMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseBuildingFreeRotateDelayBeforeReset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseBuildingFreeRotateDelayBeforeAudioStops
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean BaseBuildingSmoothMenuWhileSnapped
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single BaseBuildingUIHorizontalSafeArea
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseBuildingUIVerticalSafeArea
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseBuildingUIVerticalPosWiring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseBuildingUIVerticalOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseBuildingUIVerticalOffsetEdit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseBuildingUIVerticalOffsetFromBB
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseBuildingUIErrorFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseBuildingUIAdjustTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseBuildingPartsGridMaxCursorRestorationTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseBuildingPartsGridBreadcrumbFlashDuration
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseBuildingPartsGridMinVisibilityForActive
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseBuildingPartsGridScrollSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseBuildingPartsGridPopupDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkTextureResource BaseBuildingPartsGridExpandableIcon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public TkTextureResource BaseBuildingPartsGridExpandedIcon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public TkTextureResource BaseBuildingPartsGridRetractableIcon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public Single MarkerRingInnerRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MarkerRingOuterRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour MarkerRingBGColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single RepairTechRepairedWaitTime1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RepairTechRepairedWaitTime2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RepairTechRepairedMessageTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TechPopupRepairLayerHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TechPopupBuildLayerHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TechPopupRequirementHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageTrackArrowTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean EnableBlackouts
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single HUDMarkerObjectMinScreenDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerDistanceOrTimeDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MarkerComponentOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RepairTechLabelOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaintenanceIconFadeStart
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaintenanceIconFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkModelRendererData RepairCamera
	{
		get => GetValue<TkModelRendererData>();
		set => TrySetValue<TkModelRendererData>(value);
	}

	public TkModelRendererData RepairWeaponCamera
	{
		get => GetValue<TkModelRendererData>();
		set => TrySetValue<TkModelRendererData>(value);
	}

	public TkModelRendererData RepairBackpackCamera
	{
		get => GetValue<TkModelRendererData>();
		set => TrySetValue<TkModelRendererData>(value);
	}

	public TkModelRendererData RepairShipCameraInWorld
	{
		get => GetValue<TkModelRendererData>();
		set => TrySetValue<TkModelRendererData>(value);
	}

	public TkModelRendererData RepairShipCameraModelView
	{
		get => GetValue<TkModelRendererData>();
		set => TrySetValue<TkModelRendererData>(value);
	}

	public TkModelRendererData RepairShipCameraVR
	{
		get => GetValue<TkModelRendererData>();
		set => TrySetValue<TkModelRendererData>(value);
	}

	public VirtualList<TkModelRendererData> VehicleTypeRepairCamera
	{
		get => cache.GetOrAddValue(new VirtualList<TkModelRendererData>(address + GetOffset()));
		set => TrySetValue<TkModelRendererData>(value);
	}

	public Vector2f BinocularsDiscoveryPos
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Colour InteractionLabelCostColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour InteractionLabelPickupColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour InteractionLabelPickupFillColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Vector2f PersonalRefinerInputPos
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f PersonalRefinerOutputPos
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public TkTextureResource RefinerPopupEmptyOutputIcon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public Single RefinerPadStartTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RefinerPadStartDecayTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RefinerBeginDialInnerRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RefinerProgressDialInnerRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f DefaultRefinerOffsetIn
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f DefaultRefinerOffsetOut
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector2f RefinerParallax
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f ModelViewWorldParallax
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f HUDPlayerSentinelPulseFreq
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f HUDPlayerSentinelPulseSize
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single HUDPlayerSentinelPulseWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerSentinelRangeFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerSentinelPulseScanFreq
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerPhonePulseScanFreq
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RefinerAutoCloseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour RefinerBackgroundColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour RefinerErrorBackgroundColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour GridDisconnectedColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour GridOnlineColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour GridOfflineColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour GridBackgroundNeutralColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour GridBackgroundPositiveColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour GridBackgroundNegativeColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour TransferSendPopupColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single BountyMarkerOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlanetRaidMarkerOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TransitionOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PageTurnTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType PageTurnCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public TkCurveType PageTurnFadeCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single LowHealthShieldMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LowHealthShieldFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MaxDialogCharSizeRoman
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x20 MaxDialogCharSizeRomanString
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Int32 MaxDialogCharSizeIdeographic
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x20 MaxDialogCharSizeIdeographicString
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Single ShipOverheatSwitchMessageWait
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipOverheatSwitchMessageTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean LeadTargetEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SpaceOnlyLeadTargetEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Vector2f SaveIconPosition
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single MissionStartEndTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissionStartEndOSDTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissionStartEndOSDTimeProcedural
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StandingRewardOSDTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour MissionOSDMessageBarColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour NotificationDefaultColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour NotificationDangerColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour NotificationInfoColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour NotificationUrgentColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single ShipDamageDirectionIndicatorRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipDamageDirectionIndicatorFadeRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OnFootDamageDirectionIndicatorRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OnFootDamageDirectionIndicatorFadeRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageDirectionIndicatorOnScreenRadiusMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f DialogPageCursorOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f IntermediateInteractionPageCursorOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f CursorlessDialogPageCursorOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Int32 MissionSpecificMissionPercent
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MissionLoopCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MissionSeedOffset
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Vector3f SpaceMapCockpitOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single SpaceMapCockpitScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapCockpitScaleAdjustDropShip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapCockpitScaleAdjustFighter
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapCockpitScaleAdjustScientific
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapCockpitScaleAdjustShuttle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapCockpitScaleAdjustRoyal
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapCockpitScaleAdjustSail
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapCockpitScaleAdjustAlien
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapCockpitAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TargetDisplayScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TargetDisplayShipScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f TargetDisplayShipOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single TargetDisplayDamageFlashTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcScanEffectData TargetDisplayScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public Boolean ProgressiveDialogStyle
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single CommunicatorMessageTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour CommunicatorMessageColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single GridFlickerBaseAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GridFlickerFreq
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GridFlickerAmp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerLabelWidthMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerLabelBaseWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerLabelArriveDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerLabelDisplayDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerNonActiveMissionAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean DebugMarkerLabels
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcScanEffectData DebugEditorPreviewEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public Boolean ShowDamageNumbers
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single QuickMenuCloseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuickMenuErrorTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendWaitResponse
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendWaitInitial
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendWaitInitialTerminal
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendWaitFadeTextOut
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendWaitFadeTextFrameOut
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendWaitFadeProgressiveDialogOut
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendWaitResponseOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TalkBoxAlienTextSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TalkBoxAlienTextTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TalkBoxAlienTextTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DescriptionTextDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DescriptionTextSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DescriptionTextSpeedProgressive
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DescriptionTextTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DescriptionTextTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ConsoleTextSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ConsoleTextTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ConsoleTextTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverOffscreenBorder
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverOffscreenBorderVR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TransferSendOffscreenBorder
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TimedEventLookTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureDistanceSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureDistanceOffsetY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureDistanceShadowOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureDistanceDisplayAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureDistanceFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureDistanceAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ShowOnscreenPredatorMarkers
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single DamageImpactMergeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageImpactTimeBetweenNumbers
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageImpactMinDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamagePerSecondSampleTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageNumberTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageNumberSizeInShip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageNumberSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageNumberSizeCritMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageNumberSizeLaserMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageNumberLaserMinDamage
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageNumberLaserMaxDamage
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageNumberBlackAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageNumberOutline
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageNumberOutline2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageNumberOffsetX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageNumberOffsetY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f DamageNumberSideSpeed
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single DamageNumberFadeIn
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageNumberFadeOut
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DamageNumberUpOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType DamageNumberUpCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Colour DamageNumberCriticalColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour DamageNumberIneffectiveColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour DamageNumberIneffectiveWarningColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour PhotoModeSelectedColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour PhotoModeUnselectedColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour FuelBgColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single PhotoModeValueAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PhotoModeTimeofDayChange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrigateIconOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureIconOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureIconOffsetPhysics
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DelayBeforeHidingHangarAfterGalaxyMap
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DelayBeforeShowingHangarIntoGalaxyMap
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterSummonTurn
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterSummonPitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterSummonOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterSummonOffsetPulse
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterSummonDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 FreighterSummonTurnNumTries
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single FreighterSummonTurnAngleIncrement
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterSummonGridSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterCommanderMarkerMinDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterSurfaceMinAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterSummonPulseRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterSummonPulseFadeAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterSummonPlanetOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterSummonLookTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterHighlightRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcScanEffectData FreighterSummonScanEffect
	{
		get => GetValue<GcScanEffectData>();
		set => TrySetValue<GcScanEffectData>(value);
	}

	public Colour FreighterSummonScanEffectColourBlocked
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour FreighterSummonScanEffectColourHighlight
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single PirateCountdownTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateAttackIndicatorWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateAttackIndicatorRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PirateAttackProbeDisplayFinishFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HazardArrowsLevel2Threshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HazardArrowsLevel3Threshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ArrowBounceLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ArrowBounceRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ArrowBounceRightRate1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ArrowBounceRightRate2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType ArrowBounceRightCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single ArrowBounceLeftRate1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ArrowBounceLeftRate2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ArrowBounceLeftRate3
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType ArrowBounceLeftCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single PlanetScanDelayTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AlwaysShowIconFadeDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AlwaysShowIconFadeRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrigatePurchaseNotificationResetDistanceMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrigateDamageIconVisibilityDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterLeaderIconDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreighterEntranceOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipHeadsUpDisplayDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipHeadsUpLineFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrosshairAimTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrosshairAimOffTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrosshairInnerMinFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrosshairInnerMinFadeRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrosshairLeadScaleIn
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrosshairLeadInDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrosshairLeadInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrosshairLeadCornerOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrosshairLeadTopOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrosshairLeadTopLock
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrosshairLeadPulseSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType CrosshairLeadScaleCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single CrosshairSpringTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrosshairSpringAimTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrosshairLeadSpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrosshairLeadSpringOff
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrosshairLeadFadeRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrosshairLeadFadeSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour CrosshairLeadThreatColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour CrosshairLeadPassiveColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single CrosshairInterceptSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrosshairInterceptBaseSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrosshairInterceptCentreBaseSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrosshairInterceptSpringTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrosshairInterceptAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrosshairInterceptLockRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CrosshairTargetLockSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> CrosshairTargetLockSizeSpecific
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 19));
		set => TrySetValue<Single>(value);
	}

	public TkCurveType CrosshairTargetLockCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public TkCurveType CrosshairTargetLockAlphaCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Colour CrosshairColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public TkHitCurveData CrosshairLeadHitCurve
	{
		get => GetValue<TkHitCurveData>();
		set => TrySetValue<TkHitCurveData>(value);
	}

	public TkHitCurveData ShootableHitCurve
	{
		get => GetValue<TkHitCurveData>();
		set => TrySetValue<TkHitCurveData>(value);
	}

	public Int32 ControlScrollSteps
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single ControlScrollDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour SelectedControlColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour RemappedControlColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single MissionCompassIconScaler
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissionMarkerSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureRoutineMarkerTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 CreatureRoutineRegionsPerFrame
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single SpaceMarkersOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMarkersBattleOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LargeSpaceIconSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SmallSpaceIconSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetHoverIconSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetIconSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f TrackTypeIconOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single TrackTypeIconSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrackPrimaryCentreOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrackTimerAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrackTimerRadarPulseSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrackTimerIconOuterRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrackTimerIconInnerRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrackTimerIconExclaimRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissileCentreOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrackMissileTargetPulseRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrackScaleCritical
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrackScaleHit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrackLeadTargetInScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrackReticuleScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrackReticuleAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrackReticuleInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrackReticuleInactiveTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrackReticuleRandomTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrackReticuleRandomDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType TrackReticuleInCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public TkCurveType TrackReticuleInAngleCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single CreatureReticuleScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType CreatureReticuleScaleCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public TkCurveType CreatureReticuleAlphaCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Boolean CreatureInteractLabelUseBB
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single CreatureInteractLabelOffsetY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDDroneHealingPulse
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDDroneSummoningPulse
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDDroneCombatPulse
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackNoSightPulse
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackTimerStart
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackTimerStartFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackTimerEnd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackTimerPulseRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType TrackCritCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Vector2f TrackCriticalHitOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single TrackCriticalHitSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrackCriticalPulseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonCrosshairDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonCrosshairCircle1Distance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThirdPersonCrosshairCircle2Distance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowShipLabelOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowIconPulseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowIconShowTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowIconFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f HUDPlayerTrackArrowIconPulseSize
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single HUDPlayerTrackArrowIconPulseWidth1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowIconPulseWidth2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowIconPulse2Alpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowIconFadeDistShip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowIconFadeDistDrone
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowIconFadeDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowIconFadeRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowIconFadeRangeShip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowIconBorderReducerShip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowPulseOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowPulseRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f HUDPlayerTrackIconOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single ShipFullscreenDamperMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipFullscreenDamper
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipDesatDamper
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanEventArrowShipFadeRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanEventArrowShipFadeDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanEventArrowPlayerFadeRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanEventArrowPlayerFadeDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanEventArrowOffsetMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanEventArrowOffsetMultiplierOneEvent
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanEventArrowSecondaryAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcAudioWwiseEvents ScanEventIconAudio
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public TkNGuiRectanglePulseEffect PulseBarData
	{
		get => GetValue<TkNGuiRectanglePulseEffect>();
		set => TrySetValue<TkNGuiRectanglePulseEffect>(value);
	}

	public TkNGuiRectanglePulseEffect PulseIconData
	{
		get => GetValue<TkNGuiRectanglePulseEffect>();
		set => TrySetValue<TkNGuiRectanglePulseEffect>(value);
	}

	public Colour PulseDamageColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour PulseAlertColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single TechDisplayDelayTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CriticalMessageTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 NumDeathQuotes
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x10 ShowStatWithDeathQuote
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean EnableKanaConversion
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single HUDDisplayTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackDangerPulse
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowTextOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowTextHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour HUDPlayerTrackArrowTextColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single HUDPlayerTrackArrowHealthOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f HUDPlayerTrackArrowHealthSize
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Colour HUDPlayerTrackArrowEnergyShieldColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour HUDPlayerTrackArrowEnergyShieldLowColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single HUDPlayerTrackArrowEnergyShieldLowThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowEnergyShieldOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f HUDPlayerTrackArrowEnergyShieldSize
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single HUDPlayerTrackArrowGlowBaseOpacity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowDamageGlowHullHitCriticalOpacityScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowDamageGlowHullHitOpacityScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour HUDPlayerTrackArrowDamageGlowHullHitMaxColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour HUDPlayerTrackArrowDamageGlowHullHitMinColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single HUDPlayerTrackArrowDamageGlowShieldHitCriticalOpacityScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowDamageGlowShieldHitOpacityScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour HUDPlayerTrackArrowDamageGlowShieldHitMaxColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour HUDPlayerTrackArrowDamageGlowShieldHitMinColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single HUDPlayerTrackArrowDamageGlowOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f HUDPlayerTrackArrowDamageGlowSize
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single HUDPlayerTrackArrowEnergyShieldGlowOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f HUDPlayerTrackArrowEnergyShieldGlowSize
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single HUDPlayerTrackArrowEnergyShieldDepletedGlowOpacityScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowEnergyShieldDepletedTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType HUDPlayerTrackArrowEnergyShieldDepletedCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Colour HUDPlayerTrackArrowEnergyShieldDepletedGlowMaxColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour HUDPlayerTrackArrowEnergyShieldDepletedGlowMinColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single HUDPlayerTrackArrowEnergyShieldStartChargeGlowOpacityScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowEnergyShieldStartChargeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType HUDPlayerTrackArrowEnergyShieldStartChargeCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Colour HUDPlayerTrackArrowEnergyShieldStartChargeGlowMaxColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour HUDPlayerTrackArrowEnergyShieldStartChargeGlowMinColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single HUDPlayerTrackArrowTargetDistShip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowTargetDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowScreenBorder
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowSizeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowSizeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowIconSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowSmallIconSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowArrowSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowDotSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour HUDPlayerTrackArrowDotColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour HUDPlayerTrackArrowDotColourPolice
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour HUDPlayerTrackArrowDotColourPirate
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour HUDPlayerTrackArrowDotColourTrader
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour HUDWarningColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour HUDNotifyColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single HUDPlayerTrackArrowMinFadeDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPlayerTrackArrowFadeRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Colour> SystemHooverLEDColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 4));
		set => TrySetValue<Colour>(value);
	}

	public VirtualArray<Colour> SystemHooverStatusBarColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 4));
		set => TrySetValue<Colour>(value);
	}

	public Single GalaxyMapRadialBorder
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GalaxyMapRadialTargetDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IconBackgroundAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WantedLevelWitnessPulseRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WantedLevelWitnessOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WantedLevelTimeoutPulseRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WantedLevelWitnessAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WantedLevelScanAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WantedLevelScannedRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<NMSString0x80> StatIcons
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x80>(address + GetOffset()));
		set => TrySetValue<NMSString0x80>(value);
	}

	public Boolean ShowJetpackNotificationForNonTerrain
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single StatsMessageDelayTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SeasonMessageDelayTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean HideExtremePlanetNotifications
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single NotificationBackgroundGradientEndOffsetPercentInShip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationBackgroundGradientAlphaInShip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 NotificationsResourceExtractHintCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single NotificationStaminaHintDistanceWalked
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationMinVisibleTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationHazardSafeThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationHazardTimer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationInteractHintStartTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationBuildHintStartTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationJetpackTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationShieldTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationShipBoostTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationShipBoostTimeVR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationCantFireTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationDangerTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationScanTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationScanTimeCutoff
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationMessageCycleTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationMaxPageHintTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationShipJumpMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationShipJumpReminderTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationShipJumpReminderTutorial
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationShipBoostMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationShipBoostReminderTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationShipBoostReminderTimeTutorial
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandNotifySpeedThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandNotifyHeightThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandNotifyTimeThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationTimeBeforeHeridiumMarker
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationUrgentMessageTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationGoToSpaceStationWait
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationMonolithMissionWait
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationFinalMissionWait
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationWaypointReachDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationBridgeReachDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationDiscoveryIdleTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationInfoIdleTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationNewTechIdleTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationScanEventMissionIdleTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationDeviceIdleTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationMissionHintTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationMissionHintTimeCritical
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NotificationMissionHintTimeSecondary
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f NotificationMissionHintPauseTime
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f NotificationMissionHintPauseTimeCritical
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f NotificationMissionHintPauseTimeSecondary
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single TooltipTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InventoryIconTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MessageNotificationTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MessageTimeQuick
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ItemReceivedMessageTimeToAdd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DeathMessageSwitchTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DeathMessageTotalTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour DeathMessageColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour PinnedRecipeBorder
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public NMSString0x20 DistanceUnitM
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x20 DistanceUnitKM
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x20 DistanceUnitMpS
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Single ZoomHUDElementsOffsetX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ZoomHUDElementsOffsetY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ZoomHUDElementTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDElementsOffsetHMDSide
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDElementsOffsetHMDTop
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDElementsOffsetHMDBottom
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDElementsOffsetX_0
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDElementsOffsetY_0
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDElementsOffsetX_1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDElementsOffsetY_1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDElementsOffsetX_2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDElementsOffsetY_2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDElementsOffsetX_3
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDElementsOffsetY_3
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDElementsOffsetX_4
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDElementsOffsetY_4
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDElementsOffsetX_5
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDElementsOffsetY_5
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcWorldUISettings WorldUISettings
	{
		get => GetValue<GcWorldUISettings>();
		set => TrySetValue<GcWorldUISettings>(value);
	}

	public Single PauseMenuHoldTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f PlanetLabelOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f PlanetMeasureOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f PlanetLineOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single PlanetLabelTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlanetLabelAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour ItemSlotColourSubstance
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ItemSlotColourTech
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ItemSlotColourTechCharge
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ItemSlotColourTechDamage
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ItemSlotColourPartiallyInstalled
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single ItemSlotColourTechChargeRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour ItemSlotColourProduct
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ItemSlotTextColourSubstance
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ItemSlotTextColourTech
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ItemSlotTextColourProduct
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single InteractionScanScanTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionScanMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionScanDisplayTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionScanSlapTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionScanSlapScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionScanSlapOverallTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType InteractionScanSlapCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single ShipHUDMissileLockSizeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipHUDMissileLockSizeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipHUDMissileLockSpringSlow
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipHUDMissileLockSpringFast
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipHUDMaxOffscreenTargetDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipHUDTargetRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipHUDTargetTriangleRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipHUDTargetAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipHUDTargetArrowLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipHUDTargetMinDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipHUDTargetRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipHUDTargetScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipHUDTargetArrowsRotationRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour ShipHUDTargetArrowsColourOutOfRange
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ShipHUDTargetArrowsColourThreat
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ShipHUDTargetArrowsColourLocal
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public VirtualList<Colour> ShipHUDTargetArrowsColour
	{
		get => cache.GetOrAddValue(new VirtualList<Colour>(address + GetOffset()));
		set => TrySetValue<Colour>(value);
	}

	public Colour ShipHUDAimTargetColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ShipHUDAimTargetCritColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single ShipHUDHitPointTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipHUDHitPointSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TargetScreenFoV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TargetScreenDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f TargetScreenCamOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single InventoryFullMessageRepeatTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoldTimerResetTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ModelRendererBGPass
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ModelRendererPass1
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ModelRendererPass2
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single HazardScreenEffectPulseRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single KeepHazardBarActiveTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single KeepSecondHazardBarActiveTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HazardBarPulseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HazardScreenEffectPulseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HazardScreenEffectStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HazardWarningPulseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HazardWarningPulseStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HazardPainPulseStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShieldSpringTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShieldPulseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShieldHazardPulseRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ShieldHUDAlwaysOn
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single ShieldHazardPulseThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AlwaysOnHazardThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AlwaysOnHazardStrengthTox
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AlwaysOnHazardStrengthHeat
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AlwaysOnHazardStrengthRad
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AlwaysOnHazardStrengthCold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AlwaysOnHazardMultiplierTox
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AlwaysOnHazardMultiplierHeat
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AlwaysOnHazardMultiplierRad
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AlwaysOnHazardMultiplierCold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HazardPulseRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<NMSString0x80> HazardTextures
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x80>(address + GetOffset()));
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualList<NMSString0x80> HazardNormalMaps
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x80>(address + GetOffset()));
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualList<NMSString0x80> HazardHeightmaps
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x80>(address + GetOffset()));
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 CamoTexture
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 CamoNormalTexture
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Single IconPulseRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour EnergyBgColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour EnergyBgPulseColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour HazardBgPulseColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour HazardDamagePulseColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ShieldColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ShieldDamageColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ShieldBgColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ShieldDamageBgColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Vector2f ScanLabelOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f InteractionLabelOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f InteractionLabelOffset_1
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f InteractionLabelSize
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f InteractionLabelLineOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single InteractionLabelRadiusScaler
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionLabelHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionLabelLineAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionIconInnerRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionIconOuterRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionLabelPixelHeightMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionLabelPixelHeightMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcModelViewCollection ModelViews
	{
		get => GetValue<GcModelViewCollection>();
		set => TrySetValue<GcModelViewCollection>(value);
	}

	public Colour CursorColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour CursorConfirmColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour CursorTransferUploadColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour CursorDeleteColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single CursorHoverSlowFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CursorHoverSlowFactorMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendBGAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendConfirmTimeMouseMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendConfirmTimeFast
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendTouchConfirmTimeFastMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendConfirmTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendConfirmTimeSlow
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType FrontendConfirmCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single FrontendCursorSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendCursorOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PopupXClampOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PopupXClampOffsetRightAligned
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PopupSlotWidthOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendCursorWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendDeactivateTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendDeactivateSplit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendActivateTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendActivateSplit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendStatCircleWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendStatCircleWidthExtra
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendBootTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendBootBarTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType FrontendBootBarCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single PopupDebounceTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PopupActivateTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PopupDeactivateTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType PopupActivateCurve1
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public TkCurveType PopupActivateCurve2
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single ByteBeatTreeLineWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour ByteBeatTreeLineColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single ByteBeatVisLineWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour ByteBeatVisLineColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ByteBeatVisGridColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single ByteBeatIconLineWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ByteBeatIconPad
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ByteBeatArpLineWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ByteBeatArpRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ByteBeatArpPad
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour ByteBeatArpGridInactiveColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ByteBeatArpGridActiveColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ByteBeatArpPipInactiveColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ByteBeatArpPipActiveColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single ByteBeatSequencerLineWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ByteBeatSequencerPad
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ByteBeatPartSequencerPad
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ByteBeatSequencerCornerRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ByteBeatRhythmBeatPad
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ByteBeatSequencerInactiveSaturation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ByteBeatSequencerActiveSaturation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ByteBeatRhythmSequencerInactiveSaturation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ByteBeatRhythmSequencerActiveSaturation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ByteBeatSequencerUnpoweredTintStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour ByteBeatSequencerUnpoweredTint
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ByteBeatSequencerBGColourActive
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ByteBeatSequencerBGColourInactive
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ByteBeatSequencerRimColourActive
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ByteBeatSequencerRimColourInactive
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ByteBeatRhythmColour0Active
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ByteBeatRhythmColour0Inactive
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ByteBeatRhythmColour1Active
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ByteBeatRhythmColour1Inactive
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ByteBeatRhythmColour2Active
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ByteBeatRhythmColour2Inactive
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ByteBeatSequencerHighlightColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single ByteBeatSequencerHighlightLineWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ByteBeatSliderLineWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ByteBeatSliderPad
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ByteBeatSliderCornerRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour ByteBeatSliderFGColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ByteBeatSliderTextActiveColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour ByteBeatSliderTextInactiveColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single ByteBeatSwitchPanelAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ByteBeatSwitchPanelSplit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour RadialMenuInnerColourSelected
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour RadialMenuOuterColourSelected
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour RadialMenuInnerColourUnselected
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour RadialMenuOuterColourUnselected
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour RadialMenuInnerColourDisabled
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour RadialMenuOuterColourDisabled
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single RadialMenuInnerRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RadialMenuInnerRadiusCursor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RadialMenuWedgeOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HatchPulseSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HatchPulseWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HatchPulsePauseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 HatchCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single HatchCursorRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HatchAlphaMain
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HatchAlphaBase
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HatchAlphaCursor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendDoFNearPlaneMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendDoFNearPlaneMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendDoFFarPlaneMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendDoFFarPlaneMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendDoFFarPlaneFadeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendDoFFarPlaneFadeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendDoFBlurMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean FrontendDoFEnableBokeh
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkCurveType FrontendDoFCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single FrontendShineSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendToolbarTextHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendToolbarTextHeightSelected
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrontendTitleFontSpacing
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NGuiPadSensitivity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NGuiMouseSensitivity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f NGuiTouchPadSensitivity
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Colour TargetMarkerColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour TargetMarkerHighlightColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single TargetMarkerScaleStart
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TargetMarkerScaleEnd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TargetMarkerFadeAngleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TargetMarkerFadeAngleRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HitMarkerPulseSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HitMarkerPulseSizeStatic
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HitMarkerPulseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour WantedColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour UnseenItemColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single PlanetPoleMaxDotProduct
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapLineWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapLineBaseScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapLineBaseFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapShipCombineDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean SpaceMapShowPlanets
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SpaceMapShowPlanetLines
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SpaceMapShowStation
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SpaceMapShowStationLines
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SpaceMapShowAnomaly
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SpaceMapShowAnomalyLines
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SpaceMapShowNexus
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SpaceMapShowNexusLines
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SpaceMapShowShips
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SpaceMapShowShipLines
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SpaceMapShowFrieghters
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SpaceMapShowFrieghterLines
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SpaceMapShowPulseEncounters
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SpaceMapShowPulseEncounterLines
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single SpaceMapFoV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapAspectRatio
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapDistanceScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapDistanceLogScaler
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType SpaceMapDistanceCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single SpaceMapScaleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapScaleRangeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapScaleRangeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapObjectScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapFreighterScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapStationScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapAnomalyScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapPlanetScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapPlanetLineOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapMoonScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapActionScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapShipScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapMarkerScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapMaxTraderDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapDistanceMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapHorizonThickness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapFadeAngleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapFadeAngleMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapCamHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapCamAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapCamDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapShipScaleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapLightPitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMapLightYaw
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour SpaceFriendlyShipLineColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour SpaceEnemyShipLineColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Vector3f SpaceMapPosScaler
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Colour SpaceMapAttackColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour SpaceMapOtherPlayerColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour SpaceMapThreatColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour SpaceMapNeutralColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour SpaceMapSquadronColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour SpaceMapDeathPointColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public GcSpaceMapObjectData SpaceMapMarkerData
	{
		get => GetValue<GcSpaceMapObjectData>();
		set => TrySetValue<GcSpaceMapObjectData>(value);
	}

	public GcSpaceMapObjectData SpaceMapPlanetData
	{
		get => GetValue<GcSpaceMapObjectData>();
		set => TrySetValue<GcSpaceMapObjectData>(value);
	}

	public GcSpaceMapObjectData SpaceMapStationData
	{
		get => GetValue<GcSpaceMapObjectData>();
		set => TrySetValue<GcSpaceMapObjectData>(value);
	}

	public GcSpaceMapObjectData SpaceMapNexusData
	{
		get => GetValue<GcSpaceMapObjectData>();
		set => TrySetValue<GcSpaceMapObjectData>(value);
	}

	public GcSpaceMapObjectData SpaceMapAtlasData
	{
		get => GetValue<GcSpaceMapObjectData>();
		set => TrySetValue<GcSpaceMapObjectData>(value);
	}

	public GcSpaceMapObjectData SpaceMapBlackHoleData
	{
		get => GetValue<GcSpaceMapObjectData>();
		set => TrySetValue<GcSpaceMapObjectData>(value);
	}

	public GcSpaceMapObjectData SpaceMapShipData
	{
		get => GetValue<GcSpaceMapObjectData>();
		set => TrySetValue<GcSpaceMapObjectData>(value);
	}

	public GcSpaceMapObjectData SpaceMapFreighterData
	{
		get => GetValue<GcSpaceMapObjectData>();
		set => TrySetValue<GcSpaceMapObjectData>(value);
	}

	public GcSpaceMapObjectData SpaceMapPulseEncounterData
	{
		get => GetValue<GcSpaceMapObjectData>();
		set => TrySetValue<GcSpaceMapObjectData>(value);
	}

	public Vector2f HUDTargetHealthOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f HUDTargetHealthSize
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f HUDTargetHealthIconOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single HUDTargetHealthIconSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDTargetHealthDangerTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDTargetMarkerOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDTargetMarkerSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDTargetIconOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDTargetIconSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour HUDMarkerColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour HUDSpaceshipColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour HUDRelicMarkerColourDiscovered
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour HUDRelicMarkerColourUnknown
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour HUDOutpostColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Vector2f HUDMarkerPrimaryIndicatorOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f HUDMarkerCompassPrimaryIndicatorOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public NMSString0x100 HUDMarkerIcon
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public NMSString0x100 HUDMarkerPrimaryIndicatorIcon
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public NMSString0x100 HUDMarkerColourIcon
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public NMSString0x100 HUDPointIcon
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public NMSString0x100 HUDSpaceshipIcon
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public NMSString0x100 HUDSaveIcon
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public NMSString0x100 HUDDeathPointIcon
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public NMSString0x100 HUDHexAnimIcon
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public NMSString0x100 HUDCircleAnimIcon
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public Single HUDMarkerAnimSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerAnimScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerAnimOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerAnimLoopTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType HUDMarkerAnimAlphaCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public TkCurveType HUDMarkerAnimCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single HUDMarkerPrimaryIndicatorSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPetMarkerAngleTest
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerHoverAngleTestGround
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDPetCentreScreenAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDNetworkMarkerHoverAngleTestGround
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerWideHoverAngleTest
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerHoverAngleTestShip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerHoverShowLargeAngleTest
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDNetworkMarkerHoverShowLargeAngleTest
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerShipOffsetMaxDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerShipOffsetMinDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerNearFadeDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerNearFadeRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerFarDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerFarFadeRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerScalerMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerScalerRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerScalerSizeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerScalerSizeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerHorizonBlendRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerModelFadeRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerModelFadeMinHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerShowActualIconDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerShowActualSpaceIconDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMarkerActiveTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType HUDMarkerActiveCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single HUDMarkerIconHoverMinScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AltimeterResolution
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AltimeterLineSpacing
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AltimeterWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AltimeterMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AltimeterMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AltimeterTextSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AltimeterMinValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour AltimeterBandColour1
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour AltimeterBandColour2
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour AltimeterColour1
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour AltimeterColour2
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single LockOnMarkerSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LockOnMarkerSizeLock
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour LockOnMarkerActiveColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single AsteroidMarkerMinDisplayDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AsteroidMarkerMinDisplayAngleDegrees
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissileIconAttackPulseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MissileIconAttackPulseAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NGuiModelRotationDegreesX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NGuiModelRotationDegreesY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NGuiModelRotationDegreesZ
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NGuiModelViewDistanceGlobal
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NGuiModelViewDistanceSuitPage
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NGuiModelViewDistanceWeaponPage
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NGuiModelViewDistanceShipPage
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NGuiModelViewDistanceDiscoveryPage
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NGuiModelViewFov
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NGuiModelViewCdSmoothTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NGuiAltPlacementDistanceScrollSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NGuiPlacementAngleScrollSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NGuiModelViewFractionOfBBHeightAboveReflectivePlane
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f NGuiModelTranslationFactors
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f NGuiModelTranslationFactorsInteraction
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f NGuiThumbnailModelTranslationFactors
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single NGuiThumbnailModelRotationDegreesY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NGuiThumbnailModelViewDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NGuiCursorOffsetMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NGuiActiveAreaOffsetTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f NGuiMin2DParallax
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f NGuiMax2DParallax
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f NGuiModelParallax
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f NGuiShipInteractParallax
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f InteractionWorldParallax
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single TargetParallaxMouseMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TargetParallaxMaintenancePageMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NGuiModelViewFadeInAfterRenderTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType NGuiModelViewFadeInAfterRenderCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Boolean NGuiUseSeparateLayersForModelAndReflection
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcDiscoveryHelperTimings DiscoveryHelperTimings
	{
		get => GetValue<GcDiscoveryHelperTimings>();
		set => TrySetValue<GcDiscoveryHelperTimings>(value);
	}

	public GcHUDStartupTable IntroTiming
	{
		get => GetValue<GcHUDStartupTable>();
		set => TrySetValue<GcHUDStartupTable>(value);
	}

	public GcHUDStartupTable IntroTimingFreighter
	{
		get => GetValue<GcHUDStartupTable>();
		set => TrySetValue<GcHUDStartupTable>(value);
	}

	public GcInventorySlotActionData InstallTechSlotAction
	{
		get => GetValue<GcInventorySlotActionData>();
		set => TrySetValue<GcInventorySlotActionData>(value);
	}

	public GcInventorySlotActionData BuildProductSlotAction
	{
		get => GetValue<GcInventorySlotActionData>();
		set => TrySetValue<GcInventorySlotActionData>(value);
	}

	public GcInventorySlotActionData ChargeSlotAction
	{
		get => GetValue<GcInventorySlotActionData>();
		set => TrySetValue<GcInventorySlotActionData>(value);
	}

	public GcInventorySlotActionData RepairSlotAction
	{
		get => GetValue<GcInventorySlotActionData>();
		set => TrySetValue<GcInventorySlotActionData>(value);
	}

	public GcInventorySlotActionData NewSlotRevealAction
	{
		get => GetValue<GcInventorySlotActionData>();
		set => TrySetValue<GcInventorySlotActionData>(value);
	}

	public GcInventorySlotActionData NewSlotPulseAction
	{
		get => GetValue<GcInventorySlotActionData>();
		set => TrySetValue<GcInventorySlotActionData>(value);
	}

	public GcInventorySlotActionData InventoryHintAction
	{
		get => GetValue<GcInventorySlotActionData>();
		set => TrySetValue<GcInventorySlotActionData>(value);
	}

	public Single ReportBaseFlashTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ReportBaseFlashIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ReportBaseFlashDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 ReportBaseTexWidth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ReportBaseTexHeight
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single ReportCameraSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AmbientModeFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean HideQuickMenuControls
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean QuickMenuAllowCycle
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single TextChatMaxDisplayTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TextChatStayBigAfterTextInput
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 BuildingShopMaxItems
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single ShipScreenTexScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MultiplayerTeleportEffectDisappearTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MultiplayerTeleportEffectAppearTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 AbandonedFreighterAirlockRoomNumber
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single SettlementStatInnerRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SettlementStatOuterRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour SettlementStatColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour SettlementStatBackgroundColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public VirtualArray<NMSString0x20A> SettlementStatLoc
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 7));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<NMSString0x20A> SettlementStatFormatLoc
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x20A>(address + GetOffset(), 7));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualArray<TkTextureResource> SettlementStatBasicImages
	{
		get => cache.GetOrAddValue(new VirtualArray<TkTextureResource>(address + GetOffset(), 7));
		set => TrySetValue<TkTextureResource>(value);
	}

	public VirtualArray<TkTextureResource> SettlementStatPositiveImages
	{
		get => cache.GetOrAddValue(new VirtualArray<TkTextureResource>(address + GetOffset(), 7));
		set => TrySetValue<TkTextureResource>(value);
	}

	public VirtualArray<TkTextureResource> SettlementStatNegativeImages
	{
		get => cache.GetOrAddValue(new VirtualArray<TkTextureResource>(address + GetOffset(), 7));
		set => TrySetValue<TkTextureResource>(value);
	}

	public Single MinimumHoldFill
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean EnableAccessibleUI
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single AccessibleUIPopupScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DetailMessageDismissTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TouchScrollMaxDelta
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TextTouchScrollCap
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TouchScrollChangePageThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ManualScrollChangePerInputMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ManualScrollChangePerInputMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InfoPortalGuideCycleTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InfoPortalMilestonesCycleTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FeedFrigateAnimPeriod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 FeedFrigateAnimNumPeriods
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single FeedFrigateAnimScaleChange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FeedFrigateAnimAlphaChange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcUIGlobals(long address) : base(address)
	{

	}
}
