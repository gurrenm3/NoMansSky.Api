using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionHasAnySettlementBuildingInProgress : NMSTemplate
{
	public Boolean IgnoreIfTimerActive
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionHasAnySettlementBuildingInProgress(long address) : base(address)
	{

	}
}
