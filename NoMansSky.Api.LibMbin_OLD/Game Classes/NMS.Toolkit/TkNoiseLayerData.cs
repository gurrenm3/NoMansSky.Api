using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkNoiseLayerData : NMSTemplate
{
	public Boolean Active
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Invert
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Absolute
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Subtract
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.Toolkit.TkNoiseLayerData.NoiseTypeEnum NoiseType
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkNoiseLayerData.NoiseTypeEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkNoiseLayerData.NoiseTypeEnum>(value);
	}

	public Single Height
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Width
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 Octaves
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single FrequencyScaleY
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RegionRatio
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RegionScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurbulenceFrequency
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurbulenceAmplitude
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 TurbulenceOctaves
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 SeedOffset
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkNoiseLayerData(long address) : base(address)
	{

	}
}
