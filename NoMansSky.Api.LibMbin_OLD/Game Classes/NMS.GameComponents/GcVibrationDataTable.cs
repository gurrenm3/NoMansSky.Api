using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcVibrationDataTable : NMSTemplate
{
	public VirtualList<GcVibrationChannelData> Data
	{
		get => cache.GetOrAddValue(new VirtualList<GcVibrationChannelData>(address + GetOffset()));
		set => TrySetValue<GcVibrationChannelData>(value);
	}

	public GcVibrationDataTable(long address) : base(address)
	{

	}
}
