using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCPlacementInfo : NMSTemplate
{
	public NMSString0x10 PlacementRuleId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20 SpawnUnderNodeName
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x20 PlacmentNodeName
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public Boolean MustPlace
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single SpawnChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FractionOfNodesActive
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MaxNodesActivated
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x10 SpawnSpecific
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcAlienRace Race
	{
		get => GetValue<GcAlienRace>();
		set => TrySetValue<GcAlienRace>(value);
	}

	public Boolean SpawnAnyMajorRace
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcInteractionType InteractionOverride
	{
		get => GetValue<GcInteractionType>();
		set => TrySetValue<GcInteractionType>(value);
	}

	public GcTechnologyCategory TechShopCategory
	{
		get => GetValue<GcTechnologyCategory>();
		set => TrySetValue<GcTechnologyCategory>(value);
	}

	public NMSString0x20A ForceInteraction
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualList<GcAlienPuzzleMissionOverride> PuzzleMissionOverrideTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcAlienPuzzleMissionOverride>(address + GetOffset()));
		set => TrySetValue<GcAlienPuzzleMissionOverride>(value);
	}

	public Boolean DisableInteraction
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseFreighterNPC
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean PlaceAtLeastOne
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SpawnMoving
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean SpawnInAbandoned
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<NMSString0x10> HideDuringMissions
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean OnlyUsePuzzleOverridesIfPlayerOwned
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcNPCPlacementInfo(long address) : base(address)
	{

	}
}
