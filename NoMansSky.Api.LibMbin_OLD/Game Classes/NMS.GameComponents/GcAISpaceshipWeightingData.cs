using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAISpaceshipWeightingData : NMSTemplate
{
	public VirtualArray<Single> CivilianClassWeightings
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 9));
		set => TrySetValue<Single>(value);
	}

	public GcAISpaceshipWeightingData(long address) : base(address)
	{

	}
}
