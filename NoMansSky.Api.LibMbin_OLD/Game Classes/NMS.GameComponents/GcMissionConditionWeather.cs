using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionWeather : NMSTemplate
{
	public Boolean IsExtreme
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcPlayerHazardType WeatherRequirement
	{
		get => GetValue<GcPlayerHazardType>();
		set => TrySetValue<GcPlayerHazardType>(value);
	}

	public Boolean StormActive
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IgnoreStormIfInShip
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean AllowNonHazardExtremeIfNoStorms
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionWeather(long address) : base(address)
	{

	}
}
