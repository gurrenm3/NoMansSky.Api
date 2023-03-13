using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDifficultySettingEditability : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcDifficultySettingEditability.DifficultySettingEditabilityEnum DifficultySettingEditability
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcDifficultySettingEditability.DifficultySettingEditabilityEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcDifficultySettingEditability.DifficultySettingEditabilityEnum>(value);
	}

	public GcDifficultySettingEditability(long address) : base(address)
	{

	}
}
