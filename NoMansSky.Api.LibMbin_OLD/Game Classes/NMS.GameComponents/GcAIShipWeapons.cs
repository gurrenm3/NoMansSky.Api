using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAIShipWeapons : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcAIShipWeapons.AIShipWeaponEnum AIShipWeapon
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcAIShipWeapons.AIShipWeaponEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcAIShipWeapons.AIShipWeaponEnum>(value);
	}

	public GcAIShipWeapons(long address) : base(address)
	{

	}
}
