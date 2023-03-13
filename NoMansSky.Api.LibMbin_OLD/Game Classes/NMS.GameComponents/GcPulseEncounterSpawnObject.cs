using Reloaded.ModHelper;
using System;
using libMBIN.NMS.Toolkit;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPulseEncounterSpawnObject : NMSTemplate
{
	public TkModelResource Object
	{
		get => GetValue<TkModelResource>();
		set => TrySetValue<TkModelResource>(value);
	}

	public Single SpawnScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Pitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Yaw
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Roll
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPulseEncounterSpawnObject(long address) : base(address)
	{

	}
}
