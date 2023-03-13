using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcShipFlareComponentData : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcShipFlareComponentData.FlareTypeEnum FlareType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcShipFlareComponentData.FlareTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcShipFlareComponentData.FlareTypeEnum>(value);
	}

	public GcShipFlareComponentData(long address) : base(address)
	{

	}
}
