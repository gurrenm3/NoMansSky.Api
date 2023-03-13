using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcHUDLayerData : NMSTemplate
{
	public GcHUDComponent Data
	{
		get => GetValue<GcHUDComponent>();
		set => TrySetValue<GcHUDComponent>(value);
	}

	public VirtualList<NMSTemplate> Children
	{
		get => cache.GetOrAddValue(new VirtualList<NMSTemplate>(address + GetOffset()));
		set => TrySetValue<NMSTemplate>(value);
	}

	public GcHUDLayerData(long address) : base(address)
	{

	}
}
