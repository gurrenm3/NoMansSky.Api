using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerWeapons : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcPlayerWeapons.WeaponModeEnum WeaponMode
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPlayerWeapons.WeaponModeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPlayerWeapons.WeaponModeEnum>(value);
	}

	public GcPlayerWeapons(long address) : base(address)
	{

	}
}
