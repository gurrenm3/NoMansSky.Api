using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGalaxyGlobals : NMSTemplate
{
	public Boolean NewStyleLookAtCamera
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean GizmoOnHand
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Vector2f ClickToSelectIconOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single ClickToSelectIconScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MenuRotateHmd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MenuOffsetHmd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MenuSideOffsetHmd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MenuScaleHmd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MenuCursorRadiusHmd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HexStackOffsetX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HexStackOffsetXOdd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HexStackOffsetY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HexMarkerWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HexMarkerRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HexMarkerRotation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HexMarkerOuterWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x80 MarkerDefaultHex
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Single PathToTargetLineTimeFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathToTargetIndicatorTimeFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathUISelectionMultiplierPad
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathUISelectionMultiplierMouse
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathUIConfirmSelectionMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathUISelectionMultiplierPushing
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathUISelectionGenerosity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathUISelectionMouseSmoothRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathUISelectionMouseDeadZone
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathUISelectionHandLineSelectAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathUISelectionHandSystemSelectAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathUISelectionHandInvalidLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 SolarInfoPanelWidth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 SolarInfoPanelHeight
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single HandControlRotateSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControlPitchSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControlMoveSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControlPointerLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControlPointerLengthMini
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControlGizmoScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControlMaxOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControlMoveBlendRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControlRotateBlendRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControlFreeMoveMaxOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControlFreeMoveAngleOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControlDefaultOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControlWarpSelectAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControlMinLockDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControlMaxLockDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandTurnFactorMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandTurnFactorRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandPitchFactorMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandPitchFactorRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandPitchMaxDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandZoomFactorMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandZoomFactorRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandControlZoomSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour HandGizmoColourAt
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour HandGizmoColourRight
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour HandGizmoColourUp
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Vector3f HandGizmoHeadOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single HandGizmoMinAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandGizmoRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandGizmoLineThickness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandGizmoInnerRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HandGizmoInnerThickness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour HandGizmoColourInner
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public GcInWorldUIScreenData HandMenuOffset
	{
		get => GetValue<GcInWorldUIScreenData>();
		set => TrySetValue<GcInWorldUIScreenData>(value);
	}

	public Vector2f SolarInfoPanelOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f SolarInfoPanelLineOffset
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f SolarInfoPanelOffsetVR
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f SolarInfoPanelAlignment
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f SolarMarkerAlignmentVR
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f IntroLabelAlignmentVR
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f SolarMarkerOriginOffsetVR
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single SolarMarkerPanelScaleVR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SolarInfoPanelScaleVR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SolarLabelScaleDistanceVR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathUIWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StarPathUIWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FadeGameOutTimeCentreJourney
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FadeMapInTimeCentreJourney
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathUIAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathUIDotLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathUIGapLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathUIHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathUIXOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathUIYOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathUISlotSpacing
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathUISlotRadiusInner
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathUISlotRadiusOuter
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathUISlotRadiusRing
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathUISlotWidthRing
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MarkerDropShadowSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MarkerDropShadowMult
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlanetUIIconLargeScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlanetUIIconMediumScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlanetUIIconSmallScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShowPopupAtCameraMinDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GalacticPathMaximumJumpDistanceLightyears
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GalacticPathPreferGuideStarsTillJump
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShowUIHelpDuration
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SystemInfoPanelGeneralAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType MarkerPulseStartCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public TkCurveType MarkerPulseEndCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public VirtualArray<Colour> GalacticWaypointDefaultColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 7));
		set => TrySetValue<Colour>(value);
	}

	public VirtualArray<Colour> GalacticWaypointProtanopiaColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 7));
		set => TrySetValue<Colour>(value);
	}

	public VirtualArray<Colour> GalacticWaypointDeuteranopiaColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 7));
		set => TrySetValue<Colour>(value);
	}

	public VirtualArray<Colour> GalacticWaypointTritanopiaColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 7));
		set => TrySetValue<Colour>(value);
	}

	public VirtualArray<Colour> RaceFilterDefaultColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 8));
		set => TrySetValue<Colour>(value);
	}

	public VirtualArray<Colour> RaceFilterProtanopiaColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 8));
		set => TrySetValue<Colour>(value);
	}

	public VirtualArray<Colour> RaceFilterDeuteranopiaColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 8));
		set => TrySetValue<Colour>(value);
	}

	public VirtualArray<Colour> RaceFilterTritanopiaColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 8));
		set => TrySetValue<Colour>(value);
	}

	public VirtualArray<Colour> EconomyFilterDefaultColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 7));
		set => TrySetValue<Colour>(value);
	}

	public VirtualArray<Colour> EconomyFilterProtanopiaColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 7));
		set => TrySetValue<Colour>(value);
	}

	public VirtualArray<Colour> EconomyFilterDeuteranopiaColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 7));
		set => TrySetValue<Colour>(value);
	}

	public VirtualArray<Colour> EconomyFilterTritanopiaColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 7));
		set => TrySetValue<Colour>(value);
	}

	public VirtualArray<Colour> ConflictFilterDefaultColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 4));
		set => TrySetValue<Colour>(value);
	}

	public VirtualArray<Colour> ConflictFilterProtanopiaColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 4));
		set => TrySetValue<Colour>(value);
	}

	public VirtualArray<Colour> ConflictFilterDeuteranopiaColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 4));
		set => TrySetValue<Colour>(value);
	}

	public VirtualArray<Colour> ConflictFilterTritanopiaColours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 4));
		set => TrySetValue<Colour>(value);
	}

	public VirtualArray<GcGalaxyMarkerSettings> MarkerSettings
	{
		get => cache.GetOrAddValue(new VirtualArray<GcGalaxyMarkerSettings>(address + GetOffset(), 16));
		set => TrySetValue<GcGalaxyMarkerSettings>(value);
	}

	public Single IntroFadeInRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IntroTitleFadeTrigger
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IntroTitleHoldTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IntroFadeOutRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IntroCameraLookSmoothRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IntroTitleTextureScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TransitionTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType TransitionOutCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single FinalHoldTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FinalFadedTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FinalHoldTowardsCenterTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FinalFadeInRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FinalFadeOutRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FinalTransitionMaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FinalTransitionAcceleration
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FinalTransitionInterpolationValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EarlyStageMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OffWorldDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceComputerScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathRenderingSelectedStartAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathRenderingSelectedEndAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathRenderingSelectedStepAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathRenderingUnselectedStartAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathRenderingUnselectedEndAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathRenderingUnselectedStepAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StarBlurMaxDistanceFromCamera
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StarBlurMaxBlurLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StarBlurSizeMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StarBlurLineWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StarBlurIntroMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AnostreakAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType AnostreakAlphaCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public TkCurveType AnostreakValueCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public GcGalaxyRenderAnostreakData AnostreakAway
	{
		get => GetValue<GcGalaxyRenderAnostreakData>();
		set => TrySetValue<GcGalaxyRenderAnostreakData>(value);
	}

	public GcGalaxyRenderAnostreakData AnostreakFacing
	{
		get => GetValue<GcGalaxyRenderAnostreakData>();
		set => TrySetValue<GcGalaxyRenderAnostreakData>(value);
	}

	public Single SelectionTreeAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour SelectionTreeColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Vector2f GoalDistanceRange
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public GcGalaxyStarColours BaseStarDefaultColours
	{
		get => GetValue<GcGalaxyStarColours>();
		set => TrySetValue<GcGalaxyStarColours>(value);
	}

	public GcGalaxyStarColours BaseStarProtanopiaColours
	{
		get => GetValue<GcGalaxyStarColours>();
		set => TrySetValue<GcGalaxyStarColours>(value);
	}

	public GcGalaxyStarColours BaseStarDeuteranopiaColours
	{
		get => GetValue<GcGalaxyStarColours>();
		set => TrySetValue<GcGalaxyStarColours>(value);
	}

	public GcGalaxyStarColours BaseStarTritanopiaColours
	{
		get => GetValue<GcGalaxyStarColours>();
		set => TrySetValue<GcGalaxyStarColours>(value);
	}

	public GcGalaxyCameraData Camera
	{
		get => GetValue<GcGalaxyCameraData>();
		set => TrySetValue<GcGalaxyCameraData>(value);
	}

	public GcGalaxyAudioSetupData Audio
	{
		get => GetValue<GcGalaxyAudioSetupData>();
		set => TrySetValue<GcGalaxyAudioSetupData>(value);
	}

	public Single FadeGameOutTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FadeMapInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FadeMapOutTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FadeGameInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LargeAreaColourScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcGalaxyRenderSetupData DefaultRenderSetup
	{
		get => GetValue<GcGalaxyRenderSetupData>();
		set => TrySetValue<GcGalaxyRenderSetupData>(value);
	}

	public GcGalaxyGenerationSetupData DefaultGeneration
	{
		get => GetValue<GcGalaxyGenerationSetupData>();
		set => TrySetValue<GcGalaxyGenerationSetupData>(value);
	}

	public GcGalaxyRenderSetupData FinalAnimationRenderSetup
	{
		get => GetValue<GcGalaxyRenderSetupData>();
		set => TrySetValue<GcGalaxyRenderSetupData>(value);
	}

	public GcGalaxyGenerationSetupData FinalAnimationGeneration
	{
		get => GetValue<GcGalaxyGenerationSetupData>();
		set => TrySetValue<GcGalaxyGenerationSetupData>(value);
	}

	public GcGalaxySolarSystemParams SolarSystemParameters
	{
		get => GetValue<GcGalaxySolarSystemParams>();
		set => TrySetValue<GcGalaxySolarSystemParams>(value);
	}

	public GcGalaxyGlobals(long address) : base(address)
	{

	}
}
