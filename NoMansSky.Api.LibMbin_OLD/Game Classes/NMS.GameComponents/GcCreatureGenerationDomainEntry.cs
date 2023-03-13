using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureGenerationDomainEntry : NMSTemplate
{
	public GcCreatureGenerationDensity DensityModifier
	{
		get => GetValue<GcCreatureGenerationDensity>();
		set => TrySetValue<GcCreatureGenerationDensity>(value);
	}

	public NMSString0x80 File
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcCreatureGenerationDomainEntry(long address) : base(address)
	{

	}
}
