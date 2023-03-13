using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcAlienPodComponentData : NMSTemplate
{
	public Single AgroRate
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AgroMovement
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AgroMovementRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AgroTorch
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AgroTorchRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AgroTorchFOV
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AgroThreshold
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AgroThresholdOffscreen
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AgroSpookValue
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AgroSpookTime
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AgroSpookTimeMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single AgroSpookTimeMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GlowIntensityMin
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GlowIntensityMax
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single InstaAgroDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GunfireAgro
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single GunfireAgroRange
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcAlienPodComponentData(long address) : base(address)
	{

	}
}
