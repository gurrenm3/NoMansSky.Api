using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWiki : NMSTemplate
{
	public VirtualList<GcWikiCategory> Categories
	{
		get => cache.GetOrAddValue(new VirtualList<GcWikiCategory>(address + GetOffset()));
		set => TrySetValue<GcWikiCategory>(value);
	}

	public GcWiki(long address) : base(address)
	{

	}
}
