using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPetCustomisationData : NMSTemplate
{
	public VirtualArray<GcCharacterCustomisationSaveData> Data
	{
		get => cache.GetOrAddValue(new VirtualArray<GcCharacterCustomisationSaveData>(address + GetOffset(), 3));
		set => TrySetValue<GcCharacterCustomisationSaveData>(value);
	}

	public GcPetCustomisationData(long address) : base(address)
	{

	}
}
