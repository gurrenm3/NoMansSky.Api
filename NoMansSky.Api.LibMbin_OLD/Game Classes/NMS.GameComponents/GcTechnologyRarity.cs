using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcTechnologyRarity : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcTechnologyRarity.TechnologyRarityEnum TechnologyRarity
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcTechnologyRarity.TechnologyRarityEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcTechnologyRarity.TechnologyRarityEnum>(value);
	}

	public GcTechnologyRarity(long address) : base(address)
	{

	}
}
