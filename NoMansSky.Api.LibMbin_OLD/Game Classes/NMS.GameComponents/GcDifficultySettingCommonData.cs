using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDifficultySettingCommonData : NMSTemplate
{
	public GcDifficultySettingType SettingType
	{
		get => GetValue<GcDifficultySettingType>();
		set => TrySetValue<GcDifficultySettingType>(value);
	}

	public Boolean IsAscendingDifficulty
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcDifficultySettingEditability EditabilityInOptionsMenu
	{
		get => GetValue<GcDifficultySettingEditability>();
		set => TrySetValue<GcDifficultySettingEditability>(value);
	}

	public NMSString0x20A TitleLocID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A DescriptionLocID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A ToggleEnabledLocID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A ToggleDisabledLocID
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public GcDifficultySettingCommonData(long address) : base(address)
	{

	}
}
