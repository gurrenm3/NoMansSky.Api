using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcEntitlementRewardsTable : NMSTemplate
{
	public VirtualList<GcEntitlementRewardData> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcEntitlementRewardData>(address + GetOffset()));
		set => TrySetValue<GcEntitlementRewardData>(value);
	}

	public GcEntitlementRewardsTable(long address) : base(address)
	{

	}
}
