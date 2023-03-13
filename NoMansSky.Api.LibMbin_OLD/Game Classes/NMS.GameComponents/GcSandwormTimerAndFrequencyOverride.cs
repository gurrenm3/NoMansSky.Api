using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSandwormTimerAndFrequencyOverride : NMSTemplate
{
	public UInt64 PackedUA
	{
		get => GetValue<UInt64>();
		set => TrySetValue<UInt64>(value);
	}

	public Single Timer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpawnChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcSandwormTimerAndFrequencyOverride(long address) : base(address)
	{

	}
}
