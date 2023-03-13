using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDifficultySettingEnum : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcDifficultySettingEnum.DifficultySettingEnum DifficultySetting
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcDifficultySettingEnum.DifficultySettingEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcDifficultySettingEnum.DifficultySettingEnum>(value);
	}

	public GcDifficultySettingEnum(long address) : base(address)
	{

	}
}
