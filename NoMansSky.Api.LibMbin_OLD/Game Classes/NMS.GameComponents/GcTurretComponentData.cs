using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTurretComponentData : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcTurretComponentData.GunTypeEnum GunType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcTurretComponentData.GunTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcTurretComponentData.GunTypeEnum>(value);
	}

	public NMSString0x10 LaserEffectId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 LaserMuzzleFlashId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 ProjectileId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 ProjectileMuzzleFlashId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 MissileId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean HasFreighterAlertLight
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single TurretRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurretLaserShootTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurretLaserLength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurretLaserMoveSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurretLaserActiveTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurretLaserAbortDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurretShootPauseTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 TurretBurstCount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single TurretBurstTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurretMissileLaunchTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurretMissileLaunchSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurretMaxDownAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurretSlerpFactor
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurretAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurretProjectileRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurretMissileRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurretDispersionAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean RemotePlayersCanDamage
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CanMoveDuringBurst
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean FireInTurretFacing
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single TurretAimOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcTurretComponentData(long address) : base(address)
	{

	}
}
