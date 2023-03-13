using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBuildingGlobals : NMSTemplate
{
	public Vector3f BuildingPartPreviewOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single BuildingPlacementEffectInterpRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementEffectInterpRateSlow
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementEffectPreviewInterpTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementEffectPostPreviewInterpTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementEffectSpringSlow
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementEffectSpringFast
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPartPreviewRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPartPreviewPitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPartPreviewRotateSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<TkLODDistances> ActiveLodDistances
	{
		get => cache.GetOrAddValue(new VirtualArray<TkLODDistances>(address + GetOffset(), 4));
		set => TrySetValue<TkLODDistances>(value);
	}

	public VirtualArray<TkLODDistances> InactiveLodDistances
	{
		get => cache.GetOrAddValue(new VirtualArray<TkLODDistances>(address + GetOffset(), 4));
		set => TrySetValue<TkLODDistances>(value);
	}

	public TkTextureResource ScreenSpaceRotationIcon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public TkTextureResource ScreenSpaceRotationGlow
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public VirtualArray<GcBuildMenuIconSet> Icons
	{
		get => cache.GetOrAddValue(new VirtualArray<GcBuildMenuIconSet>(address + GetOffset(), 16));
		set => TrySetValue<GcBuildMenuIconSet>(value);
	}

	public Single PowerlineSnapDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HologramDistanceMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HologramDistanceMultiplierAlt
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean AllowBuildingUsingIntermediates
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single BuildingWaterMargin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingLineAlphaEnd0
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingLineAlphaEnd1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingLineAlphaStart
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingLineWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingLineMoveSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingLineResetTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingLineOBBShrink
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingLineProjectorWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingLineProjectorLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 BuildingLineCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single IconSpringTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverFadeAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverVisibilityTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverMinToStayActiveTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverStayActiveTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverLockedInitTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverLockedActiveTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverLockedIconScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverInactiveSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverFadeAlphaHmd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverTimeHmd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverVisibilityTimeHmd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverFadeTimeHmd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverMinToStayActiveTimeHmd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverStayActiveTimeHmd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverLockedInitTimeHmd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverLockedActiveTimeHmd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverLockedIconScaleHmd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverInactiveSizeHmd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LineMinDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LineDistanceRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxLineLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinLineLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinLineLengthShip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeightDiffLineAdjustMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeightDiffLineAdjustMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeightDiffLineAdjustFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType LineCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single BuildingYOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractMarkerYOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RadiusMultiplier_DoNotPlace
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RadiusMultiplier_DoNotPlaceClose
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RadiusMultiplier_DoNotPlaceAnywhereNear
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RadiusMultiplier_OnlyPlaceAround
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ObjectFadeRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AddToRadius_DoNotPlaceClose
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Radius_DoNotPlaceAnywhereNear
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ChanceOfAddingShelter
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SectorMessageReshowDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SectorMessageCenterDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SectorMessageMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinTimeBetweenBuildingEntryMessage
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinTimeBetweenBuildingEntryMessageBase
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FadeStart
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FadeDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NearMinAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LineScaleFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingNearDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingNearArcDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingVisitDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NearMaxLineLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NearMinLineLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NearLineScaleFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinElevatedHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxLowHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TextStringXOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TextTagXOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TextTagYOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TextTagWidthOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceTextXOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceTagXOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TextTagLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceForVisited
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceForTooltip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SmallIconSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LargeIconSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LargeIconArrowOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CompassIconSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SmallIconArrowOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMarkerOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMarkerOffsetPlanet
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMarkerOffsetSamePlanet
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MarkerLineWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour MarkerLineColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single AmountToMoveMarkerRoundSphere
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MarkerTransitionDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMarkerMinHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMarkerMaxHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxTimeBetweenEvents
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShowTimeNotDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UnknownBuildingRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxIconRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MarkerTimeIncrease
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlyingBuildingIconTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MinShipScanBuildings
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxShipScanBuildings
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single TestDistanceForSettlementBaseBufferAlignment
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinRadiusForBases
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseRadiusExtension
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxRadiusForPlanetBases
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxRadiusForSpaceBases
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinRadiusFromFeaturedBases
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementMaxConnectionLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementMaxDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementMaxDistanceNoHit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementMaxDistanceNoHitExtra
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementMaxDistanceScaleExtraMinSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementMaxDistanceScaleExtraMaxSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementMaxDistanceScaleExtra
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementCursorOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementDefaultMinDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementMinDistanceScaleIncrease
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementDefaultMinDistanceVR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementMinDistanceScaleIncreaseVR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementNumGhostsMinOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementNumGhostsVolume
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementGhostHearScaleDistanceMod
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementGhostHeartSizeScaleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementGhostHeartSizeScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementGhostHeartSizeSelected
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType BuildingPlacementGhostHeartSizeCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single BuildingPlacementGhostHeartWiringSizeOtherSnapped
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementGhostHeartWiringSizeScaleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementGhostHeartWiringSizeScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementTwistScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementConeStartRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementConeEndRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementConeEndDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementConeStartRadiusIndoors
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementConeEndRadiusIndoors
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementConeEndDistanceIndoors
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean BuildingPlacementEffectEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single BuildingPlacementEffectDissolveSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementEffectFadeWaitTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementEffectCrossFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementEffectHidePlaceholderFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BuildingPlacementEffectHidePlaceholderDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f BuildingPlacementScaleMinMax
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single InactiveVisibleComplexityFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean DebugForceShowInactives
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualArray<Single> TotalPlanetFrameTimeForComplexity
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> TotalSpaceFrameTimeForComplexity
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public Single MinPercentageNodesBufferFree
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinLoadingPercentageNodesBufferFree
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PercentagePhysicsComponentsForComplexity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaximumComplexityDensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ComplexityDensityTestRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ComplexityDensitySigmaSquared
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StartCrashSiteMinDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StartCrashSiteMaxDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StartShelterMinDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StartShelterMaxDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x80 FreighterBaseSpawnOverride
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Boolean BaseBuildingTerrainEditBoundsOverride
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single BaseBuildingTerrainEditBaseYOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseBuildingTerrainEditTopYOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseBuildingTerrainEditBoundsScalar
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean BaseBuildingCamEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single BaseBuildingWiringSnappingScaleFactorEasy
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BaseBuildingWiringSnappingScaleFactorHard
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcBuildingGlobals(long address) : base(address)
	{

	}
}
