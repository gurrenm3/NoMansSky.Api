using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureGenerationWeightedList : NMSTemplate
{
	public VirtualList<GcCreatureGenerationWeightedListDomainEntry> Ground
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureGenerationWeightedListDomainEntry>(address + GetOffset()));
		set => TrySetValue<GcCreatureGenerationWeightedListDomainEntry>(value);
	}

	public VirtualList<GcCreatureGenerationWeightedListDomainEntry> Air
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureGenerationWeightedListDomainEntry>(address + GetOffset()));
		set => TrySetValue<GcCreatureGenerationWeightedListDomainEntry>(value);
	}

	public VirtualList<GcCreatureGenerationWeightedListDomainEntry> Cave
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureGenerationWeightedListDomainEntry>(address + GetOffset()));
		set => TrySetValue<GcCreatureGenerationWeightedListDomainEntry>(value);
	}

	public VirtualList<GcCreatureGenerationWeightedListDomainEntry> Water
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureGenerationWeightedListDomainEntry>(address + GetOffset()));
		set => TrySetValue<GcCreatureGenerationWeightedListDomainEntry>(value);
	}

	public GcCreatureGenerationWeightedList(long address) : base(address)
	{

	}
}
