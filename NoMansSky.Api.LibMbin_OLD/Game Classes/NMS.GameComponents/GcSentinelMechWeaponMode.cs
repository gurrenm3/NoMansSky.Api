using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSentinelMechWeaponMode : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcSentinelMechWeaponMode.SentinelMechWeaponModeEnum SentinelMechWeaponMode
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcSentinelMechWeaponMode.SentinelMechWeaponModeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcSentinelMechWeaponMode.SentinelMechWeaponModeEnum>(value);
	}

	public GcSentinelMechWeaponMode(long address) : base(address)
	{

	}
}
