using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionBaseRequiresPower : NMSTemplate
{
	public Int32 MinNumPowerUsingParts
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcMissionConditionBaseRequiresPower(long address) : base(address)
	{

	}
}
