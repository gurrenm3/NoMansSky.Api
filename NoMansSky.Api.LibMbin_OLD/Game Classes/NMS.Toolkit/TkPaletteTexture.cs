using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkPaletteTexture : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkPaletteTexture.PaletteEnum Palette
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkPaletteTexture.PaletteEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkPaletteTexture.PaletteEnum>(value);
	}

	public libMBIN.NMS.Toolkit.TkPaletteTexture.ColourAltEnum ColourAlt
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkPaletteTexture.ColourAltEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkPaletteTexture.ColourAltEnum>(value);
	}

	public TkPaletteTexture(long address) : base(address)
	{

	}
}
