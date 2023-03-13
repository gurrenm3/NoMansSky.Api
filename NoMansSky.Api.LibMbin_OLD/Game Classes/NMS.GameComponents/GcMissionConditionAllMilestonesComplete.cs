using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionAllMilestonesComplete : NMSTemplate
{
	public Int32 ForStage
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean UseSeasonOverrideMessage
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionAllMilestonesComplete(long address) : base(address)
	{

	}
}
