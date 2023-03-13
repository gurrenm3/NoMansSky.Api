using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcJourney : NMSTemplate
{
	public VirtualList<GcJourneyCategory> Categories
	{
		get => cache.GetOrAddValue(new VirtualList<GcJourneyCategory>(address + GetOffset()));
		set => TrySetValue<GcJourneyCategory>(value);
	}

	public GcJourney(long address) : base(address)
	{

	}
}
