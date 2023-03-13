using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkSceneBoneRemappingTable : NMSTemplate
{
	public VirtualList<TkSceneBoneRemapping> BoneMappings
	{
		get => cache.GetOrAddValue(new VirtualList<TkSceneBoneRemapping>(address + GetOffset()));
		set => TrySetValue<TkSceneBoneRemapping>(value);
	}

	public TkSceneBoneRemappingTable(long address) : base(address)
	{

	}
}
