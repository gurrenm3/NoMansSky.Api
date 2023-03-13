using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardCompleteMultiMission : NMSTemplate
{
	public VirtualList<NMSString0x10> Missions
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcRewardCompleteMultiMission(long address) : base(address)
	{

	}
}
