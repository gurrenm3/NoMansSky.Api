using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRewardProduct : NMSTemplate
{
	public GcRealitySubstanceCategory ItemCategory
	{
		get => GetValue<GcRealitySubstanceCategory>();
		set => TrySetValue<GcRealitySubstanceCategory>(value);
	}

	public GcRarity ItemRarity
	{
		get => GetValue<GcRarity>();
		set => TrySetValue<GcRarity>(value);
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

	public Int32 AmountMin
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 AmountMax
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcRewardProduct(long address) : base(address)
	{

	}
}
