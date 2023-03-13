using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardFreighterSlot : NMSTemplate
{
	public NMSString0x10 Cost
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcRewardFreighterSlot(long address) : base(address)
	{

	}
}
