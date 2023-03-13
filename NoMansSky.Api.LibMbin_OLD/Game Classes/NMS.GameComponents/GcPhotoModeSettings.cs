using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPhotoModeSettings : NMSTemplate
{
	public Single Fog
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CloudAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector4f SunDir
	{
		get => GetValue<Vector4f>();
		set => TrySetValue<Vector4f>(value);
	}

	public Single FoV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.GameComponents.GcPhotoModeSettings.DepthOfFieldSettingEnum DepthOfFieldSetting
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPhotoModeSettings.DepthOfFieldSettingEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPhotoModeSettings.DepthOfFieldSettingEnum>(value);
	}

	public Single DepthOfFieldDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DepthOfFieldDistanceSpace
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HalfFocalPlaneDepth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HalfFocalPlaneDepthSpace
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DepthOfFieldPhysConvergence
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DepthOfFieldPhysAperture
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Vignette
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 Filter
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single Bloom
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPhotoModeSettings(long address) : base(address)
	{

	}
}
