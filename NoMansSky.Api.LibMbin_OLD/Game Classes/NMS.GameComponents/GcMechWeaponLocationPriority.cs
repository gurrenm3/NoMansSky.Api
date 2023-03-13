using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMechWeaponLocationPriority : NMSTemplate
{
	public VirtualList<GcMechWeaponLocation> MechWeaponLocationPriority
	{
		get => cache.GetOrAddValue(new VirtualList<GcMechWeaponLocation>(address + GetOffset()));
		set => TrySetValue<GcMechWeaponLocation>(value);
	}

	public GcMechWeaponLocationPriority(long address) : base(address)
	{

	}
}
