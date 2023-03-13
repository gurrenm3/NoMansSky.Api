using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSubstanceTable : NMSTemplate
{
	public VirtualList<GcRealitySubstanceData> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcRealitySubstanceData>(address + GetOffset()));
		set => TrySetValue<GcRealitySubstanceData>(value);
	}

	public VirtualList<GcRealityCraftingRecipeData> Crafting
	{
		get => cache.GetOrAddValue(new VirtualList<GcRealityCraftingRecipeData>(address + GetOffset()));
		set => TrySetValue<GcRealityCraftingRecipeData>(value);
	}

	public GcSubstanceTable(long address) : base(address)
	{

	}
}
