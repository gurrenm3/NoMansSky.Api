using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCReactionEntry : NMSTemplate
{
	public NMSString0x10 Emote
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single ReactionChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcNPCProbabilityReactionData> Animations
	{
		get => cache.GetOrAddValue(new VirtualList<GcNPCProbabilityReactionData>(address + GetOffset()));
		set => TrySetValue<GcNPCProbabilityReactionData>(value);
	}

	public GcNPCReactionEntry(long address) : base(address)
	{

	}
}
