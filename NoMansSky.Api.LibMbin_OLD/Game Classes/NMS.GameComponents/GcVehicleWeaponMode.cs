using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcVehicleWeaponMode : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcVehicleWeaponMode.VehicleWeaponModeEnum VehicleWeaponMode
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcVehicleWeaponMode.VehicleWeaponModeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcVehicleWeaponMode.VehicleWeaponModeEnum>(value);
	}

	public GcVehicleWeaponMode(long address) : base(address)
	{

	}
}
