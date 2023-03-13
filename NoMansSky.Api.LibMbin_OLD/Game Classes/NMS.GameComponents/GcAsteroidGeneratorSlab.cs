using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAsteroidGeneratorSlab : NMSTemplate
{
	public GcAsteroidGeneratorAssignment Assignment
	{
		get => GetValue<GcAsteroidGeneratorAssignment>();
		set => TrySetValue<GcAsteroidGeneratorAssignment>(value);
	}

	public Vector3f Rotation
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Vector3f Scale
	{
		get => GetValue<Vector3f>();
		set => TrySetValue<Vector3f>(value);
	}

	public Single NoiseOffset
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NoiseScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NoiseApply
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcAsteroidGeneratorSlab(long address) : base(address)
	{

	}
}
