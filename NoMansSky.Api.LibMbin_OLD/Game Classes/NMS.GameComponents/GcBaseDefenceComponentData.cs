using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseDefenceComponentData : NMSTemplate
{
	public VirtualList<GcBaseDefenceTrigger> Triggers
	{
		get => cache.GetOrAddValue(new VirtualList<GcBaseDefenceTrigger>(address + GetOffset()));
		set => TrySetValue<GcBaseDefenceTrigger>(value);
	}

	public Single LostUncertaintyThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SearchTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean PrioritiseThreats
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single LaserRangeAnimateTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcBaseDefenceComponentData(long address) : base(address)
	{

	}
}
