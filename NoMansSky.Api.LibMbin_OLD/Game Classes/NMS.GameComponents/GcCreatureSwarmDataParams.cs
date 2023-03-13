using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureSwarmDataParams : NMSTemplate
{
	public VirtualList<NMSString0x20A> ValidDescriptors
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20A>(address + GetOffset()));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Single Coherence
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Alignment
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SeparateStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Spacing
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Follow
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Range
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxBankingAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TurnRequiredForMaxBanking
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxPitchAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UpwardMovementForMaxPitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FaceMoveDirStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TiltMoveDirStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean CanLand
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single LandAdjustDist
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandClampBegin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandSlowDown
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TakeOffTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TakeOffStartSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TakeOffUpwardBoost
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean CanWalk
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single WalkSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WalkTurnTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlyTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FlyTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandIdleTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandIdleTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandWalkTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LandWalkTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AlignTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BankingTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpringSmoothTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean ApplyScaleToSpeed
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcCreatureSwarmDataParams(long address) : base(address)
	{

	}
}
