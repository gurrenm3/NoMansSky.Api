using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionCreatureReadyToLay : NMSTemplate
{
	public Boolean PrimaryCreatureOnly
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionCreatureReadyToLay(long address) : base(address)
	{

	}
}
