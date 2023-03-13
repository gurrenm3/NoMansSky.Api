using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCostNPCHabitation : NMSTemplate
{
	public GcNPCHabitationType NPCHabitationType
	{
		get => GetValue<GcNPCHabitationType>();
		set => TrySetValue<GcNPCHabitationType>(value);
	}

	public Boolean MustBeInhabited
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcCostNPCHabitation(long address) : base(address)
	{

	}
}
