using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkNoiseFeatureData : NMSTemplate
{
	public Boolean Active
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 MaximumLOD
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean Subtract
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Trench
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkNoiseVoxelTypeEnum VoxelType
	{
		get => GetValue<TkNoiseVoxelTypeEnum>();
		set => TrySetValue<TkNoiseVoxelTypeEnum>(value);
	}

	public libMBIN.NMS.Toolkit.TkNoiseFeatureData.FeatureTypeEnum FeatureType
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkNoiseFeatureData.FeatureTypeEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkNoiseFeatureData.FeatureTypeEnum>(value);
	}

	public Single Width
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Height
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 Octaves
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single RegionSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Ratio
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeightVarianceAmplitude
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeightVarianceFrequency
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeightOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkNoiseOffsetEnum Offset
	{
		get => GetValue<TkNoiseOffsetEnum>();
		set => TrySetValue<TkNoiseOffsetEnum>(value);
	}

	public Single SmoothRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 SeedOffset
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single TileBlendMeters
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkNoiseFeatureData(long address) : base(address)
	{

	}
}
