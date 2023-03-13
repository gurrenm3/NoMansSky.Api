using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlanetTerrainColour : NMSTemplate
{
	public TkPaletteTexture Palette
	{
		get => GetValue<TkPaletteTexture>();
		set => TrySetValue<TkPaletteTexture>(value);
	}

	public Int32 Index
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcPlanetTerrainColour(long address) : base(address)
	{

	}
}
