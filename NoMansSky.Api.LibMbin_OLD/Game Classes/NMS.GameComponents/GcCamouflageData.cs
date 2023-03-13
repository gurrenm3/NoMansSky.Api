using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCamouflageData : NMSTemplate
{
	public TkMaterialResource CamouflageMaterial
	{
		get => GetValue<TkMaterialResource>();
		set => TrySetValue<TkMaterialResource>(value);
	}

	public Single DissolveTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DissolveTimeVR
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FadeOutTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FadeInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LowQualityFresnelModifier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LowQualityBrightnessMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCamouflageData(long address) : base(address)
	{

	}
}
