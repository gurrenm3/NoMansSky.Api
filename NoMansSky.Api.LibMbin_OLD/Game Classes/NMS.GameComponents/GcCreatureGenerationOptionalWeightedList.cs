using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureGenerationOptionalWeightedList : NMSTemplate
{
	public Single Probability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean OverrideAllDomains
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcCreatureGenerationWeightedList Archetypes
	{
		get => GetValue<GcCreatureGenerationWeightedList>();
		set => TrySetValue<GcCreatureGenerationWeightedList>(value);
	}

	public GcCreatureGenerationOptionalWeightedList(long address) : base(address)
	{

	}
}
