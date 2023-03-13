using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureGenerationDensity : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcCreatureGenerationDensity.DensityEnum Density
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCreatureGenerationDensity.DensityEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCreatureGenerationDensity.DensityEnum>(value);
	}

	public GcCreatureGenerationDensity(long address) : base(address)
	{

	}
}
