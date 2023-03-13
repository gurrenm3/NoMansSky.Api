using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSmokeBotSystemReport : NMSTemplate
{
	public UInt64 UA
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public GcSmokeBotStats SystemStats
	{
		get => GetValue<GcSmokeBotStats>();
		set => TrySetValue<GcSmokeBotStats>(value);
	}

	public GcSmokeBotStats SpaceStats
	{
		get => GetValue<GcSmokeBotStats>();
		set => TrySetValue<GcSmokeBotStats>(value);
	}

	public VirtualList<GcSmokeBotPlanetReport> PlanetReports
	{
		get => cache.GetOrAddValue(new VirtualList<GcSmokeBotPlanetReport>(address + GetOffset()));
		set => TrySetValue<GcSmokeBotPlanetReport>(value);
	}

	public GcSmokeBotSystemReport(long address) : base(address)
	{

	}
}
