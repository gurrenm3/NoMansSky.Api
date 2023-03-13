using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSentinelSpawnSequenceGroup : NMSTemplate
{
	public GcSentinelSpawnSequence Sequence
	{
		get => GetValue<GcSentinelSpawnSequence>();
		set => TrySetValue<GcSentinelSpawnSequence>(value);
	}

	public GcSentinelSpawnSequence ExtremeSequence
	{
		get => GetValue<GcSentinelSpawnSequence>();
		set => TrySetValue<GcSentinelSpawnSequence>(value);
	}

	public GcSentinelSpawnSequenceGroup(long address) : base(address)
	{

	}
}
