using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDifficultyPresetType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcDifficultyPresetType.DifficultyPresetTypeEnum DifficultyPresetType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcDifficultyPresetType.DifficultyPresetTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcDifficultyPresetType.DifficultyPresetTypeEnum>(value);
	}

	public GcDifficultyPresetType(long address) : base(address)
	{

	}
}
