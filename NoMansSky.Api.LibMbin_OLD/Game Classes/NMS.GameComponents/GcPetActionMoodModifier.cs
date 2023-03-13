using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPetActionMoodModifier : NMSTemplate
{
	public VirtualArray<Single> MoodModifiers
	{
		get => cache.GetOrAddValue(new VirtualArray<Single>(address + GetOffset(), 2));
		set => TrySetValue<Single>(value);
	}

	public GcPetActionMoodModifier(long address) : base(address)
	{

	}
}
