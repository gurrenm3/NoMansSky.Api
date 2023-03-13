using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMissionConditionRequestedPhoto : NMSTemplate
{
	public GcBiomeType Biome
	{
		get => GetValue<GcBiomeType>();
		set => TrySetValue<GcBiomeType>(value);
	}

	public GcMissionConditionRequestedPhoto(long address) : base(address)
	{

	}
}
