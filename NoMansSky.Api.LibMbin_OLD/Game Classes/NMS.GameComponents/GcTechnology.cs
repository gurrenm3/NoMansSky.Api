using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTechnology : NMSTemplate
{
	public NMSString0x10 ID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x20A Group
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
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

	public Boolean Teach
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x20A HintStart
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public NMSString0x20A HintEnd
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public TkTextureResource Icon
	{
		get => GetValue<TkTextureResource>();
		set => TrySetValue<TkTextureResource>(value);
	}

	public Colour Colour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Int32 Level
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean Chargeable
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 ChargeAmount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcRealitySubstanceCategory ChargeType
	{
		get => GetValue<GcRealitySubstanceCategory>();
		set => TrySetValue<GcRealitySubstanceCategory>(value);
	}

	public VirtualList<NMSString0x10> ChargeBy
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single ChargeMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean BuildFullyCharged
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean UsesAmmo
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x10 AmmoId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean PrimaryItem
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Upgrade
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Core
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean RepairTech
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean Procedural
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcTechnologyCategory Category
	{
		get => GetValue<GcTechnologyCategory>();
		set => TrySetValue<GcTechnologyCategory>(value);
	}

	public GcTechnologyRarity Rarity
	{
		get => GetValue<GcTechnologyRarity>();
		set => TrySetValue<GcTechnologyRarity>(value);
	}

	public Single Value
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcTechnologyRequirement> Requirements
	{
		get => cache.GetOrAddValue(new VirtualList<GcTechnologyRequirement>(address + GetOffset()));
		set => TrySetValue<GcTechnologyRequirement>(value);
	}

	public GcStatsTypes BaseStat
	{
		get => GetValue<GcStatsTypes>();
		set => TrySetValue<GcStatsTypes>(value);
	}

	public VirtualList<GcStatsBonus> StatBonuses
	{
		get => cache.GetOrAddValue(new VirtualList<GcStatsBonus>(address + GetOffset()));
		set => TrySetValue<GcStatsBonus>(value);
	}

	public NMSString0x10 RequiredTech
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 RequiredLevel
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public NMSString0x20A FocusLocator
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Colour UpgradeColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public Colour LinkColour
	{
		get => GetValue<Colour>();
		set => TrySetValue<Colour>(value);
	}

	public NMSString0x10 RewardGroup
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Int32 BaseValue
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcItemPriceModifiers Cost
	{
		get => GetValue<GcItemPriceModifiers>();
		set => TrySetValue<GcItemPriceModifiers>(value);
	}

	public Int32 RequiredRank
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcAlienRace DispensingRace
	{
		get => GetValue<GcAlienRace>();
		set => TrySetValue<GcAlienRace>(value);
	}

	public Int32 FragmentCost
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcTechnologyRarity TechShopRarity
	{
		get => GetValue<GcTechnologyRarity>();
		set => TrySetValue<GcTechnologyRarity>(value);
	}

	public Boolean WikiEnabled
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VariableSizeString DamagedDescription
	{
		get => GetValue<VariableSizeString>();
		set => TrySetValue<VariableSizeString>(value);
	}

	public NMSString0x10 ParentTechId
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean IsTemplate
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcTechnology(long address) : base(address)
	{

	}
}
