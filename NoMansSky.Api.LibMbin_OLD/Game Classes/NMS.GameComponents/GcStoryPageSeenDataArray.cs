using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStoryPageSeenDataArray : NMSTemplate
{
	public VirtualList<GcStoryPageSeenData> PagesData
	{
		get => cache.GetOrAddValue(new VirtualList<GcStoryPageSeenData>(address + GetOffset()));
		set => TrySetValue<GcStoryPageSeenData>(value);
	}

	public GcStoryPageSeenDataArray(long address) : base(address)
	{

	}
}
