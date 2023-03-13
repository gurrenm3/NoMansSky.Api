using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkNoiseUberData : NMSTemplate
{
	public Int32 Octaves
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single SlopeGain
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SlopeBias
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SharpToRoundFeatures
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AmplifyFeatures
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PerturbFeatures
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AltitudeErosion
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RidgeErosion
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SlopeErosion
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Lacunarity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Gain
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RemapFromMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RemapFromMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RemapToMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RemapToMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.Toolkit.TkNoiseUberData.DebugNoiseTypeEnum DebugNoiseType
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkNoiseUberData.DebugNoiseTypeEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkNoiseUberData.DebugNoiseTypeEnum>(value);
	}

	public TkNoiseUberData(long address) : base(address)
	{

	}
}
