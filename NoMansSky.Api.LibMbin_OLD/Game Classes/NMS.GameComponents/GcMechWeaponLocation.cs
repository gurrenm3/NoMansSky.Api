using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMechWeaponLocation : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMechWeaponLocation.MechWeaponLocationEnum MechWeaponLocation
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMechWeaponLocation.MechWeaponLocationEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMechWeaponLocation.MechWeaponLocationEnum>(value);
	}

	public GcMechWeaponLocation(long address) : base(address)
	{

	}
}
