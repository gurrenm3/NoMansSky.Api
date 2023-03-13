using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcScanEventTable : NMSTemplate
{
	public VirtualList<GcScanEventData> Events
	{
		get => cache.GetOrAddValue(new VirtualList<GcScanEventData>(address + GetOffset()));
		set => TrySetValue<GcScanEventData>(value);
	}

	public GcScanEventTable(long address) : base(address)
	{

	}
}
