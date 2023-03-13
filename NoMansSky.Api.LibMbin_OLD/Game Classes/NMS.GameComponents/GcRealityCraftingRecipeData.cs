using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRealityCraftingRecipeData : NMSTemplate
{
	public VirtualArray<GcRealitySubstanceCraftingMix> Inputs
	{
		get => cache.GetOrAddValue(new VirtualArray<GcRealitySubstanceCraftingMix>(address + GetOffset(), 3));
		set => TrySetValue<GcRealitySubstanceCraftingMix>(value);
	}

	public NMSString0x10 OutputID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcRealityCraftingRecipeData(long address) : base(address)
	{

	}
}
