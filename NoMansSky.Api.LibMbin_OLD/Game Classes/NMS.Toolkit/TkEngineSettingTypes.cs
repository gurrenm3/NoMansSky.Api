using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkEngineSettingTypes : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkEngineSettingTypes.EngineSettingEnum EngineSetting
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkEngineSettingTypes.EngineSettingEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkEngineSettingTypes.EngineSettingEnum>(value);
	}

	public TkEngineSettingTypes(long address) : base(address)
	{

	}
}
