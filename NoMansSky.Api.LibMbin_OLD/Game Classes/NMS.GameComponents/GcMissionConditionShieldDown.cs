using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionShieldDown : NMSTemplate
{
	public Boolean RequireOnFoot
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionShieldDown(long address) : base(address)
	{

	}
}
