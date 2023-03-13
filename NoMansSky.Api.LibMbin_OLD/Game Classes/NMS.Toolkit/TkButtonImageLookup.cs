using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkButtonImageLookup : NMSTemplate
{
	public VirtualList<TkButtonPathMapping> Lookup
	{
		get => cache.GetOrAddValue(new VirtualList<TkButtonPathMapping>(address + GetOffset()));
		set => TrySetValue<TkButtonPathMapping>(value);
	}

	public TkButtonImageLookup(long address) : base(address)
	{

	}
}
