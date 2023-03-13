using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDifficultyStateData : NMSTemplate
{
	public GcDifficultyPresetType Preset
	{
		get => GetValue<GcDifficultyPresetType>();
		set => TrySetValue<GcDifficultyPresetType>(value);
	}

	public GcDifficultyPresetType EasiestUsedPreset
	{
		get => GetValue<GcDifficultyPresetType>();
		set => TrySetValue<GcDifficultyPresetType>(value);
	}

	public GcDifficultyPresetType HardestUsedPreset
	{
		get => GetValue<GcDifficultyPresetType>();
		set => TrySetValue<GcDifficultyPresetType>(value);
	}

	public GcDifficultySettingsData Settings
	{
		get => GetValue<GcDifficultySettingsData>();
		set => TrySetValue<GcDifficultySettingsData>(value);
	}

	public GcDifficultyStateData(long address) : base(address)
	{

	}
}
