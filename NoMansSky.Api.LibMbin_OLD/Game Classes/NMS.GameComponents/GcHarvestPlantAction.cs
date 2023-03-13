using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcHarvestPlantAction : NMSTemplate
{
	public Single Radius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcHarvestPlantAction(long address) : base(address)
	{

	}
}
