using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardCrashSiteFly : NMSTemplate
{
	public NMSString0x20A NPCScanEvent
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcRewardCrashSiteFly(long address) : base(address)
	{

	}
}
