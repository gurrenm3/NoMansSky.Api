using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardScanEventNearestBuilding : NMSTemplate
{
	public Boolean DoAerialScan
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IncludeVisited
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRewardScanEventNearestBuilding(long address) : base(address)
	{

	}
}
