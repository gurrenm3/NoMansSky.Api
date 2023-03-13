using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionCriticalMissionsDone : NMSTemplate
{
	public Boolean Warped
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionCriticalMissionsDone(long address) : base(address)
	{

	}
}
