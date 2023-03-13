using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkLocalisationTable : NMSTemplate
{
	public VirtualList<TkLocalisationEntry> Table
	{
		get => cache.GetOrAddValue(new VirtualList<TkLocalisationEntry>(address + GetOffset()));
		set => TrySetValue<TkLocalisationEntry>(value);
	}

	public TkLocalisationTable(long address) : base(address)
	{

	}
}
