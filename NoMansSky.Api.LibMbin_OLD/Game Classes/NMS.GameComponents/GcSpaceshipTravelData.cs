using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSpaceshipTravelData : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single MinSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BoostSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Force
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinSpeedForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurnMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurnMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DirectionBrake
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxSpeedBrake
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Falloff
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Roll
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AvoidTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean Hovering
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcSpaceshipTravelData(long address) : base(address)
	{

	}
}
