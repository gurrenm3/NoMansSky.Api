using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcExpeditionCategoryStrength : NMSTemplate
{
	public VirtualArray<Int32> OccurranceChance
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 5));
		set => TrySetValue<Int32>(value);
	}

	public GcExpeditionCategoryStrength(long address) : base(address)
	{

	}
}
