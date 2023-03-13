using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcEcosystemSpawnData : NMSTemplate
{
	public VirtualList<GcEcosystemCreatureData> Creatures
	{
		get => cache.GetOrAddValue(new VirtualList<GcEcosystemCreatureData>(address + GetOffset()));
		set => TrySetValue<GcEcosystemCreatureData>(value);
	}

	public Single CreatureMinNoise
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CreatureMaxNoise
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcEcosystemSpawnData(long address) : base(address)
	{

	}
}
