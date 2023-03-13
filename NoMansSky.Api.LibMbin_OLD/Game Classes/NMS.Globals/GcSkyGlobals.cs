using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSkyGlobals : NMSTemplate
{
	public Single RainbowDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RainbowScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RainbowWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RainbowAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RainbowStormAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RainbowFadeWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NightThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPhotoModeAdjustData FogAdjust
	{
		get => GetValue<GcPhotoModeAdjustData>();
		set => TrySetValue<GcPhotoModeAdjustData>(value);
	}

	public GcPhotoModeAdjustData CloudAdjust
	{
		get => GetValue<GcPhotoModeAdjustData>();
		set => TrySetValue<GcPhotoModeAdjustData>(value);
	}

	public GcPhotoModeAdjustData VignetteAdjust
	{
		get => GetValue<GcPhotoModeAdjustData>();
		set => TrySetValue<GcPhotoModeAdjustData>(value);
	}

	public TkCurveType DoFAdjustMagnitudeMaxCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Int32 DayLength
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Vector3f SunRotationAxis
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Int32 SafeSkyMinIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 SafeSkyMaxIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 FrozenSkyMinIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 FrozenSkyMaxIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single SunClampAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f PhotoModeVignette
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single PhotoModeSunSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PhotoModeMacroMaxDOFAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PhotoModeMacroMaxDOFAperture
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean UpdateWeatherWhenSunLocked
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single WeatherFilterSpaceTransitionChangeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FreshStartTimeOfDay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ForceStormSetting
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single ForceStormStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StormScreenFilterFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StormScreenFilterDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinTimeBetweenStormsLow
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxTimeBetweenStormsLow
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinTimeBetweenStormsHigh
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxTimeBetweenStormsHigh
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinTimeBetweenStormsExtremeFallback
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxTimeBetweenStormsExtremeFallback
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinStormLengthLow
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxStormLengthLow
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinStormLengthHigh
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxStormLengthHigh
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StormWarningTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StormTransitionTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxCloudCover
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxStormCloudCover
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ForceFlightSetting
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single ForceFlightStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ToFootFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ToFlightFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InFlightStormStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureStormThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TakeoffStormThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExtremeAudioLevel
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StormAudioLevel
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CloudCoverSmoothTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CloudRatioSmoothTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StormCloudTopColourMinBlend
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StormCloudTopColourMaxBlend
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StormCloudBottomColourMinBlend
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StormCloudBottomColourMaxBlend
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StormCloudSmoothTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean SleepSunFromSettings
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Vector3f SleepSunFromSettingsPos
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f SunPosition
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Colour AsteroidColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour DayLightColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour NightLightColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour DuskLightColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour NightHeavyAirColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour SpaceLightColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour AbandonedFreighterFogColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single HeavyAirScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AmbientFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinSunsetFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxSunsetFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinSunsetHorizonFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxSunsetHorizonFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinNightFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxNightFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinSunsetPosFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxSunsetPosFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinSunsetFogFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxSunsetFogFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinSunsetAtmosphereFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxSunsetAtmosphereFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinSunsetColourFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxSunsetColourFade
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinSaturation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxSaturation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinFogSaturation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxFogSaturation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinFogValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxFogValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinColourS
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxColourS
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinColourV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxColourV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MulticolourH
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NebulaColourH
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NebulaColour1S
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NebulaColour1V
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NebulaColour2S
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NebulaColour2V
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MidColourH
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MidColourS
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MidColourV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CloudColourH
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CloudColourS
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CloudColourV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceAtmosphereThickness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaterHeavyAirAlpha
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NightHorizonBlendMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NightHorizonBlendMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NightSkyBlendMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NightSkyBlendMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NightLightBlendMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NightLightBlendMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ForceNightBlend
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single ForceNightBlendValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NoAtmosphereFogStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NoAtmosphereFogMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NoAtmosphereColourStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NoAtmosphereColourMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LowFlightFogThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPlanetSkyProperties PlanetProperties
	{
		get => GetValue<GcPlanetSkyProperties>();
		set => TrySetValue<GcPlanetSkyProperties>(value);
	}

	public GcPlanetSkyProperties PlanetPrimeProperties
	{
		get => GetValue<GcPlanetSkyProperties>();
		set => TrySetValue<GcPlanetSkyProperties>(value);
	}

	public GcFogProperties AbandonedFreighterFog
	{
		get => GetValue<GcFogProperties>();
		set => TrySetValue<GcFogProperties>(value);
	}

	public GcSpaceSkyProperties SpaceSkyMin
	{
		get => GetValue<GcSpaceSkyProperties>();
		set => TrySetValue<GcSpaceSkyProperties>(value);
	}

	public GcSpaceSkyProperties SpaceSkyMax
	{
		get => GetValue<GcSpaceSkyProperties>();
		set => TrySetValue<GcSpaceSkyProperties>(value);
	}

	public VirtualList<GcSpaceSkyColours> SpaceSkyColours
	{
		get => cache.GetOrAddValue(new VirtualList<GcSpaceSkyColours>(address + GetOffset()));
		set => TrySetValue<GcSpaceSkyColours>(value);
	}

	public GcPlanetWeatherColourData NightSkyColours
	{
		get => GetValue<GcPlanetWeatherColourData>();
		set => TrySetValue<GcPlanetWeatherColourData>(value);
	}

	public Colour HeavyAirColour1
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour HeavyAirColour2
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour NightHorizonColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour NightSkyColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour NightFogColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour NightHeightFogColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public GcPlanetCloudProperties PlanetCloudsMin
	{
		get => GetValue<GcPlanetCloudProperties>();
		set => TrySetValue<GcPlanetCloudProperties>(value);
	}

	public GcPlanetCloudProperties PlanetCloudsMax
	{
		get => GetValue<GcPlanetCloudProperties>();
		set => TrySetValue<GcPlanetCloudProperties>(value);
	}

	public Single BinaryStarChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TernaryStarChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeatherBloomGain
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeatherBloomGainSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeatherBloomThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeatherBloomThresholdSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WeatherBloomImpulseSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkCurveType WeatherBloomCurve
	{
		get => GetValue<TkCurveType>();
		set => TrySetValue<TkCurveType>(value);
	}

	public Single MaxRainWetness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RainWetnessFadeInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RainWetnessFadeOutTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcSkyGlobals(long address) : base(address)
	{

	}
}
