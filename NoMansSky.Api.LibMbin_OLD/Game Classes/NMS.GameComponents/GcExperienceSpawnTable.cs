using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcExperienceSpawnTable : NMSTemplate
{
	public VirtualList<GcAIShipSpawnData> FlybySpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcAIShipSpawnData>(address + GetOffset()));
		set => TrySetValue<GcAIShipSpawnData>(value);
	}

	public VirtualList<GcAIShipSpawnData> OutpostSpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcAIShipSpawnData>(address + GetOffset()));
		set => TrySetValue<GcAIShipSpawnData>(value);
	}

	public VirtualList<GcAIShipSpawnData> SpaceFlybySpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcAIShipSpawnData>(address + GetOffset()));
		set => TrySetValue<GcAIShipSpawnData>(value);
	}

	public VirtualList<GcAIShipSpawnData> MiningFlybySpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcAIShipSpawnData>(address + GetOffset()));
		set => TrySetValue<GcAIShipSpawnData>(value);
	}

	public VirtualList<GcAIShipSpawnData> PirateSpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcAIShipSpawnData>(address + GetOffset()));
		set => TrySetValue<GcAIShipSpawnData>(value);
	}

	public VirtualList<GcAIShipSpawnData> PlanetaryPirateFlybySpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcAIShipSpawnData>(address + GetOffset()));
		set => TrySetValue<GcAIShipSpawnData>(value);
	}

	public VirtualList<GcAIShipSpawnData> PlanetaryPirateRaidSpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcAIShipSpawnData>(address + GetOffset()));
		set => TrySetValue<GcAIShipSpawnData>(value);
	}

	public VirtualList<GcAIShipSpawnData> PirateBattleSpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcAIShipSpawnData>(address + GetOffset()));
		set => TrySetValue<GcAIShipSpawnData>(value);
	}

	public VirtualList<GcAIShipSpawnData> PoliceSpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcAIShipSpawnData>(address + GetOffset()));
		set => TrySetValue<GcAIShipSpawnData>(value);
	}

	public VirtualList<GcAIShipSpawnData> TraderSpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcAIShipSpawnData>(address + GetOffset()));
		set => TrySetValue<GcAIShipSpawnData>(value);
	}

	public VirtualList<GcAIShipSpawnData> AmbientSpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcAIShipSpawnData>(address + GetOffset()));
		set => TrySetValue<GcAIShipSpawnData>(value);
	}

	public VirtualList<GcAIShipSpawnData> BattleSpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcAIShipSpawnData>(address + GetOffset()));
		set => TrySetValue<GcAIShipSpawnData>(value);
	}

	public VirtualList<GcAIShipSpawnData> AbandonedFreighterSpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcAIShipSpawnData>(address + GetOffset()));
		set => TrySetValue<GcAIShipSpawnData>(value);
	}

	public VirtualList<GcAIShipSpawnData> BattleInitialStandardSpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcAIShipSpawnData>(address + GetOffset()));
		set => TrySetValue<GcAIShipSpawnData>(value);
	}

	public VirtualList<GcAIShipSpawnData> BattleInitialPirateSpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcAIShipSpawnData>(address + GetOffset()));
		set => TrySetValue<GcAIShipSpawnData>(value);
	}

	public VirtualList<GcAIShipSpawnData> BattleSecondaryPirateSpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcAIShipSpawnData>(address + GetOffset()));
		set => TrySetValue<GcAIShipSpawnData>(value);
	}

	public VirtualList<GcBountySpawnInfo> PirateBountySpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcBountySpawnInfo>(address + GetOffset()));
		set => TrySetValue<GcBountySpawnInfo>(value);
	}

	public VirtualList<GcPulseEncounterInfo> PulseEncounters
	{
		get => cache.GetOrAddValue(new VirtualList<GcPulseEncounterInfo>(address + GetOffset()));
		set => TrySetValue<GcPulseEncounterInfo>(value);
	}

	public VirtualList<GcBackgroundSpaceEncounterInfo> BackgroundSpaceEncounters
	{
		get => cache.GetOrAddValue(new VirtualList<GcBackgroundSpaceEncounterInfo>(address + GetOffset()));
		set => TrySetValue<GcBackgroundSpaceEncounterInfo>(value);
	}

	public VirtualList<GcPlayerExperienceSpawnTable> CreatureSpawnTable
	{
		get => cache.GetOrAddValue(new VirtualList<GcPlayerExperienceSpawnTable>(address + GetOffset()));
		set => TrySetValue<GcPlayerExperienceSpawnTable>(value);
	}

	public VirtualList<GcPlayerExperienceSpawnArchetypeData> CreatureSpawnArchetypes
	{
		get => cache.GetOrAddValue(new VirtualList<GcPlayerExperienceSpawnArchetypeData>(address + GetOffset()));
		set => TrySetValue<GcPlayerExperienceSpawnArchetypeData>(value);
	}

	public GcPlayerExperienceAsteroidCreatureSpawnTable AsteroidCreatureSpawns
	{
		get => GetValue<GcPlayerExperienceAsteroidCreatureSpawnTable>();
		set => TrySetValue<GcPlayerExperienceAsteroidCreatureSpawnTable>(value);
	}

	public VirtualList<GcAIShipSpawnData> FrigateFlybySpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcAIShipSpawnData>(address + GetOffset()));
		set => TrySetValue<GcAIShipSpawnData>(value);
	}

	public VirtualArray<GcSentinelSpawnSequenceGroupList> WantedLevelSpawns
	{
		get => cache.GetOrAddValue(new VirtualArray<GcSentinelSpawnSequenceGroupList>(address + GetOffset(), 6));
		set => TrySetValue<GcSentinelSpawnSequenceGroupList>(value);
	}

	public VirtualArray<GcSentinelSpawnSequenceGroupList> EncounterSpawns
	{
		get => cache.GetOrAddValue(new VirtualArray<GcSentinelSpawnSequenceGroupList>(address + GetOffset(), 7));
		set => TrySetValue<GcSentinelSpawnSequenceGroupList>(value);
	}

	public VirtualList<GcSentinelEncounterOverride> EncounterOverrides
	{
		get => cache.GetOrAddValue(new VirtualList<GcSentinelEncounterOverride>(address + GetOffset()));
		set => TrySetValue<GcSentinelEncounterOverride>(value);
	}

	public GcSentinelWaveGroup SummonerSpawns
	{
		get => GetValue<GcSentinelWaveGroup>();
		set => TrySetValue<GcSentinelWaveGroup>(value);
	}

	public VirtualList<GcSentinelSpawnNamedSequence> SentinelSequences
	{
		get => cache.GetOrAddValue(new VirtualList<GcSentinelSpawnNamedSequence>(address + GetOffset()));
		set => TrySetValue<GcSentinelSpawnNamedSequence>(value);
	}

	public VirtualList<GcSentinelSpawnWave> SentinelSpawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcSentinelSpawnWave>(address + GetOffset()));
		set => TrySetValue<GcSentinelSpawnWave>(value);
	}

	public GcExperienceSpawnTable(long address) : base(address)
	{

	}
}
