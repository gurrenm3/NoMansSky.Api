using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseBuildingTable : NMSTemplate
{
	public TkModelResource LegModel
	{
		get => GetValue<TkModelResource>();
		set => TrySetValue<TkModelResource>(value);
	}

	public TkModelResource GhostHeart
	{
		get => GetValue<TkModelResource>();
		set => TrySetValue<TkModelResource>(value);
	}

	public TkModelResource GhostHeartSelected
	{
		get => GetValue<TkModelResource>();
		set => TrySetValue<TkModelResource>(value);
	}

	public TkMaterialResource BuildEffectMaterial
	{
		get => GetValue<TkMaterialResource>();
		set => TrySetValue<TkMaterialResource>(value);
	}

	public TkModelResource RotateScaleGizmo
	{
		get => GetValue<TkModelResource>();
		set => TrySetValue<TkModelResource>(value);
	}

	public TkModelResource WiringFirefly
	{
		get => GetValue<TkModelResource>();
		set => TrySetValue<TkModelResource>(value);
	}

	public TkModelResource WiringSnapPoint
	{
		get => GetValue<TkModelResource>();
		set => TrySetValue<TkModelResource>(value);
	}

	public TkModelResource WiringSnapSelected
	{
		get => GetValue<TkModelResource>();
		set => TrySetValue<TkModelResource>(value);
	}

	public VirtualList<GcBaseBuildingEntry> Objects
	{
		get => cache.GetOrAddValue(new VirtualList<GcBaseBuildingEntry>(address + GetOffset()));
		set => TrySetValue<GcBaseBuildingEntry>(value);
	}

	public VirtualList<GcBaseBuildingGroup> Groups
	{
		get => cache.GetOrAddValue(new VirtualList<GcBaseBuildingGroup>(address + GetOffset()));
		set => TrySetValue<GcBaseBuildingGroup>(value);
	}

	public VirtualList<GcBaseBuildingPalette> Palettes
	{
		get => cache.GetOrAddValue(new VirtualList<GcBaseBuildingPalette>(address + GetOffset()));
		set => TrySetValue<GcBaseBuildingPalette>(value);
	}

	public VirtualList<GcId256List> PaletteGroups
	{
		get => cache.GetOrAddValue(new VirtualList<GcId256List>(address + GetOffset()));
		set => TrySetValue<GcId256List>(value);
	}

	public VirtualList<GcBaseBuildingMaterial> Materials
	{
		get => cache.GetOrAddValue(new VirtualList<GcBaseBuildingMaterial>(address + GetOffset()));
		set => TrySetValue<GcBaseBuildingMaterial>(value);
	}

	public VirtualList<GcId256List> MaterialGroups
	{
		get => cache.GetOrAddValue(new VirtualList<GcId256List>(address + GetOffset()));
		set => TrySetValue<GcId256List>(value);
	}

	public GcBaseBuildingProperties Properties
	{
		get => GetValue<GcBaseBuildingProperties>();
		set => TrySetValue<GcBaseBuildingProperties>(value);
	}

	public VirtualList<GcBaseBuildingFamily> Families
	{
		get => cache.GetOrAddValue(new VirtualList<GcBaseBuildingFamily>(address + GetOffset()));
		set => TrySetValue<GcBaseBuildingFamily>(value);
	}

	public GcBaseBuildingGroup RelativesTabSetupData
	{
		get => GetValue<GcBaseBuildingGroup>();
		set => TrySetValue<GcBaseBuildingGroup>(value);
	}

	public GcBaseBuildingTable(long address) : base(address)
	{

	}
}
