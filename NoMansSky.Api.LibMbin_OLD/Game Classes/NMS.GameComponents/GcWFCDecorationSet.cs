using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWFCDecorationSet : NMSTemplate
{
	public VirtualList<GcWFCDecorationItem> Items
	{
		get => cache.GetOrAddValue(new VirtualList<GcWFCDecorationItem>(address + GetOffset()));
		set => TrySetValue<GcWFCDecorationItem>(value);
	}

	public GcWFCDecorationSet(long address) : base(address)
	{

	}
}
