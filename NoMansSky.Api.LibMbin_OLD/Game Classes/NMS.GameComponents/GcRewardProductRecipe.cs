using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardProductRecipe : NMSTemplate
{
	public GcRealitySubstanceCategory ItemCatagory
	{
		get => GetValue<GcRealitySubstanceCategory>();
		set => TrySetValue<GcRealitySubstanceCategory>(value);
	}

	public GcRarity ItemRarity
	{
		get => GetValue<GcRarity>();
		set => TrySetValue<GcRarity>(value);
	}

	public Boolean IgnoreRarity
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 ItemLevel
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Boolean> AllowedProductTypes
	{
		get => cache.GetOrAddValue(new VirtualArray<Boolean>(address + GetOffset(), 9));
		set => TrySetValue<Boolean>(value);
	}

	public GcRewardProductRecipe(long address) : base(address)
	{

	}
}
