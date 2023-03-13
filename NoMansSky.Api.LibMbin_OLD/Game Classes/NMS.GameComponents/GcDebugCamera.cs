using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDebugCamera : NMSTemplate
{
	public Single BaseSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Smoothing
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcDebugCameraEntry> Waypoints
	{
		get => cache.GetOrAddValue(new VirtualList<GcDebugCameraEntry>(address + GetOffset()));
		set => TrySetValue<GcDebugCameraEntry>(value);
	}

	public Int32 CurrentWaypoint
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single CurrentWaypointProgress
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcDebugCamera(long address) : base(address)
	{

	}
}
