using Reloaded.ModHelper;
using System;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCreatureDebugSpawnData : NMSTemplate
{
	public Int32 CreatureIndex
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single InitialDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcCreatureDebugWaypoint> Waypoints
	{
		get => cache.GetOrAddValue(new VirtualList<GcCreatureDebugWaypoint>(address + GetOffset()));
		set => TrySetValue<GcCreatureDebugWaypoint>(value);
	}

	public libMBIN.NMS.GameComponents.GcCreatureDebugSpawnData.OnCompleteEnum OnComplete
	{
		get => GetValue<libMBIN.NMS.GameComponents.GcCreatureDebugSpawnData.OnCompleteEnum>();
		set => TrySetValue<libMBIN.NMS.GameComponents.GcCreatureDebugSpawnData.OnCompleteEnum>(value);
	}

	public Single SmoothTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 CurrentWaypoint
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Boolean ArrivedAtCurrentWaypoint
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public Single Timer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single SmoothTimer
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcCreatureDebugSpawnData(long address) : base(address)
	{

	}
}
