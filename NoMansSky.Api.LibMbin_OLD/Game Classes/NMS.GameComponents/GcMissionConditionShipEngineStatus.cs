using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionShipEngineStatus : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcMissionConditionShipEngineStatus.EngineStatusEnum EngineStatus
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionConditionShipEngineStatus.EngineStatusEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionConditionShipEngineStatus.EngineStatusEnum>(value);
	}

	public GcMissionConditionShipEngineStatus(long address) : base(address)
	{

	}
}
