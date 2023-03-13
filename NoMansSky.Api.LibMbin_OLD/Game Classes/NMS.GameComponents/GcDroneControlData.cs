using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcDroneControlData : NMSTemplate
{
	public Single MaxSpeed
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single Strength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DirectionBrake
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MinHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxHeight
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MaxPitch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeightAdjustStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single HeightAdjustDownStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single LookStrength
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single StopTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RepelForce
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single RepelRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcDroneControlData(long address) : base(address)
	{

	}
}
