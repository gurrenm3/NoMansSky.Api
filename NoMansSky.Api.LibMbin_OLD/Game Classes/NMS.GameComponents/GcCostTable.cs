using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCostTable : NMSTemplate
{
	public VirtualList<GcCostTableEntry> SimpleInteractionTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcCostTableEntry>(address + GetOffset()));
		set => TrySetValue<GcCostTableEntry>(value);
	}

	public VirtualList<GcCostTableEntry> InteractionTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcCostTableEntry>(address + GetOffset()));
		set => TrySetValue<GcCostTableEntry>(value);
	}

	public VirtualList<GcCostTableEntry> ItemCostsTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcCostTableEntry>(address + GetOffset()));
		set => TrySetValue<GcCostTableEntry>(value);
	}

	public VirtualList<GcCostTableEntry> AtlasPathCosts
	{
		get => cache.GetOrAddValue(new VirtualList<GcCostTableEntry>(address + GetOffset()));
		set => TrySetValue<GcCostTableEntry>(value);
	}

	public VirtualList<GcCostTableEntry> UnusedCostsTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcCostTableEntry>(address + GetOffset()));
		set => TrySetValue<GcCostTableEntry>(value);
	}

	public GcCostTable(long address) : base(address)
	{

	}
}
