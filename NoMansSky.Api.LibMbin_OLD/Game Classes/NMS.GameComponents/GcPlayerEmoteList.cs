using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerEmoteList : NMSTemplate
{
	public VirtualList<GcPlayerEmote> Emotes
	{
		get => cache.GetOrAddValue(new VirtualList<GcPlayerEmote>(address + GetOffset()));
		set => TrySetValue<GcPlayerEmote>(value);
	}

	public GcPlayerEmoteList(long address) : base(address)
	{

	}
}
