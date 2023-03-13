using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerTitleData : NMSTemplate
{
	public VirtualList<GcPlayerTitle> Titles
	{
		get => cache.GetOrAddValue(new VirtualList<GcPlayerTitle>(address + GetOffset()));
		set => TrySetValue<GcPlayerTitle>(value);
	}

	public GcPlayerTitleData(long address) : base(address)
	{

	}
}
