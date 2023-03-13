using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureGenerationData : NMSTemplate
{
	public VirtualArray<GcCreatureGenerationOptionalWeightedList> BiomeSpecific
	{
		get => cache.GetOrAddValue(new VirtualArray<GcCreatureGenerationOptionalWeightedList>(address + GetOffset(), 16));
		set => TrySetValue<GcCreatureGenerationOptionalWeightedList>(value);
	}

	public VirtualArray<GcCreatureGenerationOptionalWeightedList> SubBiomeSpecific
	{
		get => cache.GetOrAddValue(new VirtualArray<GcCreatureGenerationOptionalWeightedList>(address + GetOffset(), 27));
		set => TrySetValue<GcCreatureGenerationOptionalWeightedList>(value);
	}

	public GcCreatureGenerationOptionalWeightedList AbandonedSystemSpecific
	{
		get => GetValue<GcCreatureGenerationOptionalWeightedList>();
		set => TrySetValue<GcCreatureGenerationOptionalWeightedList>(value);
	}

	public GcCreatureGenerationOptionalWeightedList EmptySystemSpecific
	{
		get => GetValue<GcCreatureGenerationOptionalWeightedList>();
		set => TrySetValue<GcCreatureGenerationOptionalWeightedList>(value);
	}

	public GcCreatureGenerationWeightedList Generic
	{
		get => GetValue<GcCreatureGenerationWeightedList>();
		set => TrySetValue<GcCreatureGenerationWeightedList>(value);
	}

	public VirtualList<GcCreatureGenerationWeightedListDomainEntry> AirArchetypesForEmptyGround
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureGenerationWeightedListDomainEntry>(address + GetOffset()));
		set => TrySetValue<GcCreatureGenerationWeightedListDomainEntry>(value);
	}

	public VirtualArray<Single> SandwormPresenceChance
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 16));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> LifeChance
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> RoleFrequencyModifiers
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> RarityFrequencyModifiers
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> GroundGroupsPerKm
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> WaterGroupsPerKm
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> AirGroupsPerKm
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> CaveGroupsPerKm
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> DensityModifiers
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public VirtualArray<Single> LifeLevelDensityModifiers
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public Single HerdCreaturePenalty
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCreatureGenerationData(long address) : base(address)
	{

	}
}
