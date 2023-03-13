using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcStatDefinitionTable : NMSTemplate
{
	public VirtualList<GcStatDefinition> StatDefinitionTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcStatDefinition>(address + GetOffset()));
		set => TrySetValue<GcStatDefinition>(value);
	}

	public GcStatDefinitionTable(long address) : base(address)
	{

	}
}
