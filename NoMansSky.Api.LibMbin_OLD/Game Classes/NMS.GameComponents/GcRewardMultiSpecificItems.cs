using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardMultiSpecificItems : NMSTemplate
{
	public Boolean Silent
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcMultiSpecificItemEntry> Items
	{
		get => cache.GetOrAddValue(new VirtualList<GcMultiSpecificItemEntry>(address + GetOffset()));
		set => TrySetValue<GcMultiSpecificItemEntry>(value);
	}

	public GcRewardMultiSpecificItems(long address) : base(address)
	{

	}
}
