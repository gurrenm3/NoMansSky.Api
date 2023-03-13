using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionNPCHabitationHasWorker : NMSTemplate
{
	public GcNPCHabitationType WorkerType
	{
		get => GetValue<GcNPCHabitationType>();
		set => TrySetValue<GcNPCHabitationType>(value);
	}

	public libMBIN.NMS.GameComponents.GcMissionConditionNPCHabitationHasWorker.WorkerInCurrentBaseEnum WorkerInCurrentBase
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcMissionConditionNPCHabitationHasWorker.WorkerInCurrentBaseEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcMissionConditionNPCHabitationHasWorker.WorkerInCurrentBaseEnum>(value);
	}

	public GcMissionConditionNPCHabitationHasWorker(long address) : base(address)
	{

	}
}
