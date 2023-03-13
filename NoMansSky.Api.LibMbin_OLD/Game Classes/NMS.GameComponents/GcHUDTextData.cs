using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcHUDTextData : NMSTemplate
{
	public GcHUDComponent Data
	{
		get => GetValue<GcHUDComponent>();
		set => TrySetValue<GcHUDComponent>(value);
	}

	public NMSString0x80 Text
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcTextPreset Preset
	{
		get => GetValue<GcTextPreset>();
		set => TrySetValue<GcTextPreset>(value);
	}

	public GcHUDTextData(long address) : base(address)
	{

	}
}
