using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGroundWormComponentData : NMSTemplate
{
	public NMSString0x100 LookJoint
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public NMSString0x100 GrabJoint
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public NMSString0x10 EmergeEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 SubmergeEffect
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 EmergeShake
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x10 RoarShake
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single CollisionBodySize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RumbleTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EmergeEffectTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EmergeDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SubmergeDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SubmergeDepth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlinchTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlinchAngleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlinchAngleMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlinchSmooth
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 AttackDamageType
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single AttackDamageRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackDistMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackDistMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AttackCooldown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RoarCooldown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LungeStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LungeAngleHead
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LungeAngleBase
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LungeBeginTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LungeEndTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LungeBlendInSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LungeBlendOutSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WindUpStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WindUpAngleHead
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WindUpAngleBase
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RestTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TrackTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurnSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EmergeLookBlendStart
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EmergeLookBlendEnd
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single EmergeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RearUpBeginDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RearUpEndDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcGroundWormComponentData(long address) : base(address)
	{

	}
}
