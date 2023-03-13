using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardCustomPlayerControl : NMSTemplate
{
	public NMSString0x10 RequestedMode
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcRewardCustomPlayerControl(long address) : base(address)
	{

	}
}
