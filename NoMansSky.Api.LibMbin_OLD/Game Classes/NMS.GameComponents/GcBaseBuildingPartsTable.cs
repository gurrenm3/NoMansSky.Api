using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseBuildingPartsTable : NMSTemplate
{
	public VirtualList<GcBaseBuildingPart> Parts
	{
		get => cache.GetOrAddValue(new VirtualList<GcBaseBuildingPart>(address + GetOffset()));
		set => TrySetValue<GcBaseBuildingPart>(value);
	}

	public GcBaseBuildingPartsTable(long address) : base(address)
	{

	}
}
