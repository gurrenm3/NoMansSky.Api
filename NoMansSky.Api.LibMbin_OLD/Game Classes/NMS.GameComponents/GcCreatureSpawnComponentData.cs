using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureSpawnComponentData : NMSTemplate
{
	public NMSString0x10 TriggerID
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public NMSString0x80 Model
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public NMSString0x10 Creature
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public GcCreatureTypes CreatureType
	{
		get => GetValue<GcCreatureTypes>();
		set => TrySetValue<GcCreatureTypes>(value);
	}

	public GcAISpaceshipTypes ShipAIOverride
	{
		get => GetValue<GcAISpaceshipTypes>();
		set => TrySetValue<GcAISpaceshipTypes>(value);
	}

	public GcSeed Seed
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public Int32 FunctionKey
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single TriggerDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Scale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StartTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StartTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean SpawnAlert
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public libMBIN.NMS.GameComponents.GcCreatureSpawnComponentData.SpawnerModeEnum SpawnerMode
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCreatureSpawnComponentData.SpawnerModeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCreatureSpawnComponentData.SpawnerModeEnum>(value);
	}

	public GcResourceElement SpecificModel
	{
		get => GetValue<GcResourceElement>();
		set => TrySetValue<GcResourceElement>(value);
	}

	public VirtualList<GcSpawnComponentOption> SpawnOptionList
	{
		get => cache.GetOrAddValue(new VirtualList<GcSpawnComponentOption>(address + GetOffset()));
		set => TrySetValue<GcSpawnComponentOption>(value);
	}

	public GcCreatureSpawnComponentData(long address) : base(address)
	{

	}
}
