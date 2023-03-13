using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSavedInteractionRaceData : NMSTemplate
{
	public VirtualArray<Int32> SavedRaceIndicies
	{
		get => cache.GetOrAddValue(new VirtualArray<Int32>(address + GetOffset(), 8));
		set => TrySetValue<Int32>(value);
	}

	public VirtualArray<Boolean> HasLoopedIndicies
	{
		get => cache.GetOrAddValue(new VirtualArray<Boolean>(address + GetOffset(), 8));
		set => TrySetValue<Boolean>(value);
	}

	public GcSavedInteractionRaceData(long address) : base(address)
	{

	}
}
