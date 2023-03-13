using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPetEggTraitModifierOverrideTable : NMSTemplate
{
	public VirtualList<GcPetEggTraitModifierOverrideData> TraitModifiers
	{
		get => cache.GetOrAddValue(new VirtualList<GcPetEggTraitModifierOverrideData>(address + GetOffset()));
		set => TrySetValue<GcPetEggTraitModifierOverrideData>(value);
	}

	public GcPetEggTraitModifierOverrideTable(long address) : base(address)
	{

	}
}
