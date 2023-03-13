using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureGenerationWeightedListDomainEntry : NMSTemplate
{
	public Single Weight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public NMSString0x10 Archetype
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcCreatureGenerationWeightedListDomainEntry(long address) : base(address)
	{

	}
}
