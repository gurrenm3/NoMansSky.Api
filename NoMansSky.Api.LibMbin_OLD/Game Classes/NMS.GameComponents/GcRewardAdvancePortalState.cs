using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardAdvancePortalState : NMSTemplate
{
	public NMSString0x20A PortalScanEvent
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcRewardAdvancePortalState(long address) : base(address)
	{

	}
}
