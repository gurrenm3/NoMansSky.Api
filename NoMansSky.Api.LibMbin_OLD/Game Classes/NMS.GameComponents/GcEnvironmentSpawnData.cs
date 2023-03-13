using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcEnvironmentSpawnData : NMSTemplate
{
	public VirtualList<GcCreatureSpawnData> Creatures
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureSpawnData>(address + GetOffset()));
		set => TrySetValue<GcCreatureSpawnData>(value);
	}

	public VirtualList<GcObjectSpawnData> DistantObjects
	{
		get => cache.GetOrAddValue(new VirtualList<GcObjectSpawnData>(address + GetOffset()));
		set => TrySetValue<GcObjectSpawnData>(value);
	}

	public VirtualList<GcObjectSpawnData> Landmarks
	{
		get => cache.GetOrAddValue(new VirtualList<GcObjectSpawnData>(address + GetOffset()));
		set => TrySetValue<GcObjectSpawnData>(value);
	}

	public VirtualList<GcObjectSpawnData> Objects
	{
		get => cache.GetOrAddValue(new VirtualList<GcObjectSpawnData>(address + GetOffset()));
		set => TrySetValue<GcObjectSpawnData>(value);
	}

	public VirtualList<GcObjectSpawnData> DetailObjects
	{
		get => cache.GetOrAddValue(new VirtualList<GcObjectSpawnData>(address + GetOffset()));
		set => TrySetValue<GcObjectSpawnData>(value);
	}

	public VirtualList<GcSelectableObjectSpawnList> SelectableObjects
	{
		get => cache.GetOrAddValue(new VirtualList<GcSelectableObjectSpawnList>(address + GetOffset()));
		set => TrySetValue<GcSelectableObjectSpawnList>(value);
	}

	public GcEnvironmentSpawnData(long address) : base(address)
	{

	}
}
