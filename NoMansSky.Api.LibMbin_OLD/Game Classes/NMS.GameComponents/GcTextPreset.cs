using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTextPreset : NMSTemplate
{
	public GcFontTypesEnum Font
	{
		get => GetValue<GcFontTypesEnum>();
		set => TrySetValue<GcFontTypesEnum>(value);
	}

	public NMSTemplate Style
	{
		get => GetValue<NMSTemplate>();
		set => TrySetValue<NMSTemplate>(value);
	}

	public Single Height
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Colour Colour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public GcTextPreset(long address) : base(address)
	{

	}
}
