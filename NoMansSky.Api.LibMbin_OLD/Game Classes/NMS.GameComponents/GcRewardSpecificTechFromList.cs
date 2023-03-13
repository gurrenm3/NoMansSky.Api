using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardSpecificTechFromList : NMSTemplate
{
	public VirtualList<NMSString0x10> TechList
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean FailIfAllKnown
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.GameComponents.GcRewardSpecificTechFromList.TechListRewardOrderEnum TechListRewardOrder
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcRewardSpecificTechFromList.TechListRewardOrderEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcRewardSpecificTechFromList.TechListRewardOrderEnum>(value);
	}

	public GcRewardSpecificTechFromList(long address) : base(address)
	{

	}
}
