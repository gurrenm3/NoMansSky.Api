using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWaterColourSettingList : NMSTemplate
{
	public VirtualList<GcPlanetWaterColourData> Settings
	{
		get => cache.GetOrAddValue(new VirtualList<GcPlanetWaterColourData>(address + GetOffset()));
		set => TrySetValue<GcPlanetWaterColourData>(value);
	}

	public GcWaterColourSettingList(long address) : base(address)
	{

	}
}
