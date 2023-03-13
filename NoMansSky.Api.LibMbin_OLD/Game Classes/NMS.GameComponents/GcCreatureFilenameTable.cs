using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureFilenameTable : NMSTemplate
{
	public VirtualList<GcCreatureFilename> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureFilename>(address + GetOffset()));
		set => TrySetValue<GcCreatureFilename>(value);
	}

	public GcCreatureFilenameTable(long address) : base(address)
	{

	}
}
