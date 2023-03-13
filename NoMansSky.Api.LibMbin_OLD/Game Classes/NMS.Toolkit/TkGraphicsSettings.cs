using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkGraphicsSettings : NMSTemplate
{
	public Int32 Version
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean FullScreen
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Borderless
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 Monitor
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<NMSString0x100> MonitorNames
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x100>(address + GetOffset()));
		set => TrySetValue<NMSString0x100>(value);
	}

	public Int32 ResolutionWidth
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 ResolutionHeight
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single ResolutionScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.Toolkit.TkGraphicsSettings.VsyncExEnum VsyncEx
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkGraphicsSettings.VsyncExEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkGraphicsSettings.VsyncExEnum>(value);
	}

	public TkGraphicsDetailPreset GraphicsDetail
	{
		get => GetValue<TkGraphicsDetailPreset>();
		set => TrySetValue<TkGraphicsDetailPreset>(value);
	}

	public Single MotionBlurStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean VignetteAndScanlines
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single FoVOnFoot
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FoVInShip
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 Brightness
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxframeRate
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 NumHighThreads
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 NumLowThreads
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public libMBIN.NMS.Toolkit.TkGraphicsSettings.TextureStreamingVkEnum TextureStreamingVk
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkGraphicsSettings.TextureStreamingVkEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkGraphicsSettings.TextureStreamingVkEnum>(value);
	}

	public Boolean ShowRequirementsWarnings
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean RemoveBaseBuildingRestrictions
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single MouseClickSpeedMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean UseTerrainTextureCache
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UseArbSparseTexture
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.Toolkit.TkGraphicsSettings.HDRModeEnum HDRMode
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkGraphicsSettings.HDRModeEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkGraphicsSettings.HDRModeEnum>(value);
	}

	public NMSString0x100 AdapterName
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public Int32 AdapterIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 NumGraphicsThreadsBeta
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkGraphicsSettings(long address) : base(address)
	{

	}
}
