using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDefaultSaveData : NMSTemplate
{
	public GcPlayerStateData State
	{
		get => GetValue<GcPlayerStateData>();
		set => TrySetValue<GcPlayerStateData>(value);
	}

	public GcPlayerSpawnStateData Spawn
	{
		get => GetValue<GcPlayerSpawnStateData>();
		set => TrySetValue<GcPlayerSpawnStateData>(value);
	}

	public GcDefaultSaveData(long address) : base(address)
	{

	}
}
