using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCHabitationComponentData : NMSTemplate
{
	public NMSString0x10 NPCSpawnLocator
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcNPCHabitationType NPCHabitationType
	{
		get => GetValue<GcNPCHabitationType>();
		set => TrySetValue<GcNPCHabitationType>(value);
	}

	public GcNPCHabitationComponentData(long address) : base(address)
	{

	}
}
