using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWFCBuilding : NMSTemplate
{
	public NMSString0x20 Name
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x80 ModuleSet
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public VirtualArray<NMSString0x80> Decoration
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x80>(address + GetOffset(), 2));
		set => TrySetValue<NMSString0x80>(value);
	}

	public Boolean ImprovedCoherence
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean RequireNoUnreachableRooms
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single InitialUnlockProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean DontSpawnNearPlayerBases
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean RemoveUnreachableBlocks
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<NMSString0x10> GroupsEnabled
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcModuleOverride> ModuleOverrides
	{
		get => cache.GetOrAddValue(new VirtualList<GcModuleOverride>(address + GetOffset()));
		set => TrySetValue<GcModuleOverride>(value);
	}

	public VirtualList<GcMinimumUseConstraint> MinimumUseConstraints
	{
		get => cache.GetOrAddValue(new VirtualList<GcMinimumUseConstraint>(address + GetOffset()));
		set => TrySetValue<GcMinimumUseConstraint>(value);
	}

	public VirtualList<NMSString0x10> NPCs
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcWeightedResource> Layouts
	{
		get => cache.GetOrAddValue(new VirtualList<GcWeightedResource>(address + GetOffset()));
		set => TrySetValue<GcWeightedResource>(value);
	}

	public VirtualList<GcWeightedBuildingSize> Sizes
	{
		get => cache.GetOrAddValue(new VirtualList<GcWeightedBuildingSize>(address + GetOffset()));
		set => TrySetValue<GcWeightedBuildingSize>(value);
	}

	public VirtualList<Int64> FallbackSeeds
	{
		get => cache.GetOrAddValue(new VirtualList<Int64>(address + GetOffset()));
		set => TrySetValue<Int64>(value);
	}

	public VirtualList<Int64> PresetFallbackSeeds
	{
		get => cache.GetOrAddValue(new VirtualList<Int64>(address + GetOffset()));
		set => TrySetValue<Int64>(value);
	}

	public Int32 NumberOfPresetsPerPlanet
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcBaseBuildingPartStyle ReplaceMaterials
	{
		get => GetValue<GcBaseBuildingPartStyle>();
		set => TrySetValue<GcBaseBuildingPartStyle>(value);
	}

	public VirtualList<GcFreighterBaseRoom> Rooms
	{
		get => cache.GetOrAddValue(new VirtualList<GcFreighterBaseRoom>(address + GetOffset()));
		set => TrySetValue<GcFreighterBaseRoom>(value);
	}

	public GcWFCBuilding(long address) : base(address)
	{

	}
}
