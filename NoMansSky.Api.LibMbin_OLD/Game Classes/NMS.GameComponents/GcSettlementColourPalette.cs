using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSettlementColourPalette : NMSTemplate
{
	public NMSString0x10 Name
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single RelativeProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcBaseBuildingPartStyle LimitToStyle
	{
		get => GetValue<GcBaseBuildingPartStyle>();
		set => TrySetValue<GcBaseBuildingPartStyle>(value);
	}

	public VirtualList<GcWeightedColourId> DefaultPalettes
	{
		get => cache.GetOrAddValue(new VirtualList<GcWeightedColourId>(address + GetOffset()));
		set => TrySetValue<GcWeightedColourId>(value);
	}

	public VirtualList<GcBuildingColourPalette> BuildingPalettes
	{
		get => cache.GetOrAddValue(new VirtualList<GcBuildingColourPalette>(address + GetOffset()));
		set => TrySetValue<GcBuildingColourPalette>(value);
	}

	public GcSettlementColourPalette(long address) : base(address)
	{

	}
}
