using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCustomisationColourPalettes : NMSTemplate
{
	public VirtualArray<GcPaletteData> ColourPalettes
	{
		get => cache.GetOrAddValue(new VirtualArray<GcPaletteData>(address + GetOffset(), 20));
		set => TrySetValue<GcPaletteData>(value);
	}

	public VirtualArray<GcCustomisationColourPaletteExtraData> ExtraData
	{
		get => cache.GetOrAddValue(new VirtualArray<GcCustomisationColourPaletteExtraData>(address + GetOffset(), 20));
		set => TrySetValue<GcCustomisationColourPaletteExtraData>(value);
	}

	public GcCustomisationColourPalettes(long address) : base(address)
	{

	}
}
