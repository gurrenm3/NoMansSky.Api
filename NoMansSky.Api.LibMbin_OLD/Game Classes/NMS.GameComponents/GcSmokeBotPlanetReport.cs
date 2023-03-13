using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSmokeBotPlanetReport : NMSTemplate
{
	public UInt64 UA
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public GcSmokeBotStats PlanetStats
	{
		get => GetValue<GcSmokeBotStats>();
		set => TrySetValue<GcSmokeBotStats>(value);
	}

	public GcSmokeBotPlanetReport(long address) : base(address)
	{

	}
}
