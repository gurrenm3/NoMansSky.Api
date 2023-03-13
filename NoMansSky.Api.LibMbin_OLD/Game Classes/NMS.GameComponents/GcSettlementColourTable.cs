using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSettlementColourTable : NMSTemplate
{
	public VirtualList<GcSettlementColourPalette> SettlementColourPalettes
	{
		get => cache.GetOrAddValue(new VirtualList<GcSettlementColourPalette>(address + GetOffset()));
		set => TrySetValue<GcSettlementColourPalette>(value);
	}

	public VirtualList<NMSString0x10> DecorationPartIds
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcSettlementColourTable(long address) : base(address)
	{

	}
}
