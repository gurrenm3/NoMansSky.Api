using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFiendCrimeSpawnTable : NMSTemplate
{
	public GcFiendCrime Crime
	{
		get => GetValue<GcFiendCrime>();
		set => TrySetValue<GcFiendCrime>(value);
	}

	public Single ResponseRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcFiendCrimeSpawnData> Spawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcFiendCrimeSpawnData>(address + GetOffset()));
		set => TrySetValue<GcFiendCrimeSpawnData>(value);
	}

	public GcFiendCrimeSpawnTable(long address) : base(address)
	{

	}
}
