using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionGameMode : NMSTemplate
{
	public GcGameMode Mode
	{
		get => GetValue<GcGameMode>();
		set => TrySetValue<GcGameMode>(value);
	}

	public GcMissionConditionGameMode(long address) : base(address)
	{

	}
}
