using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAreaDamageDataTable : NMSTemplate
{
	public VirtualList<GcAreaDamageData> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcAreaDamageData>(address + GetOffset()));
		set => TrySetValue<GcAreaDamageData>(value);
	}

	public GcAreaDamageDataTable(long address) : base(address)
	{

	}
}
