using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcJourneyMilestoneData : NMSTemplate
{
	public NMSString0x10 JourneyMilestoneId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 PointsToUnlock
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x20A JourneyMilestoneTitle
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A JourneyMilestoneTitleLower
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcJourneyMilestoneData(long address) : base(address)
	{

	}
}
