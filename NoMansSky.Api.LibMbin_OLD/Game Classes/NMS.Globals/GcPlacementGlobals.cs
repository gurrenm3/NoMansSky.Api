using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlacementGlobals : NMSTemplate
{
	public Single MinFrequency
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinDensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinPatchSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MinPatchVariance
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single MaxFrequency
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxDensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxPatchSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MaxPatchVariance
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single InterpValueVariance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HighInterpValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MidInterpValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LowInterpValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MultiplyLodDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AddToLodDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> LodDistancesDetail
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 5));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> LodDistancesObject
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 5));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> LodDistancesLandmark
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 5));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> LodDistancesDistant
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 5));
		set => TrySetValue<Single>(value);
	}

	public GcPlacementGlobals(long address) : base(address)
	{

	}
}
