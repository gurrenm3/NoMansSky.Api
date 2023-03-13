using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRobotLaserData : NMSTemplate
{
	public NMSString0x10 LaserID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single LaserSpringTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaserActiveSpringTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 LaserMiningDamage
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single LaserChargeTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaserTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaserLightChargeSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LaserLightAttackSize
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f LaserLightOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Colour LaserColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public GcRobotLaserData(long address) : base(address)
	{

	}
}
