using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCostMultiItem : NMSTemplate
{
	public NMSString0x20A DisplayLocID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean OnlyTakeIfCanAfford
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcItemAmountCostPair> ItemList
	{
		get => cache.GetOrAddValue(new VirtualList<GcItemAmountCostPair>(address + GetOffset()));
		set => TrySetValue<GcItemAmountCostPair>(value);
	}

	public GcCostMultiItem(long address) : base(address)
	{

	}
}
