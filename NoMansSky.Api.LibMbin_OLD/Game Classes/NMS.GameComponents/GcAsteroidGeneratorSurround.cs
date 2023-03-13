using Reloaded.ModHelper;
using System;
using libMBIN.NMS.GameComponents;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAsteroidGeneratorSurround : NMSTemplate
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

	public GcAsteroidGeneratorSurround(long address) : base(address)
	{

	}
}
