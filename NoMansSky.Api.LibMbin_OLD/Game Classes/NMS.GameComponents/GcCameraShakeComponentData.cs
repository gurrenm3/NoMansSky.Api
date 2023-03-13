using Reloaded.ModHelper;
using System;
using System.Collections.Generic;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcCameraShakeComponentData : NMSTemplate
{
	public Single DangerRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public VirtualList<GcCameraShakeTriggerData> AnimTriggers
	{
		get => cache.GetOrAddValue(new VirtualList<GcCameraShakeTriggerData>(address + GetOffset()));
		set => TrySetValue<GcCameraShakeTriggerData>(value);
	}

	public GcCameraShakeComponentData(long address) : base(address)
	{

	}
}
