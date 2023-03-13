using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAsteroidGeneratorRing : NMSTemplate
{
	public GcAsteroidGeneratorAssignment Assignment
	{
		get => GetValue<GcAsteroidGeneratorAssignment>();
		set => TrySetValue<GcAsteroidGeneratorAssignment>(value);
	}

	public Single LowerRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single UpperRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PushRadius
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Int32 OffBalance
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Vector3f Rotation
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single USpread
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single PushAmount
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Boolean FlipPush
	{
		get => GetValue<Boolean>();
		set => TrySetValue<Boolean>(value);
	}

	public GcAsteroidGeneratorRing(long address) : base(address)
	{

	}
}
