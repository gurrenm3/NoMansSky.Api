using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcInventoryClassProbabilities : NMSTemplate
{
	public VirtualArray<Single> ClassProbabilities
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 4));
		set => TrySetValue<Single>(value);
	}

	public GcInventoryClassProbabilities(long address) : base(address)
	{

	}
}
