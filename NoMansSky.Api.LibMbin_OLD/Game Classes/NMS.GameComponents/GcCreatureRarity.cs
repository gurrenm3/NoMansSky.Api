using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureRarity : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcCreatureRarity.CreatureRarityEnum CreatureRarity
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCreatureRarity.CreatureRarityEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCreatureRarity.CreatureRarityEnum>(value);
	}

	public GcCreatureRarity(long address) : base(address)
	{

	}
}
