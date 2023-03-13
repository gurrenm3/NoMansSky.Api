using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPunctuationDelayData : NMSTemplate
{
	public VirtualList<GcPunctuationDelay> PunctuationList
	{
		get => cache.GetOrAddValue(new VirtualList<GcPunctuationDelay>(address + GetOffset()));
		set => TrySetValue<GcPunctuationDelay>(value);
	}

	public Single DefaultDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPunctuationDelayData(long address) : base(address)
	{

	}
}
