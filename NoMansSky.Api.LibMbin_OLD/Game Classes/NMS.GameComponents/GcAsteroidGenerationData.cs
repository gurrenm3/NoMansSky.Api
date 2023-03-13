using Reloaded.ModHelper;
using System;
using libMBIN.NMS;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAsteroidGenerationData : NMSTemplate
{
	public Single Scale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f ScaleVariance
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Int32 Health
	{
		get => GetValue<Int32>();
		set => TrySetValue<Int32>(value);
	}

	public Single Spacing
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Vector2f NoiseRange
	{
		get => GetValue<Vector2f>();
		set => TrySetValue<Vector2f>(value);
	}

	public Single FadeRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single NoiseScale
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcAsteroidGenerationData(long address) : base(address)
	{

	}
}
