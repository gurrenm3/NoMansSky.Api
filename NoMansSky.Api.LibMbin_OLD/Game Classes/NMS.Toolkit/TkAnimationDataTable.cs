using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkAnimationDataTable : NMSTemplate
{
	public VirtualList<TkAnimationData> Table
	{
		get => cache.GetOrAddValue(new VirtualList<TkAnimationData>(address + GetOffset()));
		set => TrySetValue<TkAnimationData>(value);
	}

	public TkAnimationDataTable(long address) : base(address)
	{

	}
}
