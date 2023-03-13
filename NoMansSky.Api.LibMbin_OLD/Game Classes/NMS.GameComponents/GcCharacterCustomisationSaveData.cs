using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCharacterCustomisationSaveData : NMSTemplate
{
	public NMSString0x10 SelectedPreset
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcCharacterCustomisationData CustomData
	{
		get => GetValue<GcCharacterCustomisationData>();
		set => TrySetValue<GcCharacterCustomisationData>(value);
	}

	public GcCharacterCustomisationSaveData(long address) : base(address)
	{

	}
}
