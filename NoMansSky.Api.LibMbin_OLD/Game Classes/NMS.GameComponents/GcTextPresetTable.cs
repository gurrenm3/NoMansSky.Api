using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTextPresetTable : NMSTemplate
{
	public VirtualList<GcTextPreset> Table
	{
		get => cache.GetOrAddValue(new VirtualList<GcTextPreset>(address + GetOffset()));
		set => TrySetValue<GcTextPreset>(value);
	}

	public GcTextPresetTable(long address) : base(address)
	{

	}
}
