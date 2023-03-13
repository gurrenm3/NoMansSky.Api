using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRealityIconTable : NMSTemplate
{
	public VirtualArray<TkTextureResource> HazardIcons
	{
		get => cache.GetOrAddValue(new VirtualArray<TkTextureResource>(address + GetOffset(), 6));
		set => TrySetValue<TkTextureResource>(value);
	}

	public VirtualArray<TkTextureResource> HazardIconsHUD
	{
		get => cache.GetOrAddValue(new VirtualArray<TkTextureResource>(address + GetOffset(), 6));
		set => TrySetValue<TkTextureResource>(value);
	}

	public VirtualArray<TkTextureResource> SubstanceCategoryIcons
	{
		get => cache.GetOrAddValue(new VirtualArray<TkTextureResource>(address + GetOffset(), 9));
		set => TrySetValue<TkTextureResource>(value);
	}

	public VirtualArray<TkTextureResource> ProductCategoryIcons
	{
		get => cache.GetOrAddValue(new VirtualArray<TkTextureResource>(address + GetOffset(), 9));
		set => TrySetValue<TkTextureResource>(value);
	}

	public VirtualArray<TkTextureResource> MissionFactionIcons
	{
		get => cache.GetOrAddValue(new VirtualArray<TkTextureResource>(address + GetOffset(), 9));
		set => TrySetValue<TkTextureResource>(value);
	}

	public VirtualArray<TkTextureResource> BinocularDiscoveryIcons
	{
		get => cache.GetOrAddValue(new VirtualArray<TkTextureResource>(address + GetOffset(), 17));
		set => TrySetValue<TkTextureResource>(value);
	}

	public VirtualArray<TkTextureResource> DiscoveryPageTradingIcons
	{
		get => cache.GetOrAddValue(new VirtualArray<TkTextureResource>(address + GetOffset(), 7));
		set => TrySetValue<TkTextureResource>(value);
	}

	public VirtualArray<TkTextureResource> DiscoveryPageConflictIcons
	{
		get => cache.GetOrAddValue(new VirtualArray<TkTextureResource>(address + GetOffset(), 4));
		set => TrySetValue<TkTextureResource>(value);
	}

	public VirtualArray<TkTextureResource> DiscoveryPageRaceIcons
	{
		get => cache.GetOrAddValue(new VirtualArray<TkTextureResource>(address + GetOffset(), 8));
		set => TrySetValue<TkTextureResource>(value);
	}

	public TkTextureResource DiscoveryPageTradingUnknown
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public TkTextureResource DiscoveryPageConflictUnknown
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public TkTextureResource DiscoveryPageRaceUnknown
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public VirtualList<GcPlanetResourceIconLookup> TerrainIconLookups
	{
		get => cache.GetOrAddValue(new VirtualList<GcPlanetResourceIconLookup>(address + GetOffset()));
		set => TrySetValue<GcPlanetResourceIconLookup>(value);
	}

	public VirtualList<GcPlanetResourceIconLookup> PlanetResourceIconLookups
	{
		get => cache.GetOrAddValue(new VirtualList<GcPlanetResourceIconLookup>(address + GetOffset()));
		set => TrySetValue<GcPlanetResourceIconLookup>(value);
	}

	public VirtualList<TkTextureResource> RepairTechIcons
	{
		get => cache.GetOrAddValue(new VirtualList<TkTextureResource>(address + GetOffset()));
		set => TrySetValue<TkTextureResource>(value);
	}

	public VirtualArray<TkTextureResource> GameIcons
	{
		get => cache.GetOrAddValue(new VirtualArray<TkTextureResource>(address + GetOffset(), 86));
		set => TrySetValue<TkTextureResource>(value);
	}

	public VirtualList<GcRealityIcon> MissionDetailIcons
	{
		get => cache.GetOrAddValue(new VirtualList<GcRealityIcon>(address + GetOffset()));
		set => TrySetValue<GcRealityIcon>(value);
	}

	public VirtualArray<TkTextureResource> DifficultyPresetIcons
	{
		get => cache.GetOrAddValue(new VirtualArray<TkTextureResource>(address + GetOffset(), 7));
		set => TrySetValue<TkTextureResource>(value);
	}

	public VirtualArray<TkTextureResource> DifficultyUIOptionIcons
	{
		get => cache.GetOrAddValue(new VirtualArray<TkTextureResource>(address + GetOffset(), 4));
		set => TrySetValue<TkTextureResource>(value);
	}

	public VirtualArray<TkTextureResource> InventoryFilterIcons
	{
		get => cache.GetOrAddValue(new VirtualArray<TkTextureResource>(address + GetOffset(), 5));
		set => TrySetValue<TkTextureResource>(value);
	}

	public GcRealityIconTable(long address) : base(address)
	{

	}
}
