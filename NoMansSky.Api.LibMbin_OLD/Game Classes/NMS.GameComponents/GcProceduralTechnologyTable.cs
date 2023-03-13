using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcProceduralTechnologyTable : NMSTemplate
{
	public VirtualList<GcProceduralTechnologyData> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcProceduralTechnologyData>(address + GetOffset()));
		set => TrySetValue<GcProceduralTechnologyData>(value);
	}

	public GcProceduralTechnologyTable(long address) : base(address)
	{

	}
}
