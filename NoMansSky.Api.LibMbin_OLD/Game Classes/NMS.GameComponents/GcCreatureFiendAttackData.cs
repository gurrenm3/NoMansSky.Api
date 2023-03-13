using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureFiendAttackData : NMSTemplate
{
	public Single NearDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FarDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ModifyDistanceForHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 SpitAnim
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 SpitAnimFrame
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x40 SpitJoint
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public NMSString0x10 SpitProjectile
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean AllowSpit
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single DelayBetweenSpitAttacks
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean AllowPounce
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single DelayBetweenPounceAttacks
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x40 AttackLight
	{
		get => GetValue<NMSString0x40>();
		set => TrySetValue<NMSString0x40>(value);
	}

	public Single IdleLightIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackLightIntensity
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MinFlurryHits
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxFlurryHits
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single RoarChanceOnHit
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RoarChanceOnMiss
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StartDamageTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurnToFaceTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCreatureFiendAttackData(long address) : base(address)
	{

	}
}
