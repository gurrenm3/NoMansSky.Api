using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCostPirateTribute : NMSTemplate
{
	public Single CargoValuePercent
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 MinimumValue
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcCostPirateTribute(long address) : base(address)
	{

	}
}
