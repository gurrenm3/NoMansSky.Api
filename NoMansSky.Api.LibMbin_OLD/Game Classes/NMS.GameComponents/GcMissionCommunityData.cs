using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionCommunityData : NMSTemplate
{
	public VirtualList<NMSString0x10> CommunityMissionsIDs
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcMissionCommunityMissionData> CommunityMissionsData
	{
		get => cache.GetOrAddValue(new VirtualList<GcMissionCommunityMissionData>(address + GetOffset()));
		set => TrySetValue<GcMissionCommunityMissionData>(value);
	}

	public GcMissionCommunityData(long address) : base(address)
	{

	}
}
