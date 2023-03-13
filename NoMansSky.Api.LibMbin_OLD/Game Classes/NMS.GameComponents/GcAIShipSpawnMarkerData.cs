using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAIShipSpawnMarkerData : NMSTemplate
{
	public TkTextureResource MarkerIcon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public NMSString0x20A MarkerLabel
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean HideDuringCombat
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single MinVisibleRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxVisibleRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinAngleVisible
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public libMBIN.NMS.GameComponents.GcAIShipSpawnMarkerData.ShipsToMarkEnum ShipsToMark
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcAIShipSpawnMarkerData.ShipsToMarkEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcAIShipSpawnMarkerData.ShipsToMarkEnum>(value);
	}

	public GcAIShipSpawnMarkerData(long address) : base(address)
	{

	}
}
