using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcShipAIPlanetPatrolData : NMSTemplate
{
	public NMSString0x10 Squad
	{
		get => GetValue<NMSString0x10>();
		set => TrySetValue<NMSString0x10>(value);
	}

	public Single PlayerOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PlayerFalloff
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WaypointDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PathSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AlongPathForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single ToPathForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single BrakeForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AlignForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcShipAIPlanetPatrolData(long address) : base(address)
	{

	}
}
