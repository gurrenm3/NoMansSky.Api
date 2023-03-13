using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseBuildingPartsDataTable : NMSTemplate
{
	public VirtualList<GcBaseBuildingPartData> PartsData
	{
		get => cache.GetOrAddValue(new VirtualList<GcBaseBuildingPartData>(address + GetOffset()));
		set => TrySetValue<GcBaseBuildingPartData>(value);
	}

	public GcBaseBuildingPartsDataTable(long address) : base(address)
	{

	}
}
