using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardSpecificWeapon : NMSTemplate
{
	public GcInventoryContainer WeaponInventory
	{
		get => GetValue<GcInventoryContainer>();
		set => TrySetValue<GcInventoryContainer>(value);
	}

	public GcInventoryLayout WeaponLayout
	{
		get => GetValue<GcInventoryLayout>();
		set => TrySetValue<GcInventoryLayout>(value);
	}

	public GcExactResource WeaponResource
	{
		get => GetValue<GcExactResource>();
		set => TrySetValue<GcExactResource>(value);
	}

	public GcWeaponClasses WeaponType
	{
		get => GetValue<GcWeaponClasses>();
		set => TrySetValue<GcWeaponClasses>(value);
	}

	public NMSString0x20A NameOverride
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Boolean IsGift
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IsRewardWeapon
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean FormatAsSeasonal
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRewardSpecificWeapon(long address) : base(address)
	{

	}
}
