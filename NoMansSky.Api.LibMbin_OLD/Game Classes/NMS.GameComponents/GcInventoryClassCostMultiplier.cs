using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInventoryClassCostMultiplier : NMSTemplate
{
	public VirtualArray<Single> Multiplier
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public GcInventoryClassCostMultiplier(long address) : base(address)
	{

	}
}
