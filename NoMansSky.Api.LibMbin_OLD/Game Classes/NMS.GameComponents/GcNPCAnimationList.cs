using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcNPCAnimationList : NMSTemplate
{
	public VirtualList<GcNPCProbabilityAnimationData> Animations
	{
		get => cache.GetOrAddValue(new VirtualList<GcNPCProbabilityAnimationData>(address + GetOffset()));
		set => TrySetValue<GcNPCProbabilityAnimationData>(value);
	}

	public GcNPCAnimationList(long address) : base(address)
	{

	}
}
