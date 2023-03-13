using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardTrigger : NMSTemplate
{
	public NMSString0x10 Trigger
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcRewardTrigger(long address) : base(address)
	{

	}
}
