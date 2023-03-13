using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBiomeSubType : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcBiomeSubType.BiomeSubTypeEnum BiomeSubType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcBiomeSubType.BiomeSubTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcBiomeSubType.BiomeSubTypeEnum>(value);
	}

	public GcBiomeSubType(long address) : base(address)
	{

	}
}
