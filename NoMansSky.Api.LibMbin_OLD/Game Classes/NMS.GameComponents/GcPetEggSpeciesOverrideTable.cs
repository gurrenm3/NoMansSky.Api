using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPetEggSpeciesOverrideTable : NMSTemplate
{
	public VirtualList<GcPetEggSpeciesOverrideData> SpeciesOverrides
	{
		get => cache.GetOrAddValue(new VirtualList<GcPetEggSpeciesOverrideData>(address + GetOffset()));
		set => TrySetValue<GcPetEggSpeciesOverrideData>(value);
	}

	public GcPetEggSpeciesOverrideTable(long address) : base(address)
	{

	}
}
