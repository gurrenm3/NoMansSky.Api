using Reloaded.ModHelper;
using System;
using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerExperienceSpawnTable : NMSTemplate
{
	public NMSString0x10 Event
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public libMBIN.NMS.GameComponents.GcPlayerExperienceSpawnTable.ExperienceSpawnTypeEnum ExperienceSpawnType
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcPlayerExperienceSpawnTable.ExperienceSpawnTypeEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcPlayerExperienceSpawnTable.ExperienceSpawnTypeEnum>(value);
	}

	public Single ResponseRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PerSpawnDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean Destroy
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public VirtualList<GcPlayerExperienceSpawnData> Spawns
	{
		get => cache.GetOrAddValue(new VirtualList<GcPlayerExperienceSpawnData>(address + GetOffset()));
		set => TrySetValue<GcPlayerExperienceSpawnData>(value);
	}

	public GcPlayerExperienceSpawnTable(long address) : base(address)
	{

	}
}
