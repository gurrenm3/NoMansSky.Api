using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkChordsImageLookup : NMSTemplate
{
	public VirtualList<TkChordPathMapping> Lookup
	{
		get => cache.GetOrAddValue(new VirtualList<TkChordPathMapping>(address + GetOffset()));
		set => TrySetValue<TkChordPathMapping>(value);
	}

	public TkChordsImageLookup(long address) : base(address)
	{

	}
}
