using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBaseAutoPowerSetting : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcBaseAutoPowerSetting.BaseAutoPowerSettingEnum BaseAutoPowerSetting
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBaseAutoPowerSetting.BaseAutoPowerSettingEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBaseAutoPowerSetting.BaseAutoPowerSettingEnum>(value);
	}

	public GcBaseAutoPowerSetting(long address) : base(address)
	{

	}
}
