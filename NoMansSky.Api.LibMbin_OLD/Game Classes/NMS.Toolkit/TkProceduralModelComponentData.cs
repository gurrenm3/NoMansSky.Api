using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkProceduralModelComponentData : NMSTemplate
{
	public VirtualList<NMSString0x80> List
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x80>(address + GetOffset()));
		set => TrySetValue<NMSString0x80>(value);
	}

	public TkProceduralModelComponentData(long address) : base(address)
	{

	}
}
