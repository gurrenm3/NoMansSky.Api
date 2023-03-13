using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionWaitForTime : NMSTemplate
{
	public UInt64 WaitTimeInSeconds
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public Boolean ThisConditionWillSetMissionUserDataIsThatOk
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionWaitForTime(long address) : base(address)
	{

	}
}
