using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcLegacyItemTable : NMSTemplate
{
	public VirtualList<GcLegacyItem> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcLegacyItem>(address + GetOffset()));
		set => TrySetValue<GcLegacyItem>(value);
	}

	public GcLegacyItemTable(long address) : base(address)
	{

	}
}
