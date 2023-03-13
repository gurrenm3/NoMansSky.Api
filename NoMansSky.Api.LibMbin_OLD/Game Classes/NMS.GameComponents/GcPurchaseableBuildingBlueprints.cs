using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPurchaseableBuildingBlueprints : NMSTemplate
{
	public VirtualList<GcBuildingBlueprint> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcBuildingBlueprint>(address + GetOffset()));
		set => TrySetValue<GcBuildingBlueprint>(value);
	}

	public VirtualList<Int32> GroupMaxItems
	{
		get => cache.GetOrAddValue(new VirtualList<Int32>(address + GetOffset()));
		set => TrySetValue<Int32>(value);
	}

	public GcPurchaseableBuildingBlueprints(long address) : base(address)
	{

	}
}
