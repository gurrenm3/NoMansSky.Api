using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTerrainControls : NMSTemplate
{
	public VirtualArray<Single> NoiseLayers
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 8));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> GridLayers
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 9));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> Features
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 7));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> Caves
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 1));
		set => TrySetValue<Single>(value);
	}

	public Single WaterActiveFrequency
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HighWaterActiveFrequency
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RockTileFrequency
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SubstanceTileFrequency
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ForceContinentalNoise
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcTerrainControls(long address) : base(address)
	{

	}
}
