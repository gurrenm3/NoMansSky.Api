using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcModuleOverride : NMSTemplate
{
	public NMSString0x10 Module
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single ProbabilityMultiplier
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single OriginalSceneProbability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcWeightedResource> Scenes
	{
		get => cache.GetOrAddValue(new VirtualList<GcWeightedResource>(address + GetOffset()));
		set => TrySetValue<GcWeightedResource>(value);
	}

	public GcModuleOverride(long address) : base(address)
	{

	}
}
