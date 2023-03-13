using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMiningSubstanceData : NMSTemplate
{
	public GcRealitySubstanceCategory SubstanceCategory
	{
		get => GetValue<GcRealitySubstanceCategory>();
		set => TrySetValue<GcRealitySubstanceCategory>(value);
	}

	public Boolean UseRarity
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcRarity Rarity
	{
		get => GetValue<GcRarity>();
		set => TrySetValue<GcRarity>(value);
	}

	public GcMiningSubstanceData(long address) : base(address)
	{

	}
}
