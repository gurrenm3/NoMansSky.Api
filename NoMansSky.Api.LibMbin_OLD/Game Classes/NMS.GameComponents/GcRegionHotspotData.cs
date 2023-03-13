using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRegionHotspotData : NMSTemplate
{
	public Single ProbabilityWeighting
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> ClassWeightings
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> ClassStrengths
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public Single DiscoveryDistanceThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcRegionHotspotData(long address) : base(address)
	{

	}
}
