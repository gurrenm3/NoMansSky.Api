using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionTable : NMSTemplate
{
	public VirtualList<GcGenericMissionSequence> Missions
	{
		get => cache.GetOrAddValue(new VirtualList<GcGenericMissionSequence>(address + GetOffset()));
		set => TrySetValue<GcGenericMissionSequence>(value);
	}

	public GcMissionTable(long address) : base(address)
	{

	}
}
