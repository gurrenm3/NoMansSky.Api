using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBiomeList : NMSTemplate
{
	public VirtualArray<Single> BiomeProbability
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 16));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> PrimeBiomeProbability
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 16));
		set => TrySetValue<Single>(value);
	}

	public GcBiomeList(long address) : base(address)
	{

	}
}
