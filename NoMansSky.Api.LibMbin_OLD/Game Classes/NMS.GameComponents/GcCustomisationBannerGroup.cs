using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCustomisationBannerGroup : NMSTemplate
{
	public VirtualList<GcCustomisationBannerImageData> BannerImages
	{
		get => cache.GetOrAddValue(new VirtualList<GcCustomisationBannerImageData>(address + GetOffset()));
		set => TrySetValue<GcCustomisationBannerImageData>(value);
	}

	public GcPaletteData MainColours
	{
		get => GetValue<GcPaletteData>();
		set => TrySetValue<GcPaletteData>(value);
	}

	public GcCustomisationColourPaletteExtraData MainColoursExtraData
	{
		get => GetValue<GcCustomisationColourPaletteExtraData>();
		set => TrySetValue<GcCustomisationColourPaletteExtraData>(value);
	}

	public GcPaletteData BackgroundColours
	{
		get => GetValue<GcPaletteData>();
		set => TrySetValue<GcPaletteData>(value);
	}

	public GcCustomisationColourPaletteExtraData BackgroundColoursExtraData
	{
		get => GetValue<GcCustomisationColourPaletteExtraData>();
		set => TrySetValue<GcCustomisationColourPaletteExtraData>(value);
	}

	public GcCustomisationBannerGroup(long address) : base(address)
	{

	}
}
