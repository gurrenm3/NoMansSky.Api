using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDifficultySettingUIOption : NMSTemplate
{
	public GcDifficultySettingEnum MainOption
	{
		get => GetValue<GcDifficultySettingEnum>();
		set => TrySetValue<GcDifficultySettingEnum>(value);
	}

	public VirtualList<GcDifficultySettingEnum> AlsoChangeOptions
	{
		get => cache.GetOrAddValue(new VirtualList<GcDifficultySettingEnum>(address + GetOffset()));
		set => TrySetValue<GcDifficultySettingEnum>(value);
	}

	public GcDifficultySettingUIOption(long address) : base(address)
	{

	}
}
