using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseBuildingCostsTable : NMSTemplate
{
	public VirtualList<GcBaseBuildingEntryCosts> ObjectCosts
	{
		get => cache.GetOrAddValue(new VirtualList<GcBaseBuildingEntryCosts>(address + GetOffset()));
		set => TrySetValue<GcBaseBuildingEntryCosts>(value);
	}

	public GcBaseBuildingCostsTable(long address) : base(address)
	{

	}
}
