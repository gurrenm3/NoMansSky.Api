using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBackgroundSpaceEncounterSpawnConditions : NMSTemplate
{
	public Boolean NeedsEmptySystem
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean NeedsAbandonedSystem
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean NeedsPirateSystem
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Boolean NeedsAsteroidField
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcBackgroundSpaceEncounterSpawnConditions(long address) : base(address)
	{

	}
}
