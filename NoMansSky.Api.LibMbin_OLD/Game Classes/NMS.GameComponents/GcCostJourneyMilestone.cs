using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCostJourneyMilestone : NMSTemplate
{
	public NMSString0x10 RequiredMilestone
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcCostJourneyMilestone(long address) : base(address)
	{

	}
}
