using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcHeavyAirSettingValues : NMSTemplate
{
	public Single Thickness
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Speed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Alpha1
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Alpha2
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkPaletteTexture Colour1
	{
		get => GetValue<TkPaletteTexture>();
		set => TrySetValue<TkPaletteTexture>(value);
	}

	public TkPaletteTexture Colour2
	{
		get => GetValue<TkPaletteTexture>();
		set => TrySetValue<TkPaletteTexture>(value);
	}

	public GcHeavyAirSettingValues(long address) : base(address)
	{

	}
}
