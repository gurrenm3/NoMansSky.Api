using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPaletteData : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcPaletteData.NumColoursEnum NumColours
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPaletteData.NumColoursEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPaletteData.NumColoursEnum>(value);
	}

	public VirtualArray<Colour> Colours
	{
		get => cache.GetOrAddValue(new VirtualArray<Colour>(address + GetOffset(), 64));
		set => TrySetValue<Colour>(value);
	}

	public GcPaletteData(long address) : base(address)
	{

	}
}
