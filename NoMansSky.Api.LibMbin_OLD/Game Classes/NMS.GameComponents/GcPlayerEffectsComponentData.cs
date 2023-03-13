using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcPlayerEffectsComponentData : NMSTemplate
{
	public Single VehicleInOutTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleInOutEffectDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VehicleInOutDissolveDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcPlayerEffectsComponentData(long address) : base(address)
	{

	}
}
