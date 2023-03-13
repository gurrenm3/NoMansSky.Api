using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPaletteList : NMSTemplate
{
	public VirtualArray<GcPaletteData> Palettes
	{
		get => cache.GetOrAddValue(new VirtualArray<GcPaletteData>(address + GetOffset(), 58));
		set => TrySetValue<GcPaletteData>(value);
	}

	public GcPaletteList(long address) : base(address)
	{

	}
}
