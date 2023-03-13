using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSentinelSpawnSequenceStep : NMSTemplate
{
	public VirtualList<NMSString0x10> WavePool
	{
		get => cache.GetOrAddValue(new VirtualList<NMSString0x10>(address + GetOffset()));
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcSentinelSpawnSequenceStep(long address) : base(address)
	{

	}
}
