using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGeneratedShipCounts : NMSTemplate
{
	public VirtualArray<Int32> Counts
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 7));
		set => TrySetValue<Int32>(value);
	}

	public GcGeneratedShipCounts(long address) : base(address)
	{

	}
}
