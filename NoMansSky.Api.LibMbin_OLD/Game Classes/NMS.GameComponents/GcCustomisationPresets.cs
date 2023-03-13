using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCustomisationPresets : NMSTemplate
{
	public VirtualList<GcCustomisationPreset> Presets
	{
		get => cache.GetOrAddValue(new VirtualList<GcCustomisationPreset>(address + GetOffset()));
		set => TrySetValue<GcCustomisationPreset>(value);
	}

	public GcCustomisationPresets(long address) : base(address)
	{

	}
}
