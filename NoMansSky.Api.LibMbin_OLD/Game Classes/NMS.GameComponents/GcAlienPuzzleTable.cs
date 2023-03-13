using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAlienPuzzleTable : NMSTemplate
{
	public VirtualList<GcAlienPuzzleEntry> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcAlienPuzzleEntry>(address + GetOffset()));
		set => TrySetValue<GcAlienPuzzleEntry>(value);
	}

	public GcAlienPuzzleTable(long address) : base(address)
	{

	}
}
