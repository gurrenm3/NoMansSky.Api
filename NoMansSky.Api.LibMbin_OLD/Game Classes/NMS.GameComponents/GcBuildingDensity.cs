using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBuildingDensity : NMSTemplate
{
	public Single BuildingSpacing
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcBuildingDensity(long address) : base(address)
	{

	}
}
