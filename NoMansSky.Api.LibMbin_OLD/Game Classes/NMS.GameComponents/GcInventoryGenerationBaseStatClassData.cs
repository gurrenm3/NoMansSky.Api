using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInventoryGenerationBaseStatClassData : NMSTemplate
{
	public VirtualList<GcInventoryGenerationBaseStatDataEntry> BaseStats
	{
		get => cache.GetOrAddValue(new VirtualList<GcInventoryGenerationBaseStatDataEntry>(address + GetOffset()));
		set => TrySetValue<GcInventoryGenerationBaseStatDataEntry>(value);
	}

	public GcInventoryGenerationBaseStatClassData(long address) : base(address)
	{

	}
}
