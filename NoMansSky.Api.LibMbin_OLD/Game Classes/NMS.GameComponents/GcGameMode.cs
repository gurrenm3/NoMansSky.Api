using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcGameMode : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcGameMode.PresetGameModeEnum PresetGameMode
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcGameMode.PresetGameModeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcGameMode.PresetGameModeEnum>(value);
	}

	public GcGameMode(long address) : base(address)
	{

	}
}
