using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRecipeTable : NMSTemplate
{
	public VirtualList<GcRefinerRecipe> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcRefinerRecipe>(address + GetOffset()));
		set => TrySetValue<GcRefinerRecipe>(value);
	}

	public GcRecipeTable(long address) : base(address)
	{

	}
}
