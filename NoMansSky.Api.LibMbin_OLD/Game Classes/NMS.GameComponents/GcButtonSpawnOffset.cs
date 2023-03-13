using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcButtonSpawnOffset : NMSTemplate
{
	public Single AngleMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AngleMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Offset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Spacing
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Facing
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 Count
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

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

	public GcButtonSpawnOffset(long address) : base(address)
	{

	}
}
