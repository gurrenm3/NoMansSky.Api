using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSentinelSpawnWave : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public VirtualList<GcSentinelSpawnData> Spawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcSentinelSpawnData>(address + GetOffset()));
		set => TrySetValue<GcSentinelSpawnData>(value);
	}

	public Int32 ReinforceAt
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcSentinelSpawnWave(long address) : base(address)
	{

	}
}
