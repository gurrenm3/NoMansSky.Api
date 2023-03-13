using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSeasonalRingArray : NMSTemplate
{
	public VirtualList<GcSeasonalRingData> SeasonalRingData
	{
		get => cache.GetOrAddValue(new VirtualList<GcSeasonalRingData>(address + GetOffset()));
		set => TrySetValue<GcSeasonalRingData>(value);
	}

	public GcSeasonalRingArray(long address) : base(address)
	{

	}
}
