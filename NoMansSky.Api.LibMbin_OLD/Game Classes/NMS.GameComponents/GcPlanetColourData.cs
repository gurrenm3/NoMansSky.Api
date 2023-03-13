using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlanetColourData : NMSTemplate
{
	public VirtualArray<GcColourPaletteData> Palettes
	{
		get => cache.GetOrAddValue(new VirtualArray<GcColourPaletteData>(address + GetOffset(), 58));
		set => TrySetValue<GcColourPaletteData>(value);
	}

	public GcPlanetColourData(long address) : base(address)
	{

	}
}
