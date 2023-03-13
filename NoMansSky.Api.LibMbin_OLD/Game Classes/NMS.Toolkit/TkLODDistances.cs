using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class TkLODDistances : NMSTemplate
{
	public VirtualArray<Single> Distances
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 5));
		set => TrySetValue<Single>(value);
	}

	public TkLODDistances(long address) : base(address)
	{

	}
}
