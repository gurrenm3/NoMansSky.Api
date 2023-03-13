using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCharacterCustomisationColourData : NMSTemplate
{
	public TkPaletteTexture Palette
	{
		get => GetValue<TkPaletteTexture>();
		set => TrySetValue<TkPaletteTexture>(value);
	}

	public Colour Colour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public GcCharacterCustomisationColourData(long address) : base(address)
	{

	}
}
