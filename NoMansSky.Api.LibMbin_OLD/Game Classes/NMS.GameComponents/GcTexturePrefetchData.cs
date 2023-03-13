using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTexturePrefetchData : NMSTemplate
{
	public VirtualList<NMSString0x80> Textures
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x80>(address + GetOffset()));
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcTexturePrefetchData(long address) : base(address)
	{

	}
}
