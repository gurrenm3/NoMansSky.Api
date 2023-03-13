using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFoliageComponentData : NMSTemplate
{
	public Single Radius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcFoliageComponentData(long address) : base(address)
	{

	}
}
