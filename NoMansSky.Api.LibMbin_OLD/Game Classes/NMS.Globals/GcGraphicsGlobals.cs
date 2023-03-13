using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGraphicsGlobals : NMSTemplate
{
	public Single LUTDistanceFlightMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SunLightIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SunLightBlendTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HBAOBias
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HBAORadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HBAOIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcLightShaftProperties LightShaftProperties
	{
		get => GetValue<GcLightShaftProperties>();
		set => TrySetValue<GcLightShaftProperties>(value);
	}

	public GcLightShaftProperties StormLightShaftProperties
	{
		get => GetValue<GcLightShaftProperties>();
		set => TrySetValue<GcLightShaftProperties>(value);
	}

	public Single SunRayDensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SunRayDecay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SunRayExposure
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SunRayWeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Brightness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Contrast
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Saturation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean Redo_On
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single Redo_LightIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Redo_SkyIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Redo_BounceIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single New_BounceLightWarp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single New_BounceLightPower
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single New_BounceLightIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single New_SkyLightWarp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single New_SkyLightPower
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single New_SkyLightIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single New_SideRimWarp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single New_SideRimColourMixer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single New_TopRimWarp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single New_TopRimColourMixer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single New_TopRimPower
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single New_TopRimIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Old_BounceLightWarp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Old_BounceLightPower
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Old_BounceLightIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Old_SkyLightWarp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Old_SkyLightPower
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Old_SkyLightIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Old_SideRimWarp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Old_SideRimColourMixer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Old_TopRimWarp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Old_TopRimColourMixer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Old_TopRimPower
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Old_TopRimIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ModelRendererLightIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PetModelRendererLightIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanFresnel
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanClamp
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour ScanColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Boolean DebugLinesDepthTest
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CenterRenderSpaceOffset
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkImGuiSettings ImGui
	{
		get => GetValue<TkImGuiSettings>();
		set => TrySetValue<TkImGuiSettings>(value);
	}

	public Colour UIColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour UIShipColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single HUDMotionXSpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMotionYSpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMotionPosSpring
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMotionX
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMotionY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDMotionPos
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HUDDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NearClipDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FarClipDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpK
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpKCube
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpKDispersion
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 ShadowMapSize
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single DirectionLightRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DirectionLightFOV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DirectionLightShadowBias
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShadowLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShadowLengthShip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShadowLengthSpace
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShadowLengthStation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShadowLengthFreighter
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShadowLengthFreighterAbandoned
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShadowLengthCameraView
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector4f ShadowSplit
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Vector4f ShadowSplitShip
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Vector4f ShadowSplitSpace
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Vector4f ShadowSplitStation
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Vector4f ShadowSplitCameraView
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Vector4f ShadowBias
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Boolean ShadowQuantized
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single ShadowBillboardOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuantizeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuantizeTimeShip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuantizeTimeSpace
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single QuantizeTimeCameraView
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ToneMapExposure
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HDRExposure
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HDRGamma
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HDRLutExposure
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HDRLutGamma
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HDRLutToe
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HDRThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HDROffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LensThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LensOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LensScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LensDirt
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ToneMapExposureCave
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HDRExposureCave
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HDRThresholdCave
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HDROffsetCave
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LensThresholdCave
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LensOffsetCave
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LensScaleCave
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LensDirtCave
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFNearPlane
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFFarPlane
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFAmountManual
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFAmountManualLightIndoor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFAmountManualFullIndoor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFAmountManualLight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFAmountManualFull
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFNearFadeDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFNearFadeDistanceManual
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFFarFadeDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFFarPlaneCave
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFFarFadeDistanceCave
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFFarPlaneSpace
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFFarFadeDistanceSpace
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFFarStrengthWater
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFFarPlaneWater
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFFarFadeDistanceWater
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFFarPlaneManual
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFFarFadeDistanceManualIndoor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFFarFadeDistanceManual
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFAutoFarAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFAutoFarFarPlaneFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFAutoFarFarPlane
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFAutoFarNearPlane
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFNearMinInteraction
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFNearAdjustInteraction
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFFarPlaneInteraction
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DOFFarFadeDistanceInteraction
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean DOFEnableBokeh
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DOFEnableNewBokehShader
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean DOFEnablePhysCamera
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single VignetteStart
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VignetteEnd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VignetteStartTurnVR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VignetteEndTurnVR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VignetteStartMoveVR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VignetteEndMoveVR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VignetteVRTurnInterpTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VignetteVRMoveInterpTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VignetteStartMoveVRShip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VignetteEndMoveVRShip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VignetteVRMoveInterpTimeShip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VignetteStartTurnVRShip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VignetteEndTurnVRShip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VignetteVRTurnInterpTimeShip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VignetteStartTurnRidingVR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VignetteEndTurnRidingVR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VignetteVRTurnRidingInterpTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VignetteStartRidingVR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VignetteEndRidingVR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VignetteVRRidingInterpTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LowHealthVignetteStart
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LowHealthVignetteEnd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LowHealthDesaturationIntensityMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LowHealthDesaturationIntensityMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LowHealthDesaturationIntensityTimeSinceHit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LowHealthOverlayIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LowHealthFadeInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LowHealthFadeOutTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LowHealthPulseRateLowShield
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LowHealthPulseRateFullShield
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LowHealthStrengthLowShield
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LowHealthStrengthFullShield
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShieldDownScanlineTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean FullscreenScanEffect
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseImposters
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Vector4f MipLevelDebug
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Vector4f LensParams
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Colour VerticalColourTop
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour VerticalColourBottom
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Vector4f VerticalGradient
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
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

	public Single ScanEffectSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanObjectFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanBandWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanHeightScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanHorizontalScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Single1ScanTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Single1ScanHeightScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Single1ScanBandWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Single1ScanEffectSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Single1ScanObjectFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Single1ScanHorizontalScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Single2ScanTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Single2ScanHeightScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Single2ScanBandWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Single2ScanEffectSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Single2ScanObjectFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Single2ScanHorizontalScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TeleportFlashTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f WindDir1
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Vector2f WindDir2
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single AtmosphereSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RingSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RingRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HueVariance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SaturationVariance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ValueVariance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FoliageSaturationMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FoliageSaturationMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FoliageValueMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FoliageValueMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GrassSaturationMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GrassSaturationMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GrassValueMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GrassValueMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SkySaturationMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SkySaturationMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SkyValueMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SkyValueMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceMieFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceSunFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxSpaceFogStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ReflectionStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AlphaCutoutMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AlphaCutoutMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaterHueShift
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaterSaturation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaterValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxParticleRenderRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxParticleRenderRangeSpace
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MotionBlurShutterSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MotionBlurShutterAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TaaLowFreqConstant
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TaaHighFreqConstant
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TaaAccumDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrustumJitterAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FrustumJitterAmountDLSS
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean UseTaaResolve
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ApplyTaaTest
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShowTaaBuf
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean TonemapInLuminance
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShowTaaVarianceBuf
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShowTaaNVarianceBuf
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShowTaaCVarianceBuf
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Vector4f TaaSettings
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public VirtualArray<Vector4f> TessSettings
	{
		get => cache.GetOrAddValue(new VirtualArray<Vector4f>(address + GetOffset(), 4));
		set => TrySetValue<Vector4f>(value);
	}

	public Vector4f TerrainMipDistanceLow
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Vector4f TerrainMipDistanceMed
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Vector4f TerrainMipDistanceHigh
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Vector4f TerrainMipDistanceUlt
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public VirtualArray<Vector4f> ShellsSettings
	{
		get => cache.GetOrAddValue(new VirtualArray<Vector4f>(address + GetOffset(), 4));
		set => TrySetValue<Vector4f>(value);
	}

	public Int32 TerrainAnisoLow
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 TerrainAnisoMed
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 TerrainAnisoHi
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 TerrainAnisoUlt
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 TerrainDroppedMipsLow
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 TerrainDroppedMipsMed
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single TerrainMipBiasLow
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TerrainMipBiasMed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 TerrainBlocksPerFrameLow
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 TerrainBlocksPerFrameMed
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 TerrainBlocksPerFrameHi
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 TerrainBlocksPerFrameUlt
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 TerrainBlocksPerFramePs430
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 TerrainBlocksPerFramePs460
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 TerrainBlocksPerFrameXb130
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 TerrainBlocksPerFrameXb160
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 TerrainBlocksPerFrameOberon
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean EnableTerrainCachePs4Base
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EnableTerrainCachePs4Pro
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EnableTerrainCacheXb1Base
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EnableTerrainCacheXb1X
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceCachedTerrain
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceUncachedTerrain
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single MinPixelSizeOfObjectsInShadowsSpace
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinPixelSizeOfObjectsInShadowsPlanet
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinPixelSizeOfObjectsInShadowsCockpitOnPlanet
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean AllowPartialCascadeRender
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<Int32> CascadeRenderSequence
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public Int32 SupersamplingLevel
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean EnableTextureStreaming
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceStreamAllTextures
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceEvictAllTextures
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 TargetTextureMemUsageMB
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single MotionBlurThresholdOnFoot
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MotionBlurThresholdInVehicle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MotionBlurThresholdSpace
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MotionBlurThresholdDefault
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceIBLBlendStart
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceIBLBlendDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NoFocusMaxFPS
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean EnableCrossPipeSharing
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EnableSSR
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ShowReflectionProbes
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single SharpenFilterAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SharpenFilterDepthFactorStart
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SharpenFilterDepthFactorEnd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<TkGraphicsDetailPreset> GraphicsDetailPresetsPC
	{
		get => cache.GetOrAddValue(new VirtualArray<TkGraphicsDetailPreset>(address + GetOffset(), 4));
		set => TrySetValue<TkGraphicsDetailPreset>(value);
	}

	public TkGraphicsDetailPreset GraphicsDetailPresetPS4
	{
		get => GetValue<TkGraphicsDetailPreset>();
		set => TrySetValue<TkGraphicsDetailPreset>(value);
	}

	public TkGraphicsDetailPreset GraphicsDetailPresetPS4VR
	{
		get => GetValue<TkGraphicsDetailPreset>();
		set => TrySetValue<TkGraphicsDetailPreset>(value);
	}

	public TkGraphicsDetailPreset GraphicsDetailPresetPS4Pro
	{
		get => GetValue<TkGraphicsDetailPreset>();
		set => TrySetValue<TkGraphicsDetailPreset>(value);
	}

	public TkGraphicsDetailPreset GraphicsDetailPresetPS4ProVR
	{
		get => GetValue<TkGraphicsDetailPreset>();
		set => TrySetValue<TkGraphicsDetailPreset>(value);
	}

	public TkGraphicsDetailPreset GraphicsDetailPresetXB1
	{
		get => GetValue<TkGraphicsDetailPreset>();
		set => TrySetValue<TkGraphicsDetailPreset>(value);
	}

	public TkGraphicsDetailPreset GraphicsDetailPresetXB1X
	{
		get => GetValue<TkGraphicsDetailPreset>();
		set => TrySetValue<TkGraphicsDetailPreset>(value);
	}

	public TkGraphicsDetailPreset GraphicsDetailPresetOberon
	{
		get => GetValue<TkGraphicsDetailPreset>();
		set => TrySetValue<TkGraphicsDetailPreset>(value);
	}

	public TkGraphicsDetailPreset GraphicsDetailPresetPS5VR
	{
		get => GetValue<TkGraphicsDetailPreset>();
		set => TrySetValue<TkGraphicsDetailPreset>(value);
	}

	public Boolean EnableVariableUpdate
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualArray<Single> VariableUpdatePeriodModifers
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public Single PhotoModeBloomGainMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PhotoModeBloomThresholdMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PhotoModeDefaultBloomValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PhotoModeMediumValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PhotoModeBloomGainMedium
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PhotoModeBloomThresholdMedium
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PhotoModeBloomGainMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PhotoModeBloomThresholdMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcGraphicsGlobals(long address) : base(address)
	{

	}
}
