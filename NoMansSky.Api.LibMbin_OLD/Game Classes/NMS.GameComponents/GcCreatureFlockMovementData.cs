using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureFlockMovementData : NMSTemplate
{
	public Int32 MinFlockMembers
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 MaxFlockMembers
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single FlockFollow
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlockHysteresis
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlockCohere
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlockSeperate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlockSeperateMinDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlockSeperateMaxDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlockAlign
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlockAvoidTerrain
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlockAvoidTerrainMinDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlockAvoidTerrainMaxDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlockAvoidPredators
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlockAvoidPredatorsMinDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlockAvoidPredatorsMaxDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlockAvoidPredatorsSpeedBoost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MoveInFacingStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlockMoveSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlockMoveDirectionTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlockTurnAngle
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxBank
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BankTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinFlapSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxFlapSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCreatureFlockMovementData(long address) : base(address)
	{

	}
}
