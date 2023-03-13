using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureData : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Boolean OnlySpawnWhenIdIsForced
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcCreatureTypes ForceType
	{
		get => GetValue<GcCreatureTypes>();
		set => TrySetValue<GcCreatureTypes>(value);
	}

	public GcCreatureTypes RealType
	{
		get => GetValue<GcCreatureTypes>();
		set => TrySetValue<GcCreatureTypes>(value);
	}

	public Boolean EcoSystemCreature
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean CanBeFemale
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcCreatureTagAndRarity> Tags
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureTagAndRarity>(address + GetOffset()));
		set => TrySetValue<GcCreatureTagAndRarity>(value);
	}

	public libMBIN.NMS.GameComponents.GcCreatureData.MoveAreaEnum MoveArea
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCreatureData.MoveAreaEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCreatureData.MoveAreaEnum>(value);
	}

	public Single MinScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FurLengthModifierAtMinScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FurLengthModifierAtMaxScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FurChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCreatureRarity Rarity
	{
		get => GetValue<GcCreatureRarity>();
		set => TrySetValue<GcCreatureRarity>(value);
	}

	public GcCreatureRoleFrequencyModifier PredatorProbabilityModifier
	{
		get => GetValue<GcCreatureRoleFrequencyModifier>();
		set => TrySetValue<GcCreatureRoleFrequencyModifier>(value);
	}

	public GcCreatureRoleFrequencyModifier HerbivoreProbabilityModifier
	{
		get => GetValue<GcCreatureRoleFrequencyModifier>();
		set => TrySetValue<GcCreatureRoleFrequencyModifier>(value);
	}

	public VirtualList<NMSTemplate> Data
	{
		get => cache.GetOrAddValue(new VirtualList<NMSTemplate>(address + GetOffset()));
		set => TrySetValue<NMSTemplate>(value);
	}

	public GcCreatureData(long address) : base(address)
	{

	}
}
