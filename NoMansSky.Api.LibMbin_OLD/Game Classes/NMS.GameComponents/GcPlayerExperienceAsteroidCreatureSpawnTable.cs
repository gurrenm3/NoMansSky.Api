using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerExperienceAsteroidCreatureSpawnTable : NMSTemplate
{
	public Single SmallAsteroidSpawnPercent
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcPlayerExperienceAsteroidCreatureSpawnData> SmallAsteroidSpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcPlayerExperienceAsteroidCreatureSpawnData>(address + GetOffset()));
		set => TrySetValue<GcPlayerExperienceAsteroidCreatureSpawnData>(value);
	}

	public Single MediumAsteroidSpawnPercent
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcPlayerExperienceAsteroidCreatureSpawnData> MediumAsteroidSpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcPlayerExperienceAsteroidCreatureSpawnData>(address + GetOffset()));
		set => TrySetValue<GcPlayerExperienceAsteroidCreatureSpawnData>(value);
	}

	public Single LargeAsteroidSpawnPercent
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcPlayerExperienceAsteroidCreatureSpawnData> LargeAsteroidSpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcPlayerExperienceAsteroidCreatureSpawnData>(address + GetOffset()));
		set => TrySetValue<GcPlayerExperienceAsteroidCreatureSpawnData>(value);
	}

	public GcPlayerExperienceAsteroidCreatureSpawnTable(long address) : base(address)
	{

	}
}
