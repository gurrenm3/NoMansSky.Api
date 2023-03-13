using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFrigateClassCost : NMSTemplate
{
	public VirtualArray<Int32> Cost
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 8));
		set => TrySetValue<Int32>(value);
	}

	public GcFrigateClassCost(long address) : base(address)
	{

	}
}
