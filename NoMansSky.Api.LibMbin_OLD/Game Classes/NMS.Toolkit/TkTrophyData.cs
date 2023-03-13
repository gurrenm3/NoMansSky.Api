using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkTrophyData : NMSTemplate
{
	public VirtualList<TkTrophyEntry> Trophies
	{
		get => cache.GetOrAddValue(new VirtualList<TkTrophyEntry>(address + GetOffset()));
		set => TrySetValue<TkTrophyEntry>(value);
	}

	public TkTrophyData(long address) : base(address)
	{

	}
}
