using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseBuildingPartsNavDataTable : NMSTemplate
{
	public VirtualList<GcBaseBuildingPartNavData> Parts
	{
		get => cache.GetOrAddValue(new VirtualList<GcBaseBuildingPartNavData>(address + GetOffset()));
		set => TrySetValue<GcBaseBuildingPartNavData>(value);
	}

	public GcBaseBuildingPartsNavDataTable(long address) : base(address)
	{

	}
}
