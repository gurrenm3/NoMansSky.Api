using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRegionHotspotsTable : NMSTemplate
{
	public Single RegionHotspotsPoleSpacing
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RegionHotspotsPerPoleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RegionHotspotsPerPoleMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RegionHotspotsMinSameCategorySpacing
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RegionHotspotsMaxDifferentCategoryOverlap
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<GcRegionHotspotData> RegionHotspots
	{
		get => cache.GetOrAddValue(new VirtualArray<GcRegionHotspotData>(address + GetOffset(), 6));
		set => TrySetValue<GcRegionHotspotData>(value);
	}

	public VirtualArray<GcRegionHotspotBiomeGases> RegionHotspotBiomeGases
	{
		get => cache.GetOrAddValue(new VirtualArray<GcRegionHotspotBiomeGases>(address + GetOffset(), 16));
		set => TrySetValue<GcRegionHotspotBiomeGases>(value);
	}

	public VirtualList<GcRegionHotspotSubstance> RegionHotspotSubstances
	{
		get => cache.GetOrAddValue(new VirtualList<GcRegionHotspotSubstance>(address + GetOffset()));
		set => TrySetValue<GcRegionHotspotSubstance>(value);
	}

	public GcRegionHotspotsTable(long address) : base(address)
	{

	}
}
