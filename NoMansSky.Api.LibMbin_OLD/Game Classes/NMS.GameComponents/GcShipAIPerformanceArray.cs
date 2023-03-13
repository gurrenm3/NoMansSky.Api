using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcShipAIPerformanceArray : NMSTemplate
{
	public VirtualList<NMSTemplate> Array
	{
		get => cache.GetOrAddValue(new VirtualList<NMSTemplate>(address + GetOffset()));
		set => TrySetValue<NMSTemplate>(value);
	}

	public GcShipAIPerformanceArray(long address) : base(address)
	{

	}
}
