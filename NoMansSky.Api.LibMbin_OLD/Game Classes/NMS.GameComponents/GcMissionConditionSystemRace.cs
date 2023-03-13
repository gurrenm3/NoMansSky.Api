using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionSystemRace : NMSTemplate
{
	public GcAlienRace Race
	{
		get => GetValue<GcAlienRace>();
		set => TrySetValue<GcAlienRace>(value);
	}

	public GcMissionConditionSystemRace(long address) : base(address)
	{

	}
}
