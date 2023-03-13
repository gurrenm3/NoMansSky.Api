using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Globals;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcEnvironmentGlobals : NMSTemplate
{
	public VirtualArray<TkLODSettingsData> LODSettings
	{
		get => cache.GetOrAddValue(new VirtualArray<TkLODSettingsData>(address + GetOffset(), 4));
		set => TrySetValue<TkLODSettingsData>(value);
	}

	public Vector2f SpaceBuildingTemperature
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public GcCloudProperties CloudProperties
	{
		get => GetValue<GcCloudProperties>();
		set => TrySetValue<GcCloudProperties>(value);
	}

	public Single SenseProbingValueSmoothingTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SenseProbingValueSmoothingTimeMed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SenseProbingValueSmoothingTimeSlow
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IndoorsLightingWeightAround
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IndoorsLightingWeightOverhead
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IndoorsLightingWeightTowardsSun
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IndoorsLightingWeightGround
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IndoorsLightingTransitionTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IndoorsLightingThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IndoorsLightingPlanetMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IndoorsLightingAbandonedFreighterMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IndoorsLightingNexusMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IndoorsLightingFreighterMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxElevation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SphereLodTextureScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ForceAddUnderwaterProps
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceAddCaveProps
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single DistortionStep
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HDeform
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SDeform
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VDeform
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LocationStableTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InterestStableTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AsteroidFieldStableEnterTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AsteroidFieldStableLeaveTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TemperatureSmoothTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SunFactorMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExposureSurfaceContrib
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExposureSurfaceDistMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ExposureGroundFactorAddMul
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f ExposureHeightBracket
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single DailyTempChangePercent
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceTemperature
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AbandonedFreighterMinTemperature
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AbandonedFreighterMaxTemperature
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipTemperature
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceRadiation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipRadiation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceToxicity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ShipToxicity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean MatchPlantPalettes
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single DuplicateColourThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.Globals.GcEnvironmentGlobals.SwitchTypeEnum SwitchType
	{
		get => GetValue<libMBIN.NMS.Globals.GcEnvironmentGlobals.SwitchTypeEnum>();
		set => TrySetValue<libMBIN.NMS.Globals.GcEnvironmentGlobals.SwitchTypeEnum>(value);
	}

	public Single GrassNormalUpright
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GrassNormalOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GrassNormalSpherify
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GrassNormalMap
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinPlacementBlendValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinPlacementBlendValuePatch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxPlacementBlendValuePatch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinPlacementObjectScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpaceStationStateBoundingBoxScaler
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AtmosphereSpaceRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpawnLowerAtmosphereRadiusMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TerrainFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TerrainFadeTimeInShip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureFadeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FloraFadeTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FloraFadeTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlanetUnwrapMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlanetUnwrapMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TerrainFlattenMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TerrainFlattenMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeightFogHeightMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaterFogHeightMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaterAlphaHeightMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaterAlphaHeightMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DoFHeightMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DoFHeightMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SunClampHeightMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SunClampHeightMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeavyAirFadeDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeavyAirFadeInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeavyAirFadeOutTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlanetFlipDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlanetEffectEndDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AsteroidFadeHeightMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AsteroidFadeHeightMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AsteroidScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SmallAsteroidScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AsteroidMinRotate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AsteroidMaxRotate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinWaterReflections
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<Single> SpacePlanetFogStrength
	{
		get => cache.GetOrAddValue(new VirtualList<Single>(address + GetOffset()));
		set => TrySetValue<Single>(value);
	}

	public VirtualList<Single> SkyBlendLength
	{
		get => cache.GetOrAddValue(new VirtualList<Single>(address + GetOffset()));
		set => TrySetValue<Single>(value);
	}

	public Single SkyAtmospherePower
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<Single> SkyAtmosphereBlendLength
	{
		get => cache.GetOrAddValue(new VirtualList<Single>(address + GetOffset()));
		set => TrySetValue<Single>(value);
	}

	public VirtualList<Single> FarBlendHeight
	{
		get => cache.GetOrAddValue(new VirtualList<Single>(address + GetOffset()));
		set => TrySetValue<Single>(value);
	}

	public Single FarBlendLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IndoorColourBlendTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour IndoorAmbientColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single LightDirectionHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LightDirectionBlend
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LightColourHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LightColourBlend
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ObjectSpawnFirstRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ObjectSpawnFirstDotCheck
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ObjectSpawnDetailRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InteractionRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean EnableWind
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<TkShearWindData> ShearWindSettings
	{
		get => cache.GetOrAddValue(new VirtualList<TkShearWindData>(address + GetOffset()));
		set => TrySetValue<TkShearWindData>(value);
	}

	public Int32 HotspotsLOD
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single RegionHotspotProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxHotspotOffsetDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinHotspotFalloffDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxHotspotFalloffDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcEnvironmentProperties EnvironmentProperties
	{
		get => GetValue<GcEnvironmentProperties>();
		set => TrySetValue<GcEnvironmentProperties>(value);
	}

	public GcEnvironmentProperties EnvironmentPrimeProperties
	{
		get => GetValue<GcEnvironmentProperties>();
		set => TrySetValue<GcEnvironmentProperties>(value);
	}

	public GcEnvironmentGlobals(long address) : base(address)
	{

	}
}
