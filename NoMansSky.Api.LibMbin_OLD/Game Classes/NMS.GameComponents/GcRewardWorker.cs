using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardWorker : NMSTemplate
{
	public GcNPCHabitationType NPCHabitationType
	{
		get => GetValue<GcNPCHabitationType>();
		set => TrySetValue<GcNPCHabitationType>(value);
	}

	public GcRewardWorker(long address) : base(address)
	{

	}
}
