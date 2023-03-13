using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcUnlockableTrees : NMSTemplate
{
	public VirtualArray<GcUnlockableItemTrees> Trees
	{
		get => cache.GetOrAddValue(new VirtualArray<GcUnlockableItemTrees>(address + GetOffset(), 14));
		set => TrySetValue<GcUnlockableItemTrees>(value);
	}

	public VirtualList<GcUnlockableTreeCostType> CostTypes
	{
		get => cache.GetOrAddValue(new VirtualList<GcUnlockableTreeCostType>(address + GetOffset()));
		set => TrySetValue<GcUnlockableTreeCostType>(value);
	}

	public GcUnlockableTrees(long address) : base(address)
	{

	}
}
