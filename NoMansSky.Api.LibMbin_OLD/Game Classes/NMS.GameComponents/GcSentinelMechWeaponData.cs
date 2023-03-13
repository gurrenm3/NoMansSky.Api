using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSentinelMechWeaponData : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 Projectile
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 ProjectilesPerShot
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single ProjectileSpread
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FireInterval
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 NumShotsMin
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 NumShotsMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
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

	public Single IdealRange
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

	public Single ExplosionRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InheritInitialVelocity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcMechWeaponLocation ShootLocation
	{
		get => GetValue<GcMechWeaponLocation>();
		set => TrySetValue<GcMechWeaponLocation>(value);
	}

	public GcVehicleWeaponMuzzleData MuzzleData
	{
		get => GetValue<GcVehicleWeaponMuzzleData>();
		set => TrySetValue<GcVehicleWeaponMuzzleData>(value);
	}

	public GcAudioWwiseEvents StartFireAudioEvent
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public GcAudioWwiseEvents StopFireAudioEvent
	{
		get => GetValue<GcAudioWwiseEvents>();
		set => TrySetValue<GcAudioWwiseEvents>(value);
	}

	public GcSentinelMechWeaponData(long address) : base(address)
	{

	}
}
