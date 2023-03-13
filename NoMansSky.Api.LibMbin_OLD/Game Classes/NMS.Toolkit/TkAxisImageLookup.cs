using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkAxisImageLookup : NMSTemplate
{
	public VirtualList<TkAxisPathMapping> Lookup
	{
		get => cache.GetOrAddValue(new VirtualList<TkAxisPathMapping>(address + GetOffset()));
		set => TrySetValue<TkAxisPathMapping>(value);
	}

	public TkAxisImageLookup(long address) : base(address)
	{

	}
}
