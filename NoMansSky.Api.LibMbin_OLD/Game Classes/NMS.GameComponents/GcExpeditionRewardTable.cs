using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcExpeditionRewardTable : NMSTemplate
{
	public VirtualList<GcGenericRewardTableEntry> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericRewardTableEntry>(address + GetOffset()));
		set => TrySetValue<GcGenericRewardTableEntry>(value);
	}

	public GcExpeditionRewardTable(long address) : base(address)
	{

	}
}
