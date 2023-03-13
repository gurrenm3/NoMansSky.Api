using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcScanEffectData : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public libMBIN.NMS.GameComponents.GcScanEffectData.ScanEffectTypeEnum ScanEffectType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcScanEffectData.ScanEffectTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcScanEffectData.ScanEffectTypeEnum>(value);
	}

	public Colour Colour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Single BasecolourIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ScanlinesSeparation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FresnelIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GlowIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaveOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean WaveActive
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean FixedUpAxis
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Transparent
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean ModelFade
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single FadeInTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FadeOutTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcScanEffectData(long address) : base(address)
	{

	}
}
