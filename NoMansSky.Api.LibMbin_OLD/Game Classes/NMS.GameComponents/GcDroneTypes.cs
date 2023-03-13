using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDroneTypes : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcDroneTypes.DroneTypeEnum DroneType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcDroneTypes.DroneTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcDroneTypes.DroneTypeEnum>(value);
	}

	public GcDroneTypes(long address) : base(address)
	{

	}
}
