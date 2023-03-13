using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardSpecificProductRecipeFromList : NMSTemplate
{
	public VirtualList<NMSString0x10> ProductList
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public libMBIN.NMS.GameComponents.GcRewardSpecificProductRecipeFromList.ProductListRewardOrderEnum ProductListRewardOrder
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcRewardSpecificProductRecipeFromList.ProductListRewardOrderEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcRewardSpecificProductRecipeFromList.ProductListRewardOrderEnum>(value);
	}

	public GcRewardSpecificProductRecipeFromList(long address) : base(address)
	{

	}
}
