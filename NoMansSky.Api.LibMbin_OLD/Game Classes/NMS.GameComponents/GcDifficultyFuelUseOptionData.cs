using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDifficultyFuelUseOptionData : NMSTemplate
{
	public Single Multiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcDifficultyFuelUseTechOverride> TechOverrides
	{
		get => cache.GetOrAddValue(new VirtualList<GcDifficultyFuelUseTechOverride>(address + GetOffset()));
		set => TrySetValue<GcDifficultyFuelUseTechOverride>(value);
	}

	public GcDifficultyFuelUseOptionData(long address) : base(address)
	{

	}
}
