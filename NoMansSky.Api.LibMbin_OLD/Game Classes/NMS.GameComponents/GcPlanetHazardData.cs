using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlanetHazardData : NMSTemplate
{
	public VirtualArray<Single> Temperature
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 5));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> Toxicity
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 5));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> Radiation
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 5));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> LifeSupportDrain
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 5));
		set => TrySetValue<Single>(value);
	}

	public GcPlanetHazardData(long address) : base(address)
	{

	}
}
