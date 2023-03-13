using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcItemShopAvailabilityDifficultyOptionData : NMSTemplate
{
	public VirtualList<NMSString0x10> NeverSoldItems
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcItemShopAvailabilityDifficultyOptionData(long address) : base(address)
	{

	}
}
