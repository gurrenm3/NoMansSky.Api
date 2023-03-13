using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcRarity : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcRarity.RarityEnum Rarity
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcRarity.RarityEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcRarity.RarityEnum>(value);
	}

	public GcRarity(long address) : base(address)
	{

	}
}
