using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkFoliageData : NMSTemplate
{
	public NMSString0x80 Material
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Single Scale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Density
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DensityVariance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AngleMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean AngleExponentially
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Colour Colour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public TkFoliageData(long address) : base(address)
	{

	}
}
