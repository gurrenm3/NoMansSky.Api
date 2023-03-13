using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCProbabilityWordReactionData : NMSTemplate
{
	public NMSString0x20A NextInteraction
	{
		get => GetValue<NMSString0x20A>();
		set => TrySetValue<NMSString0x20A>(value);
	}

	public Single Probability
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcNPCProbabilityWordReactionData(long address) : base(address)
	{

	}
}
