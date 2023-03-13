using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionSystemPlanetTest : NMSTemplate
{
	public Boolean RequiresExtremePlanet
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcPlayerHazardType PlanetWeatherRequirement
	{
		get => GetValue<GcPlayerHazardType>();
		set => TrySetValue<GcPlayerHazardType>(value);
	}

	public GcMissionConditionSystemPlanetTest(long address) : base(address)
	{

	}
}
