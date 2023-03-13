using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcShipWeaponData : NMSTemplate
{
	public NMSString0x10 Projectile
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcStatsTypes Stat
	{
		get => GetValue<GcStatsTypes>();
		set => TrySetValue<GcStatsTypes>(value);
	}

	public Boolean IsProjectile
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 Reticle
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single AutoAimAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AutoAimExtraAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ShowOverheatSwitch
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single OverheatCoolTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CoolRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcRemoteWeapons RemoteType
	{
		get => GetValue<GcRemoteWeapons>();
		set => TrySetValue<GcRemoteWeapons>(value);
	}

	public GcShipWeaponData(long address) : base(address)
	{

	}
}
