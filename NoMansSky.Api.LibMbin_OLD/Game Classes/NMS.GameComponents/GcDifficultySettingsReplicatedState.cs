using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDifficultySettingsReplicatedState : NMSTemplate
{
	public Boolean IsPermadeath
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcDifficultyPresetType Preset
	{
		get => GetValue<GcDifficultyPresetType>();
		set => TrySetValue<GcDifficultyPresetType>(value);
	}

	public GcDifficultyPresetType RoundedDownPreset
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

	public Boolean IsLocked
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcDifficultySettingsReplicatedState(long address) : base(address)
	{

	}
}
