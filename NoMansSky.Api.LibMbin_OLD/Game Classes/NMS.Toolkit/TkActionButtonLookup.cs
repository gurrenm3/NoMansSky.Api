using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkActionButtonLookup : NMSTemplate
{
	public VirtualList<TkActionButtonMap> Lookup
	{
		get => cache.GetOrAddValue(new VirtualList<TkActionButtonMap>(address + GetOffset()));
		set => TrySetValue<TkActionButtonMap>(value);
	}

	public TkActionButtonLookup(long address) : base(address)
	{

	}
}
