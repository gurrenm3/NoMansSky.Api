using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcHeavyAirList : NMSTemplate
{
	public VirtualList<NMSString0x80> Options
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x80>(address + GetOffset()));
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcHeavyAirList(long address) : base(address)
	{

	}
}
