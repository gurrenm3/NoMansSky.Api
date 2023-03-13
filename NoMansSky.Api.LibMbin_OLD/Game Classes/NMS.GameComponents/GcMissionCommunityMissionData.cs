using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionCommunityMissionData : NMSTemplate
{
	public Boolean ShowTimeToDeadline
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionCommunityMissionData(long address) : base(address)
	{

	}
}
