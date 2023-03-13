using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionIsPlayerWeak : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMissionConditionIsPlayerWeak.ProgressTypeEnum ProgressType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionConditionIsPlayerWeak.ProgressTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionConditionIsPlayerWeak.ProgressTypeEnum>(value);
	}

	public GcMissionConditionIsPlayerWeak(long address) : base(address)
	{

	}
}
