using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcWeaponClasses : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcWeaponClasses.WeaponStatClassEnum WeaponStatClass
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcWeaponClasses.WeaponStatClassEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcWeaponClasses.WeaponStatClassEnum>(value);
	}

	public GcWeaponClasses(long address) : base(address)
	{

	}
}
