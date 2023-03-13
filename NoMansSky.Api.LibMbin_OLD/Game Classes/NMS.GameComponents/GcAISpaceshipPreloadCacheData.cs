using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAISpaceshipPreloadCacheData : NMSTemplate
{
	public GcRealityCommonFactions Faction
	{
		get => GetValue<GcRealityCommonFactions>();
		set => TrySetValue<GcRealityCommonFactions>(value);
	}

	public GcAISpaceshipRoles ShipRole
	{
		get => GetValue<GcAISpaceshipRoles>();
		set => TrySetValue<GcAISpaceshipRoles>(value);
	}

	public GcSpaceshipClasses ShipClass
	{
		get => GetValue<GcSpaceshipClasses>();
		set => TrySetValue<GcSpaceshipClasses>(value);
	}

	public GcFrigateClass FrigateClass
	{
		get => GetValue<GcFrigateClass>();
		set => TrySetValue<GcFrigateClass>(value);
	}

	public GcSeed Seed
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public GcAISpaceshipPreloadCacheData(long address) : base(address)
	{

	}
}
