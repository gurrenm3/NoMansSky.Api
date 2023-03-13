using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerWeaponClass : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcPlayerWeaponClass.WeaponClassEnum WeaponClass
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPlayerWeaponClass.WeaponClassEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPlayerWeaponClass.WeaponClassEnum>(value);
	}

	public GcPlayerWeaponClass(long address) : base(address)
	{

	}
}
