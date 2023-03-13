using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRealitySubstanceData : NMSTemplate
{
	public NMSString0x20 Name
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x20 NameLower
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public NMSString0x10 ID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20 Symbol
	{
		get => GetValue<NMSString0x20>();
		set => TrySetValue<NMSString0x20>(value);
	}

	public TkTextureResource Icon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public TkModelResource DebrisFile
	{
		get => GetValue<TkModelResource>();
		set => TrySetValue<TkModelResource>(value);
	}

	public VariableSizeString Subtitle
	{
		get => GetValue<VariableSizeString>();
		set => TrySetValue<VariableSizeString>(value);
	}

	public VariableSizeString Description
	{
		get => GetValue<VariableSizeString>();
		set => TrySetValue<VariableSizeString>(value);
	}

	public Colour Colour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour WorldColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Int32 BaseValue
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcRealitySubstanceCategory Category
	{
		get => GetValue<GcRealitySubstanceCategory>();
		set => TrySetValue<GcRealitySubstanceCategory>(value);
	}

	public GcRarity Rarity
	{
		get => GetValue<GcRarity>();
		set => TrySetValue<GcRarity>(value);
	}

	public GcLegality Legality
	{
		get => GetValue<GcLegality>();
		set => TrySetValue<GcLegality>(value);
	}

	public Int32 ChargeValue
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 StackMultiplier
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcItemPriceModifiers Cost
	{
		get => GetValue<GcItemPriceModifiers>();
		set => TrySetValue<GcItemPriceModifiers>(value);
	}

	public Single NormalisedValueOnWorld
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NormalisedValueOffWorld
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcTradeCategory TradeCategory
	{
		get => GetValue<GcTradeCategory>();
		set => TrySetValue<GcTradeCategory>(value);
	}

	public Boolean WikiEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single EconomyInfluenceMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x20A PinObjective
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A PinObjectiveTip
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x10 WikiMissionID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean CookingIngredient
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean GoodForSelling
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean EggModifierIngredient
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRealitySubstanceData(long address) : base(address)
	{

	}
}
