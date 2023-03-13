using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;
using libMBIN;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWeatherEffect : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20A OSDMessage
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualList<GcWeightedFilename> Effects
	{
		get => cache.GetOrAddValue(new VirtualList<GcWeightedFilename>(address + GetOffset()));
		set => TrySetValue<GcWeightedFilename>(value);
	}

	public libMBIN.NMS.GameComponents.GcWeatherEffect.SpawnConditionsEnum SpawnConditions
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcWeatherEffect.SpawnConditionsEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcWeatherEffect.SpawnConditionsEnum>(value);
	}

	public Int32 MaxHazardsOfThisTypeActive
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x10 ForcedOnByHazard
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 BlockedByCluster
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public libMBIN.NMS.GameComponents.GcWeatherEffect.WeatherEffectBehaviourEnum WeatherEffectBehaviour
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcWeatherEffect.WeatherEffectBehaviourEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcWeatherEffect.WeatherEffectBehaviourEnum>(value);
	}

	public libMBIN.NMS.GameComponents.GcWeatherEffect.WeatherEffectSpawnTypeEnum WeatherEffectSpawnType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcWeatherEffect.WeatherEffectSpawnTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcWeatherEffect.WeatherEffectSpawnTypeEnum>(value);
	}

	public Boolean RandomRotationAroundUp
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single MinSpawnScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxSpawnScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 SpawnAttemptsPerRegion
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single SpawnChancePerSecondPerAttempt
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ChanceOfPlanetBeingExtreme
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpawnChancePerSecondExtreme
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinSpawnDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxSpawnDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinLifetime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxLifetime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FadeoutStart
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean FadeoutVisuals
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean FadeoutAudio
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcAudioWwiseEvents Audio
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public NMSString0x80 ImpactGift
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Single ImpactGiftChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ClusterSpawnChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ClusterMinLifetime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ClusterMaxLifetime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PatchMaxTimeSpawnOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PatchMinRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PatchMaxRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 PatchMinSpawns
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 PatchMaxSpawns
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single PatchScaling
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MoveSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WanderMinRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WanderMaxRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WanderMinArcDeg
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WanderMaxArcDeg
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSTemplate EffectData
	{
		get => GetValue<NMSTemplate>();
		set => TrySetValue<NMSTemplate>(value);
	}

	public GcWeatherEffect(long address) : base(address)
	{

	}
}
