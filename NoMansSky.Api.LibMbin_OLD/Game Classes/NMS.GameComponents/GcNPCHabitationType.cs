using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCHabitationType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcNPCHabitationType.NPCHabitationTypeEnum NPCHabitationType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcNPCHabitationType.NPCHabitationTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcNPCHabitationType.NPCHabitationTypeEnum>(value);
	}

	public GcNPCHabitationType(long address) : base(address)
	{

	}
}
