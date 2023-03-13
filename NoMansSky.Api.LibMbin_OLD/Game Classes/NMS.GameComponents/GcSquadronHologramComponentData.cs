using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSquadronHologramComponentData : NMSTemplate
{
	public Single HologramRotationSpeedDegPerSec
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PilotScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector3f SpawnOffset
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single SpawnRotation
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcSquadronHologramComponentData(long address) : base(address)
	{

	}
}
