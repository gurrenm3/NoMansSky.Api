using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkGraphicsDetailPreset : NMSTemplate
{
	public TkGraphicsDetailTypes TextureQuality
	{
		get => GetValue<TkGraphicsDetailTypes>();
		set => TrySetValue<TkGraphicsDetailTypes>(value);
	}

	public TkGraphicsDetailTypes AnimationQuality
	{
		get => GetValue<TkGraphicsDetailTypes>();
		set => TrySetValue<TkGraphicsDetailTypes>(value);
	}

	public TkGraphicsDetailTypes ShadowQuality
	{
		get => GetValue<TkGraphicsDetailTypes>();
		set => TrySetValue<TkGraphicsDetailTypes>(value);
	}

	public TkGraphicsDetailTypes PostProcessingEffects
	{
		get => GetValue<TkGraphicsDetailTypes>();
		set => TrySetValue<TkGraphicsDetailTypes>(value);
	}

	public TkGraphicsDetailTypes ReflectionsQuality
	{
		get => GetValue<TkGraphicsDetailTypes>();
		set => TrySetValue<TkGraphicsDetailTypes>(value);
	}

	public TkGraphicsDetailTypes VolumetricsQuality
	{
		get => GetValue<TkGraphicsDetailTypes>();
		set => TrySetValue<TkGraphicsDetailTypes>(value);
	}

	public TkGraphicsDetailTypes TerrainTessellation
	{
		get => GetValue<TkGraphicsDetailTypes>();
		set => TrySetValue<TkGraphicsDetailTypes>(value);
	}

	public TkGraphicsDetailTypes PlanetQuality
	{
		get => GetValue<TkGraphicsDetailTypes>();
		set => TrySetValue<TkGraphicsDetailTypes>(value);
	}

	public TkGraphicsDetailTypes BaseQuality
	{
		get => GetValue<TkGraphicsDetailTypes>();
		set => TrySetValue<TkGraphicsDetailTypes>(value);
	}

	public libMBIN.NMS.Toolkit.TkGraphicsDetailPreset.UIQualityEnum UIQuality
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkGraphicsDetailPreset.UIQualityEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkGraphicsDetailPreset.UIQualityEnum>(value);
	}

	public libMBIN.NMS.Toolkit.TkGraphicsDetailPreset.DLSSQualityEnum DLSSQuality
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkGraphicsDetailPreset.DLSSQualityEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkGraphicsDetailPreset.DLSSQualityEnum>(value);
	}

	public libMBIN.NMS.Toolkit.TkGraphicsDetailPreset.FFXSRQualityEnum FFXSRQuality
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkGraphicsDetailPreset.FFXSRQualityEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkGraphicsDetailPreset.FFXSRQualityEnum>(value);
	}

	public libMBIN.NMS.Toolkit.TkGraphicsDetailPreset.FFXSR2QualityEnum FFXSR2Quality
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkGraphicsDetailPreset.FFXSR2QualityEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkGraphicsDetailPreset.FFXSR2QualityEnum>(value);
	}

	public libMBIN.NMS.Toolkit.TkGraphicsDetailPreset.XESSQualityEnum XESSQuality
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkGraphicsDetailPreset.XESSQualityEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkGraphicsDetailPreset.XESSQualityEnum>(value);
	}

	public libMBIN.NMS.Toolkit.TkGraphicsDetailPreset.AmbientOcclusionEnum AmbientOcclusion
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkGraphicsDetailPreset.AmbientOcclusionEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkGraphicsDetailPreset.AmbientOcclusionEnum>(value);
	}

	public libMBIN.NMS.Toolkit.TkGraphicsDetailPreset.AnisotropyLevelEnum AnisotropyLevel
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkGraphicsDetailPreset.AnisotropyLevelEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkGraphicsDetailPreset.AnisotropyLevelEnum>(value);
	}

	public libMBIN.NMS.Toolkit.TkGraphicsDetailPreset.AntiAliasingEnum AntiAliasing
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkGraphicsDetailPreset.AntiAliasingEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkGraphicsDetailPreset.AntiAliasingEnum>(value);
	}

	public TkGraphicsDetailPreset(long address) : base(address)
	{

	}
}
