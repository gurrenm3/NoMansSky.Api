using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcZoomData : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcZoomData.ZoomTypeEnum ZoomType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcZoomData.ZoomTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcZoomData.ZoomTypeEnum>(value);
	}

	public Single EffectStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MoveSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FoV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinScanDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxScanDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcZoomData(long address) : base(address)
	{

	}
}
