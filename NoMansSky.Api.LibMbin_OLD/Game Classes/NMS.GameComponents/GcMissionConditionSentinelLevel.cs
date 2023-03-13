using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionSentinelLevel : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMissionConditionSentinelLevel.RequiredSentinelLevelEnum RequiredSentinelLevel
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionConditionSentinelLevel.RequiredSentinelLevelEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionConditionSentinelLevel.RequiredSentinelLevelEnum>(value);
	}

	public GcMissionConditionSentinelLevel(long address) : base(address)
	{

	}
}
