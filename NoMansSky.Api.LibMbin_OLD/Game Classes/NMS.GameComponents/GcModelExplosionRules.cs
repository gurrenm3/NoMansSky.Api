using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcModelExplosionRules : NMSTemplate
{
	public VirtualList<GcModelExplosionRule> Rules
	{
		get => cache.GetOrAddValue(new VirtualList<GcModelExplosionRule>(address + GetOffset()));
		set => TrySetValue<GcModelExplosionRule>(value);
	}

	public VirtualArray<Boolean> UseRules
	{
		get => cache.GetOrAddValue(new VirtualArray<Boolean>(address + GetOffset(), 9));
		set => TrySetValue<Boolean>(value);
	}

	public VirtualArray<Single> ShipSalvageDisplayScales
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 9));
		set => TrySetValue<Single>(value);
	}

	public GcModelExplosionRules(long address) : base(address)
	{

	}
}
