using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureTagAndRarity : NMSTemplate
{
	public NMSString0x10 Tag
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcCreatureRarity RarityOverride
	{
		get => GetValue<GcCreatureRarity>();
		set => TrySetValue<GcCreatureRarity>(value);
	}

	public GcCreatureTagAndRarity(long address) : base(address)
	{

	}
}
