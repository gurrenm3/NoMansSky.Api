using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSolarSystemTraderSpawnData : NMSTemplate
{
	public Int32 MaxToSpawn
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single InitialTakeoffDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f SequenceTakeoffDelay
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Int32 ChanceToDelayLaunch
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public GcSolarSystemTraderSpawnData(long address) : base(address)
	{

	}
}
