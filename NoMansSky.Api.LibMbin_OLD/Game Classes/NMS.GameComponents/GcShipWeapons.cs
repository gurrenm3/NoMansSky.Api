using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcShipWeapons : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcShipWeapons.ShipWeaponEnum ShipWeapon
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcShipWeapons.ShipWeaponEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcShipWeapons.ShipWeaponEnum>(value);
	}

	public GcShipWeapons(long address) : base(address)
	{

	}
}
