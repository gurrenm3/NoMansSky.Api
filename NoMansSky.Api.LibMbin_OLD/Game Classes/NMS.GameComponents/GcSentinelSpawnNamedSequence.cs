using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSentinelSpawnNamedSequence : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcSentinelSpawnSequenceStep> Waves
	{
		get => cache.GetOrAddValue(new VirtualList<GcSentinelSpawnSequenceStep>(address + GetOffset()));
		set => TrySetValue<GcSentinelSpawnSequenceStep>(value);
	}

	public GcSentinelSpawnNamedSequence(long address) : base(address)
	{

	}
}
