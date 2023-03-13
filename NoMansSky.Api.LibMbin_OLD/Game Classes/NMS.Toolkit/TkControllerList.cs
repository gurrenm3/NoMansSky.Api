using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkControllerList : NMSTemplate
{
	public VirtualList<TkControllerButtonLookup> Controllers
	{
		get => cache.GetOrAddValue(new VirtualList<TkControllerButtonLookup>(address + GetOffset()));
		set => TrySetValue<TkControllerButtonLookup>(value);
	}

	public TkControllerList(long address) : base(address)
	{

	}
}
