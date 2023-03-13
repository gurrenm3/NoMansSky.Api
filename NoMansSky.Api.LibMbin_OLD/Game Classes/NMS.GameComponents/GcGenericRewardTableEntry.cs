using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGenericRewardTableEntry : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcRewardTableItemList List
	{
		get => GetValue<GcRewardTableItemList>();
		set => TrySetValue<GcRewardTableItemList>(value);
	}

	public GcGenericRewardTableEntry(long address) : base(address)
	{

	}
}
