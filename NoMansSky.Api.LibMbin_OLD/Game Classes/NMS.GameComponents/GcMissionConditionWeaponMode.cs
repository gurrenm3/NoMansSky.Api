using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionWeaponMode : NMSTemplate
{
	public GcPlayerWeapons WeaponMode
	{
		get => GetValue<GcPlayerWeapons>();
		set => TrySetValue<GcPlayerWeapons>(value);
	}

	public GcMissionConditionWeaponMode(long address) : base(address)
	{

	}
}
