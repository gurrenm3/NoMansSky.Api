using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCostHealth : NMSTemplate
{
	public Int32 HealthUnits
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcCostHealth(long address) : base(address)
	{

	}
}
