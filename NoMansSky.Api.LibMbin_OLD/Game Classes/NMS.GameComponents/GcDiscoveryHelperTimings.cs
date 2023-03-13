using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDiscoveryHelperTimings : NMSTemplate
{
	public Single DiscoverPlanetTotalTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DiscoverPlanetMessageWait
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DiscoverPlanetMessageTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcDiscoveryHelperTimings(long address) : base(address)
	{

	}
}
