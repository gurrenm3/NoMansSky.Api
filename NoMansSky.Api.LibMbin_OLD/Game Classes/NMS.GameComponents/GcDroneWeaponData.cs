using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDroneWeaponData : NMSTemplate
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

	public Int32 NumProjectiles
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single ProjectileSpread
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FireRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ChangeBarrelEachShot
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single Timeout
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

	public Single FireTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FireTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Range
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

	public Single MoveDistanceMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MoveDistanceMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcDroneWeaponData(long address) : base(address)
	{

	}
}
