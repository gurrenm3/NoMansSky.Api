using Reloaded.ModHelper;
using System;

namespace NoMansSky.Api.LibMbin;

public unsafe class GcMechTargetSelectionWeightingSettings : NMSTemplate
{
	public Single ThreatWeightFactorBase
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FwdDirectionWeightFactorBase
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single DistanceWeightFactorBase
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VeryCloseDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VeryCloseDistanceWeightFactorExponent
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CloseDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single CloseDistanceWeightFactorExponent
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MidDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single MidDistanceWeightFactorExponent
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FarDistance
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single FarDistanceWeightFactorExponent
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public Single VeryFarDistanceWeightFactorExponent
	{
		get => GetValue<Single>();
		set => TrySetValue<Single>(value);
	}

	public GcMechTargetSelectionWeightingSettings(long address) : base(address)
	{

	}
}
