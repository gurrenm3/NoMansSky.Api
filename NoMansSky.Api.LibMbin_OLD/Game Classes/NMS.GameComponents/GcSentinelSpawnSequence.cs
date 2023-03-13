using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSentinelSpawnSequence : NMSTemplate
{
	public VirtualList<GcSentinelSpawnSequenceStep> Waves
	{
		get => cache.GetOrAddValue(new VirtualList<GcSentinelSpawnSequenceStep>(address + GetOffset()));
		set => TrySetValue<GcSentinelSpawnSequenceStep>(value);
	}

	public GcSentinelSpawnSequence(long address) : base(address)
	{

	}
}
