using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSolarGenerationData : NMSTemplate
{
	public UInt64 SolarSeed
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public GcSolarGenerationData(long address) : base(address)
	{

	}
}
