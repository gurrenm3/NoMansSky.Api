using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCostCargo : NMSTemplate
{
	public Int32 Slots
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcCostCargo(long address) : base(address)
	{

	}
}
