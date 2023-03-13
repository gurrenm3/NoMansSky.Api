using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCustomisationColourGroup : NMSTemplate
{
	public NMSString0x10 GroupID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20A Title
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public TkPaletteTexture Palette
	{
		get => GetValue<TkPaletteTexture>();
		set => TrySetValue<TkPaletteTexture>(value);
	}

	public GcCustomisationColourGroup(long address) : base(address)
	{

	}
}
