using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkGameSettings : NMSTemplate
{
	public libMBIN.NMS.Toolkit.TkGameSettings.LanguageSettingEnum LanguageSetting
	{
		get => GetValue<libMBIN.NMS.Toolkit.TkGameSettings.LanguageSettingEnum>();
		set => TrySetValue<libMBIN.NMS.Toolkit.TkGameSettings.LanguageSettingEnum>(value);
	}

	public VirtualList<GcInputActionMapping> KeyMapping
	{
		get => cache.GetOrAddValue(new VirtualList<GcInputActionMapping>(address + GetOffset()));
		set => TrySetValue<GcInputActionMapping>(value);
	}

	public VirtualList<GcInputActionMapping2> KeyMapping2
	{
		get => cache.GetOrAddValue(new VirtualList<GcInputActionMapping2>(address + GetOffset()));
		set => TrySetValue<GcInputActionMapping2>(value);
	}

	public TkGameSettings(long address) : base(address)
	{

	}
}
