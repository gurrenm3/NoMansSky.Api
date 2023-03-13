using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkProceduralTexture : NMSTemplate
{
	public NMSString0x20A Name
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public TkPaletteTexture Palette
	{
		get => GetValue<TkPaletteTexture>();
		set => TrySetValue<TkPaletteTexture>(value);
	}

	public Single Probability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.Toolkit.TkProceduralTexture.TextureGameplayUseEnum TextureGameplayUse
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkProceduralTexture.TextureGameplayUseEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkProceduralTexture.TextureGameplayUseEnum>(value);
	}

	public Boolean OverrideAverageColour
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Colour AverageColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public NMSString0x80 Diffuse
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 Normal
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 Mask
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public TkProceduralTexture(long address) : base(address)
	{

	}
}
