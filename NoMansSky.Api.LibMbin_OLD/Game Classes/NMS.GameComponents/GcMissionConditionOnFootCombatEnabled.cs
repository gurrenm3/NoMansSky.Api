using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionOnFootCombatEnabled : NMSTemplate
{
	public Boolean Enabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcMissionConditionOnFootCombatEnabled(long address) : base(address)
	{

	}
}
