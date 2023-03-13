using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCustomisationPreset : NMSTemplate
{
	public NMSString0x10 Name
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcCharacterCustomisationData Data
	{
		get => GetValue<GcCharacterCustomisationData>();
		set => TrySetValue<GcCharacterCustomisationData>(value);
	}

	public GcCustomisationPreset(long address) : base(address)
	{

	}
}
