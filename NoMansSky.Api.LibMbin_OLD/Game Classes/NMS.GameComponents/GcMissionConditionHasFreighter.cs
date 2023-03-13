using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionHasFreighter : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMissionConditionHasFreighter.FreighterInCurrentSystemEnum FreighterInCurrentSystem
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionConditionHasFreighter.FreighterInCurrentSystemEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionConditionHasFreighter.FreighterInCurrentSystemEnum>(value);
	}

	public GcMissionConditionHasFreighter(long address) : base(address)
	{

	}
}
