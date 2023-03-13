using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureGenerationArchetypes : NMSTemplate
{
	public VirtualList<GcCreatureGenerationDomainTable> GroundArchetypes
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureGenerationDomainTable>(address + GetOffset()));
		set => TrySetValue<GcCreatureGenerationDomainTable>(value);
	}

	public VirtualList<GcCreatureGenerationDomainTable> AirArchetypes
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureGenerationDomainTable>(address + GetOffset()));
		set => TrySetValue<GcCreatureGenerationDomainTable>(value);
	}

	public VirtualList<GcCreatureGenerationDomainTable> WaterArchetypes
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureGenerationDomainTable>(address + GetOffset()));
		set => TrySetValue<GcCreatureGenerationDomainTable>(value);
	}

	public VirtualList<GcCreatureGenerationDomainTable> CaveArchetypes
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureGenerationDomainTable>(address + GetOffset()));
		set => TrySetValue<GcCreatureGenerationDomainTable>(value);
	}

	public GcCreatureGenerationArchetypes(long address) : base(address)
	{

	}
}
