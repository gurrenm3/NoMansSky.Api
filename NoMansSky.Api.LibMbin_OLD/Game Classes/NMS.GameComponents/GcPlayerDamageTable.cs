using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerDamageTable : NMSTemplate
{
	public VirtualList<GcPlayerDamageData> DamageTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcPlayerDamageData>(address + GetOffset()));
		set => TrySetValue<GcPlayerDamageData>(value);
	}

	public GcPlayerDamageTable(long address) : base(address)
	{

	}
}
