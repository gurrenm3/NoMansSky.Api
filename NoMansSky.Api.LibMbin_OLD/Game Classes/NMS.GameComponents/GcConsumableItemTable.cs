using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcConsumableItemTable : NMSTemplate
{
	public VirtualList<GcConsumableItem> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcConsumableItem>(address + GetOffset()));
		set => TrySetValue<GcConsumableItem>(value);
	}

	public GcConsumableItemTable(long address) : base(address)
	{

	}
}
