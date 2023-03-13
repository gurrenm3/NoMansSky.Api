using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcVehicleType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcVehicleType.VehicleTypeEnum VehicleType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcVehicleType.VehicleTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcVehicleType.VehicleTypeEnum>(value);
	}

	public GcVehicleType(long address) : base(address)
	{

	}
}
