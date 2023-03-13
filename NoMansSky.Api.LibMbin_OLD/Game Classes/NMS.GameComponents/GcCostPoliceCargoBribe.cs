using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCostPoliceCargoBribe : NMSTemplate
{
	public Boolean IncludeNipNip
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean OnlyCargoProbeInventories
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Int32 Amount
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcCostPoliceCargoBribe(long address) : base(address)
	{

	}
}
