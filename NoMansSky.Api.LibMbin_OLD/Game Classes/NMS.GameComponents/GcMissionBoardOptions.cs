using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionBoardOptions : NMSTemplate
{
	public GcMissionType Type
	{
		get => GetValue<GcMissionType>();
		set => TrySetValue<GcMissionType>(value);
	}

	public GcMissionDifficulty Difficulty
	{
		get => GetValue<GcMissionDifficulty>();
		set => TrySetValue<GcMissionDifficulty>(value);
	}

	public Int32 MinRank
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean CloseMissionGiver
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IsGuildShopMission
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IsPlanetProcMission
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IsMultiplayerEventMission
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 RewardPenaltyOnAbandon
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcMissionFaction> Faction
	{
		get => cache.GetOrAddValue(new VirtualList<GcMissionFaction>(address + GetOffset()));
		set => TrySetValue<GcMissionFaction>(value);
	}

	public Int32 Weighting
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean IgnoreCalculatedObjective
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x20A MultiplayerMissionInitialWarpScanEvent
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public VirtualList<NMSString0x20A> DefaultItemInitialWarpScanEvents
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x20A>(address + GetOffset()));
		set => TrySetValue<NMSString0x20A>(value);
	}

	public libMBIN.NMS.GameComponents.GcMissionBoardOptions.DefaultItemTypeForInitialWarpEnum DefaultItemTypeForInitialWarp
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionBoardOptions.DefaultItemTypeForInitialWarpEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionBoardOptions.DefaultItemTypeForInitialWarpEnum>(value);
	}

	public VirtualList<NMSString0x10> BasePartBlueprints
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcMissionBoardOptions(long address) : base(address)
	{

	}
}
