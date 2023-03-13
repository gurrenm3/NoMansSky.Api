using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcHeavyAirSetting : NMSTemplate
{
	public VirtualArray<GcHeavyAirSettingValues> Settings
	{
		get => cache.GetOrAddValue(new VirtualArray<GcHeavyAirSettingValues>(address + GetOffset(), 5));
		set => TrySetValue<GcHeavyAirSettingValues>(value);
	}

	public GcHeavyAirSetting(long address) : base(address)
	{

	}
}
