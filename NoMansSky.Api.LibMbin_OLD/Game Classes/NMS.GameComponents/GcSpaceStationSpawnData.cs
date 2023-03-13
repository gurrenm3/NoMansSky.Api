using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcSpaceStationSpawnData : NMSTemplate
{
	public libMBIN.NMS.GameComponents.GcSpaceStationSpawnData.SpawnModeEnum SpawnMode
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcSpaceStationSpawnData.SpawnModeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcSpaceStationSpawnData.SpawnModeEnum>(value);
	}

	public GcSeed Seed
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public NMSString0x100 AltId
	{
		get => GetValue<NMSString0x100>();
		set => TrySetValue<NMSString0x100>(value);
	}

	public Vector3f SpawnPosition
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f SpawnFacing
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public GcSpaceStationSpawnData(long address) : base(address)
	{

	}
}
