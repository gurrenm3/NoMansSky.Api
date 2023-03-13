using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAtmosphereList : NMSTemplate
{
	public VirtualList<NMSString0x80> Atmospheres
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x80>(address + GetOffset()));
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcAtmosphereList(long address) : base(address)
	{

	}
}
