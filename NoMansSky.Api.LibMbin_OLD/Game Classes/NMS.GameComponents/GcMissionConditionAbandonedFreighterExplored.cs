using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionAbandonedFreighterExplored : NMSTemplate
{
	public Int32 TargetRooms
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcMissionConditionAbandonedFreighterExplored(long address) : base(address)
	{

	}
}
