using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcExternalObjectFileList : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean OnlyOnExtremeWeather
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean OnlyOnExtremeSentinels
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean OnlyOnDeepWater
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean NotOnExtremePlanets
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean NotOnStartPlanets
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean NotOnWeirdPlanets
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean NotOnDeadPlanets
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ForceOnSeasonStart
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcBiomeType OnlyOnBiome
	{
		get => GetValue<GcBiomeType>();
		set => TrySetValue<GcBiomeType>(value);
	}

	public Single ProbabilityOfBeingActive
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MinFilesToChoose
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxFilesToChoose
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<GcExternalObjectListOptions> ExternalObjectFiles
	{
		get => cache.GetOrAddValue(new VirtualList<GcExternalObjectListOptions>(address + GetOffset()));
		set => TrySetValue<GcExternalObjectListOptions>(value);
	}

	public GcExternalObjectFileList(long address) : base(address)
	{

	}
}
