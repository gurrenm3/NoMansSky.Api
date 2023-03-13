using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkLODSettingsData : NMSTemplate
{
	public VirtualArray<Single> LODAdjust
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 5));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Int32> ImposterOverrideRange
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 6));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Int32> MaxObjectDistanceOverride
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 6));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Int32> RegionLODHiddenRanges
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 6));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Int32> RegionLODRadius
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 6));
		set => TrySetValue<Int32>(value);
	}

	public Boolean EnableOctahedralImposters
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ViewImpostersFromSpace
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 NumberOfImposterViews
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ImposterResolutionMultiplier
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 AsteroidCountMultiplier
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 AsteroidDividerMultiplier
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single AsteroidFadeRangeMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MaxAsteroidGenerationPerFrame
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxAsteroidGenerationPerFramePulseJump
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkLODSettingsData(long address) : base(address)
	{

	}
}
