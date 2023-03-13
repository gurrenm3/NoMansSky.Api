using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPerformanceGuard : NMSTemplate
{
	public Single Radius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcEncounterComponentData Encounter
	{
		get => GetValue<GcEncounterComponentData>();
		set => TrySetValue<GcEncounterComponentData>(value);
	}

	public GcPerformanceGuard(long address) : base(address)
	{

	}
}
