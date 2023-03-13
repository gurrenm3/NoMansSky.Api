using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionWaitForPirates : NMSTemplate
{
	public Int32 LivingPirates
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean CountHostileTraders
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CompleteOnlyInSpace
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CareAboutAttackingPlayer
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CheckAllFireteamMembers
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public TkEqualityEnum Test
	{
		get => GetValue<TkEqualityEnum>();
		set => TrySetValue<TkEqualityEnum>(value);
	}

	public GcMissionConditionWaitForPirates(long address) : base(address)
	{

	}
}
