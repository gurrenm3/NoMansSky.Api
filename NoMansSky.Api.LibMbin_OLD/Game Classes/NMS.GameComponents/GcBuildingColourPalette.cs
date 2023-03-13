using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBuildingColourPalette : NMSTemplate
{
	public GcBuildingClassification Building
	{
		get => GetValue<GcBuildingClassification>();
		set => TrySetValue<GcBuildingClassification>(value);
	}

	public VirtualList<GcWeightedColourId> Palettes
	{
		get => cache.GetOrAddValue(new VirtualList<GcWeightedColourId>(address + GetOffset()));
		set => TrySetValue<GcWeightedColourId>(value);
	}

	public GcBuildingColourPalette(long address) : base(address)
	{

	}
}
