using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBiomeType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcBiomeType.BiomeEnum Biome
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBiomeType.BiomeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBiomeType.BiomeEnum>(value);
	}

	public GcBiomeType(long address) : base(address)
	{

	}
}
