using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcFrigateStatsByClass : NMSTemplate
{
	public VirtualArray<GcFrigateStats> FrigateClass
	{
		get => cache.GetOrAddValue(new VirtualArray<GcFrigateStats>(address + GetOffset(), 8));
		set => TrySetValue<GcFrigateStats>(value);
	}

	public GcFrigateStatsByClass(long address) : base(address)
	{

	}
}
