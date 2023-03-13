using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSettlementPerksTable : NMSTemplate
{
	public VirtualList<GcSettlementPerkData> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcSettlementPerkData>(address + GetOffset()));
		set => TrySetValue<GcSettlementPerkData>(value);
	}

	public GcSettlementPerksTable(long address) : base(address)
	{

	}
}
