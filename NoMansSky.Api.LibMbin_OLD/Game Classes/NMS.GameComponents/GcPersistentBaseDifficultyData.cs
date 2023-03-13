using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPersistentBaseDifficultyData : NMSTemplate
{
	public GcDifficultyPresetType DifficultyPreset
	{
		get => GetValue<GcDifficultyPresetType>();
		set => TrySetValue<GcDifficultyPresetType>(value);
	}

	public libMBIN.NMS.GameComponents.GcPersistentBaseDifficultyData.PersistentBaseDifficultyFlagsEnum PersistentBaseDifficultyFlags
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPersistentBaseDifficultyData.PersistentBaseDifficultyFlagsEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPersistentBaseDifficultyData.PersistentBaseDifficultyFlagsEnum>(value);
	}

	public GcPersistentBaseDifficultyData(long address) : base(address)
	{

	}
}
