using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcProductData : NMSTemplate
{
	public NMSString0x10 ID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x80 Name
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x80 NameLower
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
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

	public NMSString0x20A Hint
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x10 GroupID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public TkModelResource DebrisFile
	{
		get => GetValue<TkModelResource>();
		set => TrySetValue<TkModelResource>(value);
	}

	public Int32 BaseValue
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 Level
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public TkTextureResource Icon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public TkTextureResource HeroIcon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public Colour Colour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public GcRealitySubstanceCategory Category
	{
		get => GetValue<GcRealitySubstanceCategory>();
		set => TrySetValue<GcRealitySubstanceCategory>(value);
	}

	public GcProductCategory Type
	{
		get => GetValue<GcProductCategory>();
		set => TrySetValue<GcProductCategory>(value);
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

	public Boolean Consumable
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
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

	public Int32 DefaultCraftAmount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 CraftAmountStepSize
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Int32 CraftAmountMultiplier
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public VirtualList<GcTechnologyRequirement> Requirements
	{
		get => cache.GetOrAddValue(new VirtualList<GcTechnologyRequirement>(address + GetOffset()));
		set => TrySetValue<GcTechnologyRequirement>(value);
	}

	public VirtualList<GcTechnologyRequirement> AltRequirements
	{
		get => cache.GetOrAddValue(new VirtualList<GcTechnologyRequirement>(address + GetOffset()));
		set => TrySetValue<GcTechnologyRequirement>(value);
	}

	public GcItemPriceModifiers Cost
	{
		get => GetValue<GcItemPriceModifiers>();
		set => TrySetValue<GcItemPriceModifiers>(value);
	}

	public Int32 RecipeCost
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean SpecificChargeOnly
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
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

	public libMBIN.NMS.GameComponents.GcProductData.WikiCategoryEnum WikiCategory
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcProductData.WikiCategoryEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcProductData.WikiCategoryEnum>(value);
	}

	public Boolean IsCraftable
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 DeploysInto
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
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

	public Boolean CookingIngredient
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single CookingValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean GoodForSelling
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 GiveRewardOnSpecialPurchase
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean EggModifierIngredient
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean IsTechbox
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcProductData(long address) : base(address)
	{

	}
}
