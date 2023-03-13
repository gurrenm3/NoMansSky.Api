using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionOnOtherSideOfPortal : NMSTemplate
{
	public Boolean TestForRegularPortal
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean TestForStoryPortal
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionOnOtherSideOfPortal(long address) : base(address)
	{

	}
}
