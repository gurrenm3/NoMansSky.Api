using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSpaceSkyColourSettingList : NMSTemplate
{
	public VirtualList<GcSolarSystemSkyColourData> Settings
	{
		get => cache.GetOrAddValue(new VirtualList<GcSolarSystemSkyColourData>(address + GetOffset()));
		set => TrySetValue<GcSolarSystemSkyColourData>(value);
	}

	public GcSpaceSkyColourSettingList(long address) : base(address)
	{

	}
}
