using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRemoteWeapons : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcRemoteWeapons.RemoteWeaponTypeEnum RemoteWeaponType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcRemoteWeapons.RemoteWeaponTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcRemoteWeapons.RemoteWeaponTypeEnum>(value);
	}

	public GcRemoteWeapons(long address) : base(address)
	{

	}
}
