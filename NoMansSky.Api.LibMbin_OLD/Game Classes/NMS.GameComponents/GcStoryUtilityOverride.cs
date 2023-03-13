using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStoryUtilityOverride : NMSTemplate
{
	public NMSString0x20A Name
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x10 Reward
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcRewardMissionOverride> SpecificRewardOverrideTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcRewardMissionOverride>(address + GetOffset()));
		set => TrySetValue<GcRewardMissionOverride>(value);
	}

	public GcStoryUtilityOverride(long address) : base(address)
	{

	}
}
