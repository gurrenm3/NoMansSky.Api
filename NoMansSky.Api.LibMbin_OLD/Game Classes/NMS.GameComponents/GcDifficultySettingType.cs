using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDifficultySettingType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcDifficultySettingType.DifficultySettingTypeEnum DifficultySettingType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcDifficultySettingType.DifficultySettingTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcDifficultySettingType.DifficultySettingTypeEnum>(value);
	}

	public GcDifficultySettingType(long address) : base(address)
	{

	}
}
