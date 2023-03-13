using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionInMultiplayer : NMSTemplate
{
	public Boolean MustBeInFireteam
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionInMultiplayer(long address) : base(address)
	{

	}
}
