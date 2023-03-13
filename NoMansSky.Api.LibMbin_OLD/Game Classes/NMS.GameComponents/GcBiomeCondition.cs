using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBiomeCondition : NMSTemplate
{
	public GcBiomeType BiomeType
	{
		get => GetValue<GcBiomeType>();
		set => TrySetValue<GcBiomeType>(value);
	}

	public GcBiomeCondition(long address) : base(address)
	{

	}
}
