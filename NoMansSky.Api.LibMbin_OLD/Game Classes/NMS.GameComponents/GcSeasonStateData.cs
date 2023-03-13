using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSeasonStateData : NMSTemplate
{
	public VirtualList<Single> MilestoneValues
	{
		get => cache.GetOrAddValue(new VirtualList<Single>(address + GetOffset()));
		set => TrySetValue<Single>(value);
	}

	public VirtualList<Int16> RewardCollected
	{
		get => cache.GetOrAddValue(new VirtualList<Int16>(address + GetOffset()));
		set => TrySetValue<Int16>(value);
	}

	public Int32 PinnedStage
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 PinnedMilestone
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<UInt64> RendezvousUAs
	{
		get => cache.GetOrAddValue(new VirtualList<UInt64>(address + GetOffset()));
		set => TrySetValue<UInt64>(value);
	}

	public Boolean HasCollectedFinalReward
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcUAProtectedLocations> ProtectedEvents
	{
		get => cache.GetOrAddValue(new VirtualList<GcUAProtectedLocations>(address + GetOffset()));
		set => TrySetValue<GcUAProtectedLocations>(value);
	}

	public GcSeasonSaveStateOnDeath StateOnDeath
	{
		get => GetValue<GcSeasonSaveStateOnDeath>();
		set => TrySetValue<GcSeasonSaveStateOnDeath>(value);
	}

	public GcSeasonStateData(long address) : base(address)
	{

	}
}
