using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAIShipDebugSpawnData : NMSTemplate
{
	public Vector3f Position
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f Facing
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f Up
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f FlightDir
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single Speed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single IgnitionDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single TakeOffDelay
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HoverHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single WarpOutTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean Wingman
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public NMSString0x80 SpecificModel
	{
		get => GetValue<NMSString0x80>();
		set => TrySetValue<NMSString0x80>(value);
	}

	public GcSeed Seed
	{
		get => GetValue<GcSeed>();
		set => TrySetValue<GcSeed>(value);
	}

	public GcAIShipDebugSpawnData(long address) : base(address)
	{

	}
}
