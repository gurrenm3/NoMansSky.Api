using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcExoMechWeaponData : NMSTemplate
{
	public VirtualList<GcMechWeaponLocation> LocationPriority
	{
		get => cache.GetOrAddValue(new VirtualList<GcMechWeaponLocation>(address + GetOffset()));
		set => TrySetValue<GcMechWeaponLocation>(value);
	}

	public Single MaintainFireLocationMinTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<NMSString0x10> MuzzleFlashDataID
	{
		get => cache.GetOrAddValue(new VirtualArray<NMSString0x10>(address + GetOffset(), 4));
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single AngleToleranceForArmAiming
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CooldownTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CooldownTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SelectionWeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcExoMechWeaponData(long address) : base(address)
	{

	}
}
