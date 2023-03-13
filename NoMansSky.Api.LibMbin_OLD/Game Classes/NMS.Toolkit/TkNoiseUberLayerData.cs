using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkNoiseUberLayerData : NMSTemplate
{
	public TkNoiseUberData NoiseData
	{
		get => GetValue<TkNoiseUberData>();
		set => TrySetValue<TkNoiseUberData>(value);
	}

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

	public TkNoiseVoxelTypeEnum VoxelType
	{
		get => GetValue<TkNoiseVoxelTypeEnum>();
		set => TrySetValue<TkNoiseVoxelTypeEnum>(value);
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

	public Single RegionGain
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SmoothRadius
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

	public libMBIN.NMS.Toolkit.TkNoiseUberLayerData.WaterFadeEnum WaterFade
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkNoiseUberLayerData.WaterFadeEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkNoiseUberLayerData.WaterFadeEnum>(value);
	}

	public Single PlateauStratas
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 PlateauSharpness
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single PlateauRegionSize
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

	public TkNoiseUberLayerData(long address) : base(address)
	{

	}
}
