using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkNoiseGridData : NMSTemplate
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

	public Boolean SwapZY
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Hemisphere
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkNoiseVoxelTypeEnum VoxelType
	{
		get => GetValue<TkNoiseVoxelTypeEnum>();
		set => TrySetValue<TkNoiseVoxelTypeEnum>(value);
	}

	public libMBIN.NMS.Toolkit.TkNoiseGridData.NoiseGridTypeEnum NoiseGridType
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkNoiseGridData.NoiseGridTypeEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkNoiseGridData.NoiseGridTypeEnum>(value);
	}

	public NMSString0x80 Filename
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public Single MinWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxWidth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinHeightOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxHeightOffset
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

	public TkNoiseUberLayerData TurbulenceNoiseLayer
	{
		get => GetValue<TkNoiseUberLayerData>();
		set => TrySetValue<TkNoiseUberLayerData>(value);
	}

	public Single Yaw
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Pitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Roll
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VaryYaw
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VaryPitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VaryRoll
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
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

	public Single RandomPrimitive
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkNoiseSuperFormulaData SuperFormula1
	{
		get => GetValue<TkNoiseSuperFormulaData>();
		set => TrySetValue<TkNoiseSuperFormulaData>(value);
	}

	public TkNoiseSuperFormulaData SuperFormula2
	{
		get => GetValue<TkNoiseSuperFormulaData>();
		set => TrySetValue<TkNoiseSuperFormulaData>(value);
	}

	public TkNoiseSuperPrimitiveData SuperPrimitive
	{
		get => GetValue<TkNoiseSuperPrimitiveData>();
		set => TrySetValue<TkNoiseSuperPrimitiveData>(value);
	}

	public Single TileBlendMeters
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public TkNoiseGridData(long address) : base(address)
	{

	}
}
