using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSeed : NMSTemplate
{
	public Int64 Seed
	{
		get => GetValue<Int64>();
		set => TrySetValue<Int64>(value);
	}

	public Boolean UseSeedValue
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcSeed(long address) : base(address)
	{

	}
}
