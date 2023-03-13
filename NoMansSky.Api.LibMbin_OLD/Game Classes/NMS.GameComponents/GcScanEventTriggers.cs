using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcScanEventTriggers : NMSTemplate
{
	public Single Range
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<NMSString0x10> Triggers
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean AllowRetrigger
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcScanEventTriggers(long address) : base(address)
	{

	}
}
