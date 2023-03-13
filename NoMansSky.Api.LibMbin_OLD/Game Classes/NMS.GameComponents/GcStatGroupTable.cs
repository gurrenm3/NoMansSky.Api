using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStatGroupTable : NMSTemplate
{
	public VirtualList<GcStatGroupData> StatGroupTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcStatGroupData>(address + GetOffset()));
		set => TrySetValue<GcStatGroupData>(value);
	}

	public GcStatGroupTable(long address) : base(address)
	{

	}
}
