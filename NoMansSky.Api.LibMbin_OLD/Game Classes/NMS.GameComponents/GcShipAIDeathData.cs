using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcShipAIDeathData : NMSTemplate
{
	public Single DroneDeathTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneDeathForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneDeathBoomTotalTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DroneDeathOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 DroneNumDeathBooms
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single DroneDeathTimeout
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BrakeForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcShipAIDeathData(long address) : base(address)
	{

	}
}
