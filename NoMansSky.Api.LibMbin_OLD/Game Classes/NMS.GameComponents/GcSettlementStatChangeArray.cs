using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSettlementStatChangeArray : NMSTemplate
{
	public VirtualList<GcSettlementStatChange> Stats
	{
		get => cache.GetOrAddValue(new VirtualList<GcSettlementStatChange>(address + GetOffset()));
		set => TrySetValue<GcSettlementStatChange>(value);
	}

	public GcSettlementStatChangeArray(long address) : base(address)
	{

	}
}
