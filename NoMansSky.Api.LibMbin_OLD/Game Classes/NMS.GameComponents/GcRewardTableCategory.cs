using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardTableCategory : NMSTemplate
{
	public VirtualArray<GcRewardTableItemList> Sizes
	{
		get => cache.GetOrAddValue(new VirtualArray<GcRewardTableItemList>(address + GetOffset(), 3));
		set => TrySetValue<GcRewardTableItemList>(value);
	}

	public GcRewardTableCategory(long address) : base(address)
	{

	}
}
