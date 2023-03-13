using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDiscoveryRewardLookupTable : NMSTemplate
{
	public VirtualList<GcDiscoveryRewardLookup> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcDiscoveryRewardLookup>(address + GetOffset()));
		set => TrySetValue<GcDiscoveryRewardLookup>(value);
	}

	public GcDiscoveryRewardLookupTable(long address) : base(address)
	{

	}
}
