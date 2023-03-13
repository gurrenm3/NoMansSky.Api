using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerSpaceshipClassBonuses : NMSTemplate
{
	public Single ThrustForceMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ThrustForceMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxSpeedMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxSpeedMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BoostMaxSpeedMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BoostMaxSpeedMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BoostingTurnDampMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BoostingTurnDampMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DirectionBrakeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DirectionBrakeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurnStrengthMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurnStrengthMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPlayerSpaceshipClassBonuses(long address) : base(address)
	{

	}
}
