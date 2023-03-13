using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCProbabilityReactionData : NMSTemplate
{
	public NMSString0x10 Name
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single Probability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcNPCRaceProbabilityModifierData> RaceModifiers
	{
		get => cache.GetOrAddValue(new VirtualList<GcNPCRaceProbabilityModifierData>(address + GetOffset()));
		set => TrySetValue<GcNPCRaceProbabilityModifierData>(value);
	}

	public GcNPCProbabilityReactionData(long address) : base(address)
	{

	}
}
