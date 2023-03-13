using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardForgetSpecificProductRecipe : NMSTemplate
{
	public VirtualList<NMSString0x10> ProductList
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcRewardForgetSpecificProductRecipe(long address) : base(address)
	{

	}
}
