using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFiendCrimeSpawnData : NMSTemplate
{
	public GcCreatureTypes Type
	{
		get => GetValue<GcCreatureTypes>();
		set => TrySetValue<GcCreatureTypes>(value);
	}

	public Single MinDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Int32> MinNum
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 4));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Int32> MaxNum
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 4));
		set => TrySetValue<Int32>(value);
	}

	public GcFiendCrimeSpawnData(long address) : base(address)
	{

	}
}
