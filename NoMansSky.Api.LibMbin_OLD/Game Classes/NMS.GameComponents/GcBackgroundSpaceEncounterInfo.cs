using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcBackgroundSpaceEncounterInfo : NMSTemplate
{
	public NMSString0x10 Id
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcBackgroundSpaceEncounterSpawnConditions SpawnConditions
	{
		get => GetValue<GcBackgroundSpaceEncounterSpawnConditions>();
		set => TrySetValue<GcBackgroundSpaceEncounterSpawnConditions>(value);
	}

	public Single SelectionWeighting
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpawnChance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SpawnDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinDuration
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DespawnDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPulseEncounterSpawnObject Encounter
	{
		get => GetValue<GcPulseEncounterSpawnObject>();
		set => TrySetValue<GcPulseEncounterSpawnObject>(value);
	}

	public GcBackgroundSpaceEncounterInfo(long address) : base(address)
	{

	}
}
