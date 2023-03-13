using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcModSettings : NMSTemplate
{
	public VirtualList<GcModSettingsInfo> Data
	{
		get => cache.GetOrAddValue(new VirtualList<GcModSettingsInfo>(address + GetOffset()));
		set => TrySetValue<GcModSettingsInfo>(value);
	}

	public GcModSettings(long address) : base(address)
	{

	}
}
