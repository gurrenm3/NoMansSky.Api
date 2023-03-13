using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMarkerComponentData : NMSTemplate
{
	public GcGenericIconTypes Icon
	{
		get => GetValue<GcGenericIconTypes>();
		set => TrySetValue<GcGenericIconTypes>(value);
	}

	public Single Radius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.GameComponents.GcMarkerComponentData.DisplayModeEnum DisplayMode
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMarkerComponentData.DisplayModeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMarkerComponentData.DisplayModeEnum>(value);
	}

	public Boolean ShipScannable
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x20A CustomName
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean UseCustomIcon
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRealityGameIcons CustomIcon
	{
		get => GetValue<GcRealityGameIcons>();
		set => TrySetValue<GcRealityGameIcons>(value);
	}

	public GcMarkerComponentData(long address) : base(address)
	{

	}
}
